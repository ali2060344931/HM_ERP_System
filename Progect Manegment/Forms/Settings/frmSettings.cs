using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.TruckUsageType;
using HM_ERP_System.Entity.TypeCustomer;
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

namespace HM_ERP_System.Forms.Settings
{
    public partial class frmSettings : frmMasterForm, IUpdatableForms
    {
        private IUpdatableForms _updatableForms;
        int ListId = 0;

        public frmSettings(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms = updatableForms;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CallUpdateTata();
        }
        public void UpdateData()
        {
            CallUpdateTata();
        }

        private void CallUpdateTata()
        {
            FilldgvList();
            FillcmbDefultCompany();
            FillCustomSetings();
        }


        void FillCustomSetings()
        {
            using (var db = new DBcontextModel())
            {
                int userId = PublicClass.UserId;
                var q = db.CustomerRoles.Where(c => c.Id == userId).First();
                txtSetDayToReportList.Text = q.SetDayToReportList.ToString();
                cmbDefultCompany.Value = q.DefultSetingId;
            }

        }
        private void FilldgvList()
        {
            using (var db = new DBcontextModel())
            {
                var q = db.Settings.ToList();
                dgvList.DataSource = q;
                PublicClass.SettingGridEX(dgvList);
            }
        }

        void EditListData(int id)
        {
            try
            {
                txtSetDayToReportList.Value = PublicClass.SetDayToReportList();
                chkShowAccountBalance.Checked = Properties.Settings.Default.StatusShowAccountBalance;

                using (var db = new DBcontextModel())
                {
                    var q = db.Settings.Where(c => c.Id == id);
                    {
                        txtName.Text = q.First().Subject;
                        txtAddres.Text = q.First().StrCode1;
                        txtTels.Text = q.First().StrCode2;
                        txtSubjectTitel.Text = q.First().StrCode3;
                    }

                    //Todo: دستور نمایش عکس ها
                    DataTable onRec1 = new DataTable();

                    onRec1 = MyClass.Manage_Photos.Read_TableFromBank_InsertToDataTable("SELECT * FROM Settings where id=" + id);
                    picLogo.Image = MyClass.Manage_Photos.GetImageFromeFieldValues(onRec1.Rows[0]["Image1"]);
                    picReg.Image = MyClass.Manage_Photos.GetImageFromeFieldValues(onRec1.Rows[0]["Image2"]);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }


        private void FillcmbDefultCompany()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from st in db.Settings
                            select new
                            {
                                st.Id,
                                Name = st.Subject
                            };

                    cmbDefultCompany.DataSource = q.ToList();
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        /// <summary>
        /// ذخیره بخش عمومی
        /// </summary>
        void SaveDatapublic()
        {
            try
            {
                using (var db = new DBcontextModel())
                {

                    if (PublicClass.FindEmptyControls(txtName, ResourceCode.T196, txtSubjectTitel, ResourceCode.T200, txtAddres, ResourceCode.T198, txtTels, ResourceCode.T199)) return;

                    if (picLogo.Image == null || picReg.Image == null)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T201); return;
                    }
                    if (ListId == 0)
                    {
                        int cont = db.Settings.Count(c => c.Subject == txtName.Text);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T163); return;
                        }
                    }
                    else
                    {
                        int cont = db.Settings.Count(c => c.Subject == txtName.Text & c.Id != ListId);
                        if (cont > 0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T163); return;
                        }
                    }

                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                        return;

                    Properties.Settings.Default.SetDayToReportList = txtSetDayToReportList.Value;
                    Properties.Settings.Default.StatusShowAccountBalance = chkShowAccountBalance.Checked;

                    System.Drawing.Image picture1 = picLogo.Image;
                    System.Drawing.Image picture2 = picReg.Image;
                    byte[] arrpic1 = null;
                    byte[] arrpic2 = null;

                    System.IO.MemoryStream mp1 = new System.IO.MemoryStream();
                    picture1.Save(mp1, picture1.RawFormat);
                    arrpic1 = mp1.GetBuffer();

                    System.IO.MemoryStream mp2 = new System.IO.MemoryStream();
                    picture2.Save(mp2, picture2.RawFormat);
                    arrpic2 = mp2.GetBuffer();

                    var seting = new Repository<Entity.Settings.Setting>(db);
                    seting.SaveOrUpdate(new Entity.Settings.Setting { Id = ListId, Subject = txtName.Text, StrCode1 = txtAddres.Text, StrCode2 = txtTels.Text, StrCode3 = txtSubjectTitel.Text, Image1 = arrpic1, Image2 = arrpic2, RecordDateTime = DateTime.Now, UserId = PublicClass.UserId }, ListId);
                }

