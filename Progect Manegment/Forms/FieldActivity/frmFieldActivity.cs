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

namespace HM_ERP_System.Forms.FieldActivity
{
    public partial class frmFieldActivity : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmFieldActivity(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms = updatableForms;

        }
        private void frmFieldActivity_Load(object sender, EventArgs e)
        {
            CallUpdateTata();
        }
        public void UpdateData()
        {
            CallUpdateTata();
        }

        private void CallUpdateTata()
        {
            FilldgvList();
        }
        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q=from fa in db.FieldActivities

                      join cuR in db.CustomerRoles
                      on fa.UserId equals cuR.Id into cuRGroup
                      from cuR_ in cuRGroup.DefaultIfEmpty()

                      join CuUser in db.Customers
                      on cuR_.CustomerId equals CuUser.Id into CuUserGroup
                      from CuUser_ in CuUserGroup.DefaultIfEmpty()


                      select new
                      {
                          fa.Id,
                          fa.Name,
                          User = CuUser_ != null ? CuUser_.Family + " " + CuUser_.Name : "-",
                      };
                DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt;
                PublicClass.SettingGridEX(dgvList, Name);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(txtName, ResourceCode.T183))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.Provinces.Count(c => c.Name == txtName.Text);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T163); return;
                        }
                    }
                    else
                    {
                        int cont = db.Provinces.Count(c => c.Name == txtName.Text & c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T163); return;
                        }
                    }

                    var userRepo = new Repository<Entity.FieldActivity.FieldActivity>(db);
                    if (userRepo.SaveOrUpdate(new Entity.FieldActivity.FieldActivity { Id = ListId, Name = txtName.Text,UserId=PublicClass.UserId,RecordDateTime=DateTime.Now }, ListId))
                    {
                        PublicClass.WindowAlart("1");
                        if (_updatableForms != null)
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
            ListId = 0;
            txtName.ResetText();
            txtName.Focus();
            FilldgvList();
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
                        var q = db.FieldActivities.Where(c => c.Id == ListId).First();
                        txtName.Text = q.Name;
                    }
                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        if (db.PlaceTransfers.Where(c => c.FieldActivityId == ListId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            var q = db.FieldActivities.Where(c => c.Id == ListId).First();
                            db.FieldActivities.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChangesSafe();
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
    }
}
