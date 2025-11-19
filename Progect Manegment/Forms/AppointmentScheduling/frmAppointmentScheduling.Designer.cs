namespace HM_ERP_System.Forms.AppointmentScheduling
{
    partial class frmAppointmentScheduling
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
            Janus.Windows.GridEX.GridEXLayout cmbCarplate_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentScheduling));
            Janus.Windows.GridEX.GridEXLayout cmbProvinces_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference cmbProvinces_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.WatermarkImage.Image");
            this.label64 = new System.Windows.Forms.Label();
            this.btnAddCare = new DevComponents.DotNetBar.ButtonX();
            this.cmbCarplate = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new Atf.UI.DateTimeSelector();
            this.txtTime = new MyClass.MyTextBox();
            this.btnAddNewCity = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProvincesList = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnAddToList = new DevComponents.DotNetBar.ButtonX();
            this.dgvList = new GridExEx.GridExEx();
            this.cmbProvinces = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.lblCarPlatH = new System.Windows.Forms.Label();
            this.chkSelected = new System.Windows.Forms.CheckBox();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCarplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvinces)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Location = new System.Drawing.Point(0, 44);
            this.pnlViewItemBody.Size = new System.Drawing.Size(696, 421);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(696, 44);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Controls.Add(this.chkSelected);
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 465);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(696, 28);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.buttonX01, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnShowGridExHideColumns, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnExportToExcel, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.chkSelected, 0);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.lblCarPlatH);
            this.pnlAddItemBodi.Controls.Add(this.cmbProvinces);
            this.pnlAddItemBodi.Controls.Add(this.txtProvincesList);
            this.pnlAddItemBodi.Controls.Add(this.btnAddToList);
            this.pnlAddItemBodi.Controls.Add(this.btnAddNewCity);
            this.pnlAddItemBodi.Controls.Add(this.txtTime);
            this.pnlAddItemBodi.Controls.Add(this.txtDate);
            this.pnlAddItemBodi.Controls.Add(this.label64);
            this.pnlAddItemBodi.Controls.Add(this.btnAddCare);
            this.pnlAddItemBodi.Controls.Add(this.cmbCarplate);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label13);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(352, 465);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 465);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(352, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(277, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(395, 9);
            this.txtDateStart.Value = new System.DateTime(2025, 8, 9, 20, 55, 51, 416);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(193, 9);
            this.txtDateEnd.Value = new System.DateTime(2025, 8, 9, 20, 55, 51, 416);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(103, 12);
            this.btnShowListItems.Click += new System.EventHandler(this.btnShowListItems_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(323, 12);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(525, 12);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(698, 521);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(701, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(358, 521);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(593, 0);
            // 
            // buttonX01
            // 
            this.buttonX01.Location = new System.Drawing.Point(662, 0);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(627, 0);
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label64.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label64.Location = new System.Drawing.Point(86, 11);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(150, 18);
            this.label64.TabIndex = 100;
            this.label64.Text = "67 ایران 345ع12=1234567";
            // 
            // btnAddCare
            // 
            this.btnAddCare.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCare.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCare.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCare.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddCare.Location = new System.Drawing.Point(72, 31);
            this.btnAddCare.Name = "btnAddCare";
            this.btnAddCare.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddCare.Size = new System.Drawing.Size(18, 28);
            this.btnAddCare.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCare.Symbol = "";
            this.btnAddCare.SymbolSize = 15F;
            this.btnAddCare.TabIndex = 99;
            this.btnAddCare.TabStop = false;
            this.btnAddCare.Tooltip = "ثبت خودرو";
            this.btnAddCare.Click += new System.EventHandler(this.btnAddCare_Click);
            // 
            // cmbCarplate
            // 
            this.cmbCarplate.DataMember = "id";
            cmbCarplate_DesignTimeLayout.LayoutString = resources.GetString("cmbCarplate_DesignTimeLayout.LayoutString");
            this.cmbCarplate.DesignTimeLayout = cmbCarplate_DesignTimeLayout;
            this.cmbCarplate.DisplayMember = "CarPlat";
            this.cmbCarplate.Image = ((System.Drawing.Image)(resources.GetObject("cmbCarplate.Image")));
            this.cmbCarplate.Location = new System.Drawing.Point(91, 30);
            this.cmbCarplate.MaxLength = 8;
            this.cmbCarplate.Name = "cmbCarplate";
            this.cmbCarplate.SelectedIndex = -1;
            this.cmbCarplate.SelectedItem = null;
            this.cmbCarplate.Size = new System.Drawing.Size(145, 30);
            this.cmbCarplate.TabIndex = 0;
            this.cmbCarplate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCarplate.ValueMember = "id";
            this.cmbCarplate.ValueChanged += new System.EventHandler(this.cmbCarplate_ValueChanged);
            this.cmbCarplate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCarplate_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(239, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 18);
            this.label13.TabIndex = 101;
            this.label13.Text = "شماره پلاک:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(239, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 101;
            this.label1.Text = "تاریخ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(239, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 101;
            this.label2.Text = "ساعت:";
            // 
            // txtDate
            // 
            this.txtDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate.Location = new System.Drawing.Point(91, 86);
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDate.Size = new System.Drawing.Size(145, 29);
            this.txtDate.TabIndex = 1;
            this.txtDate.UsePersianFormat = true;
            this.txtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCarplate_KeyDown);
            // 
            // txtTime
            // 
            this.txtTime.CheackCodeMeli = false;
            this.txtTime.Day = 0;
            this.txtTime.Location = new System.Drawing.Point(159, 121);
            this.txtTime.Miladi = new System.DateTime(((long)(0)));
            this.txtTime.Month = 0;
            this.txtTime.Name = "txtTime";
            this.txtTime.NowDateSelected = false;
            this.txtTime.Number = null;
            this.txtTime.SelectedDate = null;
            this.txtTime.Shamsi = null;
            this.txtTime.Size = new System.Drawing.Size(77, 28);
            this.txtTime.TabIndex = 2;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtTime.TextMode = MyClass.MyTextBox.TextBoxMode.Watch;
            this.txtTime.TextSimple = "";
            this.txtTime.TextWatermark = null;
            this.txtTime.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtTime.Year = 0;
            this.txtTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCarplate_KeyDown);
            // 
            // btnAddNewCity
            // 
            this.btnAddNewCity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewCity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewCity.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewCity.Location = new System.Drawing.Point(33, 155);
            this.btnAddNewCity.Name = "btnAddNewCity";
            this.btnAddNewCity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewCity.Size = new System.Drawing.Size(18, 28);
            this.btnAddNewCity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewCity.Symbol = "";
            this.btnAddNewCity.SymbolSize = 15F;
            this.btnAddNewCity.TabIndex = 108;
            this.btnAddNewCity.TabStop = false;
            this.btnAddNewCity.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewCity.Click += new System.EventHandler(this.btnAddNewCity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(239, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 101;
            this.label4.Text = "استان:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(239, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 101;
            this.label5.Text = "لیست استان ها:";
            // 
            // txtProvincesList
            // 
            this.txtProvincesList.Location = new System.Drawing.Point(21, 208);
            this.txtProvincesList.Multiline = true;
            this.txtProvincesList.Name = "txtProvincesList";
            this.txtProvincesList.Size = new System.Drawing.Size(215, 97);
            this.txtProvincesList.TabIndex = 5;
            // 
            // btnAddToList
            // 
            this.btnAddToList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddToList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddToList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddToList.Location = new System.Drawing.Point(87, 186);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddToList.Size = new System.Drawing.Size(115, 18);
            this.btnAddToList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddToList.Symbol = "";
            this.btnAddToList.SymbolSize = 15F;
            this.btnAddToList.TabIndex = 4;
            this.btnAddToList.Tooltip = "افزودن شهر به لیست شهرها";
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
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
            this.dgvList.SettingsKey = "frmAppointmentScheduling";
            this.dgvList.Size = new System.Drawing.Size(696, 421);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 87;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // cmbProvinces
            // 
            this.cmbProvinces.DataMember = "id";
            cmbProvinces_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("cmbProvinces_DesignTimeLayout_Reference_0.Instance")));
            cmbProvinces_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            cmbProvinces_DesignTimeLayout_Reference_0});
            cmbProvinces_DesignTimeLayout.LayoutString = resources.GetString("cmbProvinces_DesignTimeLayout.LayoutString");
            this.cmbProvinces.DesignTimeLayout = cmbProvinces_DesignTimeLayout;
            this.cmbProvinces.DisplayMember = "Name";
            this.cmbProvinces.Image = ((System.Drawing.Image)(resources.GetObject("cmbProvinces.Image")));
            this.cmbProvinces.Location = new System.Drawing.Point(52, 155);
            this.cmbProvinces.Name = "cmbProvinces";
            this.cmbProvinces.SelectedIndex = -1;
            this.cmbProvinces.SelectedItem = null;
            this.cmbProvinces.Size = new System.Drawing.Size(184, 30);
            this.cmbProvinces.TabIndex = 3;
            this.cmbProvinces.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbProvinces.ValueMember = "id";
            this.cmbProvinces.ValueChanged += new System.EventHandler(this.cmbLoadingOrinig_ValueChanged);
            this.cmbProvinces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLoadingOrinig_KeyDown);
            // 
            // lblCarPlatH
            // 
            this.lblCarPlatH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCarPlatH.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCarPlatH.Location = new System.Drawing.Point(91, 63);
            this.lblCarPlatH.Name = "lblCarPlatH";
            this.lblCarPlatH.Size = new System.Drawing.Size(145, 20);
            this.lblCarPlatH.TabIndex = 111;
            this.lblCarPlatH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkSelected
            // 
            this.chkSelected.AutoSize = true;
            this.chkSelected.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkSelected.Location = new System.Drawing.Point(401, 0);
            this.chkSelected.Name = "chkSelected";
            this.chkSelected.Size = new System.Drawing.Size(192, 28);
            this.chkSelected.TabIndex = 3;
            this.chkSelected.Text = "نمایش لیست انتخاب شده ها";
            this.chkSelected.UseVisualStyleBackColor = true;
            this.chkSelected.CheckedChanged += new System.EventHandler(this.chkSelected_CheckedChanged);
            // 
            // frmAppointmentScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 527);
            this.KeyPreview = true;
            this.Name = "frmAppointmentScheduling";
            this.Text = "نوبت دهی کامیون ها";
            this.Load += new System.EventHandler(this.frmAppointmentScheduling_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAppointmentScheduling_KeyDown);
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
            ((System.Configuration.IPersistComponentSettings)(this.dgvList)).LoadComponentSettings();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProvinces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label64;
        public DevComponents.DotNetBar.ButtonX btnAddCare;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCarplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private MyClass.MyTextBox txtTime;
        public Atf.UI.DateTimeSelector txtDate;
        public DevComponents.DotNetBar.ButtonX btnAddNewCity;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.GridEX.EditControls.EditBox txtProvincesList;
        public DevComponents.DotNetBar.ButtonX btnAddToList;
        private System.Windows.Forms.Label label5;
        public GridExEx.GridExEx dgvList;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbProvinces;
        private System.Windows.Forms.Label lblCarPlatH;
        private System.Windows.Forms.CheckBox chkSelected;
    }
}