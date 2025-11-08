namespace HM_ERP_System.Forms.Main_Form
{
    partial class frmAddItems
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
            this.components = new System.ComponentModel.Container();
            this.uiPanelManager1 = new Janus.Windows.UI.Dock.UIPanelManager(this.components);
            this.pnlAddItems = new Janus.Windows.UI.Dock.UIPanel();
            this.pnlAddItemsContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.pnlAddItemBodi = new System.Windows.Forms.Panel();
            this.pnlAddItemFoter = new System.Windows.Forms.Panel();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.pnlViewItems = new Janus.Windows.UI.Dock.UIPanel();
            this.pnlViewItemsContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.pnlViewItemBody = new System.Windows.Forms.Panel();
            this.pnlViewItemHeder = new System.Windows.Forms.Panel();
            this.txtDateEnd = new Atf.UI.DateTimeSelector();
            this.btnShowListItems = new DevComponents.DotNetBar.ButtonX();
            this.txtDateStart = new Atf.UI.DateTimeSelector();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.pnlViewItemFoter = new System.Windows.Forms.Panel();
            this.btnExportToExcel = new DevComponents.DotNetBar.ButtonX();
            this.gridEXExporter1 = new Janus.Windows.GridEX.Export.GridEXExporter(this.components);
            this.buttonX01 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            this.pnlAddItems.SuspendLayout();
            this.pnlAddItemsContainer.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            this.pnlViewItems.SuspendLayout();
            this.pnlViewItemsContainer.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelManager1
            // 
            this.uiPanelManager1.ContainerControl = this;
            this.pnlAddItems.Id = new System.Guid("aa935301-3c91-4523-9466-563997456df4");
            this.uiPanelManager1.Panels.Add(this.pnlAddItems);
            this.pnlViewItems.Id = new System.Guid("7f2269c5-94cb-4267-ae18-44f9e370af61");
            this.uiPanelManager1.Panels.Add(this.pnlViewItems);
            // 
            // Design Time Panel Info:
            // 
            this.uiPanelManager1.BeginPanelInfo();
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("aa935301-3c91-4523-9466-563997456df4"), Janus.Windows.UI.Dock.PanelDockStyle.Right, new System.Drawing.Size(318, 560), true);
            this.uiPanelManager1.AddDockPanelInfo(new System.Guid("7f2269c5-94cb-4267-ae18-44f9e370af61"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(637, 560), true);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("aa935301-3c91-4523-9466-563997456df4"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.AddFloatingPanelInfo(new System.Guid("7f2269c5-94cb-4267-ae18-44f9e370af61"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.uiPanelManager1.EndPanelInfo();
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlAddItems.InnerContainer = this.pnlAddItemsContainer;
            this.pnlAddItems.Location = new System.Drawing.Point(640, 3);
            this.pnlAddItems.Name = "pnlAddItems";
            this.pnlAddItems.Size = new System.Drawing.Size(318, 560);
            this.pnlAddItems.TabIndex = 4;
            this.pnlAddItems.Text = "بخش ثبت اطلاعات";
            this.pnlAddItems.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Center;
            // 
            // pnlAddItemsContainer
            // 
            this.pnlAddItemsContainer.Controls.Add(this.pnlAddItemBodi);
            this.pnlAddItemsContainer.Controls.Add(this.pnlAddItemFoter);
            this.pnlAddItemsContainer.Location = new System.Drawing.Point(5, 27);
            this.pnlAddItemsContainer.Name = "pnlAddItemsContainer";
            this.pnlAddItemsContainer.Size = new System.Drawing.Size(312, 532);
            this.pnlAddItemsContainer.TabIndex = 0;
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.AutoScroll = true;
            this.pnlAddItemBodi.AutoScrollMinSize = new System.Drawing.Size(0, 500);
            this.pnlAddItemBodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddItemBodi.Location = new System.Drawing.Point(0, 0);
            this.pnlAddItemBodi.Name = "pnlAddItemBodi";
            this.pnlAddItemBodi.Size = new System.Drawing.Size(312, 504);
            this.pnlAddItemBodi.TabIndex = 1;
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Controls.Add(this.btnNew);
            this.pnlAddItemFoter.Controls.Add(this.btnSave);
            this.pnlAddItemFoter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 504);
            this.pnlAddItemFoter.Name = "pnlAddItemFoter";
            this.pnlAddItemFoter.Size = new System.Drawing.Size(312, 28);
            this.pnlAddItemFoter.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnNew.Location = new System.Drawing.Point(237, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnNew.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4);
            this.btnNew.Size = new System.Drawing.Size(75, 28);
            this.btnNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNew.Symbol = "57390";
            this.btnNew.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnNew.SymbolSize = 15F;
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "جدید F4";
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
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.SymbolSize = 15F;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ذخیره F5";
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlViewItems.InnerContainer = this.pnlViewItemsContainer;
            this.pnlViewItems.Location = new System.Drawing.Point(3, 3);
            this.pnlViewItems.Name = "pnlViewItems";
            this.pnlViewItems.Size = new System.Drawing.Size(637, 560);
            this.pnlViewItems.TabIndex = 4;
            this.pnlViewItems.Text = "بخش نمایش اطلاعات";
            this.pnlViewItems.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Center;
            // 
            // pnlViewItemsContainer
            // 
            this.pnlViewItemsContainer.Controls.Add(this.pnlViewItemBody);
            this.pnlViewItemsContainer.Controls.Add(this.pnlViewItemHeder);
            this.pnlViewItemsContainer.Controls.Add(this.pnlViewItemFoter);
            this.pnlViewItemsContainer.Location = new System.Drawing.Point(1, 27);
            this.pnlViewItemsContainer.Name = "pnlViewItemsContainer";
            this.pnlViewItemsContainer.Size = new System.Drawing.Size(635, 532);
            this.pnlViewItemsContainer.TabIndex = 0;
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewItemBody.Location = new System.Drawing.Point(0, 50);
            this.pnlViewItemBody.Name = "pnlViewItemBody";
            this.pnlViewItemBody.Size = new System.Drawing.Size(635, 454);
            this.pnlViewItemBody.TabIndex = 3;
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.AutoScroll = true;
            this.pnlViewItemHeder.AutoScrollMinSize = new System.Drawing.Size(400, 0);
            this.pnlViewItemHeder.Controls.Add(this.txtDateEnd);
            this.pnlViewItemHeder.Controls.Add(this.btnShowListItems);
            this.pnlViewItemHeder.Controls.Add(this.txtDateStart);
            this.pnlViewItemHeder.Controls.Add(this.labelX1);
            this.pnlViewItemHeder.Controls.Add(this.labelX2);
            this.pnlViewItemHeder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlViewItemHeder.Location = new System.Drawing.Point(0, 0);
            this.pnlViewItemHeder.Name = "pnlViewItemHeder";
            this.pnlViewItemHeder.Size = new System.Drawing.Size(635, 50);
            this.pnlViewItemHeder.TabIndex = 2;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateEnd.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateEnd.Location = new System.Drawing.Point(194, 12);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateEnd.Size = new System.Drawing.Size(124, 29);
            this.txtDateEnd.TabIndex = 0;
            this.txtDateEnd.UsePersianFormat = true;
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowListItems.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnShowListItems.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnShowListItems.Location = new System.Drawing.Point(104, 15);
            this.btnShowListItems.Name = "btnShowListItems";
            this.btnShowListItems.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnShowListItems.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F8);
            this.btnShowListItems.Size = new System.Drawing.Size(84, 23);
            this.btnShowListItems.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnShowListItems.Symbol = "";
            this.btnShowListItems.SymbolSize = 15F;
            this.btnShowListItems.TabIndex = 2;
            this.btnShowListItems.Text = "نمایش F8";
            // 
            // txtDateStart
            // 
            this.txtDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateStart.CalendarRightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateStart.Location = new System.Drawing.Point(396, 12);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateStart.Size = new System.Drawing.Size(124, 29);
            this.txtDateStart.TabIndex = 0;
            this.txtDateStart.UsePersianFormat = true;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(526, 17);
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
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(324, 17);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolSize = 12F;
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "تا تاریخ:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Controls.Add(this.buttonX01);
            this.pnlViewItemFoter.Controls.Add(this.btnExportToExcel);
            this.pnlViewItemFoter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 504);
            this.pnlViewItemFoter.Name = "pnlViewItemFoter";
            this.pnlViewItemFoter.Size = new System.Drawing.Size(635, 28);
            this.pnlViewItemFoter.TabIndex = 1;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnExportToExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExportToExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportToExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnExportToExcel.Location = new System.Drawing.Point(601, 0);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.btnExportToExcel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F9);
            this.btnExportToExcel.Size = new System.Drawing.Size(34, 28);
            this.btnExportToExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExportToExcel.Symbol = "";
            this.btnExportToExcel.SymbolColor = System.Drawing.Color.Green;
            this.btnExportToExcel.SymbolSize = 15F;
            this.btnExportToExcel.TabIndex = 3;
            this.btnExportToExcel.Tooltip = "خروجی لیست به اکسل F9";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX1
            // 
            this.buttonX01.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX01.BackColor = System.Drawing.Color.Transparent;
            this.buttonX01.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX01.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX01.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX01.Location = new System.Drawing.Point(567, 0);
            this.buttonX01.Name = "buttonX1";
            this.buttonX01.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(8);
            this.buttonX01.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlP);
            this.buttonX01.Size = new System.Drawing.Size(34, 28);
            this.buttonX01.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX01.Symbol = "";
            this.buttonX01.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonX01.SymbolSize = 15F;
            this.buttonX01.TabIndex = 4;
            this.buttonX01.Tooltip = "چاپ جدول";
            // 
            // frmAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 566);
            this.Controls.Add(this.pnlViewItems);
            this.Controls.Add(this.pnlAddItems);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmAddItems";
            this.Text = "frmAddItems";
            this.Load += new System.EventHandler(this.frmAddItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).EndInit();
            this.pnlAddItems.ResumeLayout(false);
            this.pnlAddItemsContainer.ResumeLayout(false);
            this.pnlAddItemFoter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).EndInit();
            this.pnlViewItems.ResumeLayout(false);
            this.pnlViewItemsContainer.ResumeLayout(false);
            this.pnlViewItemHeder.ResumeLayout(false);
            this.pnlViewItemHeder.PerformLayout();
            this.pnlViewItemFoter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Dock.UIPanelManager uiPanelManager1;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer pnlViewItemsContainer;
        private Janus.Windows.UI.Dock.UIPanelInnerContainer pnlAddItemsContainer;
        public System.Windows.Forms.Panel pnlViewItemBody;
        public System.Windows.Forms.Panel pnlViewItemHeder;
        public System.Windows.Forms.Panel pnlViewItemFoter;
        public System.Windows.Forms.Panel pnlAddItemBodi;
        public System.Windows.Forms.Panel pnlAddItemFoter;
        public DevComponents.DotNetBar.ButtonX btnSave;
        public DevComponents.DotNetBar.ButtonX btnNew;
        public Atf.UI.DateTimeSelector txtDateStart;
        public Atf.UI.DateTimeSelector txtDateEnd;
        public DevComponents.DotNetBar.ButtonX btnShowListItems;
        public DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.LabelX labelX1;
        public Janus.Windows.UI.Dock.UIPanel pnlViewItems;
        public Janus.Windows.UI.Dock.UIPanel pnlAddItems;
        public DevComponents.DotNetBar.ButtonX btnExportToExcel;
        private Janus.Windows.GridEX.Export.GridEXExporter gridEXExporter1;
        public DevComponents.DotNetBar.ButtonX buttonX01;
    }
}