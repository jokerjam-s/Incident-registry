namespace incidentMap
{
    partial class OptionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txDepart = new System.Windows.Forms.TextBox();
            this.txPlace = new System.Windows.Forms.TextBox();
            this.nPointX = new System.Windows.Forms.NumericUpDown();
            this.nPointY = new System.Windows.Forms.NumericUpDown();
            this.cbMap = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPointY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMap);
            this.groupBox1.Controls.Add(this.nPointY);
            this.groupBox1.Controls.Add(this.nPointX);
            this.groupBox1.Controls.Add(this.txPlace);
            this.groupBox1.Controls.Add(this.txDepart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подразделение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Нас. пункт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Широта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Долгота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Карта";
            // 
            // txDepart
            // 
            this.txDepart.Location = new System.Drawing.Point(99, 22);
            this.txDepart.MaxLength = 50;
            this.txDepart.Name = "txDepart";
            this.txDepart.Size = new System.Drawing.Size(275, 20);
            this.txDepart.TabIndex = 5;
            // 
            // txPlace
            // 
            this.txPlace.Location = new System.Drawing.Point(99, 48);
            this.txPlace.MaxLength = 50;
            this.txPlace.Name = "txPlace";
            this.txPlace.Size = new System.Drawing.Size(275, 20);
            this.txPlace.TabIndex = 6;
            // 
            // nPointX
            // 
            this.nPointX.DecimalPlaces = 8;
            this.nPointX.Location = new System.Drawing.Point(99, 74);
            this.nPointX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nPointX.Name = "nPointX";
            this.nPointX.Size = new System.Drawing.Size(120, 20);
            this.nPointX.TabIndex = 7;
            // 
            // nPointY
            // 
            this.nPointY.DecimalPlaces = 8;
            this.nPointY.Location = new System.Drawing.Point(99, 100);
            this.nPointY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nPointY.Name = "nPointY";
            this.nPointY.Size = new System.Drawing.Size(120, 20);
            this.nPointY.TabIndex = 8;
            // 
            // cbMap
            // 
            this.cbMap.FormattingEnabled = true;
            this.cbMap.Items.AddRange(new object[] {
            "Google",
            "Yandex"});
            this.cbMap.Location = new System.Drawing.Point(99, 126);
            this.cbMap.Name = "cbMap";
            this.cbMap.Size = new System.Drawing.Size(121, 21);
            this.cbMap.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(236, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(317, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(404, 210);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPointY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMap;
        private System.Windows.Forms.NumericUpDown nPointY;
        private System.Windows.Forms.NumericUpDown nPointX;
        private System.Windows.Forms.TextBox txPlace;
        private System.Windows.Forms.TextBox txDepart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}