using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Ciltys;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Ciltys;
using HM_ERP_System.Forms.CustomerToGroup;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.Reports;

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

namespace HM_ERP_System.Forms.PlaceTransfer
{
    public partial class frmPlaceTransfer : frmAddItems, IUpdatableForms

    {
        private IUpdatableForms _updatableForms;

        public int ListId = 0;
        int UserId_ = PublicClass.UserId;
        public frmPlaceTransfer(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms = updatableForms;
        }
        public System.Data.DataTable dt_Citi;
        private void frmPlaceTransfer_Load(object sender, EventArgs e)
        {
            dt_Citi = new System.Data.DataTable();
            dt_Citi.Columns.Add("Id", typeof(int));
            dt_Citi.Columns.Add("Name", typeof(string));
            DataColumn productColumn1 = dt_Citi.Columns["Id"];
            dt_Citi.PrimaryKey = new DataColumn[] { productColumn1 };

            UpdateData();
        }
        private void CallUpdateTata()
        {
            FilldgvList();
            fillcmbCiti1();
            fillcmbCiti2();
        }

        private void fillcmbCiti2()
        {
            using (var db = new DBcontextModel())
            {
                var q = (from ct in db.Ciltys
                         join pr in db.Provinces
                         on ct.ProvincesId equals pr.Id
                         select new
                         {
                             ct.Id,
                             ct.Name,
                             Provinces = pr.Name,
                         }).ToList();

                cmbCity2.DataSource = q;
                dt_City2 = new DataTable();
                dt_City2 = PublicClass.AddEntityTableToDataTable(q);
            }
        }
        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void fillcmbCiti1()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = (from ct in db.Ciltys
                             join pr in db.Provinces
                             on ct.ProvincesId equals pr.Id
                             select new
                             {
                                 ct.Id,
                                 ct.Name,
                                 Provinces = pr.Name,
                             }).ToList();

                    cmbCity1.DataSource = q;
                    dt_City1 = new DataTable();
                    dt_City1 = PublicClass.AddEntityTableToDataTable(q);

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// نوع جابجایی:بارگیری، تخلیه
        /// </summary>
        private void FillcmbEvacuationDeployment()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.EvacuationDeployments.ToList();
                    cmbEvacuationDeployment.DataSource = q;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FilldgvList()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from pt in db.PlaceTransfers


                            join ct in db.Ciltys
                            on pt.CiltyId equals ct.Id

                            join pr in db.Provinces
                            on ct.ProvincesId equals pr.Id

                            join cuR in db.CustomerRoles
                            on pt.UserId equals cuR.Id into cuRGroup
                            from cuR_ in cuRGroup.DefaultIfEmpty()

                            join CuUser in db.Customers
                            on cuR_.CustomerId equals CuUser.Id into CuUserGroup
                            from CuUser_ in CuUserGroup.DefaultIfEmpty()


