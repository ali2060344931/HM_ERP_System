using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.Banck;
using HM_ERP_System.Entity.Accounts.SpecificAccount;
using HM_ERP_System.Entity.Provinces;
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

namespace HM_ERP_System.Forms.Accounts.ContraAccounts
{
    public partial class frmContraAccounts : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int LisId = 0;
        public int TypeAccounts_Id = 0;
        public int SpecificAccountCode = 0;
        public frmContraAccounts(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }
        int SpecificAccountId_ = 0;
        private void frmContraAccounts_Load(object sender, EventArgs e)
        {
            UpdateData();
            ShowList(TypeAccounts_Id);
            lblBanckName.ResetText();
            if (TypeAccounts_Id != 0)
            {
                panel1.Visible=true;
                using (var db = new DBcontextModel())
                {
                    SpecificAccountId_ = db.SpecificAccounts.Where(c => c.Cod==SpecificAccountCode).First().Id;
                    lblCodeAccount.Text=PublicClass.CeratDetailedAccountCode(SpecificAccountId_).ToString();
                }
                if (TypeAccounts_Id == 3)
                {
                    panel2.Visible=true;
                }
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

        public void ShowList(int Id)
        {
            if (Id>=3 && Id<=4)
            {
                cmbTypeAccounts.Value=Id;
            }
            //else 
            //{
            //    cmbTypeAccounts.Value=Id;
            //}

        }

        public void UpdateData()
        {
            CallUpdateTata();
        }

        private void CallUpdateTata()
        {
            FilldgvList();
            FillcmbTypeAccounts();
            FillcmbNatureAccounts();
            FillcmbBanck();
            FillcmbTypeAccount();

        }

        private void FillcmbTypeAccount()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.TypeAccounts.ToList();
                cmbType_Account.DataSource=q;
            }
        }

