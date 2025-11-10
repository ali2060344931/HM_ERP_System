namespace HM_ERP_System.Forms.Accounts.RecevingPayment
{
    partial class frmRecevingPaymentDoc
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
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListH_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column25.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecevingPaymentDoc));
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListH_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column26.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListH_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column27.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListH_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column28.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListH_Layout_0_Reference_4 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column29.ButtonImage");
            Janus.Windows.GridEX.GridEXLayout dgvListB_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListB_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column71.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListB_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column72.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference dgvListB_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column73.ButtonImage");
            this.GroupBoxComersH = new Janus.Windows.EditControls.UIGroupBox();
            this.dgvListH = new GridExEx.GridExEx();
            this.GroupBoxComersB = new Janus.Windows.EditControls.UIGroupBox();
            this.dgvListB = new GridExEx.GridExEx();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxComersH)).BeginInit();
            this.GroupBoxComersH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxComersB)).BeginInit();
            this.GroupBoxComersB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxComersH
            // 
            this.GroupBoxComersH.Controls.Add(this.dgvListH);
            this.GroupBoxComersH.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxComersH.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxComersH.Name = "GroupBoxComersH";
            this.GroupBoxComersH.Size = new System.Drawing.Size(1642, 237);
            this.GroupBoxComersH.TabIndex = 0;
            this.GroupBoxComersH.Text = "حوالـــــــــــــه";
            this.GroupBoxComersH.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            // 
            // dgvListH
            // 
            this.dgvListH.DefaultComment = null;
            this.dgvListH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListH.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvListH.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvListH.FindCondition = null;
            this.dgvListH.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always;
            this.dgvListH.HiddenColumnSortingEnabled = false;
            this.dgvListH.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            dgvListH_Layout_0.IsCurrentLayout = true;
            dgvListH_Layout_0.Key = "MyGrig";
            dgvListH_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("dgvListH_Layout_0_Reference_0.Instance")));
            dgvListH_Layout_0_Reference_1.Instance = ((object)(resources.GetObject("dgvListH_Layout_0_Reference_1.Instance")));
            dgvListH_Layout_0_Reference_2.Instance = ((object)(resources.GetObject("dgvListH_Layout_0_Reference_2.Instance")));
            dgvListH_Layout_0_Reference_3.Instance = ((object)(resources.GetObject("dgvListH_Layout_0_Reference_3.Instance")));
            dgvListH_Layout_0_Reference_4.Instance = ((object)(resources.GetObject("dgvListH_Layout_0_Reference_4.Instance")));
            dgvListH_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            dgvListH_Layout_0_Reference_0,
            dgvListH_Layout_0_Reference_1,
            dgvListH_Layout_0_Reference_2,
            dgvListH_Layout_0_Reference_3,
            dgvListH_Layout_0_Reference_4});
            dgvListH_Layout_0.LayoutString = resources.GetString("dgvListH_Layout_0.LayoutString");
            this.dgvListH.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            dgvListH_Layout_0});
            this.dgvListH.Location = new System.Drawing.Point(3, 24);
            this.dgvListH.Name = "dgvListH";
            this.dgvListH.RecordNavigator = true;
            this.dgvListH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListH.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.dgvListH.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListH.SettingsKey = "frmComersH";
            this.dgvListH.Size = new System.Drawing.Size(1636, 210);
            this.dgvListH.Sortable = true;
            this.dgvListH.TabIndex = 86;
            this.dgvListH.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListH.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListH.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvListH.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListH.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            // 
            // GroupBoxComersB
            // 
            this.GroupBoxComersB.Controls.Add(this.dgvListB);
            this.GroupBoxComersB.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxComersB.Location = new System.Drawing.Point(0, 237);
            this.GroupBoxComersB.Name = "GroupBoxComersB";
            this.GroupBoxComersB.Size = new System.Drawing.Size(1642, 232);
            this.GroupBoxComersB.TabIndex = 0;
            this.GroupBoxComersB.Text = "بارنامــــــــــه";
            this.GroupBoxComersB.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            // 
            // dgvListB
            // 
            this.dgvListB.DefaultComment = null;
            this.dgvListB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListB.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.dgvListB.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.dgvListB.FindCondition = null;
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
            this.dgvListB.Location = new System.Drawing.Point(3, 24);
            this.dgvListB.Name = "dgvListB";
            this.dgvListB.RecordNavigator = true;
            this.dgvListB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvListB.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.dgvListB.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListB.SettingsKey = "frmComersB";
            this.dgvListB.Size = new System.Drawing.Size(1636, 205);
            this.dgvListB.Sortable = true;
            this.dgvListB.TabIndex = 87;
            this.dgvListB.TableHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvListB.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.dgvListB.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.dgvListB.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.dgvListB.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            // 
            // frmRecevingPaymentDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 300);
            this.ClientSize = new System.Drawing.Size(1642, 505);
            this.Controls.Add(this.GroupBoxComersB);
            this.Controls.Add(this.GroupBoxComersH);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmRecevingPaymentDoc";
            this.Text = "لیست اسناد";
            this.Load += new System.EventHandler(this.frmRecevingPaymentDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxComersH)).EndInit();
            this.GroupBoxComersH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBoxComersB)).EndInit();
            this.GroupBoxComersB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox GroupBoxComersH;
        private Janus.Windows.EditControls.UIGroupBox GroupBoxComersB;
        public GridExEx.GridExEx dgvListH;
        public GridExEx.GridExEx dgvListB;
    }
}