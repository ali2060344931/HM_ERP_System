namespace HM_ERP_System.Forms.Accounts.Transaction
{
    partial class frmTransaction
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
            Janus.Windows.GridEX.GridEXLayout cmbContraAccountFrom_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbContraAccountTo_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbSpecificAccount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.cmbContraAccountFrom = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtTransactionDate = new Atf.UI.DateTimeSelector();
            this.txtTransactionCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lblContraAccountFrom = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.rdbIncomr = new System.Windows.Forms.RadioButton();
            this.rdbExpense = new System.Windows.Forms.RadioButton();
            this.btnAddNewCity1 = new DevComponents.DotNetBar.ButtonX();
            this.lblContraAccountTo = new System.Windows.Forms.Label();
            this.cmbContraAccountTo = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblIEAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new DevComponents.Editors.DoubleInput();
            this.txtIEAmount = new DevComponents.Editors.DoubleInput();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblSpecificAccount = new System.Windows.Forms.Label();
            this.cmbSpecificAccount = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.dgvList = new GridExEx.GridExEx();
            this.chkTax = new System.Windows.Forms.CheckBox();
            this.txtTaxAmount = new DevComponents.Editors.DoubleInput();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.lblInOut = new DevComponents.DotNetBar.LabelX();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContraAccountFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContraAccountTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIEAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSpecificAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(796, 372);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(796, 50);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 422);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(796, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.rdbIncomr);
            this.pnlAddItemBodi.Controls.Add(this.chkTax);
            this.pnlAddItemBodi.Controls.Add(this.txtDescription);
            this.pnlAddItemBodi.Controls.Add(this.txtTaxAmount);
            this.pnlAddItemBodi.Controls.Add(this.txtIEAmount);
            this.pnlAddItemBodi.Controls.Add(this.txtTotalAmount);
            this.pnlAddItemBodi.Controls.Add(this.buttonX4);
            this.pnlAddItemBodi.Controls.Add(this.buttonX3);
            this.pnlAddItemBodi.Controls.Add(this.buttonX1);
            this.pnlAddItemBodi.Controls.Add(this.buttonX2);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewCity1);
            this.pnlAddItemBodi.Controls.Add(this.rdbExpense);
            this.pnlAddItemBodi.Controls.Add(this.cmbContraAccountTo);
            this.pnlAddItemBodi.Controls.Add(this.cmbSpecificAccount);
            this.pnlAddItemBodi.Controls.Add(this.cmbContraAccountFrom);
            this.pnlAddItemBodi.Controls.Add(this.txtTransactionDate);
            this.pnlAddItemBodi.Controls.Add(this.lblIEAmount);
            this.pnlAddItemBodi.Controls.Add(this.lblTotalAmount);
            this.pnlAddItemBodi.Controls.Add(this.lblContraAccountTo);
            this.pnlAddItemBodi.Controls.Add(this.lblSpecificAccount);
            this.pnlAddItemBodi.Controls.Add(this.txtTransactionCode);
            this.pnlAddItemBodi.Controls.Add(this.lblContraAccountFrom);
            this.pnlAddItemBodi.Controls.Add(this.label50);
            this.pnlAddItemBodi.Controls.Add(this.label25);
            this.pnlAddItemBodi.Controls.Add(this.lblInOut);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(432, 422);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 422);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(432, 28);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(357, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(557, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 7, 12, 14, 13, 26, 322);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(355, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 7, 12, 14, 13, 26, 322);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(265, 15);
            this.btnShowListItems.Click += new System.EventHandler(this.btnShowListItems_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(485, 17);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(687, 17);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(798, 478);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(801, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(438, 478);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(762, 0);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(728, 0);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(693, 0);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // cmbContraAccountFrom
            // 
            this.cmbContraAccountFrom.DataMember = "id";
            cmbContraAccountFrom_DesignTimeLayout.LayoutString = resources.GetString("cmbContraAccountFrom_DesignTimeLayout.LayoutString");
            this.cmbContraAccountFrom.DesignTimeLayout = cmbContraAccountFrom_DesignTimeLayout;
            this.cmbContraAccountFrom.DisplayMember = "Name";
            this.cmbContraAccountFrom.Image = ((System.Drawing.Image)(resources.GetObject("cmbContraAccountFrom.Image")));
            this.cmbContraAccountFrom.Location = new System.Drawing.Point(71, 184);
            this.cmbContraAccountFrom.MaxLength = 8;
            this.cmbContraAccountFrom.Name = "cmbContraAccountFrom";
            this.cmbContraAccountFrom.SelectedIndex = -1;
            this.cmbContraAccountFrom.SelectedItem = null;
            this.cmbContraAccountFrom.Size = new System.Drawing.Size(279, 30);
            this.cmbContraAccountFrom.TabIndex = 5;
            this.cmbContraAccountFrom.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbContraAccountFrom.ValueMember = "id";
            this.cmbContraAccountFrom.ValueChanged += new System.EventHandler(this.cmbContraAccountFrom_ValueChanged);
            this.cmbContraAccountFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbContraAccountFrom_KeyDown);
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTransactionDate.Location = new System.Drawing.Point(205, 90);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTransactionDate.Size = new System.Drawing.Size(145, 29);
            this.txtTransactionDate.TabIndex = 2;
            this.txtTransactionDate.UsePersianFormat = true;
            // 
            // txtTransactionCode
            // 
            this.txtTransactionCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTransactionCode.Enabled = false;
            this.txtTransactionCode.Location = new System.Drawing.Point(205, 121);
            this.txtTransactionCode.MaxLength = 7;
            this.txtTransactionCode.Name = "txtTransactionCode";
            this.txtTransactionCode.Size = new System.Drawing.Size(145, 28);
            this.txtTransactionCode.TabIndex = 3;
            this.txtTransactionCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtTransactionCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransactionCode_KeyPress);
            // 
            // lblContraAccountFrom
            // 
            this.lblContraAccountFrom.AutoSize = true;
            this.lblContraAccountFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblContraAccountFrom.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblContraAccountFrom.Location = new System.Drawing.Point(358, 190);
            this.lblContraAccountFrom.Name = "lblContraAccountFrom";
            this.lblContraAccountFrom.Size = new System.Drawing.Size(57, 18);
            this.lblContraAccountFrom.TabIndex = 107;
            this.lblContraAccountFrom.Text = "دریافت از:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label50.Location = new System.Drawing.Point(358, 126);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(62, 18);
            this.label50.TabIndex = 108;
            this.label50.Text = "شماره سند:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label25.Location = new System.Drawing.Point(358, 94);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 18);
            this.label25.TabIndex = 109;
            this.label25.Text = "تاریخ سنــد:";
            // 
            // rdbIncomr
            // 
            this.rdbIncomr.AutoSize = true;
            this.rdbIncomr.Font = new System.Drawing.Font("Vazir FD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbIncomr.Location = new System.Drawing.Point(265, 8);
            this.rdbIncomr.Name = "rdbIncomr";
            this.rdbIncomr.Size = new System.Drawing.Size(139, 32);
            this.rdbIncomr.TabIndex = 0;
            this.rdbIncomr.Text = "درآمــــد(فروش)";
            this.rdbIncomr.UseVisualStyleBackColor = true;
            this.rdbIncomr.CheckedChanged += new System.EventHandler(this.rdbIncomr_CheckedChanged);
            // 
            // rdbExpense
            // 
            this.rdbExpense.AutoSize = true;
            this.rdbExpense.Font = new System.Drawing.Font("Vazir FD", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdbExpense.Location = new System.Drawing.Point(29, 8);
            this.rdbExpense.Name = "rdbExpense";
            this.rdbExpense.Size = new System.Drawing.Size(132, 32);
            this.rdbExpense.TabIndex = 1;
            this.rdbExpense.Text = "هــــزینه(خرید)";
            this.rdbExpense.UseVisualStyleBackColor = true;
            this.rdbExpense.CheckedChanged += new System.EventHandler(this.rdbExpense_CheckedChanged);
            // 
            // btnAddNewCity1
            // 
            this.btnAddNewCity1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewCity1.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCity1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewCity1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewCity1.Location = new System.Drawing.Point(52, 185);
            this.btnAddNewCity1.Name = "btnAddNewCity1";
            this.btnAddNewCity1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewCity1.Size = new System.Drawing.Size(18, 28);
            this.btnAddNewCity1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewCity1.Symbol = "";
            this.btnAddNewCity1.SymbolSize = 15F;
            this.btnAddNewCity1.TabIndex = 112;
            this.btnAddNewCity1.TabStop = false;
            this.btnAddNewCity1.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewCity1.Click += new System.EventHandler(this.btnAddNewCity1_Click);
            // 
            // lblContraAccountTo
            // 
            this.lblContraAccountTo.AutoSize = true;
            this.lblContraAccountTo.BackColor = System.Drawing.Color.Transparent;
            this.lblContraAccountTo.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblContraAccountTo.Location = new System.Drawing.Point(358, 225);
            this.lblContraAccountTo.Name = "lblContraAccountTo";
            this.lblContraAccountTo.Size = new System.Drawing.Size(47, 18);
            this.lblContraAccountTo.TabIndex = 107;
            this.lblContraAccountTo.Text = "واریز به:";
            // 
            // cmbContraAccountTo
            // 
            this.cmbContraAccountTo.DataMember = "id";
            cmbContraAccountTo_DesignTimeLayout.LayoutString = resources.GetString("cmbContraAccountTo_DesignTimeLayout.LayoutString");
            this.cmbContraAccountTo.DesignTimeLayout = cmbContraAccountTo_DesignTimeLayout;
            this.cmbContraAccountTo.DisplayMember = "Name";
            this.cmbContraAccountTo.Image = ((System.Drawing.Image)(resources.GetObject("cmbContraAccountTo.Image")));
            this.cmbContraAccountTo.Location = new System.Drawing.Point(71, 219);
            this.cmbContraAccountTo.MaxLength = 8;
            this.cmbContraAccountTo.Name = "cmbContraAccountTo";
            this.cmbContraAccountTo.SelectedIndex = -1;
            this.cmbContraAccountTo.SelectedItem = null;
            this.cmbContraAccountTo.Size = new System.Drawing.Size(279, 30);
            this.cmbContraAccountTo.TabIndex = 6;
            this.cmbContraAccountTo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbContraAccountTo.ValueMember = "id";
            this.cmbContraAccountTo.ValueChanged += new System.EventHandler(this.cmbContraAccountTo_ValueChanged);
            this.cmbContraAccountTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbContraAccountTo_KeyDown);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(52, 220);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Size = new System.Drawing.Size(18, 28);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 112;
            this.buttonX1.TabStop = false;
            this.buttonX1.Tooltip = "ثبت آیتم جدید";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTotalAmount.Location = new System.Drawing.Point(358, 261);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(72, 18);
            this.lblTotalAmount.TabIndex = 107;
            this.lblTotalAmount.Text = "مبلغ درآمـــــد:";
            // 
            // lblIEAmount
            // 
            this.lblIEAmount.AutoSize = true;
            this.lblIEAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblIEAmount.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIEAmount.Location = new System.Drawing.Point(358, 295);
            this.lblIEAmount.Name = "lblIEAmount";
            this.lblIEAmount.Size = new System.Drawing.Size(72, 18);
            this.lblIEAmount.TabIndex = 107;
            this.lblIEAmount.Text = "پیش دریافت:";
            // 
            // txtTotalAmount
            // 
            // 
            // 
            // 
            this.txtTotalAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTotalAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTotalAmount.ButtonCalculator.Visible = true;
            this.txtTotalAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTotalAmount.DisplayFormat = "#,##0";
            this.txtTotalAmount.Increment = 1D;
            this.txtTotalAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtTotalAmount.Location = new System.Drawing.Point(170, 256);
            this.txtTotalAmount.MaxValue = 1797693134862.3157D;
            this.txtTotalAmount.MinValue = 0D;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(180, 28);
            this.txtTotalAmount.TabIndex = 7;
            this.txtTotalAmount.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.txtTotalAmount.WatermarkText = "مبــــلغ";
            this.txtTotalAmount.ValueChanged += new System.EventHandler(this.txtTotalAmount_ValueChanged);
            // 
            // txtIEAmount
            // 
            // 
            // 
            // 
            this.txtIEAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtIEAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIEAmount.ButtonCalculator.Visible = true;
            this.txtIEAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtIEAmount.DisplayFormat = "#,##0";
            this.txtIEAmount.Increment = 1D;
            this.txtIEAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtIEAmount.Location = new System.Drawing.Point(170, 290);
            this.txtIEAmount.MaxValue = 1797693134862.3157D;
            this.txtIEAmount.MinValue = 0D;
            this.txtIEAmount.Name = "txtIEAmount";
            this.txtIEAmount.Size = new System.Drawing.Size(180, 28);
            this.txtIEAmount.TabIndex = 8;
            this.txtIEAmount.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.txtIEAmount.WatermarkText = "مبــــلغ";
            this.txtIEAmount.Enter += new System.EventHandler(this.txtIEAmount_Enter);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(53, 357);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(297, 62);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Text = "";
            // 
            // lblSpecificAccount
            // 
            this.lblSpecificAccount.AutoSize = true;
            this.lblSpecificAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecificAccount.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSpecificAccount.Location = new System.Drawing.Point(358, 156);
            this.lblSpecificAccount.Name = "lblSpecificAccount";
            this.lblSpecificAccount.Size = new System.Drawing.Size(63, 18);
            this.lblSpecificAccount.TabIndex = 107;
            this.lblSpecificAccount.Text = "درآمد بابت:";
            // 
            // cmbSpecificAccount
            // 
            this.cmbSpecificAccount.DataMember = "id";
            cmbSpecificAccount_DesignTimeLayout.LayoutString = resources.GetString("cmbSpecificAccount_DesignTimeLayout.LayoutString");
            this.cmbSpecificAccount.DesignTimeLayout = cmbSpecificAccount_DesignTimeLayout;
            this.cmbSpecificAccount.DisplayMember = "Name";
            this.cmbSpecificAccount.Image = ((System.Drawing.Image)(resources.GetObject("cmbSpecificAccount.Image")));
            this.cmbSpecificAccount.Location = new System.Drawing.Point(71, 150);
            this.cmbSpecificAccount.MaxLength = 8;
            this.cmbSpecificAccount.Name = "cmbSpecificAccount";
            this.cmbSpecificAccount.SelectedIndex = -1;
            this.cmbSpecificAccount.SelectedItem = null;
            this.cmbSpecificAccount.Size = new System.Drawing.Size(279, 30);
            this.cmbSpecificAccount.TabIndex = 4;
            this.cmbSpecificAccount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbSpecificAccount.ValueMember = "id";
            this.cmbSpecificAccount.ValueChanged += new System.EventHandler(this.cmbSpecificAccount_ValueChanged);
            this.cmbSpecificAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSpecificAccount_KeyDown);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX2.Location = new System.Drawing.Point(52, 151);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX2.Size = new System.Drawing.Size(18, 28);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 15F;
            this.buttonX2.TabIndex = 112;
            this.buttonX2.TabStop = false;
            this.buttonX2.Tooltip = "ثبت آیتم جدید";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.BackColor = System.Drawing.Color.Transparent;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX3.Location = new System.Drawing.Point(11, 220);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX3.Size = new System.Drawing.Size(39, 28);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "59387";
            this.buttonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX3.SymbolSize = 20F;
            this.buttonX3.TabIndex = 112;
            this.buttonX3.TabStop = false;
            this.buttonX3.Tooltip = "جهت واریز/برداشت به چند حساب";
            this.buttonX3.Visible = false;
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.FrozenColumns = 4;
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
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvList.SaveSettings = true;
            this.dgvList.SettingsKey = "frmTransaction";
            this.dgvList.Size = new System.Drawing.Size(796, 372);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 84;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            // 
            // chkTax
            // 
            this.chkTax.AutoSize = true;
            this.chkTax.Location = new System.Drawing.Point(359, 325);
            this.chkTax.Name = "chkTax";
            this.chkTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkTax.Size = new System.Drawing.Size(69, 26);
            this.chkTax.TabIndex = 116;
            this.chkTax.Text = ":مالیات";
            this.chkTax.UseVisualStyleBackColor = true;
            this.chkTax.CheckedChanged += new System.EventHandler(this.chkTax_CheckedChanged);
            // 
            // txtTaxAmount
            // 
            // 
            // 
            // 
            this.txtTaxAmount.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTaxAmount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTaxAmount.ButtonCalculator.Visible = true;
            this.txtTaxAmount.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtTaxAmount.DisplayFormat = "#,##0";
            this.txtTaxAmount.Enabled = false;
            this.txtTaxAmount.Increment = 1D;
            this.txtTaxAmount.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtTaxAmount.Location = new System.Drawing.Point(170, 324);
            this.txtTaxAmount.MaxValue = 1797693134862.3157D;
            this.txtTaxAmount.MinValue = 0D;
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.Size = new System.Drawing.Size(180, 28);
            this.txtTaxAmount.TabIndex = 9;
            this.txtTaxAmount.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.txtTaxAmount.WatermarkText = "مبــــلغ";
            this.txtTaxAmount.Enter += new System.EventHandler(this.txtIEAmount_Enter);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.BackColor = System.Drawing.Color.Transparent;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX4.Location = new System.Drawing.Point(356, 357);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX4.Size = new System.Drawing.Size(72, 28);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX4.SymbolSize = 20F;
            this.buttonX4.TabIndex = 112;
            this.buttonX4.TabStop = false;
            this.buttonX4.Text = "شــــرح سنـــد:";
            this.buttonX4.Tooltip = "ساخت شـــرح سند پیشفرض";
            // 
            // lblInOut
            // 
            // 
            // 
            // 
            this.lblInOut.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInOut.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.lblInOut.Location = new System.Drawing.Point(161, 5);
            this.lblInOut.Name = "lblInOut";
            this.lblInOut.Size = new System.Drawing.Size(104, 81);
            this.lblInOut.Symbol = "";
            this.lblInOut.SymbolSize = 60F;
            this.lblInOut.TabIndex = 117;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 484);
            this.KeyPreview = true;
            this.Name = "frmTransaction";
            this.Text = "فـــرم ثبت اسناد درآمــــد(فروش) - هــــربنه(خرید)";
            this.Activated += new System.EventHandler(this.frmTransaction_Activated);
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTransaction_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbContraAccountFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContraAccountTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIEAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSpecificAccount)).EndInit();
            ((System.Configuration.IPersistComponentSettings)(this.dgvList)).LoadComponentSettings();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbContraAccountFrom;
        public Atf.UI.DateTimeSelector txtTransactionDate;
        private Janus.Windows.GridEX.EditControls.EditBox txtTransactionCode;
        private System.Windows.Forms.Label lblContraAccountFrom;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label25;
        public DevComponents.DotNetBar.ButtonX buttonX1;
        public DevComponents.DotNetBar.ButtonX btnAddNewCity1;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbContraAccountTo;
        private System.Windows.Forms.Label lblIEAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblContraAccountTo;
        private DevComponents.Editors.DoubleInput txtIEAmount;
        private DevComponents.Editors.DoubleInput txtTotalAmount;
        private System.Windows.Forms.RichTextBox txtDescription;
        public DevComponents.DotNetBar.ButtonX buttonX2;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbSpecificAccount;
        private System.Windows.Forms.Label lblSpecificAccount;
        public DevComponents.DotNetBar.ButtonX buttonX3;
        public GridExEx.GridExEx dgvList;
        public System.Windows.Forms.RadioButton rdbExpense;
        public System.Windows.Forms.RadioButton rdbIncomr;
        private System.Windows.Forms.CheckBox chkTax;
        private DevComponents.Editors.DoubleInput txtTaxAmount;
        public DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.LabelX lblInOut;
    }
}