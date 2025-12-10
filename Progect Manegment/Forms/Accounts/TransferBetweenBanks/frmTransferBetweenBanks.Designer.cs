namespace HM_ERP_System.Forms.Accounts.TransferBetweenBanks
{
    partial class frmTransferBetweenBanks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferBetweenBanks));
            Janus.Windows.GridEX.GridEXLayout cmbDetailedAccountsTo_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbDetailedAccountsFr_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.uiPanel0 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel0Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAmount2 = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.txtSeryalNumber = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.cmbDetailedAccountsTo = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtTransactionDate = new Atf.UI.DateTimeSelector();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbDetailedAccountsFr = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtAmount1 = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtDescription = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lblAccountBalancT = new System.Windows.Forms.Label();
            this.lblAccountBalancF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNewBanck2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddNewCofer2 = new DevComponents.DotNetBar.ButtonItem();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNewCustomer = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNewBanck1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddNewCofer1 = new DevComponents.DotNetBar.ButtonItem();
            this.txtTransactionCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.uiPanelGroup1 = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.uiPanel1 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel1Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.dgvList = new GridExEx.GridExEx();
            this.pnlViewItemFoter = new System.Windows.Forms.Panel();
            this.btnExportToExcel = new DevComponents.DotNetBar.ButtonX();
            this.uiPanel2 = new Janus.Windows.UI.Dock.UIPanel();
            this.uiPanel2Container = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.txtDateEnd = new Atf.UI.DateTimeSelector();
            this.btnShowListItems = new DevComponents.DotNetBar.ButtonX();
            this.txtDateStart = new Atf.UI.DateTimeSelector();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.rcmDetails = new Janus.Windows.Ribbon.RibbonContextMenu(this.components);
            this.dropDownCommand1 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand2 = new Janus.Windows.Ribbon.DropDownCommand();
            this.separatorCommand1 = new Janus.Windows.Ribbon.SeparatorCommand();
            this.dropDownCommand3 = new Janus.Windows.Ribbon.DropDownCommand();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).BeginInit();
            this.uiPanel0.SuspendLayout();
            this.uiPanel0Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDetailedAccountsTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDetailedAccountsFr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelGroup1)).BeginInit();
            this.uiPanelGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanel1Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlViewItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel2)).BeginInit();
            this.uiPanel2.SuspendLayout();
            this.uiPanel2Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.uiPanel0.Id = new System.Guid("84b0915b-8a0f-4285-8d30-20f62a2fddae");
            this.uiPanelManager1.Panels.Add(this.uiPanel0);
            this.uiPanelGroup1.Id = new System.Guid("dd164192-8471-4147-967e-d7796a3852be");
            this.uiPanel1.Id = new System.Guid("90d3c177-c66d-4a08-a198-6f7ffedfbb00");
            this.uiPanelGroup1.Panels.Add(this.uiPanel1);
            this.uiPanel2.Id = new System.Guid("ab2d85f5-78a3-4661-bbcd-ee587af56007");
            this.uiPanelGroup1.Panels.Add(this.uiPanel2);
            this.uiPanelManager1.Panels.Add(this.uiPanelGroup1);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("84b0915b-8a0f-4285-8d30-20f62a2fddae"), Janus.Windows.UI.Dock.PanelDockStyle.Top, new System.Drawing.Size(1354, 126), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("dd164192-8471-4147-967e-d7796a3852be"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Fill, false, new System.Drawing.Size(1354, 318), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("90d3c177-c66d-4a08-a198-6f7ffedfbb00"), new System.Guid("dd164192-8471-4147-967e-d7796a3852be"), 841, true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("ab2d85f5-78a3-4661-bbcd-ee587af56007"), new System.Guid("dd164192-8471-4147-967e-d7796a3852be"), 157, true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("ab2d85f5-78a3-4661-bbcd-ee587af56007"), new System.Drawing.Point(367, 463), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("90d3c177-c66d-4a08-a198-6f7ffedfbb00"), new System.Drawing.Point(330, 432), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("84b0915b-8a0f-4285-8d30-20f62a2fddae"), new System.Drawing.Point(412, 327), new System.Drawing.Size(200, 200), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // uiPanel0
            // 
            this.uiPanel0.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel0.FloatingLocation = new System.Drawing.Point(412, 327);
            this.uiPanel0.InnerContainer = this.uiPanel0Container;
            this.uiPanel0.Location = new System.Drawing.Point(3, 3);
            this.uiPanel0.Name = "uiPanel0";
            this.uiPanel0.Size = new System.Drawing.Size(1354, 126);
            this.uiPanel0.TabIndex = 4;
            this.uiPanel0.Text = "ثبت اسناد";
            this.uiPanel0.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Center;
            // 
            // uiPanel0Container
            // 
            this.uiPanel0Container.Controls.Add(this.pictureBox1);
            this.uiPanel0Container.Controls.Add(this.txtAmount2);
            this.uiPanel0Container.Controls.Add(this.label28);
            this.uiPanel0Container.Controls.Add(this.txtSeryalNumber);
            this.uiPanel0Container.Controls.Add(this.cmbDetailedAccountsTo);
            this.uiPanel0Container.Controls.Add(this.txtTransactionDate);
            this.uiPanel0Container.Controls.Add(this.label25);
            this.uiPanel0Container.Controls.Add(this.cmbDetailedAccountsFr);
            this.uiPanel0Container.Controls.Add(this.btnNew);
            this.uiPanel0Container.Controls.Add(this.btnSave);
            this.uiPanel0Container.Controls.Add(this.txtAmount1);
            this.uiPanel0Container.Controls.Add(this.txtDescription);
            this.uiPanel0Container.Controls.Add(this.lblAccountBalancT);
            this.uiPanel0Container.Controls.Add(this.lblAccountBalancF);
            this.uiPanel0Container.Controls.Add(this.label1);
            this.uiPanel0Container.Controls.Add(this.buttonX1);
            this.uiPanel0Container.Controls.Add(this.label5);
            this.uiPanel0Container.Controls.Add(this.btnAddNewCustomer);
            this.uiPanel0Container.Controls.Add(this.txtTransactionCode);
            this.uiPanel0Container.Controls.Add(this.label50);
            this.uiPanel0Container.Controls.Add(this.label2);
            this.uiPanel0Container.Controls.Add(this.label6);
            this.uiPanel0Container.Controls.Add(this.label14);
            this.uiPanel0Container.Location = new System.Drawing.Point(1, 27);
            this.uiPanel0Container.Name = "uiPanel0Container";
            this.uiPanel0Container.Size = new System.Drawing.Size(1352, 94);
            this.uiPanel0Container.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1252, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 204;
            this.pictureBox1.TabStop = false;
            // 
            // txtAmount2
            // 
            this.txtAmount2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount2.CheackCodeMeli = false;
            this.txtAmount2.Day = 0;
            this.txtAmount2.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAmount2.Location = new System.Drawing.Point(554, 55);
            this.txtAmount2.Miladi = new System.DateTime(((long)(0)));
            this.txtAmount2.Month = 0;
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.NowDateSelected = false;
            this.txtAmount2.Number = null;
            this.txtAmount2.SelectedDate = null;
            this.txtAmount2.Shamsi = null;
            this.txtAmount2.Size = new System.Drawing.Size(165, 32);
            this.txtAmount2.TabIndex = 3;
            this.txtAmount2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtAmount2.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtAmount2.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtAmount2.TextSimple = "";
            this.txtAmount2.TextWatermark = null;
            this.txtAmount2.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtAmount2.Year = 0;
            this.txtAmount2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalAmount_KeyDown);
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label28.Location = new System.Drawing.Point(721, 62);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 18);
            this.label28.TabIndex = 203;
            this.label28.Text = "مبلغ کارمزد :";
            // 
            // txtSeryalNumber
            // 
            this.txtSeryalNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeryalNumber.CheackCodeMeli = false;
            this.txtSeryalNumber.Day = 0;
            this.txtSeryalNumber.Location = new System.Drawing.Point(386, 20);
            this.txtSeryalNumber.Miladi = new System.DateTime(((long)(0)));
            this.txtSeryalNumber.Month = 0;
            this.txtSeryalNumber.Name = "txtSeryalNumber";
            this.txtSeryalNumber.NowDateSelected = false;
            this.txtSeryalNumber.Number = null;
            this.txtSeryalNumber.SelectedDate = null;
            this.txtSeryalNumber.Shamsi = null;
            this.txtSeryalNumber.Size = new System.Drawing.Size(93, 28);
            this.txtSeryalNumber.TabIndex = 4;
            this.txtSeryalNumber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtSeryalNumber.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtSeryalNumber.TextSimple = "";
            this.txtSeryalNumber.TextWatermark = null;
            this.txtSeryalNumber.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtSeryalNumber.Year = 0;
            this.txtSeryalNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalAmount_KeyDown);
            // 
            // cmbDetailedAccountsTo
            // 
            this.cmbDetailedAccountsTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDetailedAccountsTo.DataMember = "id";
            cmbDetailedAccountsTo_DesignTimeLayout.LayoutString = resources.GetString("cmbDetailedAccountsTo_DesignTimeLayout.LayoutString");
            this.cmbDetailedAccountsTo.DesignTimeLayout = cmbDetailedAccountsTo_DesignTimeLayout;
            this.cmbDetailedAccountsTo.DisplayMember = "Name";
            this.cmbDetailedAccountsTo.Image = ((System.Drawing.Image)(resources.GetObject("cmbDetailedAccountsTo.Image")));
            this.cmbDetailedAccountsTo.Location = new System.Drawing.Point(960, 56);
            this.cmbDetailedAccountsTo.MaxLength = 8;
            this.cmbDetailedAccountsTo.Name = "cmbDetailedAccountsTo";
            this.cmbDetailedAccountsTo.SelectedIndex = -1;
            this.cmbDetailedAccountsTo.SelectedItem = null;
            this.cmbDetailedAccountsTo.Size = new System.Drawing.Size(228, 30);
            this.cmbDetailedAccountsTo.TabIndex = 1;
            this.cmbDetailedAccountsTo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbDetailedAccountsTo.ValueMember = "id";
            this.cmbDetailedAccountsTo.ValueChanged += new System.EventHandler(this.cmbDetailedAccountsTo_ValueChanged);
            this.cmbDetailedAccountsTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDetailedAccountsTo_KeyDown);
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTransactionDate.Location = new System.Drawing.Point(3, 50);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTransactionDate.Size = new System.Drawing.Size(124, 29);
            this.txtTransactionDate.TabIndex = 0;
            this.txtTransactionDate.UsePersianFormat = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label25.Location = new System.Drawing.Point(126, 57);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 18);
            this.label25.TabIndex = 195;
            this.label25.Text = "تاریخ:";
            // 
            // cmbDetailedAccountsFr
            // 
            this.cmbDetailedAccountsFr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDetailedAccountsFr.DataMember = "id";
            cmbDetailedAccountsFr_DesignTimeLayout.LayoutString = resources.GetString("cmbDetailedAccountsFr_DesignTimeLayout.LayoutString");
            this.cmbDetailedAccountsFr.DesignTimeLayout = cmbDetailedAccountsFr_DesignTimeLayout;
            this.cmbDetailedAccountsFr.DisplayMember = "Name";
            this.cmbDetailedAccountsFr.Image = ((System.Drawing.Image)(resources.GetObject("cmbDetailedAccountsFr.Image")));
            this.cmbDetailedAccountsFr.Location = new System.Drawing.Point(960, 19);
            this.cmbDetailedAccountsFr.MaxLength = 8;
            this.cmbDetailedAccountsFr.Name = "cmbDetailedAccountsFr";
            this.cmbDetailedAccountsFr.SelectedIndex = -1;
            this.cmbDetailedAccountsFr.SelectedItem = null;
            this.cmbDetailedAccountsFr.Size = new System.Drawing.Size(228, 30);
            this.cmbDetailedAccountsFr.TabIndex = 0;
            this.cmbDetailedAccountsFr.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbDetailedAccountsFr.ValueMember = "id";
            this.cmbDetailedAccountsFr.ValueChanged += new System.EventHandler(this.cmbDetailedAccountsFr_ValueChanged);
            this.cmbDetailedAccountsFr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDetailedAccountsFr_KeyDown);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnNew.Location = new System.Drawing.Point(200, 55);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(5);
            this.btnNew.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4);
            this.btnNew.Size = new System.Drawing.Size(76, 33);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.Symbol = "57390";
            this.btnNew.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnNew.SymbolSize = 15F;
            this.btnNew.TabIndex = 202;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "جدید F4";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSave.Location = new System.Drawing.Point(282, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnSave.Size = new System.Drawing.Size(144, 33);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.SymbolSize = 15F;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ذخیره(ثبت نهایی) F5";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAmount1
            // 
            this.txtAmount1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount1.CheackCodeMeli = false;
            this.txtAmount1.Day = 0;
            this.txtAmount1.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAmount1.Location = new System.Drawing.Point(554, 18);
            this.txtAmount1.Miladi = new System.DateTime(((long)(0)));
            this.txtAmount1.Month = 0;
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.NowDateSelected = false;
            this.txtAmount1.Number = null;
            this.txtAmount1.SelectedDate = null;
            this.txtAmount1.Shamsi = null;
            this.txtAmount1.Size = new System.Drawing.Size(165, 32);
            this.txtAmount1.TabIndex = 2;
            this.txtAmount1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtAmount1.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtAmount1.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtAmount1.TextSimple = "";
            this.txtAmount1.TextWatermark = null;
            this.txtAmount1.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtAmount1.Year = 0;
            this.txtAmount1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalAmount_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.ButtonText = "..";
            this.txtDescription.Location = new System.Drawing.Point(430, 57);
            this.txtDescription.MaxLength = 32768;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(49, 28);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            // 
            // lblAccountBalancT
            // 
            this.lblAccountBalancT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountBalancT.BackColor = System.Drawing.Color.LightGray;
            this.lblAccountBalancT.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAccountBalancT.Location = new System.Drawing.Point(799, 59);
            this.lblAccountBalancT.Name = "lblAccountBalancT";
            this.lblAccountBalancT.Size = new System.Drawing.Size(133, 25);
            this.lblAccountBalancT.TabIndex = 198;
            this.lblAccountBalancT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblAccountBalancT, "مــانده حســـاب");
            // 
            // lblAccountBalancF
            // 
            this.lblAccountBalancF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountBalancF.BackColor = System.Drawing.Color.LightGray;
            this.lblAccountBalancF.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAccountBalancF.Location = new System.Drawing.Point(800, 22);
            this.lblAccountBalancF.Name = "lblAccountBalancF";
            this.lblAccountBalancF.Size = new System.Drawing.Size(132, 25);
            this.lblAccountBalancF.TabIndex = 198;
            this.lblAccountBalancF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lblAccountBalancF, "مــانده حســـاب");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1188, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 199;
            this.label1.Text = "به حساب:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.AutoCheckOnClick = true;
            this.buttonX1.AutoExpandOnClick = true;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(932, 57);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Size = new System.Drawing.Size(28, 28);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddNewBanck2,
            this.btnAddNewCofer2});
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 200;
            this.buttonX1.TabStop = false;
            this.buttonX1.Tooltip = "ثبت آیتم جدید";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnAddNewBanck2
            // 
            this.btnAddNewBanck2.GlobalItem = false;
            this.btnAddNewBanck2.Name = "btnAddNewBanck2";
            this.btnAddNewBanck2.Text = "بانک";
            this.btnAddNewBanck2.Click += new System.EventHandler(this.btnAddNewBanck2_Click);
            // 
            // btnAddNewCofer2
            // 
            this.btnAddNewCofer2.GlobalItem = false;
            this.btnAddNewCofer2.Name = "btnAddNewCofer2";
            this.btnAddNewCofer2.Text = "صندوق";
            this.btnAddNewCofer2.Click += new System.EventHandler(this.btnAddNewCofer2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(1188, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 199;
            this.label5.Text = "از حساب:";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCustomer.AutoExpandOnClick = true;
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCustomer.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewCustomer.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(932, 20);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewCustomer.Size = new System.Drawing.Size(28, 28);
            this.btnAddNewCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewCustomer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddNewBanck1,
            this.btnAddNewCofer1});
            this.btnAddNewCustomer.Symbol = "";
            this.btnAddNewCustomer.SymbolSize = 15F;
            this.btnAddNewCustomer.TabIndex = 200;
            this.btnAddNewCustomer.TabStop = false;
            this.btnAddNewCustomer.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnAddNewBanck1
            // 
            this.btnAddNewBanck1.GlobalItem = false;
            this.btnAddNewBanck1.Name = "btnAddNewBanck1";
            this.btnAddNewBanck1.Text = "بانک";
            this.btnAddNewBanck1.Click += new System.EventHandler(this.btnAddNewBanck1_Click);
            // 
            // btnAddNewCofer1
            // 
            this.btnAddNewCofer1.GlobalItem = false;
            this.btnAddNewCofer1.Name = "btnAddNewCofer1";
            this.btnAddNewCofer1.Text = "صندوق";
            this.btnAddNewCofer1.Click += new System.EventHandler(this.btnAddNewCofer1_Click);
            // 
            // txtTransactionCode
            // 
            this.txtTransactionCode.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTransactionCode.Enabled = false;
            this.txtTransactionCode.Location = new System.Drawing.Point(3, 16);
            this.txtTransactionCode.MaxLength = 7;
            this.txtTransactionCode.Name = "txtTransactionCode";
            this.txtTransactionCode.Size = new System.Drawing.Size(124, 28);
            this.txtTransactionCode.TabIndex = 193;
            this.txtTransactionCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label50.Location = new System.Drawing.Point(126, 21);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(62, 18);
            this.label50.TabIndex = 194;
            this.label50.Text = "شماره سند:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(480, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 196;
            this.label2.Text = "شرح سند:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(480, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 196;
            this.label6.Text = "شماره سریال:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(721, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 18);
            this.label14.TabIndex = 196;
            this.label14.Text = "مبلغ جابجایی:";
            // 
            // uiPanelGroup1
            // 
            this.uiPanelGroup1.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles;
            this.uiPanelGroup1.Location = new System.Drawing.Point(3, 129);
            this.uiPanelGroup1.Name = "uiPanelGroup1";
            this.uiPanelGroup1.Size = new System.Drawing.Size(1354, 318);
            this.uiPanelGroup1.TabIndex = 5;
            // 
            // uiPanel1
            // 
            this.uiPanel1.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel1.FloatingLocation = new System.Drawing.Point(330, 432);
            this.uiPanel1.InnerContainer = this.uiPanel1Container;
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1138, 318);
            this.uiPanel1.TabIndex = 4;
            this.uiPanel1.Text = "لیست اسناد";
            this.uiPanel1.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Center;
            // 
            // uiPanel1Container
            // 
            this.uiPanel1Container.Controls.Add(this.dgvList);
            this.uiPanel1Container.Controls.Add(this.pnlViewItemFoter);
            this.uiPanel1Container.Location = new System.Drawing.Point(1, 27);
            this.uiPanel1Container.Name = "uiPanel1Container";
            this.uiPanel1Container.Size = new System.Drawing.Size(1136, 290);
            this.uiPanel1Container.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.FrozenColumns = 6;
            this.dgvList.GroupTotalRowFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.GroupTotalRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvList.GroupTotalRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup;
            this.dgvList.HiddenColumnSortingEnabled = false;
            this.dgvList.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True;
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
            this.dgvList.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.Size = new System.Drawing.Size(1136, 262);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 88;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TabStop = false;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Controls.Add(this.btnExportToExcel);
            this.pnlViewItemFoter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 262);
            this.pnlViewItemFoter.Name = "pnlViewItemFoter";
            this.pnlViewItemFoter.Size = new System.Drawing.Size(1136, 28);
            this.pnlViewItemFoter.TabIndex = 89;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportToExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportToExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportToExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnExportToExcel.Location = new System.Drawing.Point(959, 0);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnExportToExcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9);
            this.btnExportToExcel.Size = new System.Drawing.Size(177, 28);
            this.btnExportToExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportToExcel.Symbol = "";
            this.btnExportToExcel.SymbolColor = System.Drawing.Color.Green;
            this.btnExportToExcel.SymbolSize = 15F;
            this.btnExportToExcel.TabIndex = 3;
            this.btnExportToExcel.Text = "خروجی لیست به اکسل F9";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.uiPanel2.FloatingLocation = new System.Drawing.Point(367, 463);
            this.uiPanel2.InnerContainer = this.uiPanel2Container;
            this.uiPanel2.Location = new System.Drawing.Point(1142, 0);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(212, 318);
            this.uiPanel2.TabIndex = 4;
            this.uiPanel2.Text = "نمایش اسناد";
            this.uiPanel2.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Center;
            // 
            // uiPanel2Container
            // 
            this.uiPanel2Container.Controls.Add(this.txtDateEnd);
            this.uiPanel2Container.Controls.Add(this.btnShowListItems);
            this.uiPanel2Container.Controls.Add(this.txtDateStart);
            this.uiPanel2Container.Controls.Add(this.label48);
            this.uiPanel2Container.Controls.Add(this.label47);
            this.uiPanel2Container.Location = new System.Drawing.Point(1, 27);
            this.uiPanel2Container.Name = "uiPanel2Container";
            this.uiPanel2Container.Size = new System.Drawing.Size(210, 290);
            this.uiPanel2Container.TabIndex = 0;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateEnd.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateEnd.Location = new System.Drawing.Point(37, 88);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateEnd.Size = new System.Drawing.Size(139, 29);
            this.txtDateEnd.TabIndex = 111;
            this.txtDateEnd.UsePersianFormat = true;
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowListItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowListItems.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowListItems.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnShowListItems.Location = new System.Drawing.Point(37, 123);
            this.btnShowListItems.Name = "btnShowListItems";
            this.btnShowListItems.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnShowListItems.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8);
            this.btnShowListItems.Size = new System.Drawing.Size(139, 23);
            this.btnShowListItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowListItems.Symbol = "";
            this.btnShowListItems.SymbolSize = 15F;
            this.btnShowListItems.TabIndex = 113;
            this.btnShowListItems.Text = "نمایش F8";
            this.btnShowListItems.Click += new System.EventHandler(this.btnShowListItems_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateStart.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateStart.Location = new System.Drawing.Point(37, 35);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateStart.Size = new System.Drawing.Size(139, 29);
            this.txtDateStart.TabIndex = 112;
            this.txtDateStart.UsePersianFormat = true;
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label48.Location = new System.Drawing.Point(84, 67);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(42, 18);
            this.label48.TabIndex = 114;
            this.label48.Text = "تا تاریخ";
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label47.Location = new System.Drawing.Point(83, 14);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(43, 18);
            this.label47.TabIndex = 115;
            this.label47.Text = "از تاریخ";
            // 
            // rcmDetails
            // 
            this.rcmDetails.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.dropDownCommand1,
            this.dropDownCommand2,
            this.separatorCommand1,
            this.dropDownCommand3});
            this.rcmDetails.Name = "rcmDetails";
            this.rcmDetails.ShowShortcutInMenus = true;
            this.rcmDetails.ShowShortcutInToolTips = true;
            this.rcmDetails.CommandClick += new Janus.Windows.Ribbon.CommandEventHandler(this.rcmDetails_CommandClick);
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
            // frmTransferBetweenBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 450);
            this.Controls.Add(this.uiPanelGroup1);
            this.Controls.Add(this.uiPanel0);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmTransferBetweenBanks";
            this.Text = "خزانه داری - اعلامی جابجــــایی بین بانکی ها";
            this.Load += new System.EventHandler(this.frmTransferBetweenBanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel0)).EndInit();
            this.uiPanel0.ResumeLayout(false);
            this.uiPanel0Container.ResumeLayout(false);
            this.uiPanel0Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDetailedAccountsTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDetailedAccountsFr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelGroup1)).EndInit();
            this.uiPanelGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlViewItemFoter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanel2)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel2Container.ResumeLayout(false);
            this.uiPanel2Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanelGroup uiPanelGroup1;
        private Janus.Windows.UI.Dock.UIPanel uiPanel0;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel0Container;
        private Janus.Windows.UI.Dock.UIPanel uiPanel1;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel1Container;
        private Janus.Windows.UI.Dock.UIPanel uiPanel2;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer uiPanel2Container;
        public GridExEx.GridExEx dgvList;
        public Atf.UI.DateTimeSelector txtDateEnd;
        public DevComponents.DotNetBar.ButtonX btnShowListItems;
        public Atf.UI.DateTimeSelector txtDateStart;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private Class_General.MyTextBoxJanus txtAmount1;
        private Janus.Windows.GridEX.EditControls.EditBox txtDescription;
        private System.Windows.Forms.Label lblAccountBalancT;
        private System.Windows.Forms.Label lblAccountBalancF;
        private System.Windows.Forms.Label label1;
        public DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label5;
        public DevComponents.DotNetBar.ButtonX btnAddNewCustomer;
        public Atf.UI.DateTimeSelector txtTransactionDate;
        private Janus.Windows.GridEX.EditControls.EditBox txtTransactionCode;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label14;
        public DevComponents.DotNetBar.ButtonX btnNew;
        public DevComponents.DotNetBar.ButtonX btnSave;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbDetailedAccountsTo;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbDetailedAccountsFr;
        private System.Windows.Forms.Label label6;
        private Class_General.MyTextBoxJanus txtSeryalNumber;
        public System.Windows.Forms.Panel pnlViewItemFoter;
        public DevComponents.DotNetBar.ButtonX btnExportToExcel;
        private Class_General.MyTextBoxJanus txtAmount2;
        private System.Windows.Forms.Label label28;
        private DevComponents.DotNetBar.ButtonItem btnAddNewBanck1;
        private DevComponents.DotNetBar.ButtonItem btnAddNewCofer1;
        private DevComponents.DotNetBar.ButtonItem btnAddNewBanck2;
        private DevComponents.DotNetBar.ButtonItem btnAddNewCofer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.Ribbon.RibbonContextMenu rcmDetails;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand2;
        private Janus.Windows.Ribbon.SeparatorCommand separatorCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}