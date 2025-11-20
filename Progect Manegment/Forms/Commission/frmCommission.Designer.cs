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
            this.dgvList1 = new GridExEx.GridExEx();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImportFile = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddTolist = new DevComponents.DotNetBar.ButtonX();
            this.chkRegAccount = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmsdgv = new Janus.Windows.Ribbon.RibbonContextMenu(this.components);
            this.dropDownCommand1 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand2 = new Janus.Windows.Ribbon.DropDownCommand();
            this.separatorCommand1 = new Janus.Windows.Ribbon.SeparatorCommand();
            this.dropDownCommand3 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand4 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand5 = new Janus.Windows.Ribbon.DropDownCommand();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvList1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Location = new System.Drawing.Point(0, 54);
            this.pnlViewItemBody.Size = new System.Drawing.Size(874, 237);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(874, 54);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 291);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(874, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.AutoScrollMinSize = new System.Drawing.Size(0, 200);
            this.pnlAddItemBodi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddItemBodi.Controls.Add(this.dgvList1);
            this.pnlAddItemBodi.Controls.Add(this.panel4);
            this.pnlAddItemBodi.Controls.Add(this.panel2);
            this.pnlAddItemBodi.Controls.Add(this.panel3);
            this.pnlAddItemBodi.Controls.Add(this.panel1);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(521, 291);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Controls.Add(this.chkRegAccount);
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 291);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(521, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            this.pnlAddItemFoter.Controls.SetChildIndex(this.btnSave, 0);
            this.pnlAddItemFoter.Controls.SetChildIndex(this.btnNew, 0);
            this.pnlAddItemFoter.Controls.SetChildIndex(this.chkRegAccount, 0);
            // 
            // btnSave
            // 
            this.btnSave.Size = new System.Drawing.Size(153, 28);
            this.btnSave.Text = "ذخیره(ثبت نهایی) F5";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(446, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(466, 13);
            this.txtDateStart.Value = new System.DateTime(2025, 11, 2, 16, 4, 40, 280);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(264, 13);
            this.txtDateEnd.Value = new System.DateTime(2025, 11, 2, 16, 4, 40, 280);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(174, 16);
            this.btnShowListItems.Click += new System.EventHandler(this.btnShowListItems_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(394, 18);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(596, 18);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(876, 347);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(879, 3);
            this.pnlAddItems.MinimumSize = new System.Drawing.Size(400, -1);
            this.pnlAddItems.Size = new System.Drawing.Size(527, 347);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(840, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(806, 0);
            this.buttonX01.Click += new System.EventHandler(this.buttonX01_Click);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(771, 0);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.FrozenColumns = 3;
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
            this.dgvList.SaveSettings = true;
            this.dgvList.SettingsKey = "frmCommission";
            this.dgvList.Size = new System.Drawing.Size(874, 237);
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
            this.txtAmount1.Location = new System.Drawing.Point(133, 4);
            this.txtAmount1.Miladi = new System.DateTime(((long)(0)));
            this.txtAmount1.Month = 0;
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.NowDateSelected = false;
            this.txtAmount1.Number = null;
            this.txtAmount1.SelectedDate = null;
            this.txtAmount1.Shamsi = null;
            this.txtAmount1.Size = new System.Drawing.Size(141, 28);
            this.txtAmount1.TabIndex = 1;
            this.txtAmount1.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtAmount1.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtAmount1.TextSimple = "";
            this.txtAmount1.TextWatermark = null;
            this.txtAmount1.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtAmount1.Year = 0;
            this.txtAmount1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(436, 10);
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
            this.label1.Location = new System.Drawing.Point(469, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "بارنامه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(436, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 99;
            this.label3.Text = "نــوع پورسانت:";
            // 
            // txtDate
            // 
            this.txtDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate.Location = new System.Drawing.Point(287, 5);
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
            this.label4.Location = new System.Drawing.Point(436, 72);
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
            this.label5.Location = new System.Drawing.Point(274, 9);
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
            this.cmbComers1.Location = new System.Drawing.Point(341, 4);
            this.cmbComers1.Name = "cmbComers1";
            this.cmbComers1.SelectedIndex = -1;
            this.cmbComers1.SelectedItem = null;
            this.cmbComers1.Size = new System.Drawing.Size(128, 30);
            this.cmbComers1.TabIndex = 0;
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
            this.btnShowComers.Location = new System.Drawing.Point(323, 5);
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
            this.cmbCommissionType.Location = new System.Drawing.Point(167, 35);
            this.cmbCommissionType.Name = "cmbCommissionType";
            this.cmbCommissionType.SelectedIndex = -1;
            this.cmbCommissionType.SelectedItem = null;
            this.cmbCommissionType.Size = new System.Drawing.Size(266, 30);
            this.cmbCommissionType.TabIndex = 1;
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
            this.buttonX3.Location = new System.Drawing.Point(148, 67);
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
            this.cmbCustomer.Location = new System.Drawing.Point(167, 67);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.SelectedIndex = -1;
            this.cmbCustomer.SelectedItem = null;
            this.cmbCustomer.Size = new System.Drawing.Size(266, 30);
            this.cmbCustomer.TabIndex = 2;
            this.cmbCustomer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCustomer.ValueMember = "id";
            this.cmbCustomer.ValueChanged += new System.EventHandler(this.cmbCustomer_ValueChanged);
            // 
            // txtDes
            // 
            this.txtDes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDes.CheackCodeMeli = false;
            this.txtDes.Day = 0;
            this.txtDes.Location = new System.Drawing.Point(3, 3);
            this.txtDes.Miladi = new System.DateTime(((long)(0)));
            this.txtDes.Month = 0;
            this.txtDes.Name = "txtDes";
            this.txtDes.NowDateSelected = false;
            this.txtDes.Number = null;
            this.txtDes.SelectedDate = null;
            this.txtDes.Shamsi = null;
            this.txtDes.Size = new System.Drawing.Size(437, 28);
            this.txtDes.TabIndex = 4;
            this.txtDes.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtDes.TextSimple = "";
            this.txtDes.TextWatermark = null;
            this.txtDes.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtDes.Year = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(446, 8);
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
            this.btnCreatFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreatFile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnCreatFile.Location = new System.Drawing.Point(127, 0);
            this.btnCreatFile.Name = "btnCreatFile";
            this.btnCreatFile.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnCreatFile.Size = new System.Drawing.Size(116, 25);
            this.btnCreatFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreatFile.Symbol = "";
            this.btnCreatFile.SymbolColor = System.Drawing.Color.LimeGreen;
            this.btnCreatFile.SymbolSize = 15F;
            this.btnCreatFile.TabIndex = 0;
            this.btnCreatFile.Text = "ایجاد فایل";
            this.btnCreatFile.Click += new System.EventHandler(this.btnCreatFile_Click);
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
            this.dgvList1.Location = new System.Drawing.Point(0, 167);
            this.dgvList1.Name = "dgvList1";
            this.dgvList1.RecordNavigator = true;
            this.dgvList1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.dgvList1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList1.Size = new System.Drawing.Size(521, 90);
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
            this.panel2.Controls.Add(this.btnCreatFile);
            this.panel2.Controls.Add(this.btnImportFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 25);
            this.panel2.TabIndex = 2;
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
            this.btnImportFile.Size = new System.Drawing.Size(127, 25);
            this.btnImportFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportFile.Symbol = "";
            this.btnImportFile.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnImportFile.SymbolSize = 15F;
            this.btnImportFile.TabIndex = 1;
            this.btnImportFile.Text = "دریافت از فایل";
            this.btnImportFile.Tooltip = "ورود اطلاعات از فایل اکسل به لیست";
            this.btnImportFile.Click += new System.EventHandler(this.btnSelectList_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Size = new System.Drawing.Size(521, 104);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddTolist
            // 
            this.btnAddTolist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddTolist.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTolist.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddTolist.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddTolist.Location = new System.Drawing.Point(3, 5);
            this.btnAddTolist.Name = "btnAddTolist";
            this.btnAddTolist.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddTolist.Size = new System.Drawing.Size(124, 25);
            this.btnAddTolist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddTolist.Symbol = "";
            this.btnAddTolist.SymbolSize = 15F;
            this.btnAddTolist.TabIndex = 2;
            this.btnAddTolist.Text = "افزودن به لیست";
            this.btnAddTolist.Click += new System.EventHandler(this.btnAddTolist_Click);
            // 
            // chkRegAccount
            // 
            this.chkRegAccount.AutoSize = true;
            this.chkRegAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkRegAccount.Location = new System.Drawing.Point(153, 0);
            this.chkRegAccount.Name = "chkRegAccount";
            this.chkRegAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRegAccount.Size = new System.Drawing.Size(140, 28);
            this.chkRegAccount.TabIndex = 2;
            this.chkRegAccount.Text = "ثبت سند حســابداری";
            this.chkRegAccount.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtAmount1);
            this.panel3.Controls.Add(this.cmbComers1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnAddTolist);
            this.panel3.Controls.Add(this.btnShowComers);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 38);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDes);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 257);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(521, 34);
            this.panel4.TabIndex = 109;
            // 
            // cmsdgv
            // 
            this.cmsdgv.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.dropDownCommand1,
            this.dropDownCommand2,
            this.separatorCommand1,
            this.dropDownCommand3,
            this.dropDownCommand4,
            this.dropDownCommand5});
            this.cmsdgv.Name = "cmsdgv";
            this.cmsdgv.CommandClick += new Janus.Windows.Ribbon.CommandEventHandler(this.ribbonContextMenu1_CommandClick);
            // 
            // dropDownCommand1
            // 
            this.dropDownCommand1.Key = "Edit";
            this.dropDownCommand1.Name = "dropDownCommand1";
            this.dropDownCommand1.Text = "ویرایش";
            // 
            // dropDownCommand2
            // 
            this.dropDownCommand2.Key = "Delete";
            this.dropDownCommand2.Name = "dropDownCommand2";
            this.dropDownCommand2.Text = "حذف";
            // 
            // separatorCommand1
            // 
            this.separatorCommand1.Key = "separatorCommand1";
            this.separatorCommand1.Name = "separatorCommand1";
            // 
            // dropDownCommand3
            // 
            this.dropDownCommand3.Key = "AddDocumentToBanck";
            this.dropDownCommand3.Name = "dropDownCommand3";
            this.dropDownCommand3.Text = "ثبت مدارک";
            // 
            // dropDownCommand4
            // 
            this.dropDownCommand4.Key = "AddTransectionDocument";
            this.dropDownCommand4.Name = "dropDownCommand4";
            this.dropDownCommand4.Text = "ثبت سند حسابداری";
            // 
            // dropDownCommand5
            // 
            this.dropDownCommand5.Key = "detailsComersHB";
            this.dropDownCommand5.Name = "dropDownCommand5";
            this.dropDownCommand5.Text = "مشخصات حواله و بارنامه";
            // 
            // frmCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 353);
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
            this.pnlAddItemFoter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).EndInit();
            ((System.Configuration.IPersistComponentSettings)(this.dgvList)).LoadComponentSettings();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCommissionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        public GridExEx.GridExEx dgvList1;
        private System.Windows.Forms.Panel panel2;
        public DevComponents.DotNetBar.ButtonX btnImportFile;
        private System.Windows.Forms.CheckBox chkRegAccount;
        public DevComponents.DotNetBar.ButtonX btnAddTolist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Janus.Windows.Ribbon.RibbonContextMenu cmsdgv;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand2;
        private Janus.Windows.Ribbon.SeparatorCommand separatorCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand3;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand4;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand5;
    }
}