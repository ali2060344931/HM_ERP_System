using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Provinces;
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
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HM_ERP_System.Forms.PurchaseTanker
{
    public partial class frmPurchase_Tanker : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;

        public frmPurchase_Tanker(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }
        private void frmPurchase_Tanker_Load(object sender, EventArgs e)
        {
            txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);
            txtDateEnd.Value = DateTime.Now;

            txtDate.Value= DateTime.Now;
            UpdateData();
        }
        public void UpdateData()
        {
            CallUpdateTata();
        }

        private void CallUpdateTata()
        {
            FilldgvList();
            FillcmbSeller();
            FillcmbBuyer();
            FillcmbTypeTrailer();
            FilltxtypeChassisCapsule();
            FilltxtManufacturer();
            FilltxtDocumentStatus();
        }

        private void FilltxtDocumentStatus()
        {
            using (var db = new DBcontextModel())
            {
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                var q = db.PurchaseTankers.ToList();
                foreach (var i in q)
                {
                    a.Add(i.DocumentStatus);
                }
                txtDocumentStatus.AutoCompleteCustomSource=a;
            }

        }

        private void FilltxtManufacturer()
        {
            using (var db = new DBcontextModel())
            {
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                var q = db.PurchaseTankers.ToList();
                foreach (var i in q)
                {
                    a.Add(i.Manufacturer);
                }
                txtManufacturer.AutoCompleteCustomSource=a;
            }
        }

        private void FilltxtypeChassisCapsule()
        {
            using (var db = new DBcontextModel())
            {
                //ToDo AutoCompleteMode TextBox
                //txtypeChassisCapsule.Auto CompleteMode = AutoCompleteMode.SuggestAppend;
                //txtypeChassisCapsule.AutoCompleteSource=AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                var q = db.PurchaseTankers.ToList();
                foreach (var i in q)
                {
                    a.Add(i.TypeChassisCapsule);
                }
                txtTypeChassisCapsule.AutoCompleteCustomSource=a;
            }
        }

        private void FillcmbTypeTrailer()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.TruckUsageTypes.ToList()/*.OrderBy(c=>c.Name)*/;
                cmbTypeTrailer.DataSource=q;
            }
        }

        DataTable dt_Buyer;

        private void FillcmbBuyer()
        {
            using (var db = new DBcontextModel())
            {
                var q = (from cu in db.Customers
                         where cu.id_TypeCustomer<=2


                         select new
                         {
                             cu.Id,
                             Name = cu.Family +" "+cu.Name,
                             cu.Tel,
                         }).OrderBy(c => c.Name);


                cmbBuyer.DataSource = q.ToList();
                dt_Buyer = new System.Data.DataTable();
                dt_Buyer = PublicClass.AddEntityTableToDataTable(q.ToList());
            }


        }

        DataTable dt_Seller;
        private void FillcmbSeller()
        {
            using (var db = new DBcontextModel())
            {
                var q = (from cu in db.Customers
                         where cu.id_TypeCustomer<=2

                         select new
                         {
                             cu.Id,
                             Name = cu.Family +" "+cu.Name,
                             cu.Tel,
                         }).OrderBy(c => c.Name);
                cmbSeller.DataSource = q.ToList();
                dt_Seller = new System.Data.DataTable();
                dt_Seller = PublicClass.AddEntityTableToDataTable(q.ToList());
            }

        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from pt in db.PurchaseTankers

                        join Seller in db.Customers
                        on pt.SellerId equals Seller.Id

                        join Buyer in db.Customers
                        on pt.BuyerId equals Buyer.Id

                        join tut in db.TruckUsageTypes
                        on pt.TypeTrailerId equals tut.Id
                        
                        where string.Compare(pt.Date, txtDateStart.Text) >= 0 && string.Compare(pt.Date, txtDateEnd.Text) <= 0

                        select new
                        {
                            pt.Id,
                            pt.Date,
                            Seller = Seller.Family +" "+Seller.Name,
                            Buyer = Buyer.Family +" "+Buyer.Name,
                            TypeTrailer = tut.Name,
                            pt.TankerNo,
                            pt.Manufacturer,
                            pt.NumberAxles,
                            pt.TypeChassisCapsule,
                            pt.DocumentStatus,
                            pt.PreviousPlateNumber,
                            pt.NewPlateNumber,
                            pt.PurchaseAmount,
                            pt.BlockedAmountDocument,
                            pt.AgencyCommission,
                            pt.TransactionsStatuse,
                        };
                dgvList.DataSource=q.ToList();
                PublicClass.SettingGridEX(dgvList,Name);
            }
        }

        int SellerId = 0;
        private void cmbSeller_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SellerId = Convert.ToInt32(cmbSeller.Value);
            }
            catch (Exception)
            {
            }

        }
        int BuyerId = 0;
        private void cmbBuyer_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BuyerId = Convert.ToInt32(cmbBuyer.Value);
            }
            catch (Exception)
            {
            }

        }
        int TypeTrailerId = 0;
        private void cmbTypeTrailer_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TypeTrailerId = Convert.ToInt32(cmbTypeTrailer.Value);
            }
            catch (Exception)
            {
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(txtTankerNo, "شماره کامیون را وارد نمائید", cmbSeller, "نام فروشنده را انتخاب نمائید.", cmbBuyer, "نام خریدار را انتخاب نمائید", txtNumberAxles, "تعداد محور را وارد نمائید", cmbTypeTrailer, "نوع یدک را انتخاب نمائید.", txtTypeChassisCapsule, "نوع شاسی یا کپسول را وارد نمائید.", txtManufacturer, "کارخانه سازنده را وارد نمائید.", txtDocumentStatus, "وضعیت سند را وارد نمائید.", txtPreviousPlateNumber, "شمار پلاک قبلی را وارد نمائید.", txtNewPlateNumber, "شماره پلاک جدید را وارد نمائید.", txtPurchaseAmount, "مبلغ خرید را وارد نمائید."))
                    return;
                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int TankerNo = Convert.ToInt32(txtTankerNo.Text);
                        int cont = db.PurchaseTankers.Count(c => c.TankerNo == TankerNo);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T129); return;
                        }
                    }
                    else
                    {
                        int TankerNo = Convert.ToInt32(txtTankerNo.Text);
                        int cont = db.PurchaseTankers.Count(c => c.TankerNo == TankerNo && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T129); return;
                        }
                    }

                    var save = new Repository<Entity.PurchaseTanker.PurchaseTanker>(db);
                    if (save.SaveOrUpdate(new Entity.PurchaseTanker.PurchaseTanker { Id = ListId, TankerNo=Convert.ToInt32(txtTankerNo.Text), Date=txtDate.Text, SellerId=SellerId, BuyerId=BuyerId, NumberAxles=Convert.ToInt32(txtNumberAxles.Text), TypeTrailerId=TypeTrailerId, TypeChassisCapsule=txtTypeChassisCapsule.Text, Manufacturer=txtManufacturer.Text, DocumentStatus=txtDocumentStatus.Text, PreviousPlateNumber= Convert.ToInt32(txtPreviousPlateNumber.Text), NewPlateNumber=Convert.ToInt32(txtNewPlateNumber.Text), PurchaseAmount=Convert.ToInt64(txtPurchaseAmount.TextSimple), BlockedAmountDocument=Convert.ToInt64(txtBlockedAmountDocument.TextSimple), AgencyCommission=Convert.ToInt64(txtAgencyCommission.TextSimple) }, ListId))
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
            txtTankerNo.ResetText();
            cmbSeller.ResetText();
            cmbBuyer.ResetText();
            txtNumberAxles.ResetText();
            cmbTypeTrailer.ResetText();
            txtTypeChassisCapsule.ResetText();
            txtManufacturer.ResetText();
            txtDocumentStatus.ResetText();
            txtPreviousPlateNumber.ResetText();
            txtNewPlateNumber.ResetText();
            txtPurchaseAmount.ResetText();
            txtAgencyCommission.ResetText();
            txtBlockedAmountDocument.ResetText();
            ListId=0;
            txtTankerNo.Focus();
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
                        var q = db.PurchaseTankers.Where(c => c.Id == ListId).First();
                        txtTankerNo.Text=q.TankerNo.ToString();
                        txtDate.Text=q.Date.ToString();
                        cmbSeller.Value=q.SellerId;
                        cmbBuyer.Value=q.BuyerId;
                        txtNumberAxles.Text=q.NumberAxles.ToString();
                        cmbTypeTrailer.Value=q.TypeTrailerId;
                        txtTypeChassisCapsule.Text=q.TypeChassisCapsule;
                        txtManufacturer.Text=q.Manufacturer;
                        txtDocumentStatus.Text=q.DocumentStatus;
                        txtPreviousPlateNumber.Text=q.PreviousPlateNumber.ToString();
                        txtNewPlateNumber.Text = q.NewPlateNumber.ToString();
                        txtPurchaseAmount.Text=q.PurchaseAmount.ToString();
                        txtAgencyCommission.Text=q.AgencyCommission.ToString();
                        txtBlockedAmountDocument.Text=q.BlockedAmountDocument.ToString();

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

                        if (System.Windows.Forms.MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.PurchaseTankers.Where(c => c.Id == ListId).First();
                            db.PurchaseTankers.Remove(q);
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

        private void txtTankerNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            Customer.frmCustomer frmCustomer = new Customer.frmCustomer(this);
            frmCustomer.ShowDialog();
            FillcmbSeller();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Customer.frmCustomer frmCustomer = new Customer.frmCustomer(this);
            frmCustomer.ShowDialog();
            FillcmbBuyer();
        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvList();
        }

        private void btnRegDocAccounts_Click(object sender, EventArgs e)
        {
            if(dgvList.GetCheckedRows().Count()!=1)
            {
                PublicClass.ErrorMesseg(ResourceCode.T076);return;
            }

        }

        private void frmPurchase_Tanker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }

        private void buttonX01_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.grid=dgvList;
            f.TitelString =ResourceCode.TRPurchase_Tanker;
            f.ReporFileName ="HM_ERP_System.ReportViewer.Report_Purchase_Tanker.rdlc";
            f.ShowDialog();
        }
    }
}
