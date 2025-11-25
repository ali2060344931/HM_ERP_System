using HM_ERP_System.Class_General;
using HM_ERP_System.Forms.Accounts.ContraAccounts;
using HM_ERP_System.Forms.Accounts.DetailedAccount;
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

namespace HM_ERP_System.Forms.Accounts.TransferBetweenBanks
{
    public partial class frmTransferBetweenBanks : frmMasterForm, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int ListId_ = 0;
        int UserId_ = PublicClass.UserId;
        System.Data.DataTable dt_MultipleAccount;
        public frmTransferBetweenBanks(/*IUpdatableForms updatableForms*/)
        {
            InitializeComponent();
            //_updatableForms=updatableForms;
        }

        private void frmTransferBetweenBanks_Load(object sender, EventArgs e)
        {
            try
            {
                txtTransactionDate.Value = DateTime.Now;
                txtTransactionCode.Text=PublicClass.CreatTransactionCode();
                txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);
                txtDateEnd.Value = DateTime.Now;
                WindowState = FormWindowState.Maximized;
                UpdateData();

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        public void UpdateData()
        {
            FillcmbDetailedAccountsFr();
            FillcmbDetailedAccountsTo();
            //FillcmbDetailedAccountsTo();
            //AddColumnsToDataTable();
            FilldgvList();

        }
        private void FilldgvList()
        {
            try
            {
                List<int> requiredIds = new List<int> { 3 };
                PublicClass.FilldgvListTransaction(dgvList, txtDateStart.Text, txtDateEnd.Text, requiredIds);

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        System.Data.DataTable dt_DetailedAccountsTo;
        private void FillcmbDetailedAccountsTo()
        {
            string FinancialYear = PublicClass.FinancialYear;
            try
            {
                using (var db = new DBcontextModel())
                {
                    var spid1 = db.SpecificAccounts.Where(c => c.Cod == 10101).First().Id;
                    var spid2 = db.SpecificAccounts.Where(c => c.Cod == 10102).First().Id;
                    var q = from dt in db.DetailedAccounts

                            join cu in db.Customers
                            on dt.CustomerId equals cu.Id

                            //                            from shLeft in shGroup.DefaultIfEmpty()

                            join brb in db.BankBranches
                            on cu.BanckId equals brb.Id into brbGroup
                            from brb_ in brbGroup.DefaultIfEmpty()

                            join ba in db.Bancks
                            on brb_.BanckId equals ba.Id into baGroup
                            from ba_ in baGroup.DefaultIfEmpty()

                            join tc in db.TypeCustomers
                            on cu.id_TypeCustomer equals tc.Id

                            join tr in db.Transactions
                            on dt.Id equals tr.DetailedAccountId
                            into trGroup

                            where dt.SpecificAccountId == spid1 || dt.SpecificAccountId == spid2

                            select new
                            {
                                dt.Id,
                                name = (cu.Family + " " + cu.Name).Trim(),
                                TypeAccount = tc.Name,
                                AccountCode = dt.CodeAccount,
                                AccountNumber = cu.AccountNumber,
                                BanckName = brb_ != null ? brb_.Name + " - " + ba_.Name : "-",

                                AccountBalance = Math.Abs((trGroup.Sum(t => (double?)t.PaymentBes) ?? 0) - (trGroup.Where(c => c.FinancialYear == FinancialYear).Sum(t => (double?)t.PaymentBed) ?? 0))
                            };

                    cmbDetailedAccountsTo.DataSource= q.ToList();

                    dt_DetailedAccountsTo = new System.Data.DataTable();
                    dt_DetailedAccountsTo = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        System.Data.DataTable dt_DetailedAccountsFr;
        private void FillcmbDetailedAccountsFr()
        {
            try
            {
                string FinancialYear = PublicClass.FinancialYear;
                using (var db = new DBcontextModel())
                {
                    var spid1 = db.SpecificAccounts.Where(c => c.Cod==10101).First().Id;
                    var spid2 = db.SpecificAccounts.Where(c => c.Cod==10102).First().Id;
                    var q = from dt in db.DetailedAccounts

                            join cu in db.Customers
                            on dt.CustomerId equals cu.Id

                            //                            from shLeft in shGroup.DefaultIfEmpty()

                            join brb in db.BankBranches 
                            on cu.BanckId equals brb.Id into brbGroup
                            from brb_ in brbGroup.DefaultIfEmpty()

                            join ba in db.Bancks
                            on brb_.BanckId equals ba.Id into baGroup
                            from ba_ in baGroup.DefaultIfEmpty()

                            join tc in db.TypeCustomers
                            on cu.id_TypeCustomer equals tc.Id

                            join tr in db.Transactions
                            on dt.Id equals tr.DetailedAccountId
                            into trGroup

                            where dt.SpecificAccountId==spid1 || dt.SpecificAccountId==spid2

                            select new
                            {
                                dt.Id,
                                name = (cu.Family+" "+cu.Name).Trim(),
                                TypeAccount = tc.Name,
                                AccountCode = dt.CodeAccount,
                                AccountNumber = cu.AccountNumber,
                                BanckName=brb_!=null ? brb_.Name +" - "+ba_.Name:"-",

                                AccountBalance = Math.Abs((trGroup.Sum(t => (double?)t.PaymentBes) ?? 0) - (trGroup.Where(c => c.FinancialYear == FinancialYear).Sum(t => (double?)t.PaymentBed) ?? 0)) 
                            };

                    cmbDetailedAccountsFr.DataSource= q.ToList();
                    dt_DetailedAccountsFr = new System.Data.DataTable();
                    dt_DetailedAccountsFr = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void cmbDetailedAccountsFr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDetailedAccountsFr, dt_DetailedAccountsFr);
            }
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

        private void txtTotalAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }
        int DetailedAccountsFrId = 0;
        double AccountBalancF = 0;
        double AccountBalancT = 0;
        private void cmbDetailedAccountsFr_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDetailedAccountsFr.SelectedIndex!=-1)
                {
                    DetailedAccountsFrId = Convert.ToInt32(cmbDetailedAccountsFr.Value);

                    using (var db = new DBcontextModel())
                    {
                        var spid = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsFrId).First().SpecificAccountId;
                        AccountBalancF=PublicClass.DetailedAccountsBalance(spid, DetailedAccountsFrId);

                        lblAccountBalancF.Text=AccountBalancF.ToString("#,##0;(#,##0)");
                    }

                }
                else
                    lblAccountBalancF.Text="0";
            }
            catch (Exception)
            {
            }

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
                        var spid = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsToId).First().SpecificAccountId;
                        AccountBalancT=PublicClass.DetailedAccountsBalance(spid, DetailedAccountsToId);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ControlFildes()) return;
                txtTransactionCode.Text=PublicClass.CreatTransactionCode();
                int Series = 0;
                if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                using (var db = new DBcontextModel())
                {

                    string TransactionCode = txtTransactionCode.Text;
                    string TransactionDate = txtTransactionDate.Text;
                    double Amount = Convert.ToDouble(txtAmount1.TextSimple);
                    using (var transaction = db.Database.BeginTransaction())
                        try
                        {
                            {
                                var SpecificAccountIdF_ = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsFrId).First().SpecificAccountId;
                                var SpecificAccountIdT_ = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsToId).First().SpecificAccountId;


                                Series++;
                                PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, 3, SpecificAccountIdF_, DetailedAccountsFrId, Amount, 0, Amount, 0, txtDescription.Text, txtSeryalNumber.Text, Series, false);

                                Series++;
                                PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, 3, SpecificAccountIdT_, DetailedAccountsToId, Amount, Amount, 0, 0, txtDescription.Text, txtSeryalNumber.Text, Series, false);


