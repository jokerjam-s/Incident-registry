/*
Created: 01.10.2019
Modified: 04.10.2019
Model: incidentMap
Database: MS SQL Server 2017
*/


-- Create tables section -------------------------------------------------

-- Table users

CREATE TABLE [users]
(
 [id_us] Int IDENTITY NOT NULL,
 [usLogin] Varchar(250) NULL,
 [usPass] Varchar(250) NULL,
 [id_role] Int NULL
)
go

-- Create indexes for table users

CREATE INDEX [IX_Relationship1] ON [users] ([id_role])
go

-- Add keys for table users

ALTER TABLE [users] ADD CONSTRAINT [PK_users] PRIMARY KEY ([id_us])
go

-- Table incident

CREATE TABLE [incident]
(
 [id_inc] Int IDENTITY NOT NULL,
 [ncDate] Date NULL,
 [ncSubj] Varchar(1) NULL,
 [ncNotes] Varchar(max) NULL,
 [ncClosed] Bit NULL,
 [ncVerdict] Varchar(max) NULL,
 [pointX] Decimal(18,10) NULL,
 [pointY] Decimal(18,10) NULL,
 [id_kn] Int NULL,
 [id_hd] Int NULL
)
go

-- Create indexes for table incident

CREATE INDEX [IX_Relationship3] ON [incident] ([id_kn])
go

CREATE INDEX [IX_Relationship4] ON [incident] ([id_hd])
go

-- Add keys for table incident

ALTER TABLE [incident] ADD CONSTRAINT [PK_incident] PRIMARY KEY ([id_inc])
go

-- Table region

CREATE TABLE [region]
(
 [id_rg] Int IDENTITY NOT NULL,
 [rgName] Varchar(50) NULL
)
go

-- Add keys for table region

ALTER TABLE [region] ADD CONSTRAINT [PK_region] PRIMARY KEY ([id_rg])
go

-- Table kind

CREATE TABLE [kind]
(
 [id_kn] Int IDENTITY NOT NULL,
 [knName] Varchar(50) NULL
)
go

-- Add keys for table kind

ALTER TABLE [kind] ADD CONSTRAINT [PK_kind] PRIMARY KEY ([id_kn])
go

-- Table hards

CREATE TABLE [hards]
(
 [id_hd] Int IDENTITY NOT NULL,
 [hdName] Varchar(50) NULL
)
go

-- Add keys for table hards

ALTER TABLE [hards] ADD CONSTRAINT [PK_hards] PRIMARY KEY ([id_hd])
go

-- Table roles

CREATE TABLE [roles]
(
 [id_role] Int IDENTITY NOT NULL,
 [rlName] Varchar(20) NULL
)
go

-- Add keys for table roles

ALTER TABLE [roles] ADD CONSTRAINT [PK_roles] PRIMARY KEY ([id_role])
go

-- Table regBorder

CREATE TABLE [regBorder]
(
 [id_rg] Int NULL,
 [pointX] Decimal(18,10) NULL,
 [pointY] Decimal(18,10) NULL
)
go

-- Create indexes for table regBorder

CREATE INDEX [IX_Relationship2] ON [regBorder] ([id_rg])
go

-- Table options

CREATE TABLE [options]
(
 [department] Varchar(50) NULL,
 [place] Varchar(50) NULL,
 [beginX] Decimal(18,0) NULL,
 [beginY] Decimal(18,0) NULL,
 [usedMap] Int NULL
)
go

-- Create foreign keys (relationships) section ------------------------------------------------- 


ALTER TABLE [users] ADD CONSTRAINT [Relationship1] FOREIGN KEY ([id_role]) REFERENCES [roles] ([id_role]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [regBorder] ADD CONSTRAINT [Relationship2] FOREIGN KEY ([id_rg]) REFERENCES [region] ([id_rg]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [incident] ADD CONSTRAINT [Relationship3] FOREIGN KEY ([id_kn]) REFERENCES [kind] ([id_kn]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [incident] ADD CONSTRAINT [Relationship4] FOREIGN KEY ([id_hd]) REFERENCES [hards] ([id_hd]) ON UPDATE NO ACTION ON DELETE NO ACTION
go




