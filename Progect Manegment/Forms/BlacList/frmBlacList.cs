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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HM_ERP_System.Forms.BlacList
{
    public partial class frmBlacList : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmBlacList(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmBlacList_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void UpdateData()
        {
            FillcmbPerson();
            FilldgvList();

        }

        DataTable dt_Person;
        private void FillcmbPerson()
        {
            using (var db = new DBcontextModel())
            {
                var q = from c in db.Customers

                            //join ctg in db.CustomerToGroups
                            //on c.Id equals ctg.CustomerId
                            ////where c.id_TypeCustomer == 1
                            //where ctg.PersonGroupId==1
                        select new
                        {
                            c.Id,
                            Name = (c.Family + " " + c.Name).Trim(),
                        };
                cmbPerson.DataSource = q.ToList();
                dt_Person = new DataTable();
                dt_Person = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }
        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from bl in db.BlacLists

                        join cu in db.Customers
                        on bl.CustomerId equals cu.Id

                        select new
                        {
                            bl.Id,
                            Name = (cu.Family+ " "+ cu.Name).Trim(),
                            des = bl.Description,
                            bl.status,
                            bl.NoSaveData,
                        };
                dgvList.DataSource = q.ToList();
                PublicClass.SettingGridEX(dgvList,Name);
                //dgvList.AutoSizeColumns();
            }
        }


        private void cmbPerson_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbPerson, dt_Person);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbPerson, ResourceCode.T007))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.BlacLists.Count(c => c.CustomerId == PersonId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T099); return;
                        }
                    }
                    else
                    {
                        int cont = db.BlacLists.Count(c => c.CustomerId == PersonId && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T099); return;
                        }
                    }

                    var userRepo = new Repository<Entity.BlacList.BlacList>(db);
                    if (userRepo.SaveOrUpdate(new Entity.BlacList.BlacList { Id = ListId, CustomerId =PersonId, Description = txtDes.Text, status=chkStatus.Checked, NoSaveData=chkNoSaveData.Checked }, ListId))
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
            cmbPerson.SelectedIndex=-1;
            txtDes.ResetText();
            chkStatus.Checked=true;
            chkNoSaveData.Checked=false;
            ListId= 0;
            cmbPerson.Focus();
            FilldgvList();
        }

        int PersonId = 0;
        private void cmbPerson_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                PersonId = Convert.ToInt32(cmbPerson.Value);
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
                        var q = db.BlacLists.Where(c => c.Id == ListId).First();

                        cmbPerson.Value = q.CustomerId;
                        txtDes.Text = q.Description;
                        chkStatus.Checked=q.status;
                        chkNoSaveData.Checked=q.NoSaveData;
                    }
                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        //if (db.Ciltys.Where(c => c.ProvincesId == LisId).Count() != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.BlacLists.Where(c => c.Id == ListId).First();
                            db.BlacLists.Remove(q);
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

        private void cmbPerson_Leave(object sender, EventArgs e)
        {
            using (var db = new DBcontextModel())
            {
                int cont = db.BlacLists.Count(c => c.CustomerId == PersonId);
                if (cont > 0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T099);
                    cmbPerson.ResetText();
                    cmbPerson.Focus();
                    return;
                }
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}
