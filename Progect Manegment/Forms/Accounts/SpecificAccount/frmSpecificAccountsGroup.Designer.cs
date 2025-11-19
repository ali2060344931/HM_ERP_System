namespace HM_ERP_System.Forms.Accounts.SpecificAccount
{
    partial class frmSpecificAccountsGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecificAccountsGroup));
            Janus.Windows.GridEX.GridEXLayout cmbTransactionTypes_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbSpecificAccountF_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvList = new GridExEx.GridExEx();
            this.cmbTransactionTypes = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.cmbSpecificAccountF = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new Janus.Windows.GridEX.EditControls.EditBox();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransactionTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSpecificAccountF)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(528, 338);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(528, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 388);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(528, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.txtDescription);
            this.pnlAddItemBodi.Controls.Add(this.buttonX2);
            this.pnlAddItemBodi.Controls.Add(this.cmbSpecificAccountF);
            this.pnlAddItemBodi.Controls.Add(this.txtName);
            this.pnlAddItemBodi.Controls.Add(this.cmbTransactionTypes);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(410, 388);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 388);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(410, 28);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(335, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(289, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 10, 3, 9, 36, 53, 808);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(87, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 10, 3, 9, 36, 53, 808);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(-3, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(217, 17);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(419, 17);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(530, 444);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(533, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(416, 444);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(494, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(460, 0);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(425, 0);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(304, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 115;
            this.label1.Text = "حساب معین:";
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
            this.dgvList.SettingsKey = "frmSpecificAccountsGroup";
            this.dgvList.Size = new System.Drawing.Size(528, 338);
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
            // cmbTransactionTypes
            // 
            this.cmbTransactionTypes.DataMember = "id";
            cmbTransactionTypes_DesignTimeLayout.LayoutString = resources.GetString("cmbTransactionTypes_DesignTimeLayout.LayoutString");
            this.cmbTransactionTypes.DesignTimeLayout = cmbTransactionTypes_DesignTimeLayout;
            this.cmbTransactionTypes.DisplayMember = "Name";
            this.cmbTransactionTypes.Location = new System.Drawing.Point(188, 17);
            this.cmbTransactionTypes.Name = "cmbTransactionTypes";
            this.cmbTransactionTypes.SelectedIndex = -1;
            this.cmbTransactionTypes.SelectedItem = null;
            this.cmbTransactionTypes.Size = new System.Drawing.Size(114, 28);
            this.cmbTransactionTypes.TabIndex = 119;
            this.cmbTransactionTypes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbTransactionTypes.ValueMember = "id";
            this.cmbTransactionTypes.ValueChanged += new System.EventHandler(this.cmbTransactionTypes_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(304, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 120;
            this.label2.Text = "نوع عملیات:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(304, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 120;
            this.label3.Text = "نام/عنوان گروه:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(33, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 28);
            this.txtName.TabIndex = 121;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.Transparent;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX2.Location = new System.Drawing.Point(7, 85);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX2.Size = new System.Drawing.Size(20, 28);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 15F;
            this.buttonX2.TabIndex = 140;
            this.buttonX2.TabStop = false;
            this.buttonX2.Tooltip = "ثبت آیتم جدید";
            // 
            // cmbSpecificAccountF
            // 
            this.cmbSpecificAccountF.DataMember = "id";
            cmbSpecificAccountF_DesignTimeLayout.LayoutString = resources.GetString("cmbSpecificAccountF_DesignTimeLayout.LayoutString");
            this.cmbSpecificAccountF.DesignTimeLayout = cmbSpecificAccountF_DesignTimeLayout;
            this.cmbSpecificAccountF.DisplayMember = "Name";
            this.cmbSpecificAccountF.Image = ((System.Drawing.Image)(resources.GetObject("cmbSpecificAccountF.Image")));
            this.cmbSpecificAccountF.Location = new System.Drawing.Point(33, 85);
            this.cmbSpecificAccountF.MaxLength = 8;
            this.cmbSpecificAccountF.Name = "cmbSpecificAccountF";
            this.cmbSpecificAccountF.SelectedIndex = -1;
            this.cmbSpecificAccountF.SelectedItem = null;
            this.cmbSpecificAccountF.Size = new System.Drawing.Size(271, 30);
            this.cmbSpecificAccountF.TabIndex = 139;
            this.cmbSpecificAccountF.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbSpecificAccountF.ValueMember = "id";
            this.cmbSpecificAccountF.ValueChanged += new System.EventHandler(this.cmbSpecificAccount_ValueChanged);
            this.cmbSpecificAccountF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSpecificAccount_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(306, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 115;
            this.label5.Text = "شرح پیشفرض:";
            // 
            // txtDescription
            // 
            this.txtDescription.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
            this.txtDescription.ButtonText = "..";
            this.txtDescription.Location = new System.Drawing.Point(7, 121);
            this.txtDescription.MaxLength = 9;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(297, 95);
            this.txtDescription.TabIndex = 142;
            this.txtDescription.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            // 
            // frmSpecificAccountsGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Name = "frmSpecificAccountsGroup";
            this.Text = "فــرم گروه بندی حساب ها";
            this.Load += new System.EventHandler(this.frmSpecificAccountsGroup_Load);
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
            ((System.Configuration.IPersistComponentSettings)(this.dgvList)).LoadComponentSettings();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransactionTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSpecificAccountF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public GridExEx.GridExEx dgvList;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbTransactionTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        public DevComponents.DotNetBar.ButtonX buttonX2;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbSpecificAccountF;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.GridEX.EditControls.EditBox txtDescription;
    }
}