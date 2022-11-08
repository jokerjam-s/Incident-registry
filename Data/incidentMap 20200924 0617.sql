--
-- Скрипт сгенерирован Devart dbForge Studio 2019 for SQL Server, Версия 5.8.127.0
-- Домашняя страница продукта: http://www.devart.com/ru/dbforge/sql/studio
-- Дата скрипта: 24.09.2020 6:17:35
-- Версия сервера: 15.00.2070
--


SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

USE incidentMap
GO

IF DB_NAME() <> N'incidentMap' SET NOEXEC ON
GO

--
-- Создать таблицу [dbo].[users]
--
PRINT (N'Создать таблицу [dbo].[users]')
GO
CREATE TABLE dbo.users (
  id_us int IDENTITY,
  usLogin varchar(250) NULL,
  usPass varchar(250) NULL,
  id_role int NULL,
  usFio varchar(50) NULL,
  usRang varchar(50) NULL,
  CONSTRAINT PK_users PRIMARY KEY CLUSTERED (id_us)
)
ON [PRIMARY]
GO

--
-- Создать индекс [IX_Relationship1] для объекта типа таблица [dbo].[users]
--
PRINT (N'Создать индекс [IX_Relationship1] для объекта типа таблица [dbo].[users]')
GO
CREATE INDEX IX_Relationship1
  ON dbo.users (id_role)
  ON [PRIMARY]
GO

SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO

--
-- Создать процедуру [dbo].[getUser]
--
GO
PRINT (N'Создать процедуру [dbo].[getUser]')
GO
CREATE OR ALTER PROCEDURE dbo.getUser 
  @login VARCHAR(50),
  @pass VARCHAR(50)
AS
  SELECT
    u.id_us
   ,u.id_role
   ,u.usFio
   ,u.usRang
  FROM users u
  WHERE 
    u.usLogin = @login AND
    u.usPass = @pass
GO

--
-- Создать таблицу [dbo].[roles]
--
PRINT (N'Создать таблицу [dbo].[roles]')
GO
CREATE TABLE dbo.roles (
  id_role int IDENTITY,
  rlName varchar(20) NULL,
  CONSTRAINT PK_roles PRIMARY KEY CLUSTERED (id_role)
)
ON [PRIMARY]
GO

--
-- Создать таблицу [dbo].[region]
--
PRINT (N'Создать таблицу [dbo].[region]')
GO
CREATE TABLE dbo.region (
  id_rg int IDENTITY,
  rgName varchar(50) NULL,
  rgRovd varchar(50) NULL,
  CONSTRAINT PK_region PRIMARY KEY CLUSTERED (id_rg)
)
ON [PRIMARY]
GO

--
-- Создать таблицу [dbo].[options]
--
PRINT (N'Создать таблицу [dbo].[options]')
GO
CREATE TABLE dbo.options (
  department varchar(50) NULL,
  place varchar(50) NULL,
  beginX decimal(18, 10) NULL,
  beginY decimal(18, 10) NULL,
  usedMap int NULL
)
ON [PRIMARY]
GO

--
-- Создать процедуру [dbo].[setOptions]
--
GO
PRINT (N'Создать процедуру [dbo].[setOptions]')
GO
CREATE OR ALTER PROCEDURE dbo.setOptions
  @department VARCHAR(50), 
  @place VARCHAR(50), 
  @beginX DECIMAL(18,10), 
  @beginY DECIMAL(18,10), 
  @usedMap INT
AS 
  DECLARE @recCnt INT

  SELECT @recCnt = COUNT(*) FROM options

  IF @recCnt > 0 BEGIN  

  	UPDATE options 
    SET department = @department
       ,place = @place
       ,beginX = @beginX
       ,beginY = @beginY
       ,usedMap = @usedMap;

  END ELSE BEGIN

    INSERT INTO options (department, place, beginX, beginY, usedMap)
    VALUES (@department, @place, @beginX, @beginY, @usedMap);

  END

  
GO

--
-- Создать процедуру [dbo].[getOptions]
--
GO
PRINT (N'Создать процедуру [dbo].[getOptions]')
GO
CREATE OR ALTER PROCEDURE dbo.getOptions
AS
  SELECT
    o.department
   ,o.place
   ,o.beginX
   ,o.beginY
   ,o.usedMap
  FROM options o 
GO

