using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.Cheque;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Accounts.Banck;
using HM_ERP_System.Forms.Accounts.RecevingPayment;
using HM_ERP_System.Forms.BillLadingRequest;
using HM_ERP_System.Forms.Main_Form;

using Janus.Windows.GridEX;

using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

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
using System.Xml.Linq;

using Telegram.Bot.Types;

namespace HM_ERP_System.Forms.Accounts.Cheque
{
    public partial class frmCheque : frmAddItems, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        public int ListId = 0;
        public int ListId_ = 0;
        public string IsReqoestExitForm = "";
        public int AccountId = 0;
        public int AccountCode = 0;
        public string AccountName = "";
        bool FilterByChequeType = false;
        public frmCheque(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;
        }

        private void frmCheque_Load(object sender, EventArgs e)
        {
            txtDueDate.Value= DateTime.Now;
            txtIssueDate.Value= DateTime.Now;
            PublicClass.SettingGridEX(dgvList);
            PublicClass.SettingGridEX(dgvListChequeStatus);

            if (IsReqoestExitForm=="frmRecevingPayment")
            {
                btnSelectCheque.Visible=true;
                dgvList.RootTable.Columns["SelectItems"].Visible=true;
                cmbChequeType.Enabled=false;
                FilterByChequeType=true;
            }
            else
            {
                btnSelectCheque.Visible=false;
                dgvList.RootTable.Columns["SelectItems"].Visible=false;
                cmbChequeType.Enabled=true;
            }
            UpdateData();

        }
        public void UpdateData()
        {
            FillcmbBanck();
            fillcmbChequeType();
            FilltxtBankName();
            FilltxtChequeOwner();
            FilltxtDescription();
            FillcmbPayer_Payee_Acc();
            FilldgvList();

        }
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
        DataTable dt_Payer_Payee_Acc;
        private void FillcmbPayer_Payee_Acc()
        {
            using (var db = new DBcontextModel())
            {
                //var q=db.Customers.Where(c=>c.id_TypeCustomer==1 ||  c.id_TypeCustomer==2).OrderBy(c=>c.Family).ToList();
                var q = from cu in db.Customers
                        where cu.id_TypeCustomer==1 ||  cu.id_TypeCustomer==2
                        orderby cu.Name, cu.Family
                        select new
                        {
                            cu.Id,
                            Name = cu.Family +" "+cu.Name,
                            cu.Tel,
                        };


                cmbPayer_Payee_Acc.DataSource=q.ToList();
                dt_Payer_Payee_Acc = new System.Data.DataTable();
                dt_Payer_Payee_Acc = PublicClass.AddEntityTableToDataTable(q.ToList());

            }
        }

        void FilltxtBankName()
        {
            //ToDo AutoCompleteMode TextBox
            /*
            using (var db = new DBcontextModel())
            {
                txtBankName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtBankName.AutoCompleteSource=AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                var q = db.Cheques.ToList();
                foreach (var i in q)
                {
                    a.Add(i.BankName);
                }
                txtBankName.AutoCompleteCustomSource=a;
            }
            */
        }
        void FilltxtChequeOwner()
        {
            //ToDo AutoCompleteMode TextBox
            using (var db = new DBcontextModel())
            {
                txtChequeOwner.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtChequeOwner.AutoCompleteSource=AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                var q = db.Cheques.ToList();
                foreach (var i in q)
                {
                    a.Add(i.ChequeOwner);
                }
                txtChequeOwner.AutoCompleteCustomSource=a;
            }
        }
        void FilltxtDescription()
        {
            //ToDo AutoCompleteMode TextBox
            using (var db = new DBcontextModel())
            {
                txtDescription.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtDescription.AutoCompleteSource=AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                var q = db.Cheques.ToList();
                foreach (var i in q)
                {
                    a.Add(i.Description);
                }
                txtDescription.AutoCompleteCustomSource=a;
            }
        }

