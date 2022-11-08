namespace incidentMap
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mSpravka_hideAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mKind = new System.Windows.Forms.ToolStripMenuItem();
            this.mForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mAdmin_hideAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptions_hideAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mHideAdmin1 = new System.Windows.Forms.ToolStripSeparator();
            this.mAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSpravka_hideAdmin = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmKind = new System.Windows.Forms.ToolStripMenuItem();
            this.tmForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tmRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.tbOptions__hideAdmin = new System.Windows.Forms.ToolStripButton();
            this.mHideAdmin2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txLatNow = new System.Windows.Forms.ToolStripTextBox();
            this.txLngNow = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.gmMap = new GMap.NET.WindowsForms.GMapControl();
            this.grIncident = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.getIncViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getIncDataSet = new incidentMap.getIncDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idincDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncSubjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncClosedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ncVerdictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usFioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usRangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idknDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idhdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionDataSet = new incidentMap.regionDataSet();
            this.chRegion = new System.Windows.Forms.CheckBox();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.kindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindDataSet = new incidentMap.kindDataSet();
            this.chKind = new System.Windows.Forms.CheckBox();
            this.bSelect = new System.Windows.Forms.Button();
            this.rbClosed = new System.Windows.Forms.RadioButton();
            this.rbAllOpen = new System.Windows.Forms.RadioButton();
            this.rbActionNow = new System.Windows.Forms.RadioButton();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.getIncViewTableAdapter = new incidentMap.getIncDataSetTableAdapters.getIncViewTableAdapter();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kindTableAdapter = new incidentMap.kindDataSetTableAdapters.kindTableAdapter();
            this.regionTableAdapter = new incidentMap.regionDataSetTableAdapters.regionTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grIncident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getIncViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIncDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1046, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem,
            this.mSpravka_hideAdmin,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNew,
            this.toolStripMenuItem3,
            this.mExit});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // mNew
            // 
            this.mNew.Image = global::incidentMap.Properties.Resources.plus;
            this.mNew.Name = "mNew";
            this.mNew.Size = new System.Drawing.Size(222, 22);
            this.mNew.Text = "Регистрация проишествий";
            this.mNew.Click += new System.EventHandler(this.mNew_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(219, 6);
            // 
            // mExit
            // 
            this.mExit.Image = global::incidentMap.Properties.Resources.mExit;
            this.mExit.Name = "mExit";
            this.mExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mExit.Size = new System.Drawing.Size(222, 22);
            this.mExit.Text = "Выход";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mSpravka_hideAdmin
            // 
            this.mSpravka_hideAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKind,
            this.mForm,
            this.mRegion});
            this.mSpravka_hideAdmin.Name = "mSpravka_hideAdmin";
            this.mSpravka_hideAdmin.Size = new System.Drawing.Size(94, 20);
            this.mSpravka_hideAdmin.Text = "Справочники";
            // 
            // mKind
            // 
            this.mKind.Name = "mKind";
            this.mKind.Size = new System.Drawing.Size(265, 22);
            this.mKind.Text = "Виды проишествий/преступлений";
            this.mKind.Click += new System.EventHandler(this.mKind_Click);
            // 
            // mForm
            // 
            this.mForm.Name = "mForm";
            this.mForm.Size = new System.Drawing.Size(265, 22);
            this.mForm.Text = "Формы тяжести";
            this.mForm.Click += new System.EventHandler(this.mForm_Click);
            // 
            // mRegion
            // 
            this.mRegion.Name = "mRegion";
            this.mRegion.Size = new System.Drawing.Size(265, 22);
            this.mRegion.Text = "Районы ответственности";
            this.mRegion.Click += new System.EventHandler(this.mRegion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAdmin_hideAdmin,
            this.mOptions_hideAdmin,
            this.mHideAdmin1,
            this.mAbout});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 20);
            this.toolStripMenuItem1.Text = "=";
            // 
            // mAdmin_hideAdmin
            // 
            this.mAdmin_hideAdmin.Name = "mAdmin_hideAdmin";
            this.mAdmin_hideAdmin.Size = new System.Drawing.Size(189, 22);
            this.mAdmin_hideAdmin.Text = "Администрирование";
            this.mAdmin_hideAdmin.Click += new System.EventHandler(this.mAdmin_Click);
            // 
            // mOptions_hideAdmin
            // 
            this.mOptions_hideAdmin.Image = global::incidentMap.Properties.Resources.mOptions;
            this.mOptions_hideAdmin.Name = "mOptions_hideAdmin";
            this.mOptions_hideAdmin.Size = new System.Drawing.Size(189, 22);
            this.mOptions_hideAdmin.Text = "Настройки";
            this.mOptions_hideAdmin.Click += new System.EventHandler(this.mOptions_Click);
            // 
            // mHideAdmin1
            // 
            this.mHideAdmin1.Name = "mHideAdmin1";
            this.mHideAdmin1.Size = new System.Drawing.Size(186, 6);
            // 
            // mAbout
            // 
            this.mAbout.Name = "mAbout";
            this.mAbout.Size = new System.Drawing.Size(189, 22);
            this.mAbout.Text = "О программе";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.tbSpravka_hideAdmin,
            this.mHideAdmin2,
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.tbOptions__hideAdmin,
            this.toolStripLabel1,
            this.txLatNow,
            this.txLngNow,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1046, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::incidentMap.Properties.Resources.plus;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Регистрация";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSpravka_hideAdmin
            // 
            this.tbSpravka_hideAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSpravka_hideAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmKind,
            this.tmForm,
            this.tmRegion});
            this.tbSpravka_hideAdmin.Image = global::incidentMap.Properties.Resources.gnf;
            this.tbSpravka_hideAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSpravka_hideAdmin.Name = "tbSpravka_hideAdmin";
            this.tbSpravka_hideAdmin.Size = new System.Drawing.Size(29, 22);
            this.tbSpravka_hideAdmin.Text = "toolStripDropDownButton2";
            // 
            // tmKind
            // 
            this.tmKind.Name = "tmKind";
            this.tmKind.Size = new System.Drawing.Size(265, 22);
            this.tmKind.Text = "Виды проишествий/преступлений";
            this.tmKind.Click += new System.EventHandler(this.mKind_Click);
            // 
            // tmForm
            // 
            this.tmForm.Name = "tmForm";
            this.tmForm.Size = new System.Drawing.Size(265, 22);
            this.tmForm.Text = "Формы тяжести";
            this.tmForm.Click += new System.EventHandler(this.mForm_Click);
            // 
            // tmRegion
            // 
            this.tmRegion.Name = "tmRegion";
            this.tmRegion.Size = new System.Drawing.Size(265, 22);
            this.tmRegion.Text = "Районы ответственности";
            this.tmRegion.Click += new System.EventHandler(this.mRegion_Click);
            // 
            // tbOptions__hideAdmin
            // 
            this.tbOptions__hideAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOptions__hideAdmin.Image = global::incidentMap.Properties.Resources.mOptions;
            this.tbOptions__hideAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOptions__hideAdmin.Name = "tbOptions__hideAdmin";
            this.tbOptions__hideAdmin.Size = new System.Drawing.Size(23, 22);
            this.tbOptions__hideAdmin.Text = "Настройки";
            this.tbOptions__hideAdmin.Click += new System.EventHandler(this.mOptions_Click);
            // 
            // mHideAdmin2
            // 
            this.mHideAdmin2.Name = "mHideAdmin2";
            this.mHideAdmin2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::incidentMap.Properties.Resources.mExit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Выход";
            this.toolStripButton3.Click += new System.EventHandler(this.mExit_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel1.Text = "Позиция";
            // 
            // txLatNow
            // 
            this.txLatNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txLatNow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txLatNow.Name = "txLatNow";
            this.txLatNow.ReadOnly = true;
            this.txLatNow.Size = new System.Drawing.Size(100, 25);
            // 
            // txLngNow
            // 
            this.txLngNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txLngNow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txLngNow.Name = "txLngNow";
            this.txLngNow.ReadOnly = true;
            this.txLngNow.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::incidentMap.Properties.Resources.bApply;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Установить по умолчанию";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // gmMap
            // 
            this.gmMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmMap.Bearing = 0F;
            this.gmMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gmMap.CanDragMap = true;
            this.gmMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmMap.GrayScaleMode = false;
            this.gmMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmMap.LevelsKeepInMemmory = 5;
            this.gmMap.Location = new System.Drawing.Point(13, 52);
            this.gmMap.MarkersEnabled = true;
            this.gmMap.MaxZoom = 2;
            this.gmMap.MinZoom = 2;
            this.gmMap.MouseWheelZoomEnabled = true;
            this.gmMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmMap.Name = "gmMap";
            this.gmMap.NegativeMode = false;
            this.gmMap.PolygonsEnabled = true;
            this.gmMap.RetryLoadTile = 0;
            this.gmMap.RoutesEnabled = true;
            this.gmMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmMap.ShowTileGridLines = false;
            this.gmMap.Size = new System.Drawing.Size(659, 589);
            this.gmMap.TabIndex = 3;
            this.gmMap.Zoom = 0D;
            this.gmMap.OnMapDrag += new GMap.NET.MapDrag(this.gmMap_OnMapDrag);
            this.gmMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gmMap_OnMapZoomChanged);
            this.gmMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmMap_MouseClick);
            // 
            // grIncident
            // 
            this.grIncident.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grIncident.Controls.Add(this.label2);
            this.grIncident.Controls.Add(this.label1);
            this.grIncident.Controls.Add(this.textBox2);
            this.grIncident.Controls.Add(this.textBox1);
            this.grIncident.Controls.Add(this.dataGridView1);
            this.grIncident.Controls.Add(this.bindingNavigator1);
            this.grIncident.Location = new System.Drawing.Point(678, 219);
            this.grIncident.Name = "grIncident";
            this.grIncident.Size = new System.Drawing.Size(356, 422);
            this.grIncident.TabIndex = 4;
            this.grIncident.TabStop = false;
            this.grIncident.Text = "Проишествия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Решение по делу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Описание событий";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getIncViewBindingSource, "ncVerdict", true));
            this.textBox2.Location = new System.Drawing.Point(6, 341);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(344, 69);
            this.textBox2.TabIndex = 3;
            // 
            // getIncViewBindingSource
            // 
            this.getIncViewBindingSource.DataMember = "getIncView";
            this.getIncViewBindingSource.DataSource = this.getIncDataSet;
            // 
            // getIncDataSet
            // 
            this.getIncDataSet.DataSetName = "getIncDataSet";
            this.getIncDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.getIncViewBindingSource, "ncNotes", true));
            this.textBox1.Location = new System.Drawing.Point(6, 253);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 69);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idincDataGridViewTextBoxColumn,
            this.ncDateDataGridViewTextBoxColumn,
            this.ncSubjDataGridViewTextBoxColumn,
            this.ncNotesDataGridViewTextBoxColumn,
            this.closeDateDataGridViewTextBoxColumn,
            this.ncClosedDataGridViewCheckBoxColumn,
            this.ncVerdictDataGridViewTextBoxColumn,
            this.ncAdresDataGridViewTextBoxColumn,
            this.pointXDataGridViewTextBoxColumn,
            this.pointYDataGridViewTextBoxColumn,
            this.knNameDataGridViewTextBoxColumn,
            this.hdNameDataGridViewTextBoxColumn,
            this.usFioDataGridViewTextBoxColumn,
            this.usRangDataGridViewTextBoxColumn,
            this.rgNameDataGridViewTextBoxColumn,
            this.idknDataGridViewTextBoxColumn,
            this.idhdDataGridViewTextBoxColumn,
            this.idusDataGridViewTextBoxColumn,
            this.idrgDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getIncViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 190);
            this.dataGridView1.TabIndex = 1;
            // 
            // idincDataGridViewTextBoxColumn
            // 
            this.idincDataGridViewTextBoxColumn.DataPropertyName = "id_inc";
            this.idincDataGridViewTextBoxColumn.HeaderText = "Протокол №";
            this.idincDataGridViewTextBoxColumn.Name = "idincDataGridViewTextBoxColumn";
            this.idincDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ncDateDataGridViewTextBoxColumn
            // 
            this.ncDateDataGridViewTextBoxColumn.DataPropertyName = "ncDate";
            this.ncDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.ncDateDataGridViewTextBoxColumn.Name = "ncDateDataGridViewTextBoxColumn";
            this.ncDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ncSubjDataGridViewTextBoxColumn
            // 
            this.ncSubjDataGridViewTextBoxColumn.DataPropertyName = "ncSubj";
            this.ncSubjDataGridViewTextBoxColumn.HeaderText = "Проишествие";
            this.ncSubjDataGridViewTextBoxColumn.Name = "ncSubjDataGridViewTextBoxColumn";
            this.ncSubjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ncNotesDataGridViewTextBoxColumn
            // 
            this.ncNotesDataGridViewTextBoxColumn.DataPropertyName = "ncNotes";
            this.ncNotesDataGridViewTextBoxColumn.HeaderText = "ncNotes";
            this.ncNotesDataGridViewTextBoxColumn.Name = "ncNotesDataGridViewTextBoxColumn";
            this.ncNotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.ncNotesDataGridViewTextBoxColumn.Visible = false;
            // 
            // closeDateDataGridViewTextBoxColumn
            // 
            this.closeDateDataGridViewTextBoxColumn.DataPropertyName = "closeDate";
            this.closeDateDataGridViewTextBoxColumn.HeaderText = "Закрыто";
            this.closeDateDataGridViewTextBoxColumn.Name = "closeDateDataGridViewTextBoxColumn";
            this.closeDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ncClosedDataGridViewCheckBoxColumn
            // 
            this.ncClosedDataGridViewCheckBoxColumn.DataPropertyName = "ncClosed";
            this.ncClosedDataGridViewCheckBoxColumn.HeaderText = "ncClosed";
            this.ncClosedDataGridViewCheckBoxColumn.Name = "ncClosedDataGridViewCheckBoxColumn";
            this.ncClosedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ncClosedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ncVerdictDataGridViewTextBoxColumn
            // 
            this.ncVerdictDataGridViewTextBoxColumn.DataPropertyName = "ncVerdict";
            this.ncVerdictDataGridViewTextBoxColumn.HeaderText = "ncVerdict";
            this.ncVerdictDataGridViewTextBoxColumn.Name = "ncVerdictDataGridViewTextBoxColumn";
            this.ncVerdictDataGridViewTextBoxColumn.ReadOnly = true;
            this.ncVerdictDataGridViewTextBoxColumn.Visible = false;
            // 
            // ncAdresDataGridViewTextBoxColumn
            // 
            this.ncAdresDataGridViewTextBoxColumn.DataPropertyName = "ncAdres";
            this.ncAdresDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.ncAdresDataGridViewTextBoxColumn.Name = "ncAdresDataGridViewTextBoxColumn";
            this.ncAdresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pointXDataGridViewTextBoxColumn
            // 
            this.pointXDataGridViewTextBoxColumn.DataPropertyName = "pointX";
            this.pointXDataGridViewTextBoxColumn.HeaderText = "pointX";
            this.pointXDataGridViewTextBoxColumn.Name = "pointXDataGridViewTextBoxColumn";
            this.pointXDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointXDataGridViewTextBoxColumn.Visible = false;
            // 
            // pointYDataGridViewTextBoxColumn
            // 
            this.pointYDataGridViewTextBoxColumn.DataPropertyName = "pointY";
            this.pointYDataGridViewTextBoxColumn.HeaderText = "pointY";
            this.pointYDataGridViewTextBoxColumn.Name = "pointYDataGridViewTextBoxColumn";
            this.pointYDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointYDataGridViewTextBoxColumn.Visible = false;
            // 
            // knNameDataGridViewTextBoxColumn
            // 
            this.knNameDataGridViewTextBoxColumn.DataPropertyName = "knName";
            this.knNameDataGridViewTextBoxColumn.HeaderText = "Вид";
            this.knNameDataGridViewTextBoxColumn.Name = "knNameDataGridViewTextBoxColumn";
            this.knNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hdNameDataGridViewTextBoxColumn
            // 
            this.hdNameDataGridViewTextBoxColumn.DataPropertyName = "hdName";
            this.hdNameDataGridViewTextBoxColumn.HeaderText = "Тяжесть";
            this.hdNameDataGridViewTextBoxColumn.Name = "hdNameDataGridViewTextBoxColumn";
            this.hdNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usFioDataGridViewTextBoxColumn
            // 
            this.usFioDataGridViewTextBoxColumn.DataPropertyName = "usFio";
            this.usFioDataGridViewTextBoxColumn.HeaderText = "Оформил";
            this.usFioDataGridViewTextBoxColumn.Name = "usFioDataGridViewTextBoxColumn";
            this.usFioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usRangDataGridViewTextBoxColumn
            // 
            this.usRangDataGridViewTextBoxColumn.DataPropertyName = "usRang";
            this.usRangDataGridViewTextBoxColumn.HeaderText = "Звание";
            this.usRangDataGridViewTextBoxColumn.Name = "usRangDataGridViewTextBoxColumn";
            this.usRangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgNameDataGridViewTextBoxColumn
            // 
            this.rgNameDataGridViewTextBoxColumn.DataPropertyName = "rgName";
            this.rgNameDataGridViewTextBoxColumn.HeaderText = "Район";
            this.rgNameDataGridViewTextBoxColumn.Name = "rgNameDataGridViewTextBoxColumn";
            this.rgNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idknDataGridViewTextBoxColumn
            // 
            this.idknDataGridViewTextBoxColumn.DataPropertyName = "id_kn";
            this.idknDataGridViewTextBoxColumn.HeaderText = "id_kn";
            this.idknDataGridViewTextBoxColumn.Name = "idknDataGridViewTextBoxColumn";
            this.idknDataGridViewTextBoxColumn.ReadOnly = true;
            this.idknDataGridViewTextBoxColumn.Visible = false;
            // 
            // idhdDataGridViewTextBoxColumn
            // 
            this.idhdDataGridViewTextBoxColumn.DataPropertyName = "id_hd";
            this.idhdDataGridViewTextBoxColumn.HeaderText = "id_hd";
            this.idhdDataGridViewTextBoxColumn.Name = "idhdDataGridViewTextBoxColumn";
            this.idhdDataGridViewTextBoxColumn.ReadOnly = true;
            this.idhdDataGridViewTextBoxColumn.Visible = false;
            // 
            // idusDataGridViewTextBoxColumn
            // 
            this.idusDataGridViewTextBoxColumn.DataPropertyName = "id_us";
            this.idusDataGridViewTextBoxColumn.HeaderText = "id_us";
            this.idusDataGridViewTextBoxColumn.Name = "idusDataGridViewTextBoxColumn";
            this.idusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idusDataGridViewTextBoxColumn.Visible = false;
            // 
            // idrgDataGridViewTextBoxColumn
            // 
            this.idrgDataGridViewTextBoxColumn.DataPropertyName = "id_rg";
            this.idrgDataGridViewTextBoxColumn.HeaderText = "id_rg";
            this.idrgDataGridViewTextBoxColumn.Name = "idrgDataGridViewTextBoxColumn";
            this.idrgDataGridViewTextBoxColumn.ReadOnly = true;
            this.idrgDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.getIncViewBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(350, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::incidentMap.Properties.Resources.bOk;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Закрытие";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::incidentMap.Properties.Resources.delete;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Удалить";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbRegion);
            this.groupBox2.Controls.Add(this.chRegion);
            this.groupBox2.Controls.Add(this.cbKind);
            this.groupBox2.Controls.Add(this.chKind);
            this.groupBox2.Controls.Add(this.bSelect);
            this.groupBox2.Controls.Add(this.rbClosed);
            this.groupBox2.Controls.Add(this.rbAllOpen);
            this.groupBox2.Controls.Add(this.rbActionNow);
            this.groupBox2.Controls.Add(this.dtDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(678, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 161);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отображение";
            // 
            // cbRegion
            // 
            this.cbRegion.DataSource = this.regionBindingSource;
            this.cbRegion.DisplayMember = "rgName";
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.Enabled = false;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Location = new System.Drawing.Point(132, 95);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(218, 21);
            this.cbRegion.TabIndex = 10;
            this.cbRegion.ValueMember = "id_rg";
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "region";
            this.regionBindingSource.DataSource = this.regionDataSet;
            // 
            // regionDataSet
            // 
            this.regionDataSet.DataSetName = "regionDataSet";
            this.regionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chRegion
            // 
            this.chRegion.AutoSize = true;
            this.chRegion.Location = new System.Drawing.Point(9, 97);
            this.chRegion.Name = "chRegion";
            this.chRegion.Size = new System.Drawing.Size(57, 17);
            this.chRegion.TabIndex = 9;
            this.chRegion.Text = "Район";
            this.chRegion.UseVisualStyleBackColor = true;
            this.chRegion.CheckedChanged += new System.EventHandler(this.chRegion_CheckedChanged);
            // 
            // cbKind
            // 
            this.cbKind.DataSource = this.kindBindingSource;
            this.cbKind.DisplayMember = "knName";
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.Enabled = false;
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Location = new System.Drawing.Point(132, 68);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(218, 21);
            this.cbKind.TabIndex = 8;
            this.cbKind.ValueMember = "id_kn";
            // 
            // kindBindingSource
            // 
            this.kindBindingSource.DataMember = "kind";
            this.kindBindingSource.DataSource = this.kindDataSet;
            // 
            // kindDataSet
            // 
            this.kindDataSet.DataSetName = "kindDataSet";
            this.kindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chKind
            // 
            this.chKind.AutoSize = true;
            this.chKind.Location = new System.Drawing.Point(9, 70);
            this.chKind.Name = "chKind";
            this.chKind.Size = new System.Drawing.Size(115, 17);
            this.chKind.TabIndex = 7;
            this.chKind.Text = "Вид проишествия";
            this.chKind.UseVisualStyleBackColor = true;
            this.chKind.CheckedChanged += new System.EventHandler(this.chKind_CheckedChanged);
            // 
            // bSelect
            // 
            this.bSelect.Location = new System.Drawing.Point(9, 122);
            this.bSelect.Name = "bSelect";
            this.bSelect.Size = new System.Drawing.Size(341, 23);
            this.bSelect.TabIndex = 6;
            this.bSelect.Text = "Отобразить";
            this.bSelect.UseVisualStyleBackColor = true;
            this.bSelect.Click += new System.EventHandler(this.bSelect_Click);
            // 
            // rbClosed
            // 
            this.rbClosed.AutoSize = true;
            this.rbClosed.Location = new System.Drawing.Point(254, 19);
            this.rbClosed.Name = "rbClosed";
            this.rbClosed.Size = new System.Drawing.Size(96, 17);
            this.rbClosed.TabIndex = 5;
            this.rbClosed.Text = "Завершенные";
            this.rbClosed.UseVisualStyleBackColor = true;
            // 
            // rbAllOpen
            // 
            this.rbAllOpen.AutoSize = true;
            this.rbAllOpen.Location = new System.Drawing.Point(132, 19);
            this.rbAllOpen.Name = "rbAllOpen";
            this.rbAllOpen.Size = new System.Drawing.Size(97, 17);
            this.rbAllOpen.TabIndex = 4;
            this.rbAllOpen.Text = "Все открытые";
            this.rbAllOpen.UseVisualStyleBackColor = true;
            // 
            // rbActionNow
            // 
            this.rbActionNow.AutoSize = true;
            this.rbActionNow.Checked = true;
            this.rbActionNow.Location = new System.Drawing.Point(9, 19);
            this.rbActionNow.Name = "rbActionNow";
            this.rbActionNow.Size = new System.Drawing.Size(103, 17);
            this.rbActionNow.TabIndex = 3;
            this.rbActionNow.TabStop = true;
            this.rbActionNow.Text = "Произошедшие";
            this.rbActionNow.UseVisualStyleBackColor = true;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(132, 42);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(146, 20);
            this.dtDate.TabIndex = 1;
            this.dtDate.Value = new System.DateTime(2019, 10, 6, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата совершения";
            // 
            // getIncViewTableAdapter
            // 
            this.getIncViewTableAdapter.ClearBeforeFill = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "flBLUE.png");
            this.imageList1.Images.SetKeyName(1, "flRED.png");
            this.imageList1.Images.SetKeyName(2, "flYELLOW.png");
            this.imageList1.Images.SetKeyName(3, "flGRAY.png");
            // 
            // kindTableAdapter
            // 
            this.kindTableAdapter.ClearBeforeFill = true;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grIncident);
            this.Controls.Add(this.gmMap);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "АРМ ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grIncident.ResumeLayout(false);
            this.grIncident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getIncViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getIncDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSpravka_hideAdmin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mAbout;
        private System.Windows.Forms.ToolStripSeparator mHideAdmin1;
        private System.Windows.Forms.ToolStripMenuItem mAdmin_hideAdmin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private GMap.NET.WindowsForms.GMapControl gmMap;
        private System.Windows.Forms.ToolStripMenuItem mOptions_hideAdmin;
        private System.Windows.Forms.ToolStripMenuItem mNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mKind;
        private System.Windows.Forms.ToolStripMenuItem mForm;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tbSpravka_hideAdmin;
        private System.Windows.Forms.ToolStripMenuItem tmKind;
        private System.Windows.Forms.ToolStripMenuItem tmForm;
        private System.Windows.Forms.ToolStripButton tbOptions__hideAdmin;
        private System.Windows.Forms.ToolStripSeparator mHideAdmin2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txLatNow;
        private System.Windows.Forms.ToolStripTextBox txLngNow;
        private System.Windows.Forms.GroupBox grIncident;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem mRegion;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem tmRegion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSelect;
        private System.Windows.Forms.RadioButton rbClosed;
        private System.Windows.Forms.RadioButton rbAllOpen;
        private System.Windows.Forms.RadioButton rbActionNow;
        private System.Windows.Forms.BindingSource getIncViewBindingSource;
        private getIncDataSet getIncDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idincDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncSubjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ncClosedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncVerdictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usFioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usRangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idknDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrgDataGridViewTextBoxColumn;
        private getIncDataSetTableAdapters.getIncViewTableAdapter getIncViewTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.CheckBox chRegion;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.CheckBox chKind;
        private kindDataSet kindDataSet;
        private System.Windows.Forms.BindingSource kindBindingSource;
        private kindDataSetTableAdapters.kindTableAdapter kindTableAdapter;
        private regionDataSet regionDataSet;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private regionDataSetTableAdapters.regionTableAdapter regionTableAdapter;
    }
}

