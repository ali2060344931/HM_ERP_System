using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace MyClass//OMS
{
    static class StaticClass
    {
        public const string ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|datadirectory|\\bank2.mdf;Integrated Security=True;User Instance=True";
        //public const string ConnectionString = "Data Source=10.104.32.106;Initial Catalog=Cooching;Persist Security Info=True;User Id=bahman;password=5294407";
        //public static string NowDateTime;
        public static string HelpBookMasir //= @"f:\نرم افزارهای نوشته خودم\94 -OMS\EBOOK";
        {
            get
            {
                return SqlServerBankClass.SearchOneRecord("tblOption", "1=1")[0].ToString();
            }
            set
            {
                SqlServerBankClass.Update("tblOption", new string[] { "masir" }, new string[] { value }, "1=1");
            }
        }
        //public const string HelpBookMAsir = "C:\\EBOOK";
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public const string ProjectName = "";
        public static string UserID = "";
        public static string UserTYPE = "";
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void MiladyToShamsy(DateTime miladyDate, out int d, out int m, out int y)
        {
            PersianCalendar p = new PersianCalendar();
            d = p.GetDayOfMonth(miladyDate);
            m = p.GetMonth(miladyDate);
            y = p.GetYear(miladyDate);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string ShamsyNowFormatFull()
        {
            PersianCalendar p = new PersianCalendar();
            string d = p.GetDayOfMonth(DateTime.Now.Date).ToString();
            d = (d.Length == 1) ? "0" + d : d;
            string m = p.GetMonth(DateTime.Now.Date).ToString();
            m = (m.Length == 1) ? "0" + m : m;
            string y = p.GetYear(DateTime.Now.Date).ToString();
            return y + "/" + m + "/" + d;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string TimeNowFormatFull()
        {
            string s = DateTime.Now.Second.ToString();
            s = (s.Length == 1) ? "0" + s : s;
            string m = DateTime.Now.Minute.ToString();
            m = (m.Length == 1) ? "0" + m : m;
            string h = DateTime.Now.Hour.ToString();
            h = (h.Length == 1) ? "0" + h : h;
            return h + ":" + m + ":" + s;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool IsKabiseShamsi(int year)
        {
            PersianCalendar p = new PersianCalendar();
            if (p.IsLeapYear(year))
                return true;
            else
                return false;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static DateTime ShamsyToMilady(string shamsyDate)
        {
            var array1 = shamsyDate.Split('/');
            int y = int.Parse(array1[0]);
            int m = int.Parse(array1[1]);
            int dd = int.Parse(array1[2]);
            DateTime d = new DateTime(y, m, dd, new PersianCalendar());
            return d;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static long DiffrentToDate(string date1, string date2)
        {
            long n = 0;
            try
            {
                var array1 = date1.Split('/');
                var array2 = date2.Split('/');
                DateTime d1 = new DateTime(int.Parse(array1[0]), int.Parse(array1[1]), int.Parse(array1[2]), new PersianCalendar());
                DateTime d2 = new DateTime(int.Parse(array2[0]), int.Parse(array2[1]), int.Parse(array2[2]), new PersianCalendar());
                n = (d2.Subtract(d1)).Days;
                if (n < 0)
                    n = 0;
                return n;
            }
            catch
            {
                return 0;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static long DiffrentToDateBaManfi(string LittDate1, string BigDate2)
        {
            long n = 0;
            try
            {
                var array1 = LittDate1.Split('/');
                var array2 = BigDate2.Split('/');
                DateTime d1 = new DateTime(int.Parse(array1[0]), int.Parse(array1[1]), int.Parse(array1[2]), new PersianCalendar());
                DateTime d2 = new DateTime(int.Parse(array2[0]), int.Parse(array2[1]), int.Parse(array2[2]), new PersianCalendar());
                n = (d2.Subtract(d1)).Days;
                return n;
            }
            catch
            {
                return 0;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static int Diffrent2TimeResultISMinute(string bigTime, string littleTime)
        {
            try
            {
                string[] array1 = bigTime.Split(':');
                string[] array2 = littleTime.Split(':');
                int n1 = int.Parse(array1[0]) * 60 + int.Parse(array1[1]);
                int n2 = int.Parse(array2[0]) * 60 + int.Parse(array2[1]);
                return n1 - n2;
            }
            catch
            {
                return 0;
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string Diffrent2TimeResultIsTime(string bigTime, string littleTime)
        {
            try
            {
                string[] array1 = bigTime.Split(':');
                string[] array2 = littleTime.Split(':');
                int n1 = int.Parse(array1[0]) * 60 + int.Parse(array1[1]);
                int n2 = int.Parse(array2[0]) * 60 + int.Parse(array2[1]);
                n1 = n1 - n2;
                if (n1 < 0)
                    return "0000";
                else
                {
                    string a = (n1 / 60).ToString();
                    string b = (n1 % 60).ToString();
                    a = (a.Length == 1) ? "0" + a : a;
                    b = (b.Length == 1) ? "0" + b : b;
                    return a + b;
                }
            }
            catch
            {
                return "0000";
            }
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static string DayBefore(int d)
        {
            DateTime date = DateTime.Now;
            date = date.AddDays(-d);
            int y1, m1, d1;
            MiladyToShamsy(date, out d1, out m1, out y1);
            string sy = y1.ToString(), sm, sd;
            if (m1 <= 9)
                sm = "0" + m1;
            else
                sm = m1.ToString();
            if (d1 <= 9)
                sd = "0" + d1;
            else
                sd = d1.ToString();
            return sy + "/" + sm + "/" + sd;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void EnglishKeyboard()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void FarsiKeyboard()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static void DataGridViewExportToExcelByCopy2(DataGridView dgr, string FileName)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = FileName + ".xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard(dgr);

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                //Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                //rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgr.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
        //-------------------------------------------------------
        public static void DataGridViewExportToExcelByCopy(DataGridView dgr)
        {
            copyAlltoClipboard(dgr);
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
        //-------------------------------------------------------
        private static void copyAlltoClipboard(DataGridView dgr)
        {
            dgr.SelectAll();
            DataObject dataObj = dgr.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

        }
        //-------------------------------------------------------

        public static void DataGridViewExportToExcel(DataGridView dgr)
        {
            var excel = new Excel.Application();
            excel.Application.Workbooks.Add(true);

            int ColumnIndex = 0;
            foreach (DataGridViewColumn col in dgr.Columns)
            {
                ColumnIndex++;
                excel.Cells[1, ColumnIndex] = col.HeaderText;
            }
            //excel.Rows[1].Interior.Color = System.Drawing.Color.LightGray;
            excel.Range[excel.Cells[1, 1], excel.Cells[1, ColumnIndex]].Interior.Color = System.Drawing.Color.LightGray;

            int rowIndex = 0;
            string val;

            //Application.DoEvents();
            foreach (DataGridViewRow row in dgr.Rows)
            {
                Application.DoEvents();
                rowIndex++;
                ColumnIndex = 0;

                //excel.Rows[rowIndex].Height = 20;

                //excel.Rows[rowIndex].Style.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);کل شیت رنگی می شه
                if (row.DefaultCellStyle.BackColor.R == 0 && row.DefaultCellStyle.BackColor.G == 0 && row.DefaultCellStyle.BackColor.B == 0)
                {
                    //no op
                }
                else
                    excel.Rows[rowIndex + 1].Interior.Color = row.DefaultCellStyle.BackColor;


                foreach (DataGridViewColumn col in dgr.Columns)
                {
                    ColumnIndex++;
                    if (row.Cells[ColumnIndex - 1].Value == null)
                        val = "";
                    else
                        val = row.Cells[ColumnIndex - 1].Value.ToString();

                    //format
                    if (val.Contains('/') || val.Contains('%') || val.Contains(':'))
                        excel.Cells[rowIndex + 1, ColumnIndex].NumberFormat = "@";
                    else if (val.Contains('.'))
                        excel.Cells[rowIndex + 1, ColumnIndex].NumberFormat = "#.##";
                    else
                        excel.Cells[rowIndex + 1, ColumnIndex].NumberFormat = "#.##";


                    //-----
                    if (val.ToUpper() == "FALSE")
                        val = "خیر";
                    else if (val.ToUpper() == "TRUE")
                        val = "بلی";
                    //-----
                    excel.Cells[rowIndex + 1, ColumnIndex] = val;
                }
            }
            excel.Columns.AutoFit();
            excel.Visible = true;
        }
        //-------------------------------------------------------

        public static void DataGridViewExportToExcel_ForSchool_Nomreh(DataGridView dgr, string FileName, string SheetName, string idKelas, string idDars, string CodModeG, string id_tbl_K_D_M)
        {
            // انتخاب سطر فیلدها
            int row_n = 1;
            var excel = new Excel.Application();
            excel.Application.Workbooks.Add(true);

            int ColumnIndex = 0;
            foreach (DataGridViewColumn col in dgr.Columns)
            {
                ColumnIndex++;
                excel.Cells[row_n, ColumnIndex] = col.HeaderText;
            }
            excel.Range[excel.Cells[row_n, 1], excel.Cells[row_n, ColumnIndex]].Interior.Color = System.Drawing.Color.LightGray;

            int rowIndex = 0;
            string val;

            Application.DoEvents();
            foreach (DataGridViewRow row in dgr.Rows)
            {
                rowIndex++;
                ColumnIndex = 0;

                foreach (DataGridViewColumn col in dgr.Columns)
                {
                    ColumnIndex++;
                    if (row.Cells[ColumnIndex - 1].Value == null)
                        val = "";
                    else
                        val = row.Cells[ColumnIndex - 1].Value.ToString();
                    excel.Cells[rowIndex + row_n, ColumnIndex] = val;
                }
            }


            excel.Columns.AutoFit();
            excel.Visible = true;
            excel.Cells[rowIndex + 3, 2] = SheetName;
            excel.Cells[rowIndex + 4, 2] = "نام درس:";

            excel.Cells[rowIndex + 5, 2] = "نام معلم:";
            excel.Cells[rowIndex + 6, 2] = "کد پرسنلی معلم:";

            excel.Cells[rowIndex + 7, 2] = "تاریخ آزمون:";
            excel.Cells[rowIndex + 8, 2] = "مجموع بارم سوالات(آزمون):";


            excel.Cells[rowIndex + 9, 2] = "Cod_File:" + idKelas;

            if (CodModeG == "2")//تهیه لیست با مشخص بودن نوع درس و معلم
            {
                System.Collections.Hashtable H = MyClass.SqlBankClass.SearchOnRecordHashTable("select * from View_tbl_K_D_M where id=" + id_tbl_K_D_M);
                excel.Cells[rowIndex + 4, 3] = H["nameDars"].ToString();
                excel.Cells[rowIndex + 5, 3] = H["name"].ToString() + " " + H["famili"].ToString();
                excel.Cells[rowIndex + 6, 3] = H["codPersneli"].ToString();
                excel.Cells[rowIndex + 9, 2] = "Cod_File:" + idKelas + ":" + id_tbl_K_D_M;

                //افزودن رنگ سلول فیلدهای بالایی
                excel.Range[excel.Cells[rowIndex + 3, 1], excel.Cells[rowIndex + 9, ColumnIndex]].Interior.Color = System.Drawing.Color.GreenYellow;

            }
            else if (CodModeG == "1")//تهیه لیست بدون مشخص بودن نوع درس و معلم
            {
                //افزودن رنگ سلول فیلدهای بالایی
                excel.Range[excel.Cells[rowIndex + 3, 1], excel.Cells[rowIndex + 9, ColumnIndex]].Interior.Color = System.Drawing.Color.LightSeaGreen;

            }

            //تغییر فرمت سلول به تکست
            excel.Range[excel.Cells[rowIndex + 4, 3], excel.Cells[rowIndex + 8, 3]].NumberFormat = "@";


            //تعیین رنگ محل ثبت نام درس
            excel.Range[excel.Cells[rowIndex + 4, 3], excel.Cells[rowIndex + 4, 3]].Interior.Color = System.Drawing.Color.Yellow;

            //تعیین رنگ محل ثبت تاریخ آزمون
            excel.Range[excel.Cells[rowIndex + 7, 3], excel.Cells[rowIndex + 7, 3]].Interior.Color = System.Drawing.Color.WhiteSmoke;

            //تعیین رنگ جهت محل ثبت مجموع بارم سوالات
            excel.Range[excel.Cells[rowIndex + 8, 3], excel.Cells[rowIndex + 8, 3]].Interior.Color = System.Drawing.Color.Yellow;

            //تعیین رنگ جهت محل ثبت مجموع بارم سوالات
            excel.Range[excel.Cells[rowIndex + 5, 3], excel.Cells[rowIndex + 5, 3]].Interior.Color = System.Drawing.Color.WhiteSmoke;

            //تعیین رنگ جهت محل ثبت مجموع بارم سوالات
            excel.Range[excel.Cells[rowIndex + 6, 3], excel.Cells[rowIndex + 6, 3]].Interior.Color = System.Drawing.Color.Yellow;

            //برای افزودن کامنت به سلول تاریخ
            excel.Range[excel.Cells[rowIndex + 7, 3], excel.Cells[rowIndex + 7, 3]].AddComment();
            excel.Range[excel.Cells[rowIndex + 7, 3], excel.Cells[rowIndex + 7, 3]].Comment.Visible = "False";
            excel.Range[excel.Cells[rowIndex + 7, 3], excel.Cells[rowIndex + 7, 3]].Comment.Text("1401/01/08" + '\n' + "لطفا تاریخ را بصورت صحیح مانند نمونه تکمیل نمائید");

            //برای افزودن کامنت به سلول نمره
            excel.Range[excel.Cells[rowIndex + 8, 3], excel.Cells[rowIndex + 8, 3]].AddComment();
            excel.Range[excel.Cells[rowIndex + 8, 3], excel.Cells[rowIndex + 8, 3]].Comment.Visible = "False";
            excel.Range[excel.Cells[rowIndex + 8, 3], excel.Cells[rowIndex + 8, 3]].Comment.Text("لطفا مجموع بارم سوالات را حتما وارد نمائید. درغیر اینصورت اطلاعات در بانک مقصد ذخیره نمی شود");

            //برای افزودن کامنت به سلول کد پرسنلی معلم
            excel.Range[excel.Cells[rowIndex + 6, 3], excel.Cells[rowIndex + 6, 3]].AddComment();
            excel.Range[excel.Cells[rowIndex + 6, 3], excel.Cells[rowIndex + 6, 3]].Comment.Visible = "False";
            excel.Range[excel.Cells[rowIndex + 6, 3], excel.Cells[rowIndex + 6, 3]].Comment.Text("لطفا کد پرسنلی معلم را صحیح وارد نمائید، در غیر اینصورت برنامه مقدور به شناسایی فرم نمی باشد");
            
            //دستور مخفی کردن سطر کد فایل
            excel.Range[excel.Cells[rowIndex + 9, 3], excel.Cells[rowIndex + 9, 3]].EntireRow.Hidden = "True";

            //Save File To Format .xls
            excel.ActiveWorkbook.SaveAs(FileName, Excel.XlFileFormat.xlOpenXMLWorkbook);

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        //---------------------------------------------------------
        public static string GetCurrentIP()
        {
            string LocalIP = null;
            System.Net.IPHostEntry IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            foreach (System.Net.IPAddress IPAddress in IPHostEntry.AddressList)
                if (IPAddress.AddressFamily.ToString() == "InterNetwork")
                    LocalIP = IPAddress.ToString();
            return LocalIP;
        }
        //-------------------------------------------------------------
        public static string ShowMaxNomrator()
        {
            string ThisDate = MyClass.PersianDate.MiladyToShamsi(DateTime.Now);
            string yy = ThisDate.Substring(1, 3);
            string mm = ThisDate.Substring(5, 2);

            if (MyClass.SqlBankClass.CountValueIn1Field_Repeat("select count(*) from TblSabtSanads") != 0)
            {
                int n = MyClass.SqlBankClass.MaxValueIn1Field("select max(nomrator) from  TblSabtSanads");

                if (n.ToString().Substring(0, 5) != yy + mm)
                    return yy + mm + "001";
                else
                    return (n + 1).ToString();
            }
            else
                return yy + mm + "001";

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}