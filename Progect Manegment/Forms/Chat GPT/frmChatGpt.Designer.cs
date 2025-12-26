namespace HM_ERP_System.Forms.Chat_GPT
{
    partial class frmChatGpt
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(77, 10);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(75, 23);
            this.btnAsk.TabIndex = 0;
            this.btnAsk.Text = "button1";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(170, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "lblStatus";
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.Location = new System.Drawing.Point(173, 51);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.Size = new System.Drawing.Size(240, 349);
            this.rtbAnswer.TabIndex = 2;
            this.rtbAnswer.Text = "";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(173, 12);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(100, 20);
            this.txtQuestion.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChatGpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAsk);
            this.Name = "frmChatGpt";
            this.Text = "frmChatGpt";
            this.Load += new System.EventHandler(this.frmChatGpt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button button1;
    }
}