        DataTable dt_Banck;
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
                dt_Banck = new System.Data.DataTable();
                dt_Banck = PublicClass.AddEntityTableToDataTable(q.ToList());
            }
        }

        private void FillcmbTypeAccounts()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.TypeCustomers.Where(c => c.Id>=3).ToList();
                cmbTypeAccounts.DataSource=q;
            }
        }
        //bool isCondition1True = false;
        //bool isCondition2True = false;
        private void FilldgvList()
        {

            using (var db = new DBcontextModel())
            {
                var baseQuery = from cu in db.Customers

                                join tc in db.TypeCustomers
                                on cu.id_TypeCustomer equals tc.Id

                                join da in db.DetailedAccounts
                                on cu.Id equals da.CustomerId

                                join taN in db.TypeAccounts
                                on cu.TypeAccountId equals taN.Id into taNGroup
                                from tan_ in taNGroup.DefaultIfEmpty()

                                where cu.id_TypeCustomer == TypeAccounts_Id
                                select new
                                {
                                    cu.Id,
                                    cu.Name,
                                    TypeAccount = tc.Name,
                                    da.BankBrancheId,
                                    BankName = (string)null,
                                    cu.SeryalShaba,
                                    cu.AccountNumber,
                                    cu.DabitCardNumber,
                                    TypeAccountId0 = tan_!=null ? tan_.Id : 0,
                                };

                IQueryable<dynamic> finalQuery;

                if (TypeAccounts_Id == 3)
                {
                    finalQuery = from item in baseQuery

                                 join bb in db.BankBranches
                                 on item.BankBrancheId equals bb.Id into bankBranchGroup
                                 from bb_left in bankBranchGroup.DefaultIfEmpty()

                                 join ba in db.Bancks
                                 on bb_left.BanckId equals ba.Id

                                 join taN in db.TypeAccounts
                                 on item.TypeAccountId0 equals taN.Id into taNGroup
                                 from tan_ in taNGroup.DefaultIfEmpty()

                                 select new
                                 {
                                     item.Id,
                                     item.Name,
                                     item.TypeAccount,
                                     banckName = (item.BankBrancheId != null && item.BankBrancheId != 0 && ba != null)
                                                 ? ba.Name +" - "+bb_left.Name : "",
                                     item.SeryalShaba,
                                     item.AccountNumber,
                                     item.DabitCardNumber,
                                     TypeAccountNamu = tan_!=null ? tan_.Name : "",


                                 };
                }
                else
                {
                    finalQuery = from item in baseQuery
                                 select new
                                 {
                                     item.Id,
                                     item.Name,
                                     item.TypeAccount,
                                     banckName = ""
                                 };
                }
                dgvList.DataSource = finalQuery.ToList();
                PublicClass.SettingGridEX(dgvList);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbTypeAccounts, ResourceCode.T075, txtName, ResourceCode.T073))
                    return;


                if (TypeAccountsId_==3 && cmbBanck.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T152); return;
                }

                if (TypeAccountsId_==3)//در صورت ثبت بانک
                {
                    if (cmbType_Account.SelectedIndex==-1)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T057);
                        cmbType_Account.Focus();
                        return;
                    }
                    if (txtAccountNumber.Text=="")
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T156);
                        txtAccountNumber.Focus();
                        return;
                    }

                    if (txtDabitCardNumber.Text!="" && txtDabitCardNumber.Text.Length!=16)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T034);
                        return;
                    }

                    if (txtSeryalShaba.Text != "" && txtSeryalShaba.Text.Length != 24)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T035);
                        return;
                    }

                }


                using (var db = new DBcontextModel())
                {
                    if (LisId == 0)//ثبت
                    {
                        if (TypeAccounts_Id == 3)//بانک
                        {
                            int cont = db.Customers.Where(c => c.id_TypeCustomer==TypeAccountsId_).Count(c => c.Name == txtName.Text && c.AccountNumber==txtAccountNumber.Text);
                            if (cont > 0)
                            {
                                PublicClass.ErrorMesseg(ResourceCode.T074); return;
                            }
                        }
                        else

                        {
                            int cont = db.Customers.Where(c => c.id_TypeCustomer==TypeAccountsId_).Count(c => c.Name == txtName.Text);
                            if (cont > 0)
                            {
                                PublicClass.ErrorMesseg(ResourceCode.T074); return;
                            }
                        }
                    }
                    else//ویرایش
                    {
                        if (TypeAccounts_Id == 3)//بانک
                        {
                            int cont = db.Customers.Where(c => c.id_TypeCustomer==TypeAccountsId_).Count(c => c.Name == txtName.Text && c.AccountNumber==txtAccountNumber.Text && c.Id != LisId);
                            if (cont > 0)
                            {
                                PublicClass.ErrorMesseg(ResourceCode.T074); return;
                            }
                        }
                        else
                        {
                            int cont = db.Customers.Where(c => c.id_TypeCustomer==TypeAccountsId_).Count(c => c.Name == txtName.Text && c.Id != LisId);
                            if (cont > 0)
                            {
                                PublicClass.ErrorMesseg(ResourceCode.T074); return;
                            }
                        }
                    }
                    if (txtAccountNumber.Text=="")
                        txtAccountNumber.Text="0";
                    var userRepo = new Repository<Entity.Customer.Customer>(db);
                    int id = userRepo.SaveOrUpdateRefId(new Entity.Customer.Customer { Id = LisId, Name = txtName.Text, id_TypeCustomer=TypeAccountsId_, TypeAccountId=TypeAccountId, AccountNumber=txtAccountNumber.Text, DabitCardNumber=txtDabitCardNumber.Text, SeryalShaba=txtSeryalShaba.Text }, LisId);

                    if (TypeAccounts_Id!=0 && LisId==0)
                    {
                        var userRepo1 = new Repository<Entity.Accounts.DetailedAccount.DetailedAccount>(db);
                        userRepo1.SaveOrUpdate(new Entity.Accounts.DetailedAccount.DetailedAccount { Id = LisId, SpecificAccountId=SpecificAccountId_, CustomerId=id, CodeAccount=Convert.ToInt32(lblCodeAccount.Text), BankBrancheId=BanckId }, LisId);
                    }
                    {
                        PublicClass.WindowAlart("1");
                        if (_updatableForms!=null)
                            _updatableForms.UpdateData();
                        CelearItems();
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
            LisId = 0;
            txtName.ResetText();
            txtName.Focus();
            txtAccountNumber.ResetText();
            txtSeryalShaba.ResetText();
            txtDabitCardNumber.ResetText();
            cmbType_Account.SelectedIndex=-1;
            FilldgvList();
        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                LisId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Edit")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Customers.Where(c => c.Id == LisId).First();
                        var qb = db.DetailedAccounts.Where(c => c.SpecificAccountId==2 && c.CustomerId==LisId).First().BankBrancheId;

                        //var BankBranche = db.BankBranches.Where(c => c.Id==qb).First().Id;
                        cmbBanck.Value=qb;
                        txtName.Text = q.Name;
                        cmbTypeAccounts.Value=q.id_TypeCustomer;
                        cmbType_Account.Value=q.TypeAccountId;
                        txtAccountNumber.Text= q.AccountNumber;
                        txtSeryalShaba.Text= q.SeryalShaba;
                        txtDabitCardNumber.Text= q.DabitCardNumber;
                    }
                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        if (db.DetailedAccounts.Where(c => c.CustomerId == LisId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            var q = db.Customers.Where(c => c.Id == LisId).First();
                            db.Customers.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            FilldgvList();
                            CelearItems();
                        }
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        int TypeAccountsId_ = 0;
        private void cmbTypeAccounts_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                label7.Visible = false;
                TypeAccountsId_ = Convert.ToInt32(cmbTypeAccounts.Value);
                TypeAccounts_Id=TypeAccountsId_;
                if (TypeAccountsId_==3)//بانک ها
                {
                    label4.Visible=true;
                    cmbBanck.Visible=true;
                    btnAddBanck.Visible=true;
                    dgvList.RootTable.Columns["BanckName"].Visible=true;
                    label1.Text="نام(عنوان) حساب:";
                }
                else//صندوق ها
                {
                    label4.Visible=false;
                    cmbBanck.Visible=false;
                    btnAddBanck.Visible=false;
                    dgvList.RootTable.Columns["BanckName"].Visible=false;
                    label1.Text="نام(عنوان) صندوق:";

                }
                FilldgvList();
            }
            catch (Exception)
            {
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void frmContraAccounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) if (PublicClass.CloseForm()) this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void btnAddBanck_Click(object sender, EventArgs e)
        {
            Banck.frmBankBranch frmBankBranch = new Banck.frmBankBranch(this);
            frmBankBranch.ShowDialog();
            FillcmbBanck();
        }

        int BanckId = 0;
        private void cmbBanck_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBanck.SelectedIndex!=-1)
                {
                    BanckId = Convert.ToInt32(cmbBanck.Value);
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Bancks.Where(c => c.Id==db.BankBranches.Where(x => x.Id==BanckId).FirstOrDefault().Id).First().Name;

                        lblBanckName.Text="نام بانک: "+q;
                    }
                }
                else
                {
                    lblBanckName.ResetText();
                }

            }
            catch (Exception)
            {
            }

        }

        int TypeAccountId = 0;
        private void cmbTypeAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TypeAccountId = Convert.ToInt32(cmbType_Account.Value);
            }
            catch (Exception)
            {
            }

        }

        private void cmbBanck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbBanck, dt_Banck);
            }

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
