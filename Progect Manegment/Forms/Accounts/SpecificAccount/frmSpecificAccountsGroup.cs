using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.SpecificAccount;
using HM_ERP_System.Entity.Accounts.TransactionType;
using HM_ERP_System.Entity.TruckUsageType;
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

using static System.Net.Mime.MediaTypeNames;

namespace HM_ERP_System.Forms.Accounts.SpecificAccount
{
    public partial class frmSpecificAccountsGroup : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmSpecificAccountsGroup(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            //_updatableForms=updatableForms;

        }
        public void UpdateData()
        {
          CallUpdateTata();
        }

        private void frmSpecificAccountsGroup_Load(object sender, EventArgs e)
        {

            UpdateData();
        }
        private void CallUpdateTata()
        {
            FilldgvList();
            FillcmbTransactionTypes();
            FillcmbSpecificAccountF();
            PublicClass.SettingGridEX(dgvList,Name);
        }

        private void FilldgvList()
        {
            using(var db=new DBcontextModel())
            {
                var q = from sag in db.SpecificAccountsGroups

                        join tt in db.TransactionTypes
                        on sag.TransactionTypeId equals tt.Id

                        join spaF in db.SpecificAccounts
                        on sag.SpecificAccountIdF equals spaF.Id

                       select new
                        {
                            sag.Id,
                            sag.Name,
                            sag.Description,
                            TransactionType = tt.Name,
                            SpecificAccount = spaF.Name,
                            
                        };
                System.Data.DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt;
                dgvList.AutoSizeColumns();

            }
        }

        DataTable dt_SpecificAccountF;
        /// <summary>
        /// دریافت از
        /// </summary>
        private void FillcmbSpecificAccountF()
        {
            using (var db = new DBcontextModel())
            {
                var q = from sp in db.SpecificAccounts

                        join ta in db.TotalAccounts
                        on sp.Id_TotalAccount equals ta.Id

                        //where (int)sp.Cod/1000!=Code && sp.Status
                        select new
                        {
                            sp.Id,
                            sp.Name,
                            Code = sp.Cod,
                            TotalAccountName = ta.Name,
                        };

                cmbSpecificAccountF.DataSource = q.ToList();
                dt_SpecificAccountF = new DataTable();
                dt_SpecificAccountF = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }




        private void FillcmbTransactionTypes()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.TransactionTypes.ToList();
                cmbTransactionTypes.DataSource = q;
            }

        }

        private void cmbSpecificAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbSpecificAccountF, dt_SpecificAccountF);
            }

        }
        int SpecificAccountIdF = 0;

        private void cmbSpecificAccount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SpecificAccountIdF = Convert.ToInt32(cmbSpecificAccountF.Value);
            }
            catch (Exception)
            {
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //string Carplate_ = this.txtCarplate1.Text + " " + ResourceCode.T016 + " " + this.txtCarplate2.Text;

                if (PublicClass.FindEmptyControls(cmbTransactionTypes, ResourceCode.T125, txtName, ResourceCode.T126, cmbSpecificAccountF, ResourceCode.T127))
                    return;

                if (cmbSpecificAccountF.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T045);
                    return;
                }

                using (var db = new DBcontextModel())
                {
                    if (ListId == 0)
                    {
                        int cont = db.SpecificAccountsGroups.Count(c => c.SpecificAccountIdF == SpecificAccountIdF  && c.Name==txtName.Text && c.TransactionTypeId==TransactionTypesId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T119); return;
                        }
                    }
                    else
                    {
                        int cont = db.SpecificAccountsGroups.Count(c => c.SpecificAccountIdF == SpecificAccountIdF  && c.Name==txtName.Text && c.TransactionTypeId==TransactionTypesId && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T018); return;
                        }
                    }

                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    var save = new Repository<SpecificAccountsGroup>(db);
                    if (save.SaveOrUpdate(new SpecificAccountsGroup { Id = ListId,TransactionTypeId=TransactionTypesId,Name=txtName.Text,SpecificAccountIdF=SpecificAccountIdF ,Description=txtDescription.Text}, ListId))
                    {
                        

                        PublicClass.WindowAlart("1");
                        if (_updatableForms!=null)
                            _updatableForms.UpdateData();
                        CelearItems();
                        FilldgvList();
                    }
                    else
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T044);
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
            txtName.ResetText();
            txtDescription.ResetText();
            cmbSpecificAccountF.ResetText();
            //cmbSpecificAccountT.ResetText();
            ListId=0;
            txtName.Focus();
        }

        int TransactionTypesId = 0;
        private void cmbTransactionTypes_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TransactionTypesId = Convert.ToInt32(cmbTransactionTypes.Value);
            }
            catch (Exception)
            {
            }

        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            ListId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
            if (e.Column.Key == "Edit")
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.SpecificAccountsGroups.Where(c => c.Id == ListId).First();
                    cmbTransactionTypes.Value=q.TransactionTypeId;
                    txtName.Text=q.Name;
                    cmbSpecificAccountF.Value=q.SpecificAccountIdF;
                    //cmbSpecificAccountT.Value=q.SpecificAccountIdT;
                    txtDescription.Text=q.Description;
                }
            }

            else if (e.Column.Key == "Delete")
            {
                using (var db = new DBcontextModel())
                {

                    //if (db.SpecificAccountsGroups.Where(c => c.CarId == ListId).Count() != 0)
                    //{
                    //    PublicClass.ErrorMesseg(ResourceCode.T004);
                    //    return;
                    //}

                    if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var q = db.SpecificAccountsGroups.Where(c => c.Id == ListId).First();
                        db.SpecificAccountsGroups.Remove(q);
                        
                        db.SaveChanges();
                        FilldgvList();
                        CelearItems();
                        PublicClass.WindowAlart("2");
                    }
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
            FilldgvList();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
             PublicClass.SaveGridExToExcel(dgvList);
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}
