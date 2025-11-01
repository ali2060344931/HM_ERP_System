using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.TransactionType;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Accounts.ContraAccounts;
using HM_ERP_System.Forms.Accounts.SpecificAccount;
using HM_ERP_System.Forms.Customer;
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
using System.Xml.Linq;

//using static Google.Protobuf.Collections.MapField<TKey, TValue>;

namespace HM_ERP_System.Forms.Accounts.Transaction
{
    public partial class frmTransaction : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int LisId = 0;
        public int TransactionsCode;
        public frmTransaction(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);

            txtTransactionDate.Value = DateTime.Now;
            txtTransactionCode.Text=PublicClass.CreatTransactionCode();
            rdbIncomr.Checked=true;
            UpdateData();
        }
        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {
            dgvList.SaveSettings=true;
            dgvList.SettingsKey=this.Name;
            FilldgvList();
            FillcmbContraAccountFrom();
            FillcmbContraAccountTo();


        }

        DataTable dt_ContraAccountTo;

        private void FillcmbContraAccountTo()
        {
            using (var db = new DBcontextModel())
            {
                var q = from cu in db.Customers

                        join tc in db.TypeCustomers
                        on cu.id_TypeCustomer equals tc.Id

                        where cu.id_TypeCustomer>=3
                        select new
                        {
                            cu.Id,
                            cu.Name,
                            TypeAccount = tc.Name,
                        };

                cmbContraAccountTo.DataSource= q.ToList();

                dt_ContraAccountTo = new DataTable();
                dt_ContraAccountTo = PublicClass.AddEntityTableToDataTable(q.ToList());

            }

        }
        DataTable dt_ContraAccountFrom;
        private void FillcmbContraAccountFrom()
        {
            using (var db = new DBcontextModel())
            {
                var q = from cu in db.Customers

                        join tc in db.TypeCustomers
                        on cu.id_TypeCustomer equals tc.Id

                        where cu.id_TypeCustomer<=2
                        select new
                        {
                            cu.Id,
                            Name = cu.Family+" "+cu.Name,
                            cu.CodMeli,
                            cu.Tel,
                            CustomerType = tc.Name,
                        };
                cmbContraAccountFrom.DataSource= q.ToList();

                dt_ContraAccountFrom = new DataTable();
                dt_ContraAccountFrom = PublicClass.AddEntityTableToDataTable(q.ToList());

            }

        }
        DataTable dt_SpecificAccount;
        /// <summary>
        /// معین های درآم   و هزینه
        /// </summary>
        private void FillcmbSpecificAccount(int Code)
        {
            using (var db = new DBcontextModel())
            {
                var q = from sp in db.SpecificAccounts

                        join ta in db.TotalAccounts
                        on sp.Id_TotalAccount equals ta.Id
                        where (int)sp.Cod/1000==Code && sp.Status
                        select new
                        {
                            sp.Id,
                            sp.Name,
                            Code = sp.Cod,
                            TotalAccountName = ta.Name,
                        };

                cmbSpecificAccount.DataSource = q.ToList();

                dt_SpecificAccount = new DataTable();
                dt_SpecificAccount = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }

        //ToDo باشد جهت نمایش در دیتاگرید Null یک جدول صفر0 یا  Id وقتی مقدار
        private void FilldgvList()
        {
            List<int> requiredIds = new List<int> { 1, 2 };

            PublicClass.FilldgvListTransaction(dgvList, txtDateStart.Text, txtDateEnd.Text, requiredIds);
        }

        private void rdbIncomr_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIncomr.Checked)
            {
                TransactionsCode=1;
                lblSpecificAccount.Text="درآمد بابت:";
                lblContraAccountFrom.Text="دریافت از:";
                lblContraAccountTo.Text="واریز به:";
                lblTotalAmount.Text="مبلغ درآمـــــد:";
                lblIEAmount.Text="پیش دریافت:";
                FillcmbSpecificAccount(60);
                cmbSpecificAccount.ResetText();
                lblInOut.Symbol="";
                lblInOut.SymbolColor=Color.Green;
            }
            else
            {
                TransactionsCode=2;
                lblSpecificAccount.Text="هزینه بابت:";
                lblContraAccountFrom.Text="پرداخت به:";
                lblContraAccountTo.Text="واریــز از:";
                lblTotalAmount.Text="مبلغ هــــــزینه:";
                lblIEAmount.Text="پیش پرداخت:";
                FillcmbSpecificAccount(80);
                cmbSpecificAccount.ResetText();
                lblInOut.Symbol="";
                lblInOut.SymbolColor=Color.Red;

            }

        }

        private void txtTotalAmount_ValueChanged(object sender, EventArgs e)
        {
            txtIEAmount.Value=txtTotalAmount.Value;
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

        private void cmbContraAccountFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbContraAccountFrom, dt_ContraAccountFrom);
            }

        }

        private void cmbContraAccountTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbContraAccountTo, dt_ContraAccountTo);
            }
        }

        private void txtIEAmount_Enter(object sender, EventArgs e)
        {
            txtIEAmount.Value=txtTotalAmount.Value;
        }

        int SpecificAccountId = 0;
        private void cmbSpecificAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SpecificAccountId = Convert.ToInt32(cmbSpecificAccount.Value);
            }
            catch (Exception)
            {
            }

        }
        int ContraAccountFromId = 0;
        private void cmbContraAccountFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ContraAccountFromId = Convert.ToInt32(cmbContraAccountFrom.Value);
            }
            catch (Exception)
            {
            }
        }

        int ContraAccountToId = 0;
        private void cmbContraAccountTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ContraAccountToId = Convert.ToInt32(cmbContraAccountTo.Value);
            }
            catch (Exception)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (PublicClass.FindEmptyControls(cmbProvinces, ResourceCode.
                //                T002, txtName, ResourceCode.
                //                T005))
                //    return;

                PublicClass.Transaction(TransactionCode: Convert.ToInt32(txtTransactionCode.Text), TransactionDate: txtTransactionDate.Text, TransactionTypeId: TransactionsCode, SpecificAccountId, ContraAccountFromId, ContraAccountToId, TotlAmount: txtTotalAmount.Value, txtIEAmount.Value, TaxAmount: txtTaxAmount.Value, ComerBId: 0, Description: txtDescription.Text);
                FilldgvList();
                if (_updatableForms!=null)
                    _updatableForms.UpdateData();
                CelearItems();
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void CelearItems()
        {
            txtTransactionCode.Text=PublicClass.CreatTransactionCode();
            cmbSpecificAccount.ResetText();
            cmbContraAccountFrom.ResetText();
            cmbContraAccountTo.ResetText();
            txtTaxAmount.ResetText();
            txtTotalAmount.ResetText();
            txtIEAmount.ResetText();
            cmbSpecificAccount.Focus();
        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvList();
        }

        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTax.Checked)
            {
                txtTaxAmount.Enabled= true;
            }
            else
            { txtTaxAmount.Enabled= false; }
        }

        private void txtTransactionCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void rdbExpense_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
            FilldgvList();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmSpecificAccount f = new frmSpecificAccount(this);
            f.ShowDialog();
            FillcmbSpecificAccount(TransactionsCode);
        }
        //private IUpdatableForms _updatableForms;

        private void btnAddNewCity1_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer(this);
            f.ShowDialog();
            FillcmbContraAccountFrom();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmContraAccounts f = new frmContraAccounts(this);
            f.ShowDialog();
            FillcmbContraAccountTo();
        }

        private void frmTransaction_Activated(object sender, EventArgs e)
        {
            CallUpdateTata();
        }

        private void frmTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();

            }
        }
    }
}
