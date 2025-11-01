namespace HM_ERP_System.Forms.User
{
    partial class frmUser
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
            Janus.Windows.GridEX.GridEXLayout cmbUserType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            Janus.Windows.GridEX.GridEXLayout cmbCustomers_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            this.btnAddNewItem = new DevComponents.DotNetBar.ButtonX();
            this.cmbUserType = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbCustomers = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.chkStatus = new Janus.Windows.EditControls.UICheckBox();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.dgvList = new GridExEx.GridExEx();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtPasswordR = new System.Windows.Forms.TextBox();
            this.chkEditPass = new Janus.Windows.EditControls.UICheckBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(474, 338);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(474, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 388);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(474, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.txtPasswordR);
            this.pnlAddItemBodi.Controls.Add(this.txtPassword);
            this.pnlAddItemBodi.Controls.Add(this.chkEditPass);
            this.pnlAddItemBodi.Controls.Add(this.chkStatus);
            this.pnlAddItemBodi.Controls.Add(this.labelX10);
            this.pnlAddItemBodi.Controls.Add(this.buttonX1);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewItem);
            this.pnlAddItemBodi.Controls.Add(this.cmbCustomers);
            this.pnlAddItemBodi.Controls.Add(this.labelX6);
            this.pnlAddItemBodi.Controls.Add(this.cmbUserType);
            this.pnlAddItemBodi.Controls.Add(this.labelX5);
            this.pnlAddItemBodi.Controls.Add(this.labelX4);
            this.pnlAddItemBodi.Controls.Add(this.labelX3);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(312, 388);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 388);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(235, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 7, 8, 11, 12, 16, 737);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(33, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 7, 8, 11, 12, 16, 737);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(-57, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(163, 17);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(365, 17);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(476, 444);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(479, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(318, 444);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(297, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewItem.Location = new System.Drawing.Point(13, 22);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewItem.Size = new System.Drawing.Size(18, 28);
            this.btnAddNewItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewItem.Symbol = "";
            this.btnAddNewItem.SymbolSize = 15F;
            this.btnAddNewItem.TabIndex = 30;
            this.btnAddNewItem.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // cmbUserType
            // 
            this.cmbUserType.DataMember = "id";
            cmbUserType_DesignTimeLayout.LayoutString = resources.GetString("cmbUserType_DesignTimeLayout.LayoutString");
            this.cmbUserType.DesignTimeLayout = cmbUserType_DesignTimeLayout;
            this.cmbUserType.DisplayMember = "Name";
            this.cmbUserType.Location = new System.Drawing.Point(34, 56);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.SelectedIndex = -1;
            this.cmbUserType.SelectedItem = null;
            this.cmbUserType.Size = new System.Drawing.Size(183, 28);
            this.cmbUserType.TabIndex = 1;
            this.cmbUserType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbUserType.ValueMember = "id";
            this.cmbUserType.ValueChanged += new System.EventHandler(this.cmbUserType_ValueChanged);
            this.cmbUserType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomers_KeyDown);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(223, 59);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(63, 23);
            this.labelX4.TabIndex = 28;
            this.labelX4.Text = "نوع کاربری:";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(223, 25);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(50, 23);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "نام کاربر:";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DataMember = "id";
            cmbCustomers_DesignTimeLayout.LayoutString = resources.GetString("cmbCustomers_DesignTimeLayout.LayoutString");
            this.cmbCustomers.DesignTimeLayout = cmbCustomers_DesignTimeLayout;
            this.cmbCustomers.DisplayMember = "Name";
            this.cmbCustomers.Location = new System.Drawing.Point(34, 22);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.SelectedIndex = -1;
            this.cmbCustomers.SelectedItem = null;
            this.cmbCustomers.Size = new System.Drawing.Size(183, 28);
            this.cmbCustomers.TabIndex = 0;
            this.cmbCustomers.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCustomers.ValueMember = "id";
            this.cmbCustomers.ValueChanged += new System.EventHandler(this.cmbCustomers_ValueChanged);
            this.cmbCustomers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomers_KeyDown);
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(223, 120);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(49, 23);
            this.labelX5.TabIndex = 28;
            this.labelX5.Text = "رمز عبور:";
            // 
            // chkStatus
            // 
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(168, 193);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(49, 25);
            this.chkStatus.TabIndex = 5;
            this.chkStatus.Text = "فعال";
            this.chkStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomers_KeyDown);
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(223, 193);
            this.labelX10.Name = "labelX10";
            this.labelX10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX10.Size = new System.Drawing.Size(48, 23);
            this.labelX10.TabIndex = 32;
            this.labelX10.Text = "وضعیت:";
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
            this.dgvList.Size = new System.Drawing.Size(474, 338);
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
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(34, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomers_KeyDown);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(223, 154);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(76, 23);
            this.labelX6.TabIndex = 28;
            this.labelX6.Text = "تکرار رمز عبور:";
            // 
            // txtPasswordR
            // 
            this.txtPasswordR.Location = new System.Drawing.Point(34, 151);
            this.txtPasswordR.Name = "txtPasswordR";
            this.txtPasswordR.PasswordChar = '*';
            this.txtPasswordR.Size = new System.Drawing.Size(183, 28);
            this.txtPasswordR.TabIndex = 4;
            this.txtPasswordR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswordR.UseSystemPasswordChar = true;
            this.txtPasswordR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomers_KeyDown);
            // 
            // chkEditPass
            // 
            this.chkEditPass.Location = new System.Drawing.Point(106, 90);
            this.chkEditPass.Name = "chkEditPass";
            this.chkEditPass.Size = new System.Drawing.Size(111, 25);
            this.chkEditPass.TabIndex = 2;
            this.chkEditPass.Text = "ویرایش رمز عبور";
            this.chkEditPass.Visible = false;
            this.chkEditPass.CheckedChanged += new System.EventHandler(this.chkEditPass_CheckedChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(13, 56);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Size = new System.Drawing.Size(18, 28);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 30;
            this.buttonX1.Tooltip = "ثبت آیتم جدید";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.KeyPreview = true;
            this.Name = "frmUser";
            this.Text = "فرم ثبت کاربران سیستم";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUser_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX btnAddNewItem;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbUserType;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCustomers;
        private DevComponents.DotNetBar.LabelX labelX5;
        private Janus.Windows.EditControls.UICheckBox chkStatus;
        private DevComponents.DotNetBar.LabelX labelX10;
        public GridExEx.GridExEx dgvList;
        private System.Windows.Forms.TextBox txtPasswordR;
        private System.Windows.Forms.TextBox txtPassword;
        private DevComponents.DotNetBar.LabelX labelX6;
        private Janus.Windows.EditControls.UICheckBox chkEditPass;
        public DevComponents.DotNetBar.ButtonX buttonX1;
    }
}