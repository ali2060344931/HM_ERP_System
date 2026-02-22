namespace HM_ERP_System.Forms.Accounts.ReviewAccounts
{
    partial class frmJournal
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
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournal));
            this.dgvList = new GridExEx.GridExEx();
            this.pnlViewItemHeder = new System.Windows.Forms.Panel();
            this.txtDateEnd = new Atf.UI.DateTimeSelector();
            this.btnShowListItems = new DevComponents.DotNetBar.ButtonX();
            this.txtDateStart = new Atf.UI.DateTimeSelector();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtDescription = new Janus.Windows.GridEX.EditControls.EditBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonX01 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnShowGridExHideColumns = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlViewItemHeder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.FrozenColumns = 5;
            this.dgvList.HiddenColumnSortingEnabled = false;
            this.dgvList.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvList_Layout_0.IsCurrentLayout = true;
            dgvList_Layout_0.Key = "MyGrig";
            dgvList_Layout_0.LayoutString = resources.GetString("dgvList_Layout_0.LayoutString");
            this.dgvList.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvList_Layout_0});
            this.dgvList.Location = new System.Drawing.Point(0, 44);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvList.Name = "dgvList";
            this.dgvList.RecordNavigator = true;
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvList.Size = new System.Drawing.Size(1540, 440);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 92;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
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
            this.pnlViewItemHeder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewItemHeder.Name = "pnlViewItemHeder";
            this.pnlViewItemHeder.Size = new System.Drawing.Size(1540, 44);
            this.pnlViewItemHeder.TabIndex = 93;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateEnd.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateEnd.Location = new System.Drawing.Point(576, 7);
            this.txtDateEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateEnd.Size = new System.Drawing.Size(145, 29);
            this.txtDateEnd.TabIndex = 0;
            this.txtDateEnd.UsePersianFormat = true;
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowListItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowListItems.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowListItems.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnShowListItems.Location = new System.Drawing.Point(471, 4);
            this.btnShowListItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowListItems.Name = "btnShowListItems";
            this.btnShowListItems.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnShowListItems.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8);
            this.btnShowListItems.Size = new System.Drawing.Size(98, 35);
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
            this.txtDateStart.Location = new System.Drawing.Point(811, 7);
            this.txtDateStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateStart.Size = new System.Drawing.Size(145, 29);
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
            this.labelX1.Location = new System.Drawing.Point(963, 10);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.labelX2.Location = new System.Drawing.Point(727, 10);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolSize = 12F;
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "تا تاریخ:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtDescription);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.buttonX01);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.btnShowGridExHideColumns);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 48);
            this.panel1.TabIndex = 94;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescription.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
            this.TxtDescription.ButtonText = "کپی";
            this.TxtDescription.Location = new System.Drawing.Point(14, 2);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDescription.MaxLength = 36000000;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(1277, 28);
            this.TxtDescription.TabIndex = 98;
            this.TxtDescription.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.TxtDescription.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(1291, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 18);
            this.label12.TabIndex = 99;
            this.label12.Text = "توضحیات گزارش:";
            this.label12.Visible = false;
            // 
            // buttonX01
            // 
            this.buttonX01.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX01.BackColor = System.Drawing.Color.Transparent;
            this.buttonX01.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX01.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX01.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX01.Location = new System.Drawing.Point(1419, 0);
            this.buttonX01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonX01.Name = "buttonX01";
            this.buttonX01.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX01.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.buttonX01.Size = new System.Drawing.Size(40, 48);
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
            this.buttonX1.Location = new System.Drawing.Point(1459, 0);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9);
            this.buttonX1.Size = new System.Drawing.Size(40, 48);
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
            this.btnShowGridExHideColumns.Location = new System.Drawing.Point(1499, 0);
            this.btnShowGridExHideColumns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowGridExHideColumns.Name = "btnShowGridExHideColumns";
            this.btnShowGridExHideColumns.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnShowGridExHideColumns.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlQ);
            this.btnShowGridExHideColumns.Size = new System.Drawing.Size(41, 48);
            this.btnShowGridExHideColumns.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowGridExHideColumns.Symbol = "59635";
            this.btnShowGridExHideColumns.SymbolColor = System.Drawing.Color.Black;
            this.btnShowGridExHideColumns.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnShowGridExHideColumns.SymbolSize = 15F;
            this.btnShowGridExHideColumns.TabIndex = 6;
            this.btnShowGridExHideColumns.Tooltip = "نمایش ستون های مخفی";
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 532);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlViewItemHeder);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "frmJournal";
            this.Text = "دفتر روزنامه";
            this.Load += new System.EventHandler(this.frmJournal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmJournal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlViewItemHeder.ResumeLayout(false);
            this.pnlViewItemHeder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlViewItemHeder;
        public Atf.UI.DateTimeSelector txtDateEnd;
        public DevComponents.DotNetBar.ButtonX btnShowListItems;
        public Atf.UI.DateTimeSelector txtDateStart;
        public DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.LabelX labelX2;
        public GridExEx.GridExEx dgvList;
        private System.Windows.Forms.Panel panel1;
        private Janus.Windows.GridEX.EditControls.EditBox TxtDescription;
        private System.Windows.Forms.Label label12;
        public DevComponents.DotNetBar.ButtonX buttonX01;
        public DevComponents.DotNetBar.ButtonX buttonX1;
        public DevComponents.DotNetBar.ButtonX btnShowGridExHideColumns;
    }
}