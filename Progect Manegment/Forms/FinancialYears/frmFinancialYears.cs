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

namespace HM_ERP_System.Forms.FinancialYears
{
    public partial class frmFinancialYears : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public frmFinancialYears(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }
        public void UpdateData()
        {
            FilldgvList();
        }

        private void frmFinancialYears_Load(object sender, EventArgs e)
        {
            txtDateS.Value=DateTime.Now;
            txtDateE.Value=DateTime.Now;
            UpdateData();
        }
        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q=db.FinancialYears.ToList();
                dgvList.DataSource = q;
                PublicClass.SettingGridEX(dgvList);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(txtName, "نام(عنوان) سال مالی را وارد نمائید.")) return;
                if (txtDateS.Text.Length!=10)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T020);
                    txtDateS.Focus();
                    return;
                }
                if (txtDateE.Text.Length!=10)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T020);
                    txtDateE.Focus();
                    return;
                }

                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.FinancialYears.Count(c => c.Name == txtName.Text && c.DateStart == txtDateS.Text && c.DateEnd == txtDateE.Text);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T060); return;
                        }
                    }
                    else
                    {
                        int cont = db.FinancialYears.Count(c => c.Name == txtName.Text && c.DateStart == txtDateS.Text && c.DateEnd == txtDateE.Text && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T060); return;
                        }
                    }

                    var save = new Repository<Entity.FinancialYear.FinancialYear>(db);
                    if (save.SaveOrUpdate(new Entity.FinancialYear.FinancialYear { Id = ListId, Name = txtName.Text, DateStart=txtDateS.Text, DateEnd=txtDateE.Text }, ListId))
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
            txtName.ResetText();
            ListId=0;
            txtDateS.ResetText();
            txtDateE.ResetText();
            txtName.Focus();
            FilldgvList();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
             PublicClass.SaveGridExToExcel(dgvList);
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
                        var q = db.FinancialYears.Where(c => c.Id == ListId).First();
                        txtName.Text = q.Name;
                        txtDateS.Text=q.DateStart;
                        txtDateE.Text=q.DateEnd;
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {
                        string name=db.FinancialYears.Where(c=>c.Id== ListId).First().Name;

                        if (db.Transactions.Where(c => c.FinancialYear ==name).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.FinancialYears.Where(c => c.Id == ListId).First();
                            db.FinancialYears.Remove(q);
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
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }
}
