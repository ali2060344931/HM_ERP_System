namespace HM_ERP_System.Forms.Commission
{
    partial class frmCommission
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
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommission));
            Janus.Windows.GridEX.GridEXLayout cmbComers1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCommissionType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCustomer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvList1_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.txtAmount1 = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new Atf.UI.DateTimeSelector();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbComers1 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnShowComers = new DevComponents.DotNetBar.ButtonX();
            this.cmbCommissionType = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.cmbCustomer = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtDes = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreatFile = new DevComponents.DotNetBar.ButtonX();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgvList1 = new GridExEx.GridExEx();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImportFile = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCommissionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(599, 464);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(599, 50);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 514);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(599, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.AutoScrollMinSize = new System.Drawing.Size(0, 200);
            this.pnlAddItemBodi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddItemBodi.Controls.Add(this.uiTab1);
            this.pnlAddItemBodi.Controls.Add(this.panel1);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(522, 514);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 514);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(522, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(447, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(360, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 11, 2, 16, 4, 40, 280);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(158, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 11, 2, 16, 4, 40, 280);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(68, 15);
            this.btnShowListItems.Click += new System.EventHandler(this.btnShowListItems_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(288, 17);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(490, 17);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(601, 570);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(604, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(528, 570);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(565, 0);
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(531, 0);
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.FrozenColumns = 5;
            this.dgvList.HiddenColumnSortingEnabled = false;
            this.dgvList.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvList_Layout_0.IsCurrentLayout = true;
            dgvList_Layout_0.Key = "MyGrig";
            dgvList_Layout_0.LayoutString = resources.GetString("dgvList_Layout_0.LayoutString");
            this.dgvList.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvList_Layout_0});
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RecordNavigator = true;
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvList.Size = new System.Drawing.Size(599, 464);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 87;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // txtAmount1
            // 
            this.txtAmount1.CheackCodeMeli = false;
            this.txtAmount1.Day = 0;
            this.txtAmount1.Location = new System.Drawing.Point(272, 45);
            this.txtAmount1.Miladi = new System.DateTime(((long)(0)));
            this.txtAmount1.Month = 0;
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.NowDateSelected = false;
            this.txtAmount1.Number = null;
            this.txtAmount1.SelectedDate = null;
            this.txtAmount1.Shamsi = null;
            this.txtAmount1.Size = new System.Drawing.Size(141, 28);
            this.txtAmount1.TabIndex = 4;
            this.txtAmount1.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtAmount1.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtAmount1.TextSimple = "";
            this.txtAmount1.TextWatermark = null;
            this.txtAmount1.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtAmount1.Year = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(418, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 99;
            this.label2.Text = "تاریخ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(417, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "بارنامه(تکی):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(418, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 99;
            this.label3.Text = "نــوع پورسانت:";
            // 
            // txtDate
            // 
            this.txtDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate.Location = new System.Drawing.Point(269, 18);
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDate.Size = new System.Drawing.Size(145, 29);
            this.txtDate.TabIndex = 0;
            this.txtDate.UsePersianFormat = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(418, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 99;
            this.label4.Text = "طرف حساب:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(417, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 99;
            this.label5.Text = "مبلــــــــغ:";
            // 
            // cmbComers1
            // 
            this.cmbComers1.DataMember = "id";
            cmbComers1_DesignTimeLayout.LayoutString = resources.GetString("cmbComers1_DesignTimeLayout.LayoutString");
            this.cmbComers1.DesignTimeLayout = cmbComers1_DesignTimeLayout;
            this.cmbComers1.DisplayMember = "ComersH";
            this.cmbComers1.Image = ((System.Drawing.Image)(resources.GetObject("cmbComers1.Image")));
            this.cmbComers1.Location = new System.Drawing.Point(268, 9);
            this.cmbComers1.Name = "cmbComers1";
            this.cmbComers1.SelectedIndex = -1;
            this.cmbComers1.SelectedItem = null;
            this.cmbComers1.Size = new System.Drawing.Size(145, 30);
            this.cmbComers1.TabIndex = 1;
            this.cmbComers1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbComers1.ValueMember = "id";
            this.cmbComers1.ValueChanged += new System.EventHandler(this.cmbComers_ValueChanged);
            this.cmbComers1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbComers_KeyDown);
            // 
            // btnShowComers
            // 
            this.btnShowComers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowComers.BackColor = System.Drawing.Color.Transparent;
            this.btnShowComers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowComers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnShowComers.Location = new System.Drawing.Point(249, 10);
            this.btnShowComers.Name = "btnShowComers";
            this.btnShowComers.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnShowComers.Size = new System.Drawing.Size(18, 28);
            this.btnShowComers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowComers.Symbol = "";
            this.btnShowComers.SymbolSize = 12F;
            this.btnShowComers.TabIndex = 102;
            // 
            // cmbCommissionType
            // 
            this.cmbCommissionType.DataMember = "id";
            cmbCommissionType_DesignTimeLayout.LayoutString = resources.GetString("cmbCommissionType_DesignTimeLayout.LayoutString");
            this.cmbCommissionType.DesignTimeLayout = cmbCommissionType_DesignTimeLayout;
            this.cmbCommissionType.DisplayMember = "Name";
            this.cmbCommissionType.Image = ((System.Drawing.Image)(resources.GetObject("cmbCommissionType.Image")));
            this.cmbCommissionType.Location = new System.Drawing.Point(148, 50);
            this.cmbCommissionType.Name = "cmbCommissionType";
            this.cmbCommissionType.SelectedIndex = -1;
            this.cmbCommissionType.SelectedItem = null;
            this.cmbCommissionType.Size = new System.Drawing.Size(267, 30);
            this.cmbCommissionType.TabIndex = 2;
            this.cmbCommissionType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCommissionType.ValueMember = "id";
            this.cmbCommissionType.ValueChanged += new System.EventHandler(this.cmbCommissionType_ValueChanged);
            this.cmbCommissionType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCommissionType_KeyDown);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.BackColor = System.Drawing.Color.Transparent;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX3.Location = new System.Drawing.Point(129, 87);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX3.Size = new System.Drawing.Size(18, 28);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolSize = 12F;
            this.buttonX3.TabIndex = 102;
            this.buttonX3.Tooltip = "ثبت آیتم جدید";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DataMember = "id";
            cmbCustomer_DesignTimeLayout.LayoutString = resources.GetString("cmbCustomer_DesignTimeLayout.LayoutString");
            this.cmbCustomer.DesignTimeLayout = cmbCustomer_DesignTimeLayout;
            this.cmbCustomer.DisplayMember = "Name";
            this.cmbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cmbCustomer.Image")));
            this.cmbCustomer.Location = new System.Drawing.Point(148, 86);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.SelectedIndex = -1;
            this.cmbCustomer.SelectedItem = null;
            this.cmbCustomer.Size = new System.Drawing.Size(267, 30);
            this.cmbCustomer.TabIndex = 3;
            this.cmbCustomer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCustomer.ValueMember = "id";
            this.cmbCustomer.ValueChanged += new System.EventHandler(this.cmbCustomer_ValueChanged);
            // 
            // txtDes
            // 
            this.txtDes.CheackCodeMeli = false;
            this.txtDes.Day = 0;
            this.txtDes.Location = new System.Drawing.Point(146, 79);
            this.txtDes.Miladi = new System.DateTime(((long)(0)));
            this.txtDes.Month = 0;
            this.txtDes.Name = "txtDes";
            this.txtDes.NowDateSelected = false;
            this.txtDes.Number = null;
            this.txtDes.SelectedDate = null;
            this.txtDes.Shamsi = null;
            this.txtDes.Size = new System.Drawing.Size(267, 28);
            this.txtDes.TabIndex = 4;
            this.txtDes.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtDes.TextSimple = "";
            this.txtDes.TextWatermark = null;
            this.txtDes.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtDes.Year = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(417, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 99;
            this.label7.Text = "توضیحــات:";
            // 
            // btnCreatFile
            // 
            this.btnCreatFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreatFile.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreatFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreatFile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnCreatFile.Location = new System.Drawing.Point(372, 0);
            this.btnCreatFile.Name = "btnCreatFile";
            this.btnCreatFile.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnCreatFile.Size = new System.Drawing.Size(116, 30);
            this.btnCreatFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreatFile.Symbol = "";
            this.btnCreatFile.SymbolSize = 18F;
            this.btnCreatFile.TabIndex = 102;
            this.btnCreatFile.Text = "ایجاد فایل";
            this.btnCreatFile.Click += new System.EventHandler(this.btnCreatFile_Click);
            // 
            // uiTab1
            // 
            this.uiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTab1.FirstTabOffset = 3;
            this.uiTab1.Location = new System.Drawing.Point(0, 124);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.Size = new System.Drawing.Size(522, 390);
            this.uiTab1.TabIndex = 106;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage2,
            this.uiTabPage3});
            this.uiTab1.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
            this.uiTab1.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Horizontal;
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2010;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.cmbComers1);
            this.uiTabPage2.Controls.Add(this.txtAmount1);
            this.uiTabPage2.Controls.Add(this.label5);
            this.uiTabPage2.Controls.Add(this.label1);
            this.uiTabPage2.Controls.Add(this.txtDes);
            this.uiTabPage2.Controls.Add(this.label7);
            this.uiTabPage2.Controls.Add(this.btnShowComers);
            this.uiTabPage2.Key = "ON";
            this.uiTabPage2.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(488, 388);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "تکی";
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.dgvList1);
            this.uiTabPage3.Controls.Add(this.panel2);
            this.uiTabPage3.Key = "List";
            this.uiTabPage3.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(488, 388);
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "فایل";
            // 
            // dgvList1
            // 
            this.dgvList1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList1.ColumnAutoResize = true;
            this.dgvList1.DefaultComment = null;
            this.dgvList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList1.FindCondition = null;
            this.dgvList1.GroupByBoxVisible = false;
            this.dgvList1.HiddenColumnSortingEnabled = true;
            this.dgvList1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvList1_Layout_0.IsCurrentLayout = true;
            dgvList1_Layout_0.Key = "MyGrig";
            dgvList1_Layout_0.LayoutString = resources.GetString("dgvList1_Layout_0.LayoutString");
            this.dgvList1.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvList1_Layout_0});
            this.dgvList1.Location = new System.Drawing.Point(0, 30);
            this.dgvList1.Name = "dgvList1";
            this.dgvList1.RecordNavigator = true;
            this.dgvList1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.dgvList1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList1.Size = new System.Drawing.Size(488, 358);
            this.dgvList1.Sortable = true;
            this.dgvList1.TabIndex = 106;
            this.dgvList1.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList1.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList1.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImportFile);
            this.panel2.Controls.Add(this.btnCreatFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 30);
            this.panel2.TabIndex = 107;
            // 
            // btnImportFile
            // 
            this.btnImportFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportFile.BackColor = System.Drawing.Color.Transparent;
            this.btnImportFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportFile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnImportFile.Location = new System.Drawing.Point(0, 0);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnImportFile.Size = new System.Drawing.Size(116, 30);
            this.btnImportFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportFile.Symbol = "";
            this.btnImportFile.SymbolSize = 20F;
            this.btnImportFile.TabIndex = 102;
            this.btnImportFile.Text = "دریافت از فایل";
            this.btnImportFile.Tooltip = "ورود اطلاعات از فایل اکسل به لیست";
            this.btnImportFile.Click += new System.EventHandler(this.btnSelectList_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCommissionType);
            this.panel1.Controls.Add(this.cmbCustomer);
            this.panel1.Controls.Add(this.buttonX3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 124);
            this.panel1.TabIndex = 107;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // frmCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 576);
            this.Name = "frmCommission";
            this.Text = "پـــورســـانت ها";
            this.Load += new System.EventHandler(this.frmCommission_Load);
            this.Controls.SetChildIndex(this.pnlAddItems, 0);
            this.Controls.SetChildIndex(this.pnlViewItems, 0);
            this.pnlViewItemBody.ResumeLayout(false);
            this.pnlViewItemHeder.ResumeLayout(false);
            this.pnlViewItemHeder.PerformLayout();
            this.pnlViewItemFoter.ResumeLayout(false);
            this.pnlAddItemBodi.ResumeLayout(false);
            this.pnlAddItemFoter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCommissionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage2.PerformLayout();
            this.uiTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        private Class_General.MyTextBoxJanus txtAmount1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Atf.UI.DateTimeSelector txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbComers1;
        public DevComponents.DotNetBar.ButtonX btnShowComers;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCommissionType;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCustomer;
        public DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.Label label7;
        private Class_General.MyTextBoxJanus txtDes;
        public DevComponents.DotNetBar.ButtonX btnCreatFile;
        private System.Windows.Forms.Panel panel1;
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public GridExEx.GridExEx dgvList1;
        private System.Windows.Forms.Panel panel2;
        public DevComponents.DotNetBar.ButtonX btnImportFile;
    }
}