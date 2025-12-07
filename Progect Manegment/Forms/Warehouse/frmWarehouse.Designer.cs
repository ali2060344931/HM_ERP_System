namespace HM_ERP_System.Forms.Warehouse
{
    partial class frmWarehouse
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
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            Janus.Windows.GridEX.GridEXLayout cmbWarehouseType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.btnAddNewItem = new DevComponents.DotNetBar.ButtonX();
            this.cmbWarehouseType = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCapacity = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtAddres = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtPostalCode = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbWarehouseType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(814, 338);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(814, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 388);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(814, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.txtPostalCode);
            this.pnlAddItemBodi.Controls.Add(this.txtAddres);
            this.pnlAddItemBodi.Controls.Add(this.txtCapacity);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewItem);
            this.pnlAddItemBodi.Controls.Add(this.cmbWarehouseType);
            this.pnlAddItemBodi.Controls.Add(this.txtName);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(312, 388);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 388);
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
            this.txtDateStart.Location = new System.Drawing.Point(436, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 12, 7, 9, 33, 29, 559);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(234, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 12, 7, 9, 33, 29, 559);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(144, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(364, 17);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(566, 17);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(816, 444);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(819, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(318, 444);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(780, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(746, 0);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(711, 0);
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
            this.dgvList.SettingsKey = "frmProvinces";
            this.dgvList.Size = new System.Drawing.Size(814, 338);
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
            // btnAddNewItem
            // 
            this.btnAddNewItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewItem.Location = new System.Drawing.Point(14, 15);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewItem.Size = new System.Drawing.Size(18, 28);
            this.btnAddNewItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewItem.Symbol = "";
            this.btnAddNewItem.SymbolSize = 12F;
            this.btnAddNewItem.TabIndex = 112;
            this.btnAddNewItem.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // cmbWarehouseType
            // 
            this.cmbWarehouseType.DataMember = "id";
            cmbWarehouseType_DesignTimeLayout.LayoutString = resources.GetString("cmbWarehouseType_DesignTimeLayout.LayoutString");
            this.cmbWarehouseType.DesignTimeLayout = cmbWarehouseType_DesignTimeLayout;
            this.cmbWarehouseType.DisplayMember = "Name";
            this.cmbWarehouseType.Image = ((System.Drawing.Image)(resources.GetObject("cmbWarehouseType.Image")));
            this.cmbWarehouseType.Location = new System.Drawing.Point(35, 15);
            this.cmbWarehouseType.Name = "cmbWarehouseType";
            this.cmbWarehouseType.SelectedIndex = -1;
            this.cmbWarehouseType.SelectedItem = null;
            this.cmbWarehouseType.Size = new System.Drawing.Size(183, 30);
            this.cmbWarehouseType.TabIndex = 0;
            this.cmbWarehouseType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbWarehouseType.ValueMember = "id";
            this.cmbWarehouseType.ValueChanged += new System.EventHandler(this.cmbWarehouseType_ValueChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(35, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 28);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(217, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 113;
            this.label1.Text = "نام انبار:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(217, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 18);
            this.label14.TabIndex = 114;
            this.label14.Text = "نوع انبار:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(217, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 113;
            this.label2.Text = "ظرفیت:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(217, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 113;
            this.label3.Text = "آدرس:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(217, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 113;
            this.label4.Text = "کدپستی:";
            // 
            // txtCapacity
            // 
            this.txtCapacity.CheackCodeMeli = false;
            this.txtCapacity.Day = 0;
            this.txtCapacity.Location = new System.Drawing.Point(118, 87);
            this.txtCapacity.Miladi = new System.DateTime(((long)(0)));
            this.txtCapacity.Month = 0;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.NowDateSelected = false;
            this.txtCapacity.Number = null;
            this.txtCapacity.SelectedDate = null;
            this.txtCapacity.Shamsi = null;
            this.txtCapacity.Size = new System.Drawing.Size(100, 28);
            this.txtCapacity.TabIndex = 2;
            this.txtCapacity.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtCapacity.TextDigitGroup = false;
            this.txtCapacity.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtCapacity.TextSimple = "";
            this.txtCapacity.TextWatermark = null;
            this.txtCapacity.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtCapacity.Year = 0;
            // 
            // txtAddres
            // 
            this.txtAddres.CheackCodeMeli = false;
            this.txtAddres.Day = 0;
            this.txtAddres.Location = new System.Drawing.Point(14, 155);
            this.txtAddres.Miladi = new System.DateTime(((long)(0)));
            this.txtAddres.Month = 0;
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.NowDateSelected = false;
            this.txtAddres.Number = null;
            this.txtAddres.SelectedDate = null;
            this.txtAddres.Shamsi = null;
            this.txtAddres.Size = new System.Drawing.Size(204, 28);
            this.txtAddres.TabIndex = 4;
            this.txtAddres.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtAddres.TextSimple = "";
            this.txtAddres.TextWatermark = null;
            this.txtAddres.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtAddres.Year = 0;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.CheackCodeMeli = false;
            this.txtPostalCode.Day = 0;
            this.txtPostalCode.Location = new System.Drawing.Point(118, 121);
            this.txtPostalCode.MaxLength = 10;
            this.txtPostalCode.Miladi = new System.DateTime(((long)(0)));
            this.txtPostalCode.Month = 0;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.NowDateSelected = false;
            this.txtPostalCode.Number = null;
            this.txtPostalCode.SelectedDate = null;
            this.txtPostalCode.Shamsi = null;
            this.txtPostalCode.Size = new System.Drawing.Size(100, 28);
            this.txtPostalCode.TabIndex = 3;
            this.txtPostalCode.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtPostalCode.TextDigitGroup = false;
            this.txtPostalCode.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtPostalCode.TextSimple = "";
            this.txtPostalCode.TextWatermark = null;
            this.txtPostalCode.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtPostalCode.Year = 0;
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Name = "frmWarehouse";
            this.Text = "انبــــارها";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbWarehouseType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        public DevComponents.DotNetBar.ButtonX btnAddNewItem;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbWarehouseType;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private Class_General.MyTextBoxJanus txtPostalCode;
        private Class_General.MyTextBoxJanus txtAddres;
        private Class_General.MyTextBoxJanus txtCapacity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}