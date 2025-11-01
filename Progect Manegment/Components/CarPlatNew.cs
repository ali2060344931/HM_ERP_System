using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Components
{
    public partial class CarPlatNew : UserControl
    {
        public event EventHandler AllControlsCompleted;
        //public bool IsNew=true;
        public string Carplate_ = "";

        public CarPlatNew()
        {
            InitializeComponent();
        }

        private void CarPlatNew_Load(object sender, EventArgs e)
        {
            cmbLeter.Text = "ع";
        }
        public void SearchCar_Driver()
        {
            if (txtCarplate1.Text.Length == 2 && txtCarplate2.Text.Length == 3 && txtCarplate3.Text.Length == 2 && cmbLeter.SelectedIndex != -1)
            {


                Carplate_ = this.txtCarplate3.Text + " " /*+ ResourceCode._001*/ + " " + this.txtCarplate2.Text + " " + this.cmbLeter.Text + " " + this.txtCarplate1.Text;

                AllControlsCompleted?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                Carplate_ = "";
                AllControlsCompleted?.Invoke(this, EventArgs.Empty);
            }

        }

        private void cmbLeter_ValueChanged(object sender, EventArgs e)
        {
            SearchCar_Driver();
            if (cmbLeter.Text.Length == 1)
                SendKeys.Send("{TAB}");

        }

        private void txtCarplate2_ValueChanged(object sender, EventArgs e)
        {
            SearchCar_Driver();
            if (txtCarplate2.Text.Length == 3)
                SendKeys.Send("{TAB}");

        }

        private void txtCarplate3_ValueChanged(object sender, EventArgs e)
        {
            SearchCar_Driver();
            if (txtCarplate3.Text.Length == 2)
                SendKeys.Send("{TAB}");

        }

        private void txtCarplate1_ValueChanged(object sender, EventArgs e)
        {
            SearchCar_Driver();
            if (txtCarplate1.Text.Length == 2)
                SendKeys.Send("{TAB}");

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCarplate1.ResetText();
            txtCarplate2.ResetText();
            txtCarplate3.ResetText();
            //  cmbLeter.ResetText();
            txtCarplate1.Focus();

        }

        private void txtCarplate1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
