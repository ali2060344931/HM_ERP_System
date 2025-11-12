using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.FinancialYears;
using HM_ERP_System.Forms.Main_Form;

using MyClass;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Login
{
    public partial class frmLoginProg : Form, IUpdatableForms
    {
        public frmLoginProg()
        {
            InitializeComponent();
        }

        public void UpdateData()
        {

        }
        private void btnIncoming_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicClass.FindEmptyControls(cmbFinancialYears, ResourceCode.T130, txtUserName, ResourceCode.T056, txtPassword, ResourceCode.T057)) { return; }
                if(cmbFinancialYears.SelectedIndex== -1)
                {
                    PublicClass.ErrorMesseg(ResourceCode.T130);
                    return; 
                }

                using (var db = new DBcontextModel())
                {
                    var q = from CrRl in db.CustomerRoles

                            join cu in db.Customers
                            on CrRl.CustomerId equals cu.Id

                            //join rl in db.Roles
                            //on CrRl.RoleId equals rl.Id

                            where cu.CodMeli==txtUserName.Text.Trim()
                            select new
                            {
                                CrRl.Id,
                                CustomersId = cu.Id,
                                CrRl.Status,
                                cu.CodMeli,
                                CrRl.Password,
                                //RoleId = rl.Id
                            };

                    if (q.Count() == 0)
                    {
                        PublicClass.StopMesseg(ResourceCode.T055/*+"1"*/);
                        return;
                    }
                    else
                    {
                        // بررسی اینکه آیا رشته‌ای با هش تولید شده مطابقت دارد یا خیر
                        bool VerifyHash = PublicClass.VerifyHash(txtPassword.Text, q.First().Password);

                        if (!VerifyHash)
                        {
                            PublicClass.StopMesseg(ResourceCode.T055);
                            return;
                        }
                        OPenMainForm(q.First().Id);
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        void OPenMainForm(int UsersId)
        {
            try
            {
                frmMainForm f = new frmMainForm();
                this.Hide();
                
                using (var db=new DBcontextModel())
                {
                    var q = db.CustomerRoles.Where(c => c.Id==UsersId).First();
                    q.FinancialYearId=FinancialYearsId;
                    db.SaveChanges();
                }
                f.UsersId = UsersId;
                Properties.Settings.Default.UsersId = UsersId;
                Properties.Settings.Default.FinancialYear =  FinancialYearsId.ToString();
                Properties.Settings.Default.Save();
                PublicClass.SetUserId();
                PublicClass.SetFinancialYear();
                f.ShowDialog();
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void frmLoginProg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");

        }

        private void frmLoginProg_Load(object sender, EventArgs e)
        {
            this.Text=ResourceCode.ProgName;
            FillcmbProvinces();
            cmbFinancialYears.Value= Properties.Settings.Default.FinancialYear;
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Text="نسخه برنامه: "+version.ToString();


        }

        private void FillcmbProvinces()
        {
            using (var db = new DBcontextModel())
            {
                var q=db.FinancialYears.ToList();
                cmbFinancialYears.DataSource= q;
            }
        }

         int FinancialYearsId =0;
        private void cmbFinancialYears_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                FinancialYearsId = Convert.ToInt32(cmbFinancialYears.Value);
            }
            catch (Exception)
            {
            }
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmFinancialYears f=new frmFinancialYears(this);
            f.ShowDialog();
            FillcmbProvinces();
        }
    }
}
