using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Ciltys;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Persons;

using MyClass;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Ciltys
{
    public partial class frmCiltys : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmCiltys(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmCiltys_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void CallUpdateTata()
        {
            FilldgvList();
            FillcmbProvinces();
        }
        public void UpdateData()
        {
           
            CallUpdateTata();
        }
        DataTable dt_Provinces;
        private void FillcmbProvinces()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.Provinces.ToList();
                cmbProvinces.DataSource = q;
                dt_Provinces = new System.Data.DataTable();
                dt_Provinces = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from ct in db.Ciltys

                        join pr in db.Provinces
                        on ct.ProvincesId equals pr.Id into provGroup
                        from pr in provGroup.DefaultIfEmpty()

                        select new
                        {
                            ct.Id,
                            NameCity = ct.Name,
                            // اگر ProvincesId برابر با 0 باشد، یا pr برابر با null باشد، خالی نشان بده
                            ProvincesName = (ct.ProvincesId == 0 || pr == null) ? "" : pr.Name
                        };
                DataTable dt = PublicClass.EntityTableToDataTable(q.ToList());dgvList.DataSource = dt;
                //dgvList.AutoSizeColumns();
                PublicClass.SettingGridEX(dgvList,Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbProvinces, ResourceCode.T002, txtName, ResourceCode.T005))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.Ciltys.Count(c => c.Name == txtName.Text && c.ProvincesId == ProvincesId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.

                                T006); return;
                        }
                    }
                    else
                    {
                        int cont = db.Ciltys.Count(c => c.Name == txtName.Text && c.ProvincesId == ProvincesId && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.
                                T006); return;
                        }
                    }

                    var userRepo = new Repository<Entity.Ciltys.Ciltys>(db);
                    if (userRepo.SaveOrUpdate(new Entity.Ciltys.Ciltys { Id = ListId, Name = txtName.Text, ProvincesId = ProvincesId }, ListId))
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
            txtName.ResetText();
            txtName.Focus();
            ListId = 0;
            FilldgvList();
        }

        int ProvincesId = 0;
        private void cmbProvinces_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ProvincesId = Convert.ToInt32(cmbProvinces.Value);
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
                        var q = db.Ciltys.Where(c => c.Id == ListId).First();

                        cmbProvinces.Value = q.ProvincesId;
                        txtName.Text = q.Name;
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q1=db.Customers.Where(c=>c.CityId == ListId).Count();
                        var q2=db.ComersHs.Where(c=>c.LoadingOrinigId == ListId).Count();
                        var q3=db.ComersHs.Where(c=>c.UnLoadingOrinigId == ListId).Count();


                        if (q1 != 0 ||q2 != 0 ||q3 != 0 )
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.Ciltys.Where(c => c.Id == ListId).First();
                            db.Ciltys.Remove(q);
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

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmProvinces f = new frmProvinces(this);
            f.ShowDialog();
            FillcmbProvinces();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void frmCiltys_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
                        if (e.Control && e.KeyCode == Keys.F12) { UpdateData();PublicClass.WindowAlart("1", ResourceCode.T161); }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cmbProvinces_KeyDown(object sender, KeyEventArgs e)
        {
                        if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbProvinces, dt_Provinces);
            }

        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }

        private void frmCiltys_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               
                dgvList.SaveComponentSettings();
            }
            catch { }
        }

    }
}
