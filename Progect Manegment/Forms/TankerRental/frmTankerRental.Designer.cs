namespace HM_ERP_System.Forms.TankerRental
{
    partial class frmTankerRental
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
            Janus.Windows.GridEX.GridEXLayout cmbCarplate_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbWarantyType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTankerRental));
            this.label1 = new System.Windows.Forms.Label();
            this.txtContactNo = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCarplate = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddCare = new DevComponents.DotNetBar.ButtonX();
            this.txtDateS = new Atf.UI.DateTimeSelector();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDateE = new Atf.UI.DateTimeSelector();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbWarantyType = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkContractStatus = new Janus.Windows.EditControls.UICheckBox();
            this.txtDes = new Janus.Windows.GridEX.EditControls.EditBox();
            this.dgvList = new GridExEx.GridExEx();
            this.lblCarPlatH = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.cmsdgv = new Janus.Windows.Ribbon.RibbonContextMenu(this.components);
            this.dropDownCommand1 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand2 = new Janus.Windows.Ribbon.DropDownCommand();
            this.separatorCommand1 = new Janus.Windows.Ribbon.SeparatorCommand();
            this.dropDownCommand3 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand4 = new Janus.Windows.Ribbon.DropDownCommand();
            this.dropDownCommand5 = new Janus.Windows.Ribbon.DropDownCommand();
            this.btnRegGroupDoc = new DevComponents.DotNetBar.ButtonX();
            this.cmbMont = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYear = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtRentAmount = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtTankerNo = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.txtSecurityDeposit = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCarplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbWarantyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Location = new System.Drawing.Point(0, 33);
            this.pnlViewItemBody.Size = new System.Drawing.Size(703, 471);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Controls.Add(this.buttonX1);
            this.pnlViewItemHeder.Size = new System.Drawing.Size(703, 33);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.labelX2, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.labelX1, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.txtDateStart, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.btnShowListItems, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.txtDateEnd, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.buttonX1, 0);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Controls.Add(this.txtYear);
            this.pnlViewItemFoter.Controls.Add(this.cmbMont);
            this.pnlViewItemFoter.Controls.Add(this.label12);
            this.pnlViewItemFoter.Controls.Add(this.label11);
            this.pnlViewItemFoter.Controls.Add(this.btnRegGroupDoc);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(703, 28);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnShowGridExHideColumns, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.buttonX01, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnExportToExcel, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnRegGroupDoc, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.label11, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.label12, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.cmbMont, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.txtYear, 0);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.lblCarPlatH);
            this.pnlAddItemBodi.Controls.Add(this.txtRentAmount);
            this.pnlAddItemBodi.Controls.Add(this.txtTankerNo);
            this.pnlAddItemBodi.Controls.Add(this.txtSecurityDeposit);
            this.pnlAddItemBodi.Controls.Add(this.label9);
            this.pnlAddItemBodi.Controls.Add(this.label8);
            this.pnlAddItemBodi.Controls.Add(this.chkContractStatus);
            this.pnlAddItemBodi.Controls.Add(this.txtDes);
            this.pnlAddItemBodi.Controls.Add(this.label7);
            this.pnlAddItemBodi.Controls.Add(this.label6);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.cmbWarantyType);
            this.pnlAddItemBodi.Controls.Add(this.txtDateE);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.txtDateS);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.btnAddCare);
            this.pnlAddItemBodi.Controls.Add(this.cmbCarplate);
            this.pnlAddItemBodi.Controls.Add(this.label13);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.txtContactNo);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(409, 504);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Size = new System.Drawing.Size(409, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(334, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(310, 6);
            this.txtDateStart.Value = new System.DateTime(2025, 8, 28, 7, 18, 6, 414);
            this.txtDateStart.Visible = false;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(96, 6);
            this.txtDateEnd.Value = new System.DateTime(2025, 8, 28, 7, 18, 6, 418);
            this.txtDateEnd.Visible = false;
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(18, 9);
            this.btnShowListItems.Visible = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(238, 11);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Visible = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(440, 11);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            this.labelX1.Visible = false;
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(705, 560);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(708, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(415, 560);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(597, 0);
            this.btnExportToExcel.Size = new System.Drawing.Size(37, 28);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(634, 0);
            this.buttonX01.Click += new System.EventHandler(this.buttonX01_Click);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(668, 0);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(293, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 114;
            this.label1.Text = "شماره قرارداد:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtContactNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContactNo.Location = new System.Drawing.Point(144, 14);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(145, 28);
            this.txtContactNo.TabIndex = 0;
            this.txtContactNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtContactNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactNo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(293, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 114;
            this.label4.Text = "شماره تانکر:";
            // 
            // cmbCarplate
            // 
            this.cmbCarplate.DataMember = "id";
            cmbCarplate_DesignTimeLayout.LayoutString = resources.GetString("cmbCarplate_DesignTimeLayout.LayoutString");
            this.cmbCarplate.DesignTimeLayout = cmbCarplate_DesignTimeLayout;
            this.cmbCarplate.DisplayMember = "CarPlat";
            this.cmbCarplate.Image = ((System.Drawing.Image)(resources.GetObject("cmbCarplate.Image")));
            this.cmbCarplate.Location = new System.Drawing.Point(144, 80);
            this.cmbCarplate.MaxLength = 8;
            this.cmbCarplate.Name = "cmbCarplate";
            this.cmbCarplate.SelectedIndex = -1;
            this.cmbCarplate.SelectedItem = null;
            this.cmbCarplate.Size = new System.Drawing.Size(145, 30);
            this.cmbCarplate.TabIndex = 2;
            this.cmbCarplate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCarplate.ValueMember = "id";
            this.cmbCarplate.ValueChanged += new System.EventHandler(this.cmbCarplateH_ValueChanged);
            this.cmbCarplate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCarplate_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(293, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 18);
            this.label13.TabIndex = 116;
            this.label13.Text = "شماره پلاک:";
            // 
            // btnAddCare
            // 
            this.btnAddCare.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCare.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCare.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCare.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddCare.Location = new System.Drawing.Point(125, 81);
            this.btnAddCare.Name = "btnAddCare";
            this.btnAddCare.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddCare.Size = new System.Drawing.Size(18, 28);
            this.btnAddCare.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCare.Symbol = "";
            this.btnAddCare.SymbolSize = 15F;
            this.btnAddCare.TabIndex = 117;
            this.btnAddCare.TabStop = false;
            this.btnAddCare.Tooltip = "ثبت خودرو";
            this.btnAddCare.Click += new System.EventHandler(this.btnAddCare_Click);
            // 
            // txtDateS
            // 
            this.txtDateS.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateS.Location = new System.Drawing.Point(144, 136);
            this.txtDateS.Name = "txtDateS";
            this.txtDateS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateS.Size = new System.Drawing.Size(145, 29);
            this.txtDateS.TabIndex = 3;
            this.txtDateS.UsePersianFormat = true;
            this.txtDateS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactNo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(293, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 119;
            this.label2.Text = "تاریخ شروع قرارداد:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(293, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 119;
            this.label3.Text = "تاریخ پایان قرارداد:";
            // 
            // txtDateE
            // 
            this.txtDateE.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateE.Location = new System.Drawing.Point(144, 171);
            this.txtDateE.Name = "txtDateE";
            this.txtDateE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateE.Size = new System.Drawing.Size(145, 29);
            this.txtDateE.TabIndex = 4;
            this.txtDateE.UsePersianFormat = true;
            this.txtDateE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactNo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(293, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 121;
            this.label5.Text = "نوع ضمانت:";
            // 
            // cmbWarantyType
            // 
            this.cmbWarantyType.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbWarantyType.DataMember = "id";
            cmbWarantyType_DesignTimeLayout.LayoutString = resources.GetString("cmbWarantyType_DesignTimeLayout.LayoutString");
            this.cmbWarantyType.DesignTimeLayout = cmbWarantyType_DesignTimeLayout;
            this.cmbWarantyType.DisplayMember = "Name";
            this.cmbWarantyType.Location = new System.Drawing.Point(144, 206);
            this.cmbWarantyType.Name = "cmbWarantyType";
            this.cmbWarantyType.SelectedIndex = -1;
            this.cmbWarantyType.SelectedItem = null;
            this.cmbWarantyType.Size = new System.Drawing.Size(145, 28);
            this.cmbWarantyType.TabIndex = 5;
            this.cmbWarantyType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbWarantyType.ValueMember = "id";
            this.cmbWarantyType.ValueChanged += new System.EventHandler(this.cmbWarantyType_ValueChanged);
            this.cmbWarantyType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactNo_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(293, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 121;
            this.label6.Text = "مبلغ ضمانت:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(293, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 121;
            this.label7.Text = "مبلغ اجاره:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(293, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 124;
            this.label9.Text = "توضیحات:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(293, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 125;
            this.label8.Text = "وضعیت قرارداد:";
            // 
            // chkContractStatus
            // 
            this.chkContractStatus.Checked = true;
            this.chkContractStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkContractStatus.Location = new System.Drawing.Point(240, 365);
            this.chkContractStatus.Name = "chkContractStatus";
            this.chkContractStatus.Size = new System.Drawing.Size(49, 25);
            this.chkContractStatus.TabIndex = 9;
            this.chkContractStatus.Text = "فعال";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(23, 308);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(266, 55);
            this.txtDes.TabIndex = 8;
            this.txtDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactNo_KeyDown);
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
            this.dgvList.RowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.dgvList.RowHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.SaveSettings = true;
            this.dgvList.SettingsKey = "frmTankerRental";
            this.dgvList.Size = new System.Drawing.Size(703, 471);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 87;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.dgvList_FormattingRow);
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // lblCarPlatH
            // 
            this.lblCarPlatH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCarPlatH.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCarPlatH.Location = new System.Drawing.Point(144, 113);
            this.lblCarPlatH.Name = "lblCarPlatH";
            this.lblCarPlatH.Size = new System.Drawing.Size(145, 20);
            this.lblCarPlatH.TabIndex = 126;
            this.lblCarPlatH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(556, 0);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Size = new System.Drawing.Size(130, 35);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 117;
            this.buttonX1.TabStop = false;
            this.buttonX1.Text = "بروز رسانی لیست";
            this.buttonX1.Tooltip = "ثبت خودرو";
            // 
            // cmsdgv
            // 
            this.cmsdgv.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.dropDownCommand1,
            this.dropDownCommand2,
            this.separatorCommand1,
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
            // dropDownCommand3
            // 
            this.dropDownCommand3.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.dropDownCommand4,
            this.dropDownCommand5});
            this.dropDownCommand3.Key = "dropDownCommand3";
            this.dropDownCommand3.Name = "dropDownCommand3";
            this.dropDownCommand3.Text = "ثبت مدارک";
            // 
            // dropDownCommand4
            // 
            this.dropDownCommand4.Key = "AddDocumentToBanck";
            this.dropDownCommand4.Name = "dropDownCommand4";
            this.dropDownCommand4.Text = "مدارک پیوستی";
            // 
            // dropDownCommand5
            // 
            this.dropDownCommand5.Key = "DocWaranty";
            this.dropDownCommand5.Name = "dropDownCommand5";
            this.dropDownCommand5.Text = "مدارک ضمانتی";
            // 
            // btnRegGroupDoc
            // 
            this.btnRegGroupDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegGroupDoc.BackColor = System.Drawing.Color.Transparent;
            this.btnRegGroupDoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegGroupDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegGroupDoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnRegGroupDoc.Location = new System.Drawing.Point(0, 0);
            this.btnRegGroupDoc.Name = "btnRegGroupDoc";
            this.btnRegGroupDoc.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnRegGroupDoc.Size = new System.Drawing.Size(168, 28);
            this.btnRegGroupDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegGroupDoc.Symbol = "";
            this.btnRegGroupDoc.SymbolSize = 15F;
            this.btnRegGroupDoc.TabIndex = 118;
            this.btnRegGroupDoc.TabStop = false;
            this.btnRegGroupDoc.Text = "ثبت گروهی دریافت اجاره";
            this.btnRegGroupDoc.Click += new System.EventHandler(this.btnRegGroupDoc_Click);
            // 
            // cmbMont
            // 
            this.cmbMont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbMont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMont.FormattingEnabled = true;
            this.cmbMont.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.cmbMont.Location = new System.Drawing.Point(168, 0);
            this.cmbMont.Name = "cmbMont";
            this.cmbMont.Size = new System.Drawing.Size(107, 28);
            this.cmbMont.TabIndex = 129;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(371, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 18);
            this.label11.TabIndex = 128;
            this.label11.Text = "سال:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(275, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 18);
            this.label12.TabIndex = 128;
            this.label12.Text = "ماه:";
            // 
            // txtYear
            // 
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtYear.CheackCodeMeli = false;
            this.txtYear.Day = 0;
            this.txtYear.Location = new System.Drawing.Point(302, 0);
            this.txtYear.Miladi = new System.DateTime(((long)(0)));
            this.txtYear.Month = 0;
            this.txtYear.Name = "txtYear";
            this.txtYear.NowDateSelected = false;
            this.txtYear.Number = null;
            this.txtYear.SelectedDate = null;
            this.txtYear.Shamsi = null;
            this.txtYear.Size = new System.Drawing.Size(69, 28);
            this.txtYear.TabIndex = 130;
            this.txtYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtYear.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtYear.TextDigitGroup = false;
            this.txtYear.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtYear.TextSimple = "";
            this.txtYear.TextWatermark = null;
            this.txtYear.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtYear.Year = 0;
            // 
            // txtRentAmount
            // 
            this.txtRentAmount.CheackCodeMeli = false;
            this.txtRentAmount.Day = 0;
            this.txtRentAmount.Location = new System.Drawing.Point(144, 274);
            this.txtRentAmount.Miladi = new System.DateTime(((long)(0)));
            this.txtRentAmount.Month = 0;
            this.txtRentAmount.Name = "txtRentAmount";
            this.txtRentAmount.NowDateSelected = false;
            this.txtRentAmount.Number = null;
            this.txtRentAmount.SelectedDate = null;
            this.txtRentAmount.Shamsi = null;
            this.txtRentAmount.Size = new System.Drawing.Size(145, 28);
            this.txtRentAmount.TabIndex = 7;
            this.txtRentAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtRentAmount.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtRentAmount.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtRentAmount.TextSimple = "";
            this.txtRentAmount.TextWatermark = null;
            this.txtRentAmount.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtRentAmount.Year = 0;
            this.txtRentAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactNo_KeyDown);
            // 
            // txtTankerNo
            // 
            this.txtTankerNo.CheackCodeMeli = false;
            this.txtTankerNo.Day = 0;
            this.txtTankerNo.Location = new System.Drawing.Point(144, 48);
            this.txtTankerNo.Miladi = new System.DateTime(((long)(0)));
            this.txtTankerNo.Month = 0;
            this.txtTankerNo.Name = "txtTankerNo";
            this.txtTankerNo.NowDateSelected = false;
            this.txtTankerNo.Number = null;
            this.txtTankerNo.SelectedDate = null;
            this.txtTankerNo.Shamsi = null;
            this.txtTankerNo.Size = new System.Drawing.Size(145, 28);
            this.txtTankerNo.TabIndex = 1;
            this.txtTankerNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtTankerNo.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtTankerNo.TextDigitGroup = false;
            this.txtTankerNo.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtTankerNo.TextSimple = "";
            this.txtTankerNo.TextWatermark = null;
            this.txtTankerNo.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtTankerNo.Year = 0;
            this.txtTankerNo.TextChanged += new System.EventHandler(this.txtSecurityDeposit_TextChanged);
            this.txtTankerNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactNo_KeyDown);
            // 
            // txtSecurityDeposit
            // 
            this.txtSecurityDeposit.CheackCodeMeli = false;
            this.txtSecurityDeposit.Day = 0;
            this.txtSecurityDeposit.Location = new System.Drawing.Point(144, 240);
            this.txtSecurityDeposit.Miladi = new System.DateTime(((long)(0)));
            this.txtSecurityDeposit.Month = 0;
            this.txtSecurityDeposit.Name = "txtSecurityDeposit";
            this.txtSecurityDeposit.NowDateSelected = false;
            this.txtSecurityDeposit.Number = null;
            this.txtSecurityDeposit.SelectedDate = null;
            this.txtSecurityDeposit.Shamsi = null;
            this.txtSecurityDeposit.Size = new System.Drawing.Size(145, 28);
            this.txtSecurityDeposit.TabIndex = 6;
            this.txtSecurityDeposit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtSecurityDeposit.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtSecurityDeposit.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtSecurityDeposit.TextSimple = "";
            this.txtSecurityDeposit.TextWatermark = null;
            this.txtSecurityDeposit.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtSecurityDeposit.Year = 0;
            this.txtSecurityDeposit.TextChanged += new System.EventHandler(this.txtSecurityDeposit_TextChanged);
            this.txtSecurityDeposit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactNo_KeyDown);
            // 
            // frmTankerRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 566);
            this.KeyPreview = true;
            this.Name = "frmTankerRental";
            this.Text = "اجاره تانکرها";
            this.Load += new System.EventHandler(this.frmTankerRental_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTankerRental_KeyDown);
            this.Controls.SetChildIndex(this.pnlAddItems, 0);
            this.Controls.SetChildIndex(this.pnlViewItems, 0);
            this.pnlViewItemBody.ResumeLayout(false);
            this.pnlViewItemHeder.ResumeLayout(false);
            this.pnlViewItemHeder.PerformLayout();
            this.pnlViewItemFoter.ResumeLayout(false);
            this.pnlViewItemFoter.PerformLayout();
            this.pnlAddItemBodi.ResumeLayout(false);
            this.pnlAddItemBodi.PerformLayout();
            this.pnlAddItemFoter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCarplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbWarantyType)).EndInit();
            ((System.Configuration.IPersistComponentSettings)(this.dgvList)).LoadComponentSettings();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.EditBox txtContactNo;
        public Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCarplate;
        private System.Windows.Forms.Label label13;
        public DevComponents.DotNetBar.ButtonX btnAddCare;
        public Atf.UI.DateTimeSelector txtDateE;
        private System.Windows.Forms.Label label3;
        public Atf.UI.DateTimeSelector txtDateS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbWarantyType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.EditControls.UICheckBox chkContractStatus;
        private Janus.Windows.GridEX.EditControls.EditBox txtDes;
        private Class_General.MyTextBoxJanus txtRentAmount;
        private Class_General.MyTextBoxJanus txtSecurityDeposit;
        public GridExEx.GridExEx dgvList;
        private System.Windows.Forms.Label lblCarPlatH;
        /// <summary>
        /// شماره تانکر
        /// </summary>
        private Class_General.MyTextBoxJanus txtTankerNo;
        public DevComponents.DotNetBar.ButtonX buttonX1;
        private Janus.Windows.Ribbon.RibbonContextMenu cmsdgv;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand2;
        private Janus.Windows.Ribbon.SeparatorCommand separatorCommand1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand3;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand4;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand5;
        public DevComponents.DotNetBar.ButtonX btnRegGroupDoc;
        private System.Windows.Forms.ComboBox cmbMont;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Class_General.MyTextBoxJanus txtYear;
    }
}