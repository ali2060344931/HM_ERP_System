using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.DetailedAccount;
using HM_ERP_System.Entity.Accounts.SpecificAccount;
using HM_ERP_System.Entity.Accounts.TransactionType;
using HM_ERP_System.Entity.FinancialYear;
using HM_ERP_System.Forms.Accounts.Cheque;
using HM_ERP_System.Forms.Accounts.DetailedAccount;
using HM_ERP_System.Forms.Accounts.SpecificAccount;
using HM_ERP_System.Forms.BillLadingRequest;
using HM_ERP_System.Forms.Main_Form;
using FontAwesome.Sharp;
using Janus.Windows.UI.Tab;
using Microsoft.Office.Interop.Excel;

using MyClass;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

using DataTable = System.Data.DataTable;

namespace HM_ERP_System.Forms.Accounts.RecevingPayment
{
    /// <summary>
    /// فرم دریافت و پرداخت
    /// </summary>
    public partial class frmRecevingPayment : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        int ListId_ = 0;
        public int ListIdM = 0;
        /// <summary>
        /// کدها: 1درآمد -2هزینه -3جابجایی -4دریافت -5پرداخت
        /// </summary>
        public int TransactionsCode;
        DataTable dt_MultipleAccount;
        public DataTable dt_Cheque;
        public frmRecevingPayment(/*IUpdatableForms updatableForms*/)
        {
            InitializeComponent();
            //_updatableForms=updatableForms;
        }

        private void frmRecevingPayment_Load(object sender, EventArgs e)
        {
            FontAwesome.Sharp.Icon icon;

            rdbIncomr.Checked=true;
            txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);

            txtTransactionDate.Value = DateTime.Now;
            txtTransactionCode.Text=PublicClass.CreatTransactionCode();
            rdbIncomr.Checked=true;
            rdbCash.Checked=true;

            AddColumnsToDataTable();




