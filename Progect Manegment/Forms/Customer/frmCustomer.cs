using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.Banck;
using HM_ERP_System.Entity.Accounts.NatureAccount;
using HM_ERP_System.Entity.Gender;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Accounts.Banck;
using HM_ERP_System.Forms.BillLadingRequest;
using HM_ERP_System.Forms.Main_Form;
using HM_ERP_System.Forms.PersonGroup;
using HM_ERP_System.Forms.Reports;

using Janus.Windows.UI.Tab;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Reporting.WinForms;

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
using System.Windows.Controls;
using System.Windows.Forms;

//using Telerik.WinControls.Svg;

namespace HM_ERP_System.Forms.Customer
{
    public partial class frmCustomer : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int ListId_ = 0;
        int UserId_ = PublicClass.UserId;
        /// <summary>
        /// در خواست از فرمهای بیرونی
        /// </summary>
        public string RequestFromExternalForms = "";
        public frmCustomer(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            //chkControlCodeMeli.Checked=Properties.Settings.Default.CheackCodeMeli;
            chkControlCodeMeli.Checked=true;
            UpdateData();
        }

        private void CallUpdateTata()
        {

            FilldgvList();
            FillcmbTypeCustomer();
            FillcmbBanck();
            //FillBanckName();
            FillcmbCity();
            //FillcmbNatureAccounts();
            FillcmbGroup();
            if (RequestFromExternalForms=="frmCar")
            {
                cmbTypeCustomer.Value=2;
                cmbTypeCustomer.Enabled=false;
            }
        }
        public void UpdateData()
        {
            CallUpdateTata();

        }

        //private void FillcmbNatureAccounts()
        //{
        //    using (var db = new DBcontextModel())
        //    {
        //        var q = db.NatureAccounts.Where(c => c.Id<=2).ToList();
        //        cmbNatureAccounts.DataSource=q;
        //        cmbNatureAccounts.SelectedIndex=0;
        //    }
        //}

        DataTable dt_Banck;

        private void FillcmbBanck()
        {
            using (var db = new DBcontextModel())
            {
                var q = from bb in db.BankBranches
                        join ba in db.Bancks
                        on bb.BanckId equals ba.Id
                        select new
                        {
                            bb.Id,
                            bb.Name,
                            BanckName = ba.Name,
                        };
                cmbBanck.DataSource=q.ToList();
                dt_Banck = new System.Data.DataTable();
                dt_Banck = PublicClass.AddEntityTableToDataTable(q.ToList());
            }

        }



        DataTable dt_City;
        private void FillcmbCity()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from ct in db.Ciltys

