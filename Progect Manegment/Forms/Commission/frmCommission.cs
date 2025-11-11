using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Comers;
using HM_ERP_System.Entity.TruckUsageType;
using HM_ERP_System.Forms.Accounts.RecevingPayment;
using HM_ERP_System.Forms.BillLadingRequest;
using HM_ERP_System.Forms.Main_Form;

using Janus.Windows.GridEX;

using MyClass;

using NPOI.SS.Formula.PTG;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Commission
{
    /// <summary>
    /// فرم ثبت پورسانت ها
    /// </summary>
    public partial class frmCommission : frmAddItems, IUpdatableForms
    {
        private readonly IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int ListId_ = 0;

        int UserId_ = PublicClass.UserId;
        public frmCommission(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmCommission_Load(object sender, EventArgs e)
        {
            txtDate.Value= DateTime.Now;
            //chkSelectList.Checked= true;
            txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList*-1);
            txtDateEnd.Value = DateTime.Now;

            string layoutPathCommission = Path.Combine(System.Windows.Forms.Application.StartupPath, "DefaultGridLayoutCommission.xml");
            using (var fs = new FileStream(layoutPathCommission, FileMode.Create, FileAccess.Write))
            {
                dgvList.SaveLayoutFile(fs);
            }


            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("SeryalH", typeof(int));
            dt.Columns.Add("SeryalB", typeof(string));
            dt.Columns.Add("Amount", typeof(long));
            DataColumn productColumn = dt.Columns["Id"];//تعریف کلید اصلی
            dt.PrimaryKey = new DataColumn[] { productColumn };

            UpdateData();
        }

        public void UpdateData()
        {
            CallUpdateTata();
        }

        private void CallUpdateTata()
        {
            FilldgvList(dgvList, txtDateStart.Text, txtDateEnd.Text);

            FillcmbCommissionType();

        }

        DataTable dt_CommissionType;
        private void FillcmbCommissionType()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.PersonGroups.Where(c => c.IsCommission).ToList();
                    cmbCommissionType.DataSource=q;
                    dt_CommissionType = new System.Data.DataTable();
                    dt_CommissionType = PublicClass.AddEntityTableToDataTable(q.ToList());
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        DataTable dt_Comers;
        private void FillcmbComers()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from cm in db.ComersBs
                            
                            where !db.Commissions.Any(c => c.ComersBId == cm.Id && c.CommissionTypeId==CommissionTypeId)
                            select new
                            {
                                cm.Id,
                                ComersH = cm.SeryalH,
                                ComersB = cm.SeryalB,
                            };
                    cmbComers1.DataSource=q.ToList();
                    dt_Comers = new System.Data.DataTable();
                    dt_Comers = PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        public static GridEX FilldgvList(GridExEx.GridExEx DG, string dateS, string dateE)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from co in db.Commissions
                            
                            join cmb in db.ComersBs
                            on co.ComersBId equals cmb.Id
                            
                            join cmH in db.ComersHs
                            on cmb.ComersHId equals cmH.Id

                            join pg in db.PersonGroups
                            on co.CommissionTypeId equals pg.Id
                            
                            join ctg in db.CustomerToGroups
                            on co.CustomerToGroupsId equals ctg.Id
                            
                            join cu in db.Customers
                            on ctg.CustomerId equals cu.Id

                            join tr in db.Transactions on co.TransactionId equals tr.Id into trj
                            from tr in trj.DefaultIfEmpty()
                                //---------------

                            join cmh in db.ComersHs on cmb.ComersHId equals cmh.Id
                            join ct1 in db.Ciltys on cmh.LoadingOrinigId equals ct1.Id
                            join pt1 in db.PlaceTransfers on cmh.LoadingLocationId equals pt1.Id
                            join ct2 in db.Ciltys on cmh.UnLoadingOrinigId equals ct2.Id
                            join pt2 in db.PlaceTransfers on cmh.UnLoadingLocationId equals pt2.Id
                            join pr in db.Products on cmh.ProductsId equals pr.Id
                            join dr1 in db.Dravers on cmb.DaraverId1_ equals dr1.Id
                            join cu1 in db.Customers on dr1.CustomerId equals cu1.Id
                            join dr2 in db.Dravers on cmb.DaraverId2_ equals dr2.Id
                            join cu2 in db.Customers on dr2.CustomerId equals cu2.Id
                            join ca in db.Customers on cmb.CostAccountId equals ca.Id
                            join ga in db.Customers on cmb.GoodsAccountId equals ga.Id
                            join sd1 in db.Customers on cmb.SenderId equals sd1.Id
                            join rs1 in db.Customers on cmb.ResiverId equals rs1.Id

                            join rs2 in db.Customers on cmb.ResiverId2 equals rs2.Id into rs2Group
                            from rs2Left in rs2Group.DefaultIfEmpty()

                            join sd2 in db.Customers on cmb.SenderId2 equals sd2.Id into sd2Group
                            from sd2Left in sd2Group.DefaultIfEmpty()

                            join tcf in db.FareCalcMethods on cmb.TypeCalFareId equals tcf.Id
                            join mcf in db.TypeCalcMethods on cmb.MethodCalFareId equals mcf.Id
                            join pm2 in db.PaymentMethods on cmb.BillLadingCastId equals pm2.Id
                            join tcm2 in db.TypeCalcMethods on cmb.BillLadingMethodId equals tcm2.Id

                            join sh in db.Customers on cmh.ShiperId equals sh.Id into shGroup
                            from shLeft in shGroup.DefaultIfEmpty()

                                // 🔸 اصلاح کامل بخش PaymentToOthers
                            join ptonDA in db.DetailedAccounts
                            on cmb.PaymentToOthersId equals ptonDA.Id into ptonDAGroup
                            from ptonDA_Left in ptonDAGroup.DefaultIfEmpty()

                            join ptonC in db.Customers
                            on ptonDA_Left.CustomerId equals ptonC.Id into ptonCGroup
                            from ptonC_Left in ptonCGroup.DefaultIfEmpty()

                            join cr in db.Cars on cmh.CarId equals cr.Id
                            join tf in db.TransactionFees on cmb.BT equals tf.Id
                            //---------------


                            where string.Compare(co.Date, dateS) >= 0 && string.Compare(co.Date, dateE) <= 0

                            select new
                            {
                                co.Id,
                                co.Date,
                                co.Amount,
                                co.Des,
                                ComersB = cmb.SeryalH,
                                CommissionType = pg.Name,
                                Customer = cu.Family +" "+cu.Name,
                                TransactionsSeryal = co.TransactionId==0 ? "" : tr.TransactionCode.ToString(),
                                cmb.DateB,
                                cmb.SeryalB,
                                LoadingOrinigName = ct1.Name,
                                LoadingLocationName = pt1.Name,
                                UnLoadingOrinigName = ct2.Name,
                                ProductsName = pr.Name,
                                UnLoadingLocationName = pt2.Name,
                                CostAccountName = (ca.Family + " " + ca.Name).Trim(),
                                GoodsAccountName = (ga.Family + " " + ga.Name).Trim(),
                                ShiperName = shLeft != null ? (shLeft.Family + " " + shLeft.Name).Trim() : "-",
                                CarPlat = cr.CarPlat + "-" + cr.CarPlatSeryal,
                                DaraverName = cu1.Family + " " + cu1.Name,
                                DaraverTel = cu1.Tel,
                                DaraverName2 = cu2.Family + " " + cu2.Name,
                                DaraverTel2 = cu2.Tel,
                                SenderName = sd1.Family + " " + sd1.Name,
                                ResiverName = rs1.Family + " " + rs1.Name,
                                SenderName2 = sd2Left != null ? (sd2Left.Family + " " + sd2Left.Name).Trim() : "-",
                                ResiverName2 = rs2Left != null ? (rs2Left.Family + " " + rs2Left.Name).Trim() : "-",
                                cmb.Bn,

                            };
                    DG.DataSource=q.ToList();
                    PublicClass.SettingGridEX(DG);
                    return DG;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

        int ComersBId = 0;
        private void cmbComers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ComersBId = Convert.ToInt32(cmbComers1.Value);
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void cmbComers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbComers1, dt_Comers);
            }
        }
        int CommissionTypeId = 0;
        private void cmbCommissionType_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CommissionTypeId = Convert.ToInt32(cmbCommissionType.Value);
                cmbCustomer.ResetText();
                FillcmbCustomer();
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        DataTable dt_Customer;

        private void FillcmbCustomer()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from ctg in db.CustomerToGroups

                            join cu in db.Customers
                            on ctg.CustomerId equals cu.Id

                            join pg in db.PersonGroups
                            on ctg.PersonGroupId equals pg.Id

                            where pg.Id==CommissionTypeId
                            select new
                            {
                                ctg.Id,
                                Name = cu.Family +" "+ cu.Name,
                            };
                    cmbCustomer.DataSource = q.ToList();
                    dt_Customer = new System.Data.DataTable();
                    dt_Customer = PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void cmbCommissionType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbCommissionType, dt_CommissionType);
            }
        }
        int CustomerToGroupId = 0;
        private void cmbCustomer_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerToGroupId = Convert.ToInt32(cmbCustomer.Value);
                cmbComers1.ResetText();
                txtAmount1.ResetText();
                dt.Clear();
                FillcmbComers();
            }
            catch (Exception)
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new DBcontextModel())
                {

                    if (cmbCommissionType.SelectedIndex==-1)//نوع پورسانت
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T153);
                        cmbCommissionType.Focus();
                        return;
                    }
                    if (cmbCustomer.SelectedIndex==-1)//طرف حساب
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T042);
                        cmbCustomer.Focus();
                        return;
                    }
                    if (txtDes.Text=="")//توضیحات
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T143);
                        txtDes.Focus();
                        return;
                    }

                    if (dgvList1.RowCount==0 || dt.Rows.Count==0)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T041);
                        return;
                    }

                    if (ListId == 0)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            int Id = Convert.ToInt32(item["Id"]);
                            int cont = db.Commissions.Count(c => c.ComersBId == Id && c.CustomerToGroupsId == CustomerToGroupId);
                            if (cont > 0)
                            {
                                PublicClass.ErrorMesseg(ResourceCode.T060+'\n'+"سریال حواله: "+item["SeryalH"].ToString());
                                return;
                            }
                        }

                    }
                    else
                    {
                        int cont = db.Commissions.Count(c => c.ComersBId == ComersBId && c.CustomerToGroupsId == CustomerToGroupId && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T060); return;
                        }
                    }

                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    string TransactionDate = PersianDate.NowPersianDate;


                    int Series = 0;
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            int TransactionId = 0; long Amount = 0;
                            Amount =Convert.ToInt64(item["Amount"]);

                            //------------------ثبت سند حسابداری-----------------
                            if (chkRegAccount.Checked)//ثبت سند حسابداری
                            {



                                    string TransactionCode = PublicClass.CreatTransactionCode();
                                    Series++;
                                    int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==30101).First().Id;//بستانکاران تجارى ،
                                    int DetailedAccountId = 0;
                                    int customertId = db.CustomerToGroups.Where(c=>c.Id==CustomerToGroupId).First().CustomerId;
                                    var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                                    if (serch1.Count()==0)
                                        DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                    else
                                        DetailedAccountId=serch1.First().Id;
                                    TransactionId= PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, 2, SpecificAccountId, DetailedAccountId, Amount, 0, Amount, 0, txtDes.Text, Series, false);


                                    Series++;
                                    //حساب معین
                                    SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==80801).First().Id;//هزینه حمل کالا
                                    customertId = db.Customers.Where(c => c.SecretCode==11).First().Id;
                                    serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                                    if (serch1.Count()==0)
                                        DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                    else
                                        DetailedAccountId=serch1.First().Id;
                                    PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, 2, SpecificAccountId, DetailedAccountId, Amount, Amount, 0, 0, "بابت پورسانت", "", Series, true);
                            }

                            //------------------ثبت سند پورسنات-----------------
                            var car = new Repository<Entity.Commission.Commission>(db);
                            car.SaveOrUpdate(new Entity.Commission.Commission { Id = ListId, ComersBId=Convert.ToInt32(item["Id"]), CommissionTypeId=CommissionTypeId, CustomerToGroupsId=CustomerToGroupId, Date=txtDate.Text, Amount=Amount, TransactionId=TransactionId, Des=txtDes.Text, UserId = UserId_, RecordDateTime = DateTime.Now }, ListId);
                        }
                    }

                    PublicClass.WindowAlart("1");
                    if (_updatableForms!=null)
                        _updatableForms.UpdateData();
                    CelearItems();

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnAddTolist_Click(object sender, EventArgs e)
        {
            if (PublicClass.FindEmptyControls(txtAmount1, ResourceCode.T081))
                return;

            if (cmbComers1.SelectedIndex==-1)//بارنامه:تکی
            {
                PublicClass.ErrorMesseg(ResourceCode.T036);
                cmbComers1.Focus();
                return;
            }
            DataRow existingRow = dt.Rows.Find(ComersBId);
            if (existingRow == null)
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.ComersBs.Where(c => c.Id==ComersBId).First();
                    DataRow newRow = dt.NewRow();
                    newRow["Id"] =ComersBId;
                    newRow["SeryalH"] = q.SeryalH;
                    newRow["SeryalB"] = q.SeryalB;
                    long amount = Convert.ToInt64(txtAmount1.TextSimple);
                    newRow["Amount"] =amount;
                    dt.Rows.Add(newRow);
                    dgvList1.DataSource = dt;

                    txtAmount1.ResetText();
                    //cmbCustomer.ResetText();
                    cmbComers1.ResetText();
                    cmbComers1.Focus();
                }
            }
            else
            {
                PublicClass.StopMesseg(ResourceCode.T154);
                return;
            }
        }

        private void CelearItems()
        {
            ListId_ = 0;
            ListId = 0;
            txtAmount1.ResetText();
            txtDes.ResetText();
            cmbCommissionType.ResetText();
            cmbCustomer.ResetText();
            cmbComers1.Focus();
            dt.Clear();
            FilldgvList(dgvList, txtDateStart.Text, txtDateEnd.Text);
        }

        string DocTitel = "";
        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId_ = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                DocTitel="نــوع پورسانت: "+dgvList.CurrentRow.Cells["CommissionType"].Value.ToString()+"  مشتـــری: "+dgvList.CurrentRow.Cells["Customer"].Value.ToString();
                if (e.Column.Key == "Details")
                {
                    cmsdgv.Show(Cursor.Position);
                }
                return;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }

        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            FilldgvList(dgvList, txtDateStart.Text, txtDateEnd.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void chkSelectList_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkSelectList.Checked)
            //{
            //    cmbComers.Enabled=false;
            //    btnShowComers.Enabled=false;
            //    cmbList.Enabled=true;
            //    btnSelectList.Enabled=true;
            //}
            //else
            //{
            //    cmbComers.Enabled=true;
            //    btnShowComers.Enabled=true;
            //    cmbList.Enabled=false;
            //    btnSelectList.Enabled=false;
            //}
        }
        DataTable dt = new DataTable();
        private void btnSelectList_Click(object sender, EventArgs e)
        {
            try
            {

                string FileName = "";
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select File Excel";
                ofd.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                ofd.FilterIndex = 1;
                if (ofd.ShowDialog() == DialogResult.OK)
                    FileName = ofd.FileName;


                //dt.Columns.Add("Id", typeof(int));
                //dt.Columns.Add("SeryalH", typeof(int));
                //dt.Columns.Add("SeryalB", typeof(string));
                //dt.Columns.Add("Amount", typeof(long));

                DataTable dataTable = new DataTable();
                dataTable= PublicClass.ReadExcel_NPOI(FileName);
                int Id = 0;
                int UserId = PublicClass.UserId;
                int i = 0;
                foreach (DataRow item in dataTable.Rows)
                {
                    var Amount = item["AmountCommission"]?.ToString()?.Trim();

                    //DataRow existingRow = dt.Rows.Find(ComersBId);

                    //if (existingRow == null)
                    {
                        if (!string.IsNullOrEmpty(Amount))
                        {
                            using (var db = new DBcontextModel())
                            {
                                Id=Convert.ToInt32(item["Id"]);
                                var q = db.ComersBs.Where(c => c.Id==Id).First();
                                DataRow newRow = dt.NewRow();
                                // فرض کنیم ستون‌های Excel همین نام‌ها را دارند
                                newRow["Id"] = Convert.ToInt32(item["Id"]);
                                newRow["SeryalH"] = q.SeryalH;
                                newRow["SeryalB"] = q.SeryalB;
                                long amount = Convert.ToInt64(item["AmountCommission"]);
                                newRow["Amount"] =amount;
                                if (amount > 0)
                                {
                                    dt.Rows.Add(newRow);
                                }
                            }
                        }
                    }
                    //else
                    //{
                    //    i++;
                    //}
                }
                //if (i!=0)
                //{
                //    PublicClass.StopMesseg("تعداد بارنامه ای تکراری در لیست: "+i.ToString());
                //}


                dgvList1.DataSource = dt;
                PublicClass.WindowAlart("1", "اطلاعات مورد نظر با موفقیت در جدول قرار گرفتند");
            }
            catch (Exception er)
            {
                if (er.Message.Contains("being used by another process"))
                {
                    PublicClass.WindowAlart("2", "فایل در حال استفاده است، لطفاً فایل اکسل را ببندید و دوباره تلاش کنید.");
                }
                else
                {
                    PublicClass.ShowErrorMessage(er);
                }
            }
        }

        private void btnCreatFile_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex==-1)
            {
                PublicClass.StopMesseg(ResourceCode.T042); return;
            }
                        using (var db = new DBcontextModel())
            {

            

            frmCommissionCreateFile f = new frmCommissionCreateFile();
            f.lblTitel.Text="لیست بارنامه های ثبت نشده برای "+cmbCustomer.Text;
            f.PersonGroupsId=CommissionTypeId;
            f.ShowDialog();
            }
        }

        private void ribbonContextMenu1_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            switch (e.Command.Key)
            {
                case "Edit":
                    using (var db = new DBcontextModel())
                    {
                        ListId=ListId_;
                        var q0 = db.Commissions.Where(c => c.Id==ListId).First();
                        if (q0.TransactionId==0)

                        {
                            var q = db.Commissions.Where(c => c.Id == ListId).First();
                            txtDate.Text = q.Date;
                            cmbComers1.Value=q.ComersBId;
                            cmbCommissionType.Value=q.CommissionTypeId;
                            cmbCustomer.Value=q.CustomerToGroupsId;
                            txtAmount1.Text=q.Amount.ToString();
                            txtDes.Text=q.Des;
                            cmbComers1.Focus();
                        }
                        else
                        {
                            PublicClass.StopMesseg(ResourceCode.T115); return;
                        }
                    }
                    break;

                case "Delete":
                    using (var db = new DBcontextModel())
                    {
                        ListId=ListId_;
                        var q0 = db.Commissions.Where(c => c.Id==ListId).First();
                        if (q0.TransactionId==0)
                        {
                            if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                var q = db.Commissions.Where(c => c.Id == ListId).First();
                                db.Commissions.Remove(q);
                                PublicClass.WindowAlart("2");
                                db.SaveChanges();
                                FilldgvList(dgvList, txtDateStart.Text, txtDateEnd.Text);
                                CelearItems();
                            }
                            ListId=0;
                        }
                        else
                        {
                            PublicClass.StopMesseg(ResourceCode.T155); return;
                        }
                    }

                    break;
                case "AddDocumentToBanck"://ثبت مدارک
                    ListId=ListId_;
                    string lblCaption = "شماره حواله:" + dgvList.GetRow().Cells["ComersB"].Value.ToString();

                    PublicClass.AddDocumentToBanck(this.Name, ListId, lblCaption);
                    FilldgvList(dgvList, txtDateStart.Text, txtDateEnd.Text);
                    ListId=0;
                    break;
                case "AddTransectionDocument"://ثبت سند حسابداری
                    ListId=ListId_;
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Commissions.Where(c => c.Id==ListId).First();
                        if (q.TransactionId==0)
                        {

                            string TransactionCode = PublicClass.CreatTransactionCode();
                            string TransactionDate = PersianDate.NowPersianDate;
                            long Amount = q.Amount;

                            int TransactionId = 0;
                            int Series = 0;

                            if (MessageBox.Show(ResourceCode.T111, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                return;

                            //------------------ثبت سند حسابداری-----------------
                            //if (chkRegAccount.Checked)//ثبت سند حسابداری
                            {
                                Series++;
                                int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==30101).First().Id;//بستانکاران تجارى ،
                                int DetailedAccountId = 0;
                                int customertId =db.CustomerToGroups.Where(c=>c.Id==CustomerToGroupId).First().CustomerId;
                                var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                                if (serch1.Count()==0)
                                    DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId=serch1.First().Id;
                                TransactionId= PublicClass.AccountingDocumentRegistrationById(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, 2, SpecificAccountId, DetailedAccountId, Amount, 0, Amount, 0, txtDes.Text, Series, false);


                                Series++;
                                //حساب معین
                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==80801).First().Id;//هزینه حمل کالا
                                customertId = db.Customers.Where(c => c.SecretCode==11).First().Id;
                                serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId==SpecificAccountId && c.CustomerId==customertId);
                                if (serch1.Count()==0)
                                    DetailedAccountId=PublicClass.AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId=serch1.First().Id;
                                PublicClass.AccountingDocumentRegistration(db, 0, Convert.ToInt32(TransactionCode), TransactionDate, 2, SpecificAccountId, DetailedAccountId, Amount, Amount, 0, 0, "بابت پورسانت", "", Series, true);

                                q.TransactionId=TransactionId;
                                db.SaveChanges();

                            }

                            PublicClass.WindowAlart("1");
                            if (_updatableForms!=null)
                                _updatableForms.UpdateData();
                            CelearItems();
                        }
                        else
                        {
                            PublicClass.StopMesseg(ResourceCode.T110); return;
                        }
                    }
                    break;
                case "detailsComersHB"://نمایش جزئیات حواله و بارنامه
                    using (var db = new DBcontextModel())
                    {
                        ListId=ListId_;
                        frmRecevingPaymentDoc f = new frmRecevingPaymentDoc();
                        f.DocTitel=DocTitel;
                        var q = db.Commissions.Where(c => c.Id==ListId).First();
                        var idh = db.ComersBs.Where(c => c.Id==q.ComersBId).First().ComersHId;
                        f.IdH=idh;
                        f.ShowDialog();
                    }
                    break;

            }

        }

        private void txtAmount1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            PublicClass.SaveGridExToExcel(dgvList);
        }
    }
}
