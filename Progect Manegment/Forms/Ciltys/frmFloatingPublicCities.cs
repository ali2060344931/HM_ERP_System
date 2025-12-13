using HM_ERP_System.Class_General;
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

namespace HM_ERP_System.Forms.Ciltys
{
    public partial class frmFloatingPublicCities : frmMasterForm, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int citiesId = 0;
        public frmFloatingPublicCities(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms = updatableForms;

        }

        private void frmFloatingPublicCities_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;

            UpdateData();
        }
        public void UpdateData()
        {
            dgvList.RootTable.Columns["PlaceTransferName"].Visible = chkSelectAllList.Checked;
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
                var q =
                    from fpc in db.FloatingPublicCities
                    join c in db.Ciltys on fpc.CiltysId equals c.Id
                    join p in db.Provinces on c.ProvincesId equals p.Id
                    join pt in db.PlaceTransfers on fpc.PlaceTransferId equals pt.Id
                    where chkSelectAllList.Checked || fpc.PlaceTransferId == citiesId
                    select new
                    {
                        fpc.Id,
                        NameCity = c.Name,
                        ProvincesName = p.Name,
                        PlaceTransferName=pt.Name
                    };

                dgvList.DataSource = q.ToList();
                PublicClass.SettingGridEX(dgvList);
            }
        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            ListId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);

            if (e.Column.Key == "Delete")
            {
                if (!PublicClass.SetPeremission("Node1_1_4_4_1", 1)) return;
                using (var db = new DBcontextModel())
                {
                    //if (db.ComersHs.Where(c => c.LoadingLocationId == ListId || c.UnLoadingLocationId == ListId).Count() != 0)
                    //{
                    //    PublicClass.ErrorMesseg(ResourceCode.T004);
                    //    return;
                    //}

                    if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var q = db.FloatingPublicCities.Where(c => c.Id == ListId).First();
                        db.FloatingPublicCities.Remove(q);
                        PublicClass.WindowAlart("2");
                        db.SaveChangesSafe();
                        FilldgvList();
                    }
                }
            }
        }

        private void chkSelectAllList_CheckedChanged(object sender, EventArgs e)
        {
            dgvList.RootTable.Columns["PlaceTransferName"].Visible = chkSelectAllList.Checked;
            FilldgvList();

        }
    }
}