--
-- Создать таблицу [dbo].[kind]
--
PRINT (N'Создать таблицу [dbo].[kind]')
GO
CREATE TABLE dbo.kind (
  id_kn int IDENTITY,
  knName varchar(50) NULL,
  CONSTRAINT PK_kind PRIMARY KEY CLUSTERED (id_kn)
)
ON [PRIMARY]
GO

--
-- Создать таблицу [dbo].[incident]
--
PRINT (N'Создать таблицу [dbo].[incident]')
GO
CREATE TABLE dbo.incident (
  id_inc int IDENTITY,
  ncDate date NULL,
  ncSubj varchar(100) NULL,
  ncNotes varchar(max) NULL,
  closeDate date NULL,
  ncClosed bit NULL,
  ncVerdict varchar(max) NULL,
  ncAdres varchar(250) NULL,
  pointX decimal(18, 10) NULL,
  pointY decimal(18, 10) NULL,
  id_kn int NULL,
  id_hd int NULL,
  id_us int NULL,
  id_rg int NULL,
  CONSTRAINT PK_incident PRIMARY KEY CLUSTERED (id_inc)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

--
-- Создать индекс [IX_Relationship3] для объекта типа таблица [dbo].[incident]
--
PRINT (N'Создать индекс [IX_Relationship3] для объекта типа таблица [dbo].[incident]')
GO
CREATE INDEX IX_Relationship3
  ON dbo.incident (id_kn)
  ON [PRIMARY]
GO

--
-- Создать индекс [IX_Relationship4] для объекта типа таблица [dbo].[incident]
--
PRINT (N'Создать индекс [IX_Relationship4] для объекта типа таблица [dbo].[incident]')
GO
CREATE INDEX IX_Relationship4
  ON dbo.incident (id_hd)
  ON [PRIMARY]
GO

--
-- Создать процедуру [dbo].[incidentDel]
--
GO
PRINT (N'Создать процедуру [dbo].[incidentDel]')
GO
CREATE OR ALTER PROCEDURE dbo.incidentDel
  @id_inc INT
AS 
  DELETE FROM incident WHERE id_inc = @id_inc
GO

--
-- Создать процедуру [dbo].[incidentClose]
--
GO
PRINT (N'Создать процедуру [dbo].[incidentClose]')
GO
CREATE OR ALTER PROCEDURE dbo.incidentClose
  @closeDate DATE,
  @ncVerdict VARCHAR(MAX),
  @id_inc INT
AS 
  UPDATE incident 
  SET closeDate = @closeDate
     ,ncVerdict = @ncVerdict 
     ,ncClosed = 1
  WHERE id_inc = @id_inc;
GO

--
-- Создать процедуру [dbo].[identIns]
--
GO
PRINT (N'Создать процедуру [dbo].[identIns]')
GO
CREATE OR ALTER PROCEDURE dbo.identIns
  @ncDate DATE, 
  @ncSubj VARCHAR(100), 
  @ncNotes VARCHAR(MAX), 
  @ncAdres VARCHAR(250), 
  @pointX DECIMAL(18,10), 
  @pointY DECIMAL(18,10), 
  @id_kn INT, 
  @id_hd INT, 
  @id_us INT, 
  @id_rg INT
AS 
  INSERT INTO incident (ncDate, ncSubj, ncNotes, ncAdres, pointX, pointY, id_kn, id_hd, id_us, id_rg, ncClosed)
  VALUES (@ncDate, @ncSubj, @ncNotes, @ncAdres, @pointX, @pointY, @id_kn, @id_hd, @id_us, @id_rg, 0);
GO

--
-- Создать таблицу [dbo].[hards]
--
PRINT (N'Создать таблицу [dbo].[hards]')
GO
CREATE TABLE dbo.hards (
  id_hd int IDENTITY,
  hdName varchar(50) NULL,
  hdImage int NULL,
  CONSTRAINT PK_hards PRIMARY KEY CLUSTERED (id_hd)
)
ON [PRIMARY]
GO

--
-- Создать процедуру [dbo].[getIncView]
--
GO
PRINT (N'Создать процедуру [dbo].[getIncView]')
GO
CREATE OR ALTER PROCEDURE dbo.getIncView
  -- @moe - режим выборки 1-произошедшие, 2-все открытые, 3-завершенные
  @dtDate DATE,
  @mode INT,  
  @id_kn INT, 
  @id_rg INT
AS

  IF @mode = 1
  BEGIN
    IF @id_kn = 0 AND @id_rg = 0
      SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.ncDate = @dtDate 
    
    IF @id_kn > 0 AND @id_rg = 0
      SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.ncDate = @dtDate AND i.id_kn = @id_kn


    IF @id_kn = 0 AND @id_rg > 0
      SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.ncDate = @dtDate AND i.id_rg = @id_rg


    IF @id_kn > 0 AND @id_rg > 0
      SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.ncDate = @dtDate AND i.id_kn = @id_kn AND i.id_rg = @id_rg


  END ELSE IF @mode = 2
  BEGIN
    IF @id_kn = 0 AND @id_rg = 0
    	SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage 
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.ncDate >= @dtDate AND (@dtDate <= i.closeDate OR i.closeDate IS NULL) 

    IF @id_kn > 0 AND @id_rg = 0
    	SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage 
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.ncDate >= @dtDate AND (@dtDate <= i.closeDate OR i.closeDate IS NULL) AND i.id_kn = @id_kn


    IF @id_kn = 0 AND @id_rg > 0
    	SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage 
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.ncDate >= @dtDate AND (@dtDate <= i.closeDate OR i.closeDate IS NULL) AND i.id_rg = @id_rg

    IF @id_kn > 0 AND @id_rg > 0
    	SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage 
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.ncDate >= @dtDate AND (@dtDate <= i.closeDate OR i.closeDate IS NULL) AND i.id_kn = @id_kn AND i.id_rg = @id_rg

  END ELSE
  BEGIN
    IF @id_kn = 0 AND @id_rg = 0
    	SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage 
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.closeDate = @dtDate


    IF @id_kn > 0 AND @id_rg = 0
    	SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage 
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.closeDate = @dtDate AND i.id_kn = @id_kn

    IF @id_kn = 0 AND @id_rg > 0
    	SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage 
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.closeDate = @dtDate AND i.id_rg = @id_rg

    IF @id_kn > 0 AND @id_rg > 0
    	SELECT
        i.id_inc,i.ncDate,i.ncSubj,i.ncNotes,i.closeDate,i.ncClosed,i.ncVerdict,i.ncAdres,i.pointX,i.pointY,i.id_kn, k.knName,i.id_hd, h.hdName, h.hdImage 
       ,i.id_us, u.usFio, u.usRang,i.id_rg, r.rgName
      FROM incident i
        LEFT JOIN hards h ON i.id_hd = h.id_hd
        LEFT JOIN kind k ON i.id_kn = k.id_kn
        LEFT JOIN users u ON i.id_us = u.id_us
        LEFT JOIN region r ON i.id_rg = r.id_rg
      WHERE i.closeDate = @dtDate AND i.id_kn = @id_kn AND i.id_rg = @id_rg

  END


GO

--
-- Создать таблицу [dbo].[flags]
--
PRINT (N'Создать таблицу [dbo].[flags]')
GO
CREATE TABLE dbo.flags (
  id_fl int IDENTITY,
  flName varchar(50) NULL,
  CONSTRAINT PK_flags_id_fl PRIMARY KEY CLUSTERED (id_fl)
)
ON [PRIMARY]
GO

--
-- Создать таблицу [dbo].[regBorder]
--
PRINT (N'Создать таблицу [dbo].[regBorder]')
GO
CREATE TABLE dbo.regBorder (
  id_rg int NULL,
  pointX decimal(18, 10) NULL,
  pointY decimal(18, 10) NULL
)
ON [PRIMARY]
GO

--
-- Создать индекс [IX_Relationship2] для объекта типа таблица [dbo].[regBorder]
--
PRINT (N'Создать индекс [IX_Relationship2] для объекта типа таблица [dbo].[regBorder]')
GO
CREATE INDEX IX_Relationship2
  ON dbo.regBorder (id_rg)
  ON [PRIMARY]
GO
-- 
-- Вывод данных для таблицы flags
--
PRINT (N'Вывод данных для таблицы flags')
SET IDENTITY_INSERT dbo.flags ON
GO
INSERT dbo.flags(id_fl, flName) VALUES (1, 'Синий')
INSERT dbo.flags(id_fl, flName) VALUES (2, 'Оранжевый')
INSERT dbo.flags(id_fl, flName) VALUES (3, 'Красный')
GO
SET IDENTITY_INSERT dbo.flags OFF
GO
-- 
-- Вывод данных для таблицы hards
--
PRINT (N'Вывод данных для таблицы hards')
SET IDENTITY_INSERT dbo.hards ON
GO
INSERT dbo.hards(id_hd, hdName, hdImage) VALUES (1, 'Легкая', 1)
INSERT dbo.hards(id_hd, hdName, hdImage) VALUES (2, 'Средняя', 2)
INSERT dbo.hards(id_hd, hdName, hdImage) VALUES (3, 'Тяжкая', 3)
GO
SET IDENTITY_INSERT dbo.hards OFF
GO
-- 
-- Вывод данных для таблицы incident
--
PRINT (N'Вывод данных для таблицы incident')
SET IDENTITY_INSERT dbo.incident ON
GO
INSERT dbo.incident(id_inc, ncDate, ncSubj, ncNotes, closeDate, ncClosed, ncVerdict, ncAdres, pointX, pointY, id_kn, id_hd, id_us, id_rg) VALUES (2, '2020-09-24', 'ДТП', 'Нарушение ПДД п.26.1.1 - 26.1.3', NULL, CONVERT(bit, 'False'), NULL, 'перекресток по ул. Полежаева, на пересечении с ул. Ккапуцинов', 52.9186421089, 30.9185321389, 1, 2, 1, 2)
INSERT dbo.incident(id_inc, ncDate, ncSubj, ncNotes, closeDate, ncClosed, ncVerdict, ncAdres, pointX, pointY, id_kn, id_hd, id_us, id_rg) VALUES (3, '2020-09-24', 'Кража', 'Украден кошелек с крупной суммой денег', '2019-10-07', CONVERT(bit, 'True'), 'преступник задержан', 'магазин №12', 52.9151790947, 30.9134573995, 1, 1, 1, 1)
INSERT dbo.incident(id_inc, ncDate, ncSubj, ncNotes, closeDate, ncClosed, ncVerdict, ncAdres, pointX, pointY, id_kn, id_hd, id_us, id_rg) VALUES (5, '2020-09-24', 'Хулиганское нападение', 'разбито стекло магазина', NULL, CONVERT(bit, 'False'), NULL, '', 52.9155811818, 30.9102494775, 1, 1, 1, 1)
INSERT dbo.incident(id_inc, ncDate, ncSubj, ncNotes, closeDate, ncClosed, ncVerdict, ncAdres, pointX, pointY, id_kn, id_hd, id_us, id_rg) VALUES (6, '2020-09-23', 'Драка', 'Драка между родственниками в состоянии алкогольного опъянения', NULL, CONVERT(bit, 'False'), NULL, '', 52.9168728348, 30.9138536453, 6, 1, 2, 1)
GO
SET IDENTITY_INSERT dbo.incident OFF
GO
-- 
-- Вывод данных для таблицы kind
--
PRINT (N'Вывод данных для таблицы kind')
SET IDENTITY_INSERT dbo.kind ON
GO
INSERT dbo.kind(id_kn, knName) VALUES (1, 'ДТП')
INSERT dbo.kind(id_kn, knName) VALUES (2, 'Кража')
INSERT dbo.kind(id_kn, knName) VALUES (3, 'Грабеж')
INSERT dbo.kind(id_kn, knName) VALUES (4, 'Мошенничество')
INSERT dbo.kind(id_kn, knName) VALUES (5, 'Убийство')
INSERT dbo.kind(id_kn, knName) VALUES (6, 'Семейно-бытовой конфликт')
INSERT dbo.kind(id_kn, knName) VALUES (7, 'Хулиганство')
GO
SET IDENTITY_INSERT dbo.kind OFF
GO
-- 
-- Вывод данных для таблицы options
--
PRINT (N'Вывод данных для таблицы options')
INSERT dbo.options VALUES ('РОВД №23 Центрального р-на', 'Минск', 52.9153217712, 30.9129531442, 0)
GO
-- 
-- Вывод данных для таблицы regBorder
--
PRINT (N'Вывод данных для таблицы regBorder')
-- Таблица incidentMap.dbo.regBorder не содержит данных
-- 
-- Вывод данных для таблицы region
--
PRINT (N'Вывод данных для таблицы region')
SET IDENTITY_INSERT dbo.region ON
GO
INSERT dbo.region(id_rg, rgName, rgRovd) VALUES (1, 'Северный ', 'РОВД №1')
INSERT dbo.region(id_rg, rgName, rgRovd) VALUES (2, 'Юго-западный', 'РОВД №2')
INSERT dbo.region(id_rg, rgName, rgRovd) VALUES (3, 'Восточный ', 'РОВД №3')
INSERT dbo.region(id_rg, rgName, rgRovd) VALUES (4, 'Центральный', 'РОВД №4')
GO
SET IDENTITY_INSERT dbo.region OFF
GO
-- 
-- Вывод данных для таблицы roles
--
PRINT (N'Вывод данных для таблицы roles')
SET IDENTITY_INSERT dbo.roles ON
GO
INSERT dbo.roles(id_role, rlName) VALUES (1, 'Администратор')
INSERT dbo.roles(id_role, rlName) VALUES (2, 'Дежурный')
GO
SET IDENTITY_INSERT dbo.roles OFF
GO
-- 
-- Вывод данных для таблицы users
--
PRINT (N'Вывод данных для таблицы users')
SET IDENTITY_INSERT dbo.users ON
GO
INSERT dbo.users(id_us, usLogin, usPass, id_role, usFio, usRang) VALUES (1, 'korj', '123456', 1, 'Коржов Н.Т.', 'к-н')
INSERT dbo.users(id_us, usLogin, usPass, id_role, usFio, usRang) VALUES (2, 'pono', '123456', 2, 'Пономарев Е.И.', 'л-т ')
INSERT dbo.users(id_us, usLogin, usPass, id_role, usFio, usRang) VALUES (3, 'sinitca', '123456', 2, 'Синицина Е.О.', 'мл л-т')
GO
SET IDENTITY_INSERT dbo.users OFF
GO

USE incidentMap
GO

IF DB_NAME() <> N'incidentMap' SET NOEXEC ON
GO

--
-- Создать внешний ключ [Relationship1] для объекта типа таблица [dbo].[users]
--
PRINT (N'Создать внешний ключ [Relationship1] для объекта типа таблица [dbo].[users]')
GO
ALTER TABLE dbo.users
  ADD CONSTRAINT Relationship1 FOREIGN KEY (id_role) REFERENCES dbo.roles (id_role)
GO

--
-- Создать внешний ключ [FK_incident_region_id_rg] для объекта типа таблица [dbo].[incident]
--
PRINT (N'Создать внешний ключ [FK_incident_region_id_rg] для объекта типа таблица [dbo].[incident]')
GO
ALTER TABLE dbo.incident
  ADD CONSTRAINT FK_incident_region_id_rg FOREIGN KEY (id_rg) REFERENCES dbo.region (id_rg)
GO

--
-- Создать внешний ключ [FK_incident_users_id_us] для объекта типа таблица [dbo].[incident]
--
PRINT (N'Создать внешний ключ [FK_incident_users_id_us] для объекта типа таблица [dbo].[incident]')
GO
ALTER TABLE dbo.incident
  ADD CONSTRAINT FK_incident_users_id_us FOREIGN KEY (id_us) REFERENCES dbo.users (id_us)
GO

--
-- Создать внешний ключ [Relationship3] для объекта типа таблица [dbo].[incident]
--
PRINT (N'Создать внешний ключ [Relationship3] для объекта типа таблица [dbo].[incident]')
GO
ALTER TABLE dbo.incident
  ADD CONSTRAINT Relationship3 FOREIGN KEY (id_kn) REFERENCES dbo.kind (id_kn)
GO

--
-- Создать внешний ключ [Relationship4] для объекта типа таблица [dbo].[incident]
--
PRINT (N'Создать внешний ключ [Relationship4] для объекта типа таблица [dbo].[incident]')
GO
ALTER TABLE dbo.incident
  ADD CONSTRAINT Relationship4 FOREIGN KEY (id_hd) REFERENCES dbo.hards (id_hd)
GO

--
-- Создать внешний ключ [Relationship2] для объекта типа таблица [dbo].[regBorder]
--
PRINT (N'Создать внешний ключ [Relationship2] для объекта типа таблица [dbo].[regBorder]')
GO
ALTER TABLE dbo.regBorder
  ADD CONSTRAINT Relationship2 FOREIGN KEY (id_rg) REFERENCES dbo.region (id_rg)
GO
SET NOEXEC OFF
GO