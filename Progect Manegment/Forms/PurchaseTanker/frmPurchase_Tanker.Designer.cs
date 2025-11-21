namespace HM_ERP_System.Forms.PurchaseTanker
{
    partial class frmPurchase_Tanker
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
            Janus.Windows.GridEX.GridEXLayout cmbTypeTrailer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbBuyer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbSeller_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchase_Tanker));
            this.txtAgencyCommission = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtBlockedAmountDocument = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtPurchaseAmount = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtNewPlateNumber = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtPreviousPlateNumber = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtDocumentStatus = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtManufacturer = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtTypeChassisCapsule = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtNumberAxles = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTankerNo = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new Atf.UI.DateTimeSelector();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNewItem = new DevComponents.DotNetBar.ButtonX();
            this.cmbTypeTrailer = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cmbBuyer = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cmbSeller = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvList = new GridExEx.GridExEx();
            this.btnRegDocAccounts = new DevComponents.DotNetBar.ButtonX();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeTrailer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBuyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Location = new System.Drawing.Point(0, 44);
            this.pnlViewItemBody.Size = new System.Drawing.Size(806, 402);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(806, 44);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Controls.Add(this.btnRegDocAccounts);
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 446);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(806, 28);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.buttonX01, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnShowGridExHideColumns, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnExportToExcel, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnRegDocAccounts, 0);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.txtAgencyCommission);
            this.pnlAddItemBodi.Controls.Add(this.txtBlockedAmountDocument);
            this.pnlAddItemBodi.Controls.Add(this.txtPurchaseAmount);
            this.pnlAddItemBodi.Controls.Add(this.txtNewPlateNumber);
            this.pnlAddItemBodi.Controls.Add(this.txtPreviousPlateNumber);
            this.pnlAddItemBodi.Controls.Add(this.txtDocumentStatus);
            this.pnlAddItemBodi.Controls.Add(this.txtManufacturer);
            this.pnlAddItemBodi.Controls.Add(this.txtTypeChassisCapsule);
            this.pnlAddItemBodi.Controls.Add(this.txtNumberAxles);
            this.pnlAddItemBodi.Controls.Add(this.label13);
            this.pnlAddItemBodi.Controls.Add(this.label12);
            this.pnlAddItemBodi.Controls.Add(this.label11);
            this.pnlAddItemBodi.Controls.Add(this.label10);
            this.pnlAddItemBodi.Controls.Add(this.label9);
            this.pnlAddItemBodi.Controls.Add(this.label8);
            this.pnlAddItemBodi.Controls.Add(this.label7);
            this.pnlAddItemBodi.Controls.Add(this.label6);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.txtTankerNo);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.txtDate);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.buttonX1);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewItem);
            this.pnlAddItemBodi.Controls.Add(this.cmbTypeTrailer);
            this.pnlAddItemBodi.Controls.Add(this.cmbBuyer);
            this.pnlAddItemBodi.Controls.Add(this.cmbSeller);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(352, 446);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 446);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(352, 28);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(277, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(572, 6);
            this.txtDateStart.Value = new System.DateTime(2025, 10, 9, 8, 0, 1, 518);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(370, 6);
            this.txtDateEnd.Value = new System.DateTime(2025, 10, 9, 8, 0, 1, 518);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(280, 9);
            this.btnShowListItems.Click += new System.EventHandler(this.btnShowListItems_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(500, 11);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(702, 11);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(808, 502);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(811, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(358, 502);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(703, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(772, 0);
            this.buttonX01.Click += new System.EventHandler(this.buttonX01_Click);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(737, 0);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // txtAgencyCommission
            // 
            this.txtAgencyCommission.CheackCodeMeli = false;
            this.txtAgencyCommission.Day = 0;
            this.txtAgencyCommission.Location = new System.Drawing.Point(77, 445);
            this.txtAgencyCommission.Miladi = new System.DateTime(((long)(0)));
            this.txtAgencyCommission.Month = 0;
            this.txtAgencyCommission.Name = "txtAgencyCommission";
            this.txtAgencyCommission.NowDateSelected = false;
            this.txtAgencyCommission.Number = null;
            this.txtAgencyCommission.SelectedDate = null;
            this.txtAgencyCommission.Shamsi = null;
            this.txtAgencyCommission.Size = new System.Drawing.Size(140, 28);
            this.txtAgencyCommission.TabIndex = 130;
            this.txtAgencyCommission.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtAgencyCommission.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtAgencyCommission.TextSimple = "";
            this.txtAgencyCommission.TextWatermark = null;
            this.txtAgencyCommission.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtAgencyCommission.Year = 0;
            this.txtAgencyCommission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // txtBlockedAmountDocument
            // 
            this.txtBlockedAmountDocument.CheackCodeMeli = false;
            this.txtBlockedAmountDocument.Day = 0;
            this.txtBlockedAmountDocument.Location = new System.Drawing.Point(77, 411);
            this.txtBlockedAmountDocument.Miladi = new System.DateTime(((long)(0)));
            this.txtBlockedAmountDocument.Month = 0;
            this.txtBlockedAmountDocument.Name = "txtBlockedAmountDocument";
            this.txtBlockedAmountDocument.NowDateSelected = false;
            this.txtBlockedAmountDocument.Number = null;
            this.txtBlockedAmountDocument.SelectedDate = null;
            this.txtBlockedAmountDocument.Shamsi = null;
            this.txtBlockedAmountDocument.Size = new System.Drawing.Size(140, 28);
            this.txtBlockedAmountDocument.TabIndex = 129;
            this.txtBlockedAmountDocument.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtBlockedAmountDocument.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtBlockedAmountDocument.TextSimple = "";
            this.txtBlockedAmountDocument.TextWatermark = null;
            this.txtBlockedAmountDocument.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtBlockedAmountDocument.Year = 0;
            this.txtBlockedAmountDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // txtPurchaseAmount
            // 
            this.txtPurchaseAmount.CheackCodeMeli = false;
            this.txtPurchaseAmount.Day = 0;
            this.txtPurchaseAmount.Location = new System.Drawing.Point(77, 377);
            this.txtPurchaseAmount.Miladi = new System.DateTime(((long)(0)));
            this.txtPurchaseAmount.Month = 0;
            this.txtPurchaseAmount.Name = "txtPurchaseAmount";
            this.txtPurchaseAmount.NowDateSelected = false;
            this.txtPurchaseAmount.Number = null;
            this.txtPurchaseAmount.SelectedDate = null;
            this.txtPurchaseAmount.Shamsi = null;
            this.txtPurchaseAmount.Size = new System.Drawing.Size(140, 28);
            this.txtPurchaseAmount.TabIndex = 128;
            this.txtPurchaseAmount.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtPurchaseAmount.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtPurchaseAmount.TextSimple = "";
            this.txtPurchaseAmount.TextWatermark = null;
            this.txtPurchaseAmount.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtPurchaseAmount.Year = 0;
            this.txtPurchaseAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // txtNewPlateNumber
            // 
            this.txtNewPlateNumber.CheackCodeMeli = false;
            this.txtNewPlateNumber.Day = 0;
            this.txtNewPlateNumber.Location = new System.Drawing.Point(122, 343);
            this.txtNewPlateNumber.Miladi = new System.DateTime(((long)(0)));
            this.txtNewPlateNumber.Month = 0;
            this.txtNewPlateNumber.Name = "txtNewPlateNumber";
            this.txtNewPlateNumber.NowDateSelected = false;
            this.txtNewPlateNumber.Number = null;
            this.txtNewPlateNumber.SelectedDate = null;
            this.txtNewPlateNumber.Shamsi = null;
            this.txtNewPlateNumber.Size = new System.Drawing.Size(95, 28);
            this.txtNewPlateNumber.TabIndex = 127;
            this.txtNewPlateNumber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtNewPlateNumber.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtNewPlateNumber.TextDigitGroup = false;
            this.txtNewPlateNumber.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtNewPlateNumber.TextSimple = "";
            this.txtNewPlateNumber.TextWatermark = null;
            this.txtNewPlateNumber.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtNewPlateNumber.Year = 0;
            this.txtNewPlateNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // txtPreviousPlateNumber
            // 
            this.txtPreviousPlateNumber.CheackCodeMeli = false;
            this.txtPreviousPlateNumber.Day = 0;
            this.txtPreviousPlateNumber.Location = new System.Drawing.Point(122, 309);
            this.txtPreviousPlateNumber.Miladi = new System.DateTime(((long)(0)));
            this.txtPreviousPlateNumber.Month = 0;
            this.txtPreviousPlateNumber.Name = "txtPreviousPlateNumber";
            this.txtPreviousPlateNumber.NowDateSelected = false;
            this.txtPreviousPlateNumber.Number = null;
            this.txtPreviousPlateNumber.SelectedDate = null;
            this.txtPreviousPlateNumber.Shamsi = null;
            this.txtPreviousPlateNumber.Size = new System.Drawing.Size(95, 28);
            this.txtPreviousPlateNumber.TabIndex = 126;
            this.txtPreviousPlateNumber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtPreviousPlateNumber.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtPreviousPlateNumber.TextDigitGroup = false;
            this.txtPreviousPlateNumber.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtPreviousPlateNumber.TextSimple = "";
            this.txtPreviousPlateNumber.TextWatermark = null;
            this.txtPreviousPlateNumber.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtPreviousPlateNumber.Year = 0;
            this.txtPreviousPlateNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // txtDocumentStatus
            // 
            this.txtDocumentStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDocumentStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDocumentStatus.CheackCodeMeli = false;
            this.txtDocumentStatus.Day = 0;
            this.txtDocumentStatus.Location = new System.Drawing.Point(34, 275);
            this.txtDocumentStatus.Miladi = new System.DateTime(((long)(0)));
            this.txtDocumentStatus.Month = 0;
            this.txtDocumentStatus.Name = "txtDocumentStatus";
            this.txtDocumentStatus.NowDateSelected = false;
            this.txtDocumentStatus.Number = null;
            this.txtDocumentStatus.SelectedDate = null;
            this.txtDocumentStatus.Shamsi = null;
            this.txtDocumentStatus.Size = new System.Drawing.Size(183, 28);
            this.txtDocumentStatus.TabIndex = 125;
            this.txtDocumentStatus.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtDocumentStatus.TextSimple = "";
            this.txtDocumentStatus.TextWatermark = null;
            this.txtDocumentStatus.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtDocumentStatus.Year = 0;
            this.txtDocumentStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtManufacturer.CheackCodeMeli = false;
            this.txtManufacturer.Day = 0;
            this.txtManufacturer.Location = new System.Drawing.Point(34, 241);
            this.txtManufacturer.Miladi = new System.DateTime(((long)(0)));
            this.txtManufacturer.Month = 0;
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.NowDateSelected = false;
            this.txtManufacturer.Number = null;
            this.txtManufacturer.SelectedDate = null;
            this.txtManufacturer.Shamsi = null;
            this.txtManufacturer.Size = new System.Drawing.Size(183, 28);
            this.txtManufacturer.TabIndex = 124;
            this.txtManufacturer.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtManufacturer.TextSimple = "";
            this.txtManufacturer.TextWatermark = null;
            this.txtManufacturer.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtManufacturer.Year = 0;
            this.txtManufacturer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // txtTypeChassisCapsule
            // 
            this.txtTypeChassisCapsule.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTypeChassisCapsule.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTypeChassisCapsule.CheackCodeMeli = false;
            this.txtTypeChassisCapsule.Day = 0;
            this.txtTypeChassisCapsule.Location = new System.Drawing.Point(34, 209);
            this.txtTypeChassisCapsule.Miladi = new System.DateTime(((long)(0)));
            this.txtTypeChassisCapsule.Month = 0;
            this.txtTypeChassisCapsule.Name = "txtTypeChassisCapsule";
            this.txtTypeChassisCapsule.NowDateSelected = false;
            this.txtTypeChassisCapsule.Number = null;
            this.txtTypeChassisCapsule.SelectedDate = null;
            this.txtTypeChassisCapsule.Shamsi = null;
            this.txtTypeChassisCapsule.Size = new System.Drawing.Size(183, 28);
            this.txtTypeChassisCapsule.TabIndex = 123;
            this.txtTypeChassisCapsule.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtTypeChassisCapsule.TextSimple = "";
            this.txtTypeChassisCapsule.TextWatermark = null;
            this.txtTypeChassisCapsule.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtTypeChassisCapsule.Year = 0;
            this.txtTypeChassisCapsule.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // txtNumberAxles
            // 
            this.txtNumberAxles.CheackCodeMeli = false;
            this.txtNumberAxles.Day = 0;
            this.txtNumberAxles.Location = new System.Drawing.Point(158, 141);
            this.txtNumberAxles.Miladi = new System.DateTime(((long)(0)));
            this.txtNumberAxles.Month = 0;
            this.txtNumberAxles.Name = "txtNumberAxles";
            this.txtNumberAxles.NowDateSelected = false;
            this.txtNumberAxles.Number = null;
            this.txtNumberAxles.SelectedDate = null;
            this.txtNumberAxles.Shamsi = null;
            this.txtNumberAxles.Size = new System.Drawing.Size(59, 28);
            this.txtNumberAxles.TabIndex = 121;
            this.txtNumberAxles.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtNumberAxles.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtNumberAxles.TextDigitGroup = false;
            this.txtNumberAxles.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtNumberAxles.TextSimple = "";
            this.txtNumberAxles.TextWatermark = null;
            this.txtNumberAxles.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtNumberAxles.Year = 0;
            this.txtNumberAxles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(223, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 18);
            this.label13.TabIndex = 144;
            this.label13.Text = " کمیسیون بنگاه :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(223, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 18);
            this.label12.TabIndex = 143;
            this.label12.Text = " مسدودی بابت سند :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(223, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 142;
            this.label11.Text = " مبلغ خرید :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(223, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 141;
            this.label10.Text = "شماره پلاک جدید:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(223, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 140;
            this.label9.Text = "شماره پلاک قبلی:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(223, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 146;
            this.label8.Text = "وضعیت سند:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(223, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 136;
            this.label7.Text = "کارخانه سازنده:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(223, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 145;
            this.label6.Text = "نوع شاسی و کپسول:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(223, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 135;
            this.label1.Text = "نوع یدک:";
            // 
            // txtTankerNo
            // 
            this.txtTankerNo.CheackCodeMeli = false;
            this.txtTankerNo.Day = 0;
            this.txtTankerNo.Location = new System.Drawing.Point(122, 4);
            this.txtTankerNo.Miladi = new System.DateTime(((long)(0)));
            this.txtTankerNo.Month = 0;
            this.txtTankerNo.Name = "txtTankerNo";
            this.txtTankerNo.NowDateSelected = false;
            this.txtTankerNo.Number = null;
            this.txtTankerNo.SelectedDate = null;
            this.txtTankerNo.Shamsi = null;
            this.txtTankerNo.Size = new System.Drawing.Size(95, 28);
            this.txtTankerNo.TabIndex = 117;
            this.txtTankerNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtTankerNo.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtTankerNo.TextDigitGroup = false;
            this.txtTankerNo.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtTankerNo.TextSimple = "";
            this.txtTankerNo.TextWatermark = null;
            this.txtTankerNo.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtTankerNo.Year = 0;
            this.txtTankerNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(223, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 137;
            this.label5.Text = "تعداد محور:";
            // 
            // txtDate
            // 
            this.txtDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate.Location = new System.Drawing.Point(72, 38);
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDate.Size = new System.Drawing.Size(145, 29);
            this.txtDate.TabIndex = 118;
            this.txtDate.UsePersianFormat = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(223, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 138;
            this.label3.Text = "شماره تانکر:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(223, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 139;
            this.label2.Text = "تاریخ خرید:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(11, 107);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Size = new System.Drawing.Size(18, 28);
            this.buttonX1.StopPulseOnMouseOver = false;
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 12F;
            this.buttonX1.TabIndex = 132;
            this.buttonX1.Tooltip = "ثبت آیتم جدید";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewItem.Location = new System.Drawing.Point(11, 73);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewItem.Size = new System.Drawing.Size(18, 28);
            this.btnAddNewItem.StopPulseOnMouseOver = false;
            this.btnAddNewItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewItem.Symbol = "";
            this.btnAddNewItem.SymbolSize = 12F;
            this.btnAddNewItem.TabIndex = 131;
            this.btnAddNewItem.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // cmbTypeTrailer
            // 
            this.cmbTypeTrailer.DataMember = "id";
            cmbTypeTrailer_DesignTimeLayout.LayoutString = resources.GetString("cmbTypeTrailer_DesignTimeLayout.LayoutString");
            this.cmbTypeTrailer.DesignTimeLayout = cmbTypeTrailer_DesignTimeLayout;
            this.cmbTypeTrailer.DisplayMember = "Name";
            this.cmbTypeTrailer.Location = new System.Drawing.Point(34, 175);
            this.cmbTypeTrailer.Name = "cmbTypeTrailer";
            this.cmbTypeTrailer.SelectedIndex = -1;
            this.cmbTypeTrailer.SelectedItem = null;
            this.cmbTypeTrailer.Size = new System.Drawing.Size(183, 28);
            this.cmbTypeTrailer.TabIndex = 122;
            this.cmbTypeTrailer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbTypeTrailer.ValueMember = "id";
            this.cmbTypeTrailer.ValueChanged += new System.EventHandler(this.cmbTypeTrailer_ValueChanged);
            this.cmbTypeTrailer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.DataMember = "id";
            cmbBuyer_DesignTimeLayout.LayoutString = resources.GetString("cmbBuyer_DesignTimeLayout.LayoutString");
            this.cmbBuyer.DesignTimeLayout = cmbBuyer_DesignTimeLayout;
            this.cmbBuyer.DisplayMember = "Name";
            this.cmbBuyer.Location = new System.Drawing.Point(34, 107);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.SelectedIndex = -1;
            this.cmbBuyer.SelectedItem = null;
            this.cmbBuyer.Size = new System.Drawing.Size(183, 28);
            this.cmbBuyer.TabIndex = 120;
            this.cmbBuyer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbBuyer.ValueMember = "id";
            this.cmbBuyer.ValueChanged += new System.EventHandler(this.cmbBuyer_ValueChanged);
            this.cmbBuyer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // cmbSeller
            // 
            this.cmbSeller.DataMember = "id";
            cmbSeller_DesignTimeLayout.LayoutString = resources.GetString("cmbSeller_DesignTimeLayout.LayoutString");
            this.cmbSeller.DesignTimeLayout = cmbSeller_DesignTimeLayout;
            this.cmbSeller.DisplayMember = "Name";
            this.cmbSeller.Location = new System.Drawing.Point(34, 73);
            this.cmbSeller.Name = "cmbSeller";
            this.cmbSeller.SelectedIndex = -1;
            this.cmbSeller.SelectedItem = null;
            this.cmbSeller.Size = new System.Drawing.Size(183, 28);
            this.cmbSeller.TabIndex = 119;
            this.cmbSeller.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbSeller.ValueMember = "id";
            this.cmbSeller.ValueChanged += new System.EventHandler(this.cmbSeller_ValueChanged);
            this.cmbSeller.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTankerNo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(223, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 134;
            this.label4.Text = "خریدار:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(223, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 18);
            this.label14.TabIndex = 133;
            this.label14.Text = "فروشنده:";
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.FrozenColumns = 6;
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
            this.dgvList.SettingsKey = "frmPurchase_Tanker";
            this.dgvList.Size = new System.Drawing.Size(806, 402);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 85;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // btnRegDocAccounts
            // 
            this.btnRegDocAccounts.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegDocAccounts.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegDocAccounts.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegDocAccounts.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnRegDocAccounts.Location = new System.Drawing.Point(0, 0);
            this.btnRegDocAccounts.Name = "btnRegDocAccounts";
            this.btnRegDocAccounts.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnRegDocAccounts.Size = new System.Drawing.Size(138, 28);
            this.btnRegDocAccounts.StopPulseOnMouseOver = false;
            this.btnRegDocAccounts.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegDocAccounts.Symbol = "";
            this.btnRegDocAccounts.SymbolSize = 17F;
            this.btnRegDocAccounts.TabIndex = 133;
            this.btnRegDocAccounts.Text = "ثبت اسناد حسابداری";
            this.btnRegDocAccounts.Click += new System.EventHandler(this.btnRegDocAccounts_Click);
            // 
            // frmPurchase_Tanker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 508);
            this.KeyPreview = true;
            this.Name = "frmPurchase_Tanker";
            this.Text = "خـــرید تانکــرها";
            this.Load += new System.EventHandler(this.frmPurchase_Tanker_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPurchase_Tanker_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbTypeTrailer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBuyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSeller)).EndInit();
            ((System.Configuration.IPersistComponentSettings)(this.dgvList)).LoadComponentSettings();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Class_General.MyTextBoxJanus txtAgencyCommission;
        private Class_General.MyTextBoxJanus txtBlockedAmountDocument;
        private Class_General.MyTextBoxJanus txtPurchaseAmount;
        private Class_General.MyTextBoxJanus txtNewPlateNumber;
        private Class_General.MyTextBoxJanus txtPreviousPlateNumber;
        private Class_General.MyTextBoxJanus txtDocumentStatus;
        private Class_General.MyTextBoxJanus txtManufacturer;
        private Class_General.MyTextBoxJanus txtTypeChassisCapsule;
        private Class_General.MyTextBoxJanus txtNumberAxles;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Class_General.MyTextBoxJanus txtTankerNo;
        private System.Windows.Forms.Label label5;
        public Atf.UI.DateTimeSelector txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public DevComponents.DotNetBar.ButtonX buttonX1;
        public DevComponents.DotNetBar.ButtonX btnAddNewItem;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbTypeTrailer;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbBuyer;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbSeller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        public GridExEx.GridExEx dgvList;
        public DevComponents.DotNetBar.ButtonX btnRegDocAccounts;
    }
}