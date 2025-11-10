using HM_ERP_System.Forms.Comers;
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

namespace HM_ERP_System.Forms.Accounts.RecevingPayment
{
    public partial class frmRecevingPaymentDoc : frmMasterForm
    {
        public string DocTitel = "";
        public int IdH = 0;
        public int IdB = 0;
        public frmRecevingPaymentDoc()
        {
            InitializeComponent();
        }

        private void frmRecevingPaymentDoc_Load(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            FillGroupBoxComersH();
            FillGroupBoxComersB();
            if (DocTitel!="")
                this.Text=DocTitel;
            /*
            switch (DocName)
            {
               case "H"://حواله
                    FillGroupBoxComersH();
                    break;
                case "B"://بارنامه
                    FillGroupBoxComersB();
                    break;
                case "T"://تانکر

                    break;
            }
            */
        }

        void FillGroupBoxComersH()
        {
            //GroupBoxComersH.Visible=true;
            //GroupBoxComersH.Dock=DockStyle.Fill;
            
            frmComers.FilldgvListH(dgvListH,"1400/01/01","1500/01/01", IdH);

        }
        void FillGroupBoxComersB()
        {
            //GroupBoxComersB.Visible=true;
            //GroupBoxComersB.Dock=DockStyle.Fill;
            frmComers.FilldgvListB(dgvListB, "1400/01/01", "1500/01/01", IdH, null);

        }
    }
}
