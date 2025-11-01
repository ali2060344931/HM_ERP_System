namespace HM_ERP_System.Forms.Accounts.DetailedAccount
{
    partial class frmDetailedAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailedAccount));
            Janus.Windows.GridEX.GridEXLayout cmbNatureAccounts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbSpecificAccount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCustomers_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.txtAmount = new DevComponents.Editors.DoubleInput();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbNatureAccounts = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSpecificAccount = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cmbCustomers = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnAddNewSpecificAccount = new DevComponents.DotNetBar.ButtonX();
            this.btnAddNewCustomers = new DevComponents.DotNetBar.ButtonX();
            this.btnAddCustomers = new DevComponents.DotNetBar.ButtonItem();
            this.btnContraAccountsB = new DevComponents.DotNetBar.ButtonItem();
            this.btnContraAccountsC = new DevComponents.DotNetBar.ButtonItem();
            this.btnOtherAccounts = new DevComponents.DotNetBar.ButtonItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodeAccount = new System.Windows.Forms.Label();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNatureAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSpecificAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(753, 334);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(753, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 384);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(753, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.txtAmount);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label19);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.lblCodeAccount);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label18);
            this.pnlAddItemBodi.Controls.Add(this.cmbCustomers);
            this.pnlAddItemBodi.Controls.Add(this.cmbSpecificAccount);
            this.pnlAddItemBodi.Controls.Add(this.cmbNatureAccounts);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewCustomers);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewSpecificAccount);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(438, 384);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 384);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(438, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(363, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(514, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 7, 19, 12, 24, 31, 607);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(312, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 7, 19, 12, 24, 31, 607);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(222, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(442, 17);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(644, 17);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(755, 440);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(758, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(444, 440);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(719, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(685, 0);
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.FrozenColumns = 5;
            this.dgvList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.dgvList.GroupTotals = Janus.Windows.GridEX.GroupTotals.ExpandedGroup;
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
            this.dgvList.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.SettingsKey = "frmDetailedAccount1";
            this.dgvList.Size = new System.Drawing.Size(753, 334);
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
            this.txtAmount.Location = new System.Drawing.Point(184, 111);
            this.txtAmount.MaxValue = 1797693134862.3157D;
            this.txtAmount.MinValue = 0D;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(132, 28);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.txtAmount.WatermarkText = "مبــــلغ";
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(320, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 18);
            this.label19.TabIndex = 102;
            this.label19.Text = "ماهیت:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(320, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 18);
            this.label18.TabIndex = 103;
            this.label18.Text = "مانده ابتدای دوره:";
            // 
            // cmbNatureAccounts
            // 
            this.cmbNatureAccounts.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbNatureAccounts.DataMember = "id";
            cmbNatureAccounts_DesignTimeLayout.LayoutString = resources.GetString("cmbNatureAccounts_DesignTimeLayout.LayoutString");
            this.cmbNatureAccounts.DesignTimeLayout = cmbNatureAccounts_DesignTimeLayout;
            this.cmbNatureAccounts.DisplayMember = "Name";
            this.cmbNatureAccounts.Location = new System.Drawing.Point(184, 145);
            this.cmbNatureAccounts.Name = "cmbNatureAccounts";
            this.cmbNatureAccounts.SelectedIndex = -1;
            this.cmbNatureAccounts.SelectedItem = null;
            this.cmbNatureAccounts.Size = new System.Drawing.Size(132, 28);
            this.cmbNatureAccounts.TabIndex = 3;
            this.cmbNatureAccounts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbNatureAccounts.ValueMember = "id";
            this.cmbNatureAccounts.ValueChanged += new System.EventHandler(this.cmbNatureAccounts_ValueChanged);
            this.cmbNatureAccounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(320, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 103;
            this.label1.Text = "حساب معین:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(320, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 102;
            this.label2.Text = "حساب تفصیل:";
            // 
            // cmbSpecificAccount
            // 
            this.cmbSpecificAccount.DataMember = "id";
            cmbSpecificAccount_DesignTimeLayout.LayoutString = resources.GetString("cmbSpecificAccount_DesignTimeLayout.LayoutString");
            this.cmbSpecificAccount.DesignTimeLayout = cmbSpecificAccount_DesignTimeLayout;
            this.cmbSpecificAccount.DisplayMember = "Name";
            this.cmbSpecificAccount.Image = ((System.Drawing.Image)(resources.GetObject("cmbSpecificAccount.Image")));
            this.cmbSpecificAccount.Location = new System.Drawing.Point(53, 17);
            this.cmbSpecificAccount.Name = "cmbSpecificAccount";
            this.cmbSpecificAccount.SelectedIndex = -1;
            this.cmbSpecificAccount.SelectedItem = null;
            this.cmbSpecificAccount.Size = new System.Drawing.Size(263, 30);
            this.cmbSpecificAccount.TabIndex = 0;
            this.cmbSpecificAccount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbSpecificAccount.ValueMember = "id";
            this.cmbSpecificAccount.ValueChanged += new System.EventHandler(this.cmbSpecificAccount_ValueChanged);
            this.cmbSpecificAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSpecificAccount_KeyDown);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DataMember = "id";
            cmbCustomers_DesignTimeLayout.LayoutString = resources.GetString("cmbCustomers_DesignTimeLayout.LayoutString");
            this.cmbCustomers.DesignTimeLayout = cmbCustomers_DesignTimeLayout;
            this.cmbCustomers.DisplayMember = "Name";
            this.cmbCustomers.Image = ((System.Drawing.Image)(resources.GetObject("cmbCustomers.Image")));
            this.cmbCustomers.Location = new System.Drawing.Point(53, 50);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.SelectedIndex = -1;
            this.cmbCustomers.SelectedItem = null;
            this.cmbCustomers.Size = new System.Drawing.Size(263, 30);
            this.cmbCustomers.TabIndex = 1;
            this.cmbCustomers.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCustomers.ValueMember = "id";
            this.cmbCustomers.ValueChanged += new System.EventHandler(this.cmbCustomers_ValueChanged);
            this.cmbCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomers_KeyDown);
            this.cmbCustomers.Leave += new System.EventHandler(this.cmbCustomers_Leave);
            // 
            // btnAddNewSpecificAccount
            // 
            this.btnAddNewSpecificAccount.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewSpecificAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewSpecificAccount.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewSpecificAccount.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewSpecificAccount.Location = new System.Drawing.Point(32, 19);
            this.btnAddNewSpecificAccount.Name = "btnAddNewSpecificAccount";
            this.btnAddNewSpecificAccount.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewSpecificAccount.Size = new System.Drawing.Size(19, 28);
            this.btnAddNewSpecificAccount.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewSpecificAccount.Symbol = "";
            this.btnAddNewSpecificAccount.SymbolSize = 15F;
            this.btnAddNewSpecificAccount.TabIndex = 105;
            this.btnAddNewSpecificAccount.TabStop = false;
            this.btnAddNewSpecificAccount.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewSpecificAccount.Click += new System.EventHandler(this.btnAddNewSpecificAccount_Click);
            // 
            // btnAddNewCustomers
            // 
            this.btnAddNewCustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewCustomers.AutoExpandOnClick = true;
            this.btnAddNewCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCustomers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewCustomers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnAddNewCustomers.Location = new System.Drawing.Point(13, 50);
            this.btnAddNewCustomers.Name = "btnAddNewCustomers";
            this.btnAddNewCustomers.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewCustomers.Size = new System.Drawing.Size(38, 28);
            this.btnAddNewCustomers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewCustomers.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddCustomers,
            this.btnContraAccountsB,
            this.btnContraAccountsC,
            this.btnOtherAccounts});
            this.btnAddNewCustomers.Symbol = "";
            this.btnAddNewCustomers.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddNewCustomers.SymbolSize = 15F;
            this.btnAddNewCustomers.TabIndex = 105;
            this.btnAddNewCustomers.TabStop = false;
            this.btnAddNewCustomers.Tooltip = "ثبت آیتم جدید";
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.GlobalItem = false;
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Text = "اشخاص حقیقی/حقوقی";
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // btnContraAccountsB
            // 
            this.btnContraAccountsB.GlobalItem = false;
            this.btnContraAccountsB.Name = "btnContraAccountsB";
            this.btnContraAccountsB.Text = "بانک";
            this.btnContraAccountsB.Click += new System.EventHandler(this.btnContraAccounts_Click);
            // 
            // btnContraAccountsC
            // 
            this.btnContraAccountsC.GlobalItem = false;
            this.btnContraAccountsC.Name = "btnContraAccountsC";
            this.btnContraAccountsC.Text = "صندوق";
            this.btnContraAccountsC.Click += new System.EventHandler(this.btnContraAccountsC_Click);
            // 
            // btnOtherAccounts
            // 
            this.btnOtherAccounts.GlobalItem = false;
            this.btnOtherAccounts.Name = "btnOtherAccounts";
            this.btnOtherAccounts.Text = "ســــــایر";
            this.btnOtherAccounts.Click += new System.EventHandler(this.btnOtherAccounts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(320, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 103;
            this.label3.Text = "کد حســاب:";
            // 
            // lblCodeAccount
            // 
            this.lblCodeAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodeAccount.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCodeAccount.Location = new System.Drawing.Point(186, 83);
            this.lblCodeAccount.Name = "lblCodeAccount";
            this.lblCodeAccount.Size = new System.Drawing.Size(130, 23);
            this.lblCodeAccount.TabIndex = 103;
            this.lblCodeAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDetailedAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 446);
            this.KeyPreview = true;
            this.Name = "frmDetailedAccount";
            this.Text = "فرم ثبت حساب های تفصیلی";
            this.Load += new System.EventHandler(this.frmDetailedAccount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDetailedAccount_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDetailedAccount_PreviewKeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNatureAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSpecificAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        private DevComponents.Editors.DoubleInput txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCustomers;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbNatureAccounts;
        public DevComponents.DotNetBar.ButtonX btnAddNewCustomers;
        public DevComponents.DotNetBar.ButtonX btnAddNewSpecificAccount;
        private DevComponents.DotNetBar.ButtonItem btnAddCustomers;
        private DevComponents.DotNetBar.ButtonItem btnContraAccountsB;
        private DevComponents.DotNetBar.ButtonItem btnOtherAccounts;
        private System.Windows.Forms.Label lblCodeAccount;
        private System.Windows.Forms.Label label3;
        protected Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbSpecificAccount;
        private DevComponents.DotNetBar.ButtonItem btnContraAccountsC;
    }
}