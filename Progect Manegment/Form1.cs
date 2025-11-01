using HM_ERP_System.Forms.Main_Form;
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

namespace HM_ERP_System
{
    public partial class Form1 : frmMasterForm
    {
        DBcontextModel db=new DBcontextModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q=db.Ciltys.First().Name;
            Text=q;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
        }
    }
}
