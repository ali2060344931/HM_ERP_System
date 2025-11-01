namespace HM_ERP_System.Forms.DocumentBanck
{
    partial class frmDocumentBanck
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
            Janus.Windows.GridEX.GridEXLayout dgwList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference dgwList_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column5.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentBanck));
            Janus.Windows.Common.Layouts.JanusLayoutReference dgwList_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column6.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgwList_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgwList_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgwList_Layout_0_Reference_4 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column9.ButtonImage");
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgwList = new GridExEx.GridExEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHajmFileSelected = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEraseSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChoisFileNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.cmbOnovanFile = new System.Windows.Forms.ComboBox();
            this.txtMoZoFile = new MyClass.MyTextBox();
            this.txtAdresFile = new MyClass.MyTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblZarfiyatMojaz = new System.Windows.Forms.Label();
            this.lblHajmFile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.lblCaption = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgwList);
            this.groupPanel1.Controls.Add(this.panel1);
            this.groupPanel1.Controls.Add(this.panel3);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 178);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(830, 304);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 52;
            this.groupPanel1.Text = "لیست اسناد و مدارک";
            // 
            // dgwList
            // 
            this.dgwList.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgwList.DefaultComment = null;
            this.dgwList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgwList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgwList.FindCondition = null;
            this.dgwList.GroupByBoxVisible = false;
            this.dgwList.HiddenColumnSortingEnabled = false;
            dgwList_Layout_0.IsCurrentLayout = true;
            dgwList_Layout_0.Key = "megrid";
            dgwList_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("dgwList_Layout_0_Reference_0.Instance")));
            dgwList_Layout_0_Reference_1.Instance = ((object)(resources.GetObject("dgwList_Layout_0_Reference_1.Instance")));
            dgwList_Layout_0_Reference_2.Instance = ((object)(resources.GetObject("dgwList_Layout_0_Reference_2.Instance")));
            dgwList_Layout_0_Reference_3.Instance = ((object)(resources.GetObject("dgwList_Layout_0_Reference_3.Instance")));
            dgwList_Layout_0_Reference_4.Instance = ((object)(resources.GetObject("dgwList_Layout_0_Reference_4.Instance")));
            dgwList_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            dgwList_Layout_0_Reference_0,
            dgwList_Layout_0_Reference_1,
            dgwList_Layout_0_Reference_2,
            dgwList_Layout_0_Reference_3,
            dgwList_Layout_0_Reference_4});
            dgwList_Layout_0.LayoutString = resources.GetString("dgwList_Layout_0.LayoutString");
            this.dgwList.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgwList_Layout_0});
            this.dgwList.Location = new System.Drawing.Point(0, 0);
            this.dgwList.Name = "dgwList";
            this.dgwList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgwList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgwList.Size = new System.Drawing.Size(824, 207);
            this.dgwList.Sortable = true;
            this.dgwList.TabIndex = 87;
            this.dgwList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgwList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgwList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgwList_ColumnButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHajmFileSelected);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 28);
            this.panel1.TabIndex = 63;
            // 
            // lblHajmFileSelected
            // 
            this.lblHajmFileSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblHajmFileSelected.Location = new System.Drawing.Point(22, 5);
            this.lblHajmFileSelected.Name = "lblHajmFileSelected";
            this.lblHajmFileSelected.Size = new System.Drawing.Size(71, 16);
            this.lblHajmFileSelected.TabIndex = 77;
            this.lblHajmFileSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "KB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "حجم فایل:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEraseSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 235);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Size = new System.Drawing.Size(824, 42);
            this.panel3.TabIndex = 62;
            this.panel3.Visible = false;
            // 
            // btnEraseSearch
            // 
            this.btnEraseSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEraseSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnEraseSearch.FlatAppearance.BorderSize = 0;
            this.btnEraseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraseSearch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEraseSearch.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnEraseSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEraseSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEraseSearch.IconSize = 20;
            this.btnEraseSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEraseSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEraseSearch.Location = new System.Drawing.Point(642, 10);
            this.btnEraseSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEraseSearch.Name = "btnEraseSearch";
            this.btnEraseSearch.Size = new System.Drawing.Size(21, 18);
            this.btnEraseSearch.TabIndex = 68;
            this.btnEraseSearch.TabStop = false;
            this.btnEraseSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.ButtonCustom.Symbol = "";
            this.txtSearch.ButtonCustom.Visible = true;
            this.txtSearch.Location = new System.Drawing.Point(665, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(149, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // btnChoisFileNew
            // 
            this.btnChoisFileNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChoisFileNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoisFileNew.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnChoisFileNew.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.btnChoisFileNew.Location = new System.Drawing.Point(579, 3);
            this.btnChoisFileNew.Name = "btnChoisFileNew";
            this.btnChoisFileNew.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnChoisFileNew.Size = new System.Drawing.Size(104, 26);
            this.btnChoisFileNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChoisFileNew.Symbol = "58124";
            this.btnChoisFileNew.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnChoisFileNew.TabIndex = 83;
            this.btnChoisFileNew.Text = "انتخــاب فایل:";
            this.btnChoisFileNew.Click += new System.EventHandler(this.btnChoisFileNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(15, 15);
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSave.Location = new System.Drawing.Point(319, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnSave.Size = new System.Drawing.Size(122, 32);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ثبت مدارک(ذخیره)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbOnovanFile
            // 
            this.cmbOnovanFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOnovanFile.FormattingEnabled = true;
            this.cmbOnovanFile.Location = new System.Drawing.Point(452, 71);
            this.cmbOnovanFile.Name = "cmbOnovanFile";
            this.cmbOnovanFile.Size = new System.Drawing.Size(121, 26);
            this.cmbOnovanFile.TabIndex = 82;
            // 
            // txtMoZoFile
            // 
            this.txtMoZoFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoZoFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMoZoFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMoZoFile.CheackCodeMeli = false;
            this.txtMoZoFile.Day = 0;
            this.txtMoZoFile.Location = new System.Drawing.Point(164, 36);
            this.txtMoZoFile.Miladi = new System.DateTime(((long)(0)));
            this.txtMoZoFile.Month = 0;
            this.txtMoZoFile.Name = "txtMoZoFile";
            this.txtMoZoFile.NowDateSelected = false;
            this.txtMoZoFile.Number = null;
            this.txtMoZoFile.SelectedDate = null;
            this.txtMoZoFile.Shamsi = null;
            this.txtMoZoFile.Size = new System.Drawing.Size(409, 26);
            this.txtMoZoFile.TabIndex = 1;
            this.txtMoZoFile.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtMoZoFile.TextSimple = "";
            this.txtMoZoFile.TextWatermark = null;
            this.txtMoZoFile.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtMoZoFile.Year = 0;
            // 
            // txtAdresFile
            // 
            this.txtAdresFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdresFile.CheackCodeMeli = false;
            this.txtAdresFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAdresFile.Day = 0;
            this.txtAdresFile.Location = new System.Drawing.Point(164, 3);
            this.txtAdresFile.Miladi = new System.DateTime(((long)(0)));
            this.txtAdresFile.Month = 0;
            this.txtAdresFile.Name = "txtAdresFile";
            this.txtAdresFile.NowDateSelected = false;
            this.txtAdresFile.Number = null;
            this.txtAdresFile.ReadOnly = true;
            this.txtAdresFile.SelectedDate = null;
            this.txtAdresFile.Shamsi = null;
            this.txtAdresFile.Size = new System.Drawing.Size(409, 26);
            this.txtAdresFile.TabIndex = 81;
            this.txtAdresFile.TabStop = false;
            this.txtAdresFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAdresFile.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtAdresFile.TextSimple = "";
            this.txtAdresFile.TextWatermark = null;
            this.txtAdresFile.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtAdresFile.Year = 0;
            this.txtAdresFile.Click += new System.EventHandler(this.txtAdresFile_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "عنوان(موضوع) فایل:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "ظرفیت مجاز:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(41, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "کیلوبایت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 75;
            this.label6.Text = "حجم فایل:";
            // 
            // lblZarfiyatMojaz
            // 
            this.lblZarfiyatMojaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblZarfiyatMojaz.Location = new System.Drawing.Point(22, 42);
            this.lblZarfiyatMojaz.Name = "lblZarfiyatMojaz";
            this.lblZarfiyatMojaz.Size = new System.Drawing.Size(71, 16);
            this.lblZarfiyatMojaz.TabIndex = 76;
            this.lblZarfiyatMojaz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHajmFile
            // 
            this.lblHajmFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHajmFile.Location = new System.Drawing.Point(22, 19);
            this.lblHajmFile.Name = "lblHajmFile";
            this.lblHajmFile.Size = new System.Drawing.Size(71, 16);
            this.lblHajmFile.TabIndex = 77;
            this.lblHajmFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "نوع(فرمت) فایل:";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnNew);
            this.groupPanel2.Controls.Add(this.pictureBox1);
            this.groupPanel2.Controls.Add(this.btnChoisFileNew);
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.Controls.Add(this.cmbOnovanFile);
            this.groupPanel2.Controls.Add(this.txtMoZoFile);
            this.groupPanel2.Controls.Add(this.txtAdresFile);
            this.groupPanel2.Controls.Add(this.label4);
            this.groupPanel2.Controls.Add(this.label7);
            this.groupPanel2.Controls.Add(this.label3);
            this.groupPanel2.Controls.Add(this.label6);
            this.groupPanel2.Controls.Add(this.lblZarfiyatMojaz);
            this.groupPanel2.Controls.Add(this.lblHajmFile);
            this.groupPanel2.Controls.Add(this.label5);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(0, 33);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(830, 145);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 53;
            this.groupPanel2.Text = "ثبت اسناد و مدارک";
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnNew.Location = new System.Drawing.Point(232, 68);
            this.btnNew.Name = "btnNew";
            this.btnNew.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.btnNew.Size = new System.Drawing.Size(81, 32);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.Symbol = "";
            this.btnNew.SymbolSize = 12F;
            this.btnNew.TabIndex = 94;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "جدید";
            this.btnNew.Tooltip = "ثبت آیتم جدید";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(830, 33);
            this.lblCaption.TabIndex = 54;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDocumentBanck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 482);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.lblCaption);
            this.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDocumentBanck";
            this.Text = "فرم ثبت اسناد و مدارک";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.frmDocumentBanck_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDocumentBanck_KeyDown);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHajmFileSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnEraseSearch;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        public DevComponents.DotNetBar.ButtonX btnChoisFileNew;
        public DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.ComboBox cmbOnovanFile;
        private MyClass.MyTextBox txtMoZoFile;
        private MyClass.MyTextBox txtAdresFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblZarfiyatMojaz;
        private System.Windows.Forms.Label lblHajmFile;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        public System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public GridExEx.GridExEx dgwList;
        public DevComponents.DotNetBar.ButtonX btnNew;
    }
}