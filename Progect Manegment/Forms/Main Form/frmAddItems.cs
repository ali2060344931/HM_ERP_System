using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Main_Form
{
    public partial class frmAddItems : frmMasterForm
    {
        public frmAddItems()
        {
            InitializeComponent();
        }

        private void frmAddItems_Load(object sender, EventArgs e)
        {
            txtDateStart.Value = DateTime.Now;
            txtDateEnd.Value = DateTime.Now;
            WindowState = FormWindowState.Maximized;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
