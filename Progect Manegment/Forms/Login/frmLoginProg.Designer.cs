namespace HM_ERP_System.Forms.Login
{
    partial class frmLoginProg
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
            Janus.Windows.GridEX.GridEXLayout cmbFinancialYears_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginProg));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIncoming = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNewItem = new DevComponents.DotNetBar.ButtonX();
            this.cmbFinancialYears = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinancialYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(81, 139);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(157, 28);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // btnIncoming
            // 
            this.btnIncoming.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIncoming.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIncoming.BackColor = System.Drawing.Color.Transparent;
            this.btnIncoming.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIncoming.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnIncoming.Location = new System.Drawing.Point(80, 187);
            this.btnIncoming.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncoming.Name = "btnIncoming";
            this.btnIncoming.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnIncoming.Size = new System.Drawing.Size(158, 33);
            this.btnIncoming.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIncoming.Symbol = "59513";
            this.btnIncoming.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnIncoming.SymbolSize = 15F;
            this.btnIncoming.TabIndex = 8;
            this.btnIncoming.Text = "ورود";
            this.btnIncoming.Tooltip = "ثبت راننده جدیدپ";
            this.btnIncoming.Click += new System.EventHandler(this.btnIncoming_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(132, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "رمز عبور";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(125, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام کاربری";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.Location = new System.Drawing.Point(80, 89);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(159, 28);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(125, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "سال مـــالی";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddNewItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNewItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewItem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddNewItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddNewItem.Location = new System.Drawing.Point(63, 34);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddNewItem.Size = new System.Drawing.Size(18, 28);
            this.btnAddNewItem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddNewItem.Symbol = "";
            this.btnAddNewItem.SymbolSize = 12F;
            this.btnAddNewItem.TabIndex = 111;
            this.btnAddNewItem.TabStop = false;
            this.btnAddNewItem.Tooltip = "ثبت آیتم جدید";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // cmbFinancialYears
            // 
            this.cmbFinancialYears.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbFinancialYears.DataMember = "id";
            cmbFinancialYears_DesignTimeLayout.LayoutString = resources.GetString("cmbFinancialYears_DesignTimeLayout.LayoutString");
            this.cmbFinancialYears.DesignTimeLayout = cmbFinancialYears_DesignTimeLayout;
            this.cmbFinancialYears.DisplayMember = "Name";
            this.cmbFinancialYears.Location = new System.Drawing.Point(81, 34);
            this.cmbFinancialYears.Name = "cmbFinancialYears";
            this.cmbFinancialYears.SelectedIndex = -1;
            this.cmbFinancialYears.SelectedItem = null;
            this.cmbFinancialYears.Size = new System.Drawing.Size(158, 28);
            this.cmbFinancialYears.TabIndex = 110;
            this.cmbFinancialYears.TabStop = false;
            this.cmbFinancialYears.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbFinancialYears.ValueMember = "id";
            this.cmbFinancialYears.ValueChanged += new System.EventHandler(this.cmbFinancialYears_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // frmLoginProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 231);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.cmbFinancialYears);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnIncoming);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Vazir FD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginProg";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم اعتبار سنجی";
            this.Load += new System.EventHandler(this.frmLoginProg_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLoginProg_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFinancialYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        public DevComponents.DotNetBar.ButtonX btnIncoming;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.EditBox txtUserName;
        private System.Windows.Forms.Label label3;
        public DevComponents.DotNetBar.ButtonX btnAddNewItem;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbFinancialYears;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}