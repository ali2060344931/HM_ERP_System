using DevComponents.DotNetBar;

using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.Cheque;
using HM_ERP_System.Entity.Accounts.NatureAccount;
using HM_ERP_System.Entity.Accounts.SpecificAccount;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Accounts.ContraAccounts;
using HM_ERP_System.Forms.Accounts.SpecificAccount;
using HM_ERP_System.Forms.Comers;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Reports;

using Microsoft.Office.Interop.Excel;

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
using System.Xml.Linq;

namespace HM_ERP_System.Forms.Accounts.DetailedAccount
{
    public partial class frmDetailedAccount : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int cmbSpecificAccountValue = 0;
        public int Code = 0;
        /// <summary>
        /// درخواست از فرم بیرونی
        /// </summary>
        public bool IsRequest = false;
        public frmDetailedAccount(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms = updatableForms;
        }

        public void UpdateData()
        {
            CallUpdateTata();
            //FilldgvList();
            //FillcmbSpecificAccount();
            //FillcmbCustomers();
            //FillcmbNatureAccounts();
        }
        private void frmDetailedAccount_Load(object sender, EventArgs e)
        {
            UpdateData();
            //CallUpdateTata();
            //if (cmbSpecificAccountValue != 0)
            //{
            //    if (Code==0)
            //    {
            //        cmbSpecificAccount.Value= cmbSpecificAccountValue;
            //        cmbSpecificAccount.Enabled=false;
            //    }
            //    else
            //    {
            //        FillcmbSpecificAccount();
            //    }
            //}

            //if (IsRequest)
            //    dgvList.RootTable.Columns["SelectAccount"].Visible=true;
            //else
            //    dgvList.RootTable.Columns["SelectAccount"].Visible=false;
        }
        private void CallUpdateTata()
        {
            FilldgvList();
            FillcmbSpecificAccount();
            FillcmbCustomers();
            FillcmbNatureAccounts();
            FillcmbBanck();
            if (cmbSpecificAccountValue != 0)
            {
                if (Code == 0)
                {
                    cmbSpecificAccount.Value = cmbSpecificAccountValue;
                    cmbSpecificAccount.Enabled = false;
                }
                else
                {
                    FillcmbSpecificAccount();
                }
            }

            if (IsRequest)
                dgvList.RootTable.Columns["SelectAccount"].Visible = true;
            else
                dgvList.RootTable.Columns["SelectAccount"].Visible = false;
        }
        System.Data.DataTable dt_Banck;
        private void FillcmbBanck()
        {
            using (var db = new DBcontextModel())
            {
                var q = from da in db.DetailedAccounts

                        join cu in db.Customers
                        on da.CustomerId equals cu.Id

                        join bb in db.BankBranches
                        on da.BankBrancheId equals bb.Id
                        join ba in db.Bancks
                        on bb.BanckId equals ba.Id
                        select new
                        {
                            da.Id,
                            AccountName = cu.Name,
                            BanckBranchName = bb.Name,
                            BanckName = ba.Name,
                            AccountNumber = cu.AccountNumber,
                        };

                cmbAccount.DataSource = q.ToList();
                dt_Banck = new System.Data.DataTable();
                dt_Banck = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }

        System.Data.DataTable dt_Customers;
        private void FillcmbCustomers()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cu in db.Customers

                            join tc in db.TypeCustomers
                            on cu.id_TypeCustomer equals tc.Id

                            where cu.id_TypeCustomer==1 || cu.id_TypeCustomer == 2
                            select new
                            {
                                cu.Id,
                                name = (cu.Family + " " + cu.Name).Trim(),
                                GroupName = tc.Name,
                            };

                    cmbCustomers.DataSource = q.ToList();

                    dt_Customers = new System.Data.DataTable();
                    dt_Customers = PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        System.Data.DataTable dt_SpecificAccount;
        private void FillcmbSpecificAccount()
        {
            using (var db = new DBcontextModel())
            {
                var q = from sa in db.SpecificAccounts

                        join ta in db.TotalAccounts
                        on sa.Id_TotalAccount equals ta.Id

                        join ga in db.GroupAccounts
                        on ta.Id_GroupAccount equals ga.Id

                        where (Code != 0 ? sa.Id == 1 || sa.Id == 2 : sa.Id > 0) &&
                (chkShowAllAccounts.Checked || (sa.Cod == 10302 || sa.Cod == 40101 || sa.Cod == 10301 || sa.Cod == 30101))
                        select new
                        {
                            sa.Id,
                            Code = sa.Cod,
                            Name = sa.Name,
                            groupAccount = ga.Name,
                            TotalAccount = ta.Name,
                        };
                cmbSpecificAccount.DataSource = q.ToList();
                dt_SpecificAccount = new System.Data.DataTable();
                dt_SpecificAccount = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }

        private void FillcmbNatureAccounts()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.NatureAccounts.Where(c => c.Id <= 2).ToList();
                cmbNatureAccounts.DataSource = q;
                cmbNatureAccounts.SelectedIndex = 0;
            }
        }

