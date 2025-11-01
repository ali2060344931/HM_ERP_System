namespace HM_ERP_System.Forms.Accounts.Cheque
{
    partial class frmCheque
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
            Janus.Windows.GridEX.GridEXLayout cmbChequeType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheque));
            Janus.Windows.GridEX.GridEXLayout cmbPayer_Payee_Acc_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvListChequeStatus_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbBanck_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.cmbChequeType = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtDueDate = new Atf.UI.DateTimeSelector();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIssueDate = new Atf.UI.DateTimeSelector();
            this.dgvList = new GridExEx.GridExEx();
            this.cmbPayer_Payee_Acc = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtDescription = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtChequeOwner = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtChequeNumber = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtAmount = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.cmsdgv = new Janus.Windows.Ribbon.RibbonContextMenu(this.components);
            this.dropDownCommand1 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand2 = new Janus.Windows.Ribbon.DropDownCommand();
            this.separatorCommand1 = new Janus.Windows.Ribbon.SeparatorCommand();
            this.btnListChequeStatus = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand3 = new Janus.Windows.Ribbon.DropDownCommand();
            this.pnlListChequeStatus = new Janus.Windows.EditControls.UIGroupBox();
            this.btnClosePael = new DevComponents.DotNetBar.ButtonX();
            this.dgvListChequeStatus = new GridExEx.GridExEx();
            this.btnSelectCheque = new DevComponents.DotNetBar.ButtonX();
            this.btnAddBanck = new DevComponents.DotNetBar.ButtonX();
            this.cmbBanck = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChequeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPayer_Payee_Acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlListChequeStatus)).BeginInit();
            this.pnlListChequeStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListChequeStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanck)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Controls.Add(this.pnlListChequeStatus);
            this.pnlViewItemBody.Size = new System.Drawing.Size(606, 440);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(606, 50);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Controls.Add(this.btnSelectCheque);
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 490);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(606, 28);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.buttonX1, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnExportToExcel, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnSelectCheque, 0);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.btnAddBanck);
            this.pnlAddItemBodi.Controls.Add(this.cmbBanck);
            this.pnlAddItemBodi.Controls.Add(this.txtDescription);
            this.pnlAddItemBodi.Controls.Add(this.txtChequeOwner);
            this.pnlAddItemBodi.Controls.Add(this.txtChequeNumber);
            this.pnlAddItemBodi.Controls.Add(this.txtAmount);
            this.pnlAddItemBodi.Controls.Add(this.txtIssueDate);
            this.pnlAddItemBodi.Controls.Add(this.txtDueDate);
            this.pnlAddItemBodi.Controls.Add(this.cmbPayer_Payee_Acc);
            this.pnlAddItemBodi.Controls.Add(this.cmbChequeType);
            this.pnlAddItemBodi.Controls.Add(this.label10);
            this.pnlAddItemBodi.Controls.Add(this.label9);
            this.pnlAddItemBodi.Controls.Add(this.label8);
            this.pnlAddItemBodi.Controls.Add(this.label7);
            this.pnlAddItemBodi.Controls.Add(this.label6);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(435, 490);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 490);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(435, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(360, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(349, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 10, 3, 15, 30, 8, 995);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(147, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 10, 3, 15, 30, 8, 996);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(57, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(277, 16);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(480, 16);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(608, 546);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(611, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(441, 546);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(538, 0);
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(572, 0);
            // 
            // cmbChequeType
            // 
            this.cmbChequeType.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbChequeType.DataMember = "id";
            cmbChequeType_DesignTimeLayout.LayoutString = resources.GetString("cmbChequeType_DesignTimeLayout.LayoutString");
            this.cmbChequeType.DesignTimeLayout = cmbChequeType_DesignTimeLayout;
            this.cmbChequeType.DisplayMember = "Name";
            this.cmbChequeType.Location = new System.Drawing.Point(164, 15);
            this.cmbChequeType.Name = "cmbChequeType";
            this.cmbChequeType.SelectedIndex = -1;
            this.cmbChequeType.SelectedItem = null;
            this.cmbChequeType.Size = new System.Drawing.Size(130, 28);
            this.cmbChequeType.TabIndex = 0;
            this.cmbChequeType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbChequeType.ValueMember = "id";
            this.cmbChequeType.ValueChanged += new System.EventHandler(this.cmbChequeType_ValueChanged);
            // 
            // txtDueDate
            // 
            this.txtDueDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDueDate.Location = new System.Drawing.Point(164, 117);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDueDate.Size = new System.Drawing.Size(130, 29);
            this.txtDueDate.TabIndex = 3;
            this.txtDueDate.UsePersianFormat = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(295, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "نوع چک:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(295, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 114;
            this.label3.Text = "شماره سریال:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(295, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 114;
            this.label4.Text = "مبلغ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(295, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 114;
            this.label5.Text = "تاریخ سررسید:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(295, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 114;
            this.label6.Text = "تاریخ صدور/ثبت:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(295, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 114;
            this.label7.Text = "نام بانک:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(295, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 114;
            this.label8.Text = "طرف حساب مشتری:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(295, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 114;
            this.label9.Text = "نام صاحب چک:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(295, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 114;
            this.label10.Text = "توضیحات:";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIssueDate.Location = new System.Drawing.Point(164, 152);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIssueDate.Size = new System.Drawing.Size(130, 29);
            this.txtIssueDate.TabIndex = 4;
            this.txtIssueDate.UsePersianFormat = true;
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
            this.dgvList.SettingsKey = "GridExEx";
            this.dgvList.Size = new System.Drawing.Size(606, 288);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 84;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgvList_FormattingRow);
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // cmbPayer_Payee_Acc
            // 
            this.cmbPayer_Payee_Acc.DataMember = "id";
            cmbPayer_Payee_Acc_DesignTimeLayout.LayoutString = resources.GetString("cmbPayer_Payee_Acc_DesignTimeLayout.LayoutString");
            this.cmbPayer_Payee_Acc.DesignTimeLayout = cmbPayer_Payee_Acc_DesignTimeLayout;
            this.cmbPayer_Payee_Acc.DisplayMember = "Name";
            this.cmbPayer_Payee_Acc.Image = ((System.Drawing.Image)(resources.GetObject("cmbPayer_Payee_Acc.Image")));
            this.cmbPayer_Payee_Acc.Location = new System.Drawing.Point(95, 221);
            this.cmbPayer_Payee_Acc.Name = "cmbPayer_Payee_Acc";
            this.cmbPayer_Payee_Acc.SelectedIndex = -1;
            this.cmbPayer_Payee_Acc.SelectedItem = null;
            this.cmbPayer_Payee_Acc.Size = new System.Drawing.Size(199, 30);
            this.cmbPayer_Payee_Acc.TabIndex = 5;
            this.cmbPayer_Payee_Acc.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbPayer_Payee_Acc.ValueMember = "id";
            this.cmbPayer_Payee_Acc.ValueChanged += new System.EventHandler(this.cmbPayer_Payee_Acc_ValueChanged);
            this.cmbPayer_Payee_Acc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPayer_Payee_Acc_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.CheackCodeMeli = false;
            this.txtDescription.Day = 0;
            this.txtDescription.Location = new System.Drawing.Point(12, 289);
            this.txtDescription.Miladi = new System.DateTime(((long)(0)));
            this.txtDescription.Month = 0;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.NowDateSelected = false;
            this.txtDescription.Number = null;
            this.txtDescription.SelectedDate = null;
            this.txtDescription.Shamsi = null;
            this.txtDescription.Size = new System.Drawing.Size(282, 28);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtDescription.TextSimple = "";
            this.txtDescription.TextWatermark = null;
            this.txtDescription.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtDescription.Year = 0;
            // 
            // txtChequeOwner
            // 
            this.txtChequeOwner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtChequeOwner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtChequeOwner.CheackCodeMeli = false;
            this.txtChequeOwner.Day = 0;
            this.txtChequeOwner.Location = new System.Drawing.Point(95, 255);
            this.txtChequeOwner.Miladi = new System.DateTime(((long)(0)));
            this.txtChequeOwner.Month = 0;
            this.txtChequeOwner.Name = "txtChequeOwner";
            this.txtChequeOwner.NowDateSelected = false;
            this.txtChequeOwner.Number = null;
            this.txtChequeOwner.SelectedDate = null;
            this.txtChequeOwner.Shamsi = null;
            this.txtChequeOwner.Size = new System.Drawing.Size(199, 28);
            this.txtChequeOwner.TabIndex = 7;
            this.txtChequeOwner.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtChequeOwner.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtChequeOwner.TextSimple = "";
            this.txtChequeOwner.TextWatermark = null;
            this.txtChequeOwner.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtChequeOwner.Year = 0;
            // 
            // txtChequeNumber
            // 
            this.txtChequeNumber.CheackCodeMeli = false;
            this.txtChequeNumber.Day = 0;
            this.txtChequeNumber.Location = new System.Drawing.Point(164, 50);
            this.txtChequeNumber.Miladi = new System.DateTime(((long)(0)));
            this.txtChequeNumber.Month = 0;
            this.txtChequeNumber.Name = "txtChequeNumber";
            this.txtChequeNumber.NowDateSelected = false;
            this.txtChequeNumber.Number = null;
            this.txtChequeNumber.SelectedDate = null;
            this.txtChequeNumber.Shamsi = null;
            this.txtChequeNumber.Size = new System.Drawing.Size(130, 28);
            this.txtChequeNumber.TabIndex = 2;
            this.txtChequeNumber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtChequeNumber.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtChequeNumber.TextDigitGroup = false;
            this.txtChequeNumber.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtChequeNumber.TextSimple = "";
            this.txtChequeNumber.TextWatermark = null;
            this.txtChequeNumber.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtChequeNumber.Year = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.CheackCodeMeli = false;
            this.txtAmount.Day = 0;
            this.txtAmount.Location = new System.Drawing.Point(164, 83);
            this.txtAmount.Miladi = new System.DateTime(((long)(0)));
            this.txtAmount.Month = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.NowDateSelected = false;
            this.txtAmount.Number = null;
            this.txtAmount.SelectedDate = null;
            this.txtAmount.Shamsi = null;
            this.txtAmount.Size = new System.Drawing.Size(130, 28);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtAmount.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtAmount.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtAmount.TextSimple = "";
            this.txtAmount.TextWatermark = null;
            this.txtAmount.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtAmount.Year = 0;
            // 
            // cmsdgv
            // 
            this.cmsdgv.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.dropDownCommand1,
            this.dropDownCommand2,
            this.separatorCommand1,
            this.btnListChequeStatus,
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
            // btnListChequeStatus
            // 
            this.btnListChequeStatus.Key = "ListChequeStatus";
            this.btnListChequeStatus.Name = "btnListChequeStatus";
            this.btnListChequeStatus.Text = "لسیت جزئیات چک";
            // 
            // dropDownCommand3
            // 
            this.dropDownCommand3.Key = "AddDocumentToBanck";
            this.dropDownCommand3.Name = "dropDownCommand3";
            this.dropDownCommand3.Text = "ثبت مدارک";
            // 
            // pnlListChequeStatus
            // 
            this.pnlListChequeStatus.Controls.Add(this.btnClosePael);
            this.pnlListChequeStatus.Controls.Add(this.dgvListChequeStatus);
            this.pnlListChequeStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlListChequeStatus.Location = new System.Drawing.Point(0, 288);
            this.pnlListChequeStatus.Name = "pnlListChequeStatus";
            this.pnlListChequeStatus.Size = new System.Drawing.Size(606, 152);
            this.pnlListChequeStatus.TabIndex = 85;
            this.pnlListChequeStatus.Text = "لیست وضعیت های چک ";
            this.pnlListChequeStatus.Visible = false;
            // 
            // btnClosePael
            // 
            this.btnClosePael.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClosePael.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClosePael.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnClosePael.Location = new System.Drawing.Point(6, 6);
            this.btnClosePael.Name = "btnClosePael";
            this.btnClosePael.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnClosePael.Size = new System.Drawing.Size(26, 18);
            this.btnClosePael.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClosePael.Symbol = "";
            this.btnClosePael.SymbolSize = 12F;
            this.btnClosePael.TabIndex = 115;
            this.btnClosePael.Tooltip = "ثبت آیتم جدید";
            this.btnClosePael.Click += new System.EventHandler(this.btnClosePael_Click);
            // 
            // dgvListChequeStatus
            // 
            this.dgvListChequeStatus.DefaultComment = null;
            this.dgvListChequeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListChequeStatus.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvListChequeStatus.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvListChequeStatus.FindCondition = null;
            this.dgvListChequeStatus.GroupByBoxVisible = false;
            this.dgvListChequeStatus.HiddenColumnSortingEnabled = false;
            this.dgvListChequeStatus.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvListChequeStatus_Layout_0.IsCurrentLayout = true;
            dgvListChequeStatus_Layout_0.Key = "MyGrig";
            dgvListChequeStatus_Layout_0.LayoutString = resources.GetString("dgvListChequeStatus_Layout_0.LayoutString");
            this.dgvListChequeStatus.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvListChequeStatus_Layout_0});
            this.dgvListChequeStatus.Location = new System.Drawing.Point(3, 24);
            this.dgvListChequeStatus.Name = "dgvListChequeStatus";
            this.dgvListChequeStatus.RecordNavigator = true;
            this.dgvListChequeStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListChequeStatus.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvListChequeStatus.SettingsKey = "GridExEx";
            this.dgvListChequeStatus.Size = new System.Drawing.Size(600, 125);
            this.dgvListChequeStatus.Sortable = true;
            this.dgvListChequeStatus.TabIndex = 85;
            this.dgvListChequeStatus.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListChequeStatus.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListChequeStatus.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvListChequeStatus.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListChequeStatus.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListChequeStatus.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            // 
            // btnSelectCheque
            // 
            this.btnSelectCheque.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelectCheque.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectCheque.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSelectCheque.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectCheque.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSelectCheque.Location = new System.Drawing.Point(256, 0);
            this.btnSelectCheque.Name = "btnSelectCheque";
            this.btnSelectCheque.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnSelectCheque.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF5);
            this.btnSelectCheque.Size = new System.Drawing.Size(282, 28);
            this.btnSelectCheque.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSelectCheque.Symbol = "";
            this.btnSelectCheque.SymbolSize = 20F;
            this.btnSelectCheque.TabIndex = 11;
            this.btnSelectCheque.TabStop = false;
            this.btnSelectCheque.Text = "انتقال چک های انتخاب شده جهت ثبت سند";
            this.btnSelectCheque.Click += new System.EventHandler(this.btnSelectCheque_Click);
            // 
            // btnAddBanck
            // 
            this.btnAddBanck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddBanck.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBanck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddBanck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddBanck.Location = new System.Drawing.Point(77, 188);
            this.btnAddBanck.Name = "btnAddBanck";
            this.btnAddBanck.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddBanck.Size = new System.Drawing.Size(18, 28);
            this.btnAddBanck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddBanck.Symbol = "";
            this.btnAddBanck.SymbolSize = 15F;
            this.btnAddBanck.TabIndex = 155;
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
            this.cmbBanck.Location = new System.Drawing.Point(95, 187);
            this.cmbBanck.Name = "cmbBanck";
            this.cmbBanck.SelectedIndex = -1;
            this.cmbBanck.SelectedItem = null;
            this.cmbBanck.Size = new System.Drawing.Size(199, 30);
            this.cmbBanck.TabIndex = 154;
            this.cmbBanck.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.cmbBanck.ValueMember = "id";
            this.cmbBanck.ValueChanged += new System.EventHandler(this.cmbBanck_ValueChanged);
            this.cmbBanck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBanck_KeyDown);
            // 
            // frmCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 552);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmCheque";
            this.Text = "ثبت چک ها";
            this.Load += new System.EventHandler(this.frmCheque_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbChequeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPayer_Payee_Acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlListChequeStatus)).EndInit();
            this.pnlListChequeStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListChequeStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBanck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Atf.UI.DateTimeSelector txtDueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Class_General.MyTextBoxJanus txtDescription;
        private Class_General.MyTextBoxJanus txtChequeOwner;
        private Class_General.MyTextBoxJanus txtAmount;
        public Atf.UI.DateTimeSelector txtIssueDate;
        public GridExEx.GridExEx dgvList;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbPayer_Payee_Acc;
        private Class_General.MyTextBoxJanus txtChequeNumber;
        private Janus.Windows.Ribbon.RibbonContextMenu cmsdgv;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand2;
        private Janus.Windows.Ribbon.SeparatorCommand separatorCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand3;
        private Janus.Windows.EditControls.UIGroupBox pnlListChequeStatus;
        public GridExEx.GridExEx dgvListChequeStatus;
        public DevComponents.DotNetBar.ButtonX btnClosePael;
        private Janus.Windows.Ribbon.DropDownCommand btnListChequeStatus;
        public DevComponents.DotNetBar.ButtonX btnSelectCheque;
        public Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbChequeType;
        public DevComponents.DotNetBar.ButtonX btnAddBanck;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbBanck;
    }
}