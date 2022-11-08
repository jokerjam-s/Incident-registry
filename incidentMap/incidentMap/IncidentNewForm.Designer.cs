namespace incidentMap
{
    partial class IncidentNewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txTitle = new System.Windows.Forms.TextBox();
            this.txNotes = new System.Windows.Forms.TextBox();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.cbHard = new System.Windows.Forms.ComboBox();
            this.txAdr = new System.Windows.Forms.TextBox();
            this.nPointX = new System.Windows.Forms.NumericUpDown();
            this.nPointY = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.regionDataSet = new incidentMap.regionDataSet();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionTableAdapter = new incidentMap.regionDataSetTableAdapters.regionTableAdapter();
            this.kindDataSet = new incidentMap.kindDataSet();
            this.kindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindTableAdapter = new incidentMap.kindDataSetTableAdapters.kindTableAdapter();
            this.hardsDataSet = new incidentMap.hardsDataSet();
            this.hardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hardsTableAdapter = new incidentMap.hardsDataSetTableAdapters.hardsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHard);
            this.groupBox1.Controls.Add(this.cbKind);
            this.groupBox1.Controls.Add(this.txNotes);
            this.groupBox1.Controls.Add(this.txTitle);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры проишествия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заголовок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вид";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тяжесть";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Широта";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRegion);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nPointY);
            this.groupBox2.Controls.Add(this.nPointX);
            this.groupBox2.Controls.Add(this.txAdr);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(377, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Место";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Долгота";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(73, 22);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(155, 20);
            this.dtDate.TabIndex = 5;
            // 
            // txTitle
            // 
            this.txTitle.Location = new System.Drawing.Point(73, 48);
            this.txTitle.MaxLength = 100;
            this.txTitle.Name = "txTitle";
            this.txTitle.Size = new System.Drawing.Size(280, 20);
            this.txTitle.TabIndex = 6;
            // 
            // txNotes
            // 
            this.txNotes.Location = new System.Drawing.Point(73, 74);
            this.txNotes.Multiline = true;
            this.txNotes.Name = "txNotes";
            this.txNotes.Size = new System.Drawing.Size(280, 73);
            this.txNotes.TabIndex = 7;
            // 
            // cbKind
            // 
            this.cbKind.DataSource = this.kindBindingSource;
            this.cbKind.DisplayMember = "knName";
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Location = new System.Drawing.Point(73, 153);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(280, 21);
            this.cbKind.TabIndex = 8;
            this.cbKind.ValueMember = "id_kn";
            // 
            // cbHard
            // 
            this.cbHard.DataSource = this.hardsBindingSource;
            this.cbHard.DisplayMember = "hdName";
            this.cbHard.FormattingEnabled = true;
            this.cbHard.Location = new System.Drawing.Point(73, 180);
            this.cbHard.Name = "cbHard";
            this.cbHard.Size = new System.Drawing.Size(280, 21);
            this.cbHard.TabIndex = 9;
            this.cbHard.ValueMember = "id_hd";
            // 
            // txAdr
            // 
            this.txAdr.Location = new System.Drawing.Point(62, 19);
            this.txAdr.MaxLength = 250;
            this.txAdr.Multiline = true;
            this.txAdr.Name = "txAdr";
            this.txAdr.Size = new System.Drawing.Size(206, 98);
            this.txAdr.TabIndex = 8;
            // 
            // nPointX
            // 
            this.nPointX.DecimalPlaces = 8;
            this.nPointX.Location = new System.Drawing.Point(63, 123);
            this.nPointX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nPointX.Name = "nPointX";
            this.nPointX.Size = new System.Drawing.Size(120, 20);
            this.nPointX.TabIndex = 9;
            // 
            // nPointY
            // 
            this.nPointY.DecimalPlaces = 8;
            this.nPointY.Location = new System.Drawing.Point(63, 149);
            this.nPointY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nPointY.Name = "nPointY";
            this.nPointY.Size = new System.Drawing.Size(120, 20);
            this.nPointY.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(495, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(576, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Район";
            // 
            // cbRegion
            // 
            this.cbRegion.DataSource = this.regionBindingSource;
            this.cbRegion.DisplayMember = "rgName";
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(62, 174);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(206, 21);
            this.cbRegion.TabIndex = 12;
            this.cbRegion.ValueMember = "id_rg";
            // 
            // regionDataSet
            // 
            this.regionDataSet.DataSetName = "regionDataSet";
            this.regionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "region";
            this.regionBindingSource.DataSource = this.regionDataSet;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // kindDataSet
            // 
            this.kindDataSet.DataSetName = "kindDataSet";
            this.kindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kindBindingSource
            // 
            this.kindBindingSource.DataMember = "kind";
            this.kindBindingSource.DataSource = this.kindDataSet;
            // 
            // kindTableAdapter
            // 
            this.kindTableAdapter.ClearBeforeFill = true;
            // 
            // hardsDataSet
            // 
            this.hardsDataSet.DataSetName = "hardsDataSet";
            this.hardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hardsBindingSource
            // 
            this.hardsBindingSource.DataMember = "hards";
            this.hardsBindingSource.DataSource = this.hardsDataSet;
            // 
            // hardsTableAdapter
            // 
            this.hardsTableAdapter.ClearBeforeFill = true;
            // 
            // IncidentNewForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(663, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IncidentNewForm";
            this.Text = "Зарегистрировать проишествие";
            this.Load += new System.EventHandler(this.IncidentNewForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbHard;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.TextBox txNotes;
        private System.Windows.Forms.TextBox txTitle;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nPointY;
        private System.Windows.Forms.NumericUpDown nPointX;
        private System.Windows.Forms.TextBox txAdr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.Label label9;
        private regionDataSet regionDataSet;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private regionDataSetTableAdapters.regionTableAdapter regionTableAdapter;
        private kindDataSet kindDataSet;
        private System.Windows.Forms.BindingSource kindBindingSource;
        private kindDataSetTableAdapters.kindTableAdapter kindTableAdapter;
        private hardsDataSet hardsDataSet;
        private System.Windows.Forms.BindingSource hardsBindingSource;
        private hardsDataSetTableAdapters.hardsTableAdapter hardsTableAdapter;
    }
}