namespace HM_ERP_System
{
    partial class ChatGPT
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
            this.TrainingService = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsk
            // 
            this.btnAsk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAsk.Location = new System.Drawing.Point(108, 29);
            this.btnAsk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(148, 26);
            this.btnAsk.TabIndex = 0;
            this.btnAsk.Text = "هوش مصنوعی محلی";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click_1);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.Location = new System.Drawing.Point(3, 1);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(359, 28);
            this.txtQuestion.TabIndex = 1;
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAnswer.Location = new System.Drawing.Point(3, 77);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.Size = new System.Drawing.Size(359, 290);
            this.rtbAnswer.TabIndex = 2;
            this.rtbAnswer.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(160, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 22);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "label1";
            // 
            // TrainingService
            // 
            this.TrainingService.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TrainingService.Location = new System.Drawing.Point(29, 372);
            this.TrainingService.Name = "TrainingService";
            this.TrainingService.Size = new System.Drawing.Size(149, 26);
            this.TrainingService.TabIndex = 4;
            this.TrainingService.Text = "آموزش برنامه";
            this.TrainingService.UseVisualStyleBackColor = true;
            this.TrainingService.Click += new System.EventHandler(this.TrainingService_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(185, 372);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "هوش مصنوعی وب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChatGPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 408);
            this.Controls.Add(this.TrainingService);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAsk);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "ChatGPT";
            this.Text = "هـــوش مصنوعی";
            this.Load += new System.EventHandler(this.ChatGPT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.Carplate carplate1;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button TrainingService;
        private System.Windows.Forms.Button button1;
    }
}