        private void fillcmbChequeType()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.ChequeTypes.ToList();
                cmbChequeType.DataSource=q;
            }
        }
        int ChequeTypeId = 0;
        private void cmbChequeType_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ChequeTypeId = Convert.ToInt32(cmbChequeType.Value);
            }
            catch (Exception)
            {
            }

        }
        int Payer_Payee_AccId = 0;
        private void cmbPayer_Payee_Acc_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Payer_Payee_AccId = Convert.ToInt32(cmbPayer_Payee_Acc.Value);
            }
            catch (Exception)
            {
            }
            txtChequeOwner.Text=cmbPayer_Payee_Acc.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbChequeType, "نوع چک زا وارد نمائید", txtChequeNumber, "سریال چک را وارد نمائید", txtAmount, "مبلغ زا وارد نمائید", cmbBanck, "نام بانک را وارد نمائید", cmbPayer_Payee_Acc, "طرف حساب را انتخاب نمائید", txtChequeOwner, "نام صاحب چک زا وارد نمائید", txtDescription, "توضیحات را وارد نمائید"))
                    return;



                using (var db = new DBcontextModel())
                {

                    if (ListId == 0)
                    {
                        int cont = db.Cheques.Count(c => c.ChequeNumber == txtChequeNumber.Text && c.DueDate == txtDueDate.Text);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T119); return;
                        }
                    }
                    else
                    {
                        int cont = db.Cheques.Count(c => c.ChequeNumber == txtChequeNumber.Text && c.DueDate == txtDueDate.Text && c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T119); return;
                        }
                    }

                    if (MessageBox.Show(ResourceCode.T111, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    int CurrentStatusID_ = 0;
                    if (ListId!=0)
                    {
                        CurrentStatusID_=db.Cheques.Where(c => c.Id== ListId).First().CurrentStatusID;
                    }

                    var userRepo = new Repository<Entity.Accounts.Cheque.Cheque>(db);
                    int ChequeId = userRepo.SaveOrUpdateRefId(new Entity.Accounts.Cheque.Cheque { Id = ListId, ChequeTypeId=ChequeTypeId, ChequeNumber=txtChequeNumber.Text, Amount=Convert.ToDouble(txtAmount.TextSimple), DueDate=txtDueDate.Text, IssueDate=txtIssueDate.Text, BankId=BanckId, Payer_Payee_AccId=Payer_Payee_AccId, ChequeOwner=txtChequeOwner.Text, Description=txtDescription.Text, CurrentStatusID=ListId==0 ? 0 : CurrentStatusID_ }, ListId);
                    {
                        if (ListId == 0)
                        {
                            var cs = new Repository<ChequeStatus>(db);
                            int ChequeStatusId = cs.SaveOrUpdateRefId(new ChequeStatus { Id = ListId, ChequeId=ChequeId, StatusCodeId=6, Description=txtDescription.Text, StatusDate=PersianDate.NowPersianDate, DateTime=DateTime.Now, UserId=PublicClass.UserId }, ListId);
                            var CurrentStatusID = db.Cheques.Where(c => c.Id==ChequeId).First();
                            CurrentStatusID.CurrentStatusID=ChequeStatusId;
                            db.SaveChanges();
                        }

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
            txtChequeNumber.ResetText();
            txtAmount.ResetText();
            txtDueDate.ResetText();
            txtIssueDate.ResetText();
            cmbBanck.ResetText();
            txtChequeOwner.ResetText();
            txtDescription.ResetText(); cmbPayer_Payee_Acc.SelectedIndex=-1;
            ListId=0;
            cmbChequeType.Focus();
            FilltxtBankName();
            FilltxtChequeOwner();
            FilltxtDescription();
            FilldgvList();
        }

        private void FilldgvList()
        {


            using (var db = new DBcontextModel())
            {
                var q = from ch in db.Cheques

                        join cty in db.ChequeTypes
                        on ch.ChequeTypeId equals cty.Id

                        join dta in db.DetailedAccounts
                        on ch.Payer_Payee_AccId equals dta.Id

                        join cu in db.Customers
                        on dta.CustomerId equals cu.Id

                        join bb in db.BankBranches
                        on ch.BankId equals bb.Id

                        join ba in db.Bancks
                        on bb.BanckId equals ba.Id

                        join chs in db.ChequeStatuses
                        on ch.CurrentStatusID equals chs.Id into chsGroup
                        from chsLeft in chsGroup.DefaultIfEmpty()

                        join chst in db.ChequeStatusTypes
                        on chsLeft.StatusCodeId equals chst.Id /*into chstGroup*/
                        //from chstLeft in chsGroup.DefaultIfEmpty()

                        where !FilterByChequeType || (ch.ChequeTypeId == ChequeTypeId && chsLeft.StatusCodeId==6)

                        select new
                        {
                            ch.Id,
                            ChequeType = cty.Name,
                            ch.ChequeNumber,
                            ch.Amount,
                            ch.DueDate,
                            ch.IssueDate,
                            banckName = ba.Name +" - "+ bb.Name,
                            ch.ChequeOwner,
                            ch.Description,
                            Payer_Payee_Acc = cu.Family +" "+cu.Name,
                            ChequeStatusTypes = chst.Name,
                        };
                dgvList.DataSource = q.ToList();
                dgvList.AutoSizeColumns();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void cmsdgv_CommandClick(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            //ListId=ListId_;

            switch (e.Command.Key)
            {

                case "Edit":
                    using (var db = new DBcontextModel())
                    {
                        ListId=ListId_;
                        var q = db.Cheques.Where(c => c.Id == ListId).First();
                        cmbChequeType.Value=q.ChequeTypeId;
                        txtChequeNumber.Text=q.ChequeNumber;
                        txtAmount.Text=q.Amount.ToString();
                        txtDueDate.Text=q.DueDate;
                        txtIssueDate.Text=q.IssueDate;
                        //txtBankName.Text=q.BankName;
                        txtChequeOwner.Text=q.ChequeOwner;
                        txtDescription.Text=q.Description;
                        cmbPayer_Payee_Acc.Value=q.Payer_Payee_AccId;
                    }
                    break;

                case "Delete":
                    using (var db = new DBcontextModel())
                    {
                        ListId=ListId_;

                        //if (db.ComersHs.Where(c => c.CarId == ListId).Count() != 0)
                        //{
                        //    PublicClass.ErrorMesseg(ResourceCode.T004);
                        //    return;
                        //}

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var q = db.Cheques.Where(c => c.Id == ListId).First();
                            db.Cheques.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChanges();

                            CelearItems();
                        }
                        ListId=0;
                    }
                    break;
                case "AddDocumentToBanck"://ثبت مدارک
                    ListId=ListId_;
                    string lblCaption = "شماره چک:" + dgvList.GetRow().Cells["ChequeNumber"].Value.ToString();

                    PublicClass.AddDocumentToBanck(this.Name, ListId, lblCaption);
                    FilldgvList();
                    ListId=0;
                    break;

                case "ListChequeStatus"://لیست وضعیت چک ها
                    using (var db = new DBcontextModel())
                    {
                        var ql = db.ChequeStatuses.Where(c => c.ChequeId==ListId);
                        if (ql.Count()!=0)
                        {
                            pnlListChequeStatus.Visible=true;
                            dgvListChequeStatus.RootTable.Caption= "شماره سریال چک:" + dgvList.GetRow().Cells["ChequeNumber"].Value.ToString();

                            var List = (from chs in db.ChequeStatuses

                                        join ChST in db.ChequeStatusTypes
                                        on chs.StatusCodeId equals ChST.Id

                                        join da in db.DetailedAccounts
                                        on chs.NewLocationAccId equals da.Id into dagroup
                                        from daLeft in dagroup.DefaultIfEmpty()

                                        join cu in db.Customers
                                        on daLeft.CustomerId equals cu.Id into Cugroup
                                        from cuLeft in Cugroup.DefaultIfEmpty()


                                        join tr in db.Transactions
                                        on chs.TransactionId equals tr.Id into trGroup
                                        from trLeft in trGroup.DefaultIfEmpty()

                                        where chs.ChequeId==ListId

                                        select new
                                        {
                                            chs.Id,
                                            chs.StatusDate,
                                            ChequeStatusTypes = ChST.Name,
                                            NewLocationAcc = cuLeft!=null ? (cuLeft.Family + " " + cuLeft.Name).Trim() : "-",
                                            TransactionCode = trLeft!=null ? trLeft.TransactionCode : 0,
                                            chs.Description,

                                        }).ToList();
                            dgvListChequeStatus.DataSource=List;
                            dgvListChequeStatus.AutoSizeColumns();



                        }
                        else
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T120); return;
                        }
                        ListId=0;
                    }
                    break;


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

        private void dgvList_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void btnClosePael_Click(object sender, EventArgs e)
        {
            pnlListChequeStatus.Visible=false;
        }
        public DataTable dt_Cheque;

        private void btnSelectCheque_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.GetCheckedRows().Count()==0)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T041); return;
                }

                dt_Cheque=new DataTable();
                //dt_Cheque.Columns.Add("id", typeof(int));
                //dt_Cheque.Columns.Add("Code", typeof(int));
                //dt_Cheque.Columns.Add("Name", typeof(string));
                dt_Cheque.Columns.Add("Cheaueid", typeof(int));
                dt_Cheque.Columns.Add("ChequeNumber", typeof(string));
                dt_Cheque.Columns.Add("DueDate", typeof(string));
                dt_Cheque.Columns.Add("Amount", typeof(double));
                dt_Cheque.Columns.Add("Description", typeof(string));

                DataRow newrow;

                foreach (GridEXRow item in dgvList.GetCheckedRows())
                {
                    newrow = dt_Cheque.NewRow();
                    //newrow["id"]=AccountId;
                    //newrow["Code"]=AccountCode;
                    //newrow["Name"]=AccountName;
                    newrow["Cheaueid"]=item.Cells["Id"].Value;
                    newrow["ChequeNumber"]=item.Cells["ChequeNumber"].Value;
                    newrow["DueDate"]=item.Cells["DueDate"].Value;
                    newrow["Amount"]=item.Cells["Amount"].Value;
                    newrow["Description"]=item.Cells["Description"].Value;
                    dt_Cheque.Rows.Add(newrow);
                }
                frmRecevingPayment f = Application.OpenForms["frmRecevingPayment"] as frmRecevingPayment;
                f.dt_Cheque=dt_Cheque;
                this.Close();
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
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

        private void cmbBanck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbBanck, dt_Banck);
            }

        }

        private void cmbPayer_Payee_Acc_KeyDown(object sender, KeyEventArgs e)
        {
                        if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

            if (e.KeyCode == Keys.F2)
            {
                PublicClass.SearchCmbId(cmbPayer_Payee_Acc, dt_Payer_Payee_Acc);
            }

        }

        private void btnShowGridExHideColumns_Click(object sender, EventArgs e)
        {
            dgvList.ShowFieldChooser(this, ResourceCode.T158);
        }
    }

}
