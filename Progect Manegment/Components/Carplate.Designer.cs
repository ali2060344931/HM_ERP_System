namespace HM_ERP_System.Components
{
    partial class Carplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carplate));
            this.cmbLeter = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.txtCarplate2 = new DevComponents.Editors.IntegerInput();
            this.txtCarplate1 = new DevComponents.Editors.IntegerInput();
            this.txtCarplate3 = new DevComponents.Editors.IntegerInput();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLeter
            // 
            this.cmbLeter.Anchor = System.Windows.Forms.AnchorStyles.None;
            cmbLeter_DesignTimeLayout.LayoutString = resources.GetString("cmbLeter_DesignTimeLayout.LayoutString");
            this.cmbLeter.DesignTimeLayout = cmbLeter_DesignTimeLayout;
            this.cmbLeter.DisplayMember = "AlphabetName";
            this.cmbLeter.Enabled = false;
            this.cmbLeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbLeter.Location = new System.Drawing.Point(68, 17);
            this.cmbLeter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbLeter.Name = "cmbLeter";
            this.cmbLeter.SelectedIndex = -1;
            this.cmbLeter.SelectedItem = null;
            this.cmbLeter.Size = new System.Drawing.Size(58, 26);
            this.cmbLeter.TabIndex = 1;
            this.cmbLeter.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbLeter.ValueMember = "id";
            this.cmbLeter.ValueChanged += new System.EventHandler(this.cmbLeter_ValueChanged);
            this.cmbLeter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarplate1_KeyDown);
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
            this.txtCarplate2.Location = new System.Drawing.Point(128, 19);
            this.txtCarplate2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCarplate2.MaxValue = 999;
            this.txtCarplate2.MinValue = 0;
            this.txtCarplate2.Name = "txtCarplate2";
            this.txtCarplate2.Size = new System.Drawing.Size(51, 23);
            this.txtCarplate2.TabIndex = 2;
            this.txtCarplate2.ValueChanged += new System.EventHandler(this.txtCarplate2_ValueChanged);
            this.txtCarplate2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarplate1_KeyDown);
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
            this.txtCarplate1.Location = new System.Drawing.Point(38, 19);
            this.txtCarplate1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCarplate1.MaxValue = 99;
            this.txtCarplate1.MinValue = 0;
            this.txtCarplate1.Name = "txtCarplate1";
            this.txtCarplate1.Size = new System.Drawing.Size(28, 23);
            this.txtCarplate1.TabIndex = 0;
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
            this.txtCarplate3.Location = new System.Drawing.Point(195, 19);
            this.txtCarplate3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCarplate3.MaxValue = 99;
            this.txtCarplate3.MinValue = 0;
            this.txtCarplate3.Name = "txtCarplate3";
            this.txtCarplate3.Size = new System.Drawing.Size(28, 23);
            this.txtCarplate3.TabIndex = 3;
            this.txtCarplate3.ValueChanged += new System.EventHandler(this.txtCarplate3_ValueChanged);
            this.txtCarplate3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCarplate1_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, -2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Location = new System.Drawing.Point(27, 15);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(10, 36);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.Symbol = "";
            this.btnNew.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNew.SymbolSize = 6F;
            this.btnNew.TabIndex = 70;
            this.btnNew.TabStop = false;
            this.btnNew.Tooltip = "خالی کردن آیتم ها";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Carplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cmbLeter);
            this.Controls.Add(this.txtCarplate2);
            this.Controls.Add(this.txtCarplate1);
            this.Controls.Add(this.txtCarplate3);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Vazir FD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Carplate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(237, 61);
            this.Load += new System.EventHandler(this.Carplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbLeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarplate3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevComponents.Editors.IntegerInput txtCarplate2;
        public DevComponents.Editors.IntegerInput txtCarplate1;
        public DevComponents.Editors.IntegerInput txtCarplate3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbLeter;
        private DevComponents.DotNetBar.ButtonX btnNew;
    }
}
