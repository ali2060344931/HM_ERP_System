using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.FinancialYear;
using HM_ERP_System.Entity.TypeDocument;
using HM_ERP_System.Forms.Accounts.DetailedAccount;
using HM_ERP_System.Forms.Accounts.SpecificAccount;
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
using System.Transactions;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using HM_ERP_System.Entity.Accounts.Cheque;
using HM_ERP_System.Entity.Accounts.TransactionType;
using HM_ERP_System.Entity.Accounts.DetailedAccount;
using Janus.Windows.UI.Dock;
using Janus.Windows.UI.Tab;
using Microsoft.Office.Interop.Excel;
using HM_ERP_System.Forms.Accounts.ContraAccounts;
using System.Windows.Controls;
using HM_ERP_System.Forms.Accounts.Banck;
using DataTable = System.Data.DataTable;

namespace HM_ERP_System.Forms.Accounts.RecevingPayment
{
    public partial class frmRecevingPaymentNew : frmMasterForm, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int ListId_ = 0;
        int UserId_ = PublicClass.UserId;
        System.Data.DataTable dt_MultipleAccount;
        public System.Data.DataTable dt_Cheque1;
        public System.Data.DataTable dt_Cheque2;

        public frmRecevingPaymentNew(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmRecevingPaymentNew_Load(object sender, EventArgs e)
        {
            int width = 400;
            //uiPanel3.Width=panel1.Width;
            panel2.Width=width;
            panel5.Width=width;
            panel7.Width=width;
            txtTransactionDate.Value = DateTime.Now;
            txtDueDate.Value = DateTime.Now;
            txtTransactionCode.Text=PublicClass.CreatTransactionCode();

            txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);
            txtDateEnd.Value = DateTime.Now;
            WindowState = FormWindowState.Maximized;

            rdbIncomr.Checked=true;
            AddColumnsToDataTable();// افزودن ستون به جدول ها
            UpdateData();
        }

        public void UpdateData()
        {
            FilldgvListMulti();
            FillcmbBanck();
            FilldgvListCheque1();
            FilltxtBankName();
            FilltxtChequeOwner();
            FilltxtDescription();
            FillcmbListCheque();
            FillcmbDetailedAccountsTo();
            FilldgvList();

        }
        System.Data.DataTable dt_Banck;
        private void FillcmbBanck()
        {

            using (var db = new DBcontextModel())
            {
                var q = from bb in db.BankBranches
                        join ba in db.Bancks
                        on bb.BanckId equals ba.Id
                        select new
                        {
                            bb.Id,
                            bb.Name,
                            BanckName = ba.Name,
                        };
                cmbBanck.DataSource=q.ToList();
                dt_Banck=new System.Data.DataTable();
                dt_Banck=PublicClass.AddEntityTableToDataTable(q.ToList());
            }

            //using (var db = new DBcontextModel())
            //{
            //    var q = from ba in db.Bancks
            //            select new
            //            {
            //                ba.Id,
            //                name = ba.Name/*+"-"+ba.BranchName*/,
            //                //ba.BranchName,

            //            };
            //    cmbBanck.DataSource=q.ToList();
            //    dt_Banck=new System.Data.DataTable();
            //    dt_Banck=PublicClass.AddEntityTableToDataTable(q.ToList());
            //}
        }

