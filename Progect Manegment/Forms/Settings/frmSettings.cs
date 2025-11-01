using HM_ERP_System.Class_General;
using HM_ERP_System.Forms.Main_Form;

using MyClass;

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

        public frmSettings(IUpdatableForms updatableForms)
        {
            InitializeComponent();
            _updatableForms=updatableForms;

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
            CallUpdateTata();
        }
        public void UpdateData()
        {
            CallUpdateTata();
        }
        private void CallUpdateTata()
        {
            txtSetDayToReportList.Value=Properties.Settings.Default.SetDayToReportList;
            chkShowAccountBalance.Checked=Properties.Settings.Default.StatusShowAccountBalance;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ResourceCode.T015, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                return;

            Properties.Settings.Default.SetDayToReportList=txtSetDayToReportList.Value;
            Properties.Settings.Default.StatusShowAccountBalance=chkShowAccountBalance.Checked;



            Properties.Settings.Default.Save();
            PublicClass.WindowAlart("1");
            if (_updatableForms!=null)
                _updatableForms.UpdateData();


        }

        private void frmSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (PublicClass.CloseForm())
                    this.Close();
            }
        }
    }
}
