using HM_ERP_System.Class_General;
using HM_ERP_System.Forms.Accounts.TotalAccount;
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

namespace HM_ERP_System.Forms.Accounts.SpecificAccount
{
    public partial class frmSpecificAccount : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmSpecificAccount(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmSpecificAccount_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {
            //dgvList.SaveSettings=true;
            //dgvList.SettingsKey=this.Name;

            FilldgvList();
            FillcmbTotalAccount();
        }

        DataTable dt_TotalAccount;
        private void FillcmbTotalAccount()
        {
            using (var db = new DBcontextModel())
            {
                var q = from ta in db.TotalAccounts
                        join ga in db.GroupAccounts
                        on ta.Id_GroupAccount equals ga.Id

                        select new
                        {
                            Id = ta.Id,
                            Name = ta.Name,
                            GroupAccountName = ga.Name,

                        };
                cmbTotalAccount.DataSource = q.ToList();
                dt_TotalAccount = new DataTable();
                dt_TotalAccount = PublicClass.AddEntityTableToDataTable(q.ToList());


            }
        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from sa in db.SpecificAccounts

                        join ta in db.TotalAccounts
                        on sa.Id_TotalAccount equals ta.Id

                        join ga in db.GroupAccounts
                        on ta.Id_GroupAccount equals ga.Id

                        join na in db.NatureAccounts
                        on ga.IdMahiyat equals na.Id

                        select new
                        {
                            sa.Id,
                            GroupAccountName = ga.Name,
                            TotalAccountName = ta.Name,
                            AccountName = sa.Name,
                            NatureAccountName = na.Name,
                            AccountCode = sa.Cod,
                            sa.Status,
                        };
                DataTable dt = PublicClass.EntityTableToDataTable(q.ToList());dgvList.DataSource = dt;
                dgvList.AutoSizeColumns();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbTotalAccount, ResourceCode.T069, txtName, ResourceCode.T071))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.SpecificAccounts.Count(c => c.Name == txtName.Text && c.Id_TotalAccount == TotalAccountId_);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T072); return;
                        }
                    }
                    else
                    {
                        int cont = db.SpecificAccounts.Count(c => c.Name == txtName.Text && c.Id_TotalAccount == TotalAccountId_ && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T072); return;
                        }
                    }

                    var userRepo = new Repository<Entity.Accounts.SpecificAccount.SpecificAccount>(db);
                    if (userRepo.SaveOrUpdate(new Entity.Accounts.SpecificAccount.SpecificAccount { Id = ListId, Name = txtName.Text, Id_TotalAccount = TotalAccountId_, Cod=AccounCode, Status=chkStatus.Checked }, ListId))
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
            cmbTotalAccount.Enabled=true;
            txtName.ResetText();
            txtName.Focus();
            chkStatus.Checked = true;
            ListId = 0;
            AccounCode=0;
            cmbTotalAccount.SelectedIndex=-1;
        }

        int TotalAccountId_ = 0;
        int AccounCode = 0;
        private void cmbTotalAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    if (cmbTotalAccount.SelectedIndex != -1)
                    {
                        TotalAccountId_ = Convert.ToInt32(cmbTotalAccount.Value);

                        try
                        {
                            if (ListId==0)
                            {
                                int NewCodHesabMoin;
                                var cn = db.SpecificAccounts.Count(c => c.Id_TotalAccount==TotalAccountId_);
                                var CodHesabKol = db.TotalAccounts.Where(c => c.Id==TotalAccountId_).First().Cod;

                                if (cn==0)
                                    NewCodHesabMoin=CodHesabKol*100+1;
                                else
                                    NewCodHesabMoin=db.SpecificAccounts.Where(c => c.Id_TotalAccount==TotalAccountId_).Max(c => c.Cod)+1;
                                AccounCode=NewCodHesabMoin;
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
                        var q = db.SpecificAccounts.Where(c => c.Id == ListId).First();
                        cmbTotalAccount.Value = q.Id_TotalAccount;
                        AccounCode=q.Cod;
                        txtName.Text = q.Name;
                        cmbTotalAccount.Enabled=false;
                        chkStatus.Checked=q.Status;
                    }
                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {
                        //if (db.SpecificAccounts.Where(c => c.Id_TotalAccount == LisId).Count() != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            var q = db.SpecificAccounts.Where(c => c.Id == ListId).First();
                            db.SpecificAccounts.Remove(q);
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

        private void btnAddNewCity1_Click(object sender, EventArgs e)
        {
            frmTotalAccount f = new frmTotalAccount(this);
            f.ShowDialog();
            FillcmbTotalAccount();
        }

        private void frmSpecificAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbTotalAccount_KeyDown(object sender, KeyEventArgs e)
        {
                        if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbTotalAccount, dt_TotalAccount);

            }

        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}
