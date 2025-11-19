using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Customer;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.PersonGroup;

using Janus.Windows.GridEX.EditControls;

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

namespace HM_ERP_System.Forms.CustomerToGroup
{
    public partial class frmCustomerToGroup : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmCustomerToGroup(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmCustomerToGroup_Load(object sender, EventArgs e)
        {
            UpdateData();

        }
        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {

            FilldgvList();
            FillcmbPerson();
            FillcmbGroup();
        }

        private void FillcmbGroup()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.PersonGroups.ToList();
                cmbGroup.DropDownDataSource= q;
                //cmbGroup.DropDownList.AutoSizeColumns();
            }
        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from cg in db.CustomerToGroups

                        join cu in db.Customers
                        on cg.CustomerId equals cu.Id

                        join pg in db.PersonGroups
                        on cg.PersonGroupId equals pg.Id

                        select new
                        {
                            cg.Id,
                            personName = cu.Family +" "+ cu.Name,
                            groupName = pg.Name,
                            cu.CodMeli,
                        };
                dgvList.DataSource=q.ToList();
                PublicClass.SettingGridEX(dgvList);
            }
        }

        DataTable dt_Person;
        private void FillcmbPerson()
        {
            using (var db = new DBcontextModel())
            {
                var q = from cu in db.Customers

                        join ct in db.TypeCustomers
                        on cu.id_TypeCustomer equals ct.Id
                        where cu.id_TypeCustomer<=2
                        select new
                        {
                            cu.Id,
                            name = cu.Family +" "+ cu.Name,
                            CustomerType = ct.Name,
                        };
                cmbPerson.DropDownDataSource=q.ToList();
                dt_Person = new DataTable();
                dt_Person = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }

        private void cmbGroup_CheckedValuesChanged(object sender, EventArgs e)
        {

        }
        int PersonId = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPerson.Text=="")
            {
                PublicClass.ErrorMesseg(ResourceCode.T007); return;
            }
            if (cmbGroup.Text=="")
            {
                PublicClass.ErrorMesseg(ResourceCode.T097); return;
            }

            if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;


            using (var db = new DBcontextModel())
            {
                foreach (var CustomerId in cmbPerson.CheckedValues)
                {
                    foreach (var GroupId in cmbGroup.CheckedValues)
                    {
                        int cuId = Convert.ToInt32(CustomerId);
                        int grId = Convert.ToInt32(GroupId);

                        var q = db.CustomerToGroups.Where(c => c.CustomerId==cuId && c.PersonGroupId==grId);
                        if (q.Count()==0)
                        {
                            var userRepo = new Repository<Entity.CustomerToGroup.CustomerToGroup>(db);
                            userRepo.SaveOrUpdate(new Entity.CustomerToGroup.CustomerToGroup { Id = ListId, CustomerId=cuId, PersonGroupId= grId }, ListId);
                        }
                    }
                }
                PublicClass.WindowAlart("1");
                FilldgvList();
                if (_updatableForms!=null)
                    _updatableForms.UpdateData();

                CelearItems();
            }
        }

        private void CelearItems()
        {
            cmbPerson.ResetText();
            cmbGroup.ResetText();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmCustomer f = new frmCustomer(this);
            f.ShowDialog();
            FillcmbPerson();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            frmPersonGroup f = new frmPersonGroup(this);
            f.ShowDialog();
            FillcmbGroup();
        }

        private void frmCustomerToGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
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
                        var q = db.Ciltys.Where(c => c.Id == ListId).First();

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
                            var q = db.CustomerToGroups.Where(c => c.Id == ListId).First();
                            db.CustomerToGroups.Remove(q);
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

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(owner: this, caption: "لیست ستون ها");
        }
    }
}