        private void FilldgvList()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    string FinancialYear = PublicClass.FinancialYear;
                    var q = from da in db.DetailedAccounts

                            join sa in db.SpecificAccounts
                            on da.SpecificAccountId equals sa.Id

                            join ta in db.TotalAccounts
                            on sa.Id_TotalAccount equals ta.Id

                            join ga in db.GroupAccounts
                            on ta.Id_GroupAccount equals ga.Id

                            join cu in db.Customers
                            on da.CustomerId equals cu.Id

                            join na in db.NatureAccounts
                            on ga.IdMahiyat equals na.Id

                            join tr in db.Transactions
                            on da.Id equals tr.DetailedAccountId
                            into trGroup

                            where sa.Name.Contains(cmbSpecificAccount.Text)

                            select new
                            {
                                Id = da.Id,
                                GroupAccountName = ga.Name,
                                TotalAccountName = ta.Name,
                                SpecificAccountName = sa.Name,
                                Name = (cu.Family + " " + cu.Name).Trim(),

                                NatureAccounts = na.Name,
                                DetailedAccountCode = da.CodeAccount,

                                Bed = trGroup.Where(c => c.FinancialYear == FinancialYear && !c.Status).Sum(t => (double?)t.PaymentBed) ?? 0,

                                Bes = trGroup.Where(c => c.FinancialYear == FinancialYear && !c.Status).Sum(t => (double?)t.PaymentBes) ?? 0,

                                Balance = Math.Abs((trGroup.Sum(t => (double?)t.PaymentBes) ?? 0) - (trGroup.Where(c => c.FinancialYear == FinancialYear && !c.Status).Sum(t => (double?)t.PaymentBed) ?? 0))
                            };

