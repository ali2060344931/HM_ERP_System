using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.Cheque;
using HM_ERP_System.Entity.Customer;
using HM_ERP_System.Entity.TypeDocument;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.Main_Form;

using Janus.Windows.UI.Dock;

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

using Telerik.WinControls;

namespace HM_ERP_System.Forms.Accounts.TransferBetweenPersons
{
    public partial class frmTransferBetweenPersons : frmMasterForm, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int ListId_ = 0;
        int UserId_ = PublicClass.UserId;
        System.Data.DataTable dt_MultipleAccount;
        public System.Data.DataTable dt_Cheque1;
        public System.Data.DataTable dt_Cheque2;

        public frmTransferBetweenPersons(/*IUpdatableForms updatableForms*/)
        {
            InitializeComponent();
            //_updatableForms=updatableForms;

        }

        private void frmTransferBetweenPersons_Load(object sender, EventArgs e)
        {

            txtTransactionDate.Value = DateTime.Now;
            txtTransactionCode.Text=PublicClass.CreatTransactionCode();

            txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);
            txtDateEnd.Value = DateTime.Now;
            WindowState = FormWindowState.Maximized;

            UpdateData();
        }
        public void UpdateData()
        {
            FillcmbSpecificAccountTo();
            FillcmbDetailedAccountsFrom();
            FillcmbDetailedAccountsTo();
            AddColumnsToDataTable();
            FilldgvList();

        }

        void AddColumnsToDataTable()
        {
            dt_MultipleAccount=new System.Data.DataTable();
            dt_MultipleAccount.Columns.Add("SpecificAccountId", typeof(int));
            dt_MultipleAccount.Columns.Add("DetailedAccountId", typeof(int));
            dt_MultipleAccount.Columns.Add("SpecificAccount", typeof(string));
            dt_MultipleAccount.Columns.Add("DetailedAccount", typeof(string));
            dt_MultipleAccount.Columns.Add("Amount", typeof(long));
            dt_MultipleAccount.Columns.Add("SeryalNumber", typeof(string));
            dt_MultipleAccount.Columns.Add("Des", typeof(string));
            DataColumn productColumn = dt_MultipleAccount.Columns["DetailedAccountId"];
            dt_MultipleAccount.PrimaryKey = new DataColumn[] { productColumn };
        }


        DataTable dt_SpecificAccountTo;
        private void FillcmbSpecificAccountTo()
        {
            /*
            using (var db = new DBcontextModel())
            {
                var q = from sp in db.SpecificAccounts
                        
                        join ta in db.TotalAccounts
                        on sp.Id_TotalAccount equals ta.Id

                        join da in db.DetailedAccounts
                        on sp.Id equals da.SpecificAccountId

                        where (sp.Cod == 10301 || sp.Cod == 30101) && da.CustomerId == customerToId
                        select new
                        {
                            sp.Id,
                            sp.Name,
                            Code = sp.Cod,
                            TotalAccountName = ta.Name,
                        };

                var distinctResults = q.Distinct().ToList();
                cmbSpecificAccountTo.DataSource = distinctResults;
                dt_SpecificAccountTo = PublicClass.AddEntityTableToDataTable(distinctResults);
            }
            */
            using (var db = new DBcontextModel())
            {
                var q = from sp in db.SpecificAccounts

                        join ta in db.TotalAccounts
                        on sp.Id_TotalAccount equals ta.Id

                        where (sp.Cod==10301 || sp.Cod==30101)
                        select new
                        {
                            sp.Id,
                            sp.Name,
                            Code = sp.Cod,
                            TotalAccountName = ta.Name,

                        };
                cmbSpecificAccountTo.DataSource=q.ToList();
                dt_SpecificAccountTo = new System.Data.DataTable();
                dt_SpecificAccountTo = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }

        DataTable dt_DetailedAccountsFrom;
        private void FillcmbDetailedAccountsFrom()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cu in db.Customers
                            join tc in db.TypeCustomers
                            on cu.id_TypeCustomer equals tc.Id
                            where cu.id_TypeCustomer<=2
                            orderby cu.Name, cu.Family
                            select new
                            {
                                cu.Id,
                                Name = (cu.Family.Trim()+" " + cu.Name.Trim()).Trim(),
                                cu.CodMeli,
                                TypeAccount = tc.Name,
                            };
                    cmbDetailedAccountsFrom.DataSource=q.ToList();
                    dt_DetailedAccountsFrom = new System.Data.DataTable();
                    dt_DetailedAccountsFrom = PublicClass.AddEntityTableToDataTable(q.ToList());
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        DataTable dt_DetailedAccountsTo;
        private void FillcmbDetailedAccountsTo()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cu in db.Customers

                            join tc in db.TypeCustomers
                            on cu.id_TypeCustomer equals tc.Id

                            where cu.id_TypeCustomer<=2
                            orderby cu.Name, cu.Family
                            select new
                            {
                                cu.Id,
                                Name = (cu.Family.Trim()+" " + cu.Name.Trim()).Trim(),
                                cu.CodMeli,
                                TypeAccount = tc.Name,
                            };
                    cmbDetailedAccountsTo.DataSource=q.ToList();
                    dt_DetailedAccountsTo = new System.Data.DataTable();
                    dt_DetailedAccountsTo = PublicClass.AddEntityTableToDataTable(q.ToList());
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FilldgvList()
        {
            List<int> requiredIds = new List<int> { 3 };
            PublicClass.FilldgvListTransaction(dgvList, txtDateStart.Text, txtDateEnd.Text, requiredIds);
        }

        int customerIdFr = 0;
        /// <summary>
        /// دریافتنی
        /// </summary>
        double AccountBalancD = 0;
        /// <summary>
        /// پرداختنی
        /// </summary>
        double AccountBalancP = 0;

        private void cmbDetailedAccountsFrom_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbDetailedAccountsFrom.SelectedIndex==-1)
                {
                    lblAccountBalancF.Text="0";
                    return;
                }
                customerIdFr = Convert.ToInt32(cmbDetailedAccountsFrom.Value);

                AccountBalancP=0; AccountBalancD=0;

                using (var db = new DBcontextModel())
                {
                    var SpecificAccountIdD = db.SpecificAccounts.Where(c => c.Cod==10301).First().Id;

                    var SpecificAccountIdP = db.SpecificAccounts.Where(c => c.Cod==30101).First().Id;

                    var DetailedAccountsFromIdD_ = db.DetailedAccounts.Where(c => c.CustomerId==customerIdFr && c.SpecificAccountId==SpecificAccountIdD);

                    var DetailedAccountsFromIdP_ = db.DetailedAccounts.Where(c => c.CustomerId==customerIdFr && c.SpecificAccountId==SpecificAccountIdP);

                    if (DetailedAccountsFromIdD_.Count()!=0)
                    {
                        AccountBalancD=PublicClass.DetailedAccountsBalance(SpecificAccountIdD, DetailedAccountsFromIdD_.First().Id);
                    }
                    if (DetailedAccountsFromIdP_.Count()!=0)
                    {
                        AccountBalancP=PublicClass.DetailedAccountsBalance(SpecificAccountIdP, DetailedAccountsFromIdP_.First().Id);
                    }

                    lblAccountBalancF.Text=(AccountBalancP-AccountBalancD).ToString("#,##0;(#,##0)");

                }
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

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer(this);
            f.ShowDialog();
            FillcmbDetailedAccountsFrom();
        }

        private void txtTotalAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
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

        int customerToId = 0;
        double AccountBalancT = 0;
        private void cmbDetailedAccountsTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDetailedAccountsTo.SelectedIndex!=-1)
                {
                    customerToId = Convert.ToInt32(cmbDetailedAccountsTo.Value);

                    //cmbSpecificAccountTo.ResetText();
                    //FillcmbSpecificAccountTo();

                    AccountBalancP=0; AccountBalancD=0;

                    using (var db = new DBcontextModel())
                    {
                        var SpecificAccountIdD = db.SpecificAccounts.Where(c => c.Cod==10301).First().Id;

                        var SpecificAccountIdP = db.SpecificAccounts.Where(c => c.Cod==30101).First().Id;

                        var DetailedAccountsFromIdD_ = db.DetailedAccounts.Where(c => c.CustomerId==customerToId && c.SpecificAccountId==SpecificAccountIdD);

                        var DetailedAccountsFromIdP_ = db.DetailedAccounts.Where(c => c.CustomerId==customerToId && c.SpecificAccountId==SpecificAccountIdP);

                        if (DetailedAccountsFromIdD_.Count()!=0)
                        {
                            AccountBalancD=PublicClass.DetailedAccountsBalance(SpecificAccountIdD, DetailedAccountsFromIdD_.First().Id);
                        }
                        if (DetailedAccountsFromIdP_.Count()!=0)
                        {
                            AccountBalancP=PublicClass.DetailedAccountsBalance(SpecificAccountIdP, DetailedAccountsFromIdP_.First().Id);
                        }

                        lblAccountBalancT.Text=(AccountBalancP-AccountBalancD).ToString("#,##0;(#,##0)");

                    }

                }
                else
                    lblAccountBalancT.Text="0";


            }
            catch (Exception)
            {
            }
        }

        private void cmbSpecificAccountTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbSpecificAccountTo, dt_SpecificAccountTo);

            }

        }
        int SpecificAccountToId = 0;
        private void cmbSpecificAccountTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSpecificAccountTo.SelectedIndex!=-1)
                {
                    SpecificAccountToId = Convert.ToInt32(cmbSpecificAccountTo.Value);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvList();
        }

        private void txtAmount1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            AddDataToCashTable();
        }

        private void AddDataToCashTable()
        {
            if (PublicClass.FindEmptyControls(cmbDetailedAccountsTo, ResourceCode.T078,cmbSpecificAccountTo, ResourceCode.T127,  txtAmount, ResourceCode.T081, txtDescriptionCa, ResourceCode.T136))
                return;


            DataRow existingRowF = dt_MultipleAccount.Rows.Find(customerIdFr);

            DataRow existingRowT = dt_MultipleAccount.Rows.Find(customerToId);
            if (customerIdFr == customerToId)
            {
                PublicClass.StopMesseg(ResourceCode.T144);
                return;
            }

            if (existingRowT == null)
            {
                DataRow newrow = dt_MultipleAccount.NewRow();
                newrow["SpecificAccountId"]=SpecificAccountToId;
                newrow["DetailedAccountId"]=customerToId;
                newrow["SpecificAccount"]=cmbSpecificAccountTo.Text;
                newrow["DetailedAccount"]=cmbDetailedAccountsTo.Text;
                newrow["Amount"]=txtAmount.TextSimple;
                newrow["SeryalNumber"]=txtSeryalNumber.Text;
                newrow["Des"]=txtDescriptionCa.Text;
                dt_MultipleAccount.Rows.Add(newrow);
                dgvListMulti.DataSource=dt_MultipleAccount;
                dgvListMulti.AutoSizeColumns();
                CalcTotalAmountAddToItems();
                celerCashItems();
            }
            else
            {
                PublicClass.StopMesseg(ResourceCode.T142);
                return;
            }
        }

        double TotalAmountCash1 = 0;
        int TotalAmountCash1C = 0;

        (double, int) CalcTotalAmount()
        {
            TotalAmountCash1 = dgvListMulti.GetRows().Select(row => Convert.ToDouble(row.Cells["Amount"].Value)).Sum();

            TotalAmountCash1C = dgvListMulti.GetRows().Select(row => Convert.ToInt32(row.Cells["Amount"].Value)).Count();
            return (TotalAmountCash1, TotalAmountCash1C);
        }

        /// <summary>
        /// نمایش مجموع مبالغ
        /// </summary>
        
        void CalcTotalAmountAddToItems()
        {
            //CelearItemslblAmounts();
            double S = 0;
            double C = 0;
            (S, C)=CalcTotalAmount();

            //lblTotlSum.Text=(Convert.ToInt64(txtTotalAmount.TextSimple) -S).ToString("#,##0");
            //lblTotlSumC.Text=C.ToString();
        }
        private void celerCashItems()
        {
            cmbDetailedAccountsTo.ResetText();
            cmbSpecificAccountTo.ResetText();
            txtAmount.ResetText();
            txtSeryalNumber.ResetText();
            //txtDescriptionCa.ResetText();
            cmbDetailedAccountsTo.Focus();
        }

        private void dgvListMulti_RecordsDeleted(object sender, EventArgs e)
        {
            CalcTotalAmountAddToItems();
        }

        private void btnAddDetailedAccountsTo_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer(this);
            f.ShowDialog();
            FillcmbDetailedAccountsTo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ControlFildes()) return;
            txtTransactionCode.Text=PublicClass.CreatTransactionCode();
            int Series = 0;
            if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (var db = new DBcontextModel())
            {

                string TransactionCode = txtTransactionCode.Text;
                string TransactionDate = txtTransactionDate.Text;
                double Amount =0;
                int Count =0;
                using (var transaction = db.Database.BeginTransaction())
                    try
                    {
                        (Amount, Count)=CalcTotalAmount(); 
                        {
                            Series++;

                            int DetailedAccountId = 0;

                            var SpecificAccountIdF_ = db.SpecificAccounts.Where(c => c.Cod==10301).First().Id;

                            var customertId = customerIdFr;
                            var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountIdF_ && c.CustomerId==customertId);
                            if (serch1.Count()==0)
                                DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountIdF_, customertId);
                            else
                                DetailedAccountId=serch1.First().Id;

                            PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, 3, SpecificAccountIdF_, DetailedAccountId, Amount, Amount, 0, 0, txtDescription.Text, "", Series, false);
                        }
                        //ثبت مبالغ لیست
                        if (dt_MultipleAccount!=null)
                        {
                            foreach (DataRow r in dt_MultipleAccount.Rows)
                            {
                                Series++;
                                int SpecificAccountId_ = Convert.ToInt32(r["SpecificAccountId"]);
                                int DetailedAccountId = 0;

                                var customertId = Convert.ToInt32(r["DetailedAccountId"]);
                                var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId_ && c.CustomerId==customertId);
                                if (serch1.Count()==0)
                                    DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId_, customertId);
                                else
                                    DetailedAccountId=serch1.First().Id;




                                Amount = Convert.ToDouble(r["Amount"]);
                                PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, 3, SpecificAccountId_, DetailedAccountId, Amount, 0, Amount, 0, r["Des"].ToString(), r["SeryalNumber"].ToString(), Series, false);
                            }
                        }
                        db.SaveChanges();
                        transaction.Commit();

                        PublicClass.WindowAlart("1");
                        if (_updatableForms!=null)
                            _updatableForms.UpdateData();
                        CelearItems();
                        FilldgvList();
                    }
                    catch (Exception er)
                    {
                        transaction.Rollback();
                        PublicClass.ShowErrorMessage(er);
                    }
            }
        }
        void FilldgvListMulti()
        {
            dgvListMulti.DataSource=null;
            dgvListMulti.DataSource= dt_MultipleAccount;
        }

        private void CelearItems()
        {
            cmbDetailedAccountsFrom.ResetText();
            //txtTotalAmount.ResetText();
            txtAmount.ResetText();
            txtDescription.ResetText();
            txtDescriptionCa.ResetText();
            cmbSpecificAccountTo.ResetText();
            celerCashItems();
            AddColumnsToDataTable();
            FilldgvListMulti();
            cmbDetailedAccountsFrom.Focus();

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

                if (cmbDetailedAccountsFrom.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T078);
                    cmbDetailedAccountsFrom.Focus();
                    return true;
                }
                if (dt_MultipleAccount.Rows.Count==0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T144);
                    return true;

                }
                
                //double Amount = 0;
                //int count = 0;
                //(Amount, count)= CalcTotalAmount();
                
                //if (Convert.ToInt64(txtTotalAmount.TextSimple)!= Amount)
                //{
                //    PublicClass.ErrorMesseg(ResourceCode.T134);
                //    return true;

                //}

                if (txtDescription.Text=="")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T143);
                    txtDescription.Focus();
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

        private void cmbDetailedAccountsTo_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDetailedAccountsTo, dt_DetailedAccountsTo);
            }

        }

        private void btnCelerItems_Click(object sender, EventArgs e)
        {
            celerCashItems();
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
