namespace HM_ERP_System.Forms.Commission
{
    partial class frmCommission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommission));
            Janus.Windows.GridEX.GridEXLayout cmbComers_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCommissionType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCustomer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.txtAmount = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new Atf.UI.DateTimeSelector();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbComers = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.btnShowComers = new DevComponents.DotNetBar.ButtonX();
            this.cmbCommissionType = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.cmbCustomer = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDes = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.chkSelectList = new System.Windows.Forms.CheckBox();
            this.btnSelectList = new DevComponents.DotNetBar.ButtonX();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbList = new Janus.Windows.GridEX.EditControls.CheckedComboBox();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCommissionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(680, 368);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(680, 50);
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 418);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(680, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddItemBodi.Controls.Add(this.cmbList);
            this.pnlAddItemBodi.Controls.Add(this.cmbCommissionType);
            this.pnlAddItemBodi.Controls.Add(this.cmbCustomer);
            this.pnlAddItemBodi.Controls.Add(this.buttonX3);
            this.pnlAddItemBodi.Controls.Add(this.cmbComers);
            this.pnlAddItemBodi.Controls.Add(this.btnSelectList);
            this.pnlAddItemBodi.Controls.Add(this.btnShowComers);
            this.pnlAddItemBodi.Controls.Add(this.txtDate);
            this.pnlAddItemBodi.Controls.Add(this.label7);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label6);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.txtDes);
            this.pnlAddItemBodi.Controls.Add(this.txtAmount);
            this.pnlAddItemBodi.Controls.Add(this.pictureBox1);
            this.pnlAddItemBodi.Controls.Add(this.chkSelectList);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(416, 418);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 418);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(416, 28);
            this.pnlAddItemFoter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(341, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(441, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 11, 2, 16, 4, 40, 280);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(239, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 11, 2, 16, 4, 40, 280);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(149, 15);
            this.btnShowListItems.Click += new System.EventHandler(this.btnShowListItems_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(369, 17);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(571, 17);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(682, 474);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(685, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(422, 474);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(646, 0);
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(612, 0);
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
            this.dgvList.Size = new System.Drawing.Size(680, 368);
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
            // txtAmount
            // 
            this.txtAmount.CheackCodeMeli = false;
            this.txtAmount.Day = 0;
            this.txtAmount.Location = new System.Drawing.Point(154, 326);
            this.txtAmount.Miladi = new System.DateTime(((long)(0)));
            this.txtAmount.Month = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.NowDateSelected = false;
            this.txtAmount.Number = null;
            this.txtAmount.SelectedDate = null;
            this.txtAmount.Shamsi = null;
            this.txtAmount.Size = new System.Drawing.Size(141, 28);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtAmount.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtAmount.TextSimple = "";
            this.txtAmount.TextWatermark = null;
            this.txtAmount.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtAmount.Year = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(299, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 99;
            this.label2.Text = "تاریخ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(299, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "بارنامه(تکی):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(299, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 99;
            this.label3.Text = "نــوع پورسانت:";
            // 
            // txtDate
            // 
            this.txtDate.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDate.Location = new System.Drawing.Point(150, 117);
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDate.Size = new System.Drawing.Size(145, 29);
            this.txtDate.TabIndex = 0;
            this.txtDate.UsePersianFormat = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(299, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 99;
            this.label4.Text = "طرف حساب:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(299, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 99;
            this.label5.Text = "مبلــــــــغ:";
            // 
            // cmbComers
            // 
            this.cmbComers.DataMember = "id";
            cmbComers_DesignTimeLayout.LayoutString = resources.GetString("cmbComers_DesignTimeLayout.LayoutString");
            this.cmbComers.DesignTimeLayout = cmbComers_DesignTimeLayout;
            this.cmbComers.DisplayMember = "ComersH";
            this.cmbComers.Image = ((System.Drawing.Image)(resources.GetObject("cmbComers.Image")));
            this.cmbComers.Location = new System.Drawing.Point(150, 176);
            this.cmbComers.Name = "cmbComers";
            this.cmbComers.SelectedIndex = -1;
            this.cmbComers.SelectedItem = null;
            this.cmbComers.Size = new System.Drawing.Size(145, 30);
            this.cmbComers.TabIndex = 1;
            this.cmbComers.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbComers.ValueMember = "id";
            this.cmbComers.ValueChanged += new System.EventHandler(this.cmbComers_ValueChanged);
            this.cmbComers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbComers_KeyDown);
            // 
            // btnShowComers
            // 
            this.btnShowComers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowComers.BackColor = System.Drawing.Color.Transparent;
            this.btnShowComers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowComers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnShowComers.Location = new System.Drawing.Point(131, 177);
            this.btnShowComers.Name = "btnShowComers";
            this.btnShowComers.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnShowComers.Size = new System.Drawing.Size(18, 28);
            this.btnShowComers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowComers.Symbol = "";
            this.btnShowComers.SymbolSize = 12F;
            this.btnShowComers.TabIndex = 102;
            // 
            // cmbCommissionType
            // 
            this.cmbCommissionType.DataMember = "id";
            cmbCommissionType_DesignTimeLayout.LayoutString = resources.GetString("cmbCommissionType_DesignTimeLayout.LayoutString");
            this.cmbCommissionType.DesignTimeLayout = cmbCommissionType_DesignTimeLayout;
            this.cmbCommissionType.DisplayMember = "Name";
            this.cmbCommissionType.Image = ((System.Drawing.Image)(resources.GetObject("cmbCommissionType.Image")));
            this.cmbCommissionType.Location = new System.Drawing.Point(28, 251);
            this.cmbCommissionType.Name = "cmbCommissionType";
            this.cmbCommissionType.SelectedIndex = -1;
            this.cmbCommissionType.SelectedItem = null;
            this.cmbCommissionType.Size = new System.Drawing.Size(267, 30);
            this.cmbCommissionType.TabIndex = 2;
            this.cmbCommissionType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCommissionType.ValueMember = "id";
            this.cmbCommissionType.ValueChanged += new System.EventHandler(this.cmbCommissionType_ValueChanged);
            this.cmbCommissionType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCommissionType_KeyDown);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.BackColor = System.Drawing.Color.Transparent;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX3.Location = new System.Drawing.Point(9, 292);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX3.Size = new System.Drawing.Size(18, 28);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolSize = 12F;
            this.buttonX3.TabIndex = 102;
            this.buttonX3.Tooltip = "ثبت آیتم جدید";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DataMember = "id";
            cmbCustomer_DesignTimeLayout.LayoutString = resources.GetString("cmbCustomer_DesignTimeLayout.LayoutString");
            this.cmbCustomer.DesignTimeLayout = cmbCustomer_DesignTimeLayout;
            this.cmbCustomer.DisplayMember = "Name";
            this.cmbCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cmbCustomer.Image")));
            this.cmbCustomer.Location = new System.Drawing.Point(28, 290);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.SelectedIndex = -1;
            this.cmbCustomer.SelectedItem = null;
            this.cmbCustomer.Size = new System.Drawing.Size(267, 30);
            this.cmbCustomer.TabIndex = 3;
            this.cmbCustomer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCustomer.ValueMember = "id";
            this.cmbCustomer.ValueChanged += new System.EventHandler(this.cmbCustomer_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // txtDes
            // 
            this.txtDes.CheackCodeMeli = false;
            this.txtDes.Day = 0;
            this.txtDes.Location = new System.Drawing.Point(28, 360);
            this.txtDes.Miladi = new System.DateTime(((long)(0)));
            this.txtDes.Month = 0;
            this.txtDes.Name = "txtDes";
            this.txtDes.NowDateSelected = false;
            this.txtDes.Number = null;
            this.txtDes.SelectedDate = null;
            this.txtDes.Shamsi = null;
            this.txtDes.Size = new System.Drawing.Size(267, 28);
            this.txtDes.TabIndex = 4;
            this.txtDes.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtDes.TextSimple = "";
            this.txtDes.TextWatermark = null;
            this.txtDes.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtDes.Year = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(299, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 99;
            this.label7.Text = "توضیحــات:";
            // 
            // chkSelectList
            // 
            this.chkSelectList.AutoSize = true;
            this.chkSelectList.Location = new System.Drawing.Point(231, 150);
            this.chkSelectList.Name = "chkSelectList";
            this.chkSelectList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSelectList.Size = new System.Drawing.Size(64, 26);
            this.chkSelectList.TabIndex = 104;
            this.chkSelectList.Text = "لیستی";
            this.chkSelectList.UseVisualStyleBackColor = true;
            this.chkSelectList.CheckedChanged += new System.EventHandler(this.chkSelectList_CheckedChanged);
            // 
            // btnSelectList
            // 
            this.btnSelectList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelectList.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSelectList.Enabled = false;
            this.btnSelectList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSelectList.Location = new System.Drawing.Point(28, 215);
            this.btnSelectList.Name = "btnSelectList";
            this.btnSelectList.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnSelectList.Size = new System.Drawing.Size(121, 28);
            this.btnSelectList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSelectList.Symbol = "";
            this.btnSelectList.SymbolSize = 12F;
            this.btnSelectList.TabIndex = 102;
            this.btnSelectList.Text = "انتخـــاب از لیست";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(299, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 99;
            this.label6.Text = "بارنامه(لیست):";
            // 
            // cmbList
            // 
            cmbList_DesignTimeLayout.LayoutString = resources.GetString("cmbList_DesignTimeLayout.LayoutString");
            this.cmbList.DesignTimeLayout = cmbList_DesignTimeLayout;
            this.cmbList.Location = new System.Drawing.Point(150, 215);
            this.cmbList.Name = "cmbList";
            this.cmbList.SaveSettings = false;
            this.cmbList.Size = new System.Drawing.Size(145, 28);
            this.cmbList.TabIndex = 105;
            this.cmbList.ValuesDataMember = null;
            // 
            // frmCommission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 480);
            this.Name = "frmCommission";
            this.Text = "پـــورســـانت ها";
            this.Load += new System.EventHandler(this.frmCommission_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbComers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCommissionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        private Class_General.MyTextBoxJanus txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Atf.UI.DateTimeSelector txtDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbComers;
        public DevComponents.DotNetBar.ButtonX btnShowComers;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCommissionType;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCustomer;
        public DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private Class_General.MyTextBoxJanus txtDes;
        public DevComponents.DotNetBar.ButtonX btnSelectList;
        private System.Windows.Forms.CheckBox chkSelectList;
        private System.Windows.Forms.Label label6;
        private Janus.Windows.GridEX.EditControls.CheckedComboBox cmbList;
    }
}