namespace HM_ERP_System.Forms.Draver
{
    partial class frmDraver
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
            Janus.Windows.GridEX.GridEXLayout cmbPerson_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbGender_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDraver));
            this.dgvList = new GridExEx.GridExEx();
            this.cmbPerson = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtDes = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtSeryalGovahiname = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtBirDate = new Atf.UI.DateTimeSelector();
            this.cmbGender = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.chkStatus = new Janus.Windows.EditControls.UICheckBox();
            this.btnAddNewItem = new DevComponents.DotNetBar.ButtonX();
            this.txtSmartCard = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlViewItemBody.Size = new System.Drawing.Size(1184, 540);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlViewItemHeder.Size = new System.Drawing.Size(1184, 65);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 605);
            this.pnlViewItemFoter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(1184, 36);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.label15);
            this.pnlAddItemBodi.Controls.Add(this.label13);
            this.pnlAddItemBodi.Controls.Add(this.label10);
            this.pnlAddItemBodi.Controls.Add(this.label9);
            this.pnlAddItemBodi.Controls.Add(this.label97);
            this.pnlAddItemBodi.Controls.Add(this.label8);
            this.pnlAddItemBodi.Controls.Add(this.label7);
            this.pnlAddItemBodi.Controls.Add(this.label6);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewItem);
            this.pnlAddItemBodi.Controls.Add(this.chkStatus);
            this.pnlAddItemBodi.Controls.Add(this.txtBirDate);
            this.pnlAddItemBodi.Controls.Add(this.cmbGender);
            this.pnlAddItemBodi.Controls.Add(this.cmbPerson);
            this.pnlAddItemBodi.Controls.Add(this.txtDes);
            this.pnlAddItemBodi.Controls.Add(this.txtSmartCard);
            this.pnlAddItemBodi.Controls.Add(this.txtSeryalGovahiname);
            this.pnlAddItemBodi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(553, 605);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 605);
            this.pnlAddItemFoter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(553, 36);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(446, 0);
            this.btnNew.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(606, 16);
            this.txtDateStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDateStart.Value = new System.DateTime(2025, 6, 20, 18, 49, 8, 738);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(317, 16);
            this.txtDateEnd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDateEnd.Value = new System.DateTime(2025, 6, 20, 18, 49, 8, 738);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(189, 20);
            this.btnShowListItems.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(503, 22);
            this.labelX2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.labelX2.Size = new System.Drawing.Size(80, 29);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(792, 22);
            this.labelX1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.labelX1.Size = new System.Drawing.Size(129, 29);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Location = new System.Drawing.Point(3, 3);
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(1186, 675);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(1189, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(559, 675);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(1135, 0);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(1086, 0);
            this.buttonX01.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonX01.Click += new System.EventHandler(this.buttonX01_Click);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(1036, 0);
            this.btnShowGridExHideColumns.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.FrozenColumns = 3;
            this.dgvList.HiddenColumnSortingEnabled = false;
            this.dgvList.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvList_Layout_0.IsCurrentLayout = true;
            dgvList_Layout_0.Key = "MyGrig";
            dgvList_Layout_0.LayoutString = resources.GetString("dgvList_Layout_0.LayoutString");
            this.dgvList.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvList_Layout_0});
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvList.Name = "dgvList";
            this.dgvList.RecordNavigator = true;
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvList.SettingsKey = "frmDraver";
            this.dgvList.Size = new System.Drawing.Size(1184, 540);
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
            // cmbPerson
            // 
            this.cmbPerson.DataMember = "id";
            cmbPerson_DesignTimeLayout.LayoutString = resources.GetString("cmbPerson_DesignTimeLayout.LayoutString");
            this.cmbPerson.DesignTimeLayout = cmbPerson_DesignTimeLayout;
            this.cmbPerson.DisplayMember = "Name";
            this.cmbPerson.Image = ((System.Drawing.Image)(resources.GetObject("cmbPerson.Image")));
            this.cmbPerson.Location = new System.Drawing.Point(59, 25);
            this.cmbPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.SelectedIndex = -1;
            this.cmbPerson.SelectedItem = null;
            this.cmbPerson.Size = new System.Drawing.Size(350, 34);
            this.cmbPerson.TabIndex = 0;
            this.cmbPerson.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbPerson.ValueMember = "id";
            this.cmbPerson.ValueChanged += new System.EventHandler(this.cmbPerson_ValueChanged);
            this.cmbPerson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerson_KeyDown_1);
            this.cmbPerson.Leave += new System.EventHandler(this.cmbPerson_Leave);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(59, 243);
            this.txtDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(350, 105);
            this.txtDes.TabIndex = 7;
            this.txtDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerson_KeyDown);
            // 
            // txtSeryalGovahiname
            // 
            this.txtSeryalGovahiname.Location = new System.Drawing.Point(214, 157);
            this.txtSeryalGovahiname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeryalGovahiname.Name = "txtSeryalGovahiname";
            this.txtSeryalGovahiname.Size = new System.Drawing.Size(194, 34);
            this.txtSeryalGovahiname.TabIndex = 5;
            this.txtSeryalGovahiname.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtSeryalGovahiname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerson_KeyDown);
            // 
            // txtBirDate
            // 
            this.txtBirDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBirDate.Location = new System.Drawing.Point(200, 70);
            this.txtBirDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBirDate.Name = "txtBirDate";
            this.txtBirDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBirDate.Size = new System.Drawing.Size(209, 35);
            this.txtBirDate.TabIndex = 1;
            this.txtBirDate.UsePersianFormat = true;
            this.txtBirDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerson_KeyDown);
            // 
            // cmbGender
            // 
            this.cmbGender.DataMember = "id";
            cmbGender_DesignTimeLayout.LayoutString = resources.GetString("cmbGender_DesignTimeLayout.LayoutString");
            this.cmbGender.DesignTimeLayout = cmbGender_DesignTimeLayout;
            this.cmbGender.DisplayMember = "Name";
            this.cmbGender.Location = new System.Drawing.Point(271, 113);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.SelectedIndex = -1;
            this.cmbGender.SelectedItem = null;
            this.cmbGender.Size = new System.Drawing.Size(137, 34);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbGender.ValueMember = "id";
            this.cmbGender.ValueChanged += new System.EventHandler(this.cmbGender_ValueChanged);
            this.cmbGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerson_KeyDown);
            // 
            // chkStatus
            // 
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Location = new System.Drawing.Point(339, 355);
            this.chkStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(70, 32);
            this.chkStatus.TabIndex = 8;
            this.chkStatus.Text = "فعال";
            this.chkStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerson_KeyDown);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewItem.Location = new System.Drawing.Point(31, 25);
            this.btnAddNewItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewItem.Size = new System.Drawing.Size(26, 36);
            this.btnAddNewItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewItem.Symbol = "";
            this.btnAddNewItem.SymbolSize = 15F;
            this.btnAddNewItem.TabIndex = 24;
            this.btnAddNewItem.TabStop = false;
            this.btnAddNewItem.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // txtSmartCard
            // 
            this.txtSmartCard.Location = new System.Drawing.Point(214, 199);
            this.txtSmartCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSmartCard.Name = "txtSmartCard";
            this.txtSmartCard.Size = new System.Drawing.Size(194, 34);
            this.txtSmartCard.TabIndex = 6;
            this.txtSmartCard.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtSmartCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPerson_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(411, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 23);
            this.label14.TabIndex = 106;
            this.label14.Text = "نام راننده:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(411, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 106;
            this.label1.Text = "تاریخ تولد:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(411, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 106;
            this.label2.Text = "جنسیت:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(411, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 106;
            this.label5.Text = "سریال گواهینامه:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(411, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 23);
            this.label6.TabIndex = 106;
            this.label6.Text = "سریال کارت هوشمند:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(411, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 106;
            this.label7.Text = "توضیحات:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(411, 359);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 106;
            this.label8.Text = "وضعیت:";
            // 
            // label97
            // 
            this.label97.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label97.BackColor = System.Drawing.Color.Transparent;
            this.label97.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label97.ForeColor = System.Drawing.Color.Red;
            this.label97.Location = new System.Drawing.Point(633, 32);
            this.label97.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(21, 20);
            this.label97.TabIndex = 107;
            this.label97.Text = "*";
            this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(633, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 107;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(622, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 107;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(678, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 20);
            this.label13.TabIndex = 107;
            this.label13.Text = "*";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(708, 207);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 20);
            this.label15.TabIndex = 107;
            this.label15.Text = "*";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDraver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 681);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "frmDraver";
            this.Text = "فرم ثبت راننده ها";
            this.Load += new System.EventHandler(this.frmDraver_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbPerson;
        private Janus.Windows.GridEX.EditControls.EditBox txtDes;
        private Janus.Windows.GridEX.EditControls.EditBox txtSeryalGovahiname;
        public Atf.UI.DateTimeSelector txtBirDate;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbGender;
        private Janus.Windows.EditControls.UICheckBox chkStatus;
        public DevComponents.DotNetBar.ButtonX btnAddNewItem;
        private Janus.Windows.GridEX.EditControls.EditBox txtSmartCard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label97;
    }
}