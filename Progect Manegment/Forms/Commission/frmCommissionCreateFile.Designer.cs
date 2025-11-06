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
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListB_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column72.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommissionCreateFile));
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListB_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column73.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListB_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column74.ButtonImage");
            this.dgvListB = new GridExEx.GridExEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportFile = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListB
            // 
            this.dgvListB.DefaultComment = null;
            this.dgvListB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListB.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvListB.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvListB.FindCondition = null;
            this.dgvListB.FrozenColumns = 9;
            this.dgvListB.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.dgvListB.HiddenColumnSortingEnabled = false;
            this.dgvListB.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvListB_Layout_0.IsCurrentLayout = true;
            dgvListB_Layout_0.Key = "MyGrig";
            dgvListB_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("dgvListB_Layout_0_Reference_0.Instance")));
            dgvListB_Layout_0_Reference_1.Instance = ((object)(resources.GetObject("dgvListB_Layout_0_Reference_1.Instance")));
            dgvListB_Layout_0_Reference_2.Instance = ((object)(resources.GetObject("dgvListB_Layout_0_Reference_2.Instance")));
            dgvListB_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            dgvListB_Layout_0_Reference_0,
            dgvListB_Layout_0_Reference_1,
            dgvListB_Layout_0_Reference_2});
            dgvListB_Layout_0.LayoutString = resources.GetString("dgvListB_Layout_0.LayoutString");
            this.dgvListB.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvListB_Layout_0});
            this.dgvListB.Location = new System.Drawing.Point(0, 0);
            this.dgvListB.Name = "dgvListB";
            this.dgvListB.RecordNavigator = true;
            this.dgvListB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListB.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.dgvListB.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListB.SettingsKey = "frmComersB";
            this.dgvListB.Size = new System.Drawing.Size(1129, 418);
            this.dgvListB.Sortable = true;
            this.dgvListB.TabIndex = 87;
            this.dgvListB.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListB.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListB.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvListB.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListB.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImportFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 32);
            this.panel1.TabIndex = 88;
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
            // frmCommissionCreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.dgvListB);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCommissionCreateFile";
            this.Text = "ایجاد فایل";
            this.Load += new System.EventHandler(this.frmCommissionCreateFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvListB;
        private System.Windows.Forms.Panel panel1;
        public DevComponents.DotNetBar.ButtonX btnImportFile;
    }
}