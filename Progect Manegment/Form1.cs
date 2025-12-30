using HM_ERP_System.Forms.Main_Form;

using MySqlX.XDevAPI.Relational;

using Org.BouncyCastle.Asn1.Cmp;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.Design;

using Telerik.WinControls;

namespace HM_ERP_System
{
    public partial class Form1 : frmMasterForm
    {
        DBcontextModel db=new DBcontextModel();
        //private readonly IUIService _aiService;
        private readonly AccountingQueryService _queryService;
        //private AiService _aiService;
        public Form1()
        {
            InitializeComponent();
            //_aiService = new AiService();
            _queryService = new AccountingQueryService();
        }

        private  void btnAsk_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "در حال پردازش...";
                btnAsk.Enabled = false;

                string userQuestion = txtQuestion.Text.Trim();
                if (string.IsNullOrEmpty(userQuestion))
                    return;

                // 1️⃣ تشخیص نوع سؤال
                string sqlResult = _queryService.ExecuteSmartQuery(userQuestion);

                // 2️⃣ ارسال نتیجه به AI برای توضیح انسانی
                //string finalAnswer = await _aiService.AnalyzeResult(userQuestion, sqlResult);

                //rtbAnsweسوr.Text = finalAnswer;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
        }

        private void btnAsk_Click_1(object sender, EventArgs e)
        {
            var repo = new AccountingRepository("_connectionString");
            var ai = new AiQueryService(repo);

            var result = ai.Execute(txtQuestion.Text);

            if (result.IsSuccess)
                rtbAnswer.Text = result.Message;
            else
                MessageBox.Show(result.Message);
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

}
