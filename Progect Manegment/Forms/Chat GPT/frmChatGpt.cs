using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Chat_GPT
{
    public partial class frmChatGpt : Form
    {
        private readonly AiService _aiService;
        private readonly AccountingQueryService _queryService;
        public frmChatGpt()
        {
            InitializeComponent();
            _aiService = new AiService();
            _queryService = new AccountingQueryService();
        }

        private void frmChatGpt_Load(object sender, EventArgs e)
        {


        }

        private async void btnAsk_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "در حال پردازش...";
            btnAsk.Enabled = false;

            try
            {
                string question = txtQuestion.Text.Trim();
                if (string.IsNullOrEmpty(question))
                    return;

                string sqlResult = _queryService.ExecuteSmartQuery(question);

                string answer = await _aiService.AnalyzeResult(question, sqlResult);

                rtbAnswer.Text = answer;
                lblStatus.Text = "آماده";
            }
            catch (Exception ex)
            {
                rtbAnswer.Text = ex.Message;
                lblStatus.Text = "خطا";
            }
            finally
            {
                btnAsk.Enabled = true;
            }
        }

        public class AccountingQueryService
        {
            public string ExecuteSmartQuery(string question)
            {
                question = question.ToLower();

                if (question.Contains("بدهکارترین"))
                {
                    return GetTopDebtor();
                }
                else if (question.Contains("فروش") && question.Contains("ماه"))
                {
                    return GetCurrentMonthSales();
                }

                return "داده‌ای برای این سؤال یافت نشد.";
            }

            private string GetTopDebtor()
            {
                // نمونه ساده (در عمل از DAL استفاده کن)
                return "مشتری: شرکت آلفا | مانده بدهی: 1,250,000,000 ریال";
            }

            private string GetCurrentMonthSales()
            {
                return "مجموع فروش این ماه: 8,450,000,000 ریال";
            }
        }

        private async  void button1_Click(object sender, EventArgs e)
        {
            rtbAnswer.Text = await _aiService.TestApiKeyAsync();
        }
    }
}