                                double Amount2 = 0;
                                if (txtAmount2.Text!="")
                                    Amount2 = Convert.ToDouble(txtAmount2.TextSimple);

                                if (Amount2!=0)
                                {
                                    string txtKrmozd = "کارمز انتقال وجه ";
                                    int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==80802).First().Id;
                                    int DetailedAccountId = 0;
                                    int customertId = db.Customers.Where(c => c.SecretCode==7).First().Id;

                                    var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                                    if (serch1.Count()==0)
                                        DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                    else
                                        DetailedAccountId=serch1.First().Id;
                                    
                                    
                                    Series++;
                                    PublicClass.AccountingDocumentRegistration(db, ListId, Convert.ToInt32(TransactionCode), TransactionDate, 5, SpecificAccountIdF_, DetailedAccountsFrId, Amount2,  0, Amount2,0, txtKrmozd+txtDescription.Text, txtSeryalNumber.Text, Series, false);

                                    Series++;
                                    PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, 5, SpecificAccountId, DetailedAccountId, Amount2,  Amount2,  0, 0, txtKrmozd+txtDescription.Text, txtSeryalNumber.Text, Series, false);



                                }
                            }
                            db.SaveChanges();
                            transaction.Commit();

                            PublicClass.WindowAlart("1");
                            if (_updatableForms!=null)
                                _updatableForms.UpdateData();
                            CelearItems();
                        }
                        catch (Exception er)
                        {
                            transaction.Rollback();
                            PublicClass.ShowErrorMessage(er);
                        }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void CelearItems()
        {
            try
            {
                cmbDetailedAccountsFr.ResetText();
                cmbDetailedAccountsTo.ResetText();
                txtAmount1.ResetText();
                txtSeryalNumber.ResetText();
                txtDescription.ResetText();
                FillcmbDetailedAccountsFr();
                FillcmbDetailedAccountsTo();
                FilldgvList();
                txtTransactionDate.Focus();

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
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

                if (cmbDetailedAccountsFr.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T078);
                    cmbDetailedAccountsFr.Focus();
                    return true;
                }
                if (cmbDetailedAccountsTo.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T078);
                    cmbDetailedAccountsTo.Focus();
                    return true;
                }
                if (cmbDetailedAccountsFr.Value==cmbDetailedAccountsTo.Value)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T145);
                    return true;
                }

                if (txtAmount1.Text=="")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T081);
                    txtAmount1.Focus();
                    return true;
                }
                if (txtSeryalNumber.Text=="")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T146);
                    txtSeryalNumber.Focus();
                    return true;
                }
                if (txtDescription.Text=="")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T143);
                    txtDescription.Focus();
                    return true;
                }

                if(Convert.ToInt64(txtAmount1.TextSimple)>AccountBalancF)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T116);
                    txtAmount1.Focus();
                    return true;

                }
                return false;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void btnCreatDescription_Click(object sender, EventArgs e)
        {
            txtDescription.Text= "سند جابجایی به مبلغ "+ txtAmount1.Text +" ریال در مورخ "+txtTransactionDate.Text+" به شماره سند "+txtTransactionCode.Text + " بابت  ";
        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvList();

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            //frmDetailedAccount f = new frmDetailedAccount(this);
            //f.IsRequest=true;
            //f.Code=1;
            //f.ShowDialog();
            //FillcmbDetailedAccountsFr();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //using (var db = new DBcontextModel())
            //{
            //    frmDetailedAccount f = new frmDetailedAccount(this);
            //    f.IsRequest=true;
            //    f.Code=1;
            //    f.ShowDialog();
            //    FillcmbDetailedAccountsTo();
            //}

        }

        private void btnAddNewBanck1_Click(object sender, EventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.cmbTypeAccounts.Enabled = false;
            f.TypeAccounts_Id=3;
            f.SpecificAccountCode=10102;//بانک
            f.ShowList(3);
            f.ShowDialog();
            FillcmbDetailedAccountsTo();
        }

        private void btnAddNewBanck2_Click(object sender, EventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.cmbTypeAccounts.Enabled = false;
            f.TypeAccounts_Id=3;
            f.SpecificAccountCode=10102;//بانک
            f.ShowList(3);
            f.ShowDialog();
            FillcmbDetailedAccountsTo();

        }

        private void btnAddNewCofer1_Click(object sender, EventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.cmbTypeAccounts.Enabled = false;
            f.TypeAccounts_Id=4;
            f.SpecificAccountCode=10101;//صندوق
            f.ShowList(4);
            f.ShowDialog();
            FillcmbDetailedAccountsTo();
        }

        private void btnAddNewCofer2_Click(object sender, EventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.cmbTypeAccounts.Enabled = false;
            f.TypeAccounts_Id=4;
            f.SpecificAccountCode=10101;//صندوق
            f.ShowList(4);
            f.ShowDialog();
            FillcmbDetailedAccountsTo();
        }

        private void rcmDetails_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
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
                            if (db.DocumentBancks.Where(c => c.FormName == Name && c.ListInFoemId==ListId).Count() != 0)
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
                        //FilldgvList();
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

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
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
    }
}
