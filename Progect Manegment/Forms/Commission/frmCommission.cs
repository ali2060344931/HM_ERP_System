using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Comers;
using HM_ERP_System.Entity.TruckUsageType;
using HM_ERP_System.Forms.BillLadingRequest;
using HM_ERP_System.Forms.Main_Form;

using Janus.Windows.GridEX;

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
            FilldgvList(dgvList,txtDateStart.Text, txtDateEnd.Text);

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
                            where !db.Commissions.Any(c => c.ComersBId == cm.Id && c.CustomerId == CustomerId)
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

        public static GridEX FilldgvList(Janus.Windows.GridEX.GridEX DG, string dateS, string dateE)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from co in db.Commissions
                            join cm in db.ComersBs
                            on co.ComersBId equals cm.Id
                            join pg in db.PersonGroups
                            on co.CommissionTypeId equals pg.Id
                            join cu in db.Customers
                            on co.CustomerId equals cu.Id

                            join tr in db.Transactions on co.TransactionId equals tr.Id into trj
                            from tr in trj.DefaultIfEmpty()

                            where string.Compare(co.Date, dateS) >= 0 && string.Compare(co.Date, dateE) <= 0

                            select new
                            {
                                co.Id,
                                co.Date,
                                co.Amount,
                                co.Des,
                                ComersB = cm.SeryalH,
                                CommissionType = pg.Name,
                                Customer = cu.Family +" "+cu.Name,
                                TransactionsSeryal = co.TransactionId==0 ? "" : tr.TransactionCode.ToString(),
                            };
                    DG.DataSource=q.ToList();
                    //PublicClass.SettingGridEX(dx);
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
                                cu.Id,
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
        int CustomerId = 0;
        private void cmbCustomer_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerId = Convert.ToInt32(cmbCustomer.Value);
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
                            int cont = db.Commissions.Count(c => c.ComersBId == Id && c.CustomerId == CustomerId);
                            if (cont > 0)
                            {
                                PublicClass.ErrorMesseg(ResourceCode.T060+'\n'+"سریال حواله: "+item["SeryalH"].ToString());
                                return;
                            }
                        }

                    }
                    else
                    {
                        int cont = db.Commissions.Count(c => c.ComersBId == ComersBId && c.CustomerId == CustomerId && c.Id != ListId);
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
                            int TransactionId = 0;long Amount = 0;
                            Amount =Convert.ToInt64(item["Amount"]);

                            //------------------ثبت سند حسابداری-----------------
                            if (chkRegAccount.Checked)//ثبت سند حسابداری
                            {
                                string TransactionCode = PublicClass.CreatTransactionCode();

                                Series++;
                                int SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod==30101).First().Id;//بستانکاران تجارى ،
                                int DetailedAccountId = 0;
                                int customertId = CustomerId;
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
                            car.SaveOrUpdate(new Entity.Commission.Commission { Id = ListId, ComersBId=Convert.ToInt32(item["Id"]), CommissionTypeId=CommissionTypeId, CustomerId=CustomerId, Date=txtDate.Text, Amount=Amount, TransactionId=TransactionId, Des=txtDes.Text, UserId = UserId_, RecordDateTime = DateTime.Now }, ListId);
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

        private void dgvList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                ListId_ = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Details")
                {
                    cmsdgv.Show(Cursor.Position);
                }
                return;

                ListId = Convert.ToInt32(dgvList.CurrentRow.Cells["Id"].Value);
                if (e.Column.Key == "Edit")
                {
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Commissions.Where(c => c.Id == ListId).First();
                        txtDate.Text = q.Date;
                        cmbComers1.Value=q.ComersBId;
                        cmbCommissionType.Value=q.CommissionTypeId;
                        cmbCustomer.Value=q.CustomerId;
                        txtAmount1.Text=q.Amount.ToString();
                        txtDes.Text=q.Des;
                        cmbComers1.Focus();
                    }

                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {

                        //if (db.ComersHs.Where(c => c.CarId == ListId).Count() != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.Commissions.Where(c => c.Id == ListId).First();
                            db.Commissions.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChanges();
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

            frmCommissionCreateFile f = new frmCommissionCreateFile();
            f.lblTitel.Text="لیست بارنامه های ثبت نشده برای "+cmbCustomer.Text;
            f.CustomerId=CustomerId;
            f.ShowDialog();
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
                            cmbCustomer.Value=q.CustomerId;
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
                                int customertId = q.CustomerId;
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
            }

        }
    }
}
