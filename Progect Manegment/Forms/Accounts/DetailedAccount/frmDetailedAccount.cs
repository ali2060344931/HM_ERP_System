using DevComponents.DotNetBar;

using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.NatureAccount;
using HM_ERP_System.Entity.Accounts.SpecificAccount;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Accounts.ContraAccounts;
using HM_ERP_System.Forms.Accounts.SpecificAccount;
using HM_ERP_System.Forms.Comers;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.Main_Form;

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
            _updatableForms=updatableForms;
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

            if (cmbSpecificAccountValue != 0)
            {
                if (Code==0)
                {
                    cmbSpecificAccount.Value= cmbSpecificAccountValue;
                    cmbSpecificAccount.Enabled=false;
                }
                else
                {
                    FillcmbSpecificAccount();
                }
            }

            if (IsRequest)
                dgvList.RootTable.Columns["SelectAccount"].Visible=true;
            else
                dgvList.RootTable.Columns["SelectAccount"].Visible=false;

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

                            select new
                            {
                                cu.Id,
                                name = (cu.Family +" "+ cu.Name).Trim(),
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

                        where Code!=0 ? sa.Id==1 || sa.Id==2 : sa.Id>0

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
                var q = db.NatureAccounts.Where(c => c.Id<=2).ToList();
                cmbNatureAccounts.DataSource=q;
                cmbNatureAccounts.SelectedIndex=0;
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

                                Bed = trGroup.Where(c => c.FinancialYear==FinancialYear && !c.Status).Sum(t => (double?)t.PaymentBed) ?? 0,

                                Bes = trGroup.Where(c => c.FinancialYear==FinancialYear && !c.Status).Sum(t => (double?)t.PaymentBes) ?? 0,

                                Balance = Math.Abs((trGroup.Sum(t => (double?)t.PaymentBes) ?? 0) - (trGroup.Where(c => c.FinancialYear == FinancialYear && !c.Status).Sum(t => (double?)t.PaymentBed) ?? 0))
                            };

                    dgvList.DataSource = q.ToList();
                    dgvList.AutoSizeColumns();
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

                if (cmbSpecificAccount.SelectedIndex==-1)
                {
                    FilldgvList();
                    return;
                }

                SpecificAccountId = Convert.ToInt32(cmbSpecificAccount.Value);
                lblCodeAccount.Text=PublicClass.CeratDetailedAccountCode(SpecificAccountId).ToString();
                FilldgvList();
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
                if (cmbSpecificAccount.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T071); return;
                }
                if (cmbCustomers.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T078); return;
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
                            int Id = userRepo.SaveOrUpdateRefIdByCommit(new Entity.Accounts.DetailedAccount.DetailedAccount { Id = ListId, SpecificAccountId=SpecificAccountId, CustomerId=CustomersId, CodeAccount=Convert.ToInt32(lblCodeAccount.Text) }, ListId);

                            //ثبت سند مانده ابتدای دوره
                            if (ListId==0)
                            {
                                if (txtAmount.Value!=0)
                                {
                                    string TransactionCode = PublicClass.CreatTransactionCode(1);
                                    int TransactionsCode = Convert.ToInt32(cmbNatureAccounts.Value)+3;
                                    int Series = 0;
                                    string TransactionDate = PersianDate.NowPersianDate;
                                    double Amount = txtAmount.Value;
                                    {
                                        Series++;
                                        PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, Id, Amount, TransactionsCode==2 ? 0 : Amount, TransactionsCode==2 ? Amount : 0, 0, "سند مانده ابتدای دوره", "", Series, false);



                                        Series++;
                                        SpecificAccountId=db.SpecificAccounts.Where(c => c.Cod==90501).First().Id;

                                        int DetailedAccountId = 0;
                                        int customertId = db.Customers.Where(c => c.SecretCode==10).First().Id;

                                        var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                                        if (serch1.Count()==0)
                                            DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                        else
                                            DetailedAccountId=serch1.First().Id;
                                        PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount, TransactionsCode==2 ? Amount : 0, TransactionsCode==2 ? 0 : Amount, 0, "سند مانده ابتدای دوره", "", Series, false);
                                    }
                                }
                            }

                            else//ویرایش مانده ابتدای دوره
                            {
                                if (txtAmount.Enabled)
                                {
                                    if (txtAmount.Value!=0)
                                    {
                                        var q = db.DetailedAccounts.Where(c => c.Id==ListId).First();
                                        var tr = db.Transactions.Where(c => c.SpecificAccountId==q.SpecificAccountId && c.DetailedAccountId==q.Id && c.IsBeginningBalance).ToList();
                                        foreach (var item in tr)
                                        {
                                            var Edit = db.Transactions.Where(c => c.Id==item.Id).First();
                                            Edit.Amount=txtAmount.Value;
                                            if (Convert.ToInt32(cmbNatureAccounts.Value)==1)//Bed
                                            {
                                                Edit.PaymentBed=txtAmount.Value;
                                                Edit.PaymentBes=0;
                                            }
                                            else//Bes
                                            {
                                                Edit.PaymentBed=0;
                                                Edit.PaymentBes=txtAmount.Value;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (MessageBox.Show(ResourceCode.T150, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                                        var q = db.DetailedAccounts.Where(c => c.Id==ListId).First();
                                        var tr = db.Transactions.Where(c => c.SpecificAccountId==q.SpecificAccountId && c.DetailedAccountId==q.Id && c.IsBeginningBalance).ToList();
                                        foreach (var item in tr)
                                        {
                                            var Edit = db.Transactions.Where(c => c.Id==item.Id).First();
                                            Edit.Status=true;
                                        }
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
                    if (_updatableForms!=null)
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
            txtAmount.Value=0;
            cmbCustomers.Focus();
            lblCodeAccount.ResetText();
            lblCodeAccount.Text= PublicClass.CeratDetailedAccountCode(SpecificAccountId).ToString();
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
                        cmbCustomers.Value=q.CustomerId;
                        lblCodeAccount.Text=q.CodeAccount.ToString();
                        txtAmount.Value=0;
                        var spId1 = db.SpecificAccounts.Where(c => c.Cod==90301).First().Id;
                        //var spId2 = db.SpecificAccounts.Where(c => c.Cod==90501).First().Id;

                        var qt = db.Transactions.Where(c => c.DetailedAccountId== ListId && c.IsBeginningBalance && !c.Status);
                        var s = db.Transactions.Where(c => c.SpecificAccountId==spId1).Count();

                        if (s!=0)
                        {
                            txtAmount.Enabled=false;
                            cmbNatureAccounts.Enabled=false;
                        }
                        else
                        {
                            txtAmount.Enabled=true;
                            cmbNatureAccounts.Enabled=true;
                        }

                        if (qt.Count()!=0)
                        {
                            txtAmount.Value= qt.First().Amount;
                            if (qt.First().PaymentBed!=0)
                                cmbNatureAccounts.Value=1;
                            else
                                cmbNatureAccounts.Value = 2;
                        }
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
                        var q = db.DetailedAccounts.Where(c => c.Id== ListId).First();
                        var cu = db.Customers.Where(c => c.Id==q.CustomerId).First();
                        f.lblPaymentToOthers.Text = cu.Name +" "+ cu.Family;
                        f.lblPaymentToOthers.Tag =q.Id;
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
            f.TypeAccounts_Id=3;
            f.SpecificAccountCode=10102;//بانک

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
            if (cmbSpecificAccount.SelectedIndex!=-1 &&  cmbCustomers.SelectedIndex!=-1)
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==CustomersId);
                    if (q.Count()!=0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T079);
                        cmbCustomers.SelectedIndex=-1;
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
            f.TypeAccounts_Id=4;
            f.SpecificAccountCode=10101;//صندوق
            f.ShowList(4);
            f.ShowDialog();
            FillcmbCustomers();

        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}
