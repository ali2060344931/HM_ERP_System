namespace HM_ERP_System.Forms.Commission
{
    partial class frmCommissionCreateFile
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
            Janus.Windows.GridEX.GridEXLayout dgvListB_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommissionCreateFile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportFile = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitel = new System.Windows.Forms.Label();
            this.dgvListB = new GridExEx.GridExEx();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnImportFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 32);
            this.panel1.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(636, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 32);
            this.label1.TabIndex = 104;
            this.label1.Text = "با فیلتر کردن لیست، آیتم های مورد نظر را انتخاب و سپس ذخیره نمائید.";
            // 
            // btnImportFile
            // 
            this.btnImportFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportFile.BackColor = System.Drawing.Color.Transparent;
            this.btnImportFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportFile.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnImportFile.Location = new System.Drawing.Point(0, 0);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnImportFile.Size = new System.Drawing.Size(160, 32);
            this.btnImportFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportFile.Symbol = "";
            this.btnImportFile.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImportFile.SymbolSize = 20F;
            this.btnImportFile.TabIndex = 103;
            this.btnImportFile.Text = "ذخیره جدول به اکسل";
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 29);
            this.panel2.TabIndex = 89;
            // 
            // lblTitel
            // 
            this.lblTitel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitel.Font = new System.Drawing.Font("Vazir FD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitel.Location = new System.Drawing.Point(0, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(1129, 29);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "لیست بارنامه های ثبت نشده پورسانت برای ";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListB
            // 
            this.dgvListB.DefaultComment = null;
            this.dgvListB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListB.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvListB.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvListB.FindCondition = null;
            this.dgvListB.FrozenColumns = 5;
            this.dgvListB.HiddenColumnSortingEnabled = false;
            this.dgvListB.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvListB_Layout_0.IsCurrentLayout = true;
            dgvListB_Layout_0.Key = "MyGrig";
            dgvListB_Layout_0.LayoutString = resources.GetString("dgvListB_Layout_0.LayoutString");
            this.dgvListB.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvListB_Layout_0});
            this.dgvListB.Location = new System.Drawing.Point(0, 29);
            this.dgvListB.Name = "dgvListB";
            this.dgvListB.RecordNavigator = true;
            this.dgvListB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListB.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvListB.Size = new System.Drawing.Size(1129, 389);
            this.dgvListB.Sortable = true;
            this.dgvListB.TabIndex = 90;
            this.dgvListB.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListB.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListB.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvListB.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListB.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListB.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            // 
            // frmCommissionCreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.dgvListB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCommissionCreateFile";
            this.Text = "ایجاد فایل";
            this.Load += new System.EventHandler(this.frmCommissionCreateFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public DevComponents.DotNetBar.ButtonX btnImportFile;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label label1;
        public GridExEx.GridExEx dgvListB;
    }
}