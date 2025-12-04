namespace HM_ERP_System.Forms.CustomerToGroup
{
    partial class frmCustomerToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerToGroup));
            Janus.Windows.GridEX.GridEXLayout cmbGroup_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbPerson_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.btnAddPerson = new DevComponents.DotNetBar.ButtonX();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGroup = new DevComponents.DotNetBar.ButtonX();
            this.cmbGroup = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.cmbPerson = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(429, 345);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(429, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 395);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(429, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.cmbPerson);
            this.pnlAddItemBodi.Controls.Add(this.cmbGroup);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Controls.Add(this.btnAddGroup);
            this.pnlAddItemBodi.Controls.Add(this.btnAddPerson);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(424, 395);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 395);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(424, 28);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(349, 0);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(190, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 8, 13, 20, 54, 32, 498);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(-12, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 8, 13, 20, 54, 32, 498);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(-102, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(118, 17);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(320, 17);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(431, 451);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(434, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(430, 451);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(395, 0);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(361, 0);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(326, 0);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
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
            this.dgvList.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvList.SaveSettings = true;
            this.dgvList.SettingsKey = "frmCustomerToGroup";
            this.dgvList.Size = new System.Drawing.Size(429, 345);
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
            // btnAddPerson
            // 
            this.btnAddPerson.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddPerson.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddPerson.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddPerson.Location = new System.Drawing.Point(17, 17);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddPerson.Size = new System.Drawing.Size(20, 28);
            this.btnAddPerson.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddPerson.Symbol = "";
            this.btnAddPerson.SymbolSize = 12F;
            this.btnAddPerson.TabIndex = 27;
            this.btnAddPerson.TabStop = false;
            this.btnAddPerson.Tooltip = "ثبت آیتم جدید";
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(333, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 18);
            this.label14.TabIndex = 109;
            this.label14.Text = "نام شخص:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(333, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 109;
            this.label1.Text = "گروه ها:";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddGroup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddGroup.Location = new System.Drawing.Point(17, 51);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddGroup.Size = new System.Drawing.Size(20, 28);
            this.btnAddGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddGroup.Symbol = "";
            this.btnAddGroup.SymbolSize = 12F;
            this.btnAddGroup.TabIndex = 27;
            this.btnAddGroup.TabStop = false;
            this.btnAddGroup.Tooltip = "ثبت آیتم جدید";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.ButtonCancelText = "انصراف";
            this.cmbGroup.ButtonOKText = "تائید";
            cmbGroup_DesignTimeLayout.LayoutString = resources.GetString("cmbGroup_DesignTimeLayout.LayoutString");
            this.cmbGroup.DesignTimeLayout = cmbGroup_DesignTimeLayout;
            this.cmbGroup.DropDownDisplayMember = "Name";
            this.cmbGroup.DropDownValueMember = "id";
            this.cmbGroup.Location = new System.Drawing.Point(38, 50);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.SaveSettings = false;
            this.cmbGroup.Size = new System.Drawing.Size(295, 28);
            this.cmbGroup.TabIndex = 112;
            this.cmbGroup.ValuesDataMember = null;
            this.cmbGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGroup_KeyDown);
            // 
            // cmbPerson
            // 
            this.cmbPerson.ButtonCancelText = "انصراف";
            this.cmbPerson.ButtonOKText = "تائید";
            cmbPerson_DesignTimeLayout.LayoutString = resources.GetString("cmbPerson_DesignTimeLayout.LayoutString");
            this.cmbPerson.DesignTimeLayout = cmbPerson_DesignTimeLayout;
            this.cmbPerson.DropDownDisplayMember = "Name";
            this.cmbPerson.DropDownValueMember = "id";
            this.cmbPerson.Location = new System.Drawing.Point(38, 17);
            this.cmbPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.SaveSettings = false;
            this.cmbPerson.Size = new System.Drawing.Size(295, 28);
            this.cmbPerson.TabIndex = 112;
            this.cmbPerson.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.cmbPerson.ValuesDataMember = null;
            //this.cmbPerson.CheckedValuesChanged += new System.EventHandler(this.cmbPerson_CheckedValuesChanged);
            this.cmbPerson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerson_KeyDown);
            // 
            // frmCustomerToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 457);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmCustomerToGroup";
            this.Text = "اختصاص اشخاص به گروه";
            this.Load += new System.EventHandler(this.frmCustomerToGroup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCustomerToGroup_KeyDown);
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
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        public DevComponents.DotNetBar.ButtonX btnAddPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        public DevComponents.DotNetBar.ButtonX btnAddGroup;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox cmbGroup;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox cmbPerson;
    }
}