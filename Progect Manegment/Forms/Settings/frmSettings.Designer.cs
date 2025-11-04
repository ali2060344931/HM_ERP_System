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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.chkShowAccountBalance = new System.Windows.Forms.CheckBox();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnAddPic = new DevComponents.DotNetBar.ButtonX();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtSetDayToReportList = new DevComponents.Editors.IntegerInput();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIEAmount = new System.Windows.Forms.Label();
            this.uiTab1 = new Janus.Windows.UI.Tab.UITab();
            this.panel1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetDayToReportList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).BeginInit();
            this.uiTab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 31);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.SymbolSize = 15F;
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "ذخیره F5";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.chkShowAccountBalance);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 30);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(706, 364);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "حسابداری";
            // 
            // chkShowAccountBalance
            // 
            this.chkShowAccountBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowAccountBalance.AutoSize = true;
            this.chkShowAccountBalance.BackColor = System.Drawing.Color.Transparent;
            this.chkShowAccountBalance.Location = new System.Drawing.Point(390, 21);
            this.chkShowAccountBalance.Name = "chkShowAccountBalance";
            this.chkShowAccountBalance.Size = new System.Drawing.Size(305, 26);
            this.chkShowAccountBalance.TabIndex = 0;
            this.chkShowAccountBalance.Text = "نمایش مانده حساب در فرم اسناد دریافت/پرداخت";
            this.chkShowAccountBalance.UseVisualStyleBackColor = false;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.txtName);
            this.uiTabPage1.Controls.Add(this.btnAddPic);
            this.uiTabPage1.Controls.Add(this.picLogo);
            this.uiTabPage1.Controls.Add(this.txtSetDayToReportList);
            this.uiTabPage1.Controls.Add(this.label2);
            this.uiTabPage1.Controls.Add(this.label1);
            this.uiTabPage1.Controls.Add(this.lblIEAmount);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 30);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(706, 364);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "تنظیمات عمومی";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(89, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(506, 28);
            this.txtName.TabIndex = 113;
            // 
            // btnAddPic
            // 
            this.btnAddPic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddPic.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnAddPic.Location = new System.Drawing.Point(373, 143);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnAddPic.Size = new System.Drawing.Size(100, 28);
            this.btnAddPic.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddPic.SymbolSize = 12F;
            this.btnAddPic.TabIndex = 112;
            this.btnAddPic.Text = "انتخاب تصویر";
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(479, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(216, 146);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 111;
            this.picLogo.TabStop = false;
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
            this.txtSetDayToReportList.Location = new System.Drawing.Point(328, 279);
            this.txtSetDayToReportList.Name = "txtSetDayToReportList";
            this.txtSetDayToReportList.ShowUpDown = true;
            this.txtSetDayToReportList.Size = new System.Drawing.Size(48, 28);
            this.txtSetDayToReportList.TabIndex = 110;
            this.txtSetDayToReportList.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center;
            this.txtSetDayToReportList.WatermarkText = "روز";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(597, 183);
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
            this.label1.Location = new System.Drawing.Point(537, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 109;
            this.label1.Text = "تصویر لوگوی شرکت";
            // 
            // lblIEAmount
            // 
            this.lblIEAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIEAmount.AutoSize = true;
            this.lblIEAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblIEAmount.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblIEAmount.Location = new System.Drawing.Point(376, 284);
            this.lblIEAmount.Name = "lblIEAmount";
            this.lblIEAmount.Size = new System.Drawing.Size(309, 18);
            this.lblIEAmount.TabIndex = 109;
            this.lblIEAmount.Text = "تعداد روز قبل از تاریخ جاری سیستم جهت نمایش لیست جداول:";
            // 
            // uiTab1
            // 
            this.uiTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTab1.FirstTabOffset = 3;
            this.uiTab1.Location = new System.Drawing.Point(0, 0);
            this.uiTab1.Name = "uiTab1";
            this.uiTab1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTab1.Size = new System.Drawing.Size(708, 395);
            this.uiTab1.TabIndex = 0;
            this.uiTab1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            this.uiTab1.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Horizontal;
            this.uiTab1.UseCompatibleTextRendering = false;
            this.uiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2010;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 426);
            this.Controls.Add(this.uiTab1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetDayToReportList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiTab1)).EndInit();
            this.uiTab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public DevComponents.DotNetBar.ButtonX btnSave;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private System.Windows.Forms.CheckBox chkShowAccountBalance;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private DevComponents.Editors.IntegerInput txtSetDayToReportList;
        private System.Windows.Forms.Label lblIEAmount;
        private Janus.Windows.UI.Tab.UITab uiTab1;
        private System.Windows.Forms.PictureBox picLogo;
        public DevComponents.DotNetBar.ButtonX btnAddPic;
        private System.Windows.Forms.Label label1;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        private System.Windows.Forms.Label label2;
    }
}