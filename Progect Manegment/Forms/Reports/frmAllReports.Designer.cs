namespace HM_ERP_System.Forms.Reports
{
    partial class frmAllReports
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
            Janus.Windows.GridEX.GridEXLayout cmbDraversH2_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllReports));
            Janus.Windows.GridEX.GridEXLayout cmbDraversH1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbResiver2_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbResiver1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbSender2_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbSender1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbCompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.chkResiver2 = new System.Windows.Forms.CheckBox();
            this.chkResiver1 = new System.Windows.Forms.CheckBox();
            this.chkSender2 = new System.Windows.Forms.CheckBox();
            this.chkSender1 = new System.Windows.Forms.CheckBox();
            this.chkDraversH2 = new System.Windows.Forms.CheckBox();
            this.label104 = new System.Windows.Forms.Label();
            this.cmbDraversH2 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cmbDraversH1 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label32 = new System.Windows.Forms.Label();
            this.lblResiver2 = new System.Windows.Forms.Label();
            this.lblResiver1 = new System.Windows.Forms.Label();
            this.lblSender2 = new System.Windows.Forms.Label();
            this.lblSender1 = new System.Windows.Forms.Label();
            this.lblDraversH2 = new System.Windows.Forms.Label();
            this.lblDraversH1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbResiver2 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cmbResiver1 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cmbSender2 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.cmbSender1 = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateEnd = new Atf.UI.DateTimeSelector();
            this.txtDateStart = new Atf.UI.DateTimeSelector();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbCompany = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.chkProductsGroupName = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraversH2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraversH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResiver2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResiver1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSender2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSender1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTab1
            // 
            this.uiTab1.BackColor = System.Drawing.SystemColors.Control;
            this.uiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTab1.FirstTabOffset = 3;
            this.uiTab1.Location = new System.Drawing.Point(0, 72);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.Size = new System.Drawing.Size(926, 348);
            this.uiTab1.TabIndex = 0;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            this.uiTab1.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
            this.uiTab1.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Horizontal;
            this.uiTab1.SelectedTabChanged += new Janus.Windows.UI.Tab.TabEventHandler(this.uiTab1_SelectedTabChanged);
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.chkProductsGroupName);
            this.uiTabPage1.Controls.Add(this.chkResiver2);
            this.uiTabPage1.Controls.Add(this.chkResiver1);
            this.uiTabPage1.Controls.Add(this.chkSender2);
            this.uiTabPage1.Controls.Add(this.chkSender1);
            this.uiTabPage1.Controls.Add(this.chkDraversH2);
            this.uiTabPage1.Controls.Add(this.label104);
            this.uiTabPage1.Controls.Add(this.cmbDraversH2);
            this.uiTabPage1.Controls.Add(this.cmbDraversH1);
            this.uiTabPage1.Controls.Add(this.label32);
            this.uiTabPage1.Controls.Add(this.lblResiver2);
            this.uiTabPage1.Controls.Add(this.lblResiver1);
            this.uiTabPage1.Controls.Add(this.lblSender2);
            this.uiTabPage1.Controls.Add(this.lblSender1);
            this.uiTabPage1.Controls.Add(this.lblDraversH2);
            this.uiTabPage1.Controls.Add(this.lblDraversH1);
            this.uiTabPage1.Controls.Add(this.label18);
            this.uiTabPage1.Controls.Add(this.label96);
            this.uiTabPage1.Controls.Add(this.label95);
            this.uiTabPage1.Controls.Add(this.label88);
            this.uiTabPage1.Controls.Add(this.label10);
            this.uiTabPage1.Controls.Add(this.label87);
            this.uiTabPage1.Controls.Add(this.label9);
            this.uiTabPage1.Controls.Add(this.cmbResiver2);
            this.uiTabPage1.Controls.Add(this.cmbResiver1);
            this.uiTabPage1.Controls.Add(this.cmbSender2);
            this.uiTabPage1.Controls.Add(this.cmbSender1);
            this.uiTabPage1.Key = "ComersH";
            this.uiTabPage1.Location = new System.Drawing.Point(3, 1);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(820, 344);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "گزارش حــــواله ها";
            // 
            // chkResiver2
            // 
            this.chkResiver2.AutoSize = true;
            this.chkResiver2.Checked = true;
            this.chkResiver2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResiver2.Location = new System.Drawing.Point(496, 173);
            this.chkResiver2.Name = "chkResiver2";
            this.chkResiver2.Size = new System.Drawing.Size(15, 14);
            this.chkResiver2.TabIndex = 120;
            this.chkResiver2.UseVisualStyleBackColor = true;
            // 
            // chkResiver1
            // 
            this.chkResiver1.AutoSize = true;
            this.chkResiver1.Checked = true;
            this.chkResiver1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResiver1.Location = new System.Drawing.Point(496, 145);
            this.chkResiver1.Name = "chkResiver1";
            this.chkResiver1.Size = new System.Drawing.Size(15, 14);
            this.chkResiver1.TabIndex = 120;
            this.chkResiver1.UseVisualStyleBackColor = true;
            // 
            // chkSender2
            // 
            this.chkSender2.AutoSize = true;
            this.chkSender2.Checked = true;
            this.chkSender2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSender2.Location = new System.Drawing.Point(496, 114);
            this.chkSender2.Name = "chkSender2";
            this.chkSender2.Size = new System.Drawing.Size(15, 14);
            this.chkSender2.TabIndex = 120;
            this.chkSender2.UseVisualStyleBackColor = true;
            // 
            // chkSender1
            // 
            this.chkSender1.AutoSize = true;
            this.chkSender1.Checked = true;
            this.chkSender1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSender1.Location = new System.Drawing.Point(496, 85);
            this.chkSender1.Name = "chkSender1";
            this.chkSender1.Size = new System.Drawing.Size(15, 14);
            this.chkSender1.TabIndex = 120;
            this.chkSender1.UseVisualStyleBackColor = true;
            // 
            // chkDraversH2
            // 
            this.chkDraversH2.AutoSize = true;
            this.chkDraversH2.Checked = true;
            this.chkDraversH2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDraversH2.Location = new System.Drawing.Point(496, 54);
            this.chkDraversH2.Name = "chkDraversH2";
            this.chkDraversH2.Size = new System.Drawing.Size(15, 14);
            this.chkDraversH2.TabIndex = 120;
            this.chkDraversH2.UseVisualStyleBackColor = true;
            // 
            // label104
            // 
            this.label104.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label104.BackColor = System.Drawing.Color.Transparent;
            this.label104.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label104.ForeColor = System.Drawing.Color.Red;
            this.label104.Location = new System.Drawing.Point(572, 24);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(15, 15);
            this.label104.TabIndex = 119;
            this.label104.Text = "*";
            this.label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDraversH2
            // 
            this.cmbDraversH2.DataMember = "id";
            cmbDraversH2_DesignTimeLayout.LayoutString = resources.GetString("cmbDraversH2_DesignTimeLayout.LayoutString");
            this.cmbDraversH2.DesignTimeLayout = cmbDraversH2_DesignTimeLayout;
            this.cmbDraversH2.DisplayMember = "Name";
            this.cmbDraversH2.Image = ((System.Drawing.Image)(resources.GetObject("cmbDraversH2.Image")));
            this.cmbDraversH2.Location = new System.Drawing.Point(0, 34);
            this.cmbDraversH2.Name = "cmbDraversH2";
            this.cmbDraversH2.SelectedIndex = -1;
            this.cmbDraversH2.SelectedItem = null;
            this.cmbDraversH2.Size = new System.Drawing.Size(222, 30);
            this.cmbDraversH2.TabIndex = 116;
            this.cmbDraversH2.ValueMember = "id";
            this.cmbDraversH2.Visible = false;
            this.cmbDraversH2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDraversH2_KeyDown);
            // 
            // cmbDraversH1
            // 
            this.cmbDraversH1.DataMember = "id";
            cmbDraversH1_DesignTimeLayout.LayoutString = resources.GetString("cmbDraversH1_DesignTimeLayout.LayoutString");
            this.cmbDraversH1.DesignTimeLayout = cmbDraversH1_DesignTimeLayout;
            this.cmbDraversH1.DisplayMember = "Name";
            this.cmbDraversH1.Image = ((System.Drawing.Image)(resources.GetObject("cmbDraversH1.Image")));
            this.cmbDraversH1.Location = new System.Drawing.Point(0, 3);
            this.cmbDraversH1.Name = "cmbDraversH1";
            this.cmbDraversH1.SelectedIndex = -1;
            this.cmbDraversH1.SelectedItem = null;
            this.cmbDraversH1.Size = new System.Drawing.Size(222, 30);
            this.cmbDraversH1.TabIndex = 115;
            this.cmbDraversH1.ValueMember = "id";
            this.cmbDraversH1.Visible = false;
            this.cmbDraversH1.ValueChanged += new System.EventHandler(this.cmbDraversH1_ValueChanged);
            this.cmbDraversH1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDraversH1_KeyDown);
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label32.Location = new System.Drawing.Point(514, 52);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(66, 18);
            this.label32.TabIndex = 117;
            this.label32.Text = "نام راننده 2:";
            // 
            // lblResiver2
            // 
            this.lblResiver2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResiver2.BackColor = System.Drawing.Color.Transparent;
            this.lblResiver2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResiver2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResiver2.Location = new System.Drawing.Point(275, 171);
            this.lblResiver2.Name = "lblResiver2";
            this.lblResiver2.Size = new System.Drawing.Size(215, 18);
            this.lblResiver2.TabIndex = 118;
            // 
            // lblResiver1
            // 
            this.lblResiver1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResiver1.BackColor = System.Drawing.Color.Transparent;
            this.lblResiver1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResiver1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResiver1.Location = new System.Drawing.Point(275, 143);
            this.lblResiver1.Name = "lblResiver1";
            this.lblResiver1.Size = new System.Drawing.Size(215, 18);
            this.lblResiver1.TabIndex = 118;
            // 
            // lblSender2
            // 
            this.lblSender2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSender2.BackColor = System.Drawing.Color.Transparent;
            this.lblSender2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSender2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSender2.Location = new System.Drawing.Point(275, 112);
            this.lblSender2.Name = "lblSender2";
            this.lblSender2.Size = new System.Drawing.Size(215, 18);
            this.lblSender2.TabIndex = 118;
            // 
            // lblSender1
            // 
            this.lblSender1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSender1.BackColor = System.Drawing.Color.Transparent;
            this.lblSender1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSender1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSender1.Location = new System.Drawing.Point(275, 83);
            this.lblSender1.Name = "lblSender1";
            this.lblSender1.Size = new System.Drawing.Size(215, 18);
            this.lblSender1.TabIndex = 118;
            // 
            // lblDraversH2
            // 
            this.lblDraversH2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDraversH2.BackColor = System.Drawing.Color.Transparent;
            this.lblDraversH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDraversH2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDraversH2.Location = new System.Drawing.Point(275, 52);
            this.lblDraversH2.Name = "lblDraversH2";
            this.lblDraversH2.Size = new System.Drawing.Size(215, 18);
            this.lblDraversH2.TabIndex = 118;
            // 
            // lblDraversH1
            // 
            this.lblDraversH1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDraversH1.BackColor = System.Drawing.Color.Transparent;
            this.lblDraversH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDraversH1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDraversH1.Location = new System.Drawing.Point(275, 22);
            this.lblDraversH1.Name = "lblDraversH1";
            this.lblDraversH1.Size = new System.Drawing.Size(215, 18);
            this.lblDraversH1.TabIndex = 118;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(514, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 18);
            this.label18.TabIndex = 118;
            this.label18.Text = "نام راننده 1:";
            // 
            // label96
            // 
            this.label96.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label96.BackColor = System.Drawing.Color.Transparent;
            this.label96.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label96.ForeColor = System.Drawing.Color.Red;
            this.label96.Location = new System.Drawing.Point(577, 145);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(15, 15);
            this.label96.TabIndex = 113;
            this.label96.Text = "*";
            this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label95
            // 
            this.label95.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label95.BackColor = System.Drawing.Color.Transparent;
            this.label95.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label95.ForeColor = System.Drawing.Color.Red;
            this.label95.Location = new System.Drawing.Point(577, 85);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(15, 15);
            this.label95.TabIndex = 114;
            this.label95.Text = "*";
            this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.Color.Transparent;
            this.label88.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label88.Location = new System.Drawing.Point(514, 171);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(94, 18);
            this.label88.TabIndex = 109;
            this.label88.Text = "تحویل به سفارش:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(514, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 110;
            this.label10.Text = "گیرنـــــــده:";
            // 
            // label87
            // 
            this.label87.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.Color.Transparent;
            this.label87.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label87.Location = new System.Drawing.Point(514, 112);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(91, 18);
            this.label87.TabIndex = 111;
            this.label87.Text = "ارسال به سفارش:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(514, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 112;
            this.label9.Text = "فــرستنده:";
            // 
            // cmbResiver2
            // 
            this.cmbResiver2.DataMember = "id";
            cmbResiver2_DesignTimeLayout.LayoutString = resources.GetString("cmbResiver2_DesignTimeLayout.LayoutString");
            this.cmbResiver2.DesignTimeLayout = cmbResiver2_DesignTimeLayout;
            this.cmbResiver2.DisplayMember = "Name";
            this.cmbResiver2.Image = ((System.Drawing.Image)(resources.GetObject("cmbResiver2.Image")));
            this.cmbResiver2.Location = new System.Drawing.Point(-1, 157);
            this.cmbResiver2.Name = "cmbResiver2";
            this.cmbResiver2.SelectedIndex = -1;
            this.cmbResiver2.SelectedItem = null;
            this.cmbResiver2.Size = new System.Drawing.Size(223, 30);
            this.cmbResiver2.TabIndex = 108;
            this.cmbResiver2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbResiver2.ValueMember = "id";
            this.cmbResiver2.Visible = false;
            this.cmbResiver2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbResiver2_KeyDown);
            // 
            // cmbResiver1
            // 
            this.cmbResiver1.DataMember = "id";
            cmbResiver1_DesignTimeLayout.LayoutString = resources.GetString("cmbResiver1_DesignTimeLayout.LayoutString");
            this.cmbResiver1.DesignTimeLayout = cmbResiver1_DesignTimeLayout;
            this.cmbResiver1.DisplayMember = "Name";
            this.cmbResiver1.Image = ((System.Drawing.Image)(resources.GetObject("cmbResiver1.Image")));
            this.cmbResiver1.Location = new System.Drawing.Point(-1, 126);
            this.cmbResiver1.Name = "cmbResiver1";
            this.cmbResiver1.SelectedIndex = -1;
            this.cmbResiver1.SelectedItem = null;
            this.cmbResiver1.Size = new System.Drawing.Size(223, 30);
            this.cmbResiver1.TabIndex = 107;
            this.cmbResiver1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbResiver1.ValueMember = "id";
            this.cmbResiver1.Visible = false;
            this.cmbResiver1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbResiver1_KeyDown);
            // 
            // cmbSender2
            // 
            this.cmbSender2.DataMember = "id";
            cmbSender2_DesignTimeLayout.LayoutString = resources.GetString("cmbSender2_DesignTimeLayout.LayoutString");
            this.cmbSender2.DesignTimeLayout = cmbSender2_DesignTimeLayout;
            this.cmbSender2.DisplayMember = "Name";
            this.cmbSender2.Image = ((System.Drawing.Image)(resources.GetObject("cmbSender2.Image")));
            this.cmbSender2.Location = new System.Drawing.Point(-1, 95);
            this.cmbSender2.Name = "cmbSender2";
            this.cmbSender2.SelectedIndex = -1;
            this.cmbSender2.SelectedItem = null;
            this.cmbSender2.Size = new System.Drawing.Size(223, 30);
            this.cmbSender2.TabIndex = 106;
            this.cmbSender2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbSender2.ValueMember = "id";
            this.cmbSender2.Visible = false;
            this.cmbSender2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSender2_KeyDown);
            // 
            // cmbSender1
            // 
            this.cmbSender1.DataMember = "id";
            cmbSender1_DesignTimeLayout.LayoutString = resources.GetString("cmbSender1_DesignTimeLayout.LayoutString");
            this.cmbSender1.DesignTimeLayout = cmbSender1_DesignTimeLayout;
            this.cmbSender1.DisplayMember = "Name";
            this.cmbSender1.Image = ((System.Drawing.Image)(resources.GetObject("cmbSender1.Image")));
            this.cmbSender1.Location = new System.Drawing.Point(-1, 65);
            this.cmbSender1.Name = "cmbSender1";
            this.cmbSender1.SelectedIndex = -1;
            this.cmbSender1.SelectedItem = null;
            this.cmbSender1.Size = new System.Drawing.Size(223, 30);
            this.cmbSender1.TabIndex = 105;
            this.cmbSender1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbSender1.ValueMember = "id";
            this.cmbSender1.Visible = false;
            this.cmbSender1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSender1_KeyDown);
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Key = "ComersB";
            this.uiTabPage2.Location = new System.Drawing.Point(3, 1);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(820, 518);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "گزارش بارنامه ها";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtDateEnd);
            this.panel2.Controls.Add(this.txtDateStart);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Controls.Add(this.cmbCompany);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 72);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(575, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 119;
            this.label1.Text = "انتخــــاب شـــرکت:";
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateEnd.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateEnd.Location = new System.Drawing.Point(245, 5);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateEnd.Size = new System.Drawing.Size(124, 29);
            this.txtDateEnd.TabIndex = 2;
            this.txtDateEnd.UsePersianFormat = true;
            // 
            // txtDateStart
            // 
            this.txtDateStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateStart.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateStart.Location = new System.Drawing.Point(447, 5);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateStart.Size = new System.Drawing.Size(124, 29);
            this.txtDateStart.TabIndex = 3;
            this.txtDateStart.UsePersianFormat = true;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelX1.Location = new System.Drawing.Point(577, 8);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(127, 23);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolSize = 12F;
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "گـــزارش      از تاریخ:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelX2.Location = new System.Drawing.Point(375, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolSize = 12F;
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "تا تاریخ:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cmbCompany
            // 
            this.cmbCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCompany.DataMember = "id";
            cmbCompany_DesignTimeLayout.LayoutString = resources.GetString("cmbCompany_DesignTimeLayout.LayoutString");
            this.cmbCompany.DesignTimeLayout = cmbCompany_DesignTimeLayout;
            this.cmbCompany.DisplayMember = "Subject";
            this.cmbCompany.Image = ((System.Drawing.Image)(resources.GetObject("cmbCompany.Image")));
            this.cmbCompany.Location = new System.Drawing.Point(245, 38);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.SelectedIndex = -1;
            this.cmbCompany.SelectedItem = null;
            this.cmbCompany.Size = new System.Drawing.Size(326, 30);
            this.cmbCompany.TabIndex = 115;
            this.cmbCompany.ValueMember = "id";
            this.cmbCompany.ValueChanged += new System.EventHandler(this.cmbCompany_ValueChanged);
            this.cmbCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDraversH1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnPrint.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnPrint.Location = new System.Drawing.Point(385, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnPrint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.btnPrint.Size = new System.Drawing.Size(156, 28);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.Symbol = "";
            this.btnPrint.SymbolColor = System.Drawing.Color.Yellow;
            this.btnPrint.SymbolSize = 18F;
            this.btnPrint.TabIndex = 16;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "چـــــاپ Ctrl+P";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // chkProductsGroupName
            // 
            this.chkProductsGroupName.AutoSize = true;
            this.chkProductsGroupName.Location = new System.Drawing.Point(377, 204);
            this.chkProductsGroupName.Name = "chkProductsGroupName";
            this.chkProductsGroupName.Size = new System.Drawing.Size(134, 26);
            this.chkProductsGroupName.TabIndex = 121;
            this.chkProductsGroupName.Text = "نمایش گروه کالاها";
            this.chkProductsGroupName.UseVisualStyleBackColor = true;
            // 
            // frmAllReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 455);
            this.Controls.Add(this.uiTab1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAllReports";
            this.Text = "گــــزارشات";
            this.Load += new System.EventHandler(this.frmAllReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraversH2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDraversH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResiver2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbResiver1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSender2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSender1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCompany)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab uiTab1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public Atf.UI.DateTimeSelector txtDateEnd;
        public Atf.UI.DateTimeSelector txtDateStart;
        public DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label9;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbResiver2;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbResiver1;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbSender2;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbSender1;
        private System.Windows.Forms.Label label104;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbDraversH2;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbDraversH1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label18;
        public DevComponents.DotNetBar.ButtonX btnPrint;
        private System.Windows.Forms.Label lblResiver2;
        private System.Windows.Forms.Label lblResiver1;
        private System.Windows.Forms.Label lblSender2;
        private System.Windows.Forms.Label lblSender1;
        private System.Windows.Forms.Label lblDraversH2;
        private System.Windows.Forms.Label lblDraversH1;
        private System.Windows.Forms.CheckBox chkResiver2;
        private System.Windows.Forms.CheckBox chkResiver1;
        private System.Windows.Forms.CheckBox chkSender2;
        private System.Windows.Forms.CheckBox chkSender1;
        private System.Windows.Forms.CheckBox chkDraversH2;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbCompany;
        private System.Windows.Forms.CheckBox chkProductsGroupName;
    }
}