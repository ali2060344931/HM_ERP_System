using HM_ERP_System.Class_General;
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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Accounts.TotalAccount
{
    public partial class frmTotalAccount : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmTotalAccount(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmTotalAccount_Load(object sender, EventArgs e)
        {
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
            FillcmbProvinces();
        }

        DataTable dt_GroupAccount;
        private void FillcmbProvinces()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.GroupAccounts.ToList();
                cmbGroupAccount.DataSource = q;
                dt_GroupAccount = new DataTable();
                dt_GroupAccount = PublicClass.AddEntityTableToDataTable(q.ToList());


            }
        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from ta in db.TotalAccounts

                        join ga in db.GroupAccounts
                        on ta.Id_GroupAccount equals ga.Id
                        select new
                        {
                            ta.Id,
                            GroupAccountName = ga.Name,
                            AccountName = ta.Name,
                            AccountCode = ta.Cod,
                        };
                dgvList.DataSource = q.ToList();
                dgvList.AutoSizeColumns();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbGroupAccount, ResourceCode.T068, txtName, ResourceCode.T069))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.TotalAccounts.Count(c => c.Name == txtName.Text && c.Id_GroupAccount == GroupAccountId_);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T070); return;
                        }
                    }
                    else
                    {
                        int cont = db.TotalAccounts.Count(c => c.Name == txtName.Text && c.Id_GroupAccount == GroupAccountId_ && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T070); return;
                        }
                    }

                    var userRepo = new Repository<Entity.Accounts.TotalAccount.TotalAccount>(db);
                    if (userRepo.SaveOrUpdate(new Entity.Accounts.TotalAccount.TotalAccount { Id = ListId, Name = txtName.Text, Id_GroupAccount = GroupAccountId_, Cod=AccountCode, Sattus=true }, ListId))
                    {
                        PublicClass.WindowAlart("1");
                        FilldgvList();
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
            cmbGroupAccount.Enabled=true;
            txtName.ResetText();
            txtName.Focus();
            ListId = 0;
            AccountCode = 0;
            cmbGroupAccount.SelectedIndex=-1;
        }

        int GroupAccountId_ = 0;
        int AccountCode = 0;
        private void cmbGroupAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    if (cmbGroupAccount.SelectedIndex!=-1)
                    {
                        GroupAccountId_ = Convert.ToInt32(cmbGroupAccount.Value);

                        try
                        {
                            if (ListId==0)
                            {
                                int NewCodHesab;
                                var cn = db.TotalAccounts.Count(c => c.Id_GroupAccount==GroupAccountId_);
                                if (cn==0)
                                    NewCodHesab=GroupAccountId_*100+1;
                                else
                                    NewCodHesab=db.TotalAccounts.Where(c => c.Id_GroupAccount==GroupAccountId_).Max(c => c.Cod)+1;

                                AccountCode=NewCodHesab;
                            }
                        }
                        catch (Exception er)
                        {
                            PublicClass.ShowErrorMessage(er);
                        }
                    }
                }

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
                        var q = db.TotalAccounts.Where(c => c.Id == ListId).First();

                        cmbGroupAccount.Value = q.Id_GroupAccount;
                        AccountCode=q.Cod;
                        txtName.Text = q.Name;
                        cmbGroupAccount.Enabled=false;
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {
                        if (db.SpecificAccounts.Where(c => c.Id_TotalAccount == ListId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.TotalAccounts.Where(c => c.Id == ListId).First();
                            db.TotalAccounts.Remove(q);
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void frmTotalAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }

        private void cmbGroupAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbGroupAccount, dt_GroupAccount);

            }

        }
    }
}