                            join pr in db.Provinces
                            on ct.ProvincesId equals pr.Id
                            select new
                            {
                                ct.Id,
                                CiltyName = ct.Name,
                                ProvinceName = pr.Name,
                            };
                    cmbCity.DataSource = q.ToList();
                    cmbCity.DropDownList.AutoSizeColumns();
                    dt_City = new System.Data.DataTable();
                    dt_City = PublicClass.AddEntityTableToDataTable(q.ToList());

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void FillcmbTypeCustomer()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.TypeCustomers.Where(c => c.Id<=2).ToList();
                cmbTypeCustomer.DataSource = q;
                cmbTypeCustomer.Value = 1;
            }
        }

        private void FillcmbGroup()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.PersonGroups.ToList();
                cmbGroup.DropDownDataSource= q;
            }
        }

        private void FillBanckName()
        {
            //using (var db = new DBcontextModel())
            //{
            //    txtBanckName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    txtBanckName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    AutoCompleteStringCollection ac = new AutoCompleteStringCollection();

            //    var q = db.Customers.ToList();
            //    foreach (var c in q)
            //    {
            //        ac.Add(c.BanckName);
            //    }
            //    txtBanckName.AutoCompleteCustomSource = ac;
            //}
        }

        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = from cu in db.Customers

                        join tc in db.TypeCustomers
                        on cu.id_TypeCustomer equals tc.Id

                        join doc in db.DocumentBancks
                        on cu.Id equals doc.ListInFoemId into docGroup

                        join bb in db.BankBranches
                        on cu.BanckId equals bb.Id into bbGroup
                        from bb_ in bbGroup.DefaultIfEmpty()

                        join ba in db.Bancks
                        on bb_.BanckId equals ba.Id into baGroup
                        from ba_ in baGroup.DefaultIfEmpty()

                        join ct in db.Ciltys
                        on cu.CityId equals ct.Id into ctGroup
                        from ct_ in ctGroup.DefaultIfEmpty()

                        join pr in db.Provinces
                        on ct_.ProvincesId equals pr.Id into prGroup
                        from pr_ in prGroup.DefaultIfEmpty()

                        where cu.id_TypeCustomer <= 2

                        select new
                        {
                            cu.Id,
                            Name = cu.Name,
                            cu.Family,
                            TypeCustomerName = tc.Name,
                            cu.CodMeli,
                            cu.Tel,
                            cu.Tel2,
                            cu.Adders,
                            cu.Adders2,
                            cu.PostalCode,
                            BanckName = cu.BanckId == 0 || bb_ == null
                                        ? "-"
                                        : ba_.Name + "-" + bb_.Name,
                            cu.SeryalShaba,
                            cu.DabitCardNumber,
                            cu.Description,
                            CiltysName = ct_ != null ? ct_.Name : "-",
                            ProvincesName = pr_ != null ? pr_.Name : "-",
                            CountDoc = docGroup.Where(c => c.FormName == this.Name).Count(),//آمار تعداد مدارک پیوست

                        };
                dgvList.DataSource = q.ToList();
                PublicClass.SettingGridEX(dgvList);
            }
            /*
            using (var db = new DBcontextModel())
            {
                var q = from cu in db.Customers

                        join tc in db.TypeCustomers
                        on cu.id_TypeCustomer equals tc.Id

                        join doc in db.DocumentBancks
                        on cu.Id equals doc.ListInFoemId into docGroup

                        join bb in db.BankBranches 
                        on cu.BanckId equals bb.Id

                        join ba in db.Bancks
                        on bb.BanckId equals ba.Id

                        join ct in db.Ciltys
                        on cu.CityId equals ct.Id into ctGroup
                        from ct_ in ctGroup.DefaultIfEmpty()

                        join pr in db.Provinces
                        on ct_.ProvincesId equals pr.Id into prGroup
                        from pr_ in prGroup.DefaultIfEmpty()

                        where cu.id_TypeCustomer<=2

                        select new
                        {
                            cu.Id,
                            Name = cu.Name,
                            cu.Family,
                            TypeCustomerName = tc.Name,
                            cu.CodMeli,
                            cu.Tel,
                            cu.Tel2,
                            cu.Adders,
                            cu.Adders2,
                            cu.PostalCode,
                            BanckName = ba.Name +"-"+bb.Name,
                            cu.SeryalShaba,
                            cu.DabitCardNumber,
                            cu.Description,
                            CityName= ct_ !=null ? ct_.Name : "-",
                            ProvincesName= pr_ !=null ? pr_.Name : "-",
                            CountDoc = docGroup.Where(c => c.FormName==this.Name).Count(),//آمار تعداد مدارک پیوست
                        };
                dgvList.DataSource = q.ToList();
                PublicClass.SettingGridEX(dgvList);
            }        
            */
        }
        int TypeCustomerId = 0;
        private void cmbTypeCustomer_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TypeCustomerId = Convert.ToInt32(cmbTypeCustomer.Value);
                if (TypeCustomerId == 1)
                {
                    txtFamily.Enabled = true;
                    txtCodMeli.CheackCodeMeli = true;

                    lblCcodeMeli.Text = "کد ملی:";
                    lblName.Text="نام:";
                    lblFamily.Text="نام خانوادگی:";
                }
                else
                {
                    txtFamily.ResetText();
                    txtCodMeli.CheackCodeMeli = false;
                    txtFamily.Enabled = false;
                    lblCcodeMeli.Text = "شناسه ملی:";
                    lblName.Text="نام شرکت:";
                    lblFamily.ResetText();

                }
            }
            catch (Exception)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PublicClass.FindEmptyControls(cmbTypeCustomer, ResourceCode.T002, txtName, ResourceCode.T005, txtTel1, ResourceCode.T010))
                return;

            if (TypeCustomerId == 1)
            {
                if (PublicClass.FindEmptyControls(txtFamily, ResourceCode.T008, txtCodMeli, ResourceCode.T009))
                    return;
            }
            if (cmbCity.SelectedIndex == -1)
            {
                PublicClass.ErrorMesseg(ResourceCode.T014);
                return;
            }

            if (txtDabitCardNumber.Text!="" && txtDabitCardNumber.Text.Length!=16)
            {
                PublicClass.ErrorMesseg(ResourceCode.T034);
                return;
            }

            if (txtSeryalShaba.Text != "" && txtSeryalShaba.Text.Length != 24)
            {
                PublicClass.ErrorMesseg(ResourceCode.T035);
                return;
            }
            if (cmbGroup.Text == "")
            {
                PublicClass.ErrorMesseg(ResourceCode.T097);
                cmbGroup.Focus();
                return;
            }


            using (var db = new DBcontextModel())
            {

                if (ListId == 0)
                {
                    if (TypeCustomerId == 1)
                    {
                        int cont = db.Customers.Count(c => c.CodMeli == txtCodMeli.Text);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.

                                T011); return;
                        }
                    }
                    else
                    {
                        int cont = db.Customers.Count(c => c.Name == txtName.Text);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.

                                T011); return;
                        }

                    }
                }
                else
                {
                    if (TypeCustomerId == 1)
                    {
                        int cont = db.Customers.Count(c => c.CodMeli == txtCodMeli.Text && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.
                                T011); return;
                        }
                    }
                    else
                    {
                        int cont = db.Customers.Count(c => c.Name == txtName.Text && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.
                                T011); return;
                        }
                    }
                }
                if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

                var userRepo = new Repository<HM_ERP_System.Entity.Customer.Customer>(db);
                int CustomerId = userRepo.SaveOrUpdateRefId(new Entity.Customer.Customer { Id = ListId, Name = txtName.Text, Family = txtFamily.Text, CodMeli = txtCodMeli.Text, id_TypeCustomer = TypeCustomerId, CityId=CityId, Tel = txtTel1.Text, Tel2=txtTel2.Text, Adders = txtAdders1.Text, Adders2=txtAdders2.Text, PostalCode=txtPostalCode.Text, BanckId=BanckId, DabitCardNumber=txtDabitCardNumber.Text, SeryalShaba=txtSeryalShaba.Text, Description = txtDes.Text, UserId = UserId_, RecordDateTime = DateTime.Now }, ListId);
                if (ListId == 0)
                {
                    if (CustomerId > 0)
                    {
                        foreach (var GroupId in cmbGroup.CheckedValues)
                        {
                            int grId = Convert.ToInt32(GroupId);
                            var q = db.CustomerToGroups.Where(c => c.CustomerId==CustomerId && c.PersonGroupId==grId);

                            if (q.Count()==0)
                            {
                                var save = new Repository<Entity.CustomerToGroup.CustomerToGroup>(db);
                                save.SaveOrUpdate(new Entity.CustomerToGroup.CustomerToGroup { Id = ListId, CustomerId=CustomerId, PersonGroupId= grId }, ListId);
                            }
                            else
                            {
                                var delet = db.CustomerToGroups.Where(c => c.Id==q.FirstOrDefault().Id).First();
                                db.CustomerToGroups.Remove(delet);
                                db.SaveChanges();
                            }
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
            txtName.ResetText();
            txtFamily.ResetText();
            cmbGroup.ResetText();
            cmbCity.ResetText();

            txtCodMeli.ResetText();
            txtTel1.ResetText();
            txtAdders1.ResetText();
            txtTel2.ResetText();
            txtAdders2.ResetText();
            txtPostalCode.ResetText();
            cmbBanck.ResetText();
            txtSeryalShaba.ResetText();
            txtDabitCardNumber.ResetText();
            txtDes.ResetText();
            //txtAmount.Value=0;
            //FillBanckName();
            cmbGroup.Enabled=true;
            btnAddGroup.Enabled=true;

            ListId = 0;
            BanckId = 0;
            txtName.Focus();
        }

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId_ = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Details")
                {
                    cmsdgv.Show(Cursor.Position);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void chkControlCodeMeli_CheckedChanged(object sender, EventArgs e)
        {
            txtCodMeli.CheackCodeMeli=chkControlCodeMeli.Checked;
            Properties.Settings.Default.CheackCodeMeli=chkControlCodeMeli.Checked;
            Properties.Settings.Default.Save();
            if (chkControlCodeMeli.Checked)
            {
                btnCratMelyCode.Enabled=false;
            }
            else
            {
                btnCratMelyCode.Enabled=true;

            }
        }

        int NatureAccountsId = 0;

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            frmPersonGroup f = new frmPersonGroup(this);
            f.ShowDialog();
            FillcmbGroup();
        }

        private void frmCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }

        }

        private void btnAddCustomerByExcelFil_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = "";
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select File Excel";
                ofd.Filter = "Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
                ofd.FilterIndex = 1;
                if (ofd.ShowDialog() == DialogResult.OK)
                    FileName = ofd.FileName;
                DataTable dataTable = new DataTable();
                dataTable= PublicClass.InputExcelToDataDataGridView(FileName);
                int UserId = PublicClass.UserId;
                foreach (DataRow item in dataTable.Rows)
                {
                    using (var db = new DBcontextModel())
                    {
                        string name = item["id_TypeCustomer"].ToString();
                        string PersonGroupname = item["PersonGroupId"].ToString();

                        int id_TypeCustomer = db.TypeCustomers.Where(c => c.Name==name).First().Id;
                        int PersonGroupId = db.PersonGroups.Where(c => c.Name==PersonGroupname).First().Id;

                        string cName = item["Name"].ToString().Trim();
                        string cFamily = item["Family"].ToString().Trim();
                        string cCodMeli = item["CodMeli"].ToString().Trim();

                        var count = db.Customers.Where(c => c.Name==cName && c.Family==cFamily && c.CodMeli==cCodMeli).Count();
                        if (count==0)
                        {

                            //Customer ذخیره در جدول
                            var insert1 = new Repository<Entity.Customer.Customer>(db);
                            int CustomerId = insert1.SaveOrUpdateRefId(new Entity.Customer.Customer { Id = 0, Name=item["Name"].ToString(), Family=item["Family"].ToString(), CodMeli=item["CodMeli"].ToString(), id_TypeCustomer=id_TypeCustomer, Tel=item["Tel"].ToString()=="" ? "0" : item["Tel"].ToString(), Tel2=item["Tel2"].ToString(), Adders=item["Adders"].ToString(), Adders2=item["Adders2"].ToString(), PostalCode=item["PostalCode"].ToString(), Description= item["Description"].ToString(), BanckName= item["BanckName"].ToString(), SeryalShaba=item["SeryalShaba"].ToString(), DabitCardNumber=item["DabitCardNumber"].ToString(), UserId=UserId }, 0);

                            //CustomerToGroup ذخیره در جدول
                            var insert2 = new Repository<Entity.CustomerToGroup.CustomerToGroup>(db);
                            insert2.SaveOrUpdate(new Entity.CustomerToGroup.CustomerToGroup { Id = 0, PersonGroupId=PersonGroupId, CustomerId=CustomerId }, 0);
                        }
                    }
                }
                FilldgvList();
                PublicClass.WindowAlart("1");
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void cmsdgv_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            ListId=ListId_;
            switch (e.Command.Key)
            {
                case "Edit":
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Customers.Where(c => c.Id == ListId).First();
                        cmbTypeCustomer.Value = q.id_TypeCustomer;
                        txtName.Text = q.Name;
                        txtFamily.Text = q.Family;
                        txtCodMeli.Text = q.CodMeli;
                        txtTel1.Text = q.Tel;
                        txtAdders1.Text = q.Adders;
                        txtTel2.Text = q.Tel2;
                        txtAdders2.Text = q.Adders2;
                        txtPostalCode.Text = q.PostalCode;
                        cmbBanck.Value = q.BanckId;
                        txtSeryalShaba.Text = q.SeryalShaba;
                        txtDabitCardNumber.Text = q.DabitCardNumber;
                        txtDes.Text = q.Description;
                        cmbCity.Value=q.CityId;

                        var qg = db.CustomerToGroups.Where(c => c.CustomerId==ListId).ToList();
                        string txt = "";
                        foreach (var item in qg)
                        {
                            var s = db.PersonGroups.Where(c => c.Id==item.PersonGroupId).First();
                            txt+= s.Name+",";
                        }

                        cmbGroup.Text=txt.Remove(txt.Length-1);
                        cmbGroup.Enabled=false;
                        btnAddGroup.Enabled=false;
                        //txtAmount.Value=q.BeginningBanace;
                        //cmbNatureAccounts.SelectedIndex =(int)q.NatureAccountsId;



                    }
                    break;
                case "Delete":
                    if (!PublicClass.SetPeremission("d1", 1)) return;

                    using (var db = new DBcontextModel())
                    {
                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                        {
                            var q = db.Customers.Where(c => c.Id == ListId).First();
                            db.Customers.Remove(q);

                            var doc = db.DocumentBancks.Where(c => c.FormName==this.Name && c.ListInFoemId==ListId).ToList();
                            db.DocumentBancks.RemoveRange(doc);

                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
                            FilldgvList();
                            CelearItems();
                        }

                    }


                    break;
                case "AddDocumentToBanck"://ثبت مدارک
                    string lblCaption = "نام و نام خانوادگی: " + dgvList.GetRow().Cells["Name"].Value.ToString()+" "+ dgvList.GetRow().Cells["Family"].Value.ToString() + " کد ملی: " + dgvList.GetRow().Cells["CodMeli"].Value.ToString();

                    PublicClass.AddDocumentToBanck(this.Name, ListId, lblCaption);
                    FilldgvList();
                    ListId=0;
                    break;

            }
            //ListId=0;
        }

        int CityId = 0;
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
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCity, dt_City);
            }
        }

        private void cmbBanck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbBanck, dt_Banck);
            }

        }
        int BanckId = 0;
        private void cmbBanck_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BanckId = Convert.ToInt32(cmbBanck.Value);
            }
            catch (Exception)
            {
            }

        }

        private void btnAddBanck_Click(object sender, EventArgs e)
        {
            frmBankBranch frmBankBranch = new frmBankBranch(this);
            frmBankBranch.ShowDialog();
            FillcmbBanck();
        }

        private void btnCratMelyCode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            long tenDigitNumber = PublicClass.GenerateTenDigitRandomNumber(rand);
            txtCodMeli.Text=tenDigitNumber.ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //frmReport f = new frmReport();
            //f.Cod="1";
            //f.grid=dgvList;
            ////f.Condition="";
            //f.DateReport="گزارش از تاریخ: "+"1404/01/01"+"  تا تاریخ: "+"1404/05/25";
            //f.ShowDialog();

        }

        private void btnRepC1_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.Cod="1";
            f.grid=dgvList;
            //f.Condition="";
            f.DateReport="گزارش از تاریخ: "+"1404/01/01"+"  تا تاریخ: "+"1404/05/25";
            f.ShowDialog();

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            PdfReportHelper.ExportJanusGridToPDF(dgvList, "گزارش لیست مشتریان");
        //    SaveFileDialog sfd = new SaveFileDialog();
        //    sfd.Filter = "PDF File|*.pdf";
        //    sfd.FileName = "Report_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf";

            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        using (var db = new DBcontextModel())
            //        {
            //            var companyName = db.Settings.Where(c => c.Code==1).First().Subject;
            //            byte[] logo = db.ImageCos.Where(c => c.Id==1).First().Image;

            //            PdfReportHelper.ExportJanusGridToPDF(dgvList, sfd.FileName, "گزارش لیست مشتریان", companyName: companyName, logo,
            //isLandscape: false,   // 👈 ایستاده
            //leftMargin: 30f,
            //rightMargin: 30f,
            //topMargin: 15f,       // 👈 فاصله بالای کمتر
            //bottomMargin: 45f
            //                );
            //        }
            //    }
        }
    }
}