                Properties.Settings.Default.Save();

                if (_updatableForms != null)
                    _updatableForms.UpdateData();

                FillcmbDefultCompany();
                CelearItems();
                PublicClass.WindowAlart("1");


            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
        /// <summary>
        /// ذخیره بخش خصوصی
        /// </summary>
        void SaveDataprivet()
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    if (db.Settings.Count() != 0 && cmbDefultCompany.SelectedIndex == -1)
                    {
                        PublicClass.ErrorMesseg(ResourceCode.T202); return;

                    }
                    if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                        return;


                    //ثبت تنظیمات شخصی
                    {
                        int userId = PublicClass.UserId;
                        var cr = db.CustomerRoles.Where(c => c.Id == userId).First();
                        cr.SetDayToReportList = Convert.ToInt32(txtSetDayToReportList.Text);
                        cr.DefultSetingId = Convert.ToInt32(cmbDefultCompany.Value);
                        db.SaveChangesSafe();
                    }
                }
                Properties.Settings.Default.Save();

                if (_updatableForms != null)
                    _updatableForms.UpdateData();

                PublicClass.WindowAlart("1");
                CelearItems();

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (TabKey)
            {
                case "public_"://عمومی
                    SaveDatapublic();
                    break;
                case "privet_"://خصوصی
                    SaveDataprivet();
                    break;
            }
        }


        private void frmSettings_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
            if (e.Control && e.KeyCode == Keys.F12) { UpdateData(); PublicClass.WindowAlart("1", ResourceCode.T161); }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            picLogo.Image = MyClass.Manage_Photos.ShowImageToPicterBox(picLogo);
        }

        private void btnAddPic2_Click(object sender, EventArgs e)
        {
            picReg.Image = MyClass.Manage_Photos.ShowImageToPicterBox(picReg);
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
                        EditListData(ListId);
                    }
                }

                else if (e.Column.Key == "Delete")
                {
                    using (var db = new DBcontextModel())
                    {
                        int userid = PublicClass.UserId;
                        var q0 = db.CustomerRoles.Where(c => c.Id == userid).First().DefultSetingId;

                        if (ListId == q0)
                        {
                            PublicClass.ErrorMesseg(ResourceCode.T004 + '\n' + ResourceCode.T204);
                            return;
                        }

                        if (MessageBox.Show(ResourceCode.T003, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            var q = db.Color_s.Where(c => c.Id == ListId).First();
                            db.Color_s.Remove(q);
                            PublicClass.WindowAlart("2");
                            db.SaveChangesSafe();
                            FilldgvList();
                            CelearItems();
                        }
                    }
                }
                else if (e.Column.Key == "btnDefault")
                {
                    /*
                    using (var db = new DBcontextModel())
                    {
                        var q = db.Settings.ToList();
                        foreach (var item in q)
                        {
                            item.Default = false;
                            if (item.Id == ListId)
                            {
                                item.Default = true;
                            }
                        }
                        if (db.SaveChangesSafe())
                            FilldgvList();
                    }
                    */
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
            txtSubjectTitel.ResetText();
            txtAddres.ResetText();
            txtTels.ResetText();
            picLogo.Image = null;
            picReg.Image = null;
            ListId = 0;
            FilldgvList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CelearItems();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        string TabKey = "";
        private void uiTab1_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            {
                TabKey = uiTab1.SelectedTab.Key;
                //switch (TabKey)
                //{
                //    case "public_"://عمومی

                //        break;
                //    case "privet_"://خصوصی

                //        break;
                //}
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                PublicClass.ErrorMesseg("لطفا کد را وارد نمائید");
                txtCode.Focus();
                return;
            }

            if (txtCode.Text == "12345")
                if (MessageBox.Show("آیا تمامی اسناد حواله، بارنامه و حسابداری حذف شوند؟", ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (var db = new DBcontextModel())
            {
                var tr = db.Transactions.ToList();
                var cmrB = db.ComersBs.ToList();
                var cmrH = db.ComersHs.ToList();
                var DB = db.DocumentBancks.ToList();

                db.Transactions.RemoveRange(tr);
                db.ComersBs.RemoveRange(cmrB);
                db.ComersHs.RemoveRange(cmrH);
                db.DocumentBancks.RemoveRange(DB);
                db.SaveChangesSafe();
                PublicClass.WindowAlart("2");
                txtCode.ResetText();
            }



        }
    }
}