        void FilltxtBankName()
        {
            //ToDo AutoCompleteMode TextBox
            /*
            using (var db = new DBcontextModel())
            {
                txtBankName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtBankName.AutoCompleteSource=AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                var q = db.Cheques.ToList();
                foreach (var i in q)
                {
                    a.Add(i.BankName);
                }
                txtBankName.AutoCompleteCustomSource=a;
            }
            */
        }
        void FilltxtChequeOwner()
        {
            using (var db = new DBcontextModel())
            {
                txtChequeOwner.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtChequeOwner.AutoCompleteSource=AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                var q = db.Cheques.ToList();
                foreach (var i in q)
                {
                    a.Add(i.ChequeOwner);
                }
                txtChequeOwner.AutoCompleteCustomSource=a;
            }
        }
        void FilltxtDescription()
        {
            using (var db = new DBcontextModel())
            {
                txtDescriptionCa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtDescriptionCa.AutoCompleteSource=AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                var q = db.Cheques.ToList();
                foreach (var i in q)
                {
                    a.Add(i.Description);
                }
                txtDescriptionCa.AutoCompleteCustomSource=a;
            }
        }
        System.Data.DataTable dt_ListCheque;
        void FillcmbListCheque()
        {
            using (var db = new DBcontextModel())
            {
                var q = from ch in db.Cheques

                        join da in db.DetailedAccounts
                        on ch.Payer_Payee_AccId equals da.Id

                        join cu in db.Customers
                        on da.CustomerId equals cu.Id

                        join cha in db.ChequeStatuses
                        on ch.CurrentStatusID equals cha.Id
                        where ch.ChequeTypeId==1  && cha.StatusCodeId==2

                        select new
                        {
                            ch.Id,
                            ch.ChequeNumber,
                            ch.DueDate,
                            //ch.BankName,
                            ch.ChequeOwner,
                            ch.Description,
                            ch.Amount,
                            Payer_Payee_Acc_Name = (cu.Family.Trim() + " "+ cu.Name.Trim()).Trim(),
                        };
                cmbListCheque.DataSource=q.ToList();
                //cmbListCheque.DropDownList.AutoSizeColumns();
                dt_ListCheque = new System.Data.DataTable();
                dt_ListCheque = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }


        //ToDo باشد جهت نمایش در دیتاگرید Null یک جدول صفر0 یا  Id وقتی مقدار
        private void FilldgvList()
        {
            List<int> requiredIds = new List<int> { 4, 5 };

            PublicClass.FilldgvListTransaction(dgvList, txtDateStart.Text, txtDateEnd.Text, requiredIds);
        }

        System.Data.DataTable dt_TypeDocument;
        private void FillcmbTypeDocument(int Id)
        {
            using (var db = new DBcontextModel())
            {
                var q = from spag in db.SpecificAccountsGroups
                        join spf in db.SpecificAccounts
                        on spag.SpecificAccountIdF equals spf.Id
                        //join spt in db.SpecificAccounts
                        //on spag.SpecificAccountIdT equals spt.Id
                        where spag.TransactionTypeId==Id
                        orderby spag.Name
                        select new
                        {
                            spag.Id,
                            spag.Name,
                            SpecificAccountF = spf.Name,
                            //SpecificAccountT = spt.Name,

                        };
                cmbTypeDocument.DataSource=q.ToList();
                dt_TypeDocument = new System.Data.DataTable();
                dt_TypeDocument = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }
        System.Data.DataTable dt_SpecificAccountF;
        /// <summary>
        /// دریافت از
        /// </summary>
        private void FillcmbSpecificAccountF(int Code)
        {
            using (var db = new DBcontextModel())
            {
                var q = from sp in db.SpecificAccounts

                        join ta in db.TotalAccounts
                        on sp.Id_TotalAccount equals ta.Id

                        where (int)sp.Cod/1000!=Code && sp.Status
                        select new
                        {
                            sp.Id,
                            sp.Name,
                            Code = sp.Cod,
                            TotalAccountName = ta.Name,
                        };

                cmbSpecificAccountFrom.DataSource = q.ToList();

                dt_SpecificAccountF = new System.Data.DataTable();
                dt_SpecificAccountF = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }

        System.Data.DataTable dt_DetailedAccountsFrom;
        private void FillcmbContraAccountF(int SpecificAccountId_)
        {
            using (var db = new DBcontextModel())
            {
                var q = from dt in db.DetailedAccounts

                        join cu in db.Customers
                        on dt.CustomerId equals cu.Id

                        join tc in db.TypeCustomers
                        on cu.id_TypeCustomer equals tc.Id

                        where dt.SpecificAccountId==SpecificAccountId_
                        select new
                        {
                            dt.Id,
                            name = (cu.Family+" "+cu.Name).Trim(),
                            TypeAccount = tc.Name,
                            AccountCode = dt.CodeAccount,
                            CodeMeli=cu.CodMeli,
                        };
                cmbDetailedAccountsFrom.DataSource= q.ToList();

                dt_DetailedAccountsFrom = new System.Data.DataTable();
                dt_DetailedAccountsFrom = PublicClass.AddEntityTableToDataTable(q.ToList());
            }

        }

        void FilldgvListMulti()
        {
            dgvListMulti.DataSource= dt_MultipleAccount;
        }
        void FilldgvListCheque1()
        {
            dgvListCheque1.DataSource= dt_Cheque1;
        }
        void FilldgvListCheque2()
        {
            dgvListCheque2.DataSource= dt_Cheque2;
        }

        System.Data.DataTable dt_SpecificAccountTo;
        /// <summary>
        /// لیست حساب های معین
        /// </summary>
        /// <param name="Code"> 60 Or 80</param>

        /// <summary>
        /// افزودن ستون به جدول ها
        /// </summary>
        void AddColumnsToDataTable()
        {
            dt_MultipleAccount=new System.Data.DataTable();
            dt_MultipleAccount.Columns.Add("SpecificAccountId", typeof(int));
            dt_MultipleAccount.Columns.Add("DetailedAccountId", typeof(int));
            dt_MultipleAccount.Columns.Add("SpecificAccount", typeof(string));
            dt_MultipleAccount.Columns.Add("DetailedAccount", typeof(string));
            dt_MultipleAccount.Columns.Add("Amount1", typeof(long));
            dt_MultipleAccount.Columns.Add("Amount2", typeof(long));
            dt_MultipleAccount.Columns.Add("SeryalNumber", typeof(string));
            dt_MultipleAccount.Columns.Add("Des", typeof(string));

            dt_Cheque1=new System.Data.DataTable();
            dt_Cheque1.Columns.Add("ChequeNumber", typeof(string));
            dt_Cheque1.Columns.Add("BankId", typeof(int));
            dt_Cheque1.Columns.Add("BankName", typeof(string));
            dt_Cheque1.Columns.Add("ChequeOwner", typeof(string));
            dt_Cheque1.Columns.Add("DueDate", typeof(string));
            dt_Cheque1.Columns.Add("Amount", typeof(long));
            dt_Cheque1.Columns.Add("Description", typeof(string));
            DataColumn productColumn1 = dt_Cheque1.Columns["ChequeNumber"];
            dt_Cheque1.PrimaryKey = new DataColumn[] { productColumn1 };


            dt_Cheque2=new System.Data.DataTable();
            dt_Cheque2.Columns.Add("Id", typeof(int));
            dt_Cheque2.Columns.Add("ChequeNumber", typeof(string));
            dt_Cheque2.Columns.Add("Payer_Payee_Acc_Id", typeof(int));
            dt_Cheque2.Columns.Add("Payer_Payee_Acc_Name", typeof(string));
            dt_Cheque2.Columns.Add("BankName", typeof(string));
            dt_Cheque2.Columns.Add("ChequeOwner", typeof(string));
            dt_Cheque2.Columns.Add("DueDate", typeof(string));
            dt_Cheque2.Columns.Add("Amount", typeof(long));
            dt_Cheque2.Columns.Add("Description", typeof(string));

            DataColumn productColumn2 = dt_Cheque2.Columns["Id"];
            dt_Cheque2.PrimaryKey = new DataColumn[] { productColumn2 };
        }

        private void dgvListMulti_InitCustomEdit(object sender, Janus.Windows.GridEX.InitCustomEditEventArgs e)
        {
            //if (e.Column.Key=="SpecificAccount")
            //{
            //    if (e.Value==null)
            //    {
            //        cmbSpecificAccountTo.SelectedIndex=-1;
            //    }
            //    else
            //    {
            //        cmbSpecificAccountTo.Text=e.Value.ToString();
            //    }
            //    e.EditControl=cmbSpecificAccountTo;
            //}
            //else if (e.Column.Key=="DetailedAccount")
            //{
            //    if (e.Value==null)
            //    {
            //        cmbDetailedAccountsTo.SelectedIndex=-1;
            //    }
            //    else
            //    {
            //        cmbDetailedAccountsTo.Text=e.Value.ToString();
            //    }

            //    e.EditControl=cmbDetailedAccountsTo;

            //}
            //else if (e.Column.Key=="Amount1")
            //{
            //    if (e.Value==null)
            //    {
            //        txtAmount1.ResetText();
            //    }
            //    else
            //    {
            //        txtAmount1.Text=e.Value.ToString();
            //    }

            //    e.EditControl=txtAmount1;

            //}
            //else if (e.Column.Key=="Amount2")
            //{
            //    if (e.Value==null)
            //    {
            //        txtAmount2.ResetText();
            //    }
            //    else
            //    {
            //        txtAmount2.Text=e.Value.ToString();
            //    }
            //    e.EditControl=txtAmount2;
            //}
        }

        private void dgvListMulti_EndCustomEdit(object sender, Janus.Windows.GridEX.EndCustomEditEventArgs e)
        {
            //try
            //{
            //    if (e.Column.Key=="SpecificAccount")
            //    {
            //        if (cmbSpecificAccountTo.SelectedIndex!=-1)
            //        {
            //            dgvListMulti.GetRow().Cells["SpecificAccountId"].Value=cmbSpecificAccountTo.Value;
            //            e.Value=cmbSpecificAccountTo.Text;
            //        }
            //        else
            //        {
            //            dgvListMulti.GetRow().Cells["SpecificAccountId"].Value=null;
            //            e.Value=null;
            //        }
            //    }
            //    else if (e.Column.Key=="DetailedAccount")
            //    {
            //        if (cmbDetailedAccountsTo.SelectedIndex!=-1)
            //        {
            //            dgvListMulti.GetRow().Cells["DetailedAccountId"].Value=cmbDetailedAccountsTo.Value;
            //            e.Value=cmbDetailedAccountsTo.Text;
            //        }
            //        else
            //        {
            //            dgvListMulti.GetRow().Cells["DetailedAccountId"].Value=null;
            //            e.Value=null;

            //        }
            //    }
            //    else if (e.Column.Key=="Amount1")
            //    {
            //        if (txtAmount1.Text!="")
            //        {
            //            e.Value=txtAmount1.TextSimple;
            //            CalcTotalAmountAddToItems();
            //        }

            //        else
            //            e.Value=0;

            //    }
            //    else if (e.Column.Key=="Amount2")
            //    {
            //        if (txtAmount2.Text!="")
            //        {
            //            e.Value=txtAmount2.TextSimple;
            //            CalcTotalAmountAddToItems();
            //        }

            //        else
            //            e.Value=0;
            //    }

            //}
            //catch (Exception)
            //{

            //}
        }

        string CheangRDB_ = "";
        private void rdbIncomr_CheckedChanged(object sender, EventArgs e)
        {
            CheangRDB_="rdbIncomr";
            if (rdbIncomr.Checked) CheangRDB(CheangRDB_);
        }

        void CheangRDB(string Code)
        {
            if (Code=="rdbIncomr")//دریافت
            {
                //FillcmbSpecificAccountT(60);
                FillcmbTypeDocument(4);
                FillcmbSpecificAccountF(80);

                TransactionsCode=4;
                pnlFrom.Text="دریافت از";
                pnlTo.Text="پــرداخت به";
                lblInOut.Symbol="";
                lblInOut.SymbolColor=System.Drawing.Color.Green;
                //lblFrom.ForeColor=Color.Green;
                //lblTo.ForeColor=Color.Green;
                txtAmount2.Enabled=false;
                txtAmount2.ResetText();
                txtChequeOwner.Enabled=true;
                uiTab1.TabPages["Documents"].TabVisible=false;
            }
            else if (Code=="rdbExpense")//پرداخت
            {
                //FillcmbSpecificAccountT(80);
                FillcmbTypeDocument(5);
                FillcmbSpecificAccountF(60);

                TransactionsCode=5;
                pnlFrom.Text="پرداخت به";
                pnlTo.Text="دریافت از";
                lblInOut.Symbol="";
                lblInOut.SymbolColor=System.Drawing.Color.Red;
                //lblFrom.ForeColor=Color.Red;
                //lblTo.ForeColor=Color.Red;
                txtAmount2.Enabled=true;
                uiTab1.TabPages["Documents"].TabVisible=true;
                txtChequeOwner.Enabled=false;
            }
            else if (Code=="rdbTransferToCustomers")
            {
                MessageBox.Show("TestC");
            }
            else if (Code=="rdbTransferToBanck")
            {
                MessageBox.Show("TestB");

            }
            cmbTypeDocument.ResetText();
            CelearItems();
            FilldgvListMulti();
            FilldgvListCheque1();

        }

        int SpecificAccountIdT;

        System.Data.DataTable dt_DetailedAccountsTo;
        private void FillcmbDetailedAccountsTo()
        {
            string FinancialYear = PublicClass.FinancialYear;

            using (var db = new DBcontextModel())
            {
                // 1. استخراج ID حساب‌های معین (با ایمنی در برابر Null)
                var sac = db.SpecificAccounts.FirstOrDefault(c => c.Cod == 10101)?.Id; // صندوق
                var sab = db.SpecificAccounts.FirstOrDefault(c => c.Cod == 10102)?.Id; // بانک

                // 2. فیلتر کردن تراکنش‌های جاری و معتبر برای افزایش عملکرد
                var currentYearTransactions = db.Transactions
                                                .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                // بررسی وجود حداقل یکی از حساب‌های معین
                if (sac == null && sab == null)
                {
                    // در صورت عدم وجود حساب‌ها، لیستی خالی برگردانده شود.
                    cmbDetailedAccountsTo.DataSource = new List<object>();
                    return;
                }

                var q = from dt in db.DetailedAccounts

                        join cu in db.Customers
                        on dt.CustomerId equals cu.Id

                        join tc in db.TypeCustomers
                        on cu.id_TypeCustomer equals tc.Id

                        // Left Join با تراکنش‌های فیلترشده در سال جاری
                        join tr in currentYearTransactions
                        on dt.Id equals tr.DetailedAccountId
                        into trGroup

                        // 3. اعمال شرط فیلتر بر روی حساب‌های تفصیلی
                        where dt.SpecificAccountId == sac || dt.SpecificAccountId == sab

                        // 4. محاسبه گردش‌ها
                        let DebitTurnover = trGroup.Sum(t => (double?)t.PaymentBed) ?? 0.0
                        let CreditTurnover = trGroup.Sum(t => (double?)t.PaymentBes) ?? 0.0

                        // 5. محاسبه مانده نهایی (با فرض ماهیت بدهکار بودن (Nature = 1) صندوق/بانک)
                        // مانده نهایی = مانده اول دوره + بدهکار - بستانکار
                        let AccountBalance =  DebitTurnover - CreditTurnover

                        select new
                        {
                            dt.Id,
                            name = (cu.Family + " " + cu.Name).Trim(),
                            TypeAccount = tc.Name,
                            AccountCode = dt.CodeAccount,

                            // 6. نمایش مانده نهایی محاسبه شده
                            AccountBalance = AccountBalance
                        };

                cmbDetailedAccountsTo.DataSource = q.ToList();

                // برای تکمیل کد شما
                dt_DetailedAccountsTo = new System.Data.DataTable();
                dt_DetailedAccountsTo = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
            /*
            string FinancialYear = PublicClass.FinancialYear;
            using (var db = new DBcontextModel())
            {
                var sac = db.SpecificAccounts.Where(c => c.Cod==10101).First().Id;
                var sab = db.SpecificAccounts.Where(c => c.Cod==10102).First().Id;
                var q = from dt in db.DetailedAccounts

                        join cu in db.Customers
                        on dt.CustomerId equals cu.Id

                        join tc in db.TypeCustomers
                        on cu.id_TypeCustomer equals tc.Id

                        join tr in db.Transactions
                        on dt.Id equals tr.DetailedAccountId
                        into trGroup

                        where dt.SpecificAccountId==sac || dt.SpecificAccountId==sab

                        select new
                        {
                            dt.Id,
                            name = (cu.Family+" "+cu.Name).Trim(),
                            TypeAccount = tc.Name,
                            AccountCode = dt.CodeAccount,

                            AccountBalance =  (trGroup.Sum(t => (double?)t.PaymentBes) ?? 0.0) - (trGroup.Where(c => c.FinancialYear == FinancialYear && !c.Status).Sum(t => (double?)t.PaymentBed) ?? 0.0)
                        };

                cmbDetailedAccountsTo.DataSource= q.ToList();

                dt_DetailedAccountsTo = new System.Data.DataTable();
                dt_DetailedAccountsTo = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
            */
        }

        private void dgvListMulti_AddingRecord(object sender, CancelEventArgs e)
        {
            //int i = 0;
            //if (dgvListMulti.GetRow().Cells["SpecificAccount"].Value==DBNull.Value)
            //    i++;
            //if (dgvListMulti.GetRow().Cells["DetailedAccount"].Value==DBNull.Value)
            //    i++;
            //if (dgvListMulti.GetRow().Cells["Amount1"].Value == DBNull.Value)
            //    i++;
            //if (dgvListMulti.GetRow().Cells["Des"].Value == DBNull.Value)
            //    i++;
            //if (i!=0)
            //{
            //    PublicClass.ErrorMesseg(ResourceCode.T029);
            //    e.Cancel = true;
            //}

            //CalcTotalAmountAddToItems();

            /*
            object c1 = null;
            object c2 = null;
            object c3 = null;
            object c4 = null;
            c1 = dgvListMulti.GetRow().Cells["SpecificAccount"].Value;
            c2 = dgvListMulti.GetRow().Cells["DetailedAccount"].Value;
            c3 = dgvListMulti.GetRow().Cells["Amount1"].Value;
            //c3 = dgvListMulti.GetRow().Cells["Amount1"].Value;
            c4 = dgvListMulti.GetRow().Cells["Des"].Value;

            if (c1== DBNull.Value ||
                 c2== DBNull.Value ||
                 c3== DBNull.Value ||
                 c4== DBNull.Value
                )
            {
                PublicClass.ErrorMesseg(ResourceCode.T029);
                e.Cancel = true;

            }
            */
        }


        private void cmbDetailedAccountsTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDetailedAccountsTo, dt_DetailedAccountsTo);

            }

        }

        int TypeDocumentId = 0;

        private void cmbTypeDocument_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTypeDocument.SelectedIndex!=-1)
                {
                    TypeDocumentId = Convert.ToInt32(cmbTypeDocument.Value);
                    using (var db = new DBcontextModel())
                    {
                        var q = db.SpecificAccountsGroups.Where(c => c.Id==TypeDocumentId).First();
                        cmbSpecificAccountFrom.Value=q.SpecificAccountIdF;
                        //cmbSpecificAccountTo.Value=q.SpecificAccountIdT;
                        cmbDetailedAccountsFrom.Focus();
                    }
                }
                else
                {
                    CelearItems();
                }

            }
            catch (Exception)
            {
            }
        }

        private void CelearItems()
        {
            try
            {
                txtTransactionCode.Text=PublicClass.CreatTransactionCode();
                cmbSpecificAccountFrom.ResetText();
                cmbDetailedAccountsFrom.ResetText();
                cmbDetailedAccountsTo.ResetText();
                txtDescription.ResetText();
                lblAccountBalancF.ResetText();
                dgvListMulti.DataSource=dt_MultipleAccount;
                ListId=0;
                cmbTypeDocument.ResetText();
                cmbTypeDocument.Focus();
                AddColumnsToDataTable();
                FillcmbListCheque();
                CelearItemslblAmounts();
                FilldgvListMulti();
                FilldgvListCheque1();
                FilldgvListCheque2();
                FillcmbDetailedAccountsTo();
                FilldgvList();

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        void CelearItemslblAmounts()
        {
            lblTotalCash.ResetText();
            lblTotlCheuqe.ResetText();
            lblTotalCashC.ResetText();
            lblTotlCheuqeC.ResetText();
            lblTotlSum.ResetText();
            lblTotlSumC.ResetText();
        }

        int DetailedAccountsFromId_ = 0;
        double AccountBalancF = 0;
        double AccountBalancT = 0;

        private void cmbDetailedAccountsFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDetailedAccountsFrom.SelectedIndex==-1)
                {
                    lblAccountBalancF.ResetText();
                    return;
                }
                DetailedAccountsFromId_ = Convert.ToInt32(cmbDetailedAccountsFrom.Value);

                AccountBalancF=PublicClass.DetailedAccountsBalance(SpecificAccountIdF, DetailedAccountsFromId_);

                lblAccountBalancF.Text=AccountBalancF.ToString("#,##0;(#,##0)");


                using (var db = new DBcontextModel())
                {
                    var cuId = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsFromId_).First().CustomerId;
                    FillcmbListDoc(cuId);
                }

            }
            catch (Exception)
            {
            }
        }

        private void FillcmbListDoc(int CuId)
        {
            using (var _context = new DBcontextModel())
            {
                var query = from B in _context.ComersBs
                            join H in _context.ComersHs on B.ComersHId equals H.Id

                            where B.CostAccountId == CuId ||
                                  B.GoodsAccountId == CuId ||
                                  H.ShiperId == CuId
                            select new
                            {
                                ComersB_Id = B.Id,
                                SeryalB = B.SeryalB, // سریال بارنامه
                                LoadWeight = B.LoadWeight, // وزن خالص بار
                                FreightRate = B.FreightRate, // نرخ حمل
                                PaidFreightRate = B.PaidFreightRate, // نرخ کرایه پرداختی به راننده
                                DescriptionB = B.Description, // توضیحات بارنامه

                                // اطلاعات از جدول ComersH
                                Id = H.Id,
                                RemiaanceSeryal = H.RemiaanceSeryal, // شماره(سریال) حواله
                                DateH = H.date, // تاریخ حواله
                                LoadingOriginId = H.LoadingOrinigId, // مبداء بارگیری
                                UnLoadingLocationId = H.UnLoadingLocationId, // محل تخلیه
                                DescriptionH = H.Description, // توضیحات حواله
                                DateB = B.DateB,
                                // فیلدهای استفاده شده در فیلتر
                                CostAccountId = B.CostAccountId, // طرف حساب هزینه کامیون
                                GoodsAccountId = B.GoodsAccountId, // طرف حساب کالا
                                ShiperId = H.ShiperId, // بارنامه نویس

                            };

                // توجه: متدToList(). زمانی که می‌خواهید داده‌ها را از دیتابیس بگیرید (اجرای کوئری)
                // برای Data Table معمولاً لازم است که IQueryable یا List<T> برگردانده شود.
                // بسته به نحوه کارکرد Data Table در سمت UI، ممکن است لازم باشد آن را به یک لیست تبدیل کنید.
                // return query.ToList(); 

                cmbListDoc.DataSource= query.ToList();
                dt_ListDoc = new System.Data.DataTable();
                dt_ListDoc = PublicClass.AddEntityTableToDataTable(query.ToList());

            }
        }
        DataTable dt_ListDoc;
        int SpecificAccountIdF = 0;

        private void cmbSpecificAccountFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSpecificAccountFrom.SelectedIndex==-1)
                {
                    cmbDetailedAccountsFrom.ResetText();
                    //lblSpecificAccountsBalanceF.ResetText();
                    lblAccountBalancF.ResetText();
                    return;
                }

                SpecificAccountIdF = Convert.ToInt32(cmbSpecificAccountFrom.Value);
                FillcmbContraAccountF(SpecificAccountIdF);

                //lblSpecificAccountsBalanceF.Text=PublicClass.SpecificAccountsBalance(SpecificAccountIdF).ToString("#,##0;(#,##0)");

                cmbDetailedAccountsFrom.ResetText();
            }
            catch (Exception)
            {
            }
        }

        private void cmbDetailedAccountsFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDetailedAccountsFrom, dt_DetailedAccountsFrom);
            }

        }

        private void cmbSpecificAccountFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbSpecificAccountFrom, dt_SpecificAccountF);

            }

        }

        private void cmbTypeDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbTypeDocument, dt_TypeDocument);

            }

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmSpecificAccountsGroup f = new frmSpecificAccountsGroup(this);
            f.ShowDialog();
            CheangRDB(CheangRDB_);
        }


        double TotalAmountCash1 = 0;
        double TotalAmountCash2 = 0;
        double TotalAmountCheque1 = 0;
        double TotalAmountCheque2 = 0;
        int TotalAmountCash1C = 0;
        int TotalAmountCash2C = 0;
        int TotalAmountChequeC1 = 0;
        int TotalAmountChequeC2 = 0;

        (double, int) CalcTotalAmount()
        {
            //ToDo Data Table محاسبه مجموع مقادیر در ستون 
            //TotalAmountCash1 = dt_MultipleAccount.AsEnumerable().Sum(row => row.Field<long>("Amount1"));

            //ToDo Janus محاسبه مجموع مقادیر در ستون دیتاگریدویو
            TotalAmountCash1 = dgvListMulti.GetRows().Select(row => Convert.ToDouble(row.Cells["Amount1"].Value)).Sum();

            TotalAmountCash2 = dgvListMulti.GetRows().Select(row => Convert.ToDouble(row.Cells["Amount2"].Value)).Sum();

            TotalAmountCheque1 = dgvListCheque1.GetRows().Select(row => Convert.ToDouble(row.Cells["Amount"].Value)).Sum();

            TotalAmountCheque2 = dgvListCheque2.GetRows().Select(row => Convert.ToDouble(row.Cells["Amount"].Value)).Sum();

            TotalAmountCash1C = dgvListMulti.GetRows().Select(row => Convert.ToInt32(row.Cells["Amount1"].Value)).Count();
            TotalAmountCash2C = dgvListMulti.GetRows().Select(row => Convert.ToInt32(row.Cells["Amount2"].Value)).Count();

            TotalAmountChequeC1 = dgvListCheque1.GetRows().Select(row => Convert.ToInt32(row.Cells["Amount"].Value)).Count();

            TotalAmountChequeC2 = dgvListCheque2.GetRows().Select(row => Convert.ToInt32(row.Cells["Amount"].Value)).Count();



            return (TotalAmountCash1+TotalAmountCash2+TotalAmountCheque1+TotalAmountCheque2, TotalAmountCash1C+TotalAmountChequeC1+TotalAmountChequeC2);
        }

        /// <summary>
        /// نمایش مجموع مبالغ
        /// </summary>
        void CalcTotalAmountAddToItems()
        {
            CelearItemslblAmounts();
            double S = 0;
            double C = 0;
            (S, C)=CalcTotalAmount();

            lblTotalCash.Text=(TotalAmountCash1+TotalAmountCash2).ToString("#,##0");
            lblTotlCheuqe.Text=(TotalAmountCheque1+TotalAmountCheque2).ToString("#,##0");

            lblTotalCashC.Text=(TotalAmountCash1C).ToString();
            lblTotlCheuqeC.Text=(TotalAmountChequeC1+TotalAmountChequeC2).ToString();

            lblTotlSum.Text=S.ToString("#,##0");
            lblTotlSumC.Text=C.ToString();

        }

        public int TransactionsCode;

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ControlFildes()) return;
            txtTransactionCode.Text=PublicClass.CreatTransactionCode();
            int Series = 0;
            if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (var db = new DBcontextModel())
            {
                string DesKarmozd = "بابت کارمز انتقال وجه - ";
                string TransactionCode = txtTransactionCode.Text;
                string TransactionDate = txtTransactionDate.Text;
                double Amount = TotalAmountCash1;
                int cuont = 0;
                using (var transaction = db.Database.BeginTransaction())
                    try
                    {
                        {


                            (Amount, cuont)=CalcTotalAmount();

                            Series++;
                            PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountIdF, DetailedAccountsFromId_, Amount, TransactionsCode==4 ? 0 : Amount, TransactionsCode==4 ? Amount : 0, 0, txtDescription.Text, "", Series, false);

                            //ثبت مبالغ نقدی
                            if (dt_MultipleAccount!=null)
                            {
                                foreach (DataRow r in dt_MultipleAccount.Rows)
                                {
                                    Series++;
                                    int SpecificAccountId_ = Convert.ToInt32(r["SpecificAccountId"]);
                                    int DetailedAccountId_ = Convert.ToInt32(r["DetailedAccountId"]);


                                    Amount = Convert.ToDouble(r["Amount1"]);

                                    PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId_, DetailedAccountId_, Amount, TransactionsCode==4 ? Amount : 0, TransactionsCode==4 ? 0 : Amount, 0, r["Des"].ToString(), r["SeryalNumber"].ToString(), Series, false);

                                    //ثبت کارمزد
                                    double Amount2 = 0;
                                    if (r["Amount2"]!=null || r["Amount2"].ToString()!="")
                                        Amount2 = Convert.ToDouble(r["Amount2"]);

                                    if (Amount2!=0)
                                    {
                                        Series++;
                                        int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==80802).First().Id;
                                        int DetailedAccountId = 0;
                                        int customertId = db.Customers.Where(c => c.SecretCode==7).First().Id;

                                        var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                                        if (serch1.Count()==0)
                                            DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                        else
                                            DetailedAccountId=serch1.First().Id;

                                        PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount2, TransactionsCode == 4 ? 0 : Amount2, TransactionsCode == 4 ? Amount2 : 0, 0, DesKarmozd + r["Des"].ToString(), r["SeryalNumber"].ToString(), Series, false);


                                        Series++;
                                        PublicClass.AccountingDocumentRegistration(db, ListId, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId_, DetailedAccountId_, Amount2, TransactionsCode==4 ? Amount2 : 0, TransactionsCode==4 ? 0 : Amount2, 0, DesKarmozd + r["Des"].ToString(), r["SeryalNumber"].ToString(), Series, false);
                                    }
                                }
                            }

                            {//برای ثبت چک
                                if (rdbIncomr.Checked)
                                {//چک های دریافتنی
                                    if (dt_Cheque1!=null)
                                    {
                                        foreach (DataRow r in dt_Cheque1.Rows)
                                        {
                                            Series++;
                                            //اسناد دریافتنی در جریان وصول
                                            int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==10302).First().Id;
                                            int DetailedAccountId = 0;
                                            var customertId = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsFromId_).First().CustomerId;
                                            var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                                            if (serch1.Count()==0)
                                                DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                            else
                                                DetailedAccountId=serch1.First().Id;



                                            //==================





                                            Amount = Convert.ToDouble(r["Amount"]);
                                            //-------ثبت در دیتابیس--------
                                            int TransactionId = PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount, TransactionsCode==4 ? Amount : 0, TransactionsCode==4 ? 0 : Amount, 0, r["Description"].ToString(), Series, false);

                                            int ChequeTypeId_ = 0;
                                            if (TransactionsCode==4)
                                                ChequeTypeId_=1;
                                            else
                                                ChequeTypeId_=2;
                                            //-------ثبت در دیتابیس--------

                                            var ChequeSave = new Repository<Entity.Accounts.Cheque.Cheque>(db);
                                            int ChequeId = ChequeSave.SaveOrUpdateRefIdByCommit(new Entity.Accounts.Cheque.Cheque { Id = ListId, ChequeTypeId=ChequeTypeId_, ChequeNumber=r["ChequeNumber"].ToString(), Amount=Amount, DueDate=r["DueDate"].ToString(), IssueDate=PersianDate.NowPersianDate, BankId=Convert.ToInt32(r["BankId"]), Payer_Payee_AccId=DetailedAccountId, ChequeOwner=r["ChequeOwner"].ToString(), Description=r["Description"].ToString(), CurrentStatusID= 0 }, ListId);


                                            //-------ثبت در دیتابیس--------
                                            var ADR = new Repository<ChequeStatus>(db);
                                            int CurrentStatusID = ADR.SaveOrUpdateRefIdByCommit(new ChequeStatus { Id = 0, ChequeId=ChequeId, StatusDate=TransactionDate, StatusCodeId=2, TransactionId=TransactionId }, 0);

                                            //-------ثبت در دیتابیس--------
                                            var ch = db.Cheques.Where(c => c.Id==ChequeId).First();
                                            ch.CurrentStatusID=CurrentStatusID;

                                        }
                                    }
                                }
                                else
                                {//چک های پرداختنی
                                    if (dt_Cheque1!=null)
                                    {
                                        foreach (DataRow r in dt_Cheque1.Rows)
                                        {
                                            Series++;
                                            //حساب ها و اسناد پرداختنی بلند مدت
                                            int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==40101).First().Id;

                                            int DetailedAccountId = 0;
                                            var customertId = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsFromId_).First().CustomerId;
                                            var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                                            if (serch1.Count()==0)
                                                DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                            else
                                                DetailedAccountId=serch1.First().Id;

                                            Amount = Convert.ToDouble(r["Amount"]);

                                            int TransactionId = PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount, TransactionsCode==4 ? Amount : 0, TransactionsCode==4 ? 0 : Amount, 0, r["Description"].ToString(), Series, false);

                                            int ChequeTypeId_ = 0;
                                            if (TransactionsCode==4)
                                                ChequeTypeId_=1;
                                            else
                                                ChequeTypeId_=2;

                                            var ChequeSave = new Repository<Entity.Accounts.Cheque.Cheque>(db);
                                            int ChequeId = ChequeSave.SaveOrUpdateRefIdByCommit(new Entity.Accounts.Cheque.Cheque { Id = ListId, ChequeTypeId=ChequeTypeId_, ChequeNumber=r["ChequeNumber"].ToString(), Amount=Amount, DueDate=r["DueDate"].ToString(), IssueDate=PersianDate.NowPersianDate, BankId=Convert.ToInt32(r["BankId"]), Payer_Payee_AccId=DetailedAccountId, ChequeOwner=r["ChequeOwner"].ToString(), Description=r["Description"].ToString(), CurrentStatusID= 0 }, ListId);


                                            //var ADR = new Repository<Entity.Accounts.Cheque.ChequeStatus>(db);
                                            //int CurrentStatusID = ADR.SaveOrUpdateRefIdByCommit(new Entity.Accounts.Cheque.ChequeStatus { Id = 0, ChequeId=ChequeId, StatusDate=TransactionDate, StatusCodeId=1, TransactionId=TransactionId }, 0);
                                            var ADR = new Repository<ChequeStatus>(db);
                                            int CurrentStatusID = ADR.SaveOrUpdateRefIdByCommit(new ChequeStatus { Id = 0, ChequeId=ChequeId, StatusDate=TransactionDate, StatusCodeId=1, TransactionId=TransactionId }, 0);

                                            var ch = db.Cheques.Where(c => c.Id==ChequeId).First();
                                            ch.CurrentStatusID=CurrentStatusID;

                                        }
                                    }
                                }
                            }
                            //ثبت برای چک های مشتری جهت خرج
                            {
                                if (rdbExpense.Checked)
                                {
                                    if (dt_Cheque2!=null)
                                    {
                                        foreach (DataRow r in dt_Cheque2.Rows)
                                        {
                                            Series++;
                                            //اسناد دریافتنی در جریان وصول
                                            int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==10302).First().Id;

                                            int DetailedAccountId = Convert.ToInt32(r["Payer_Payee_Acc_Id"]);
                                            int ChequeId = Convert.ToInt32(r["Id"]);

                                            Amount = Convert.ToDouble(r["Amount"]);

                                            int TransactionId = PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount, TransactionsCode==4 ? Amount : 0, TransactionsCode==4 ? 0 : Amount, 0, r["Description"].ToString(), Series, false);

                                            /*
                                            int ChequeTypeId_ = 0;
                                            if (TransactionsCode==4)
                                                ChequeTypeId_=1;
                                            else
                                                ChequeTypeId_=2;

                                            var ChequeSave = new Repository<Entity.Accounts.Cheque.Cheque>(db);
                                            int ChequeId = ChequeSave.SaveOrUpdateRefIdByCommit(new Entity.Accounts.Cheque.Cheque { Id = ListId, ChequeTypeId=ChequeTypeId_, ChequeNumber=r["ChequeNumber"].ToString(), Amount=Amount, DueDate=r["DueDate"].ToString(), IssueDate=PersianDate.NowPersianDate, BankName=r["BankName"].ToString(), Payer_Payee_AccId=DetailedAccountId, ChequeOwner=r["ChequeOwner"].ToString(), Description=r["Description"].ToString(), CurrentStatusID= 0 }, ListId);
                                            */


                                            var ADR = new Repository<ChequeStatus>(db);
                                            int CurrentStatusID = ADR.SaveOrUpdateRefIdByCommit(new ChequeStatus { Id = 0, ChequeId=ChequeId, StatusDate=TransactionDate, StatusCodeId=5, TransactionId=TransactionId }, 0);

                                            var ch = db.Cheques.Where(c => c.Id==ChequeId).First();
                                            ch.CurrentStatusID=CurrentStatusID;

                                        }

                                    }
                                }

                            }

                            db.SaveChanges();
                            transaction.Commit();

                            PublicClass.WindowAlart("1");
                            if (_updatableForms!=null)
                                _updatableForms.UpdateData();
                            CelearItems();
                            
                            //FilldgvListMulti();
                            //FilldgvListCheque1();
                            //FilldgvListCheque2();
                            //FillcmbDetailedAccountsTo();
                            //FilldgvList();

                        }
                    }
                    catch (Exception er)
                    {
                        transaction.Rollback();
                        PublicClass.ShowErrorMessage(er);
                    }
            }
        }

        /// <summary>
        /// بررسی فیلدهای ثبت اسناد
        /// </summary>
        /// <returns></returns>
        private bool ControlFildes()
        {
            try
            {
                foreach (DataRow r in dt_MultipleAccount.Rows)
                {
                    if (r["Amount2"]==DBNull.Value)
                        r["Amount2"]=0;
                    if (r["SeryalNumber"]==DBNull.Value)
                        r["SeryalNumber"]="-";
                }

                if (txtTransactionDate.Text.Length!=10)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T020);
                    return true;
                }
                //کنترل تاریخ در بازه سال مالی
                if (!PublicClass.FinancialYearsControl(txtTransactionDate.Text))
                {
                    PublicClass.ErrorMesseg(ResourceCode.T118);
                    return true;
                }

                if (cmbTypeDocument.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T135);
                    cmbTypeDocument.Focus();
                    return true;
                }
                if (cmbDetailedAccountsFrom.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T078);
                    cmbDetailedAccountsFrom.Focus();
                    return true;
                }
                if (txtDescription.Text =="")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T143);
                    txtDescription.Focus();
                    return true;
                }

                double Amount = 0;
                int count = 0;
                (Amount, count)= CalcTotalAmount();

                if (Amount==0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T134);
                    return true;
                }

                if (dgvListMulti.RowCount==0 && dgvListCheque1.RowCount==0&& dgvListCheque2.RowCount==0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T121);
                    return true;
                }

                return false;

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er); return false;
            }
        }

        private void btnCreatDescription_Click(object sender, EventArgs e)
        {
        }

        private void btnAddNewCity1_Click(object sender, EventArgs e)
        {
            if (cmbSpecificAccountFrom.SelectedIndex!=-1)
            {
                frmDetailedAccount f = new frmDetailedAccount(this);
                f.cmbSpecificAccountValue=SpecificAccountIdF;
                f.ShowDialog();
                FillcmbContraAccountF(SpecificAccountIdF);
            }
            else
            {
                PublicClass.ErrorMesseg(ResourceCode.T071);
                cmbSpecificAccountFrom.Focus();
            }

        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvList();
        }

        //private void dgvListMulti_CurrentCellChanged(object sender, EventArgs e)
        //{
        //    int selectedRowIndex = dgvListMulti.CurrentRow.RowIndex;
        //    Janus.Windows.GridEX.GridEXRow currentRow = dgvListMulti.GetRow(selectedRowIndex);

        //    if (currentRow != null)
        //    {
        //        currentRow.BeginEdit();
        //    }


        //}

        private void dgvListCheque_InitCustomEdit(object sender, InitCustomEditEventArgs e)
        {
            if (e.Column.Key=="BankName")
            {
                //    if (e.Value==null)
                //    {
                //        txtBankName.ResetText();
                //    }
                //    else
                //    {
                //        txtBankName.Text=e.Value.ToString();
                //    }
                //    e.EditControl=txtBankName;
            }
            else if (e.Column.Key=="ChequeOwner")
            {
                if (e.Value==null)
                {
                    txtChequeOwner.ResetText();
                }
                else
                {
                    txtChequeOwner.Text=e.Value.ToString();
                }
                e.EditControl=txtChequeOwner;
            }
            else if (e.Column.Key=="DueDate")
            {
                if (e.Value==null)
                {
                    txtDueDate.Text=PersianDate.NowPersianDate;
                }
                else
                {
                    txtDueDate.Text=e.Value.ToString();
                }
                //txtDueDate.Text=e.Value.ToString();
                e.EditControl=txtDueDate;
            }
            else if (e.Column.Key=="Amount")
            {
                if (e.Value==null)
                {
                    txtAmount1.ResetText();
                }
                else
                {
                    txtAmount1.Text=e.Value.ToString();
                }
                e.EditControl=txtAmount1;
            }
            else if (e.Column.Key=="Description")
            {
                if (e.Value==null)
                {
                    txtDescriptionCa.ResetText();
                }
                else
                {
                    txtDescriptionCa.Text=e.Value.ToString();
                }
                e.EditControl=txtDescriptionCa;
            }
        }

        private void dgvListCheque_EndCustomEdit(object sender, EndCustomEditEventArgs e)
        {
            try
            {
                if (e.Column.Key=="BankName")
                {
                    //e.Value=txtBankName.Text;

                    //if (txtBankName.Text!="")
                    //{
                    //    dgvListMulti.GetRow().Cells["SpecificAccountId"].Value=cmbSpecificAccountTo.Value;
                    //    dgvListMulti.GetRow().Cells["SpecificAccount"].Value=cmbSpecificAccountTo.Text;
                    //}
                    //else
                    //{
                    //    dgvListMulti.GetRow().Cells["SpecificAccountId"].Value=null;
                    //    dgvListMulti.GetRow().Cells["SpecificAccount"].Value=null;
                    //}
                }
                else if (e.Column.Key=="ChequeOwner")
                {
                    e.Value=txtChequeOwner.Text;
                }
                else if (e.Column.Key=="DueDate")
                {
                    e.Value=txtDueDate.Text;
                }
                else if (e.Column.Key=="Amount")
                {
                    e.Value=txtAmount1.TextSimple;
                    //CalcTotalAmountAddToItems();

                }
                else if (e.Column.Key=="Description")
                {
                    e.Value=txtDescriptionCa.Text;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void dgvListCheque_AddingRecord(object sender, CancelEventArgs e)
        {
            try
            {
                int i = 0;
                if (dgvListCheque1.GetRow().Cells["ChequeNumber"].Value==DBNull.Value)
                    i++;
                if (dgvListCheque1.GetRow().Cells["BankName"].Value==DBNull.Value)
                    i++;
                if (dgvListCheque1.GetRow().Cells["ChequeOwner"].Value == DBNull.Value)
                    i++;
                if (dgvListCheque1.GetRow().Cells["DueDate"].Value == DBNull.Value)
                    i++;
                if (dgvListCheque1.GetRow().Cells["Amount"].Value==DBNull.Value)
                    i++;
                if (dgvListCheque1.GetRow().Cells["Description"].Value == DBNull.Value)
                    i++;
                if (i!=0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T029);
                    e.Cancel = true;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void dgvListMulti_GetNewRow(object sender, GetNewRowEventArgs e)
        {
            //CalcTotalAmountAddToItems();
        }

        private void dgvListCheque_GetNewRow(object sender, GetNewRowEventArgs e)
        {
            //CalcTotalAmountAddToItems();
        }

        private void txtTotalAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void rdbExpense_CheckedChanged(object sender, EventArgs e)
        {
            CheangRDB_="rdbExpense";
            if (rdbExpense.Checked) CheangRDB(CheangRDB_);
        }

        string TabKey = "";
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            //TabKey = uiTab1.SelectedTab.Key;
            try
            {
                switch (TabKey)
                {
                    case "Cash"://نقد
                        AddDataToCashTable();
                        break;
                    case "Cheque"://چک
                        AddDataToChequeTable();
                        break;
                    case "Documents"://اسناد- خرج چک
                        AddDataToDocumentsChequeTable();
                        break;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        double TotalAmounDT1 = 0;
        double TotalAmounDT2 = 0;
        private void AddDataToCashTable()
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbDetailedAccountsTo, ResourceCode.T078, txtAmount1, ResourceCode.T081, txtDescriptionCa, ResourceCode.T136))
                    return;


                if (txtAmount2.Text=="")
                    txtAmount2.Text="0";
                if (rdbExpense.Checked)

                {
                    TotalAmounDT1 = 0;
                    TotalAmounDT2 = 0;
                    //ToDo به همراه شرط Data Table محاسبه مجموع مقادیر در ستون 
                    //مبلغ سند
                    //TotalAmounDT1 = dt_MultipleAccount.AsEnumerable().Where(row => row.Field<int>("DetailedAccountId") ==DetailedAccountsToId).Sum(row => row.Field<long>("Amount1"));
                    ////مبلغ کارمزد
                    //TotalAmounDT2 = dt_MultipleAccount.AsEnumerable().Where(row => row.Field<int>("DetailedAccountId") ==DetailedAccountsToId).Sum(row => row.Field<long>("Amount2"));


                    double TotalAmount = Convert.ToDouble(txtAmount1.TextSimple)+Convert.ToDouble(txtAmount2.TextSimple);
                    if (TotalAmount>AccountBalancT || TotalAmount==0)
                    {
                        PublicClass.StopMesseg(ResourceCode.T116);
                        txtAmount1.Focus();
                        return;
                    }
                }

                //if (MessageBox.Show(ResourceCode.T122, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                DataRow newrow = dt_MultipleAccount.NewRow();
                using (var db = new DBcontextModel())
                {
                    var spId = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsToId).First().SpecificAccountId;
                    var spName = db.SpecificAccounts.Where(c => c.Id==spId).First().Name;
                    newrow["SpecificAccountId"]=spId;
                    newrow["DetailedAccountId"]=DetailedAccountsToId;
                    newrow["SpecificAccount"]=spName;
                    newrow["DetailedAccount"]=cmbDetailedAccountsTo.Text;
                    newrow["Amount1"]=txtAmount1.TextSimple;
                    //if (txtAmount2.Text!="")
                    newrow["Amount2"]=txtAmount2.TextSimple;
                    //else
                    //    newrow["Amount2"]=0;
                    newrow["SeryalNumber"]=txtSeryalNumber.Text;
                    newrow["Des"]=txtDescriptionCa.Text;
                    dt_MultipleAccount.Rows.Add(newrow);
                    dgvListMulti.DataSource=dt_MultipleAccount;
                    dgvListMulti.AutoSizeColumns();
                    CalcTotalAmountAddToItems();
                    celerCashItems();

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        /// <summary>
        /// حذف آیتم های نقد
        /// </summary>
        void celerCashItems()
        {
            cmbDetailedAccountsTo.ResetText();
            txtAmount1.ResetText();
            txtAmount2.ResetText();
            txtSeryalNumber.ResetText();
            txtDescriptionCa.ResetText();
            cmbDetailedAccountsTo.Focus();
        }
        private void AddDataToChequeTable()
        {

            try
            {
                if (PublicClass.FindEmptyControls(txtChequeNumber, ResourceCode.T138, cmbBanck, ResourceCode.T139, txtAmount3, ResourceCode.T081, txtDescriptionCh, ResourceCode.T136))
                    return;

                if (txtDueDate.Text.Length!=10)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T020);
                    txtDueDate.Focus();
                    return;
                }
                //if(rdbIncomr.Checked && txtChequeOwner.Text=="")
                //{
                //    PublicClass.ErrorMesseg(ResourceCode.T137);
                //    txtChequeOwner.Focus();
                //    return;
                //}
                if (txtChequeOwner.Text=="")
                {
                    txtChequeOwner.Text="-";
                }


                //Todo DataTable کنترل ثبت رکوردهای تکراری در
                DataRow existingRow = dt_Cheque1.Rows.Find(txtChequeNumber.Text);
                if (existingRow == null)

                {
                    using (var db = new DBcontextModel())
                    {
                        DataRow newrow = dt_Cheque1.NewRow();
                        var q = db.Bancks.Where(c => c.Id==BanckId).First();
                        newrow["ChequeNumber"]=txtChequeNumber.Text;
                        newrow["BankId"]=BanckId;
                        newrow["BankName"]=q.Name/*+"-"+q.BranchName*/;
                        newrow["ChequeOwner"]=txtChequeOwner.Text;
                        newrow["DueDate"]=txtDueDate.Text;
                        newrow["Amount"]=txtAmount3.TextSimple;
                        newrow["Description"]=txtDescriptionCh.Text;
                        dt_Cheque1.Rows.Add(newrow);
                        dgvListCheque1.DataSource=dt_Cheque1;
                        dgvListCheque1.AutoSizeColumns();
                        CalcTotalAmountAddToItems();
                        celerChequeItems();
                        txtChequeNumber.Focus();
                    }
                }
                else
                {
                    PublicClass.StopMesseg(ResourceCode.T141);
                    return;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        /// <summary>
        /// خرج چک های مشتری
        /// </summary>
        private void AddDataToDocumentsChequeTable()
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbListCheque, ResourceCode.T140, txtDescriptionDoc, ResourceCode.T143))
                    return;

                if (cmbListCheque.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T140);
                    txtDueDate.Focus();
                    return;
                }
                //if (MessageBox.Show(ResourceCode.T122, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                using (var db = new DBcontextModel())
                {
                    var q = db.Cheques.Where(c => c.Id==ListChequeId).First();
                    var da = db.DetailedAccounts.Where(c => c.Id==q.Payer_Payee_AccId).First();
                    var cu = db.Customers.Where(c => c.Id==da.CustomerId).First();

                    DataRow existingRow = dt_Cheque2.Rows.Find(ListChequeId);
                    if (existingRow == null)

                    {
                        var qb = db.Bancks.Where(c => c.Id==q.BankId).First();
                        DataRow newrow = dt_Cheque2.NewRow();
                        newrow["Id"]=ListChequeId;
                        newrow["ChequeNumber"]=cmbListCheque.Text;
                        newrow["Payer_Payee_Acc_Id"]=q.Payer_Payee_AccId;
                        newrow["Payer_Payee_Acc_Name"]=cu.Family+" "+cu.Name;
                        newrow["BankName"]=qb.Name/*+"-"+qb.BranchName*/;
                        newrow["ChequeOwner"]=q.ChequeOwner;
                        newrow["DueDate"]=q.DueDate;
                        newrow["Amount"]=q.Amount;
                        newrow["Description"]=txtDescriptionDoc.Text;
                        dt_Cheque2.Rows.Add(newrow);
                    }
                    else
                    {
                        PublicClass.StopMesseg(ResourceCode.T141);
                        return;
                    }
                }
                dgvListCheque2.DataSource=dt_Cheque2;
                dgvListCheque2.AutoSizeColumns();
                CalcTotalAmountAddToItems();
                celerChequeItemsDoc();
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        void celerChequeItemsDoc()
        {
            cmbListCheque.ResetText();
            txtDescriptionDoc.ResetText();
            cmbListCheque.Focus();
        }
        /// <summary>
        /// حذف آیتم های چک
        /// </summary>
        void celerChequeItems()
        {
            try
            {
                txtChequeNumber.ResetText();
                cmbBanck.ResetText();
                txtChequeOwner.ResetText();
                txtDueDate.Text=PersianDate.NowPersianDate;
                txtAmount3.ResetText();
                txtDescriptionCh.ResetText();
                txtDescriptionDoc.ResetText();
                txtChequeNumber.Focus();
                cmbListCheque.ResetText();

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        private void uiTab2_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            //TabKey = uiTab2.SelectedTab.Key;
            //uiTab1.SelectedTab.Key=uiTab2.SelectedTab.Key;
            //uiTab1.SelectedIndex=uiTab2.SelectedIndex;
        }

        int DetailedAccountsToId = 0;
        private void cmbDetailedAccountsTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDetailedAccountsTo.SelectedIndex!=-1)
                {
                    DetailedAccountsToId = Convert.ToInt32(cmbDetailedAccountsTo.Value);


                    using (var db = new DBcontextModel())
                    {
                        TotalAmounDT1=0;
                        TotalAmounDT2=0;

                        TotalAmounDT1 = dt_MultipleAccount.AsEnumerable().Where(row => row.Field<int>("DetailedAccountId") ==DetailedAccountsToId).Sum(row => row.Field<long>("Amount1"));
                        //مبلغ کارمزد
                        TotalAmounDT2 = dt_MultipleAccount.AsEnumerable().Where(row => row.Field<int>("DetailedAccountId") ==DetailedAccountsToId).Sum(row => row.Field<long>("Amount2"));



                        var spid = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsToId).First().SpecificAccountId;

                        if (rdbExpense.Checked)
                        {
                            AccountBalancT=PublicClass.DetailedAccountsBalance(spid, DetailedAccountsToId)-TotalAmounDT1-TotalAmounDT2;
                        }
                        else
                        {
                            AccountBalancT=PublicClass.DetailedAccountsBalance(spid, DetailedAccountsToId)+TotalAmounDT1+TotalAmounDT2;

                        }
                        lblAccountBalancT.Text=AccountBalancT.ToString("#,##0;(#,##0)");
                    }

                }
                else
                    lblAccountBalancT.Text="0";
            }
            catch (Exception)
            {
            }
        }

        private void uiTab1_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            TabKey = uiTab1.SelectedTab.Key;
            //switch (TabKey)
            //{
            //    case "Cash"://نقد
            //        AddDataToCashTable();
            //        break;
            //    case "Cheque"://چک
            //        AddDataToChequeTable();
            //        break;
            //}

        }

        private void dgvListMulti_RecordsDeleted(object sender, EventArgs e)
        {
            CalcTotalAmountAddToItems();

        }

        private void dgvListCheque_RecordsDeleted(object sender, EventArgs e)
        {
            CalcTotalAmountAddToItems();
        }
        private void dgvListCheque2_RecordsDeleted(object sender, EventArgs e)
        {
            CalcTotalAmountAddToItems();
        }

        private void btnCelerItems_Click(object sender, EventArgs e)
        {
            try
            {
                switch (TabKey)
                {
                    case "Cash"://نقد
                        celerCashItems();
                        break;
                    case "Cheque"://چک
                        celerChequeItems();
                        break;
                    case "Documents"://آسناد
                        celerChequeItemsDoc();
                        break;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void cmbListCheque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbListCheque, dt_ListCheque);
            }
        }

        int ListChequeId = 0;
        private void cmbListCheque_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbListCheque.SelectedIndex!=-1)
                {
                    ListChequeId = Convert.ToInt32(cmbListCheque.Value);
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Cheques.Where(c => c.Id==ListChequeId).First();
                        lblAmontCheckDoc.Text=q.Amount.ToString("#,##0");
                        var m = db.DetailedAccounts.Where(c => c.Id==q.Payer_Payee_AccId).First();
                        var n = db.Customers.Where(c => c.Id==m.CustomerId).First();
                        lblCeackDocName.Text=n.Name+" "+n.Family;
                    }
                }
                else
                {
                    lblCeackDocName.ResetText();
                    lblAmontCheckDoc.ResetText();
                }
            }
            catch (Exception)
            {
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text=="")
            {
                string txtF = "";
                string txtT = "";

                if (rdbIncomr.Checked)
                {
                    txtF = "دریافت بابت ";
                }
                else
                {
                    txtF = "پرداخت بابت ";
                }
                txtDescription.Text= txtF/*+ txtTotalAmount.Text +" ریال در تاریخ "+txtTransactionDate.Text+" به شماره سند "+txtTransactionCode.Text + " بابت "*/;
            }

        }

        private void btnAddNewBanck1_Click(object sender, EventArgs e)
        {
            try
            {
                frmContraAccounts f = new frmContraAccounts(this);
                f.cmbTypeAccounts.Enabled = false;
                f.TypeAccounts_Id=3;
                f.SpecificAccountCode=10102;//بانک
                f.ShowList(3);
                f.ShowDialog();
                FillcmbDetailedAccountsTo();


            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnAddNewCofer1_Click(object sender, EventArgs e)
        {
            try
            {
                frmContraAccounts f = new frmContraAccounts(this);
                f.cmbTypeAccounts.Enabled = false;
                f.TypeAccounts_Id=4;
                f.SpecificAccountCode=10101;//صندوق
                f.ShowList(4);
                f.ShowDialog();
                FillcmbDetailedAccountsTo();

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void cmbBanck_KeyDown(object sender, KeyEventArgs e)
        {

        }
        int BanckId = 0;
        private void cmbBanck_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBanck.SelectedIndex!=-1)
                {
                    BanckId=Convert.ToInt32(cmbBanck.Value);
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnAddBanck_Click(object sender, EventArgs e)
        {
            frmBanck f = new frmBanck(this);
            f.ShowDialog();
            FillcmbBanck();
        }

        private void txtChequeNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbBanck, dt_Banck);
            }

        }

        private void txtDescriptionDoc_Enter(object sender, EventArgs e)
        {
            if (txtDescriptionDoc.Text=="")
                txtDescriptionDoc.Text="بابت ";
        }

        private void txtDescriptionCh_Enter(object sender, EventArgs e)
        {
            if (txtDescriptionCh.Text=="")
                txtDescriptionCh.Text="بابت ";

        }

        private void txtDescriptionCa_Enter(object sender, EventArgs e)
        {
            if (txtDescriptionCa.Text=="")
                txtDescriptionCa.Text="بابت ";
        }

        private void cmbListDoc_KeyDown(object sender, KeyEventArgs e)
        {
            //        if (e.KeyCode == Keys.Enter)
            //SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbListDoc, dt_ListDoc);
            }

        }

        private void rcmDetails_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            //ToDo Contex Menu Strip
            try
            {
                ListId=ListId_;
                switch (e.Command.Key)
                {
                    case "Edit":
                        using (var db = new DBcontextModel())
                        {


                        }
                        break;
                    case "Delete":

                        using (var db = new DBcontextModel())
                        {
                            if (db.DocumentBancks.Where(c => c.FormName ==this.Name && c.ListInFoemId==ListId).Count() != 0)
                            {
                                PublicClass.ErrorMesseg(ResourceCode.T149);
                                return;
                            }

                            var q = db.Transactions.Where(c => c.Id==ListId).First().TransactionCode;
                            var list = db.Transactions.Where(c => c.TransactionCode==q).ToList();
                            if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                foreach (var item in list)
                                {
                                    item.Status=true;
                                }
                                //db.Transactions.RemoveRange(list);
                                PublicClass.WindowAlart("2");
                                db.SaveChanges();
                                FilldgvList();
                                CelearItems();
                            }

                        }

                        break;
                    case "AddDocumentToBanck"://ثبت مدارک

                        string lblCaption = "شماره سند: " + dgvList.GetRow().Cells["TransactionCode"].Value.ToString();

                        PublicClass.AddDocumentToBanck(this.Name, ListId, lblCaption);
                        ListId=0;
                        break;
                    case "DocViow":
                        using (var db = new DBcontextModel())
                        {

                        }
                        break;
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
                ListId_ = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Details")
                {
                    rcmDetails.Show(Cursor.Position);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnShowDocList_Click(object sender, EventArgs e)
        {
            if(cmbListDoc.SelectedIndex==-1)
            {
                PublicClass.StopMesseg(ResourceCode.T041);
                cmbListDoc.Focus();
                return;
            }

            frmRecevingPaymentDoc f = new frmRecevingPaymentDoc();
            //f.DocName="H";
            f.IdH=Convert.ToInt32(cmbListDoc.Value);
            f.ShowDialog();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            PdfReportHelper.ExportJanusGridToPDF(dgvList, "لیست صورتحساب");
        }
    }
}