                            select new
                            {
                                pt.Id,
                                PlaceTransferName = pt.Name,
                                CityName = ct.Name,
                                ProvincesName = pr.Name,
                                pt.publicStatus,
                                pt.PostalCode,
                                pt.Addres,
                                User = CuUser_ != null ? CuUser_.Family + " " + CuUser_.Name : "-",
                            };
                    DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); dgvList.DataSource = dt;
                    PublicClass.SettingGridEX(dgvList, Name);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PublicClass.SetPeremission("Node1_1_4_1", 1)) return;
                if (PublicClass.FindEmptyControls(cmbCity1, ResourceCode.T014, txtPlaceTransferName, ResourceCode.T023))
                    return;
                if (chkPublic.Checked && dt_Citi.Rows.Count == 0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T178); return;
                }

                using (var db = new DBcontextModel())
                {
                    if (ListId == 0)
                    {
                        int cont = db.PlaceTransfers.Count(c => c.Name == txtPlaceTransferName.Text && c.CiltyId == CityId1);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T024); return;
                        }
                    }
                    else
                    {
                        int cont = db.PlaceTransfers.Count(c => c.Name == txtPlaceTransferName.Text && c.CiltyId == CityId1 && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T006); return;
                        }
                    }

                    var userRepo = new Repository<Entity.PlaceTransfer.PlaceTransfer>(db);
                    int id = userRepo.SaveOrUpdateRefId(new Entity.PlaceTransfer.PlaceTransfer { Id = ListId, Name = txtPlaceTransferName.Text, CiltyId = CityId1, PostalCode = txtPostalCode.Text, Addres = txtAddres.Text, publicStatus = chkPublic.Checked, UserId = UserId_, RecordDateTime = DateTime.Now }, ListId);

                    if (chkPublic.Checked && dt_Citi.Rows.Count != 0)
                    {
                        //حذف شهرهای قبلی که در لیست شهرهای جدید نیستند
                        var q = db.FloatingPublicCities.Where(c => c.PlaceTransferId == ListId).ToList();
                        foreach (var list in q)
                        {
                            DataRow existingRow = dt_Citi.Rows.Find(list.CiltysId);
                            if (existingRow == null)
                            {
                                db.FloatingPublicCities.Remove(list);
                            }
                        }
                        db.SaveChangesSafe();
                        foreach (DataRow item in dt_Citi.Rows)
                        {
                            int citiid = Convert.ToInt32(item["Id"]);
                            using (var db0 = new DBcontextModel())
                            {
                                int Id_0 = 0;
                                if (ListId == 0)
                                    Id_0 = id;
                                else
                                    Id_0 = ListId;

                                var serch = db.FloatingPublicCities.Where(c => c.PlaceTransferId == Id_0 && c.CiltysId == citiid);

                                if (serch.Count() == 0)
                                {
                                    FloatingPublicCities fpc = new FloatingPublicCities();
                                    fpc.PlaceTransferId = id;
                                    fpc.CiltysId = citiid;
                                    db0.FloatingPublicCities.Add(fpc);
                                }
                                db0.SaveChangesSafe();
                            }
                        }
                    }

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
            txtPlaceTransferName.ResetText();
            txtPostalCode.ResetText();
            txtAddres.ResetText();
            ListId = 0;
            txtPostalCode.Focus();
            chkPublic.Checked = false;
            FilldgvList();
            dt_Citi.Clear();
        }

        int EvacuationDeploymentId = 0;
        private void cmbEvacuationDeployment_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                EvacuationDeploymentId = Convert.ToInt32(cmbEvacuationDeployment.Value);
            }
            catch (Exception)
            {
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }
        /// <summary>
        /// ویرایش و حذف رکورد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {

                ListId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Edit")
                {
                    if (!PublicClass.SetPeremission("Node1_1_4_2", 1)) return;
                    using (var db = new DBcontextModel())
                    {
                        var q = db.PlaceTransfers.Where(c => c.Id == ListId).First();

                        //cmbEvacuationDeployment.Value = q.EvacuationDeploymentId;
                        cmbCity1.Value = q.CiltyId;
                        txtPlaceTransferName.Text = q.Name;
                        chkPublic.Checked = q.publicStatus;
                        txtPostalCode.Text = q.PostalCode;
                        txtAddres.Text = q.Addres;
                        if (q.publicStatus)
                        {
                            var srch = db.FloatingPublicCities.Where(c => c.PlaceTransferId == ListId).ToList();
                            foreach (var item in srch)
                            {
                                DataRow newrow = dt_Citi.NewRow();
                                {
                                    newrow["Id"] = item.CiltysId;
                                    newrow["Name"] = db.Ciltys.Where(c => c.Id == item.CiltysId).First().Name;
                                    dt_Citi.Rows.Add(newrow);
                                    dgvListCity.DataSource = dt_Citi;
                                }
                            }
                        }
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    if (!PublicClass.SetPeremission("Node1_1_4_3", 1)) return;
                    using (var db = new DBcontextModel())
                    {

                        if (db.ComersHs.Where(c => c.LoadingLocationId == ListId || c.UnLoadingLocationId == ListId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.PlaceTransfers.Where(c => c.Id == ListId).First();
                            db.PlaceTransfers.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChangesSafe();
                            FilldgvList();
                            CelearItems();
                        }
                    }
                }

                else if (e.Column.Key == "FloatingPublicCities")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.FloatingPublicCities.Where(c => c.PlaceTransferId == ListId);
                        if (q.Count() == 0)
                        {
                            PublicClass.StopMesseg(ResourceCode.T178);
                            return;
                        }
                        frmFloatingPublicCities frmFloatingPublicCities = new frmFloatingPublicCities(this);
                        frmFloatingPublicCities.citiesId = ListId;
                        frmFloatingPublicCities.ShowDialog();
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

        int CityId1 = 0;
        int CityId2 = 0;

        public DataTable dt_City1 { get; private set; }
        public DataTable dt_City2 { get; private set; }

        private void cmbCity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CityId1 = Convert.ToInt32(cmbCity1.Value);
            }
            catch (Exception)
            {
            }

        }

        private void cmbCity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");

                if (e.KeyCode == Keys.F2)
                {
                    if (dt_City1.Rows.Count > 0)
                        cmbCity1.Value = PublicClass.SearchToCmb(cmbCity1, dt_City1);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void cmbEvacuationDeployment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            frmCiltys f = new frmCiltys(this);
            f.ShowDialog();
            fillcmbCiti1();
        }

        private void frmPlaceTransfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) if (PublicClass.CloseForm()) this.Close();
            if (e.Control && e.KeyCode == Keys.F12) { UpdateData(); PublicClass.WindowAlart("1", ResourceCode.T161); }
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            using (var db = new DBcontextModel())
            {
                if (txtPostalCode.Text != "")
                {
                    var q = db.PlaceTransfers.Where(c => c.PostalCode == txtPostalCode.Text);
                    if (q.Count() > 0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T157);
                        txtPostalCode.ResetText();
                        txtPostalCode.Focus();
                        return;
                    }
                }
            }

        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }

        private void buttonX01_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            //f.Cod="4";
            f.grid = dgvList;
            //f.Condition="";
            //f.DateReport="گزارش تاریخ: "+PersianDate.NowPersianDate;
            f.TitelString = ResourceCode.TRplaseTransfer;
            f.ReporFileName = "HM_ERP_System.ReportViewer.Report_PlaceTransfer.rdlc";
            f.ShowDialog();

        }

        private void chkPublic_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = chkPublic.Checked;
        }

        private void cmbCity2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CityId2 = Convert.ToInt32(cmbCity2.Value);
            }
            catch (Exception)
            {
            }

        }

        private void cmbCity2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");

                if (e.KeyCode == Keys.F2)
                {
                    if (dt_City2.Rows.Count > 0)
                        cmbCity2.Value = PublicClass.SearchToCmb(cmbCity2, dt_City2);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void AddCityToLIst_Click(object sender, EventArgs e)
        {
            if (cmbCity1.SelectedIndex == -1)
            {
                PublicClass.StopMesseg(ResourceCode.T179);
                cmbCity1.Focus();
                return;
            }

            if (cmbCity1.Text == cmbCity2.Text)
            {
                PublicClass.StopMesseg(ResourceCode.T180);
                cmbCity2.Focus();
                return;
            }

            DataRow newrow = dt_Citi.NewRow();
            DataRow existingRow = dt_Citi.Rows.Find(CityId2);
            if (existingRow == null)
            {
                using (var db = new DBcontextModel())
                {
                    newrow["Id"] = CityId2;
                    newrow["Name"] = cmbCity2.Text;
                    dt_Citi.Rows.Add(newrow);
                    dgvListCity.DataSource = dt_Citi;
                }
            }
            else
            {
                PublicClass.StopMesseg(ResourceCode.T177);
                return;
            }
            cmbCity2.Focus();
        }
    }
}

