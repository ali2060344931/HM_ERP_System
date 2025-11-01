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

namespace HM_ERP_System
{
    public partial class Form3 : frmAddItems
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            //PublicClass.SaveGridExToExcel(dgvList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dgvList.RootTable.CellLayoutMode=Janus.Windows.GridEX.CellLayoutMode.UseColumns;

            //dgvList.sel
        }
    }
}
