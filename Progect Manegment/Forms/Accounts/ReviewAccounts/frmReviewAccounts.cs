using HM_ERP_System.Class_General;
using HM_ERP_System.Forms.Main_Form;

using MyClass;

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
using Janus.Windows.GridEX;
using GridExEx;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HM_ERP_System.Forms.Accounts.ReviewAccounts
{
    public partial class frmReviewAccounts : frmMasterForm, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int ListId_ = 0;


        private GridPrintColumnCollection printColumns;
        private PrintDocument printDoc; // همچنین printDoc


        public frmReviewAccounts(/*IUpdatableForms updatableForms*/)
        {
            InitializeComponent();
            //_updatableForms=updatableForms;


            // ۱. ایجاد PrintDocument
            printDoc = new PrintDocument();

            // ۲. ایجاد مجموعه کلاس چاپ و اتصال Doc به آن
            // این کار رویداد PrintPage را به متد PrintDocument_PrintPage متصل می‌کند.
            printColumns = new GridPrintColumnCollection(printDoc);

            // ۳. اتصال GridEX موجود در فرم
            printColumns.DataGrid = dgvListِDocs;

            // ۴. تنظیم اطلاعات سربرگ
            printColumns.CompanyName = "شرکت مثال برای چاپ";
            printColumns.SystemDate = DateTime.Now.ToShortDateString();
            printColumns.Comment = "گزارش نهایی از داده‌های جدول";

            // تنظیم PageBoundries اولیه در صورت لزوم (اختیاری)
            // printColumns.PageBoundries = new RectangleF(x, y, width, height); 
        }
        bool isactive = false;
        private void frmReviewAccounts_Load(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
            txtDateS.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);
            txtDateE.Value = DateTime.Now;



            isactive=true;
            UpdateData();

        }

        public void UpdateData()
        {

        }
        string TabKey = "";
        private void uiTab1_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            TabKey = uiTab1.SelectedTab.Key;
        }

        void FillAllList()
        {

            FilldgvListG();//گروه
            FilldgvListT();//کل
            FilldgvListS();//معیین
            FilldgvListD();//تفصیلی
            FilldgvListAllAcconts();//تفصیلی
            PublicClass.WindowAlart("1", "بروز رسانی انجام شد.");


            /*
            switch (TabKey)
            {
                case "G":
                    FilldgvListG();//گروه
                    break;
                case "T":
                    FilldgvListT();//کل
                    break;
                case "S":
                    FilldgvListS();//معیین
                    break;
                case "D":
                    FilldgvListD();//تفصیلی
                    break;
                case "AllAcconts":
                    FilldgvListAllAcconts();//تفصیلی
                    break;
            }
            */
        }
        /// <summary>
        /// همه حسابها
        /// </summary>
        private void FilldgvListAllAcconts()
        {
            try
            {
                PublicClass.AllAccountTransactions(dgvListAllAcconts, txtDateS.Text, txtDateE.Text, txtTransactionCodeS.Value, txtTransactionCodeE.Value);
                //dgvListD.AutoSizeColumns();
                PublicClass.SettingGridEX(dgvListAllAcconts);
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(   er);
            }
        }

        /// <summary>
        /// گروه حساب
        /// </summary>
        private void FilldgvListG()
        {
            try
            {
                PublicClass.GroupAccountTransactions(dgvListG, txtDateS.Text, txtDateE.Text, txtTransactionCodeS.Value, txtTransactionCodeE.Value,chkIsBeginningBalanceFilter.Checked);
                dgvListG.AutoSizeColumns();
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// حساب کل
        /// </summary>
        private void FilldgvListT()
        {
            try
            {
                PublicClass.TotalAccountTransactions(dgvListT, txtDateS.Text, txtDateE.Text, txtTransactionCodeS.Value, txtTransactionCodeE.Value,chkIsBeginningBalanceFilter.Checked);
                dgvListT.AutoSizeColumns();
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }
        /// <summary>
        /// حساب معین
        /// </summary>
        private void FilldgvListS_()
        {
            try
            {
                PublicClass.SpecificAccountTransactions(dgvListS, txtDateS.Text, txtDateE.Text, txtTransactionCodeS.Value, txtTransactionCodeE.Value);
                dgvListS.AutoSizeColumns();
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FilldgvListS()
        {
            try
            {
                DataSet ds = PublicClass.SpecificAccountTransactionsTree(txtDateS.Text, txtDateE.Text, txtTransactionCodeS.Value, txtTransactionCodeE.Value, chkShowZeroBalance.Checked);

                if (ds != null)
                {
                    dgvListS.DataMember ="SpecificAccounts";
                    dgvListS.RootTable.ChildTables[0].DataMember = ds.Relations[0].RelationName;
                    dgvListS.DataSource = ds;
                    dgvListS.AutoSizeColumns();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }


        /// <summary>
        /// حساب تفصیلی
        /// </summary>
        private void FilldgvListD()
        {
            try
            {
                DataSet ds = PublicClass.DetailedAccountTransactionsTree(txtDateS.Text, txtDateE.Text, txtTransactionCodeS.Value, txtTransactionCodeE.Value, chkShowZeroBalance.Checked, chkIsBeginningBalanceFilter.Checked);
                if (ds != null)
                {
                    dgvListD.DataMember ="Customers";
                    dgvListD.RootTable.ChildTables[0].DataMember = ds.Relations[0].RelationName;
                    dgvListD.DataSource = ds;
                    dgvListD.AutoSizeColumns();
                }

                PublicClass.SettingGridEX(dgvListD);
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage( er);
            }

        }

        private void btnListRefresh_Click(object sender, EventArgs e)
        {
            FillAllList();
        }

        private void txtTransactionCodeS_ValueChanged(object sender, EventArgs e)
        {
            txtTransactionCodeE.Value=txtTransactionCodeS.Value;
        }

        private void buttonCommand1_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            FillAllList();
        }

        private void ribbonStatusBar1_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {

        }

        private void buttonCommand3_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            dgvListAllAcconts.RootTable.GroupMode=GroupMode.Collapsed;
            FillAllList();
        }

        private void buttonCommand2_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            dgvListAllAcconts.RootTable.GroupMode=GroupMode.Expanded;
            FillAllList();
        }

        private void dgvListAllAcconts_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            try
            {
                ListId = Convert.ToInt32(dgvListAllAcconts.CurrentRow.Cells["Id"].Value);


                if (e.Column.Key == "Transaction")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();
                        //MessageBox.Show(ListId.ToString());

                        List<int> requiredIds = new List<int> { 1, 2, 3, 4, 5 };
                        PublicClass.FilldgvListTransaction(dgvList, txtDateS.Text, txtDateE.Text, requiredIds, ListId, txtTransactionCodeS.Value, txtTransactionCodeE.Value);

                        //uiTab1.SelectedIndex=5;
                        uiTab1.TabPages["List"].Selected=true;

                    }

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void dgvList_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            try
            {
                int TransactionCode = Convert.ToInt32(dgvList.CurrentRow.Cells["TransactionCode"].Value);
                string Date = dgvList.CurrentRow.Cells["TransactionDate"].Value.ToString();

                ListId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);

                if (e.Column.Key == "Transaction")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();

                        PublicClass.FilldgvListTransaction(dgvListِDocs, Date, Date, TransactionCode);
                        lblCode.Text=TransactionCode.ToString();
                        lblDate.Text=Date;
                        uiTab1.TabPages["Doc"].Selected=true;
                    }

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnFinancialYear_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(PublicClass.FinancialYear);
            using (var db = new DBcontextModel())
            {
                var q = db.FinancialYears.Where(c => c.Id==Id).First();
                txtDateS.Text=q.DateStart.ToString();
                txtDateE.Text=q.DateEnd.ToString();
            }
        }

        private void btnThisDay_Click(object sender, EventArgs e)
        {
            txtDateS.Value=DateTime.Now;
            txtDateE.Value=DateTime.Now;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // ۱. پاکسازی و پر کردن ستون‌های جدید
            // این کار ضروری است تا مطمئن شوید ستون‌ها بر اساس GridEX فعلی تنظیم شده‌اند.
            printColumns.Clear();
            printColumns.AddRange(dgvListِDocs);

            // ۲. ایجاد و نمایش دیالوگ پیش‌نمایش چاپ
            try
            {
                // ایجاد شیء دیالوگ
                PrintPreviewDialog previewDialog = new PrintPreviewDialog();

                // اتصال PrintDocument به دیالوگ پیش‌نمایش
                previewDialog.Document = printDoc;

                // تنظیمات ظاهری (اختیاری)
                previewDialog.Text = "پیش‌نمایش چاپ گزارش";
                previewDialog.WindowState = FormWindowState.Maximized; // نمایش در حالت تمام صفحه

                // نمایش دیالوگ
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری پیش‌نمایش چاپ: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListS_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            try
            {
                ListId = Convert.ToInt32(dgvListS.CurrentRow.Cells["Id"].Value);

                if (e.Column.Key == "TransactionP")//Parent
                {
                    using (var db = new DBcontextModel())
                    {
                        try
                        {
                            //var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();
                            List<int> requiredIds = new List<int> { 1, 2, 3, 4, 5 };
                            PublicClass.FilldgvListTransaction(dgvList, txtDateS.Text, txtDateE.Text, requiredIds, 0, txtTransactionCodeS.Value, txtTransactionCodeE.Value, ListId);
                            uiTab1.TabPages["List"].Selected=true;

                        }
                        catch (Exception er)
                        {
                            PublicClass.ShowErrorMessage(er);
                        }
                    }
                }
                else if (e.Column.Key == "TransactionC")//Child
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();
                        List<int> requiredIds = new List<int> { 1, 2, 3, 4, 5 };
                        PublicClass.FilldgvListTransaction(dgvList, txtDateS.Text, txtDateE.Text, requiredIds, ListId, txtTransactionCodeS.Value, txtTransactionCodeE.Value);
                        uiTab1.TabPages["List"].Selected=true;

                    }

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void dgvListD_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            try
            {
                ListId = Convert.ToInt32(dgvListD.CurrentRow.Cells["Id"].Value);

                if (e.Column.Key == "Transaction0")
                {
                    using (var db = new DBcontextModel())
                    {
                        //var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();
                        List<int> requiredIds = new List<int> { 1, 2, 3, 4, 5 };
                        PublicClass.FilldgvListTransactionDA(dgvList, txtDateS.Text, txtDateE.Text, requiredIds, ListId, txtTransactionCodeS.Value, txtTransactionCodeE.Value);

                        uiTab1.TabPages["List"].Selected=true;
                    }

                }
               else if (e.Column.Key == "Transaction")
                {
                    using (var db = new DBcontextModel())
                    {
                        //var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();
                        List<int> requiredIds = new List<int> { 1, 2, 3, 4, 5 };
                        PublicClass.FilldgvListTransaction(dgvList, txtDateS.Text, txtDateE.Text, requiredIds, ListId, txtTransactionCodeS.Value, txtTransactionCodeE.Value);
                        uiTab1.TabPages["List"].Selected=true;
                    }
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void buttonCommand4_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
        }
    }
}
