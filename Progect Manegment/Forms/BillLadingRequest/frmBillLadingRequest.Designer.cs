namespace HM_ERP_System.Forms.BillLadingRequest
{
    partial class frmBillLadingRequest
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
            Janus.Windows.GridEX.GridEXLayout dgvListH_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListH_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillLadingRequest));
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListH_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column3.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListH_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column29.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListH_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column30.ButtonImage");
            Janus.Windows.GridEX.GridEXLayout cmbShiper_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvListH = new GridExEx.GridExEx();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDH_PriceGoods = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtDH_FreightCharge = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtDH_SealNumber = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtDH_LoadWeight = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.cmbShiper = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.lblTelDraver1 = new System.Windows.Forms.Label();
            this.PanelH = new Janus.Windows.EditControls.UIGroupBox();
            this.btnAddPerson5 = new DevComponents.DotNetBar.ButtonX();
            this.btnCratMessage = new DevComponents.DotNetBar.ButtonX();
            this.chkDH_StatusRejistered = new System.Windows.Forms.CheckBox();
            this.PanelM = new Janus.Windows.EditControls.UIGroupBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSendMessage = new DevComponents.DotNetBar.ButtonX();
            this.chkSended = new System.Windows.Forms.CheckBox();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShiper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelH)).BeginInit();
            this.PanelH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelM)).BeginInit();
            this.PanelM.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvListH);
            this.pnlViewItemBody.Location = new System.Drawing.Point(0, 53);
            this.pnlViewItemBody.Size = new System.Drawing.Size(642, 426);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Controls.Add(this.chkSended);
            this.pnlViewItemHeder.Size = new System.Drawing.Size(642, 53);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.chkSended, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.labelX1, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.txtDateStart, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.labelX2, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.txtDateEnd, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.btnShowListItems, 0);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 479);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(642, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.PanelM);
            this.pnlAddItemBodi.Controls.Add(this.PanelH);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(446, 479);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 479);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(446, 28);
            this.pnlAddItemFoter.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(371, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDateStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDateStart.Location = new System.Drawing.Point(673, 0);
            this.txtDateStart.Value = new System.DateTime(2025, 7, 28, 11, 10, 40, 823);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDateEnd.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDateEnd.Location = new System.Drawing.Point(484, 0);
            this.txtDateEnd.Value = new System.DateTime(2025, 7, 28, 11, 10, 40, 825);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowListItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowListItems.Location = new System.Drawing.Point(400, 0);
            this.btnShowListItems.Size = new System.Drawing.Size(84, 36);
            this.btnShowListItems.Click += new System.EventHandler(this.btnShowListItems_Click);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelX2.Location = new System.Drawing.Point(608, 0);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelX1.Location = new System.Drawing.Point(797, 0);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(644, 535);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(647, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(452, 535);
            this.pnlAddItems.Visible = false;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(608, 0);
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(574, 0);
            // 
            // dgvListH
            // 
            this.dgvListH.DefaultComment = null;
            this.dgvListH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListH.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvListH.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvListH.FindCondition = null;
            this.dgvListH.FrozenColumns = 4;
            this.dgvListH.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.dgvListH.HiddenColumnSortingEnabled = false;
            this.dgvListH.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvListH_Layout_0.IsCurrentLayout = true;
            dgvListH_Layout_0.Key = "MyGrig";
            dgvListH_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("dgvListH_Layout_0_Reference_0.Instance")));
            dgvListH_Layout_0_Reference_1.Instance = ((object)(resources.GetObject("dgvListH_Layout_0_Reference_1.Instance")));
            dgvListH_Layout_0_Reference_2.Instance = ((object)(resources.GetObject("dgvListH_Layout_0_Reference_2.Instance")));
            dgvListH_Layout_0_Reference_3.Instance = ((object)(resources.GetObject("dgvListH_Layout_0_Reference_3.Instance")));
            dgvListH_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            dgvListH_Layout_0_Reference_0,
            dgvListH_Layout_0_Reference_1,
            dgvListH_Layout_0_Reference_2,
            dgvListH_Layout_0_Reference_3});
            dgvListH_Layout_0.LayoutString = resources.GetString("dgvListH_Layout_0.LayoutString");
            this.dgvListH.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvListH_Layout_0});
            this.dgvListH.Location = new System.Drawing.Point(0, 0);
            this.dgvListH.Name = "dgvListH";
            this.dgvListH.RecordNavigator = true;
            this.dgvListH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListH.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvListH.SettingsKey = "frmComersH";
            this.dgvListH.Size = new System.Drawing.Size(642, 426);
            this.dgvListH.Sortable = true;
            this.dgvListH.TabIndex = 86;
            this.dgvListH.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListH.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListH.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvListH.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListH.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvListH.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvListH_ColumnButtonClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(312, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 100;
            this.label12.Text = "مقدار(وزن) بار:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(312, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 100;
            this.label2.Text = "شماره پلمپ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(312, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 100;
            this.label4.Text = "کرایه حمل:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(312, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 100;
            this.label5.Text = "ارزش(بهاء) کالا:";
            // 
            // txtDH_PriceGoods
            // 
            this.txtDH_PriceGoods.CheackCodeMeli = false;
            this.txtDH_PriceGoods.Day = 0;
            this.txtDH_PriceGoods.Location = new System.Drawing.Point(160, 152);
            this.txtDH_PriceGoods.Miladi = new System.DateTime(((long)(0)));
            this.txtDH_PriceGoods.Month = 0;
            this.txtDH_PriceGoods.Name = "txtDH_PriceGoods";
            this.txtDH_PriceGoods.NowDateSelected = false;
            this.txtDH_PriceGoods.Number = null;
            this.txtDH_PriceGoods.SelectedDate = null;
            this.txtDH_PriceGoods.Shamsi = null;
            this.txtDH_PriceGoods.Size = new System.Drawing.Size(145, 28);
            this.txtDH_PriceGoods.TabIndex = 3;
            this.txtDH_PriceGoods.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtDH_PriceGoods.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtDH_PriceGoods.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtDH_PriceGoods.TextSimple = "";
            this.txtDH_PriceGoods.TextWatermark = null;
            this.txtDH_PriceGoods.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtDH_PriceGoods.Year = 0;
            this.txtDH_PriceGoods.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDH_LoadWeight_KeyDown);
            // 
            // txtDH_FreightCharge
            // 
            this.txtDH_FreightCharge.CheackCodeMeli = false;
            this.txtDH_FreightCharge.Day = 0;
            this.txtDH_FreightCharge.Location = new System.Drawing.Point(160, 118);
            this.txtDH_FreightCharge.Miladi = new System.DateTime(((long)(0)));
            this.txtDH_FreightCharge.Month = 0;
            this.txtDH_FreightCharge.Name = "txtDH_FreightCharge";
            this.txtDH_FreightCharge.NowDateSelected = false;
            this.txtDH_FreightCharge.Number = null;
            this.txtDH_FreightCharge.SelectedDate = null;
            this.txtDH_FreightCharge.Shamsi = null;
            this.txtDH_FreightCharge.Size = new System.Drawing.Size(145, 28);
            this.txtDH_FreightCharge.TabIndex = 2;
            this.txtDH_FreightCharge.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtDH_FreightCharge.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtDH_FreightCharge.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtDH_FreightCharge.TextSimple = "";
            this.txtDH_FreightCharge.TextWatermark = null;
            this.txtDH_FreightCharge.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtDH_FreightCharge.Year = 0;
            this.txtDH_FreightCharge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDH_LoadWeight_KeyDown);
            // 
            // txtDH_SealNumber
            // 
            this.txtDH_SealNumber.CheackCodeMeli = false;
            this.txtDH_SealNumber.Day = 0;
            this.txtDH_SealNumber.Location = new System.Drawing.Point(11, 84);
            this.txtDH_SealNumber.Miladi = new System.DateTime(((long)(0)));
            this.txtDH_SealNumber.Month = 0;
            this.txtDH_SealNumber.Name = "txtDH_SealNumber";
            this.txtDH_SealNumber.NowDateSelected = false;
            this.txtDH_SealNumber.Number = null;
            this.txtDH_SealNumber.SelectedDate = null;
            this.txtDH_SealNumber.Shamsi = null;
            this.txtDH_SealNumber.Size = new System.Drawing.Size(294, 28);
            this.txtDH_SealNumber.TabIndex = 1;
            this.txtDH_SealNumber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtDH_SealNumber.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtDH_SealNumber.TextDigitGroup = false;
            this.txtDH_SealNumber.TextSimple = "";
            this.txtDH_SealNumber.TextWatermark = null;
            this.txtDH_SealNumber.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtDH_SealNumber.Year = 0;
            this.txtDH_SealNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDH_LoadWeight_KeyDown);
            // 
            // txtDH_LoadWeight
            // 
            this.txtDH_LoadWeight.CheackCodeMeli = true;
            this.txtDH_LoadWeight.Day = 0;
            this.txtDH_LoadWeight.Location = new System.Drawing.Point(160, 50);
            this.txtDH_LoadWeight.Miladi = new System.DateTime(((long)(0)));
            this.txtDH_LoadWeight.Month = 0;
            this.txtDH_LoadWeight.Name = "txtDH_LoadWeight";
            this.txtDH_LoadWeight.NowDateSelected = false;
            this.txtDH_LoadWeight.Number = null;
            this.txtDH_LoadWeight.SelectedDate = null;
            this.txtDH_LoadWeight.Shamsi = null;
            this.txtDH_LoadWeight.Size = new System.Drawing.Size(145, 28);
            this.txtDH_LoadWeight.TabIndex = 0;
            this.txtDH_LoadWeight.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtDH_LoadWeight.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtDH_LoadWeight.TextDigitGroup = false;
            this.txtDH_LoadWeight.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtDH_LoadWeight.TextSimple = "";
            this.txtDH_LoadWeight.TextWatermark = "";
            this.txtDH_LoadWeight.TextWatermarkForeColor = System.Drawing.Color.Black;
            this.txtDH_LoadWeight.TextWMModeAlign = HM_ERP_System.Class_General.MyTextBoxJanus.TextWatermarkAlign.Center;
            this.txtDH_LoadWeight.Year = 0;
            this.txtDH_LoadWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDH_LoadWeight_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(312, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 18);
            this.label13.TabIndex = 101;
            this.label13.Text = "بارنامه نویس:";
            // 
            // cmbShiper
            // 
            this.cmbShiper.DataMember = "id";
            cmbShiper_DesignTimeLayout.LayoutString = resources.GetString("cmbShiper_DesignTimeLayout.LayoutString");
            this.cmbShiper.DesignTimeLayout = cmbShiper_DesignTimeLayout;
            this.cmbShiper.DisplayMember = "Name";
            this.cmbShiper.Location = new System.Drawing.Point(30, 186);
            this.cmbShiper.Name = "cmbShiper";
            this.cmbShiper.SelectedIndex = -1;
            this.cmbShiper.SelectedItem = null;
            this.cmbShiper.Size = new System.Drawing.Size(275, 28);
            this.cmbShiper.TabIndex = 4;
            this.cmbShiper.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbShiper.ValueMember = "id";
            this.cmbShiper.ValueChanged += new System.EventHandler(this.cmbShiper_ValueChanged);
            this.cmbShiper.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDH_LoadWeight_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(312, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 18);
            this.label15.TabIndex = 101;
            this.label15.Text = "شماره حواله:";
            // 
            // lblTelDraver1
            // 
            this.lblTelDraver1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTelDraver1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTelDraver1.ForeColor = System.Drawing.Color.Maroon;
            this.lblTelDraver1.Location = new System.Drawing.Point(160, 26);
            this.lblTelDraver1.Name = "lblTelDraver1";
            this.lblTelDraver1.Size = new System.Drawing.Size(145, 18);
            this.lblTelDraver1.TabIndex = 133;
            this.lblTelDraver1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTelDraver1.Click += new System.EventHandler(this.lblTelDraver1_Click);
            // 
            // PanelH
            // 
            this.PanelH.AutoScroll = true;
            this.PanelH.AutoScrollMinSize = new System.Drawing.Size(200, 0);
            this.PanelH.Controls.Add(this.btnAddPerson5);
            this.PanelH.Controls.Add(this.btnCratMessage);
            this.PanelH.Controls.Add(this.chkDH_StatusRejistered);
            this.PanelH.Controls.Add(this.lblTelDraver1);
            this.PanelH.Controls.Add(this.label15);
            this.PanelH.Controls.Add(this.cmbShiper);
            this.PanelH.Controls.Add(this.label12);
            this.PanelH.Controls.Add(this.txtDH_PriceGoods);
            this.PanelH.Controls.Add(this.label13);
            this.PanelH.Controls.Add(this.txtDH_FreightCharge);
            this.PanelH.Controls.Add(this.label2);
            this.PanelH.Controls.Add(this.txtDH_SealNumber);
            this.PanelH.Controls.Add(this.label4);
            this.PanelH.Controls.Add(this.txtDH_LoadWeight);
            this.PanelH.Controls.Add(this.label5);
            this.PanelH.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelH.Location = new System.Drawing.Point(0, 0);
            this.PanelH.Name = "PanelH";
            this.PanelH.Size = new System.Drawing.Size(429, 252);
            this.PanelH.TabIndex = 0;
            this.PanelH.Text = "اطلاعات تکمیلی حواله";
            this.PanelH.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            // 
            // btnAddPerson5
            // 
            this.btnAddPerson5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddPerson5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPerson5.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddPerson5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddPerson5.Location = new System.Drawing.Point(11, 186);
            this.btnAddPerson5.Name = "btnAddPerson5";
            this.btnAddPerson5.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddPerson5.Size = new System.Drawing.Size(18, 28);
            this.btnAddPerson5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddPerson5.Symbol = "";
            this.btnAddPerson5.SymbolSize = 12F;
            this.btnAddPerson5.TabIndex = 135;
            this.btnAddPerson5.TabStop = false;
            this.btnAddPerson5.Tooltip = "ثبت آیتم جدید";
            this.btnAddPerson5.Click += new System.EventHandler(this.btnAddPerson5_Click);
            // 
            // btnCratMessage
            // 
            this.btnCratMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCratMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCratMessage.BackColor = System.Drawing.Color.Transparent;
            this.btnCratMessage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCratMessage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnCratMessage.Location = new System.Drawing.Point(83, 218);
            this.btnCratMessage.Name = "btnCratMessage";
            this.btnCratMessage.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnCratMessage.Size = new System.Drawing.Size(198, 28);
            this.btnCratMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCratMessage.Symbol = "";
            this.btnCratMessage.SymbolSize = 15F;
            this.btnCratMessage.TabIndex = 5;
            this.btnCratMessage.Text = "ثبت و ایجاد پیام";
            this.btnCratMessage.Tooltip = "ثبت خودرو";
            this.btnCratMessage.Click += new System.EventHandler(this.btnCratMessage_Click);
            this.btnCratMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDH_LoadWeight_KeyDown);
            // 
            // chkDH_StatusRejistered
            // 
            this.chkDH_StatusRejistered.AutoSize = true;
            this.chkDH_StatusRejistered.Location = new System.Drawing.Point(287, 220);
            this.chkDH_StatusRejistered.Name = "chkDH_StatusRejistered";
            this.chkDH_StatusRejistered.Size = new System.Drawing.Size(134, 26);
            this.chkDH_StatusRejistered.TabIndex = 134;
            this.chkDH_StatusRejistered.Text = "وضعیت ارسال پیام";
            this.chkDH_StatusRejistered.UseVisualStyleBackColor = true;
            this.chkDH_StatusRejistered.Visible = false;
            // 
            // PanelM
            // 
            this.PanelM.Controls.Add(this.lblCaption);
            this.PanelM.Controls.Add(this.txtMessage);
            this.PanelM.Controls.Add(this.btnSendMessage);
            this.PanelM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelM.Location = new System.Drawing.Point(0, 252);
            this.PanelM.Name = "PanelM";
            this.PanelM.Size = new System.Drawing.Size(429, 248);
            this.PanelM.TabIndex = 135;
            this.PanelM.Text = "اطلاعات پیام";
            this.PanelM.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            // 
            // lblCaption
            // 
            this.lblCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaption.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCaption.Location = new System.Drawing.Point(6, 24);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(415, 22);
            this.lblCaption.TabIndex = 73;
            this.lblCaption.Text = "اطلاعات حواله";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.txtMessage.Location = new System.Drawing.Point(6, 52);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(415, 135);
            this.txtMessage.TabIndex = 72;
            this.txtMessage.TabStop = false;
            this.txtMessage.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopy,
            this.btnPaste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 48);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(105, 22);
            this.btnCopy.Text = "کپی";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(105, 22);
            this.btnPaste.Text = "الصاق";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendMessage.BackColor = System.Drawing.Color.Transparent;
            this.btnSendMessage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSendMessage.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSendMessage.Location = new System.Drawing.Point(160, 193);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnSendMessage.Size = new System.Drawing.Size(72, 28);
            this.btnSendMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSendMessage.Symbol = "";
            this.btnSendMessage.SymbolSize = 15F;
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "ارسال";
            this.btnSendMessage.Tooltip = "ثبت خودرو";
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // chkSended
            // 
            this.chkSended.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkSended.Location = new System.Drawing.Point(902, 0);
            this.chkSended.Name = "chkSended";
            this.chkSended.Size = new System.Drawing.Size(181, 36);
            this.chkSended.TabIndex = 3;
            this.chkSended.Text = "نمایش ارسال شده ها";
            this.chkSended.UseVisualStyleBackColor = true;
            this.chkSended.CheckedChanged += new System.EventHandler(this.chkSended_CheckedChanged);
            // 
            // frmBillLadingRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 541);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmBillLadingRequest";
            this.Text = "فرم درخواست بارنامه";
            this.Load += new System.EventHandler(this.frmBillLadingRequest_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBillLadingRequest_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbShiper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelH)).EndInit();
            this.PanelH.ResumeLayout(false);
            this.PanelH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelM)).EndInit();
            this.PanelM.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvListH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Class_General.MyTextBoxJanus txtDH_PriceGoods;
        private Class_General.MyTextBoxJanus txtDH_FreightCharge;
        private Class_General.MyTextBoxJanus txtDH_SealNumber;
        private Class_General.MyTextBoxJanus txtDH_LoadWeight;
        private System.Windows.Forms.Label label13;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbShiper;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTelDraver1;
        private Janus.Windows.EditControls.UIGroupBox PanelM;
        private Janus.Windows.EditControls.UIGroupBox PanelH;
        public DevComponents.DotNetBar.ButtonX btnSendMessage;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCopy;
        private System.Windows.Forms.ToolStripMenuItem btnPaste;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.CheckBox chkSended;
        private System.Windows.Forms.CheckBox chkDH_StatusRejistered;
        public DevComponents.DotNetBar.ButtonX btnCratMessage;
        public DevComponents.DotNetBar.ButtonX btnAddPerson5;
    }
}