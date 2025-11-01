namespace HM_ERP_System.Forms.SearchCombos
{
    partial class frmSearchAllCombo
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
            Janus.Windows.GridEX.GridEXLayout grList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference grList_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchAllCombo));
            Janus.Windows.GridEX.GridEXLayout cmbSub_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grList = new GridExEx.GridExEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSub = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbSub = new Janus.Windows.GridEX.EditControls.MultiColumnCombo();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSub)).BeginInit();
            this.SuspendLayout();
            // 
            // grList
            // 
            this.grList.DefaultComment = null;
            this.grList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grList.FindCondition = null;
            this.grList.FrozenColumns = 1;
            this.grList.HiddenColumnSortingEnabled = false;
            this.grList.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            grList_Layout_0.IsCurrentLayout = true;
            grList_Layout_0.Key = "MyGrig";
            grList_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("grList_Layout_0_Reference_0.Instance")));
            grList_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            grList_Layout_0_Reference_0});
            grList_Layout_0.LayoutString = resources.GetString("grList_Layout_0.LayoutString");
            this.grList.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            grList_Layout_0});
            this.grList.Location = new System.Drawing.Point(0, 68);
            this.grList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grList.Name = "grList";
            this.grList.RecordNavigator = true;
            this.grList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.grList.Size = new System.Drawing.Size(1012, 381);
            this.grList.Sortable = true;
            this.grList.TabIndex = 86;
            this.grList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.grList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.grList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.grList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grList_ColumnButtonClick);
            this.grList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grList_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSub);
            this.panel1.Controls.Add(this.cmbSub);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 68);
            this.panel1.TabIndex = 0;
            // 
            // txtSub
            // 
            this.txtSub.Anchor = System.Windows.Forms.AnchorStyles.Right;
            // 
            // 
            // 
            this.txtSub.Border.Class = "TextBoxBorder";
            this.txtSub.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSub.ButtonCustom.Symbol = "";
            this.txtSub.ButtonCustom.Visible = true;
            this.txtSub.ButtonCustom2.Symbol = "";
            this.txtSub.ButtonCustom2.SymbolColor = System.Drawing.Color.Red;
            this.txtSub.ButtonCustom2.Visible = true;
            this.txtSub.Location = new System.Drawing.Point(619, 35);
            this.txtSub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSub.Name = "txtSub";
            this.txtSub.PreventEnterBeep = true;
            this.txtSub.Size = new System.Drawing.Size(232, 28);
            this.txtSub.TabIndex = 100;
            this.txtSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSub.WatermarkText = "عنوان جستجو را وارد نمائید";
            this.txtSub.ButtonCustomClick += new System.EventHandler(this.txtSub_ButtonCustomClick);
            this.txtSub.ButtonCustom2Click += new System.EventHandler(this.txtSub_ButtonCustom2Click);
            this.txtSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSub_KeyDown);
            // 
            // cmbSub
            // 
            this.cmbSub.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbSub.DataMember = "id";
            cmbSub_DesignTimeLayout.LayoutString = resources.GetString("cmbSub_DesignTimeLayout.LayoutString");
            this.cmbSub.DesignTimeLayout = cmbSub_DesignTimeLayout;
            this.cmbSub.DisplayMember = "Name";
            this.cmbSub.Location = new System.Drawing.Point(619, 6);
            this.cmbSub.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSub.Name = "cmbSub";
            this.cmbSub.SelectedIndex = -1;
            this.cmbSub.SelectedItem = null;
            this.cmbSub.Size = new System.Drawing.Size(232, 28);
            this.cmbSub.TabIndex = 98;
            this.cmbSub.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.cmbSub.ValueMember = "id";
            this.cmbSub.ValueChanged += new System.EventHandler(this.cmbSub_ValueChanged);
            this.cmbSub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSub_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(854, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 99;
            this.label1.Text = "عنوان جستجو:";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.Location = new System.Drawing.Point(854, 11);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(149, 18);
            this.label22.TabIndex = 99;
            this.label22.Text = "ستون مورد نظر جهت جستجو:";
            // 
            // frmSearchAllCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 449);
            this.Controls.Add(this.grList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Vazir FD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchAllCombo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم جستجو";
            this.Load += new System.EventHandler(this.frmSearchAllCombo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSearchAllCombo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public GridExEx.GridExEx grList;
        private Janus.Windows.GridEX.EditControls.MultiColumnCombo cmbSub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSub;
    }
}