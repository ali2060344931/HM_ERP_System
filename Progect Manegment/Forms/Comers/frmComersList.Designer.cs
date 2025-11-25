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
            this.btnShowListItems = new DevComponents.DotNetBar.ButtonX();
            this.txtDateStart = new Atf.UI.DateTimeSelector();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgvListH = new GridExEx.GridExEx();
            this.dgvListB = new GridExEx.GridExEx();
            this.dgvListCommission = new GridExEx.GridExEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonX01 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnShowGridExHideColumns = new DevComponents.DotNetBar.ButtonX();
            this.TxtDescription = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlViewItemHeder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommission)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.AutoScroll = true;
            this.pnlViewItemHeder.AutoScrollMinSize = new System.Drawing.Size(400, 0);
            this.pnlViewItemHeder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewItemHeder.Controls.Add(this.txtDateEnd);
            this.pnlViewItemHeder.Controls.Add(this.btnShowListItems);
            this.pnlViewItemHeder.Controls.Add(this.txtDateStart);
            this.pnlViewItemHeder.Controls.Add(this.labelX1);
            this.pnlViewItemHeder.Controls.Add(this.labelX2);
            this.pnlViewItemHeder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlViewItemHeder.Location = new System.Drawing.Point(0, 0);
            this.pnlViewItemHeder.Name = "pnlViewItemHeder";
            this.pnlViewItemHeder.Size = new System.Drawing.Size(1027, 50);
            this.pnlViewItemHeder.TabIndex = 88;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateEnd.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateEnd.Location = new System.Drawing.Point(339, 12);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateEnd.Size = new System.Drawing.Size(124, 29);
            this.txtDateEnd.TabIndex = 0;
            this.txtDateEnd.UsePersianFormat = true;
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowListItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowListItems.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowListItems.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnShowListItems.Location = new System.Drawing.Point(249, 15);
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
            this.txtDateStart.Location = new System.Drawing.Point(541, 12);
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
            this.labelX1.Location = new System.Drawing.Point(671, 17);
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
            this.labelX2.Location = new System.Drawing.Point(469, 17);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtDescription);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.buttonX01);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.btnShowGridExHideColumns);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 31);
            this.panel1.TabIndex = 89;
            // 
            // buttonX01
            // 
            this.buttonX01.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX01.BackColor = System.Drawing.Color.Transparent;
            this.buttonX01.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX01.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX01.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX01.Location = new System.Drawing.Point(924, 0);
            this.buttonX01.Name = "buttonX01";
            this.buttonX01.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX01.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.buttonX01.Size = new System.Drawing.Size(34, 31);
            this.buttonX01.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX01.Symbol = "";
            this.buttonX01.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX01.SymbolSize = 15F;
            this.buttonX01.TabIndex = 8;
            this.buttonX01.Tooltip = "چاپ جدول";
            this.buttonX01.Click += new System.EventHandler(this.buttonX01_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(958, 0);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9);
            this.buttonX1.Size = new System.Drawing.Size(34, 31);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.Green;
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Tooltip = "خروجی لیست به اکسل F9";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnShowGridExHideColumns
            // 
            this.btnShowGridExHideColumns.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowGridExHideColumns.BackColor = System.Drawing.Color.Transparent;
            this.btnShowGridExHideColumns.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowGridExHideColumns.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowGridExHideColumns.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(992, 0);
            this.btnShowGridExHideColumns.Name = "btnShowGridExHideColumns";
            this.btnShowGridExHideColumns.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnShowGridExHideColumns.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlQ);
            this.btnShowGridExHideColumns.Size = new System.Drawing.Size(35, 31);
            this.btnShowGridExHideColumns.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowGridExHideColumns.Symbol = "59635";
            this.btnShowGridExHideColumns.SymbolColor = System.Drawing.Color.Black;
            this.btnShowGridExHideColumns.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnShowGridExHideColumns.SymbolSize = 15F;
            this.btnShowGridExHideColumns.TabIndex = 6;
            this.btnShowGridExHideColumns.Tooltip = "نمایش ستون های مخفی";
            this.btnShowGridExHideColumns.Click += new System.EventHandler(this.btnShowGridExHideColumns_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescription.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
            this.TxtDescription.ButtonText = "کپی";
            this.TxtDescription.Location = new System.Drawing.Point(12, 1);
            this.TxtDescription.MaxLength = 36000000;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(801, 28);
            this.TxtDescription.TabIndex = 98;
            this.TxtDescription.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.TxtDescription.ButtonClick += new System.EventHandler(this.TxtDescription_ButtonClick);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(813, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 99;
            this.label12.Text = "توضحیات گزارش:";
            // 
            // frmComersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 250);
            this.ClientSize = new System.Drawing.Size(1027, 429);
            this.Controls.Add(this.dgvListCommission);
            this.Controls.Add(this.dgvListH);
            this.Controls.Add(this.dgvListB);
            this.Controls.Add(this.pnlViewItemHeder);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmComersList";
            this.Text = "frmComersList";
            this.Load += new System.EventHandler(this.frmComersList_Load);
            this.pnlViewItemHeder.ResumeLayout(false);
            this.pnlViewItemHeder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCommission)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        public GridExEx.GridExEx dgvListCommission;
        private System.Windows.Forms.Panel panel1;
        public DevComponents.DotNetBar.ButtonX btnShowGridExHideColumns;
        public DevComponents.DotNetBar.ButtonX buttonX01;
        public DevComponents.DotNetBar.ButtonX buttonX1;
        private Janus.Windows.GridEX.EditControls.EditBox TxtDescription;
        private System.Windows.Forms.Label label12;
    }
}