            PublicClass.SettingGridEX(dgvListMulti);
            PublicClass.SettingGridEX(dgvListCheque);
            CallUpdateTata();
        }

        void AddColumnsToDataTable()
        {
            dt_MultipleAccount=new DataTable();
            dt_MultipleAccount.Columns.Add("id", typeof(int));
            dt_MultipleAccount.Columns.Add("Code", typeof(string));
            dt_MultipleAccount.Columns.Add("Name", typeof(string));
            dt_MultipleAccount.Columns.Add("Amount1", typeof(double));
            dt_MultipleAccount.Columns.Add("Amount2", typeof(double));
            dt_MultipleAccount.Columns.Add("Des", typeof(string));

            dt_Cheque=new DataTable();
            dt_Cheque.Columns.Add("Cheaueid", typeof(int));
            dt_Cheque.Columns.Add("ChequeNumber", typeof(string));
            dt_Cheque.Columns.Add("DueDate", typeof(string));
            dt_Cheque.Columns.Add("Amount", typeof(double));
            dt_Cheque.Columns.Add("Description", typeof(string));

        }

        public void UpdateData()
        {
            FilldgvList();
        }
        private void CallUpdateTata()
        {
            //panelAccountBalance.Visible=Properties.Settings.Default.StatusShowAccountBalance;
            dgvList.SaveSettings=true;
            dgvList.SettingsKey=this.Name;
            FilldgvList();

        }

        DataTable dt_ContraAccountTo;
        private void FillcmbContraAccountTo(int SpecificAccountId_)
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
                        };
                cmbDetailedAccountsTo.DataSource= q.ToList();

                dt_ContraAccountTo = new DataTable();
                dt_ContraAccountTo = PublicClass.AddEntityTableToDataTable(q.ToList());

            }

        }
        
        
        DataTable dt_ContraAccountFrom;
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
                        };
                cmbDetailedAccountsFrom.DataSource= q.ToList();

                dt_ContraAccountFrom = new DataTable();
                dt_ContraAccountFrom = PublicClass.AddEntityTableToDataTable(q.ToList());
            }

        }
        
        DataTable dt_SpecificAccountF;
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

                dt_SpecificAccountF = new DataTable();
                dt_SpecificAccountF = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }

        DataTable dt_SpecificAccountT;

        /// <summary>
        /// دریافت از
        /// </summary>
        private void FillcmbSpecificAccountT(int Code)
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

                cmbSpecificAccountTo.DataSource = q.ToList();

                dt_SpecificAccountT = new DataTable();
                dt_SpecificAccountT = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }

        //ToDo باشد جهت نمایش در دیتاگرید Null یک جدول صفر0 یا  Id وقتی مقدار
        private void FilldgvList()
        {
            PublicClass.FilldgvListTransaction(dgvList, txtDateStart.Text, txtDateEnd.Text);
        }

        private void rdbIncomr_CheckedChanged(object sender, EventArgs e)
        {
            cmbTypeDocument.ResetText();
            if (rdbIncomr.Checked)
            {
                TransactionsCode=4;
                lblFrom.Text="دریافت از";
                lblTo.Text="واریز به";
                FillcmbSpecificAccountF(80);
                FillcmbSpecificAccountT(60);
                lblInOut.Symbol="";
                lblInOut.SymbolColor=System.Drawing.Color.Green;
                lblFrom.ForeColor= System.Drawing.Color.Green;
                lblTo.ForeColor= System.Drawing.Color.Green;
                lblTotalAmount2.Visible=false;
                txtTotalAmount2.Visible=false;
                FillcmbTypeDocument(4);
            }
            else
            {
                TransactionsCode=5;
                lblFrom.Text="پرداخت به";
                lblTo.Text="واریــز(برداشت)از";
                FillcmbSpecificAccountF(60);
                FillcmbSpecificAccountT(80);
                lblInOut.Symbol="";
                lblInOut.SymbolColor=System.Drawing.Color.Red;
                lblInOut.SymbolColor=System.Drawing.Color.Red;
                lblFrom.ForeColor= System.Drawing.Color.Red;
                lblInOut.SymbolColor=System.Drawing.Color.Red;
                lblTo.ForeColor= System.Drawing.Color.Red;
                lblTotalAmount2.Visible=true;
                txtTotalAmount2.Visible=true;
                FillcmbTypeDocument(5);
            }

            CelearItems();
        }

        private void FillcmbTypeDocument(int Id)
        {
            using (var db = new DBcontextModel())
            {
                var q = from spag in db.SpecificAccountsGroups
                        join spf in db.SpecificAccounts
                        on spag.SpecificAccountIdF equals spf.Id
                        join spt in db.SpecificAccounts
                        on spag.SpecificAccountIdT equals spt.Id
                        where spag.TransactionTypeId==Id
                        orderby spag.Name
                        select new
                        {
                            spag.Id,
                            spag.Name,
                            SpecificAccountF = spf.Name,
                            SpecificAccountT = spt.Name,

                        };
                cmbTypeDocument.DataSource=q.ToList();
                dt_TypeDocument = new DataTable();
                dt_TypeDocument = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }
        
        
        DataTable dt_TypeDocument;
        private void frmRecevingPayment_Activated(object sender, EventArgs e)
        {
            CallUpdateTata();
        }

        /// <summary>
        /// حساب معین
        /// </summary>
        int SpecificAccountIdF = 0;
        private void cmbSpecificAccountFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSpecificAccountFrom.SelectedIndex==-1)
                {
                    cmbDetailedAccountsFrom.ResetText();
                    lblSpecificAccountsBalanceF.ResetText();
                    lblAccountBalancF.ResetText();
                    return;
                }

                SpecificAccountIdF = Convert.ToInt32(cmbSpecificAccountFrom.Value);
                FillcmbContraAccountF(SpecificAccountIdF);

                lblSpecificAccountsBalanceF.Text=PublicClass.SpecificAccountsBalance(SpecificAccountIdF).ToString("#,##0;(#,##0)");

                cmbDetailedAccountsFrom.ResetText();
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// حساب معین
        /// </summary>
        int SpecificAccountIdT = 0;

        private void cmbSpecificAccountTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSpecificAccountTo.SelectedIndex==-1)
                {
                    cmbDetailedAccountsTo.ResetText();
                    lblSpecificAccountsBalanceT.ResetText();
                    lblAccountBalancT.ResetText();
                    return;
                }
                SpecificAccountIdT = Convert.ToInt32(cmbSpecificAccountTo.Value);

                FillcmbContraAccountTo(SpecificAccountIdT);

                lblSpecificAccountsBalanceT.Text=PublicClass.SpecificAccountsBalance(SpecificAccountIdT).ToString("#,##0;(#,##0)");

                cmbDetailedAccountsTo.ResetText();
            }
            catch (Exception)
            {
            }
        }

        int DetailedAccountsFrom_ = 0;
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
                DetailedAccountsFrom_ = Convert.ToInt32(cmbDetailedAccountsFrom.Value);


                AccountBalancF=PublicClass.DetailedAccountsBalance(SpecificAccountIdF, DetailedAccountsFrom_);

                lblAccountBalancF.Text=AccountBalancF.ToString("#,##0;(#,##0)");
            }
            catch (Exception)
            {
            }
        }

        int DetailedAccountsTo_ = 0;
        private void cmbDetailedAccountsTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDetailedAccountsTo.SelectedIndex==-1)
                {
                    lblAccountBalancT.ResetText();
                    return;
                }
                DetailedAccountsTo_ = Convert.ToInt32(cmbDetailedAccountsTo.Value);

                AccountBalancT=PublicClass.DetailedAccountsBalance(SpecificAccountIdT, DetailedAccountsTo_);
                lblAccountBalancT.Text=AccountBalancT.ToString("#,##0;(#,##0)");
            }
            catch (Exception)
            {
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

        private void cmbSpecificAccountTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbSpecificAccountTo, dt_SpecificAccountT);
            }

        }

        private void cmbDetailedAccountsFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbTypeDocument.SelectedIndex == -1)
                    SendKeys.Send("{TAB}");
                else
                    cmbDetailedAccountsTo.Focus();
            }


            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDetailedAccountsFrom, dt_ContraAccountFrom);
            }

        }

        private void cmbDetailedAccountsTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbDetailedAccountsTo, dt_ContraAccountTo);

            }

        }

        double TotalAmountCash = 0;
        double TotalAmountCheque = 0;
        int TotalAmountCashC = 0;
        int TotalAmountChequeC = 0;



        (double, int) CalcTotalAmount()
        {
            //ToDo Janus محاسبه مجموع مقادیر در ستون دیتاگریدویو
            TotalAmountCash = dgvListMulti.GetRows().Select(row => Convert.ToDouble(row.Cells["Amount1"].Value)).Sum();
            TotalAmountCheque = dgvListCheque.GetRows().Select(row => Convert.ToDouble(row.Cells["Amount"].Value)).Sum();
            TotalAmountCashC = dgvListMulti.GetRows().Select(row => Convert.ToInt32(row.Cells["Amount1"].Value)).Count();
            TotalAmountChequeC = dgvListCheque.GetRows().Select(row => Convert.ToInt32(row.Cells["Amount"].Value)).Count();
            return (TotalAmountCash+TotalAmountCheque, TotalAmountCashC+TotalAmountChequeC);
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
            lblTotalCash.Text=TotalAmountCash.ToString("#,##0");
            lblTotlCheuqe.Text=TotalAmountCheque.ToString("#,##0");
            lblTotalCashC.Text=TotalAmountCashC.ToString();
            lblTotlCheuqeC.Text=TotalAmountChequeC.ToString();
            lblTotlSum.Text=S.ToString("#,##0");
            lblTotlSumC.Text=C.ToString();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ControlFildes()) return;

            int Series = 0;
            if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            //if (chkMultipleAccounts.Checked)
            //{
            //    CalcTotalAmount();
            //}
            //else
            //{
            //    TotalAmount=txtTotalAmount1.Value;
            //}

            using (var db = new DBcontextModel())
            {
                string TransactionCode = txtTransactionCode.Text;
                string TransactionDate = txtTransactionDate.Text;
                double Amount = 0;
                int count = 0;
                using (var transaction = db.Database.BeginTransaction())
                    try
                    {
                        {
                            (Amount, count)= CalcTotalAmount();
                            Series++;
                            PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountIdF, DetailedAccountsFrom_, Amount, TransactionsCode==4 ? 0 : Amount, TransactionsCode==4 ? Amount : 0, 0, txtDescription.Text, "", Series, false);

                            //ثبت مبالغ نقدی
                            if (dt_MultipleAccount!=null)
                            {
                                foreach (DataRow r in dt_MultipleAccount.Rows)
                                {
                                    Series++;
                                    int DetailedAccountId_ = Convert.ToInt32(r["Id"]);

                                    var q = db.DetailedAccounts.Where(c => c.Id==DetailedAccountId_).First();

                                    Amount = Convert.ToDouble(r["Amount1"]);

                                    PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, q.SpecificAccountId, DetailedAccountId_, Amount, TransactionsCode==4 ? Amount : 0, TransactionsCode==4 ? 0 : Amount, 0, r["Des"].ToString(), "", Series, false);

                                    //ثبت کارمزد
                                    double Amount2 = Convert.ToDouble(r["Amount2"]);
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

                                        PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount2, TransactionsCode == 4 ? 0 : Amount2, TransactionsCode == 4 ? Amount2 : 0, 0, txtDescription.Text, "", Series, false);


                                        Series++;
                                        PublicClass.AccountingDocumentRegistration(db, ListId, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, q.SpecificAccountId, DetailedAccountId_, Amount2, TransactionsCode==4 ? Amount2 : 0, TransactionsCode==4 ? 0 : Amount2, 0, txtDescription.Text, "", Series, false);
                                    }
                                }
                            }


                            //برای ثبت چک
                            if (rdbIncomr.Checked)
                            {//چک های دریافتنی
                                if (dt_Cheque!=null)
                                {
                                    foreach (DataRow r in dt_Cheque.Rows)
                                    {
                                        Series++;
                                        //اسناد دریافتنی در جریان وصول
                                        int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==10302).First().Id;

                                        int DetailedAccountId = 0;
                                        int ChequeId = Convert.ToInt32(r["Cheaueid"]);
                                        int Payer_Payee_AccId = db.Cheques.Where(c => c.Id==ChequeId).First().Payer_Payee_AccId;

                                        var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==Payer_Payee_AccId);

                                        if (serch1.Count()==0)
                                            DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, Payer_Payee_AccId);
                                        else
                                            DetailedAccountId=serch1.First().Id;






                                        Amount = Convert.ToDouble(r["Amount"]);
                                        int TransactionId = PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount, TransactionsCode==4 ? Amount : 0, TransactionsCode==4 ? 0 : Amount, 0, r["Description"].ToString(), Series, false);

                                        //int Cheaueid = Convert.ToInt32(r["Cheaueid"]);

                                        var ADR = new Repository<Entity.Accounts.Cheque.ChequeStatus>(db);
                                        int CurrentStatusID = ADR.SaveOrUpdateRefIdByCommit(new Entity.Accounts.Cheque.ChequeStatus { Id = 0, ChequeId=ChequeId, StatusDate=TransactionDate, StatusCodeId=2, TransactionId=TransactionId }, 0);

                                        var ch = db.Cheques.Where(c => c.Id==ChequeId).First();
                                        ch.CurrentStatusID=CurrentStatusID;

                                    }
                                }
                            }
                            else
                            {//چک های پرداختنی
                                if (dt_Cheque!=null)
                                {
                                    foreach (DataRow r in dt_Cheque.Rows)
                                    {
                                        Series++;
                                        //حساب ها و اسناد پرداختنی بلند مدت
                                        int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==40101).First().Id;

                                        int DetailedAccountId = 0;
                                        int ChequeId = Convert.ToInt32(r["Cheaueid"]);
                                        int Payer_Payee_AccId = db.Cheques.Where(c => c.Id==ChequeId).First().Payer_Payee_AccId;

                                        var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==Payer_Payee_AccId);

                                        if (serch1.Count()==0)
                                            DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, Payer_Payee_AccId);
                                        else
                                            DetailedAccountId=serch1.First().Id;

                                        Amount = Convert.ToDouble(r["Amount"]);
                                        int TransactionId = PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, TransactionsCode, SpecificAccountId, DetailedAccountId, Amount, TransactionsCode==4 ? Amount : 0, TransactionsCode==4 ? 0 : Amount, 0, r["Description"].ToString(), Series, false);

                                        //int Cheaueid = Convert.ToInt32(r["Cheaueid"]);

                                        var ADR = new Repository<Entity.Accounts.Cheque.ChequeStatus>(db);
                                        int CurrentStatusID = ADR.SaveOrUpdateRefIdByCommit(new Entity.Accounts.Cheque.ChequeStatus { Id = 0, ChequeId=ChequeId, StatusDate=TransactionDate, StatusCodeId=1, TransactionId=TransactionId }, 0);

                                        var ch = db.Cheques.Where(c => c.Id==ChequeId).First();
                                        ch.CurrentStatusID=CurrentStatusID;

                                    }
                                }
                            }

                            db.SaveChanges();
                            transaction.Commit();

                            PublicClass.WindowAlart("1");
                            FilldgvList();
                            if (_updatableForms!=null)
                                _updatableForms.UpdateData();
                            CelearItems();

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
                    return true;
                }
                //if (!chkMultipleAccounts.Checked && cmbDetailedAccountsTo.SelectedIndex==-1)
                //{
                //    PublicClass.ErrorMesseg(ResourceCode.T078);
                //    return true;
                //}

                if (cmbSpecificAccountFrom.Value==cmbSpecificAccountTo.Value && cmbDetailedAccountsFrom.Value==cmbDetailedAccountsTo.Value)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T080);
                    return true;
                }

                if (dgvListMulti.RowCount==0 && dgvListCheque.RowCount==0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T121);
                    return true;
                }
                //if (!chkMultipleAccounts.Checked && txtTotalAmount1.Text=="")
                //{
                //PublicClass.ErrorMesseg(ResourceCode.T081);
                //    return true;
                //}

                //if (chkMultipleAccounts.Checked && dgvListMulti.RowCount==0)
                //{
                //    PublicClass.ErrorMesseg(ResourceCode.T082);
                //    return true;

                //}

                if (rdbIncomr.Checked)
                {
                    if (AccountBalancF<txtTotalAmount1.Value)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T116);
                        return true;
                    }
                }

                if (rdbExpense.Checked)
                {
                    if (AccountBalancT<txtTotalAmount1.Value)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T116);
                        return true;
                    }
                }

                if (txtDescription.Text=="")
                {
                    btnCreatDescription_Click(null, null);
                }

                return false;

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er); return false;

            }

        }

        private void CelearItems()
        {
            try
            {
                txtTransactionCode.Text=PublicClass.CreatTransactionCode();
                cmbSpecificAccountFrom.ResetText();
                cmbSpecificAccountTo.ResetText();
                cmbDetailedAccountsFrom.ResetText();
                cmbDetailedAccountsTo.ResetText();
                txtTotalAmount1.ResetText();
                txtDescription.ResetText();
                lblAccountBalancF.ResetText();
                lblAccountBalancT.ResetText();
                lblSpecificAccountsBalanceF.ResetText();
                lblSpecificAccountsBalanceT.ResetText();
                txtAccountDF.ResetText();
                txtAccountDT.ResetText();
                dt_MultipleAccount=null;
                dgvListMulti.DataSource=dt_MultipleAccount;

                ListId=0;
                AccountBalancF=0;
                AccountBalancT=0;
                txtTotalAmount2.Value= 0;
                cmbTypeDocument.ResetText();
                cmbTypeDocument.Focus();

                //if (dt_Cheque!=null)
                //    dt_Cheque.Clear();
                //if (dt_MultipleAccount!=null)
                //    dt_MultipleAccount.Clear();
                AddColumnsToDataTable();

                CelearItemslblAmounts();

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

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmSpecificAccount f = new frmSpecificAccount(this);
            f.ShowDialog();
            FillcmbSpecificAccountF(TransactionsCode==3 ? 80 : 60);//جابجایی
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frmSpecificAccount f = new frmSpecificAccount(this);
            f.ShowDialog();
            FillcmbSpecificAccountT(TransactionsCode==3 ? 60 : 80);//جابجایی
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (cmbSpecificAccountTo.SelectedIndex!=-1)
            {
                frmDetailedAccount f = new frmDetailedAccount(this);
                f.cmbSpecificAccountValue=SpecificAccountIdT;
                f.ShowDialog();
                FillcmbContraAccountTo(SpecificAccountIdT);
            }
            else
            {
                PublicClass.ErrorMesseg(ResourceCode.T071);
                cmbSpecificAccountTo.Focus();
            }

        }

        private void btnCreatDescription_Click(object sender, EventArgs e)
        {
            string txtF = "";
            string txtT = "";

            if (rdbIncomr.Checked)
            {
                txtF = "دریافت به مبلغ: ";
                //txtT = " و واریز به حساب: ";
            }
            else
            {
                txtF = "پرداخت به مبلغ: ";
                //txtT = " و واریز از حساب: ";
            }
            txtDescription.Text= txtF+ txtTotalAmount1.Value.ToString("#,##")+" ریال در تاریخ: "+txtTransactionDate.Text+" به شماره سند: "+txtTransactionCode.Text + " بابت: ";



            //if (!chkMultipleAccounts.Checked)
            //{
            //    //txtDescription.Text= txtF+ cmbSpecificAccountFrom.Text+"، "+cmbDetailedAccountsFrom.Text +txtT+cmbSpecificAccountTo.Text+"، "+cmbDetailedAccountsTo.Text+" به مبلغ: "+txtTotalAmount1.Value.ToString("#,##")+" ریال در تاریخ: "+txtTransactionDate.Text+" به شماره سند: "+txtTransactionCode.Text;


            //    txtDescription.Text= txtF+ txtTotalAmount1.Value.ToString("#,##")+" ریال در تاریخ: "+txtTransactionDate.Text+" به شماره سند: "+txtTransactionCode.Text + " بابت: ";
            //}
            //else
            //{
            //    CalcTotalAmount();
            //    //txtDescription.Text= txtF+ cmbSpecificAccountFrom.Text+"، "+cmbDetailedAccountsFrom.Text +" به مبلغ: "+TotalAmount.ToString("#,##")+" ریال در تاریخ: "+txtTransactionDate.Text+" به شماره سند: "+txtTransactionCode.Text;

            //    txtDescription.Text= txtF+ TotalAmount.ToString("#,##")+" ریال در تاریخ: "+txtTransactionDate.Text+" به شماره سند: "+txtTransactionCode.Text + " بابت: ";
            //}

            txtDescription.Focus();
        }

        private void txtAccountSF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtAccountDF_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DBcontextModel())
            {
                if (txtAccountDF.Text.Length==9)
                {
                    int AccountId = Convert.ToInt32(txtAccountDF.Text);
                    var q = db.DetailedAccounts.Where(c => c.CodeAccount==AccountId);
                    if (q.Count()!=0)
                    {
                        cmbSpecificAccountFrom.Value=q.First().SpecificAccountId;
                        cmbDetailedAccountsFrom.Value=q.First().Id;
                        txtAccountDT.Focus();
                    }
                }
                else
                {
                    cmbSpecificAccountTo.ResetText();
                    cmbDetailedAccountsFrom.ResetText();
                }


            }
        }

        private void txtAccountDT_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DBcontextModel())
            {
                if (txtAccountDT.Text.Length==9)
                {
                    int AccountId = Convert.ToInt32(txtAccountDT.Text);
                    var q = db.DetailedAccounts.Where(c => c.CodeAccount==AccountId);
                    if (q.Count()!=0)
                    {
                        cmbSpecificAccountTo.Value=q.First().SpecificAccountId;
                        cmbDetailedAccountsTo.Value=q.First().Id;
                        txtTotalAmount1.Focus();
                    }
                }
                else
                {
                    cmbSpecificAccountTo.ResetText();
                    cmbDetailedAccountsTo.ResetText();

                }
            }


        }

        private void txtAccountSF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void pnlAddItemBodi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkMultipleAccounts_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkMultipleAccounts.Checked)
            //{
            //    dgvListMulti.Visible=true;
            //    btnAddToList.Visible=true;
            //    dgvListMulti.DataSource=dt_MultipleAccount;
            //}
            //else
            //{
            //    dgvListMulti.Visible=false;
            //    btnAddToList.Visible=false;
            //}
            //txtAccountDT.Focus();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {

            if (cmbDetailedAccountsTo.SelectedIndex==-1)
            {
                PublicClass.ErrorMesseg(ResourceCode.T075); return;
            }

            if (rdbCash.Checked)
            {

                if (txtTotalAmount1.Text=="")
                {
                    PublicClass.ErrorMesseg(ResourceCode.T081); return;
                }

                //bool exist = dt_MultipleAccount.AsEnumerable().Any(r => r.Field<int>("Id")==DetailedAccountsTo_);

                //if (exist)
                //{
                //    PublicClass.ErrorMesseg(ResourceCode.T079); return;
                //}


                if (txtDescription.Text=="")
                {
                    btnCreatDescription_Click(null, null);
                }
               
                if (MessageBox.Show(ResourceCode.T122, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                DataRow newrow = dt_MultipleAccount.NewRow();
                using (var db = new DBcontextModel())
                {
                    var q = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsTo_).First();
                    newrow["Id"]=DetailedAccountsTo_;
                    newrow["Code"]=q.CodeAccount;
                    newrow["Name"]=cmbDetailedAccountsTo.Text;
                    newrow["Amount1"]=txtTotalAmount1.Value;
                    newrow["Amount2"]=txtTotalAmount2.Value;
                    newrow["Des"]=txtDescription.Text;
                    dt_MultipleAccount.Rows.Add(newrow);
                    dgvListMulti.DataSource=dt_MultipleAccount;
                    dgvListMulti.AutoSizeColumns();

                }
                CalcTotalAmountAddToItems();
                txtTotalAmount1.ResetText();
                txtTotalAmount2.ResetText();
                txtAccountDT.ResetText();
                txtAccountDT.Focus();
                txtDescription.ResetText();

            }
            else
            {

            }
        }

        private void dgvListMulti_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            ListIdM = Convert.ToInt32(dgvListMulti.CurrentRow.Cells["Id"].Value);
            if (e.Column.Key == "Delete")
            {
                //using (var db = new DBcontextModel())
                {
                    //if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        List<DataRow> ldr = dt_MultipleAccount.AsEnumerable().ToList();
                        ldr.RemoveAll(r => r["id"]!= DBNull.Value && Convert.ToInt32(r["id"])==ListIdM);

                        dgvListMulti.DataSource=dt_MultipleAccount;
                    }
                }
            }
        }

        private void dgvListMulti_DeletingRecord(object sender, Janus.Windows.GridEX.RowActionCancelEventArgs e)
        {
            if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                e.Cancel=true;


        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvList();
        }

        private void frmRecevingPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();

            }
                        if (e.Control && e.KeyCode == Keys.F12) { UpdateData();PublicClass.WindowAlart("1", ResourceCode.T161); }
        }

        private void rdbExpense_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {

        }
        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            ListId_ = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);

            if (e.Column.Key == "Details")
            {
                ribbonContextMenu1.Show(Cursor.Position);
            }

        }

        private void ribbonContextMenu1_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
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
                    //if (!PublicClass.SetPeremission("d1", 1)) return;

                    using (var db = new DBcontextModel())
                    {
                        //if (db.ComersHs.Where(c => c.CarId == ListId).Count() != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        var q = db.Transactions.Where(c => c.Id==ListId).First().TransactionCode;

                        var list = db.Transactions.Where(c => c.TransactionCode==q).ToList();
                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //var q = db.Cars.Where(c => c.Id == ListId).First();
                            db.Transactions.RemoveRange(list);
                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            FilldgvList();
                            CelearItems();
                        }

                    }


                    break;
                case "AddDocumentToBanck"://ثبت مدارک


                    break;
                case "CeatComerB"://ثبت بارنامه
                    using (var db = new DBcontextModel())
                    {

                    }
                    break;
            }

        }

        private void rdbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCash.Checked)
            {
                panelCash.Enabled = true;
                txtTotalAmount1.Enabled=true;
                txtTotalAmount2.Enabled=true;
                btnAddToList.Enabled=true;
                //txtDescription.Enabled=true;
                btnSelectCheque.Enabled=false;
                labelX3.Symbol="";

            }
            else
            {
                panelCash.Enabled = false;
                txtTotalAmount1.Enabled=false;
                txtTotalAmount2.Enabled=false;
                btnAddToList.Enabled=false;
                //txtDescription.Enabled=false;
                btnSelectCheque.Enabled=true;
                txtTotalAmount1.ResetText();
                txtTotalAmount2.ResetText();
                txtAccountDT.ResetText();
                cmbSpecificAccountTo.ResetText();
                cmbDetailedAccountsTo.ResetText();
                labelX3.Symbol="";


                //txtDescription.ResetText();
            }
        }

        private void btnSelectCheque_Click(object sender, EventArgs e)
        {
            //if (cmbDetailedAccountsTo.SelectedIndex==-1)
            //{
            //    PublicClass.ErrorMesseg(ResourceCode.T075);
            //    cmbDetailedAccountsTo.Focus();
            //    return;
            //}

            frmCheque f = new frmCheque(this);
            //var q = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsTo_).First();
            //newrow["Id"]=DetailedAccountsTo_;
            //newrow["Code"]=q.CodeAccount;
            //newrow["Name"]=cmbDetailedAccountsTo.Text;
            using (var db = new DBcontextModel())
            {
                //var q = db.DetailedAccounts.Where(c => c.Id==DetailedAccountsTo_).First();
                f.IsReqoestExitForm=this.Name;
                //f.AccountId=DetailedAccountsTo_;
                //f.AccountCode=q.CodeAccount;
                //f.AccountName=cmbDetailedAccountsTo.Text;
                if (rdbIncomr.Checked)
                {
                    f.cmbChequeType.Value=1;
                }
                else
                {
                    f.cmbChequeType.Value=2;
                }
                f.ShowDialog();
                dgvListCheque.DataSource=dt_Cheque;
            }
            CalcTotalAmountAddToItems();
        }

        private void txtDescription_ButtonClick(object sender, EventArgs e)
        {
            txtDescription.ResetText();
        }

        private void dgvListCheque_DeletingRecords(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                e.Cancel=true;
        }

        private void dgvListMulti_RecordsDeleted(object sender, EventArgs e)
        {
            CalcTotalAmountAddToItems();
        }

        private void dgvListCheque_RecordsDeleted(object sender, EventArgs e)
        {
            CalcTotalAmountAddToItems();
        }

        private void txtTransactionDate_Click(object sender, EventArgs e)
        {

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

        private void cmbTypeDocument_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var db = new DBcontextModel())
            //    {
            //        var q = db.SpecificAccountsGroups.Where(c => c.Id==TypeDocumentId).First();
            //        cmbSpecificAccountFrom.Value=q.SpecificAccountIdF;
            //        cmbSpecificAccountTo.Value=q.SpecificAccountIdT;
            //    }

            //}
            //catch (Exception er)
            //{
            //    PublicClass.ShowErrorMessage(this.Name, er.Message);
            //}
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
                        cmbSpecificAccountTo.Value=q.SpecificAccountIdT;
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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmSpecificAccountsGroup f = new frmSpecificAccountsGroup(this);

            f.ShowDialog();
            rdbIncomr_CheckedChanged(null, null);
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}
