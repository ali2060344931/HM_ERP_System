using HM_ERP_System.Class_General;
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

        public int LisId = 0;
        int UserId_ = PublicClass.UserId;
        public frmPlaceTransfer(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmPlaceTransfer_Load(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void CallUpdateTata()
        {

            FilldgvList();
            //FillcmbEvacuationDeployment();
            fillcmbCity();
        }

        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void fillcmbCity()
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

                    cmbCity.DataSource = q;
                    dt_City = new DataTable();
                    dt_City = PublicClass.AddEntityTableToDataTable(q);

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

                            select new
                            {
                                pt.Id,
                                PlaceTransferName = pt.Name,
                                CityName = ct.Name,
                                ProvincesName = pr.Name,
                                pt.publicStatus,
                                pt.PostalCode,
                                pt.Addres,
                            };
                    dgvList.DataSource = q.ToList();
                    PublicClass.SettingGridEX(dgvList,Name);
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
                if (PublicClass.FindEmptyControls(/*cmbEvacuationDeployment, ResourceCode.T022,*/ cmbCity, ResourceCode.T014, txtPlaceTransferName, ResourceCode.T023))
                    return;
                using (var db = new DBcontextModel())
                {
                    if (LisId == 0)
                    {
                        int cont = db.PlaceTransfers.Count(c => c.Name == txtPlaceTransferName.Text /*&& c.EvacuationDeploymentId == EvacuationDeploymentId*/ && c.CiltyId == CityId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T024); return;
                        }
                    }
                    else
                    {
                        int cont = db.PlaceTransfers.Count(c => c.Name == txtPlaceTransferName.Text /*&& c.EvacuationDeploymentId == EvacuationDeploymentId*/ && c.CiltyId == CityId && c.Id != LisId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T006); return;
                        }
                    }

                    var userRepo = new Repository<Entity.PlaceTransfer.PlaceTransfer>(db);
                    if (userRepo.SaveOrUpdate(new Entity.PlaceTransfer.PlaceTransfer { Id = LisId, Name = txtPlaceTransferName.Text/*, EvacuationDeploymentId = EvacuationDeploymentId*/, CiltyId = CityId, PostalCode=txtPostalCode.Text, Addres=txtAddres.Text, publicStatus=chkPublic.Checked, UserId = UserId_, RecordDateTime = DateTime.Now }, LisId))
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
            txtPlaceTransferName.ResetText();
            txtPostalCode.ResetText();
            txtAddres.ResetText();
            LisId = 0;
            txtPostalCode.Focus();
            chkPublic.Checked=false;
            FilldgvList();
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

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                LisId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Edit")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.PlaceTransfers.Where(c => c.Id == LisId).First();

                        //cmbEvacuationDeployment.Value = q.EvacuationDeploymentId;
                        cmbCity.Value = q.CiltyId;
                        txtPlaceTransferName.Text = q.Name;
                        chkPublic.Checked=q.publicStatus;
                        txtPostalCode.Text= q.PostalCode;
                        txtAddres.Text= q.Addres;
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        if (db.ComersHs.Where(c => c.LoadingLocationId == LisId || c.UnLoadingLocationId == LisId).Count() != 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.PlaceTransfers.Where(c => c.Id == LisId).First();
                            db.PlaceTransfers.Remove(q);
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

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        int CityId = 0;

        public DataTable dt_City { get; private set; }

        private void cmbCity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CityId = Convert.ToInt32(cmbCity.Value);
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
                    if (dt_City.Rows.Count > 0)
                        cmbCity.Value = PublicClass.SearchToCmb(cmbCity, dt_City);
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
            fillcmbCity();
        }

        private void frmPlaceTransfer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) if (PublicClass.CloseForm()) this.Close();
        }

        private void txtPostalCode_Leave(object sender, EventArgs e)
        {
            using (var db = new DBcontextModel())
            {
                if (txtPostalCode.Text!="")
                {
                    var q = db.PlaceTransfers.Where(c => c.PostalCode==txtPostalCode.Text);
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
            f.grid=dgvList;
            //f.Condition="";
            //f.DateReport="گزارش تاریخ: "+PersianDate.NowPersianDate;
            f.TitelString =ResourceCode.TRplaseTransfer;
            f.ReporFileName="HM_ERP_System.ReportViewer.Report_PlaceTransfer.rdlc";
            f.ShowDialog();

        }
    }
}

