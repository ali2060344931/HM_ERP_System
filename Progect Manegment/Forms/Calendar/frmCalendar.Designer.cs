namespace HM_ERP_System.Forms.Calendar
{
    partial class frmCalendar
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
            this.dateTimeSelector1 = new Atf.UI.DateTimeSelector();
            this.SuspendLayout();
            // 
            // dateTimeSelector1
            // 
            this.dateTimeSelector1.Location = new System.Drawing.Point(93, 107);
            this.dateTimeSelector1.Name = "dateTimeSelector1";
            this.dateTimeSelector1.Size = new System.Drawing.Size(128, 21);
            this.dateTimeSelector1.TabIndex = 0;
            // 
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 278);
            this.Controls.Add(this.dateTimeSelector1);
            this.Name = "frmCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Atf.UI.DateTimeSelector dateTimeSelector1;
    }
}