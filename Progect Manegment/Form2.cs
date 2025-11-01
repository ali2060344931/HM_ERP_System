using HM_ERP_System.Forms.Main_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System
{
    public partial class Form2 : frmAddItems
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           this.WindowState= FormWindowState.Maximized;
        }

        private void btnShowListItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtDateStart.Text);
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
            
        {
MessageBox.Show("txtDateStart.Text");
        }

        private void pnlViewItemHeder_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
