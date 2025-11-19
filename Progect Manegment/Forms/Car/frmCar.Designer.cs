namespace HM_ERP_System.Forms.Car
{
    partial class frmCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCar));
            Janus.Windows.GridEX.GridEXLayout cmbDraverName_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbOwnership_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbTruckUsageType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbGoodsAccount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCompanys_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.chkStatus = new Janus.Windows.EditControls.UICheckBox();
            this.txtDes = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtCreatModel = new Janus.Windows.GridEX.EditControls.IntegerUpDown();
            this.cmbDraverName = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnAddDravers = new DevComponents.DotNetBar.ButtonX();
            this.txtAxisCount = new Janus.Windows.GridEX.EditControls.IntegerUpDown();
            this.txtCarName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.cmbOwnership = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCarplateSeryal = new DevComponents.Editors.IntegerInput();
            this.txtCarplate = new DevComponents.Editors.IntegerInput();
            this.txtSeryal = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTruckUsageType = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTruckCapacity = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLoadWeightCapacity = new Janus.Windows.GridEX.EditControls.EditBox();
            this.cmbGoodsAccount = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbCompanys = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddCompanys = new DevComponents.DotNetBar.ButtonX();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraverName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOwnership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplateSeryal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTruckUsageType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGoodsAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompanys)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(585, 444);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(585, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 494);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(585, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.cmbCompanys);
            this.pnlAddItemBodi.Controls.Add(this.cmbGoodsAccount);
            this.pnlAddItemBodi.Controls.Add(this.txtLoadWeightCapacity);
            this.pnlAddItemBodi.Controls.Add(this.txtTruckCapacity);
            this.pnlAddItemBodi.Controls.Add(this.txtSeryal);
            this.pnlAddItemBodi.Controls.Add(this.label16);
            this.pnlAddItemBodi.Controls.Add(this.label15);
            this.pnlAddItemBodi.Controls.Add(this.txtCarplateSeryal);
            this.pnlAddItemBodi.Controls.Add(this.txtCarplate);
            this.pnlAddItemBodi.Controls.Add(this.label9);
            this.pnlAddItemBodi.Controls.Add(this.label8);
            this.pnlAddItemBodi.Controls.Add(this.label7);
            this.pnlAddItemBodi.Controls.Add(this.label13);
            this.pnlAddItemBodi.Controls.Add(this.label6);
            this.pnlAddItemBodi.Controls.Add(this.label12);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label11);
            this.pnlAddItemBodi.Controls.Add(this.label10);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.txtCarName);
            this.pnlAddItemBodi.Controls.Add(this.txtAxisCount);
            this.pnlAddItemBodi.Controls.Add(this.txtCreatModel);
            this.pnlAddItemBodi.Controls.Add(this.btnAddCompanys);
            this.pnlAddItemBodi.Controls.Add(this.buttonX2);
            this.pnlAddItemBodi.Controls.Add(this.btnAddDravers);
            this.pnlAddItemBodi.Controls.Add(this.chkStatus);
            this.pnlAddItemBodi.Controls.Add(this.cmbOwnership);
            this.pnlAddItemBodi.Controls.Add(this.cmbTruckUsageType);
            this.pnlAddItemBodi.Controls.Add(this.cmbDraverName);
            this.pnlAddItemBodi.Controls.Add(this.txtDes);
            this.pnlAddItemBodi.Controls.Add(this.label17);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(430, 494);
            this.pnlAddItemBodi.TabIndex = 0;
            this.pnlAddItemBodi.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddItemBodi_Paint);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 494);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(430, 28);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(355, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(321, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 6, 21, 8, 39, 40, 911);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(119, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 6, 21, 8, 39, 40, 911);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(29, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(249, 17);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(451, 17);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(587, 550);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(590, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(436, 550);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(551, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(517, 0);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(482, 0);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.FrozenColumns = 5;
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
            this.dgvList.SettingsKey = "frmCar";
            this.dgvList.Size = new System.Drawing.Size(585, 444);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 86;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // chkStatus
            // 
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(248, 442);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(49, 25);
            this.chkStatus.TabIndex = 13;
            this.chkStatus.Text = "فعال";
            this.chkStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarName_KeyDown);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(21, 391);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(276, 50);
            this.txtDes.TabIndex = 12;
            this.txtDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            // 
            // txtCreatModel
            // 
            this.txtCreatModel.Location = new System.Drawing.Point(231, 322);
            this.txtCreatModel.Maximum = 3000;
            this.txtCreatModel.MaxLength = 4;
            this.txtCreatModel.Minimum = 1000;
            this.txtCreatModel.Name = "txtCreatModel";
            this.txtCreatModel.Size = new System.Drawing.Size(66, 28);
            this.txtCreatModel.TabIndex = 10;
            this.txtCreatModel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtCreatModel.UseCompatibleTextRendering = false;
            this.txtCreatModel.Value = 1000;
            this.txtCreatModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarName_KeyDown);
            // 
            // cmbDraverName
            // 
            this.cmbDraverName.DataMember = "id";
            cmbDraverName_DesignTimeLayout.LayoutString = resources.GetString("cmbDraverName_DesignTimeLayout.LayoutString");
            this.cmbDraverName.DesignTimeLayout = cmbDraverName_DesignTimeLayout;
            this.cmbDraverName.DisplayMember = "Name";
            this.cmbDraverName.Image = ((System.Drawing.Image)(resources.GetObject("cmbDraverName.Image")));
            this.cmbDraverName.Location = new System.Drawing.Point(52, 83);
            this.cmbDraverName.Name = "cmbDraverName";
            this.cmbDraverName.SelectedIndex = -1;
            this.cmbDraverName.SelectedItem = null;
            this.cmbDraverName.Size = new System.Drawing.Size(245, 30);
            this.cmbDraverName.TabIndex = 3;
            this.cmbDraverName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbDraverName.ValueMember = "id";
            this.cmbDraverName.ValueChanged += new System.EventHandler(this.cmbDraverName_ValueChanged);
            this.cmbDraverName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDraverName_KeyDown);
            // 
            // btnAddDravers
            // 
            this.btnAddDravers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddDravers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddDravers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddDravers.Location = new System.Drawing.Point(31, 83);
            this.btnAddDravers.Name = "btnAddDravers";
            this.btnAddDravers.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddDravers.Size = new System.Drawing.Size(18, 28);
            this.btnAddDravers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddDravers.Symbol = "";
            this.btnAddDravers.SymbolSize = 12F;
            this.btnAddDravers.TabIndex = 42;
            this.btnAddDravers.Tooltip = "ثبت آیتم جدید";
            this.btnAddDravers.Click += new System.EventHandler(this.btnAddDravers_Click);
            // 
            // txtAxisCount
            // 
            this.txtAxisCount.Location = new System.Drawing.Point(231, 357);
            this.txtAxisCount.Maximum = 3;
            this.txtAxisCount.MaxLength = 1;
            this.txtAxisCount.Minimum = 1;
            this.txtAxisCount.Name = "txtAxisCount";
            this.txtAxisCount.Size = new System.Drawing.Size(66, 28);
            this.txtAxisCount.TabIndex = 11;
            this.txtAxisCount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtAxisCount.Value = 1;
            this.txtAxisCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarName_KeyDown);
            // 
            // txtCarName
            // 
            this.txtCarName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCarName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCarName.Location = new System.Drawing.Point(161, 16);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(136, 28);
            this.txtCarName.TabIndex = 0;
            this.txtCarName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtCarName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarName_KeyDown);
            // 
            // cmbOwnership
            // 
            this.cmbOwnership.DataMember = "id";
            cmbOwnership_DesignTimeLayout.LayoutString = resources.GetString("cmbOwnership_DesignTimeLayout.LayoutString");
            this.cmbOwnership.DesignTimeLayout = cmbOwnership_DesignTimeLayout;
            this.cmbOwnership.DisplayMember = "Name";
            this.cmbOwnership.Location = new System.Drawing.Point(182, 185);
            this.cmbOwnership.Name = "cmbOwnership";
            this.cmbOwnership.SelectedIndex = -1;
            this.cmbOwnership.SelectedItem = null;
            this.cmbOwnership.Size = new System.Drawing.Size(115, 28);
            this.cmbOwnership.TabIndex = 6;
            this.cmbOwnership.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbOwnership.ValueMember = "id";
            this.cmbOwnership.ValueChanged += new System.EventHandler(this.cmbOwnership_ValueChanged);
            this.cmbOwnership.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(303, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "نام(عنوان) خودرو:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(302, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 98;
            this.label2.Text = "پلاک خودرو:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(302, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 98;
            this.label3.Text = "راننده:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(302, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 98;
            this.label4.Text = "سریال هوشمند:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(302, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 98;
            this.label5.Text = "مدل ساخت:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(302, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 98;
            this.label6.Text = "تعداد محور:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(302, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 98;
            this.label7.Text = "وضعیت مالکیت:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(302, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 98;
            this.label8.Text = "وضعیت:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(302, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 98;
            this.label9.Text = "توضیحات:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(122, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 18);
            this.label16.TabIndex = 102;
            this.label16.Text = "ایران";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(153, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 18);
            this.label15.TabIndex = 103;
            this.label15.Text = "سریال پلاک:";
            // 
            // txtCarplateSeryal
            // 
            // 
            // 
            // 
            this.txtCarplateSeryal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtCarplateSeryal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCarplateSeryal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCarplateSeryal.FocusHighlightColor = System.Drawing.SystemColors.Control;
            this.txtCarplateSeryal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCarplateSeryal.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtCarplateSeryal.Location = new System.Drawing.Point(92, 52);
            this.txtCarplateSeryal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCarplateSeryal.MaxValue = 99;
            this.txtCarplateSeryal.MinValue = 0;
            this.txtCarplateSeryal.Name = "txtCarplateSeryal";
            this.txtCarplateSeryal.Size = new System.Drawing.Size(30, 23);
            this.txtCarplateSeryal.TabIndex = 2;
            this.txtCarplateSeryal.ValueChanged += new System.EventHandler(this.txtCarplate2_ValueChanged);
            // 
            // txtCarplate
            // 
            // 
            // 
            // 
            this.txtCarplate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCarplate.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCarplate.FocusHighlightColor = System.Drawing.SystemColors.Control;
            this.txtCarplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCarplate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtCarplate.Location = new System.Drawing.Point(229, 52);
            this.txtCarplate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCarplate.MaxValue = 99999;
            this.txtCarplate.MinValue = 0;
            this.txtCarplate.Name = "txtCarplate";
            this.txtCarplate.Size = new System.Drawing.Size(68, 23);
            this.txtCarplate.TabIndex = 1;
            this.txtCarplate.ValueChanged += new System.EventHandler(this.txtCarplate1_ValueChanged);
            // 
            // txtSeryal
            // 
            this.txtSeryal.Location = new System.Drawing.Point(183, 220);
            this.txtSeryal.MaxLength = 7;
            this.txtSeryal.Name = "txtSeryal";
            this.txtSeryal.Size = new System.Drawing.Size(114, 28);
            this.txtSeryal.TabIndex = 7;
            this.txtSeryal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtSeryal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeryal_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(302, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 18);
            this.label10.TabIndex = 98;
            this.label10.Text = "طرف حساب کامیون:";
            // 
            // cmbTruckUsageType
            // 
            this.cmbTruckUsageType.DataMember = "id";
            cmbTruckUsageType_DesignTimeLayout.LayoutString = resources.GetString("cmbTruckUsageType_DesignTimeLayout.LayoutString");
            this.cmbTruckUsageType.DesignTimeLayout = cmbTruckUsageType_DesignTimeLayout;
            this.cmbTruckUsageType.DisplayMember = "Name";
            this.cmbTruckUsageType.Location = new System.Drawing.Point(183, 151);
            this.cmbTruckUsageType.Name = "cmbTruckUsageType";
            this.cmbTruckUsageType.SelectedIndex = -1;
            this.cmbTruckUsageType.SelectedItem = null;
            this.cmbTruckUsageType.Size = new System.Drawing.Size(114, 28);
            this.cmbTruckUsageType.TabIndex = 5;
            this.cmbTruckUsageType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbTruckUsageType.ValueMember = "id";
            this.cmbTruckUsageType.ValueChanged += new System.EventHandler(this.cmbTruckUsageType_ValueChanged);
            this.cmbTruckUsageType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarName_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(302, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 98;
            this.label11.Text = "نوع کاربری:";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX2.Location = new System.Drawing.Point(31, 117);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX2.Size = new System.Drawing.Size(18, 28);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 12F;
            this.buttonX2.TabIndex = 42;
            this.buttonX2.Tooltip = "ثبت آیتم جدید";
            this.buttonX2.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(302, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 18);
            this.label12.TabIndex = 98;
            this.label12.Text = "ظرفیت مجاز کامیون:";
            // 
            // txtTruckCapacity
            // 
            this.txtTruckCapacity.Location = new System.Drawing.Point(183, 254);
            this.txtTruckCapacity.MaxLength = 5;
            this.txtTruckCapacity.Name = "txtTruckCapacity";
            this.txtTruckCapacity.Size = new System.Drawing.Size(114, 28);
            this.txtTruckCapacity.TabIndex = 8;
            this.txtTruckCapacity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtTruckCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeryal_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(302, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 18);
            this.label13.TabIndex = 98;
            this.label13.Text = "ظرفیت مجازبارگیری:";
            // 
            // txtLoadWeightCapacity
            // 
            this.txtLoadWeightCapacity.Location = new System.Drawing.Point(183, 288);
            this.txtLoadWeightCapacity.MaxLength = 5;
            this.txtLoadWeightCapacity.Name = "txtLoadWeightCapacity";
            this.txtLoadWeightCapacity.Size = new System.Drawing.Size(114, 28);
            this.txtLoadWeightCapacity.TabIndex = 9;
            this.txtLoadWeightCapacity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtLoadWeightCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeryal_KeyPress);
            // 
            // cmbGoodsAccount
            // 
            this.cmbGoodsAccount.DataMember = "id";
            cmbGoodsAccount_DesignTimeLayout.LayoutString = resources.GetString("cmbGoodsAccount_DesignTimeLayout.LayoutString");
            this.cmbGoodsAccount.DesignTimeLayout = cmbGoodsAccount_DesignTimeLayout;
            this.cmbGoodsAccount.DisplayMember = "Name";
            this.cmbGoodsAccount.Image = ((System.Drawing.Image)(resources.GetObject("cmbGoodsAccount.Image")));
            this.cmbGoodsAccount.Location = new System.Drawing.Point(50, 117);
            this.cmbGoodsAccount.Name = "cmbGoodsAccount";
            this.cmbGoodsAccount.SelectedIndex = -1;
            this.cmbGoodsAccount.SelectedItem = null;
            this.cmbGoodsAccount.Size = new System.Drawing.Size(247, 30);
            this.cmbGoodsAccount.TabIndex = 4;
            this.cmbGoodsAccount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbGoodsAccount.ValueMember = "id";
            this.cmbGoodsAccount.ValueChanged += new System.EventHandler(this.cmbGoodsAccount_ValueChanged);
            this.cmbGoodsAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGoodsAccount_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Vazir FD", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(146, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 15);
            this.label14.TabIndex = 105;
            this.label14.Text = "کیلوگرم";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Vazir FD", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.Location = new System.Drawing.Point(146, 293);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 15);
            this.label17.TabIndex = 105;
            this.label17.Text = "کیلوگرم";
            // 
            // cmbCompanys
            // 
            this.cmbCompanys.DataMember = "id";
            cmbCompanys_DesignTimeLayout.LayoutString = resources.GetString("cmbCompanys_DesignTimeLayout.LayoutString");
            this.cmbCompanys.DesignTimeLayout = cmbCompanys_DesignTimeLayout;
            this.cmbCompanys.DisplayMember = "Name";
            this.cmbCompanys.Location = new System.Drawing.Point(50, 185);
            this.cmbCompanys.Name = "cmbCompanys";
            this.cmbCompanys.SelectedIndex = -1;
            this.cmbCompanys.SelectedItem = null;
            this.cmbCompanys.Size = new System.Drawing.Size(129, 28);
            this.cmbCompanys.TabIndex = 104;
            this.cmbCompanys.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.toolTip1.SetToolTip(this.cmbCompanys, "انتخاب نام شرکت");
            this.cmbCompanys.ValueMember = "id";
            this.cmbCompanys.Visible = false;
            this.cmbCompanys.ValueChanged += new System.EventHandler(this.cmbCompanys_ValueChanged);
            // 
            // btnAddCompanys
            // 
            this.btnAddCompanys.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCompanys.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCompanys.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddCompanys.Location = new System.Drawing.Point(31, 185);
            this.btnAddCompanys.Name = "btnAddCompanys";
            this.btnAddCompanys.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddCompanys.Size = new System.Drawing.Size(18, 28);
            this.btnAddCompanys.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCompanys.Symbol = "";
            this.btnAddCompanys.SymbolSize = 12F;
            this.btnAddCompanys.TabIndex = 42;
            this.btnAddCompanys.Tooltip = "ثبت آیتم جدید";
            this.btnAddCompanys.Visible = false;
            this.btnAddCompanys.Click += new System.EventHandler(this.btnAddCompanys_Click);
            // 
            // frmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 556);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmCar";
            this.Text = "فرم ثبت خودروها";
            this.Load += new System.EventHandler(this.frmCar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCar_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraverName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOwnership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplateSeryal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTruckUsageType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGoodsAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompanys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        private Janus.Windows.EditControls.UICheckBox chkStatus;
        private Janus.Windows.GridEX.EditControls.EditBox txtDes;
        private Janus.Windows.GridEX.EditControls.IntegerUpDown txtCreatModel;
        private Janus.Windows.GridEX.EditControls.IntegerUpDown txtAxisCount;
        public DevComponents.DotNetBar.ButtonX btnAddDravers;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbDraverName;
        private Janus.Windows.GridEX.EditControls.EditBox txtCarName;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbOwnership;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        public DevComponents.Editors.IntegerInput txtCarplateSeryal;
        public DevComponents.Editors.IntegerInput txtCarplate;
        private Janus.Windows.GridEX.EditControls.EditBox txtSeryal;
        private Janus.Windows.GridEX.EditControls.EditBox txtLoadWeightCapacity;
        private Janus.Windows.GridEX.EditControls.EditBox txtTruckCapacity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public DevComponents.DotNetBar.ButtonX buttonX2;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbTruckUsageType;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbGoodsAccount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCompanys;
        private System.Windows.Forms.ToolTip toolTip1;
        public DevComponents.DotNetBar.ButtonX btnAddCompanys;
    }
}