using HM_ERP_System.Forms.Comers;
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

namespace HM_ERP_System.Forms.Commission
{
    public partial class frmCommissionCreateFile : frmMasterForm
    {
        public int? CustomerId;
        public frmCommissionCreateFile()
        {
            InitializeComponent();
        }

        private void frmCommissionCreateFile_Load(object sender, EventArgs e)
        {
            frmComers.FilldgvListB(dgvListB, "1400/01/01", "1500/01/01", CustomerId, null, true);
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            dgvListB.RootTable.Columns["Id"].Visible=true;
            dgvListB.RootTable.Columns["AmountCommission"].Visible=true;
            if (PublicClass.SaveGridExToExcel(dgvListB)==DialogResult.OK)
            {
                Close();
            }
            else
            {
                dgvListB.RootTable.Columns["Id"].Visible=false;
                dgvListB.RootTable.Columns["AmountCommission"].Visible=false;
            }
        }
    }
}
