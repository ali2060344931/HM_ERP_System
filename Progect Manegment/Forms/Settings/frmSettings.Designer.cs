namespace HM_ERP_System.Forms.Settings
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            Janus.Windows.GridEX.GridEXLayout cmbDefultCompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkShowAccountBalance = new System.Windows.Forms.CheckBox();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.dgvList = new GridExEx.GridExEx();
            this.txtTels = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtAddres = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtSubjectTitel = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnAddPic2 = new DevComponents.DotNetBar.ButtonX();
            this.btnAddPic1 = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.picReg = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDefultCompany = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtSetDayToReportList = new DevComponents.Editors.IntegerInput();
            this.lblIEAmount = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDefultCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetDayToReportList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 31);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSave.Location = new System.Drawing.Point(772, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.SymbolSize = 15F;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ذخیره F5";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnNew.Location = new System.Drawing.Point(858, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4);
            this.btnNew.Size = new System.Drawing.Size(75, 31);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.Symbol = "57390";
            this.btnNew.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnNew.SymbolSize = 15F;
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "جدید F4";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.checkBox3);
            this.uiTabPage2.Controls.Add(this.checkBox2);
            this.uiTabPage2.Controls.Add(this.checkBox1);
            this.uiTabPage2.Controls.Add(this.txtCode);
            this.uiTabPage2.Controls.Add(this.button1);
            this.uiTabPage2.Controls.Add(this.chkShowAccountBalance);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(830, 376);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "حسابداری";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCode.Location = new System.Drawing.Point(124, 345);
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '*';
            this.txtCode.Size = new System.Drawing.Size(100, 28);
            this.txtCode.TabIndex = 2;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(224, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkShowAccountBalance
            // 
            this.chkShowAccountBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowAccountBalance.AutoSize = true;
            this.chkShowAccountBalance.BackColor = System.Drawing.Color.Transparent;
            this.chkShowAccountBalance.Location = new System.Drawing.Point(514, 21);
            this.chkShowAccountBalance.Name = "chkShowAccountBalance";
            this.chkShowAccountBalance.Size = new System.Drawing.Size(305, 26);
            this.chkShowAccountBalance.TabIndex = 0;
            this.chkShowAccountBalance.Text = "نمایش مانده حساب در فرم اسناد دریافت/پرداخت";
            this.chkShowAccountBalance.UseVisualStyleBackColor = false;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.dgvList);
            this.uiTabPage1.Controls.Add(this.txtTels);
            this.uiTabPage1.Controls.Add(this.txtAddres);
            this.uiTabPage1.Controls.Add(this.txtSubjectTitel);
            this.uiTabPage1.Controls.Add(this.txtName);
            this.uiTabPage1.Controls.Add(this.btnAddPic2);
            this.uiTabPage1.Controls.Add(this.btnAddPic1);
            this.uiTabPage1.Controls.Add(this.label4);
            this.uiTabPage1.Controls.Add(this.picReg);
            this.uiTabPage1.Controls.Add(this.picLogo);
            this.uiTabPage1.Controls.Add(this.label3);
            this.uiTabPage1.Controls.Add(this.label6);
            this.uiTabPage1.Controls.Add(this.label5);
            this.uiTabPage1.Controls.Add(this.label2);
            this.uiTabPage1.Controls.Add(this.label1);
            this.uiTabPage1.Key = "public_";
            this.uiTabPage1.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(830, 376);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "تنظیمات عمومی";
            // 
            // dgvList
            // 
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.DefaultComment = null;
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
            this.dgvList.Location = new System.Drawing.Point(8, 23);
            this.dgvList.Name = "dgvList";
            this.dgvList.RecordNavigator = true;
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvList.SettingsKey = "frmCar";
            this.dgvList.Size = new System.Drawing.Size(187, 348);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 114;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // txtTels
            // 
            this.txtTels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTels.Location = new System.Drawing.Point(201, 303);
            this.txtTels.Name = "txtTels";
            this.txtTels.Size = new System.Drawing.Size(506, 28);
            this.txtTels.TabIndex = 3;
            this.txtTels.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtAddres
            // 
            this.txtAddres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddres.Location = new System.Drawing.Point(201, 269);
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(506, 28);
            this.txtAddres.TabIndex = 2;
            this.txtAddres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtSubjectTitel
            // 
            this.txtSubjectTitel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubjectTitel.Location = new System.Drawing.Point(201, 235);
            this.txtSubjectTitel.Name = "txtSubjectTitel";
            this.txtSubjectTitel.Size = new System.Drawing.Size(506, 28);
            this.txtSubjectTitel.TabIndex = 1;
            this.txtSubjectTitel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(201, 202);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(506, 28);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btnAddPic2
            // 
            this.btnAddPic2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddPic2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPic2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddPic2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddPic2.Location = new System.Drawing.Point(259, 169);
            this.btnAddPic2.Name = "btnAddPic2";
            this.btnAddPic2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddPic2.Size = new System.Drawing.Size(100, 28);
            this.btnAddPic2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddPic2.SymbolSize = 12F;
            this.btnAddPic2.TabIndex = 112;
            this.btnAddPic2.Text = "انتخاب تصویر";
            this.btnAddPic2.Click += new System.EventHandler(this.btnAddPic2_Click);
            // 
            // btnAddPic1
            // 
            this.btnAddPic1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddPic1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPic1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddPic1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddPic1.Location = new System.Drawing.Point(549, 169);
            this.btnAddPic1.Name = "btnAddPic1";
            this.btnAddPic1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddPic1.Size = new System.Drawing.Size(100, 28);
            this.btnAddPic1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddPic1.SymbolSize = 12F;
            this.btnAddPic1.TabIndex = 112;
            this.btnAddPic1.Text = "انتخاب تصویر";
            this.btnAddPic1.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(707, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 109;
            this.label4.Text = "تلفن ها:";
            // 
            // picReg
            // 
            this.picReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picReg.Location = new System.Drawing.Point(201, 23);
            this.picReg.Name = "picReg";
            this.picReg.Size = new System.Drawing.Size(216, 146);
            this.picReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReg.TabIndex = 111;
            this.picReg.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(491, 23);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(216, 146);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 111;
            this.picLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(707, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 109;
            this.label3.Text = "آدرس شرکت(دفتر):";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(707, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 109;
            this.label6.Text = "موضوع فعالیت:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(233, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 109;
            this.label5.Text = "تصویر مهر(نمونه امضاء) شرکت";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(707, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 109;
            this.label2.Text = "نام(عنوان) شــرکت:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(549, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 109;
            this.label1.Text = "تصویر لوگوی شرکت";
            // 
            // uiTab1
            // 
            this.uiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTab1.FirstTabOffset = 3;
            this.uiTab1.Location = new System.Drawing.Point(0, 0);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTab1.Size = new System.Drawing.Size(933, 378);
            this.uiTab1.TabIndex = 0;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage3,
            this.uiTabPage2});
            this.uiTab1.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
            this.uiTab1.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Horizontal;
            this.uiTab1.UseCompatibleTextRendering = false;
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2010;
            this.uiTab1.SelectedTabChanged += new Janus.Windows.UI.Tab.TabEventHandler(this.uiTab1_SelectedTabChanged);
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.label11);
            this.uiTabPage3.Controls.Add(this.cmbDefultCompany);
            this.uiTabPage3.Controls.Add(this.txtSetDayToReportList);
            this.uiTabPage3.Controls.Add(this.lblIEAmount);
            this.uiTabPage3.Key = "privet_";
            this.uiTabPage3.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(830, 376);
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "تنظیمات شخصی";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(670, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 113;
            this.label11.Text = "شرکت پیشفرض:";
            // 
            // cmbDefultCompany
            // 
            this.cmbDefultCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDefultCompany.DataMember = "id";
            cmbDefultCompany_DesignTimeLayout.LayoutString = resources.GetString("cmbDefultCompany_DesignTimeLayout.LayoutString");
            this.cmbDefultCompany.DesignTimeLayout = cmbDefultCompany_DesignTimeLayout;
            this.cmbDefultCompany.DisplayMember = "Name";
            this.cmbDefultCompany.Location = new System.Drawing.Point(306, 66);
            this.cmbDefultCompany.Name = "cmbDefultCompany";
            this.cmbDefultCompany.SelectedIndex = -1;
            this.cmbDefultCompany.SelectedItem = null;
            this.cmbDefultCompany.Size = new System.Drawing.Size(359, 28);
            this.cmbDefultCompany.TabIndex = 112;
            this.cmbDefultCompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbDefultCompany.ValueMember = "id";
            // 
            // txtSetDayToReportList
            // 
            this.txtSetDayToReportList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSetDayToReportList.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSetDayToReportList.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSetDayToReportList.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtSetDayToReportList.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtSetDayToReportList.Location = new System.Drawing.Point(617, 32);
            this.txtSetDayToReportList.Name = "txtSetDayToReportList";
            this.txtSetDayToReportList.ShowUpDown = true;
            this.txtSetDayToReportList.Size = new System.Drawing.Size(48, 28);
            this.txtSetDayToReportList.TabIndex = 110;
            this.txtSetDayToReportList.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.txtSetDayToReportList.WatermarkText = "روز";
            // 
            // lblIEAmount
            // 
            this.lblIEAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIEAmount.AutoSize = true;
            this.lblIEAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblIEAmount.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIEAmount.Location = new System.Drawing.Point(306, 37);
            this.lblIEAmount.Name = "lblIEAmount";
            this.lblIEAmount.Size = new System.Drawing.Size(305, 18);
            this.lblIEAmount.TabIndex = 111;
            this.lblIEAmount.Text = "تعداد روز قبل از تاریخ جاری سیستم جهت نمایش لیست جداول";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 249);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(287, 26);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "حذف حواله ها، بارنامه ها و سندهای حسابداری";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(62, 281);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(231, 26);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "حذف بارنامه ها و سندهای حسابداری";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(128, 313);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(165, 26);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "حذف سندهای حسابداری";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 409);
            this.Controls.Add(this.uiTab1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmSettings";
            this.Text = "فــــرم تنظیمات برنامه";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSettings_KeyDown);
            this.panel1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage2.PerformLayout();
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            this.uiTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDefultCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetDayToReportList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public DevComponents.DotNetBar.ButtonX btnSave;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private System.Windows.Forms.CheckBox chkShowAccountBalance;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private System.Windows.Forms.PictureBox picLogo;
        public DevComponents.DotNetBar.ButtonX btnAddPic1;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        private System.Windows.Forms.Label label2;
        private Janus.Windows.GridEX.EditControls.EditBox txtTels;
        private Janus.Windows.GridEX.EditControls.EditBox txtAddres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public DevComponents.DotNetBar.ButtonX btnAddPic2;
        private System.Windows.Forms.PictureBox picReg;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.GridEX.EditControls.EditBox txtSubjectTitel;
        private System.Windows.Forms.Label label6;
        public GridExEx.GridExEx dgvList;
        public DevComponents.DotNetBar.ButtonX btnNew;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private DevComponents.Editors.IntegerInput txtSetDayToReportList;
        private System.Windows.Forms.Label lblIEAmount;
        private System.Windows.Forms.Label label11;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbDefultCompany;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}