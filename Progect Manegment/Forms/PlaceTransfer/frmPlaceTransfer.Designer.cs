namespace HM_ERP_System.Forms.PlaceTransfer
{
    partial class frmPlaceTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaceTransfer));
            Janus.Windows.GridEX.GridEXLayout cmbEvacuationDeployment_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCity1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvListCity_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCity2_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.cmbEvacuationDeployment = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtPlaceTransferName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.cmbCity1 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCity1 = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPublic = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostalCode = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddres = new Janus.Windows.GridEX.EditControls.EditBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListCity = new GridExEx.GridExEx();
            this.cmbCity2 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCityToLIst = new DevComponents.DotNetBar.ButtonX();
            this.btnAddCity2 = new DevComponents.DotNetBar.ButtonX();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvacuationDeployment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlViewItemBody.Size = new System.Drawing.Size(907, 647);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlViewItemHeder.Size = new System.Drawing.Size(907, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 697);
            this.pnlViewItemFoter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(907, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.panel1);
            this.pnlAddItemBodi.Controls.Add(this.txtAddres);
            this.pnlAddItemBodi.Controls.Add(this.txtPostalCode);
            this.pnlAddItemBodi.Controls.Add(this.btnAddCity1);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Controls.Add(this.cmbCity1);
            this.pnlAddItemBodi.Controls.Add(this.cmbEvacuationDeployment);
            this.pnlAddItemBodi.Controls.Add(this.txtPlaceTransferName);
            this.pnlAddItemBodi.Controls.Add(this.chkPublic);
            this.pnlAddItemBodi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(373, 697);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 697);
            this.pnlAddItemFoter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(373, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(298, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(505, 12);
            this.txtDateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDateStart.Value = new System.DateTime(2025, 6, 22, 23, 2, 54, 641);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(303, 12);
            this.txtDateEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDateEnd.Value = new System.DateTime(2025, 6, 22, 23, 2, 54, 641);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(213, 15);
            this.btnShowListItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(433, 17);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(635, 17);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(909, 753);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(912, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(379, 753);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(873, 0);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(839, 0);
            this.buttonX01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonX01.Click += new System.EventHandler(this.buttonX01_Click);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(804, 0);
            this.btnShowGridExHideColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
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
            this.dgvList.SettingsKey = "frmPlaceTransfer";
            this.dgvList.Size = new System.Drawing.Size(907, 647);
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
            // cmbEvacuationDeployment
            // 
            this.cmbEvacuationDeployment.DataMember = "id";
            cmbEvacuationDeployment_DesignTimeLayout.LayoutString = resources.GetString("cmbEvacuationDeployment_DesignTimeLayout.LayoutString");
            this.cmbEvacuationDeployment.DesignTimeLayout = cmbEvacuationDeployment_DesignTimeLayout;
            this.cmbEvacuationDeployment.DisplayMember = "Name";
            this.cmbEvacuationDeployment.Location = new System.Drawing.Point(81, 10);
            this.cmbEvacuationDeployment.Name = "cmbEvacuationDeployment";
            this.cmbEvacuationDeployment.SelectedIndex = -1;
            this.cmbEvacuationDeployment.SelectedItem = null;
            this.cmbEvacuationDeployment.Size = new System.Drawing.Size(183, 28);
            this.cmbEvacuationDeployment.TabIndex = 0;
            this.cmbEvacuationDeployment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbEvacuationDeployment.ValueMember = "id";
            this.cmbEvacuationDeployment.Visible = false;
            this.cmbEvacuationDeployment.ValueChanged += new System.EventHandler(this.cmbEvacuationDeployment_ValueChanged);
            this.cmbEvacuationDeployment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            // 
            // txtPlaceTransferName
            // 
            this.txtPlaceTransferName.Location = new System.Drawing.Point(81, 115);
            this.txtPlaceTransferName.Name = "txtPlaceTransferName";
            this.txtPlaceTransferName.Size = new System.Drawing.Size(183, 28);
            this.txtPlaceTransferName.TabIndex = 3;
            this.txtPlaceTransferName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtPlaceTransferName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            // 
            // cmbCity1
            // 
            this.cmbCity1.DataMember = "id";
            cmbCity1_DesignTimeLayout.LayoutString = resources.GetString("cmbCity1_DesignTimeLayout.LayoutString");
            this.cmbCity1.DesignTimeLayout = cmbCity1_DesignTimeLayout;
            this.cmbCity1.DisplayMember = "Name";
            this.cmbCity1.Image = ((System.Drawing.Image)(resources.GetObject("cmbCity1.Image")));
            this.cmbCity1.Location = new System.Drawing.Point(81, 78);
            this.cmbCity1.Name = "cmbCity1";
            this.cmbCity1.SelectedIndex = -1;
            this.cmbCity1.SelectedItem = null;
            this.cmbCity1.Size = new System.Drawing.Size(183, 30);
            this.cmbCity1.TabIndex = 2;
            this.cmbCity1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCity1.ValueMember = "id";
            this.cmbCity1.ValueChanged += new System.EventHandler(this.cmbCity_ValueChanged);
            this.cmbCity1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCity_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(268, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 18);
            this.label14.TabIndex = 106;
            this.label14.Text = "نوع جابجایی:";
            this.label14.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(268, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 106;
            this.label1.Text = "شهر اصلی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(268, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 106;
            this.label2.Text = "نام انبار:";
            // 
            // btnAddCity1
            // 
            this.btnAddCity1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCity1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCity1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddCity1.Location = new System.Drawing.Point(61, 78);
            this.btnAddCity1.Name = "btnAddCity1";
            this.btnAddCity1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddCity1.Size = new System.Drawing.Size(18, 28);
            this.btnAddCity1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCity1.Symbol = "";
            this.btnAddCity1.SymbolSize = 15F;
            this.btnAddCity1.TabIndex = 107;
            this.btnAddCity1.Tooltip = "ثبت آیتم جدید";
            this.btnAddCity1.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(268, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 106;
            this.label3.Text = "وضعیت:";
            // 
            // chkPublic
            // 
            this.chkPublic.AutoSize = true;
            this.chkPublic.Location = new System.Drawing.Point(156, 252);
            this.chkPublic.Name = "chkPublic";
            this.chkPublic.Size = new System.Drawing.Size(108, 26);
            this.chkPublic.TabIndex = 5;
            this.chkPublic.Text = "عمومی(شناور)";
            this.chkPublic.UseVisualStyleBackColor = true;
            this.chkPublic.CheckedChanged += new System.EventHandler(this.chkPublic_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(268, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 106;
            this.label4.Text = "کد پستی:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.CheackCodeMeli = false;
            this.txtPostalCode.Day = 0;
            this.txtPostalCode.Location = new System.Drawing.Point(138, 44);
            this.txtPostalCode.MaxLength = 10;
            this.txtPostalCode.Miladi = new System.DateTime(((long)(0)));
            this.txtPostalCode.Month = 0;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.NowDateSelected = false;
            this.txtPostalCode.Number = null;
            this.txtPostalCode.SelectedDate = null;
            this.txtPostalCode.Shamsi = null;
            this.txtPostalCode.Size = new System.Drawing.Size(126, 28);
            this.txtPostalCode.TabIndex = 1;
            this.txtPostalCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtPostalCode.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtPostalCode.TextDigitGroup = false;
            this.txtPostalCode.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtPostalCode.TextSimple = "";
            this.txtPostalCode.TextWatermark = null;
            this.txtPostalCode.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtPostalCode.Year = 0;
            this.txtPostalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            this.txtPostalCode.Leave += new System.EventHandler(this.txtPostalCode_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(268, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 106;
            this.label5.Text = "آدرس:";
            // 
            // txtAddres
            // 
            this.txtAddres.Location = new System.Drawing.Point(3, 147);
            this.txtAddres.Multiline = true;
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(261, 102);
            this.txtAddres.TabIndex = 4;
            this.txtAddres.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtAddres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListCity);
            this.panel1.Controls.Add(this.cmbCity2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AddCityToLIst);
            this.panel1.Controls.Add(this.btnAddCity2);
            this.panel1.Location = new System.Drawing.Point(11, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 418);
            this.panel1.TabIndex = 108;
            this.panel1.Visible = false;
            // 
            // dgvListCity
            // 
            this.dgvListCity.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListCity.ColumnAutoResize = true;
            this.dgvListCity.DefaultComment = null;
            this.dgvListCity.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.None;
            this.dgvListCity.FindCondition = null;
            this.dgvListCity.GroupByBoxVisible = false;
            this.dgvListCity.HiddenColumnSortingEnabled = false;
            this.dgvListCity.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvListCity_Layout_0.IsCurrentLayout = true;
            dgvListCity_Layout_0.Key = "MyGrig";
            dgvListCity_Layout_0.LayoutString = resources.GetString("dgvListCity_Layout_0.LayoutString");
            this.dgvListCity.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvListCity_Layout_0});
            this.dgvListCity.Location = new System.Drawing.Point(3, 67);
            this.dgvListCity.Name = "dgvListCity";
            this.dgvListCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListCity.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.dgvListCity.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListCity.SettingsKey = "frmProvinces";
            this.dgvListCity.Size = new System.Drawing.Size(249, 348);
            this.dgvListCity.Sortable = true;
            this.dgvListCity.TabIndex = 108;
            this.dgvListCity.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListCity.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListCity.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // cmbCity2
            // 
            this.cmbCity2.DataMember = "id";
            cmbCity2_DesignTimeLayout.LayoutString = resources.GetString("cmbCity2_DesignTimeLayout.LayoutString");
            this.cmbCity2.DesignTimeLayout = cmbCity2_DesignTimeLayout;
            this.cmbCity2.DisplayMember = "Name";
            this.cmbCity2.Image = ((System.Drawing.Image)(resources.GetObject("cmbCity2.Image")));
            this.cmbCity2.Location = new System.Drawing.Point(69, 32);
            this.cmbCity2.Name = "cmbCity2";
            this.cmbCity2.SelectedIndex = -1;
            this.cmbCity2.SelectedItem = null;
            this.cmbCity2.Size = new System.Drawing.Size(183, 30);
            this.cmbCity2.TabIndex = 2;
            this.cmbCity2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCity2.ValueMember = "id";
            this.cmbCity2.ValueChanged += new System.EventHandler(this.cmbCity2_ValueChanged);
            this.cmbCity2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCity2_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(69, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 106;
            this.label7.Text = "لیست شهر های شنــــاور";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(256, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 106;
            this.label6.Text = "شهر شناور:";
            // 
            // AddCityToLIst
            // 
            this.AddCityToLIst.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AddCityToLIst.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AddCityToLIst.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.AddCityToLIst.Location = new System.Drawing.Point(48, 32);
            this.AddCityToLIst.Name = "AddCityToLIst";
            this.AddCityToLIst.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.AddCityToLIst.Size = new System.Drawing.Size(18, 28);
            this.AddCityToLIst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AddCityToLIst.Symbol = "";
            this.AddCityToLIst.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddCityToLIst.SymbolSize = 15F;
            this.AddCityToLIst.TabIndex = 107;
            this.AddCityToLIst.Tooltip = "افزودن به لیست";
            this.AddCityToLIst.Click += new System.EventHandler(this.AddCityToLIst_Click);
            // 
            // btnAddCity2
            // 
            this.btnAddCity2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCity2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCity2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddCity2.Location = new System.Drawing.Point(28, 32);
            this.btnAddCity2.Name = "btnAddCity2";
            this.btnAddCity2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddCity2.Size = new System.Drawing.Size(18, 28);
            this.btnAddCity2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCity2.Symbol = "";
            this.btnAddCity2.SymbolSize = 15F;
            this.btnAddCity2.TabIndex = 107;
            this.btnAddCity2.Tooltip = "ثبت آیتم جدید";
            this.btnAddCity2.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // frmPlaceTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 759);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmPlaceTransfer";
            this.Text = "فرم ثبت محل بارگیری و تخلیه کالاها";
            this.Load += new System.EventHandler(this.frmPlaceTransfer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPlaceTransfer_KeyDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvacuationDeployment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbEvacuationDeployment;
        private Janus.Windows.GridEX.EditControls.EditBox txtPlaceTransferName;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCity1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevComponents.DotNetBar.ButtonX btnAddCity1;
        private System.Windows.Forms.CheckBox chkPublic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Class_General.MyTextBoxJanus txtPostalCode;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.GridEX.EditControls.EditBox txtAddres;
        private System.Windows.Forms.Panel panel1;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCity2;
        private System.Windows.Forms.Label label6;
        public DevComponents.DotNetBar.ButtonX AddCityToLIst;
        public DevComponents.DotNetBar.ButtonX btnAddCity2;
        public GridExEx.GridExEx dgvListCity;
        private System.Windows.Forms.Label label7;
    }
}