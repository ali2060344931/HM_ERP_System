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
            Janus.Windows.GridEX.GridEXLayout cmbFieldActivity_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
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
            this.txtPostalCode1 = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddres = new Janus.Windows.GridEX.EditControls.EditBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListCity = new GridExEx.GridExEx();
            this.cmbCity2 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtPostalCode2 = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddCityToLIst = new DevComponents.DotNetBar.ButtonX();
            this.btnAddCity2 = new DevComponents.DotNetBar.ButtonX();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFieldActivity = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPostalCode3 = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbFieldActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Margin = new System.Windows.Forms.Padding(4);
            this.pnlViewItemBody.Size = new System.Drawing.Size(917, 647);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Controls.Add(this.buttonX2);
            this.pnlViewItemHeder.Controls.Add(this.txtPostalCode3);
            this.pnlViewItemHeder.Controls.Add(this.label10);
            this.pnlViewItemHeder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlViewItemHeder.Size = new System.Drawing.Size(917, 50);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.label10, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.labelX2, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.labelX1, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.txtDateStart, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.txtPostalCode3, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.btnShowListItems, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.txtDateEnd, 0);
            this.pnlViewItemHeder.Controls.SetChildIndex(this.buttonX2, 0);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 697);
            this.pnlViewItemFoter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(917, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.panel1);
            this.pnlAddItemBodi.Controls.Add(this.txtAddres);
            this.pnlAddItemBodi.Controls.Add(this.txtPostalCode1);
            this.pnlAddItemBodi.Controls.Add(this.buttonX1);
            this.pnlAddItemBodi.Controls.Add(this.btnAddCity1);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label8);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Controls.Add(this.cmbFieldActivity);
            this.pnlAddItemBodi.Controls.Add(this.cmbCity1);
            this.pnlAddItemBodi.Controls.Add(this.cmbEvacuationDeployment);
            this.pnlAddItemBodi.Controls.Add(this.txtPlaceTransferName);
            this.pnlAddItemBodi.Controls.Add(this.chkPublic);
            this.pnlAddItemBodi.Controls.Add(this.label13);
            this.pnlAddItemBodi.Controls.Add(this.label12);
            this.pnlAddItemBodi.Controls.Add(this.label11);
            this.pnlAddItemBodi.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(514, 697);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 697);
            this.pnlAddItemFoter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(514, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(439, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(298, 10);
            this.txtDateStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateStart.Value = new System.DateTime(2025, 6, 22, 23, 2, 54, 641);
            this.txtDateStart.Visible = false;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(96, 10);
            this.txtDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateEnd.Value = new System.DateTime(2025, 6, 22, 23, 2, 54, 641);
            this.txtDateEnd.Visible = false;
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(6, 13);
            this.btnShowListItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowListItems.Visible = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(226, 15);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Visible = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(428, 15);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            this.labelX1.Visible = false;
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(919, 753);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(922, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(520, 753);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(883, 0);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(849, 0);
            this.buttonX01.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX01.Click += new System.EventHandler(this.buttonX01_Click);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(814, 0);
            this.btnShowGridExHideColumns.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvList.Size = new System.Drawing.Size(917, 647);
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
            this.cmbEvacuationDeployment.Location = new System.Drawing.Point(202, 10);
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
            this.txtPlaceTransferName.Location = new System.Drawing.Point(202, 115);
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
            this.cmbCity1.Location = new System.Drawing.Point(202, 78);
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
            this.label14.Location = new System.Drawing.Point(389, 15);
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
            this.label1.Location = new System.Drawing.Point(389, 83);
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
            this.label2.Location = new System.Drawing.Point(389, 120);
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
            this.btnAddCity1.Location = new System.Drawing.Point(182, 78);
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
            this.label3.Location = new System.Drawing.Point(389, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 106;
            this.label3.Text = "وضعیت:";
            // 
            // chkPublic
            // 
            this.chkPublic.AutoSize = true;
            this.chkPublic.Location = new System.Drawing.Point(277, 295);
            this.chkPublic.Name = "chkPublic";
            this.chkPublic.Size = new System.Drawing.Size(108, 26);
            this.chkPublic.TabIndex = 6;
            this.chkPublic.Text = "عمومی(شناور)";
            this.chkPublic.UseVisualStyleBackColor = true;
            this.chkPublic.CheckedChanged += new System.EventHandler(this.chkPublic_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(389, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 106;
            this.label4.Text = "کد پستی:";
            // 
            // txtPostalCode1
            // 
            this.txtPostalCode1.CheackCodeMeli = false;
            this.txtPostalCode1.Day = 0;
            this.txtPostalCode1.Location = new System.Drawing.Point(259, 44);
            this.txtPostalCode1.MaxLength = 10;
            this.txtPostalCode1.Miladi = new System.DateTime(((long)(0)));
            this.txtPostalCode1.Month = 0;
            this.txtPostalCode1.Name = "txtPostalCode1";
            this.txtPostalCode1.NowDateSelected = false;
            this.txtPostalCode1.Number = null;
            this.txtPostalCode1.SelectedDate = null;
            this.txtPostalCode1.Shamsi = null;
            this.txtPostalCode1.Size = new System.Drawing.Size(126, 28);
            this.txtPostalCode1.TabIndex = 1;
            this.txtPostalCode1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtPostalCode1.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtPostalCode1.TextDigitGroup = false;
            this.txtPostalCode1.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtPostalCode1.TextSimple = "";
            this.txtPostalCode1.TextWatermark = null;
            this.txtPostalCode1.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtPostalCode1.Year = 0;
            this.txtPostalCode1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            this.txtPostalCode1.Leave += new System.EventHandler(this.txtPostalCode_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(389, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 106;
            this.label5.Text = "آدرس:";
            // 
            // txtAddres
            // 
            this.txtAddres.Location = new System.Drawing.Point(124, 187);
            this.txtAddres.Multiline = true;
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(261, 102);
            this.txtAddres.TabIndex = 5;
            this.txtAddres.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtAddres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvListCity);
            this.panel1.Controls.Add(this.cmbCity2);
            this.panel1.Controls.Add(this.txtPostalCode2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AddCityToLIst);
            this.panel1.Controls.Add(this.btnAddCity2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(54, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 351);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.dgvListCity.Location = new System.Drawing.Point(9, 101);
            this.dgvListCity.Name = "dgvListCity";
            this.dgvListCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListCity.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.dgvListCity.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListCity.SettingsKey = "frmProvinces";
            this.dgvListCity.Size = new System.Drawing.Size(386, 241);
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
            this.cmbCity2.Location = new System.Drawing.Point(187, 65);
            this.cmbCity2.Name = "cmbCity2";
            this.cmbCity2.SelectedIndex = -1;
            this.cmbCity2.SelectedItem = null;
            this.cmbCity2.Size = new System.Drawing.Size(208, 30);
            this.cmbCity2.TabIndex = 0;
            this.cmbCity2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCity2.ValueMember = "id";
            this.cmbCity2.ValueChanged += new System.EventHandler(this.cmbCity2_ValueChanged);
            this.cmbCity2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCity2_KeyDown);
            // 
            // txtPostalCode2
            // 
            this.txtPostalCode2.CheackCodeMeli = false;
            this.txtPostalCode2.Day = 0;
            this.txtPostalCode2.Location = new System.Drawing.Point(55, 66);
            this.txtPostalCode2.MaxLength = 10;
            this.txtPostalCode2.Miladi = new System.DateTime(((long)(0)));
            this.txtPostalCode2.Month = 0;
            this.txtPostalCode2.Name = "txtPostalCode2";
            this.txtPostalCode2.NowDateSelected = false;
            this.txtPostalCode2.Number = null;
            this.txtPostalCode2.SelectedDate = null;
            this.txtPostalCode2.Shamsi = null;
            this.txtPostalCode2.Size = new System.Drawing.Size(126, 28);
            this.txtPostalCode2.TabIndex = 1;
            this.txtPostalCode2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtPostalCode2.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtPostalCode2.TextDigitGroup = false;
            this.txtPostalCode2.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtPostalCode2.TextSimple = "";
            this.txtPostalCode2.TextWatermark = null;
            this.txtPostalCode2.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtPostalCode2.Year = 0;
            this.txtPostalCode2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            this.txtPostalCode2.Leave += new System.EventHandler(this.txtPostalCode_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(128, 6);
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
            this.label6.Location = new System.Drawing.Point(337, 44);
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
            this.AddCityToLIst.Location = new System.Drawing.Point(31, 66);
            this.AddCityToLIst.Name = "AddCityToLIst";
            this.AddCityToLIst.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.AddCityToLIst.Size = new System.Drawing.Size(18, 28);
            this.AddCityToLIst.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AddCityToLIst.Symbol = "";
            this.AddCityToLIst.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddCityToLIst.SymbolSize = 15F;
            this.AddCityToLIst.TabIndex = 2;
            this.AddCityToLIst.Tooltip = "افزودن به لیست";
            this.AddCityToLIst.Click += new System.EventHandler(this.AddCityToLIst_Click);
            // 
            // btnAddCity2
            // 
            this.btnAddCity2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCity2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCity2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddCity2.Location = new System.Drawing.Point(11, 66);
            this.btnAddCity2.Name = "btnAddCity2";
            this.btnAddCity2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddCity2.Size = new System.Drawing.Size(18, 28);
            this.btnAddCity2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCity2.Symbol = "";
            this.btnAddCity2.SymbolSize = 15F;
            this.btnAddCity2.TabIndex = 2;
            this.btnAddCity2.Tooltip = "ثبت آیتم جدید";
            this.btnAddCity2.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(127, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 106;
            this.label9.Text = "کد پستی:";
            // 
            // cmbFieldActivity
            // 
            this.cmbFieldActivity.DataMember = "id";
            cmbFieldActivity_DesignTimeLayout.LayoutString = resources.GetString("cmbFieldActivity_DesignTimeLayout.LayoutString");
            this.cmbFieldActivity.DesignTimeLayout = cmbFieldActivity_DesignTimeLayout;
            this.cmbFieldActivity.DisplayMember = "Name";
            this.cmbFieldActivity.Image = ((System.Drawing.Image)(resources.GetObject("cmbFieldActivity.Image")));
            this.cmbFieldActivity.Location = new System.Drawing.Point(148, 149);
            this.cmbFieldActivity.Name = "cmbFieldActivity";
            this.cmbFieldActivity.SelectedIndex = -1;
            this.cmbFieldActivity.SelectedItem = null;
            this.cmbFieldActivity.Size = new System.Drawing.Size(237, 30);
            this.cmbFieldActivity.TabIndex = 4;
            this.cmbFieldActivity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbFieldActivity.ValueMember = "id";
            this.cmbFieldActivity.ValueChanged += new System.EventHandler(this.cmbFieldActivity_ValueChanged);
            this.cmbFieldActivity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCity_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(389, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 106;
            this.label8.Text = "رشته فعالیت:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(128, 149);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Size = new System.Drawing.Size(18, 28);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 107;
            this.buttonX1.Tooltip = "ثبت آیتم جدید";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(773, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 18);
            this.label10.TabIndex = 106;
            this.label10.Text = "جستجوی کد پستی:";
            // 
            // txtPostalCode3
            // 
            this.txtPostalCode3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPostalCode3.CheackCodeMeli = false;
            this.txtPostalCode3.Day = 0;
            this.txtPostalCode3.Location = new System.Drawing.Point(647, 11);
            this.txtPostalCode3.MaxLength = 10;
            this.txtPostalCode3.Miladi = new System.DateTime(((long)(0)));
            this.txtPostalCode3.Month = 0;
            this.txtPostalCode3.Name = "txtPostalCode3";
            this.txtPostalCode3.NowDateSelected = false;
            this.txtPostalCode3.Number = null;
            this.txtPostalCode3.SelectedDate = null;
            this.txtPostalCode3.Shamsi = null;
            this.txtPostalCode3.Size = new System.Drawing.Size(126, 28);
            this.txtPostalCode3.TabIndex = 1;
            this.txtPostalCode3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtPostalCode3.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtPostalCode3.TextDigitGroup = false;
            this.txtPostalCode3.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtPostalCode3.TextSimple = "";
            this.txtPostalCode3.TextWatermark = null;
            this.txtPostalCode3.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtPostalCode3.Year = 0;
            this.txtPostalCode3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            this.txtPostalCode3.Leave += new System.EventHandler(this.txtPostalCode_Leave);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX2.Location = new System.Drawing.Point(619, 11);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX2.Size = new System.Drawing.Size(28, 28);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 15F;
            this.buttonX2.TabIndex = 107;
            this.buttonX2.Tooltip = "جستجو";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(451, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 25);
            this.label11.TabIndex = 106;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(436, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 25);
            this.label12.TabIndex = 106;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(457, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 25);
            this.label13.TabIndex = 106;
            this.label13.Text = "*";
            // 
            // frmPlaceTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 759);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbFieldActivity)).EndInit();
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
        private Class_General.MyTextBoxJanus txtPostalCode1;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.GridEX.EditControls.EditBox txtAddres;
        private System.Windows.Forms.Panel panel1;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCity2;
        private System.Windows.Forms.Label label6;
        public DevComponents.DotNetBar.ButtonX AddCityToLIst;
        public DevComponents.DotNetBar.ButtonX btnAddCity2;
        public GridExEx.GridExEx dgvListCity;
        private System.Windows.Forms.Label label7;
        public DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbFieldActivity;
        private Class_General.MyTextBoxJanus txtPostalCode2;
        private System.Windows.Forms.Label label9;
        public DevComponents.DotNetBar.ButtonX buttonX2;
        private Class_General.MyTextBoxJanus txtPostalCode3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}