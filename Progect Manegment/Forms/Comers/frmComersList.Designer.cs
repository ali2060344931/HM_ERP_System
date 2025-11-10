namespace HM_ERP_System.Forms.Comers
{
    partial class frmComersList
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
            Janus.Windows.GridEX.GridEXLayout dgvListH_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComersList));
            Janus.Windows.GridEX.GridEXLayout dgvListB_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout dgvListCommission_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            this.pnlViewItemHeder = new System.Windows.Forms.Panel();
            this.txtDateEnd = new Atf.UI.DateTimeSelector();
            this.btnExportToExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnShowListItems = new DevComponents.DotNetBar.ButtonX();
            this.txtDateStart = new Atf.UI.DateTimeSelector();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgvListH = new GridExEx.GridExEx();
            this.dgvListB = new GridExEx.GridExEx();
            this.dgvListCommission = new GridExEx.GridExEx();
            this.pnlViewItemHeder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommission)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.AutoScroll = true;
            this.pnlViewItemHeder.AutoScrollMinSize = new System.Drawing.Size(400, 0);
            this.pnlViewItemHeder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewItemHeder.Controls.Add(this.txtDateEnd);
            this.pnlViewItemHeder.Controls.Add(this.btnExportToExcel);
            this.pnlViewItemHeder.Controls.Add(this.btnShowListItems);
            this.pnlViewItemHeder.Controls.Add(this.txtDateStart);
            this.pnlViewItemHeder.Controls.Add(this.labelX1);
            this.pnlViewItemHeder.Controls.Add(this.labelX2);
            this.pnlViewItemHeder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlViewItemHeder.Location = new System.Drawing.Point(0, 0);
            this.pnlViewItemHeder.Name = "pnlViewItemHeder";
            this.pnlViewItemHeder.Size = new System.Drawing.Size(788, 50);
            this.pnlViewItemHeder.TabIndex = 88;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateEnd.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateEnd.Location = new System.Drawing.Point(220, 12);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateEnd.Size = new System.Drawing.Size(124, 29);
            this.txtDateEnd.TabIndex = 0;
            this.txtDateEnd.UsePersianFormat = true;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportToExcel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportToExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportToExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnExportToExcel.Location = new System.Drawing.Point(11, 15);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnExportToExcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9);
            this.btnExportToExcel.Size = new System.Drawing.Size(113, 23);
            this.btnExportToExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportToExcel.Symbol = "";
            this.btnExportToExcel.SymbolColor = System.Drawing.Color.Green;
            this.btnExportToExcel.SymbolSize = 15F;
            this.btnExportToExcel.TabIndex = 3;
            this.btnExportToExcel.Text = "خروجی به اکسل";
            this.btnExportToExcel.Tooltip = "خروجی لیست به اکسل F9";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowListItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowListItems.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowListItems.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnShowListItems.Location = new System.Drawing.Point(130, 15);
            this.btnShowListItems.Name = "btnShowListItems";
            this.btnShowListItems.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnShowListItems.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8);
            this.btnShowListItems.Size = new System.Drawing.Size(84, 23);
            this.btnShowListItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowListItems.Symbol = "";
            this.btnShowListItems.SymbolSize = 15F;
            this.btnShowListItems.TabIndex = 2;
            this.btnShowListItems.Text = "نمایش F8";
            this.btnShowListItems.Click += new System.EventHandler(this.btnShowListItems_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateStart.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateStart.Location = new System.Drawing.Point(422, 12);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateStart.Size = new System.Drawing.Size(124, 29);
            this.txtDateStart.TabIndex = 0;
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
            this.labelX1.Location = new System.Drawing.Point(552, 17);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolSize = 12F;
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "نمایش از تاریخ:";
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
            this.labelX2.Location = new System.Drawing.Point(350, 17);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolSize = 12F;
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "تا تاریخ:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvListH
            // 
            this.dgvListH.DefaultComment = null;
            this.dgvListH.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvListH.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvListH.FindCondition = null;
            this.dgvListH.FrozenColumns = 5;
            this.dgvListH.HiddenColumnSortingEnabled = false;
            this.dgvListH.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvListH_Layout_0.IsCurrentLayout = true;
            dgvListH_Layout_0.Key = "MyGrig";
            dgvListH_Layout_0.LayoutString = resources.GetString("dgvListH_Layout_0.LayoutString");
            this.dgvListH.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvListH_Layout_0});
            this.dgvListH.Location = new System.Drawing.Point(154, 156);
            this.dgvListH.Name = "dgvListH";
            this.dgvListH.RecordNavigator = true;
            this.dgvListH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListH.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvListH.Size = new System.Drawing.Size(475, 89);
            this.dgvListH.Sortable = true;
            this.dgvListH.TabIndex = 87;
            this.dgvListH.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListH.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListH.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvListH.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListH.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListH.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            // 
            // dgvListB
            // 
            this.dgvListB.DefaultComment = null;
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
            this.dgvListB.Location = new System.Drawing.Point(154, 68);
            this.dgvListB.Name = "dgvListB";
            this.dgvListB.RecordNavigator = true;
            this.dgvListB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListB.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvListB.Size = new System.Drawing.Size(475, 82);
            this.dgvListB.Sortable = true;
            this.dgvListB.TabIndex = 87;
            this.dgvListB.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListB.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListB.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvListB.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListB.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListB.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            // 
            // dgvListCommission
            // 
            this.dgvListCommission.DefaultComment = null;
            this.dgvListCommission.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvListCommission.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvListCommission.FindCondition = null;
            this.dgvListCommission.FrozenColumns = 5;
            this.dgvListCommission.HiddenColumnSortingEnabled = false;
            this.dgvListCommission.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvListCommission_Layout_0.IsCurrentLayout = true;
            dgvListCommission_Layout_0.Key = "MyGrig";
            dgvListCommission_Layout_0.LayoutString = resources.GetString("dgvListCommission_Layout_0.LayoutString");
            this.dgvListCommission.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvListCommission_Layout_0});
            this.dgvListCommission.Location = new System.Drawing.Point(154, 251);
            this.dgvListCommission.Name = "dgvListCommission";
            this.dgvListCommission.RecordNavigator = true;
            this.dgvListCommission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListCommission.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvListCommission.Size = new System.Drawing.Size(475, 89);
            this.dgvListCommission.Sortable = true;
            this.dgvListCommission.TabIndex = 87;
            this.dgvListCommission.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListCommission.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListCommission.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvListCommission.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListCommission.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListCommission.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvListCommission.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvListCommission_ColumnButtonClick);
            // 
            // frmComersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 250);
            this.ClientSize = new System.Drawing.Size(788, 429);
            this.Controls.Add(this.dgvListCommission);
            this.Controls.Add(this.dgvListH);
            this.Controls.Add(this.dgvListB);
            this.Controls.Add(this.pnlViewItemHeder);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmComersList";
            this.Text = "frmComersList";
            this.Load += new System.EventHandler(this.frmComersList_Load);
            this.pnlViewItemHeder.ResumeLayout(false);
            this.pnlViewItemHeder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public GridExEx.GridExEx dgvListB;
        public GridExEx.GridExEx dgvListH;
        public System.Windows.Forms.Panel pnlViewItemHeder;
        public Atf.UI.DateTimeSelector txtDateEnd;
        public DevComponents.DotNetBar.ButtonX btnShowListItems;
        public Atf.UI.DateTimeSelector txtDateStart;
        public DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.ButtonX btnExportToExcel;
        public GridExEx.GridExEx dgvListCommission;
    }
}