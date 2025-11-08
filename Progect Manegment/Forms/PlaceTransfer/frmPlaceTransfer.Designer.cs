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
            Janus.Windows.GridEX.GridEXLayout cmbCity_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.dgvList = new GridExEx.GridExEx();
            this.cmbEvacuationDeployment = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtPlaceTransferName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.cmbCity = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCity = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPublic = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostalCode = new HM_ERP_System.Class_General.MyTextBoxJanus(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddres = new Janus.Windows.GridEX.EditControls.EditBox();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEvacuationDeployment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(559, 261);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(559, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 311);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(559, 28);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.txtAddres);
            this.pnlAddItemBodi.Controls.Add(this.txtPostalCode);
            this.pnlAddItemBodi.Controls.Add(this.chkPublic);
            this.pnlAddItemBodi.Controls.Add(this.btnAddCity);
            this.pnlAddItemBodi.Controls.Add(this.label3);
            this.pnlAddItemBodi.Controls.Add(this.label5);
            this.pnlAddItemBodi.Controls.Add(this.label4);
            this.pnlAddItemBodi.Controls.Add(this.label2);
            this.pnlAddItemBodi.Controls.Add(this.label1);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Controls.Add(this.cmbCity);
            this.pnlAddItemBodi.Controls.Add(this.cmbEvacuationDeployment);
            this.pnlAddItemBodi.Controls.Add(this.txtPlaceTransferName);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(360, 311);
            this.pnlAddItemBodi.TabIndex = 0;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 311);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(360, 28);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(285, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(320, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 6, 22, 23, 2, 54, 641);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(118, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 6, 22, 23, 2, 54, 641);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(28, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(248, 17);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(450, 17);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItems.Size = new System.Drawing.Size(561, 367);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(564, 3);
            this.pnlAddItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddItems.Size = new System.Drawing.Size(366, 367);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(525, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX1
            // 
            this.buttonX01.Location = new System.Drawing.Point(491, 0);
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
            this.dgvList.Size = new System.Drawing.Size(559, 261);
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
            this.cmbEvacuationDeployment.ValueChanged += new System.EventHandler(this.cmbEvacuationDeployment_ValueChanged);
            this.cmbEvacuationDeployment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            // 
            // txtPlaceTransferName
            // 
            this.txtPlaceTransferName.Location = new System.Drawing.Point(81, 78);
            this.txtPlaceTransferName.Name = "txtPlaceTransferName";
            this.txtPlaceTransferName.Size = new System.Drawing.Size(183, 28);
            this.txtPlaceTransferName.TabIndex = 2;
            this.txtPlaceTransferName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtPlaceTransferName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            // 
            // cmbCity
            // 
            this.cmbCity.DataMember = "id";
            cmbCity_DesignTimeLayout.LayoutString = resources.GetString("cmbCity_DesignTimeLayout.LayoutString");
            this.cmbCity.DesignTimeLayout = cmbCity_DesignTimeLayout;
            this.cmbCity.DisplayMember = "Name";
            this.cmbCity.Image = ((System.Drawing.Image)(resources.GetObject("cmbCity.Image")));
            this.cmbCity.Location = new System.Drawing.Point(81, 43);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.SelectedIndex = -1;
            this.cmbCity.SelectedItem = null;
            this.cmbCity.Size = new System.Drawing.Size(183, 30);
            this.cmbCity.TabIndex = 1;
            this.cmbCity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbCity.ValueMember = "id";
            this.cmbCity.ValueChanged += new System.EventHandler(this.cmbCity_ValueChanged);
            this.cmbCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCity_KeyDown);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(268, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 106;
            this.label1.Text = "شهر:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(268, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 106;
            this.label2.Text = "نام مکان:";
            // 
            // btnAddCity
            // 
            this.btnAddCity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddCity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddCity.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddCity.Location = new System.Drawing.Point(61, 43);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddCity.Size = new System.Drawing.Size(18, 28);
            this.btnAddCity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddCity.Symbol = "";
            this.btnAddCity.SymbolSize = 15F;
            this.btnAddCity.TabIndex = 107;
            this.btnAddCity.Tooltip = "ثبت آیتم جدید";
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(268, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 106;
            this.label3.Text = "وضعیت:";
            // 
            // chkPublic
            // 
            this.chkPublic.AutoSize = true;
            this.chkPublic.Location = new System.Drawing.Point(156, 207);
            this.chkPublic.Name = "chkPublic";
            this.chkPublic.Size = new System.Drawing.Size(108, 26);
            this.chkPublic.TabIndex = 5;
            this.chkPublic.Text = "عمومی(شناور)";
            this.chkPublic.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(268, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 106;
            this.label4.Text = "کد پستی:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.CheackCodeMeli = false;
            this.txtPostalCode.Day = 0;
            this.txtPostalCode.Location = new System.Drawing.Point(138, 110);
            this.txtPostalCode.MaxLength = 10;
            this.txtPostalCode.Miladi = new System.DateTime(((long)(0)));
            this.txtPostalCode.Month = 0;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.NowDateSelected = false;
            this.txtPostalCode.Number = null;
            this.txtPostalCode.SelectedDate = null;
            this.txtPostalCode.Shamsi = null;
            this.txtPostalCode.Size = new System.Drawing.Size(126, 28);
            this.txtPostalCode.TabIndex = 3;
            this.txtPostalCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtPostalCode.TextBoxBackColorEnter = System.Drawing.Color.Yellow;
            this.txtPostalCode.TextDigitGroup = false;
            this.txtPostalCode.TextMode = HM_ERP_System.Class_General.MyTextBoxJanus.TextBoxMode.IntNumber;
            this.txtPostalCode.TextSimple = "";
            this.txtPostalCode.TextWatermark = null;
            this.txtPostalCode.TextWatermarkForeColor = System.Drawing.Color.Gray;
            this.txtPostalCode.Year = 0;
            this.txtPostalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(268, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 106;
            this.label5.Text = "آدرس:";
            // 
            // txtAddres
            // 
            this.txtAddres.Location = new System.Drawing.Point(3, 146);
            this.txtAddres.Multiline = true;
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(261, 55);
            this.txtAddres.TabIndex = 4;
            this.txtAddres.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtAddres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEvacuationDeployment_KeyDown);
            // 
            // frmPlaceTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 373);
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
            ((System.ComponentModel.ISupportInitialize)(this.cmbCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvList;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbEvacuationDeployment;
        private Janus.Windows.GridEX.EditControls.EditBox txtPlaceTransferName;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevComponents.DotNetBar.ButtonX btnAddCity;
        private System.Windows.Forms.CheckBox chkPublic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Class_General.MyTextBoxJanus txtPostalCode;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.GridEX.EditControls.EditBox txtAddres;
    }
}