                    System.Data.DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt;
                    //dgvList.AutoSizeColumns();
                    PublicClass.SettingGridEX(dgvList);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void cmbCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCustomers, dt_Customers);

            }
        }

        private void cmbSpecificAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbSpecificAccount, dt_SpecificAccount);
            }

        }
        int SpecificAccountId = 0;
        int DetailedAccountCode = 0;
        private void cmbSpecificAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmbSpecificAccount.SelectedIndex == -1)
                {
                    FilldgvList();
                    return;
                }

                SpecificAccountId = Convert.ToInt32(cmbSpecificAccount.Value);
                lblCodeAccount.Text = PublicClass.CeratDetailedAccountCode(SpecificAccountId).ToString();
                FilldgvList();
                using (var db = new DBcontextModel())
                {
                    var q=db.SpecificAccounts.Where(c=>c.Id== SpecificAccountId).First();
                    
                    if (!chkShowAllAccounts.Checked)
                    {
                        if (q.Cod == 10301 || q.Cod == 30101)
                            rdbCash.Checked = true;
                        else if (q.Cod == 10302 || q.Cod == 40101)
                        {
                            rdbCheque.Checked = true;
                        }
                    }


                }



            }
            catch (Exception)
            {
            }
        }



        int CustomersId = 0;
        private void cmbCustomers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CustomersId = Convert.ToInt32(cmbCustomers.Value);
            }
            catch (Exception er)
            {
                //PublicClass.ShowErrorMessage(er);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSpecificAccount.SelectedIndex == -1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T071); return;
                }
                if (cmbCustomers.SelectedIndex == -1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T078); return;
                }
                //بررسی اطلاعات چک
                if (rdbCheque.Checked)
                {
                    if (txtAmount.Text == "")
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T081); return;
                    }
                    if (txtChequeNumber.Text == "")
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T138); return;
                    }
                    if (txtDueDate.Text.Length != 10)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T020); return;
                    }
                    if (cmbAccount.SelectedIndex == -1)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T156); return;
                    }
                    if (txtChequeOwner.Text == "")
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T137); return;
                    }
                    if (txtDescriptionCh.Text == "")
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T143); return;
                    }
                }

                using (var db = new DBcontextModel())
                {
                    if (ListId == 0)
                    {
                        int cont = db.DetailedAccounts.Count(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == CustomersId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T079); return;
                        }
                    }
                    else
                    {
                        int cont = db.DetailedAccounts.Count(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == CustomersId && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.
                                T006); return;
                        }
                    }
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            var userRepo = new Repository<Entity.Accounts.DetailedAccount.DetailedAccount>(db);
                            int DetailedAccountId_ = userRepo.SaveOrUpdateRefIdByCommit(new Entity.Accounts.DetailedAccount.DetailedAccount { Id = ListId, CodeAccount = Convert.ToInt32(lblCodeAccount.Text), SpecificAccountId = SpecificAccountId, CustomerId = CustomersId }, ListId);

                            if (ListId == 0)//ثبت
                            {
                                //ثبت سند مانده ابتدای دوره
                                if (txtAmount.Value != 0)//مبلغ ابتدای دوره
                                {
                                    string TransactionCode = PublicClass.CreatTransactionCode(1);
                                    int TransactionsCode = Convert.ToInt32(cmbNatureAccounts.Value) + 3;
                                    int Series = 0;
                                    string TransactionDate = PersianDate.NowPersianDate;
                                    double Amount = txtAmount.Value;
                                    {
                                        Series++;
                                        //نقدی
                                        if (rdbCash.Checked)
                                        {

                                            PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId_, Amount, TransactionsCode == 2 ? 0 : Amount, TransactionsCode == 2 ? Amount : 0, 0, "سند مانده ابتدای دوره", "", Series, false, true);
                                        }
                                        //چـــک
                                        {
                                            if (Convert.ToInt32(cmbNatureAccounts.Value) == 1)
                                            {//چک های دریافتنی

                                                //Series++;
                                                //اسناد دریافتنی در جریان وصول
                                                int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 10302).First().Id;
                                                int DetailedAccountid = 0;
                                                var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == CustomersId);
                                                if (serch1.Count() == 0)
                                                    DetailedAccountid = PublicClass.AddToDetailedAccounts(SpecificAccountId, CustomersId);
                                                else
                                                    DetailedAccountid = serch1.First().Id;
                                                //==================

                                                Amount = txtAmount.Value;
                                                //-------ثبت سند حسابداری در دیتابیس--------
                                                int TransactionId = PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountid, Amount, TransactionsCode == 2 ? 0 : Amount, TransactionsCode == 2 ? Amount : 0, 0, txtDescriptionCh.Text, Series, false, true);

                                                int ChequeTypeId_ = 0;
                                                if (TransactionsCode == 4)
                                                    ChequeTypeId_ = 1;
                                                else
                                                    ChequeTypeId_ = 2;
                                                //ثبت چک
                                                PublicClass.AddCheuqeToDatabase(db, 0, ChequeTypeId_, txtChequeNumber.Text, Amount, txtDueDate.Text, AccountId, DetailedAccountid, txtChequeOwner.Text, txtDescriptionCh.Text, TransactionId);

                                            }
                                            else
                                            {//چک های پرداختنی
                                             //Series++;
                                             //حساب ها و اسناد پرداختنی بلند مدت
                                                int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 40101).First().Id;

                                                int DetailedAccountid = 0;
                                                var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == CustomersId);
                                                if (serch1.Count() == 0)
                                                    DetailedAccountid = PublicClass.AddToDetailedAccounts(SpecificAccountId, CustomersId);
                                                else
                                                    DetailedAccountid = serch1.First().Id;

                                                Amount = txtAmount.Value;

                                                int TransactionId = PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountid, Amount, TransactionsCode == 2 ? 0 : Amount, TransactionsCode == 2 ? Amount : 0, 0, txtDescriptionCh.Text, Series, false, true);

                                                int ChequeTypeId_ = 0;
                                                if (TransactionsCode == 4)
                                                    ChequeTypeId_ = 1;
                                                else
                                                    ChequeTypeId_ = 2;

                                                //ثبت چک
                                                PublicClass.AddCheuqeToDatabase(db, 0, ChequeTypeId_, txtChequeNumber.Text, Amount, txtDueDate.Text, AccountId, DetailedAccountid, txtChequeOwner.Text, txtDescriptionCh.Text, TransactionId);

                                            }
                                        }


                                        {
                                            Series++;
                                            SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 90501).First().Id;

                                            int DetailedAccountId = 0;
                                            int customertId = db.Customers.Where(c => c.SecretCode == 10).First().Id;

                                            var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                            if (serch1.Count() == 0)
                                                DetailedAccountId = PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                            else
                                                DetailedAccountId = serch1.First().Id;
                                            PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount, TransactionsCode == 2 ? Amount : 0, TransactionsCode == 2 ? 0 : Amount, 0, "سند مانده ابتدای دوره", "", Series, false, true);
                                        }
                                    }
                                }
                            }

                            else//ویرایش
                            {
                                if (txtAmount.Enabled)
                                {
                                    //ثبت/ویرایش مانده ابتدای دوره
                                    if (txtAmount.Value != 0)
                                    {
                                        var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();
                                        var tr = db.Transactions.Where(c => c.SpecificAccountId == q.SpecificAccountId && c.DetailedAccountId == ListId && c.IsBeginningBalance);
                                        //ثبت سند مانده ابتدای دوره
                                        if (tr.Count() == 0)
                                        {
                                            string TransactionCode = PublicClass.CreatTransactionCode(1);
                                            int TransactionsCode = Convert.ToInt32(cmbNatureAccounts.Value) + 3;
                                            int Series = 0;
                                            string TransactionDate = PersianDate.NowPersianDate;
                                            double Amount = txtAmount.Value;
                                            {
                                                Series++;
                                                //نقدی
                                                if (rdbCash.Checked)

                                                {
                                                    PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, ListId, Amount, TransactionsCode == 2 ? 0 : Amount, TransactionsCode == 2 ? Amount : 0, 0, "سند مانده ابتدای دوره", "", Series, false, true);
                                                }

                                                //چـــک
                                                {
                                                    if (Convert.ToInt32(cmbNatureAccounts.Value) == 1)
                                                    {//چک های دریافتنی

                                                        //Series++;
                                                        //اسناد دریافتنی در جریان وصول
                                                        int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 10302).First().Id;
                                                        int DetailedAccountid = 0;
                                                        var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == CustomersId);
                                                        if (serch1.Count() == 0)
                                                            DetailedAccountid = PublicClass.AddToDetailedAccounts(SpecificAccountId, CustomersId);
                                                        else
                                                            DetailedAccountid = serch1.First().Id;
                                                        //==================

                                                        Amount = txtAmount.Value;
                                                        //-------ثبت سند حسابداری در دیتابیس--------
                                                        int TransactionId = PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountid, Amount, TransactionsCode == 2 ? 0 : Amount, TransactionsCode == 2 ? Amount : 0, 0, txtDescriptionCh.Text, Series, false, true);

                                                        int ChequeTypeId_ = 0;
                                                        if (TransactionsCode == 4)
                                                            ChequeTypeId_ = 1;
                                                        else
                                                            ChequeTypeId_ = 2;
                                                        //ثبت چک
                                                        PublicClass.AddCheuqeToDatabase(db, 0, ChequeTypeId_, txtChequeNumber.Text, Amount, txtDueDate.Text, AccountId, DetailedAccountid, txtChequeOwner.Text, txtDescriptionCh.Text, TransactionId);
                                                    }
                                                    else
                                                    {//چک های پرداختنی
                                                        //Series++;
                                                        //حساب ها و اسناد پرداختنی بلند مدت
                                                        int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 40101).First().Id;

                                                        int DetailedAccountid = 0;
                                                        var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == CustomersId);
                                                        if (serch1.Count() == 0)
                                                            DetailedAccountid = PublicClass.AddToDetailedAccounts(SpecificAccountId, CustomersId);
                                                        else
                                                            DetailedAccountid = serch1.First().Id;

                                                        Amount = txtAmount.Value;

                                                        int TransactionId = PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountid, Amount, TransactionsCode == 2 ? 0 : Amount, TransactionsCode == 2 ? Amount : 0, 0, txtDescriptionCh.Text, Series, false, true);

                                                        int ChequeTypeId_ = 0;
                                                        if (TransactionsCode == 4)
                                                            ChequeTypeId_ = 1;
                                                        else
                                                            ChequeTypeId_ = 2;
                                                        PublicClass.AddCheuqeToDatabase(db, 0, ChequeTypeId_, txtChequeNumber.Text, Amount, txtDueDate.Text, AccountId, DetailedAccountid, txtChequeOwner.Text, txtDescriptionCh.Text, TransactionId);

                                                    }
                                                }

                                                {
                                                    Series++;
                                                    SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 90501).First().Id;

                                                    int DetailedAccountId = 0;
                                                    int customertId = db.Customers.Where(c => c.SecretCode == 10).First().Id;

                                                    var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                                    if (serch1.Count() == 0)
                                                        DetailedAccountId = PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                                    else
                                                        DetailedAccountId = serch1.First().Id;
                                                    PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount, TransactionsCode == 2 ? Amount : 0, TransactionsCode == 2 ? 0 : Amount, 0, "سند مانده ابتدای دوره", "", Series, false, true);
                                                }
                                            }
                                        }
                                        //ویرایش سند مانده ابتدای دوره
                                        else
                                        {
                                            var tr1 = tr.First();
                                            var tr2 = db.Transactions.Where(c => c.Id == tr1.Id + 1).First();

                                            if (Convert.ToInt32(cmbNatureAccounts.Value) == 1)//Bed
                                            {
                                                tr1.PaymentBed = 0;
                                                tr1.PaymentBes = txtAmount.Value;

                                                tr2.PaymentBed = txtAmount.Value;
                                                tr2.PaymentBes = 0;
                                            }
                                            else//Bes
                                            {
                                                tr1.PaymentBed = txtAmount.Value;
                                                tr1.PaymentBes = 0;

                                                tr2.PaymentBed = 0;
                                                tr2.PaymentBes = txtAmount.Value;
                                            }
                                            tr1.Amount = txtAmount.Value;
                                            tr2.Amount = txtAmount.Value;
                                        }
                                    }
                                    else
                                    {
                                        if (MessageBox.Show(ResourceCode.T150, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                                        var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();
                                        var tr1 = db.Transactions.Where(c => c.SpecificAccountId == q.SpecificAccountId && c.DetailedAccountId == ListId && c.IsBeginningBalance).First();
                                        tr1.Status = true;
                                        var tr2 = db.Transactions.Where(c => c.Id == tr1.Id + 1).First();
                                        tr2.Status = true;
                                    }
                                }
                            }
                            db.SaveChanges();
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                        }
                    }

                    PublicClass.WindowAlart("1", "ویرایش با موفقیت انجام شد");
                    if (_updatableForms != null)
                        _updatableForms.UpdateData();
                    CelearItems();
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        private void CelearItems()
        {
            ListId = 0;
            cmbCustomers.ResetText();

            txtAmount.Value = 0;
            txtChequeNumber.ResetText();
            txtDescriptionCh.ResetText();
            txtChequeOwner.ResetText();
            cmbAccount.ResetText();
            cmbCustomers.Focus();
            lblCodeAccount.ResetText();
            lblCodeAccount.Text = PublicClass.CeratDetailedAccountCode(SpecificAccountId).ToString();
            rdbCash.Checked = true;
            FilldgvList();

        }

        int NatureAccountsId = 0;
        private void cmbNatureAccounts_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                NatureAccountsId = Convert.ToInt32(cmbNatureAccounts.Value);
            }
            catch (Exception)
            {
            }

        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Edit")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();

                        cmbSpecificAccount.Value = q.SpecificAccountId;
                        cmbCustomers.Value = q.CustomerId;
                        lblCodeAccount.Text = q.CodeAccount.ToString();
                        txtAmount.Value = 0;
                        var spId1 = db.SpecificAccounts.Where(c => c.Cod == 90501).First().Id;
                        //var spId2 = db.SpecificAccounts.Where(c => c.Cod==90501).First().Id;

                        var qt = db.Transactions.Where(c => c.DetailedAccountId == ListId && c.IsBeginningBalance && !c.Status);
                        if (qt.Count() != 0)
                        {
                            txtAmount.Value = qt.First().Amount;
                            if (qt.First().PaymentBed == 0)
                                cmbNatureAccounts.Value = 1;
                            else
                                cmbNatureAccounts.Value = 2;
                        }


                        //var s = db.Transactions.Where(c => c.SpecificAccountId == spId1).Count();
                        //if (s == 0)
                        //{
                        //    txtAmount.Enabled = false;
                        //    cmbNatureAccounts.Enabled = false;
                        //}
                        //else
                        //{
                        //    txtAmount.Enabled = true;
                        //    cmbNatureAccounts.Enabled = true;
                        //}

                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        if (db.Transactions.Where(c => c.DetailedAccountId == ListId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();
                            db.DetailedAccounts.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            FilldgvList();
                            CelearItems();
                        }
                    }

                }
                else if (e.Column.Key == "SelectAccount")
                {
                    using (var db = new DBcontextModel())
                    {
                        frmComers f = System.Windows.Forms.Application.OpenForms["frmComers"] as frmComers;
                        var q = db.DetailedAccounts.Where(c => c.Id == ListId).First();
                        var cu = db.Customers.Where(c => c.Id == q.CustomerId).First();
                        f.lblPaymentToOthers.Text = cu.Name + " " + cu.Family;
                        f.lblPaymentToOthers.Tag = q.Id;
                        this.Close();
                    }

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnAddNewSpecificAccount_Click(object sender, EventArgs e)
        {
            frmSpecificAccount f = new frmSpecificAccount(this);
            f.ShowDialog();
            FillcmbSpecificAccount();
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer(this);
            f.ShowDialog();
            FillcmbCustomers();
        }

        private void btnContraAccounts_Click(object sender, EventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.TypeAccounts_Id = 3;
            f.SpecificAccountCode = 10102;//بانک

            f.ShowList(3);
            f.ShowDialog();
            FillcmbCustomers();

        }

        private void btnOtherAccounts_Click(object sender, EventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.ShowDialog();
            FillcmbCustomers();
        }

        private void frmDetailedAccount_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cmbCustomers_Leave(object sender, EventArgs e)
        {
            if (cmbSpecificAccount.SelectedIndex != -1 && cmbCustomers.SelectedIndex != -1)
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == CustomersId);
                    if (q.Count() != 0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T079);
                        cmbCustomers.SelectedIndex = -1;
                        cmbCustomers.Focus();
                        return;
                    }
                }
            }
        }

        private void frmDetailedAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
            if (e.Control && e.KeyCode == Keys.F12) { UpdateData(); PublicClass.WindowAlart("1", ResourceCode.T161); }
        }

        private void dgvList_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void btnContraAccountsC_Click(object sender, EventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.TypeAccounts_Id = 4;
            f.SpecificAccountCode = 10101;//صندوق
            f.ShowList(4);
            f.ShowDialog();
            FillcmbCustomers();

        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }

        private void buttonX01_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            //f.Cod="1";
            f.grid = dgvList;
            //f.Condition="";
            //f.DateReport="گزارش تاریخ: "+PersianDate.NowPersianDate;
            f.TitelString = ResourceCode.TRdataileAccounts;
            f.ReporFileName = "HM_ERP_System.ReportViewer.Report_DetailedAccount.rdlc";
            f.ShowDialog();

        }

        private void rdbCash_CheckedChanged(object sender, EventArgs e)
        {
            pnlChequue.Visible = !rdbCash.Visible;
        }

        private void rdbCheque_CheckedChanged(object sender, EventArgs e)
        {
            pnlChequue.Visible = rdbCheque.Visible;

        }

        int AccountId = 0;
        private void cmbAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccount.SelectedIndex != -1)
                {
                    AccountId = Convert.ToInt32(cmbAccount.Value);
                }

            }
            catch (Exception)
            {

            }

        }

        private void chkShowAllAccounts_CheckedChanged(object sender, EventArgs e)
        {
            FillcmbSpecificAccount();
            rdbCash.Enabled= chkShowAllAccounts.Checked;
            rdbCheque.Enabled= chkShowAllAccounts.Checked;
        }

        private void btnAddNewCustomers_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer(this);
            f.ShowDialog();
            FillcmbCustomers();
        }
    }
}
