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

namespace HM_ERP_System.Forms.Main_Form
{
    public partial class frmAddItems : frmMasterForm
    {
        public frmAddItems()
        {
            InitializeComponent();
            //this.KeyPreview = true;
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    // جلوگیری از ارسال کلید به فرم قبلی
        //    if (!this.Focused && !this.ContainsFocus)
        //        return false;

        //    switch (keyData)
        //    {
        //        case Keys.F5:
        //            OnF5Pressed();
        //            return true;

        //        case Keys.F2:
        //            OnF2Pressed();
        //            return true;

        //        case Keys.F7:
        //            OnF7Pressed();
        //            return true;

        //        case Keys.F8:
        //            OnF8Pressed();
        //            return true;

        //        case Keys.Escape:
        //            OnEscPressed();
        //            return true;
        //    }

        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        //// رویدادهای قابل Override برای فرم‌های فرزند
        //protected virtual void OnF5Pressed() { MessageBox.Show("Test");}
        //protected virtual void OnF2Pressed() { }
        //protected virtual void OnF7Pressed() { }
        //protected virtual void OnF8Pressed() { }
        //protected virtual void OnEscPressed() { this.Close(); }


        private void frmAddItems_Load(object sender, EventArgs e)
        {

            //txtDateStart.Text = PersianDate.AddDaysToShamsiDate(PersianDate.NowPersianDate, Properties.Settings.Default.SetDayToReportList * -1);
            //txtDateEnd.Text = PersianDate.DateEnd();
            //WindowState = FormWindowState.Maximized;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            txtDateStart.Value = DateTime.Now;
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            txtDateEnd.Value = DateTime.Now;
        }
    }
}
