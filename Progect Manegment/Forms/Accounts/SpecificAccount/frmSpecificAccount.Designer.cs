namespace HM_ERP_System.Forms.Accounts.SpecificAccount
{
    partial class frmSpecificAccount
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
            Janus.Windows.GridEX.GridEXLayout cmbTotalAccount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecificAccount));
            this.cmbTotalAccount = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.dgvList = new GridExEx.GridExEx();
            this.btnAddNewCity1 = new DevComponents.DotNetBar.ButtonX();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTotalAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(548, 301);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(548, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 351);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(548, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.chkStatus);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewCity1);
            this.pnlAddItemBodi.Controls.Add(this.cmbTotalAccount);
            this.pnlAddItemBodi.Controls.Add(this.txtName);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(371, 351);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 351);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(371, 28);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(296, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(309, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 7, 10, 13, 4, 12, 926);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(107, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 7, 10, 13, 4, 12, 926);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(17, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(237, 17);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(439, 17);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(550, 407);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(553, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(377, 407);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(514, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(480, 0);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(445, 0);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // cmbTotalAccount
            // 
            this.cmbTotalAccount.DataMember = "id";
            cmbTotalAccount_DesignTimeLayout.LayoutString = resources.GetString("cmbTotalAccount_DesignTimeLayout.LayoutString");
            this.cmbTotalAccount.DesignTimeLayout = cmbTotalAccount_DesignTimeLayout;
            this.cmbTotalAccount.DisplayMember = "Name";
            this.cmbTotalAccount.Image = ((System.Drawing.Image)(resources.GetObject("cmbTotalAccount.Image")));
            this.cmbTotalAccount.Location = new System.Drawing.Point(31, 21);
            this.cmbTotalAccount.Name = "cmbTotalAccount";
            this.cmbTotalAccount.SelectedIndex = -1;
            this.cmbTotalAccount.SelectedItem = null;
            this.cmbTotalAccount.Size = new System.Drawing.Size(228, 30);
            this.cmbTotalAccount.TabIndex = 7;
            this.cmbTotalAccount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbTotalAccount.ValueMember = "id";
            this.cmbTotalAccount.ValueChanged += new System.EventHandler(this.cmbTotalAccount_ValueChanged);
            this.cmbTotalAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTotalAccount_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(17, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 28);
            this.txtName.TabIndex = 8;
            this.txtName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
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
            this.dgvList.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.dgvList.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.SaveSettings = true;
            this.dgvList.SettingsKey = "frmSpecificAccount";
            this.dgvList.Size = new System.Drawing.Size(548, 301);
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
            // btnAddNewCity1
            // 
            this.btnAddNewCity1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewCity1.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewCity1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewCity1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewCity1.Location = new System.Drawing.Point(10, 22);
            this.btnAddNewCity1.Name = "btnAddNewCity1";
            this.btnAddNewCity1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewCity1.Size = new System.Drawing.Size(18, 28);
            this.btnAddNewCity1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewCity1.Symbol = "";
            this.btnAddNewCity1.SymbolSize = 15F;
            this.btnAddNewCity1.TabIndex = 75;
            this.btnAddNewCity1.TabStop = false;
            this.btnAddNewCity1.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewCity1.Click += new System.EventHandler(this.btnAddNewCity1_Click);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(202, 91);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(57, 26);
            this.chkStatus.TabIndex = 76;
            this.chkStatus.Text = "فعال";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(262, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "نام حساب معین:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(262, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 99;
            this.label2.Text = "وضعیت:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(262, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 99;
            this.label3.Text = "حساب کل:";
            // 
            // frmSpecificAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 413);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmSpecificAccount";
            this.Text = "فرم ثبت حساب های معین";
            this.Load += new System.EventHandler(this.frmSpecificAccount_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSpecificAccount_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbTotalAccount)).EndInit();
            ((System.Configuration.IPersistComponentSettings)(this.dgvList)).LoadComponentSettings();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbTotalAccount;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        public GridExEx.GridExEx dgvList;
        public DevComponents.DotNetBar.ButtonX btnAddNewCity1;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}