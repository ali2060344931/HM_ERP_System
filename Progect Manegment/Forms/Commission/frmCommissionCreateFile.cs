using HM_ERP_System.Forms.Comers;
using HM_ERP_System.Forms.Main_Form;

using MyClass;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Forms.Commission
{
    public partial class frmCommissionCreateFile : frmMasterForm
    {
        public int? CustomerToGroupId;
        public frmCommissionCreateFile()
        {
            InitializeComponent();
        }

        private void frmCommissionCreateFile_Load(object sender, EventArgs e)
        {
            try
            {
                string layoutPathComersB = Path.Combine(Application.StartupPath, "DefaultGridLayoutComersB.xml");
                using (var fs = new FileStream(layoutPathComersB, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    dgvListB.LoadLayoutFile(fs);
                }
                frmComers.FilldgvListB(dgvListB, "1400/01/01", "1500/01/01", CustomerToGroupId, null, true);
                dgvListB.RootTable.Columns["Details"].Visible=false;
                dgvListB.RootTable.Columns["select"].Visible=false;
                //PublicClass.SettingGridEX(dgvListB);
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
            }
        }
    }
}
