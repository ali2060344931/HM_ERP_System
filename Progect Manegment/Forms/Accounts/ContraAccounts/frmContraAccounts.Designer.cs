namespace HM_ERP_System.Forms.Accounts.ContraAccounts
{
    partial class frmContraAccounts
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
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContraAccounts));
            Janus.Windows.GridEX.GridEXLayout cmbTypeAccounts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbNatureAccounts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbBanck_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbType_Account_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.cmbTypeAccounts = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodeAccount = new System.Windows.Forms.Label();
            this.txtAmount = new DevComponents.Editors.DoubleInput();
            this.cmbNatureAccounts = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnAddBanck = new DevComponents.DotNetBar.ButtonX();
            this.cmbBanck = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbType_Account = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeryalShaba = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtDabitCardNumber = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBanckName = new System.Windows.Forms.Label();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNatureAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType_Account)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(655, 550);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(655, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 600);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(655, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.panel2);
            this.pnlAddItemBodi.Controls.Add(this.btnAddBanck);
            this.pnlAddItemBodi.Controls.Add(this.cmbBanck);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.panel1);
            this.pnlAddItemBodi.Controls.Add(this.lblBanckName);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label7);
            this.pnlAddItemBodi.Controls.Add(this.cmbTypeAccounts);
            this.pnlAddItemBodi.Controls.Add(this.txtName);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(375, 600);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 600);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(375, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(300, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(416, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 7, 11, 12, 44, 8, 582);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(214, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 7, 11, 12, 44, 8, 583);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(124, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(344, 17);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(546, 17);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(657, 656);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(660, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(381, 656);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(621, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(587, 0);
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
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
            this.dgvList.Size = new System.Drawing.Size(655, 550);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 83;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(32, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 28);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // cmbTypeAccounts
            // 
            this.cmbTypeAccounts.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbTypeAccounts.DataMember = "id";
            cmbTypeAccounts_DesignTimeLayout.LayoutString = resources.GetString("cmbTypeAccounts_DesignTimeLayout.LayoutString");
            this.cmbTypeAccounts.DesignTimeLayout = cmbTypeAccounts_DesignTimeLayout;
            this.cmbTypeAccounts.DisplayMember = "Name";
            this.cmbTypeAccounts.Location = new System.Drawing.Point(32, 18);
            this.cmbTypeAccounts.Name = "cmbTypeAccounts";
            this.cmbTypeAccounts.SelectedIndex = -1;
            this.cmbTypeAccounts.SelectedItem = null;
            this.cmbTypeAccounts.Size = new System.Drawing.Size(221, 28);
            this.cmbTypeAccounts.TabIndex = 0;
            this.cmbTypeAccounts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbTypeAccounts.ValueMember = "id";
            this.cmbTypeAccounts.ValueChanged += new System.EventHandler(this.cmbTypeAccounts_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(255, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 99;
            this.label7.Text = "عنوان حســـاب:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(255, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "نام حساب:";
            this.label1.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCodeAccount);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.cmbNatureAccounts);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(99, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 108);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // lblCodeAccount
            // 
            this.lblCodeAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodeAccount.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCodeAccount.Location = new System.Drawing.Point(24, 10);
            this.lblCodeAccount.Name = "lblCodeAccount";
            this.lblCodeAccount.Size = new System.Drawing.Size(130, 23);
            this.lblCodeAccount.TabIndex = 108;
            this.lblCodeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmount.ButtonCalculator.Visible = true;
            this.txtAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtAmount.DisplayFormat = "#,##0";
            this.txtAmount.Increment = 1D;
            this.txtAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtAmount.Location = new System.Drawing.Point(22, 36);
            this.txtAmount.MaxValue = 1797693134862.3157D;
            this.txtAmount.MinValue = 0D;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(132, 28);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.txtAmount.WatermarkText = "مبــــلغ";
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // cmbNatureAccounts
            // 
            this.cmbNatureAccounts.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbNatureAccounts.DataMember = "id";
            cmbNatureAccounts_DesignTimeLayout.LayoutString = resources.GetString("cmbNatureAccounts_DesignTimeLayout.LayoutString");
            this.cmbNatureAccounts.DesignTimeLayout = cmbNatureAccounts_DesignTimeLayout;
            this.cmbNatureAccounts.DisplayMember = "Name";
            this.cmbNatureAccounts.Location = new System.Drawing.Point(22, 69);
            this.cmbNatureAccounts.Name = "cmbNatureAccounts";
            this.cmbNatureAccounts.SelectedIndex = -1;
            this.cmbNatureAccounts.SelectedItem = null;
            this.cmbNatureAccounts.Size = new System.Drawing.Size(132, 28);
            this.cmbNatureAccounts.TabIndex = 1;
            this.cmbNatureAccounts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbNatureAccounts.ValueMember = "id";
            this.cmbNatureAccounts.ValueChanged += new System.EventHandler(this.cmbNatureAccounts_ValueChanged);
            this.cmbNatureAccounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(154, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 109;
            this.label3.Text = "کد حســاب:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(154, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 18);
            this.label19.TabIndex = 106;
            this.label19.Text = "ماهیت:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(154, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 18);
            this.label18.TabIndex = 107;
            this.label18.Text = "مانده ابتدای دوره:";
            // 
            // btnAddBanck
            // 
            this.btnAddBanck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddBanck.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBanck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddBanck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddBanck.Location = new System.Drawing.Point(14, 52);
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
            this.cmbBanck.Location = new System.Drawing.Point(32, 50);
            this.cmbBanck.Name = "cmbBanck";
            this.cmbBanck.SelectedIndex = -1;
            this.cmbBanck.SelectedItem = null;
            this.cmbBanck.Size = new System.Drawing.Size(221, 30);
            this.cmbBanck.TabIndex = 1;
            this.cmbBanck.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.cmbBanck.ValueMember = "id";
            this.cmbBanck.ValueChanged += new System.EventHandler(this.cmbBanck_ValueChanged);
            this.cmbBanck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBanck_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(253, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 156;
            this.label4.Text = "شعبه بانک:";
            // 
            // cmbType_Account
            // 
            this.cmbType_Account.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbType_Account.DataMember = "id";
            cmbType_Account_DesignTimeLayout.LayoutString = resources.GetString("cmbType_Account_DesignTimeLayout.LayoutString");
            this.cmbType_Account.DesignTimeLayout = cmbType_Account_DesignTimeLayout;
            this.cmbType_Account.DisplayMember = "Name";
            this.cmbType_Account.Location = new System.Drawing.Point(107, 6);
            this.cmbType_Account.Name = "cmbType_Account";
            this.cmbType_Account.SelectedIndex = -1;
            this.cmbType_Account.SelectedItem = null;
            this.cmbType_Account.Size = new System.Drawing.Size(132, 28);
            this.cmbType_Account.TabIndex = 0;
            this.cmbType_Account.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbType_Account.ValueMember = "id";
            this.cmbType_Account.ValueChanged += new System.EventHandler(this.cmbTypeAccount_ValueChanged);
            this.cmbType_Account.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(241, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 99;
            this.label2.Text = "نوع حســــــــاب:";
            this.label2.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(241, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 161;
            this.label5.Text = "شماره شبــــــــا:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(241, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 162;
            this.label6.Text = "شماره کـــــارت:";
            // 
            // txtSeryalShaba
            // 
            this.txtSeryalShaba.Location = new System.Drawing.Point(30, 106);
            this.txtSeryalShaba.MaxLength = 24;
            this.txtSeryalShaba.Name = "txtSeryalShaba";
            this.txtSeryalShaba.Size = new System.Drawing.Size(209, 28);
            this.txtSeryalShaba.TabIndex = 3;
            this.txtSeryalShaba.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtSeryalShaba.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtDabitCardNumber
            // 
            this.txtDabitCardNumber.Location = new System.Drawing.Point(30, 74);
            this.txtDabitCardNumber.MaxLength = 16;
            this.txtDabitCardNumber.Name = "txtDabitCardNumber";
            this.txtDabitCardNumber.Size = new System.Drawing.Size(209, 28);
            this.txtDabitCardNumber.TabIndex = 2;
            this.txtDabitCardNumber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtDabitCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(10, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 23);
            this.label9.TabIndex = 163;
            this.label9.Text = "IR";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(30, 40);
            this.txtAccountNumber.MaxLength = 16;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(209, 28);
            this.txtAccountNumber.TabIndex = 1;
            this.txtAccountNumber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtAccountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(241, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 162;
            this.label8.Text = "شماره حساب:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbType_Account);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDabitCardNumber);
            this.panel2.Controls.Add(this.txtSeryalShaba);
            this.panel2.Controls.Add(this.txtAccountNumber);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(14, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 142);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // lblBanckName
            // 
            this.lblBanckName.BackColor = System.Drawing.Color.Transparent;
            this.lblBanckName.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBanckName.Location = new System.Drawing.Point(32, 83);
            this.lblBanckName.Name = "lblBanckName";
            this.lblBanckName.Size = new System.Drawing.Size(221, 18);
            this.lblBanckName.TabIndex = 99;
            this.lblBanckName.Text = "نام بانک";
            this.lblBanckName.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmContraAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 662);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmContraAccounts";
            this.Text = "تعریف حساب های نقد(صندوق) و بانک";
            this.Load += new System.EventHandler(this.frmContraAccounts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmContraAccounts_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNatureAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType_Account)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbTypeAccounts;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.Editors.DoubleInput txtAmount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbNatureAccounts;
        private System.Windows.Forms.Label lblCodeAccount;
        private System.Windows.Forms.Label label3;
        public DevComponents.DotNetBar.ButtonX btnAddBanck;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbBanck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbType_Account;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Janus.Windows.GridEX.EditControls.EditBox txtSeryalShaba;
        private Janus.Windows.GridEX.EditControls.EditBox txtDabitCardNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.GridEX.EditControls.EditBox txtAccountNumber;
        private System.Windows.Forms.Label lblBanckName;
    }
}