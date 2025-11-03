namespace HM_ERP_System.Forms.PersonGroup
{
    partial class frmPersonGroup
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
            Janus.Windows.GridEX.GridEXLayout dgvList_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonGroup));
            this.label14 = new System.Windows.Forms.Label();
            this.txtName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.dgvList = new GridExEx.GridExEx();
            this.chkCommission = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.pnlViewItemBody.SuspendLayout();
            this.pnlViewItemHeder.SuspendLayout();
            this.pnlViewItemFoter.SuspendLayout();
            this.pnlAddItemBodi.SuspendLayout();
            this.pnlAddItemFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlViewItemBody
            // 
            this.pnlViewItemBody.Controls.Add(this.dgvList);
            this.pnlViewItemBody.Size = new System.Drawing.Size(394, 338);
            // 
            // pnlViewItemHeder
            // 
            this.pnlViewItemHeder.Size = new System.Drawing.Size(394, 50);
            this.pnlViewItemHeder.Visible = false;
            // 
            // pnlViewItemFoter
            // 
            this.pnlViewItemFoter.Controls.Add(this.label18);
            this.pnlViewItemFoter.Location = new System.Drawing.Point(0, 388);
            this.pnlViewItemFoter.Size = new System.Drawing.Size(394, 28);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.btnExportToExcel, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.buttonX1, 0);
            this.pnlViewItemFoter.Controls.SetChildIndex(this.label18, 0);
            // 
            // pnlAddItemBodi
            // 
            this.pnlAddItemBodi.Controls.Add(this.chkCommission);
            this.pnlAddItemBodi.Controls.Add(this.label14);
            this.pnlAddItemBodi.Controls.Add(this.txtName);
            this.pnlAddItemBodi.Size = new System.Drawing.Size(392, 388);
            // 
            // pnlAddItemFoter
            // 
            this.pnlAddItemFoter.Location = new System.Drawing.Point(0, 388);
            this.pnlAddItemFoter.Size = new System.Drawing.Size(392, 28);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(317, 0);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(161, 12);
            this.txtDateStart.Value = new System.DateTime(2025, 8, 13, 20, 9, 58, 640);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(-41, 12);
            this.txtDateEnd.Value = new System.DateTime(2025, 8, 13, 20, 9, 58, 640);
            // 
            // btnShowListItems
            // 
            this.btnShowListItems.Location = new System.Drawing.Point(-131, 15);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(89, 17);
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(291, 17);
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            // 
            // pnlViewItems
            // 
            this.pnlViewItems.Size = new System.Drawing.Size(396, 444);
            // 
            // pnlAddItems
            // 
            this.pnlAddItems.Location = new System.Drawing.Point(399, 3);
            this.pnlAddItems.Size = new System.Drawing.Size(398, 444);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(360, 0);
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(326, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(312, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 18);
            this.label14.TabIndex = 108;
            this.label14.Text = "نام گروه:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 28);
            this.txtName.TabIndex = 107;
            this.txtName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            // 
            // dgvList
            // 
            this.dgvList.DefaultComment = null;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvList.FindCondition = null;
            this.dgvList.HiddenColumnSortingEnabled = false;
            this.dgvList.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvList_Layout_0.IsCurrentLayout = true;
            dgvList_Layout_0.Key = "MyGrig";
            dgvList_Layout_0.LayoutString = resources.GetString("dgvList_Layout_0.LayoutString");
            this.dgvList.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvList_Layout_0});
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RecordNavigator = true;
            this.dgvList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvList.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.Default;
            this.dgvList.Size = new System.Drawing.Size(394, 338);
            this.dgvList.Sortable = true;
            this.dgvList.TabIndex = 83;
            this.dgvList.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvList.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvList.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvList.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvList.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.dgvList.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.dgvList_ColumnButtonClick);
            // 
            // chkCommission
            // 
            this.chkCommission.AutoSize = true;
            this.chkCommission.Location = new System.Drawing.Point(163, 83);
            this.chkCommission.Name = "chkCommission";
            this.chkCommission.Size = new System.Drawing.Size(143, 26);
            this.chkCommission.TabIndex = 109;
            this.chkCommission.Text = "گروه پورسانت بگیران";
            this.toolTip1.SetToolTip(this.chkCommission, "آیا گروه مورد نظر جزء پورسنات بگیران هستند؟");
            this.chkCommission.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Dock = System.Windows.Forms.DockStyle.Right;
            this.label18.Font = new System.Drawing.Font("Vazir FD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.ForeColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(33, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(293, 18);
            this.label18.TabIndex = 116;
            this.label18.Text = "سطرهای با رنگ سبز جزء گروه های پورسانت بگیران می باشند";
            // 
            // frmPersonGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.KeyPreview = true;
            this.Name = "frmPersonGroup";
            this.Text = "تعریف گروه اشخاص";
            this.Load += new System.EventHandler(this.frmPersonGroup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPersonGroup_KeyDown);
            this.Controls.SetChildIndex(this.pnlAddItems, 0);
            this.Controls.SetChildIndex(this.pnlViewItems, 0);
            this.pnlViewItemBody.ResumeLayout(false);
            this.pnlViewItemHeder.ResumeLayout(false);
            this.pnlViewItemHeder.PerformLayout();
            this.pnlViewItemFoter.ResumeLayout(false);
            this.pnlViewItemFoter.PerformLayout();
            this.pnlAddItemBodi.ResumeLayout(false);
            this.pnlAddItemBodi.PerformLayout();
            this.pnlAddItemFoter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlAddItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private Janus.Windows.GridEX.EditControls.EditBox txtName;
        public GridExEx.GridExEx dgvList;
        private System.Windows.Forms.CheckBox chkCommission;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label18;
    }
}