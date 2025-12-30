namespace HM_ERP_System
{
    partial class Form1
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
            this.btnAsk = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(307, 52);
            this.btnAsk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(91, 26);
            this.btnAsk.TabIndex = 0;
            this.btnAsk.Text = "button1";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click_1);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(428, 50);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(100, 28);
            this.txtQuestion.TabIndex = 1;
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.Location = new System.Drawing.Point(428, 102);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.Size = new System.Drawing.Size(100, 96);
            this.rtbAnswer.TabIndex = 2;
            this.rtbAnswer.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(470, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 22);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 392);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnAsk);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.Carplate carplate1;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.Label lblStatus;
    }
}