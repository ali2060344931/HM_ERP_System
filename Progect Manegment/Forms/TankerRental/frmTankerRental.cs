using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.TruckUsageType;
using HM_ERP_System.Entity.WarantyType;
using HM_ERP_System.Forms.BillLadingRequest;
using HM_ERP_System.Forms.Main_Form;

using Janus.Windows.GridEX;
using Janus.Windows.UI.Tab;

using Microsoft.Office.Interop.Excel;

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
using System.Transactions;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.TankerRental
{
    public partial class frmTankerRental : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int ListId_ = 0;

        int UserId_ = PublicClass.UserId;

        public frmTankerRental(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmTankerRental_Load(object sender, EventArgs e)
        {
            txtDateS.Value = DateTime.Now;
            txtDateE.Value = DateTime.Now;

            string yyyymmdd = PersianDate.NowPersianDate;
            txtYear.Text=yyyymmdd.Substring(0, 4);
            cmbMont.SelectedIndex=Convert.ToInt32(yyyymmdd.Substring(5, 2))-1;
            UpdateData();
        }

        public void UpdateData()
        {
            CallUpdateTata();
        }

        private void CallUpdateTata()
        {
            FillcmbCarplate();
            FillcmbWarantyType();
            FilldgvList();
        }

        private void FillcmbWarantyType()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.WarantyTypes.ToList();
                cmbWarantyType.DataSource= q;
                cmbWarantyType.SelectedIndex=0;

            }

        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from sp in db.Spares

                        join cr in db.Cars
                        on sp.CarId equals cr.Id

                        join cu in db.Customers
                        on cr.GoodsAccountId equals cu.Id

                        join wr in db.WarantyTypes
                        on sp.WarantyTypeId equals wr.Id

                        join tut in db.TruckUsageTypes
                        on cr.TruckUsageTypeId equals tut.Id

                        select new
                        {
                            sp.Id,
                            sp.ContactNo,
                            sp.TankerNo,
                            cr.CarPlat,
                            cr.CarPlatSeryal,
                            cr.AxisCount,
                            cr.CarName,
                            //نام طرف حساب کامیون
                            GoodsAccountName = cu.Family+ " "+ cu.Name,
                            sp.DataStart,
                            sp.DataEnd,
                            sp.RentAmount,
                            sp.SecurityDeposit,
                            sp.ContractStatus,
                            sp.Description,
                            WarantyType = wr.Name,
                            TruckUsageTypeName = tut.Name,
                        };

                dgvList.DataSource=q.ToList();
                dgvList.AutoSizeColumns();
            }
        }

        System.Data.DataTable dt_Carplate;
        private void FillcmbCarplate()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = (from cr in db.Cars

                             join dr in db.Dravers
                             on cr.DraverId equals dr.Id

                             join cu in db.Customers
                             on dr.CustomerId equals cu.Id

                             join ct in db.Ciltys
                             on dr.CityId equals ct.Id

                             join pr in db.Provinces
                             on ct.ProvincesId equals pr.Id


                             where dr.Status /*&& (!cr.StatusCarToComers || ListId!=0)*/

                             select new
                             {
                                 cr.Id,
                                 CarPlat = cr.CarPlat + cr.CarPlatSeryal,
                                 cr.CarName,
                                 CarPlat_CarPlatSeryal = cr.CarPlatSeryal + " " + ResourceCode.T016 + " " + cr.CarPlat.ToString().Substring(2, 3) + "ع" + cr.CarPlat.ToString().Substring(0, 2),
                                 DraverName = cu.Family + " " + cu.Name,
                                 cu.CodMeli,
                                 cu.Tel,
                                 cr.Seryal,
                                 CityName = ct.Name,
                                 ProvinceName = pr.Name,
                                 //cmb.StatusDeliveryGoods,

                             }).ToList();
                    cmbCarplate.DataSource = q;
                    dt_Carplate = new System.Data.DataTable();
                    dt_Carplate = PublicClass.AddEntityTableToDataTable(q);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        int CarId_ = 0;
        public string Carplate_ = "";

        private void cmbCarplateH_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCarplate.SelectedIndex != -1 && cmbCarplate.Text.Length == 7)
                {
                    CarId_ = Convert.ToInt32(cmbCarplate.Value);
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Cars.Where(c => c.Id == CarId_).First();
                        Carplate_ = q.CarPlatSeryal + " " + ResourceCode.T016 + " " + q.CarPlat.ToString().Substring(2, 3) + "ع" + q.CarPlat.ToString().Substring(0, 2);


                        lblCarPlatH.Text = Carplate_;
                    }
                }
                else
                {
                    CarId_ = 0;
                    lblCarPlatH.ResetText();
                }

            }
            catch (Exception)
            {
            }
        }

        private void txtSecurityDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvList_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //string Carplate_ = this.txtCarplate1.Text + " " + ResourceCode.T016 + " " + this.txtCarplate2.Text;

                if (PublicClass.FindEmptyControls(txtContactNo, ResourceCode.T103, txtTankerNo, ResourceCode.T104, txtSecurityDeposit, ResourceCode.T105, txtRentAmount, ResourceCode.T106))
                    return;

                if (cmbCarplate.SelectedIndex==-1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T052);
                    return;
                }


                if (string.Compare(txtDateS.Text, txtDateE.Text)==1 || string.Compare(txtDateS.Text, txtDateE.Text)==0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T108);
                    return;

                }


                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.Spares.Where(c => c.TankerNo==txtTankerNo.Text /*&& c.ContactNo==txtContactNo.Text*/).Count();
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T107);
                            txtTankerNo.Focus();
                            return;
                        }
                    }
                    else
                    {
                        int cont = db.Spares.Where(c => c.TankerNo==txtTankerNo.Text /*&& c.ContactNo==txtContactNo.Text*/ && c.Id != ListId).Count();
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T107);
                            txtTankerNo.Focus();
                            return;
                        }
                    }

                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    var spares = new Repository<Entity.Spare.Spare>(db);
                    if (spares.SaveOrUpdate(new Entity.Spare.Spare { Id = ListId, ContactNo=txtContactNo.Text, TankerNo=txtTankerNo.Text, CarId=CarId_, DataStart=txtDateS.Text, DataEnd=txtDateE.Text, WarantyTypeId=WarantyTypeId_, SecurityDeposit=Convert.ToDouble(txtSecurityDeposit.TextSimple), RentAmount=Convert.ToDouble(txtRentAmount.TextSimple), ContractStatus=chkContractStatus.Checked, Description = txtDes.Text, UserId = UserId_, RecordDateTime = DateTime.Now }, ListId))
                    {
                        PublicClass.WindowAlart("1");
                        if (_updatableForms!=null)
                            _updatableForms.UpdateData();
                        FilldgvList();
                        CelearItems();
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
            ListId=0;
            txtContactNo.ResetText();
            txtTankerNo.ResetText();
            txtSecurityDeposit.ResetText();
            txtRentAmount.ResetText();
            txtDes.ResetText();
            cmbCarplate.SelectedIndex=-1;
            chkContractStatus.Checked=true;
            txtContactNo.Focus();
        }

        int WarantyTypeId_ = 0;

        private void cmbWarantyType_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbWarantyType.SelectedIndex != -1)
                {
                    WarantyTypeId_ = Convert.ToInt32(cmbWarantyType.Value);
                }
            }
            catch (Exception)
            {
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void btnAddCare_Click(object sender, EventArgs e)
        {
            Car.frmCar frmCar = new Car.frmCar(this);
            frmCar.ShowDialog();
            FillcmbCarplate();
        }

        private void txtContactNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cmbCarplate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCarplate, dt_Carplate);
            }

        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            ListId_ = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
            if (e.Column.Key == "Details")
            {
                cmsdgv.Show(Cursor.Position);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void cmsdgv_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            switch (e.Command.Key)
            {
                case "Edit":
                    using (var db = new DBcontextModel())
                    {
                        ListId=ListId_;
                        var q = db.Spares.Where(c => c.Id == ListId).First();
                        txtContactNo.Text=q.ContactNo;
                        txtTankerNo.Text=q.TankerNo;
                        cmbCarplate.Value=q.CarId;
                        txtDateS.Text=q.DataStart;
                        txtDateE.Text=q.DataEnd;
                        cmbWarantyType.Value=q.WarantyTypeId;
                        txtSecurityDeposit.Text=q.SecurityDeposit.ToString();
                        txtRentAmount.Text=q.RentAmount.ToString();
                        txtDes.Text = q.Description;
                        chkContractStatus.Checked=q.ContractStatus;
                    }
                    break;

                case "Delete":
                    using (var db = new DBcontextModel())
                    {
                        ListId=ListId_;

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.Spares.Where(c => c.Id == ListId).First();
                            db.Spares.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            FilldgvList();
                            CelearItems();
                        }
                        ListId=0;
                    }


                    break;
                case "AddDocumentToBanck"://ثبت مدارک
                    ListId=ListId_;
                    string lblCaption = "شماره قرارداد:" + dgvList.GetRow().Cells["ContactNo"].Value.ToString() + " شماره تانکـــر: " + dgvList.GetRow().Cells["TankerNo"].Value.ToString();

                    PublicClass.AddDocumentToBanck(this.Name, ListId, lblCaption);
                    FilldgvList();
                    ListId=0;
                    break;
                case "DocWaranty"://ثبت درخواست بارنامه
                    ListId=ListId_;
                    frmBillLadingRequest f = new frmBillLadingRequest(this);
                    f.ComersHId=ListId;
                    f.ShowDialog();
                    ListId=0;

                    break;
            }

        }

        int Series = 0;

        private void btnRegGroupDoc_Click(object sender, EventArgs e)
        {
            if (dgvList.GetCheckedRows().Count()==0)
            {
                PublicClass.ErrorMesseg(ResourceCode.T041); return;
            }
            //if (txtDesAghsat.Text=="")
            //{
            //    PublicClass.ErrorMesseg(ResourceCode.T117);
            //    txtDesAghsat.Focus();
            //    return;
            //}
            if (txtYear.Text=="" ||txtYear.Text.Length!=4)
            {
                PublicClass.ErrorMesseg(ResourceCode.T123);
                txtYear.Focus();
                return;

            }


            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("ListId", typeof(int));

            int TransactionCode = Convert.ToInt32(PublicClass.CreatTransactionCode());
            using (var db = new DBcontextModel())
            {
                var userRepo = new Repository<Entity.Accounts.Transaction.Transaction>(db);
                int n = 0;

                foreach (GridEXRow item in dgvList.GetCheckedRows())
                {
                    string txtDes = "قسط ماه:" + cmbMont.Text + " سال: " + txtYear.Text + " به شماره تانکر "+item.Cells["TankerNo"].Value.ToString() + "  با شماره قرارداد " + item.Cells["ContactNo"].Value.ToString() + " با شماره پلاک :"+ item.Cells["CarPlat"].Value.ToString() + "-" + item.Cells["CarPlatSeryal"].Value.ToString() + " طرحساب: " + item.Cells["GoodsAccountName"].Value.ToString();

                    var seerch = db.Transactions.Where(c => c.Description.Contains(txtDes)).Count();

                    if (seerch==0)
                    {
                        n++;
                    }

                }
                if (n==0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T124);
                    txtYear.Focus();
                    return;

                }
                if (MessageBox.Show(ResourceCode.T015+'\n'+"تعداد: " + n, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;


                foreach (GridEXRow item in dgvList.GetCheckedRows())
                {
                    string txtDes = "قسط ماه:" + cmbMont.Text + " سال: " + txtYear.Text + " به شماره تانکر "+item.Cells["TankerNo"].Value.ToString() + "  با شماره قرارداد " + item.Cells["ContactNo"].Value.ToString() + " با شماره پلاک :"+ item.Cells["CarPlat"].Value.ToString() + "-" + item.Cells["CarPlatSeryal"].Value.ToString() + " طرحساب: " + item.Cells["GoodsAccountName"].Value.ToString();

                    int Id = Convert.ToInt32(item.Cells["Id"].Value.ToString());
                    double RentAmount = Convert.ToDouble(item.Cells["RentAmount"].Value.ToString());

                    var seerch = db.Transactions.Where(c => c.Description.Contains(txtDes)).Count();


                    if (seerch==0)
                    {
                        var Spares = db.Spares.Where(c => c.Id==Id).First();
                        var car = db.Cars.Where(c => c.Id==Spares.CarId).First();
                        var draver = db.Dravers.Where(c => c.Id==car.DraverId).First();
                        var customer = db.Customers.Where(c => c.Id==draver.CustomerId).First();
                        {
                            Series++;
                            int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==10301).First().Id;
                            int DetailedAccountId = 0;
                            //حساب تفصیلی
                            int customertId = customer.Id;
                            var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                            if (serch1.Count()==0)
                                DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                            else
                                DetailedAccountId=serch1.First().Id;
                            PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 1, SpecificAccountId, DetailedAccountId, RentAmount, RentAmount, 0, 0, txtDes,"", Series, true);

                            Series++;
                            SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==60201).First().Id;
                            DetailedAccountId = 0;

                            //حساب تفصیلی
                            customertId = db.Customers.Where(c => c.SecretCode==8).First().Id;

                            var serch2 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                            if (serch2.Count()==0)
                                DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                            else
                                DetailedAccountId=serch2.First().Id;
                            PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 1, SpecificAccountId, DetailedAccountId, RentAmount, 0, RentAmount, 0, txtDes,"", Series, true);
                        }
                    }
                    db.SaveChanges();
                }

                PublicClass.WindowAlart("1");
                dgvList.UnCheckAllRecords();
            }
        }

        private void editBox1_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void frmTankerRental_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }
    }
}
