namespace HM_ERP_System.Components
{
    partial class CarPlatNew
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.GridEX.GridEXLayout cmbLeter_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarPlatNew));
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.cmbLeter = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtCarplate2 = new DevComponents.Editors.IntegerInput();
            this.txtCarplate1 = new DevComponents.Editors.IntegerInput();
            this.txtCarplate3 = new DevComponents.Editors.IntegerInput();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Location = new System.Drawing.Point(27, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(10, 28);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.Symbol = "";
            this.btnNew.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNew.SymbolSize = 6F;
            this.btnNew.TabIndex = 76;
            this.btnNew.TabStop = false;
            this.btnNew.Tooltip = "خالی کردن آیتم ها";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cmbLeter
            // 
            this.cmbLeter.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbLeter_DesignTimeLayout.LayoutString = resources.GetString("cmbLeter_DesignTimeLayout.LayoutString");
            this.cmbLeter.DesignTimeLayout = cmbLeter_DesignTimeLayout;
            this.cmbLeter.DisplayMember = "AlphabetName";
            this.cmbLeter.Enabled = false;
            this.cmbLeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbLeter.Location = new System.Drawing.Point(68, 14);
            this.cmbLeter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLeter.Name = "cmbLeter";
            this.cmbLeter.SelectedIndex = -1;
            this.cmbLeter.SelectedItem = null;
            this.cmbLeter.Size = new System.Drawing.Size(58, 26);
            this.cmbLeter.TabIndex = 72;
            this.cmbLeter.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbLeter.ValueMember = "id";
            this.cmbLeter.ValueChanged += new System.EventHandler(this.cmbLeter_ValueChanged);
            // 
            // txtCarplate2
            // 
            this.txtCarplate2.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtCarplate2.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtCarplate2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCarplate2.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCarplate2.FocusHighlightColor = System.Drawing.SystemColors.Control;
            this.txtCarplate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCarplate2.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtCarplate2.Location = new System.Drawing.Point(128, 16);
            this.txtCarplate2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarplate2.MaxValue = 999;
            this.txtCarplate2.MinValue = 0;
            this.txtCarplate2.Name = "txtCarplate2";
            this.txtCarplate2.Size = new System.Drawing.Size(51, 23);
            this.txtCarplate2.TabIndex = 73;
            this.txtCarplate2.ValueChanged += new System.EventHandler(this.txtCarplate2_ValueChanged);
            // 
            // txtCarplate1
            // 
            this.txtCarplate1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtCarplate1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtCarplate1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCarplate1.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCarplate1.FocusHighlightColor = System.Drawing.SystemColors.Control;
            this.txtCarplate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCarplate1.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtCarplate1.Location = new System.Drawing.Point(38, 16);
            this.txtCarplate1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarplate1.MaxValue = 99;
            this.txtCarplate1.MinValue = 0;
            this.txtCarplate1.Name = "txtCarplate1";
            this.txtCarplate1.Size = new System.Drawing.Size(28, 23);
            this.txtCarplate1.TabIndex = 71;
            this.txtCarplate1.ValueChanged += new System.EventHandler(this.txtCarplate1_ValueChanged);
            this.txtCarplate1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarplate1_KeyDown);
            // 
            // txtCarplate3
            // 
            this.txtCarplate3.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtCarplate3.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtCarplate3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCarplate3.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txtCarplate3.FocusHighlightColor = System.Drawing.SystemColors.Control;
            this.txtCarplate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCarplate3.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.txtCarplate3.Location = new System.Drawing.Point(195, 16);
            this.txtCarplate3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCarplate3.MaxValue = 99;
            this.txtCarplate3.MinValue = 0;
            this.txtCarplate3.Name = "txtCarplate3";
            this.txtCarplate3.Size = new System.Drawing.Size(28, 23);
            this.txtCarplate3.TabIndex = 74;
            this.txtCarplate3.ValueChanged += new System.EventHandler(this.txtCarplate3_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // CarPlatNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cmbLeter);
            this.Controls.Add(this.txtCarplate2);
            this.Controls.Add(this.txtCarplate1);
            this.Controls.Add(this.txtCarplate3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "CarPlatNew";
            this.Size = new System.Drawing.Size(236, 49);
            this.Load += new System.EventHandler(this.CarPlatNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbLeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnNew;
        public Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbLeter;
        public DevComponents.Editors.IntegerInput txtCarplate2;
        public DevComponents.Editors.IntegerInput txtCarplate1;
        public DevComponents.Editors.IntegerInput txtCarplate3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
