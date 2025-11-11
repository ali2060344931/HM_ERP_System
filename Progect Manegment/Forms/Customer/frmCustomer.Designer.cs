namespace HM_ERP_System.Forms.Customer
{
    partial class frmCustomer
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
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvList_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column23.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            Janus.Windows.GridEX.GridEXLayout cmbTypeCustomer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCity_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference cmbCity_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.WatermarkImage.Image");
            Janus.Windows.GridEX.GridEXLayout cmbGroup_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbBanck_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.cmbTypeCustomer = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtFamily = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtTel1 = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtAdders1 = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtCodMeli = new MyClass.MyTextBox();
            this.txtDes = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtDabitCardNumber = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtSeryalShaba = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.lblCcodeMeli = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel2 = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdders2 = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPostalCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chkControlCodeMeli = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbCity = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cmbGroup = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnAddGroup = new DevComponents.DotNetBar.ButtonX();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAddCustomerByExcelFil = new DevComponents.DotNetBar.ButtonX();
            this.cmsdgv = new Janus.Windows.Ribbon.RibbonContextMenu(this.components);
            this.dropDownCommand1 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand2 = new Janus.Windows.Ribbon.DropDownCommand();
            this.separatorCommand1 = new Janus.Windows.Ribbon.SeparatorCommand();
            this.dropDownCommand3 = new Janus.Windows.Ribbon.DropDownCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewCity = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBanck = new DevComponents.DotNetBar.ButtonX();
            this.cmbBanck = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnCratMelyCode = new DevComponents.DotNetBar.ButtonX();
            this.btnRepC1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanck)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(742, 511);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(742, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Controls.Add(this.btnAddCustomerByExcelFil);
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 561);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(742, 28);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.buttonX01, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnExportToExcel, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnAddCustomerByExcelFil, 0);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.btnAddBanck);
            this.pnlAddItemBodi.Controls.Add(this.cmbBanck);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewCity);
            this.pnlAddItemBodi.Controls.Add(this.cmbCity);
            this.pnlAddItemBodi.Controls.Add(this.cmbGroup);
            this.pnlAddItemBodi.Controls.Add(this.label20);
            this.pnlAddItemBodi.Controls.Add(this.btnCratMelyCode);
            this.pnlAddItemBodi.Controls.Add(this.btnAddGroup);
            this.pnlAddItemBodi.Controls.Add(this.chkControlCodeMeli);
            this.pnlAddItemBodi.Controls.Add(this.label8);
            this.pnlAddItemBodi.Controls.Add(this.label7);
            this.pnlAddItemBodi.Controls.Add(this.label6);
            this.pnlAddItemBodi.Controls.Add(this.label12);
            this.pnlAddItemBodi.Controls.Add(this.label13);
            this.pnlAddItemBodi.Controls.Add(this.label11);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label10);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.lblCcodeMeli);
            this.pnlAddItemBodi.Controls.Add(this.lblFamily);
            this.pnlAddItemBodi.Controls.Add(this.lblName);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label24);
            this.pnlAddItemBodi.Controls.Add(this.txtCodMeli);
            this.pnlAddItemBodi.Controls.Add(this.cmbTypeCustomer);
            this.pnlAddItemBodi.Controls.Add(this.txtDes);
            this.pnlAddItemBodi.Controls.Add(this.txtSeryalShaba);
            this.pnlAddItemBodi.Controls.Add(this.txtDabitCardNumber);
            this.pnlAddItemBodi.Controls.Add(this.txtPostalCode);
            this.pnlAddItemBodi.Controls.Add(this.txtAdders2);
            this.pnlAddItemBodi.Controls.Add(this.txtAdders1);
            this.pnlAddItemBodi.Controls.Add(this.txtTel2);
            this.pnlAddItemBodi.Controls.Add(this.txtTel1);
            this.pnlAddItemBodi.Controls.Add(this.txtFamily);
            this.pnlAddItemBodi.Controls.Add(this.txtName);
            this.pnlAddItemBodi.Controls.Add(this.label9);
            this.pnlAddItemBodi.Controls.Add(this.label21);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label17);
            this.pnlAddItemBodi.Controls.Add(this.label16);
            this.pnlAddItemBodi.Controls.Add(this.label15);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(345, 555);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 555);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(345, 34);
            // 
            // btnSave
            // 
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(270, 0);
            this.btnNew.Size = new System.Drawing.Size(75, 34);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(503, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 6, 20, 17, 4, 6, 98);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(301, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 6, 20, 17, 4, 6, 98);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(211, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(431, 17);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(633, 17);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Location = new System.Drawing.Point(3, 25);
            this.pnlViewItems.Size = new System.Drawing.Size(744, 617);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(747, 25);
            this.pnlAddItems.Size = new System.Drawing.Size(351, 617);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(612, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.AutoExpandOnClick = true;
            this.buttonX01.Location = new System.Drawing.Point(646, 0);
            this.buttonX01.Size = new System.Drawing.Size(96, 28);
            this.buttonX01.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnRepC1,
            this.buttonItem1});
            this.buttonX01.Text = "گزارشات";
            this.buttonX01.Click += new System.EventHandler(this.buttonX1_Click);
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
            dgvList_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("dgvList_Layout_0_Reference_0.Instance")));
            dgvList_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            dgvList_Layout_0_Reference_0});
            dgvList_Layout_0.LayoutString = resources.GetString("dgvList_Layout_0.LayoutString");
            this.dgvList.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvList_Layout_0});
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RecordNavigator = true;
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvList.SettingsKey = "frmCustomer";
            this.dgvList.Size = new System.Drawing.Size(742, 511);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 84;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // cmbTypeCustomer
            // 
            this.cmbTypeCustomer.DataMember = "id";
            cmbTypeCustomer_DesignTimeLayout.LayoutString = resources.GetString("cmbTypeCustomer_DesignTimeLayout.LayoutString");
            this.cmbTypeCustomer.DesignTimeLayout = cmbTypeCustomer_DesignTimeLayout;
            this.cmbTypeCustomer.DisplayMember = "Name";
            this.cmbTypeCustomer.Location = new System.Drawing.Point(129, 4);
            this.cmbTypeCustomer.Name = "cmbTypeCustomer";
            this.cmbTypeCustomer.SelectedIndex = -1;
            this.cmbTypeCustomer.SelectedItem = null;
            this.cmbTypeCustomer.Size = new System.Drawing.Size(118, 28);
            this.cmbTypeCustomer.TabIndex = 0;
            this.cmbTypeCustomer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbTypeCustomer.ValueMember = "id";
            this.cmbTypeCustomer.ValueChanged += new System.EventHandler(this.cmbTypeCustomer_ValueChanged);
            this.cmbTypeCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(38, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 28);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(38, 106);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(209, 28);
            this.txtFamily.TabIndex = 3;
            this.txtFamily.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtFamily.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(129, 174);
            this.txtTel1.MaxLength = 11;
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(118, 28);
            this.txtTel1.TabIndex = 5;
            this.txtTel1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtTel1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtTel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtAdders1
            // 
            this.txtAdders1.Location = new System.Drawing.Point(38, 273);
            this.txtAdders1.Name = "txtAdders1";
            this.txtAdders1.Size = new System.Drawing.Size(209, 28);
            this.txtAdders1.TabIndex = 8;
            this.txtAdders1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtAdders1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtCodMeli
            // 
            this.txtCodMeli.CheackCodeMeli = true;
            this.txtCodMeli.CodeMeliTextLength = 11;
            this.txtCodMeli.Day = 0;
            this.txtCodMeli.Location = new System.Drawing.Point(128, 140);
            this.txtCodMeli.Miladi = new System.DateTime(((long)(0)));
            this.txtCodMeli.Month = 0;
            this.txtCodMeli.Name = "txtCodMeli";
            this.txtCodMeli.NowDateSelected = false;
            this.txtCodMeli.Number = null;
            this.txtCodMeli.SelectedDate = null;
            this.txtCodMeli.Shamsi = null;
            this.txtCodMeli.Size = new System.Drawing.Size(118, 28);
            this.txtCodMeli.TabIndex = 4;
            this.txtCodMeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodMeli.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtCodMeli.TextMode = MyClass.MyTextBox.TextBoxMode.CodMeli;
            this.txtCodMeli.TextSimple = "";
            this.txtCodMeli.TextWatermark = null;
            this.txtCodMeli.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtCodMeli.Year = 0;
            this.txtCodMeli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(38, 476);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(209, 56);
            this.txtDes.TabIndex = 14;
            this.txtDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtDabitCardNumber
            // 
            this.txtDabitCardNumber.Location = new System.Drawing.Point(38, 410);
            this.txtDabitCardNumber.MaxLength = 16;
            this.txtDabitCardNumber.Name = "txtDabitCardNumber";
            this.txtDabitCardNumber.Size = new System.Drawing.Size(209, 28);
            this.txtDabitCardNumber.TabIndex = 12;
            this.txtDabitCardNumber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtDabitCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtDabitCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtSeryalShaba
            // 
            this.txtSeryalShaba.Location = new System.Drawing.Point(38, 442);
            this.txtSeryalShaba.MaxLength = 24;
            this.txtSeryalShaba.Name = "txtSeryalShaba";
            this.txtSeryalShaba.Size = new System.Drawing.Size(209, 28);
            this.txtSeryalShaba.TabIndex = 13;
            this.txtSeryalShaba.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtSeryalShaba.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtSeryalShaba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label24.Location = new System.Drawing.Point(252, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 18);
            this.label24.TabIndex = 98;
            this.label24.Text = "نوع شخص:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(252, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 18);
            this.lblName.TabIndex = 98;
            this.lblName.Text = "نام:";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.BackColor = System.Drawing.Color.Transparent;
            this.lblFamily.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFamily.Location = new System.Drawing.Point(252, 111);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(73, 18);
            this.lblFamily.TabIndex = 98;
            this.lblFamily.Text = "نام خانوادگی:";
            // 
            // lblCcodeMeli
            // 
            this.lblCcodeMeli.AutoSize = true;
            this.lblCcodeMeli.BackColor = System.Drawing.Color.Transparent;
            this.lblCcodeMeli.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCcodeMeli.Location = new System.Drawing.Point(252, 147);
            this.lblCcodeMeli.Name = "lblCcodeMeli";
            this.lblCcodeMeli.Size = new System.Drawing.Size(46, 18);
            this.lblCcodeMeli.TabIndex = 98;
            this.lblCcodeMeli.Text = "کد ملی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(252, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "تلفن 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(252, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 98;
            this.label5.Text = "آدرس 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(252, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 98;
            this.label6.Text = "شماره کارت:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(252, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 98;
            this.label7.Text = "شماره شبا:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(255, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 98;
            this.label8.Text = "توضیحات:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(18, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 23);
            this.label9.TabIndex = 98;
            this.label9.Text = "IR";
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(129, 208);
            this.txtTel2.MaxLength = 11;
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(118, 28);
            this.txtTel2.TabIndex = 6;
            this.txtTel2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtTel2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtTel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(252, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 98;
            this.label10.Text = "تلفن 2:";
            // 
            // txtAdders2
            // 
            this.txtAdders2.Location = new System.Drawing.Point(38, 307);
            this.txtAdders2.Name = "txtAdders2";
            this.txtAdders2.Size = new System.Drawing.Size(209, 28);
            this.txtAdders2.TabIndex = 9;
            this.txtAdders2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtAdders2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(252, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 98;
            this.label11.Text = "آدرس 2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(252, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 98;
            this.label12.Text = "نام بانک:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(129, 341);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(118, 28);
            this.txtPostalCode.TabIndex = 10;
            this.txtPostalCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtPostalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(252, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 98;
            this.label13.Text = "کد پستی:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(116, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 98;
            this.label3.Text = "*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(25, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 18);
            this.label14.TabIndex = 98;
            this.label14.Text = "*";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(25, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 18);
            this.label15.TabIndex = 98;
            this.label15.Text = "*";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(78, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 18);
            this.label16.TabIndex = 98;
            this.label16.Text = "*";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(116, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 18);
            this.label17.TabIndex = 98;
            this.label17.Text = "*";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkControlCodeMeli
            // 
            this.chkControlCodeMeli.AutoSize = true;
            this.chkControlCodeMeli.Location = new System.Drawing.Point(93, 147);
            this.chkControlCodeMeli.Name = "chkControlCodeMeli";
            this.chkControlCodeMeli.Size = new System.Drawing.Size(15, 14);
            this.chkControlCodeMeli.TabIndex = 99;
            this.toolTip1.SetToolTip(this.chkControlCodeMeli, "جهت کنترل صحیح بودن کد ملی اشخاص");
            this.chkControlCodeMeli.UseVisualStyleBackColor = true;
            this.chkControlCodeMeli.CheckedChanged += new System.EventHandler(this.chkControlCodeMeli_CheckedChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.DataMember = "id";
            cmbCity_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("cmbCity_DesignTimeLayout_Reference_0.Instance")));
            cmbCity_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            cmbCity_DesignTimeLayout_Reference_0});
            cmbCity_DesignTimeLayout.LayoutString = resources.GetString("cmbCity_DesignTimeLayout.LayoutString");
            this.cmbCity.DesignTimeLayout = cmbCity_DesignTimeLayout;
            this.cmbCity.DisplayMember = "CiltyName";
            this.cmbCity.Image = ((System.Drawing.Image)(resources.GetObject("cmbCity.Image")));
            this.cmbCity.Location = new System.Drawing.Point(38, 239);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.SelectedIndex = -1;
            this.cmbCity.SelectedItem = null;
            this.cmbCity.Size = new System.Drawing.Size(209, 30);
            this.cmbCity.TabIndex = 7;
            this.cmbCity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.toolTip1.SetToolTip(this.cmbCity, "F2 جستجوی بر اساس فیلدها");
            this.cmbCity.ValueMember = "id";
            this.cmbCity.ValueChanged += new System.EventHandler(this.cmbCity_ValueChanged);
            this.cmbCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCity_KeyDown);
            // 
            // cmbGroup
            // 
            this.cmbGroup.ButtonCancelText = "انصراف";
            this.cmbGroup.ButtonOKText = "تائید";
            cmbGroup_DesignTimeLayout.LayoutString = resources.GetString("cmbGroup_DesignTimeLayout.LayoutString");
            this.cmbGroup.DesignTimeLayout = cmbGroup_DesignTimeLayout;
            this.cmbGroup.DropDownDisplayMember = "Name";
            this.cmbGroup.DropDownValueMember = "id";
            this.cmbGroup.Location = new System.Drawing.Point(38, 37);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.SaveSettings = false;
            this.cmbGroup.Size = new System.Drawing.Size(209, 28);
            this.cmbGroup.TabIndex = 1;
            this.cmbGroup.ValuesDataMember = null;
            this.cmbGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.Location = new System.Drawing.Point(252, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 18);
            this.label20.TabIndex = 114;
            this.label20.Text = "گروه ها:";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddGroup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddGroup.Location = new System.Drawing.Point(17, 37);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddGroup.Size = new System.Drawing.Size(20, 28);
            this.btnAddGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddGroup.Symbol = "";
            this.btnAddGroup.SymbolSize = 12F;
            this.btnAddGroup.TabIndex = 113;
            this.btnAddGroup.TabStop = false;
            this.btnAddGroup.Tooltip = "ثبت آیتم جدید";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(5, 42);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 18);
            this.label21.TabIndex = 98;
            this.label21.Text = "*";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCustomerByExcelFil
            // 
            this.btnAddCustomerByExcelFil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCustomerByExcelFil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCustomerByExcelFil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddCustomerByExcelFil.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddCustomerByExcelFil.Location = new System.Drawing.Point(0, 0);
            this.btnAddCustomerByExcelFil.Name = "btnAddCustomerByExcelFil";
            this.btnAddCustomerByExcelFil.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddCustomerByExcelFil.Size = new System.Drawing.Size(194, 28);
            this.btnAddCustomerByExcelFil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCustomerByExcelFil.Symbol = "59390";
            this.btnAddCustomerByExcelFil.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnAddCustomerByExcelFil.SymbolSize = 20F;
            this.btnAddCustomerByExcelFil.TabIndex = 114;
            this.btnAddCustomerByExcelFil.TabStop = false;
            this.btnAddCustomerByExcelFil.Text = "افزودن اشخاص از فایل اکسل";
            this.btnAddCustomerByExcelFil.Tooltip = "ثبت آیتم جدید";
            this.btnAddCustomerByExcelFil.Click += new System.EventHandler(this.btnAddCustomerByExcelFil_Click);
            // 
            // cmsdgv
            // 
            this.cmsdgv.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.dropDownCommand1,
            this.dropDownCommand2,
            this.separatorCommand1,
            this.dropDownCommand3});
            this.cmsdgv.Name = "cmsdgv";
            this.cmsdgv.CommandClick += new Janus.Windows.Ribbon.CommandEventHandler(this.cmsdgv_CommandClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(249, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "نام شهــر:";
            // 
            // btnAddNewCity
            // 
            this.btnAddNewCity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewCity.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewCity.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewCity.Location = new System.Drawing.Point(19, 240);
            this.btnAddNewCity.Name = "btnAddNewCity";
            this.btnAddNewCity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewCity.Size = new System.Drawing.Size(18, 28);
            this.btnAddNewCity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewCity.Symbol = "";
            this.btnAddNewCity.SymbolSize = 15F;
            this.btnAddNewCity.TabIndex = 116;
            this.btnAddNewCity.TabStop = false;
            this.btnAddNewCity.Tooltip = "ثبت آیتم جدید";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 98;
            this.label2.Text = "*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddBanck
            // 
            this.btnAddBanck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddBanck.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBanck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddBanck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddBanck.Location = new System.Drawing.Point(19, 375);
            this.btnAddBanck.Name = "btnAddBanck";
            this.btnAddBanck.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddBanck.Size = new System.Drawing.Size(18, 28);
            this.btnAddBanck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddBanck.Symbol = "";
            this.btnAddBanck.SymbolSize = 15F;
            this.btnAddBanck.TabIndex = 158;
            this.btnAddBanck.TabStop = false;
            this.btnAddBanck.Tooltip = "ثبت آیتم جدید";
            this.btnAddBanck.Click += new System.EventHandler(this.btnAddBanck_Click);
            // 
            // cmbBanck
            // 
            this.cmbBanck.DataMember = "id";
            cmbBanck_DesignTimeLayout.LayoutString = resources.GetString("cmbBanck_DesignTimeLayout.LayoutString");
            this.cmbBanck.DesignTimeLayout = cmbBanck_DesignTimeLayout;
            this.cmbBanck.DisplayMember = "Name";
            this.cmbBanck.Image = ((System.Drawing.Image)(resources.GetObject("cmbBanck.Image")));
            this.cmbBanck.Location = new System.Drawing.Point(38, 375);
            this.cmbBanck.Name = "cmbBanck";
            this.cmbBanck.SelectedIndex = -1;
            this.cmbBanck.SelectedItem = null;
            this.cmbBanck.Size = new System.Drawing.Size(209, 30);
            this.cmbBanck.TabIndex = 11;
            this.cmbBanck.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.cmbBanck.ValueMember = "id";
            this.cmbBanck.ValueChanged += new System.EventHandler(this.cmbBanck_ValueChanged);
            this.cmbBanck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBanck_KeyDown);
            // 
            // btnCratMelyCode
            // 
            this.btnCratMelyCode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCratMelyCode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCratMelyCode.Enabled = false;
            this.btnCratMelyCode.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnCratMelyCode.Location = new System.Drawing.Point(108, 140);
            this.btnCratMelyCode.Name = "btnCratMelyCode";
            this.btnCratMelyCode.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnCratMelyCode.Size = new System.Drawing.Size(20, 28);
            this.btnCratMelyCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCratMelyCode.Symbol = "";
            this.btnCratMelyCode.SymbolSize = 12F;
            this.btnCratMelyCode.TabIndex = 113;
            this.btnCratMelyCode.TabStop = false;
            this.btnCratMelyCode.Tooltip = "ایجاد کد ملی مجازی";
            this.btnCratMelyCode.Click += new System.EventHandler(this.btnCratMelyCode_Click);
            // 
            // btnRepC1
            // 
            this.btnRepC1.GlobalItem = false;
            this.btnRepC1.Name = "btnRepC1";
            this.btnRepC1.Text = "گزارش از لیست اشخاص";
            this.btnRepC1.Click += new System.EventHandler(this.btnRepC1_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalItem = false;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "گزارش pdf";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 645);
            this.KeyPreview = true;
            this.Name = "frmCustomer";
            this.Text = "فرم ثبت اشخاص";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCustomer_KeyDown);
            this.Controls.SetChildIndex(this.pnlAddItems, 0);
            this.Controls.SetChildIndex(this.pnlViewItems, 0);
            this.pnlViewItemBody.ResumeLayout(false);
            this.pnlViewItemHeder.ResumeLayout(false);
            this.pnlViewItemHeder.PerformLayout();
            this.pnlViewItemFoter.ResumeLayout(false);
            this.pnlAddItemBodi.ResumeLayout(false);
            this.pnlAddItemBodi.PerformLayout();
            this.pnlAddItemFoter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        private Janus.Windows.GridEX.EditControls.EditBox txtFamily;
        private MyClass.MyTextBox txtCodMeli;
        private Janus.Windows.GridEX.EditControls.EditBox txtDes;
        private Janus.Windows.GridEX.EditControls.EditBox txtAdders1;
        private Janus.Windows.GridEX.EditControls.EditBox txtTel1;
        private Janus.Windows.GridEX.EditControls.EditBox txtSeryalShaba;
        private Janus.Windows.GridEX.EditControls.EditBox txtDabitCardNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCcodeMeli;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Janus.Windows.GridEX.EditControls.EditBox txtAdders2;
        private Janus.Windows.GridEX.EditControls.EditBox txtTel2;
        private System.Windows.Forms.Label label13;
        private Janus.Windows.GridEX.EditControls.EditBox txtPostalCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkControlCodeMeli;
        private System.Windows.Forms.ToolTip toolTip1;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox cmbGroup;
        private System.Windows.Forms.Label label20;
        public DevComponents.DotNetBar.ButtonX btnAddGroup;
        private System.Windows.Forms.Label label21;
        public Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbTypeCustomer;
        public DevComponents.DotNetBar.ButtonX btnAddCustomerByExcelFil;
        private Janus.Windows.Ribbon.RibbonContextMenu cmsdgv;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand2;
        private Janus.Windows.Ribbon.SeparatorCommand separatorCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand3;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCity;
        public DevComponents.DotNetBar.ButtonX btnAddNewCity;
        private System.Windows.Forms.Label label2;
        public DevComponents.DotNetBar.ButtonX btnAddBanck;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbBanck;
        public DevComponents.DotNetBar.ButtonX btnCratMelyCode;
        private DevComponents.DotNetBar.ButtonItem btnRepC1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
    }
}