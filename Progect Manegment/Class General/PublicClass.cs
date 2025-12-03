using BehComponents;

using ClosedXML.Excel;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

using FastMember;

using GridExEx;

using HM_ERP_System;
using HM_ERP_System.Class_General;
using HM_ERP_System.Entity.Accounts.Cheque;
using HM_ERP_System.Entity.Accounts.DetailedAccount;
using HM_ERP_System.Entity.Accounts.SpecificAccount;
using HM_ERP_System.Entity.Accounts.Transaction;
using HM_ERP_System.Entity.Accounts.TransactionType;
using HM_ERP_System.Entity.Provinces;
using HM_ERP_System.Forms.Accounts.ReviewAccounts;
using HM_ERP_System.Forms.BlacList;
using HM_ERP_System.Forms.DocumentBanck;
using HM_ERP_System.Forms.SearchCombos;

using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.GridEX.Export;

using Microsoft.Office.Interop.Excel;

using NPOI.HSSF.UserModel;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

using Org.BouncyCastle.Crypto.Tls;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
//using Telerik.WinControls.Svg;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace MyClass
{
    public static class PublicClass
    {
        static DBcontextModel db_ = new DBcontextModel();

        //public const string ProjectNameMainPege = "نرم افزار ؟؟؟";
        ////public const string NameSandogh = "0صندوق امام حسن مجتبی علیه السلام";
        //public const string TaydSabt = ".اطلاعات مورد نظر با موفقید ثبت گردید";



        public static string UserName = "";
        public static int Id_ = 0;
        /// <summary>
        /// کد کاربر
        /// </summary>
        public static int UserId = HM_ERP_System.Properties.Settings.Default.UsersId;

        /// <summary>
        /// سال مالی
        /// </summary>
        public static string FinancialYear = HM_ERP_System.Properties.Settings.Default.FinancialYear;


        public static void SetUserId()
        {
            UserId = HM_ERP_System.Properties.Settings.Default.UsersId;
        }

        public static void SetFinancialYear()
        {
            FinancialYear = HM_ERP_System.Properties.Settings.Default.FinancialYear;
            //FinancialYear =db_.CustomerRoles.Where(c => c.Id==UserId).First().FinancialYearId.ToString();
        }
        //-------------------------------------------------------
        public static bool RunningProject()
        {
            string p = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            System.Diagnostics.Process[] ins = System.Diagnostics.Process.GetProcessesByName(p);
            if (ins.Length > 1)
                return true;
            else
                return false;
        }
        //-------------------------------------------------------
        public static string ProjectName
        {
            get
            {
                //System.Collections.Hashtable h = MyClass.SqlBankClass.SearchOnRecordHashTable("Select txt from TblTanzimatKol where id=1");
                return NameProg;
            }
        }

        //-------------------------------------------------------
        public static string NameProg
        {
            get
            {
                return "نرم افزار حسابداری هوشمند";
            }
        }

        //_______________________________________________________
        public static void WriteGraphicText(Graphics e, string txt, System.Drawing.Point p, System.Drawing.Font f, Color foreColor, bool shadow, Color shadowColor, int shadowDepth)
        {
            e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (shadow)
                e.DrawString(txt, f, new SolidBrush(shadowColor), new PointF(p.X + shadowDepth, p.Y + shadowDepth));//shadow
            e.DrawString(txt, f, new SolidBrush(foreColor), p);
        }
        //_______________________________________________________
        /// <summary>
        /// : FindEmptyControls(textbox1,"لطفا نام را وارد نمائید")
        /// </summary>
        /// <param name="controls_Messages"></param>
        /// <returns></returns>
        /// 
        internal static bool FindEmptyControls(params object[] controls_Messages)
        {

            for (int i = 0; i < controls_Messages.Length; i += 2)
            {
                Control c = controls_Messages[i] as Control;
                string mesage = controls_Messages[i + 1].ToString();
                //if ((c is ComboBox && (c as ComboBox).SelectedIndex == -1) || (c is ComboBox && (c as ComboBox).Text == "") || ((c is TextBox || c is MaskedTextBox) && (c.Text == "")))
                if ((c is RichTextBox && (c as RichTextBox).Text == "") || (c is ComboBox && (c as ComboBox).Text == "") || ((c is System.Windows.Forms.TextBox || c is MaskedTextBox) && (c.Text == "")) || ((c is Janus.Windows.GridEX.EditControls.EditBox || c is Janus.Windows.GridEX.EditControls.EditBox) && (c.Text == "")) || ((c is MultiColumnCombo || c is MultiColumnCombo) && (c.Text == "")) || ((c is IntegerInput || c is IntegerInput) && (c.Text == "")) || ((c is DoubleInput || c is DoubleInput) && (c.Text == "")))
                {
                    MessageBoxFarsi.Show(mesage, ResourceCode.ProgName, MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                    c.Focus();

                    return true;
                }
            }
            return false;
        }
        //_______________________________________________________
        public static Size TextWidthHeight(Graphics e, string txt, System.Drawing.Font f)
        {
            e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            return new Size((int)e.MeasureString(txt, f).Width, (int)e.MeasureString(txt, f).Height);
        }
        //_______________________________________________________
        public static object GetFieldCombo(ComboBox ctrl, string field)
        {
            return (ctrl.SelectedItem as DataRowView)[field];
        }
        //-----------دستور-----------
        public static bool ChekEmailAddres(string EmailAddres)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(EmailAddres, @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"))
            {
                return true;
            }

            else
            {
                return false;
            }

        }
        //_______________________________________________________
        public static bool ChekUrlAdres(string UrlAdres)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(UrlAdres) as HttpWebRequest;
                request.Method = "HEAD";
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                //لینک وجود ندارد
                return false;
            }
        }
        //_______________________________________________________
        public static string Date_Time()
        {
            PersianCalendar pc = new System.Globalization.PersianCalendar();
            string LogIn_OutTime = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00") + " - " + DateTime.Now.ToShortTimeString();
            return LogIn_OutTime;
        }
        //_______________________________________________________
        public static void ErrorMesseg(string textError)
        {
            MessageBoxFarsi.Show(textError, ResourceCode.ProgName, MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Warning);
        }

        public static DialogResult ErrorMessegYesNo(string textError)
        {
            if (MessageBoxFarsi.Show(textError, ResourceCode.ProgName, MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Warning, MessageBoxFarsiDefaultButton.Button2) == DialogResult.Yes)
                return DialogResult.Yes;
            else
                return DialogResult.No;
        }

        //_______________________________________________________
        public static void SaveMesseg(string txtSave)
        {
            MessageBoxFarsi.Show(txtSave, ResourceCode.ProgName, MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
        }
        //_______________________________________________________
        public static void StopMesseg(string txtSave)
        {
            MessageBoxFarsi.Show(txtSave, ResourceCode.ProgName, MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Stop);
        }
        //_______________________________________________________
        public static string QuestionMesseg(string textError)
        {
            string Drsoult = MessageBox.Show(textError, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign).ToString();
            return Drsoult;
        }

        //_______________________________________________________

        public static string QuestionExitOfForms()
        {
            string Drsoult = MessageBox.Show("آیا موافقید از فرم خارج شوید", ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign).ToString();
            return Drsoult;
        }

        //_______________________________________________________

        public static bool CheckOpenForms(string FormName)
        {
            if (System.Windows.Forms.Application.OpenForms[FormName] != null)
            {
                //MessageBox.Show("فـــرم  مورد نظر فعــال (باز) می باشــد", "هشــدار");
                return true;
            }
            return false;
        }
        public static bool CheckOpenFormsNoMesag(string FormName)
        {
            if (System.Windows.Forms.Application.OpenForms[FormName] != null)
            {
                //MessageBox.Show("فـــرم  مورد نظر فعــال (باز) می باشــد", "هشــدار");
                return true;
            }
            return false;
        }

        //_______________________________________________________
        public static string DeleteMesseg(string textError)
        {
            string Drsoult = MessageBox.Show(textError, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign).ToString();
            return Drsoult;
        }
        //-------------------------------------------------------
        /// <summary>
        /// برای تغییر پرینتر
        /// </summary>
        public static class myPrinters
        {
            [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetDefaultPrinter(string Name);
        }

        /// <summary>
        ///(this,"Clear","1") برای خالی کردن عناوین کنترل ها
        /// </summary>
        /// <param name="container">This</param>
        /// <param name="CommandName">Clear,ReadOnly</param>
        /// <param name="TagString">Tag String کلمه تگ</param>
        public static void CelearMyTextControl(Control container, string CommandName, string TagString)
        {
            // برای خالی کردن کنترل ها کافیست که در قسمت پروپرتی رو تگ عدد 1 قرار دهید
            foreach (Control c in container.Controls)
            {
                CelearMyTextControl(c, CommandName, TagString);
                if (c is System.Windows.Forms.TextBox || c is ComboBox || c is System.Windows.Forms.Label || c is System.Windows.Forms.Button)
                {
                    switch (CommandName)
                    {
                        case "Clear":
                            if (c.Tag.ToString() == TagString)
                                c.ResetText();
                            break;
                        case "ReadOnly":
                            ((System.Windows.Forms.TextBox)c).ReadOnly = true;
                            break;
                    }

                }
            }
        }

        /// <summary>
        ///نحوه نمایش در فرم ها textBox1.Text = MyClass.PublicClass.GetNetworkTime().Year.ToString() + "." + MyClass.PublicClass.GetNetworkTime().Month.ToString("00") + "." + MyClass.PublicClass.GetNetworkTime().Day.ToString("00") + "-" + MyClass.PublicClass.GetNetworkTime().Hour.ToString("00") + ":" + MyClass.PublicClass.GetNetworkTime().Minute.ToString("00") + ":" + MyClass.PublicClass.GetNetworkTime().Second.ToString("00");
        /// </summary>
        /// <returns></returns>
        public static DateTime GetNetworkTime()
        {
            //default Windows time server
            const string ntpServer = "time.windows.com";

            // NTP message size - 16 bytes of the digest (RFC 2030)
            var ntpData = new byte[48];

            //Setting the Leap Indicator, Version Number and Mode values
            ntpData[0] = 0x1B; //LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //The UDP port number assigned to NTP is 123
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP uses UDP

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);

                //Stops code hang if NTP is blocked
                socket.ReceiveTimeout = 3000;

                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }

            //Offset to get to the "Transmit Timestamp" field (time at which the reply 
            //departed the server for the client, in 64-bit timestamp format."
            const byte serverReplyTime = 40;

            //Get the seconds part
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //Get the seconds fraction
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Convert From big-endian to little-endian
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //**UTC** time
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }

        // stackoverflow.com/a/3294698/162671
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }

        /* دستور جهت نمایش در داخل فرمها
                    textBox1.Text = MyClass.PublicClass.GetNetworkTime().Year.ToString() + "." + MyClass.PublicClass.GetNetworkTime().Month.ToString("00") + "." + MyClass.PublicClass.GetNetworkTime().Day.ToString("00") + "-" + MyClass.PublicClass.GetNetworkTime().Hour.ToString("00") + ":" + MyClass.PublicClass.GetNetworkTime().Minute.ToString("00") + ":" + MyClass.PublicClass.GetNetworkTime().Second.ToString("00");
        */


        /// <summary>
        /// کد برای رمزگذاری
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        //todo: کد برای رمز گشایی
        /// <summary>
        /// کد برای رمز گشایی
        /// </summary>
        /// <param name="base64EncodedData"></param>
        /// <returns></returns>
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        /// <summary>
        /// جهت نمایش پیغام ویندوزی
        /// </summary>
        /// <param name="Cod">کد: 1 ذخیره کد: 2 حذف</param>        /// <param name="msgText">متن پیام های اختیاری</param>
        public static void WindowAlart(string Cod, string MassegText = "")
        {
            if (Cod == "1")//جهت ثبت
            {
                DesktopAlert.Show(MassegText == "" ? "اطلاعات مورد نظر با موفقیت ثبت گردید" : MassegText, "10003", eSymbolSet.Awesome, Color.Empty, eDesktopAlertColor.Green, eAlertPosition.BottomRight, 3, 0, null);
            }
            else if (Cod == "2")//جهت ثبت
            {

                DesktopAlert.Show(MassegText == "" ? "اطلاعات مورد نظر با موفقیت حذف گردید" : MassegText, "10008", eSymbolSet.Awesome, Color.Empty, eDesktopAlertColor.Red, eAlertPosition.BottomRight, 3, 0, null);

                //DesktopAlert.Show("اطلاعات مورد نظر با موفقیت حذف گردید", "10008", eSymbolSet.Awesome, Color.Empty, eDesktopAlertColor.Red, eAlertPosition.BottomRight, 3, 0, null);
            }

            else if (Cod == "3")
            {
                DesktopAlert.Show("هیچ سندی با این شماره ثبت نشده است", "10008", eSymbolSet.Awesome, Color.Empty, eDesktopAlertColor.Blue, eAlertPosition.BottomRight, 3, 0, null);
            }


        }

        private static NotifyIcon notifyIcon;

        public static void WindowsNotifyIcon(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon)
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information; // آیکون نوتیفیکیشن  
            notifyIcon.Visible = true;
            // نمایش نوتیفیکیشن  
            notifyIcon.ShowBalloonTip(timeout, tipTitle, tipText, tipIcon);
        }

        /// <summary>
        /// نوتیفکیشن ویندوز
        /// </summary>
        /// <param name="ColorCode">کد رنگ یا نام رنگ</param>
        /// <param name="AlertText">متن پیام</param>
        /// <param name="IconCode">کد آیکون</param>
        /// <param name="alertDurationSeconds">مدت زمان مکث آلارم</param>
        /// <param name="alertId">کد جهت انجام دستور</param>
        /// پارامتر alertClickAction در متد DesktopAlert.Show معمولاً به عنوان یک delegate یا action استفاده می‌شود که وقتی کاربر بر روی هشدار کلیک می‌کند، باید اجرا شود. این پارامتر به شما امکان می‌دهد تابعی را تعیین کنید که در واکنش به عمل کلیک کاربر فراخوانی شود.
        public static void WindowAlartByText(eDesktopAlertColor ColorCode, string AlertText, string symbol, int alertDurationSeconds, long alertId)
        {
            int Id = 0;
            DesktopAlert.Show(AlertText, symbol, eSymbolSet.Awesome, Color.YellowGreen, ColorCode, eAlertPosition.TopRight, alertDurationSeconds, alertId, (id) =>
            {
                switch (id)
                {
                    case 1:
                        //frmBlacList f = new frmBlacList(null);
                        //f.ShowDialog();
                        Id = (int)id;

                        break;
                }
                //alertId عملیات (کلیک روی نوتیفکیشن) مورد نظر با استفاده از
                //MessageBox.Show(id.ToString());
            });

        }

        /// <summary>
        /// حذف محتویات جداول
        /// </summary>
        public static void CelereTables()
        {
            if (MessageBox.Show(ResourceCode.T053, ResourceCode.ProgName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            using (var db = new DBcontextModel())
            {
                //ToDo دستور حذف کل ردیف های یک جدول
                var q1 = db.DocumentBancks.ToList();
                db.DocumentBancks.RemoveRange(q1);

                var q2 = db.ComersBs.ToList();
                db.ComersBs.RemoveRange(q2);

                var q3 = db.ComersHs.ToList();
                foreach (var item in q3)
                {
                    CheangStatusCarToComers(item.CarId, false);
                }

                db.ComersHs.RemoveRange(q3);

                db.SaveChanges();
                WindowAlart("2");
            }
        }

        /// <summary>
        /// متد تغییر وضیعت آزاد بودن کامیون ها
        /// </summary>
        /// <param name="CarId"></param>
        /// <param name="Satatus"></param>
        public static void CheangStatusCarToComers(int CarId, bool Satatus)
        {
            using (var db = new DBcontextModel())
            {
                var cr = db.Cars.Where(c => c.Id == CarId).First();
                cr.StatusCarToComers = Satatus;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// خروجی جدول دیتاگرید جانوس به اکسل
        /// </summary>
        /// <param name="gridEXExporter"></param>
        public static DialogResult SaveGridExToExcel(GridEX gridEX)
        {
            GridEXExporter gridEXExporter = new GridEXExporter();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel File (*.xls)|*.xls"
                ,
                Title = "ذخیر لیست به اکسل",
                FileName = "Comers List_" + DateTime.Now.ToString("yyyyMMdd_HHmm")
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gridEXExporter.GridEX = gridEX;
                using (var stream = saveFileDialog.OpenFile())
                {
                    gridEXExporter.Export(stream);
                }

                WindowAlart("1");
                return DialogResult.OK;
            }
            else
            {
                return DialogResult.No;
            }
        }

        public static void ExportVisibleColumnsToExcel(GridEX gridEX, string filePath)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Data");

            // Header (فقط ستون‌های قابل‌نمایش)
            IRow headerRow = sheet.CreateRow(0);
            int visibleColIndex = 0;
            for (int i = 0; i < gridEX.RootTable.Columns.Count; i++)
            {
                var col = gridEX.RootTable.Columns[i];
                if (col.Visible)
                {
                    headerRow.CreateCell(visibleColIndex).SetCellValue(col.Caption);
                    visibleColIndex++;
                }
            }

            // Rows (فقط داده‌های ستون‌های قابل‌نمایش)
            for (int r = 0; r < gridEX.RowCount; r++)
            {
                gridEX.MoveToRowIndex(r);
                GridEXRow currentRow = gridEX.GetRow();
                IRow row = sheet.CreateRow(r + 1);

                visibleColIndex = 0;
                for (int c = 0; c < gridEX.RootTable.Columns.Count; c++)
                {
                    var col = gridEX.RootTable.Columns[c];
                    if (col.Visible)
                    {
                        string val = currentRow.Cells[col.Key].Value?.ToString() ?? "";
                        row.CreateCell(visibleColIndex).SetCellValue(val);
                        visibleColIndex++;
                    }
                }
            }

            // ذخیره فایل
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
            }
        }


        /// <summary>
        /// جستجو در کمبوباکس ها
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="dt"></param>
        public static int SearchToCmb(MultiColumnCombo cmb, System.Data.DataTable dt)
        {
            try
            {
                int cn = cmb.DropDownList.Columns.Count;
                string txt = "";
                for (int i = 0; i < cn; i++)
                {
                    txt += cmb.DropDownList.Columns[i].Key + ",";
                    txt += cmb.DropDownList.Columns[i].Caption + ",";
                    txt += cmb.DropDownList.Columns[i].DataMember + ",";
                    txt += cmb.DropDownList.Columns[i].Visible + ",";
                    txt += cmb.DropDownList.Columns[i].Width + ",";
                    //txt += cmb.DropDownList.Columns[i].Tag + ",";
                }

                if (dt.Rows.Count > 0)
                {
                    frmSearchAllCombo f = new frmSearchAllCombo();
                    f.dt = dt;
                    f.ColItems = txt;
                    f.ColumnsCount = cn;
                    f.ShowDialog();

                }
                return Id_;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }

        /// <summary>
        /// افزودن مقادیر در دیتاتیبل
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static System.Data.DataTable FillToDataTable<T>(IEnumerable<T> data)
        {
            try
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                if (data == null || !data.Any())
                    return dt; // اگر لیست خالی بود، دیتاتابل خالی برمی‌گرداند
                               // گرفتن ویژگی‌های نوع T
                var properties = typeof(T).GetProperties();
                // افزودن ستون‌ها به DataTable بر اساس ویژگی‌ها
                foreach (var property in properties)
                {
                    dt.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                }
                // پر کردن سطرهای DataTable
                foreach (var item in data)
                {
                    var row = dt.NewRow();
                    foreach (var property in properties)
                    {
                        var value = property.GetValue(item) ?? DBNull.Value;
                        row[property.Name] = value;
                    }
                    dt.Rows.Add(row);
                }
                return dt;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

        /// <summary>
        ///FastMember با DataTable در Entity افزودن جدول های
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static System.Data.DataTable AddEntityTableToDataTable<T>(List<T> list)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();
            using (var reader = FastMember.ObjectReader.Create(list))
            {
                dataTable.Load(reader);
            }
            return dataTable;
        }

        /// <summary>
        /// متد مدیریت خطاها
        /// </summary>
        /// <param name="FromName">نام فرم</param>
        /// <param name="ex">پیام های خطا</param>
        public static void ShowErrorMessage_(string SourceName, Exception ex)
        {
            // 1. استخراج اطلاعات از StackTrace
            StackTrace trace = new StackTrace(ex, true);
            StackFrame stackFrameForError = null;

            // جستجو در فریم‌ها برای یافتن اولین فریم کد کاربر (که lineNumber != 0 دارد)
            for (int i = 0; i < trace.FrameCount; i++)
            {
                StackFrame frame = trace.GetFrame(i);

                // اگر شماره خط یا نام فایل وجود داشت، آن را به عنوان فریم خطا در نظر می‌گیریم.
                if (frame.GetFileLineNumber() != 0 || frame.GetFileName() != null)
                {
                    // همچنین مطمئن می‌شویم که مربوط به اسمبلی‌های .NET Framework نباشد
                    Assembly assembly = frame.GetMethod()?.DeclaringType?.Assembly;
                    if (assembly != null && !assembly.FullName.StartsWith("System."))
                    {
                        stackFrameForError = frame;
                        break;
                    }
                }
            }

            // اگر فریم مناسب پیدا نشد، از فریم صفر استفاده می‌شود.
            if (stackFrameForError == null)
            {
                stackFrameForError = trace.GetFrame(0);
            }

            // 2. استخراج جزئیات
            string className = "N/A";
            string methodName = "N/A";
            string fileName = "N/A";
            int lineNumber = 0;
            string errorText = ex.Message; // متن خطا همان Message شیء Exception است

            if (stackFrameForError != null)
            {
                MethodBase methodBase = stackFrameForError.GetMethod();
                if (methodBase != null)
                {
                    // استخراج نام کلاس
                    className = methodBase.DeclaringType?.Name ?? "N/A";
                    // استخراج نام متد
                    methodName = methodBase.Name ?? "N/A";
                }

                fileName = stackFrameForError.GetFileName() ?? "N/A";
                lineNumber = stackFrameForError.GetFileLineNumber();
            }

            // 2. ساخت پیام خطا
            string ErrText = $" Error Source File: {fileName}  \n  \n" +
                             $" Form Name: {className} \n " +
                             $" Method Name: {methodName} \n " +
                             $" Error Line Number: {lineNumber} \n " +
                             $" Error Text: {errorText} \n" +
                             " ______________________________________________________ \n\n";
            // 3. نمایش و کپی کردن
            Clipboard.SetText(ErrText);
            MessageBox.Show(ErrText + "متن خطا در حافظه موقت سیستم کپی شد \n خطای مورد نظر را به گروه پشتیبانی اعلام فرمائید \n 09111161996",
                            "Error خطا",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public static void ShowErrorMessage(Exception ex)
        {
            StackTrace trace = new StackTrace(ex, true);
            StackFrame stackFrameForError = null;

            // 1. جستجو در فریم‌ها برای یافتن اولین فریم کد کاربر (که lineNumber != 0 دارد)
            for (int i = 0; i < trace.FrameCount; i++)
            {
                StackFrame frame = trace.GetFrame(i);

                // اگر شماره خط یا نام فایل وجود داشت، و مربوط به اسمبلی‌های .NET Framework نبود
                if (frame.GetFileLineNumber() != 0 || frame.GetFileName() != null)
                {
                    // این بررسی برای فیلتر کردن کدهای سیستم است و تمرکز بر کد پروژه شما.
                    Assembly assembly = frame.GetMethod()?.DeclaringType?.Assembly;
                    if (assembly != null && !assembly.FullName.StartsWith("System."))
                    {
                        stackFrameForError = frame;
                        break;
                    }
                }
            }

            // اگر فریم مناسب پیدا نشد، از فریم صفر استفاده می‌شود.
            if (stackFrameForError == null)
            {
                stackFrameForError = trace.GetFrame(0);
            }

            // 2. استخراج جزئیات
            string className = "N/A";
            string methodName = "N/A";
            string fileName = "N/A";
            int lineNumber = 0;
            string errorText = ex.Message;

            if (stackFrameForError != null)
            {
                MethodBase methodBase = stackFrameForError.GetMethod();
                if (methodBase != null)
                {
                    // نام کلاس از DeclaringType متد استخراج می‌شود
                    className = methodBase.DeclaringType?.Name ?? "N/A";
                    // نام متد استخراج می‌شود
                    methodName = methodBase.Name ?? "N/A";
                }

                fileName = stackFrameForError.GetFileName() ?? "N/A";
                lineNumber = stackFrameForError.GetFileLineNumber();
            }

            // 2. ساخت پیام خطا
            string ErrText = $" Error Source File: {fileName}  \n  \n" +
                             $" Form Name: {className} \n " +
                             $" Method Name: {methodName} \n " +
                             $" Error Line Number: {lineNumber} \n " +
                             $" Error Text: {errorText} \n" +
                             " ______________________________________________________ \n\n";
            // 3. نمایش و کپی کردن
            Clipboard.SetText(ErrText);
            MessageBox.Show(ErrText + "متن خطا در حافظه موقت سیستم کپی شد \n خطای مورد نظر را به گروه پشتیبانی اعلام فرمائید \n 09111161996",
                            "Error خطا",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        /// <summary>
        /// جستجوی در کمبوباکس ها
        /// </summary>
        /// <param name="multiColumnCombo"></param>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static object SearchCmbId(MultiColumnCombo multiColumnCombo, System.Data.DataTable dataTable)
        {
            try
            {
                if (dataTable != null)
                {
                    int id = SearchToCmb(multiColumnCombo, dataTable);
                    if (id != 0)
                        return multiColumnCombo.Value = id;
                    else
                        return multiColumnCombo.Text = "";
                }
                else
                {
                    WindowAlartByText(eDesktopAlertColor.Red, "مقادیری در لیست نمی باشد", "No", 2, 150);
                    return multiColumnCombo.Text = "";
                }
            }
            catch (Exception)
            {
                return multiColumnCombo.Text = "";
            }
        }

        /// <summary>
        /// افزدون مدارک پیوستی
        /// </summary>
        /// <param name="FromName">نام فرم</param>
        /// <param name="ListInFoemId">آی دی لیست</param>
        /// <param name="Title">عنوان</param>
        public static void AddDocumentToBanck(string FromName, int ListInFoemId, string Title)
        {
            frmDocumentBanck f = new frmDocumentBanck();
            f.FormName = FromName;
            f.ListInFoemId = ListInFoemId;
            f.lblCaption.Text = Title;
            f.ShowDialog();
        }


        /// <summary>
        /// برای تبدیل یک رشته به هش
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GenerateHash(string input)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // به شکل هگزادسیمال تبدیل می‌شود  
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// بررسی اینکه آیا رشته‌ای با هش تولید شده مطابقت دارد یا خیر
        /// </summary>
        /// <param name="input"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static bool VerifyHash(string input, string hash)
        {
            string hashOfInput = GenerateHash(input);
            return hashOfInput.Equals(hash, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// تنظیمات دسترسی فرم ها
        /// </summary>
        /// <param name="ControlName">نام تگ کنترل</param>
        /// <param name="mode">صفر0: بدون اعلام 1: با اعلام</param>
        /// <returns></returns>
        public static bool SetPeremission(string ControlName, int mode = 0)


        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    if (db.Peremissions.Count() == 0) return false;

                    var rlId = db.CustomerRoles.Where(c => c.Id == UserId).First().RoleId;

                    var perId = db.Peremissions.Where(c => c.NodeName == ControlName).First().Id;

                    var q = db.RolePermissiones.Where(c => c.RoleId == rlId && c.PermissionId == perId).First();


                    if (q.status)
                        return q.status;
                    else
                    {
                        if (mode == 0)
                            return q.status;
                        else
                        {
                            WindowAlartByText(eDesktopAlertColor.Red, ResourceCode.T065, "10007", 5, 150);

                            return false;
                        }
                    }
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return false;
            }
        }

        /// <summary>
        /// ثبت اسناد حسابداری:درآمد و هزینه
        /// </summary>
        /// <param name="TransactionCode">کد سند</param>
        /// <param name="TransactionDate">تاریخ سندparam>
        /// <param name="TransactionTypeId">نوع سند</param>
        /// <param name="SpecificAccountId">حساب معین</param>
        /// <param name="DetailedAccountFromId">حساب تفصیلی از</param>
        /// <param name="DetailedAccountToId">حساب تفصیلی به</param>
        /// <param name="TotlAmount">مبلغ سند</param>
        /// <param name="PayAmount">مبلغ دریافتی/پرداختی</param>
        /// <param name="ComerBId">کد بارنامه</param>
        /// <param name="Description">توضیحات</param>
        public static void Transaction(int TransactionCode, string TransactionDate, int TransactionTypeId, int SpecificAccountId, int DetailedAccountFromId, int DetailedAccountToId, double TotlAmount, double PayAmount, double TaxAmount, int ComerBId, string Description)
        {
            using (var db = new DBcontextModel())
            {
                int ListId = 0;
                int Series = 1;
                int SpecificAccountId_ = 0;
                double Bed = 0;
                double Bes = 0;

                if (TransactionTypeId == 1)//درآمد
                    SpecificAccountId_ = db.SpecificAccounts.Where(c => c.Cod == 10301).First().Id;//بدهکاران تجاری، خریداران
                else//فروش
                    SpecificAccountId_ = db.SpecificAccounts.Where(c => c.Cod == 30101).First().Id;//بستانکاران تجارى ،فروشندگان

                int DetailedAccountFromId_ = 0;
                {//بدهکاران/بستانکاران تجاری


                    if (TransactionTypeId == 1)
                    {
                        Bed = TotlAmount + TaxAmount;
                        Bes = 0;
                    }
                    else
                    {
                        Bed = 0;
                        Bes = TotlAmount + TaxAmount;
                    }


                    //حساب تفصیلی
                    var da = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId_ && c.CustomerId == DetailedAccountFromId);

                    if (da.Count() != 0)
                        DetailedAccountFromId_ = da.First().Id;
                    else
                    {
                        int CodeAccount_ = CeratDetailedAccountCode(SpecificAccountId_);

                        var insert = new Repository<DetailedAccount>(db);

                        DetailedAccountFromId_ = insert.SaveOrUpdateRefId(new DetailedAccount { Id = 0, SpecificAccountId = SpecificAccountId_, CustomerId = DetailedAccountFromId, CodeAccount = CodeAccount_ }, 0);
                    }

                    var userRepo = new Repository<Transaction>(db);
                    userRepo.SaveOrUpdate(new Transaction { Id = ListId, FinancialYear = FinancialYear, TransactionCode = TransactionCode, TransactionDate = TransactionDate, TransactionTypeId = TransactionTypeId, SpecificAccountId = SpecificAccountId_, DetailedAccountId = DetailedAccountFromId_, Amount = TotlAmount, PaymentBed = TransactionTypeId == 1 ? TotlAmount + TaxAmount : 0, PaymentBes = TransactionTypeId == 1 ? 0 : TotlAmount + TaxAmount, ComerBId = ComerBId, Description = Description, UserId = UserId, Series = Series, DateTime = DateTime.Now, FinalRegistry = false, Status = false, IsAutoRejDoc = true }, ListId);
                }

                //مالیات
                if (TaxAmount != 0)
                {
                    Series++;
                    int cuId_ = 0;
                    int SpecificAccountTaxId = 0;
                    if (TransactionTypeId == 1)//درآمد
                    {
                        SpecificAccountTaxId = db.SpecificAccounts.Where(c => c.Cod == 10406).First().Id;
                        cuId_ = db.Customers.Where(c => c.SecretCode == 1).First().Id;
                    }
                    else//هزینه
                    {
                        SpecificAccountTaxId = db.SpecificAccounts.Where(c => c.Cod == 30602).First().Id;
                        cuId_ = db.Customers.Where(c => c.SecretCode == 2).First().Id;
                    }

                    DetailedAccountFromId_ = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountTaxId && c.CustomerId == cuId_).First().Id;

                    var userRepo = new Repository<Transaction>(db);
                    userRepo.SaveOrUpdate(new Transaction { Id = ListId, FinancialYear = FinancialYear, TransactionCode = TransactionCode, TransactionDate = TransactionDate, TransactionTypeId = TransactionTypeId, SpecificAccountId = SpecificAccountTaxId, DetailedAccountId = DetailedAccountFromId_, Amount = TotlAmount, PaymentBed = TransactionTypeId == 1 ? 0 : TaxAmount, PaymentBes = TransactionTypeId == 1 ? TaxAmount : 0, ComerBId = ComerBId, Description = Description, UserId = UserId, Series = Series, DateTime = DateTime.Now, FinalRegistry = false, Status = false, IsAutoRejDoc = true }, ListId);
                }


                {//   درآمد/هزینه
                    Series++;

                    var da = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == DetailedAccountFromId);

                    if (da.Count() != 0)
                        DetailedAccountFromId_ = da.First().Id;
                    else
                    {
                        int CodeAccount_ = CeratDetailedAccountCode(SpecificAccountId);

                        var insert = new Repository<DetailedAccount>(db);

                        DetailedAccountFromId_ = insert.SaveOrUpdateRefId(new DetailedAccount { Id = 0, SpecificAccountId = SpecificAccountId, CustomerId = DetailedAccountFromId, CodeAccount = CodeAccount_ }, 0);
                    }



                    var userRepo = new Repository<Transaction>(db);
                    userRepo.SaveOrUpdate(new Transaction { Id = ListId, FinancialYear = FinancialYear, TransactionCode = TransactionCode, TransactionDate = TransactionDate, TransactionTypeId = TransactionTypeId, SpecificAccountId = SpecificAccountId, DetailedAccountId = DetailedAccountFromId_, Amount = TotlAmount, PaymentBed = TransactionTypeId == 1 ? 0 : TotlAmount, PaymentBes = TransactionTypeId == 1 ? TotlAmount : 0, ComerBId = ComerBId, Description = Description, UserId = UserId, Series = Series, DateTime = DateTime.Now, FinalRegistry = false, Status = false, IsAutoRejDoc = true }, ListId);
                }

                if (PayAmount != 0)
                {
                    {//بانک
                        Series++;
                        int DetailedAccountToId_ = 0;
                        int SpecificAccountBanckId_ = db.SpecificAccounts.Where(c => c.Cod == 10102).First().Id;

                        var da = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountBanckId_ && c.CustomerId == DetailedAccountToId);

                        if (da.Count() != 0)
                            DetailedAccountToId_ = da.First().Id;
                        else
                        {
                            int CodeAccount_ = CeratDetailedAccountCode(SpecificAccountBanckId_);

                            var insert = new Repository<DetailedAccount>(db);

                            DetailedAccountToId_ = insert.SaveOrUpdateRefId(new DetailedAccount { Id = 0, SpecificAccountId = SpecificAccountBanckId_, CustomerId = DetailedAccountToId, CodeAccount = CodeAccount_ }, 0);
                        }

                        var userRepo = new Repository<Transaction>(db);
                        userRepo.SaveOrUpdate(new Transaction { Id = ListId, FinancialYear = FinancialYear, TransactionCode = TransactionCode, TransactionDate = TransactionDate, TransactionTypeId = TransactionTypeId, SpecificAccountId = SpecificAccountBanckId_, DetailedAccountId = DetailedAccountToId_, Amount = TotlAmount, PaymentBed = TransactionTypeId == 1 ? PayAmount : 0, PaymentBes = TransactionTypeId == 1 ? 0 : PayAmount, ComerBId = ComerBId, Description = Description, UserId = UserId, Series = Series, DateTime = DateTime.Now, FinalRegistry = false, Status = false, IsAutoRejDoc = true }, ListId);
                    }

                    {//بدهکاران/بستانکاران تجاری
                        Series++;



                        var userRepo = new Repository<Transaction>(db);
                        userRepo.SaveOrUpdate(new Transaction { Id = ListId, FinancialYear = FinancialYear, TransactionCode = TransactionCode, TransactionDate = TransactionDate, TransactionTypeId = TransactionTypeId, SpecificAccountId = SpecificAccountId_, DetailedAccountId = DetailedAccountFromId_, Amount = TotlAmount, PaymentBed = TransactionTypeId == 1 ? 0 : PayAmount, PaymentBes = TransactionTypeId == 1 ? PayAmount : 0, ComerBId = ComerBId, Description = Description, UserId = UserId, Series = Series, DateTime = DateTime.Now, FinalRegistry = false, Status = false, IsAutoRejDoc = true }, ListId);
                    }
                }
                WindowAlart("1");
            }
        }

        /// <summary>
        /// ایجاد کد تفصیلی
        /// </summary>
        public static int CeratDetailedAccountCode(int SpecificAccountId_)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.SpecificAccounts.Where(c => c.Id == SpecificAccountId_).First();

                    var cd = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId_);
                    if (cd.Count() == 0)
                    {
                        return q.Cod * 10000 + 1;
                    }
                    else
                    {
                        return cd.Max(c => c.CodeAccount) + 1;
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
        /// <summary>
        /// شماره اسناد حسابداری
        /// </summary>
        /// <param name="Code">1 برای سندهای ابتدای دوره و صفر برای همه سند ها</param>
        /// <returns></returns>
        public static string CreatTransactionCode(int? Code = 0)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.Transactions;
                    string yare = PersianDate.NowPersianDate.Substring(0, 4);
                    if (Code == 0)
                    {
                        if (q.Count() == 0)
                        {
                            return yare + "0001";
                        }
                        else
                        {
                            var maxRemiaanceSeryal = q.Max(c => c.TransactionCode);
                            if (maxRemiaanceSeryal.ToString().Substring(0, 4) == yare)
                            {
                                return (maxRemiaanceSeryal + 1).ToString();
                            }
                            else
                            {
                                return yare + "0001";
                            }
                        }
                    }
                    else//برای سندهای افتتاحیه ابتدای دوره
                    {
                        return yare + "0000";
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return "";
            }
        }

        /// <summary>
        /// نمایش اطلاعات در جدول درآمد/هزینه و دریافت/پرداخت
        /// </summary>
        /// <param name="gx"></param>
        /// <param name="DateStart"></param>
        /// <param name="DateEnd"></param>
        /// <returns></returns>
        public static GridExEx.GridExEx FilldgvListTransaction(GridExEx.GridExEx gx, string DateStart, string DateEnd)
        {
            using (var db = new DBcontextModel())
            {
                var q = from tr in db.Transactions

                        join sp in db.SpecificAccounts
                        on tr.SpecificAccountId equals sp.Id

                        join da in db.DetailedAccounts
                        on tr.DetailedAccountId equals da.Id

                        join cu in db.Customers
                        on da.CustomerId equals cu.Id

                        join tt in db.TransactionTypes
                        on tr.TransactionTypeId equals tt.Id

                        where !tr.Status && (tr.TransactionTypeId == 3 || tr.TransactionTypeId == 4 || tr.TransactionTypeId == 5) && string.Compare(tr.TransactionDate, DateStart) >= 0 && string.Compare(tr.TransactionDate, DateEnd) <= 0

                        orderby tr.Id

                        select new
                        {
                            tr.Id,
                            tr.Series,
                            tr.TransactionCode,
                            tr.TransactionDate,
                            TransactionType = tt.Name,
                            SpecificAccountName = sp.Name,
                            ContraAccountName = (cu.Family + " " + cu.Name).Trim(),
                            TotalAmount = tr.Amount,
                            tr.PaymentBed,
                            tr.PaymentBes,
                            tr.Description,
                            AccountCode = da.CodeAccount,
                            tr.IsAutoRejDoc,
                        };
                gx.DataSource = q.ToList();
                //gx.AutoSizeColumns();
                SettingGridEX(gx);

                return gx;
            }
        }

        /// <summary>
        ///  نمایش اطلاعات در جدول درآمد/هزینه و دریافت/پرداخت
        /// </summary>
        /// <param name="gx">جدول دیتاگرید</param>
        /// <param name="DateStart">تاریخ شروع</param>
        /// <param name="DateEnd">تاریخ پایان</param>
        /// <param name="transactionTypeIds">transactionType نوع تراکنش بصورت لیستی آرایه ای از جدول </param>
        /// <returns></returns>
        public static GridExEx.GridExEx FilldgvListTransaction(GridExEx.GridExEx gx, string DateStart, string DateEnd, IEnumerable<int> transactionTypeIds)
        {
            using (var db = new DBcontextModel())
            {
                // تعریف مجموعه شناسه های تراکنش مورد نظر (برای خوانایی بهتر)
                var targetTransactionTypeIds = new List<int> { 4, 5 };

                var q = from tr in db.Transactions

                        join sp in db.SpecificAccounts on tr.SpecificAccountId equals sp.Id
                        join da in db.DetailedAccounts on tr.DetailedAccountId equals da.Id
                        join cu in db.Customers on da.CustomerId equals cu.Id
                        join tt in db.TransactionTypes on tr.TransactionTypeId equals tt.Id

                        join coB in db.ComersBs
                        on tr.ComerBId equals coB.Id into coBGroup
                        from coB_ in coBGroup.DefaultIfEmpty()

                        join coH in db.ComersHs
                        on coB_.ComersHId equals coH.Id into coHGroup
                        from coH_ in coHGroup.DefaultIfEmpty()

                        where !tr.Status && transactionTypeIds.Contains(tr.TransactionTypeId)
                        && string.Compare(tr.TransactionDate, DateStart) >= 0
                        && string.Compare(tr.TransactionDate, DateEnd) <= 0
                        && (!(targetTransactionTypeIds.Contains(tr.TransactionTypeId)) || (tr.Series == 1))

                        orderby tr.Id

                        select new
                        {
                            tr.Id,
                            tr.Series,
                            tr.TransactionCode,
                            tr.TransactionDate,
                            TransactionType = tt.Name,
                            SpecificAccountName = sp.Name,
                            ContraAccountName = (cu.Family + " " + cu.Name).Trim(),
                            TotalAmount = tr.Amount,
                            tr.PaymentBed,
                            tr.PaymentBes,
                            tr.Description,
                            AccountCode = da.CodeAccount,
                            tr.IsAutoRejDoc,
                            ComerSeryal = tr.ComerBId == 0 ? 0 : (coH_ != null ? coH_.RemiaanceSeryal : 0)
                        };

                gx.DataSource = q.ToList();

                //gx.AutoSizeColumns();
                SettingGridEX(gx);
                return gx;
            }

            /*
            using (var db = new DBcontextModel())
            {

                var q = from tr in db.Transactions

                        join sp in db.SpecificAccounts on tr.SpecificAccountId equals sp.Id
                        join da in db.DetailedAccounts on tr.DetailedAccountId equals da.Id
                        join cu in db.Customers on da.CustomerId equals cu.Id
                        join tt in db.TransactionTypes on tr.TransactionTypeId equals tt.Id

                        join coB in db.ComersBs
                        on tr.ComerBId equals coB.Id into coBGroup
                        from coB_ in coBGroup.DefaultIfEmpty()

                        join coH in db.ComersHs
                        on coB_.ComersHId equals coH.Id into coHGroup
                        from coH_ in coHGroup.DefaultIfEmpty()

                        where transactionTypeIds.Contains(tr.TransactionTypeId)
                        && string.Compare(tr.TransactionDate, DateStart) >= 0
                        && string.Compare(tr.TransactionDate, DateEnd) <= 0 

                        orderby tr.Id

                        select new
                        {
                            tr.Id,
                            tr.Series,
                            tr.TransactionCode,
                            tr.TransactionDate,
                            TransactionType = tt.Name,
                            SpecificAccountName = sp.Name,
                            ContraAccountName = (cu.Family + " " + cu.Name).Trim(),
                            TotalAmount = tr.Amount,
                            tr.PaymentBed,
                            tr.PaymentBes,
                            tr.Description,
                            AccountCode = da.CodeAccount,
                            tr.IsAutoRejDoc,

                            ComerSeryal = tr.ComerBId == 0 ? 0: (coH_ != null ? coH_.RemiaanceSeryal : 0)
                        };

                gx.DataSource = q.ToList();
                
                gx.AutoSizeColumns();
                return gx;
            }
            */


        }


        /// <summary>
        ///  نمایش اطلاعات در جدول درآمد/هزینه و دریافت/پرداخت و جابجایی ها
        /// </summary>
        /// <param name="gx">جدول دیتاگرید</param>
        /// <param name="DateStart">تاریخ شروع</param>
        /// <param name="DateEnd">تاریخ پایان</param>
        /// <param name="transactionTypeListIds">transactionType نوع تراکنش بصورت لیستی آرایه ای از جدول </param>
        /// <param name="DetailedAccountId">Id کد تفصیلی(اختیاری) می باشد</param>
        /// <param name="TransactionCodeS">شماره سند از (اختیاری) می باشد</param>
        /// <param name="TransactionCodeE">شماره سند تا (اختیاری) می باشد</param>
        /// <returns></returns>
        public static GridExEx.GridExEx FilldgvListTransaction0(GridExEx.GridExEx gx, string DateStart, string DateEnd, IEnumerable<int> transactionTypeListIds, int? DetailedAccountId = 0, int? TransactionCodeS = 0, int? TransactionCodeE = 0, int? SpecificAccountId = 0)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    // ----------------------------------------------------------------
                    // 1. تعریف فیلتر اصلی حساب‌ها (برای استفاده در هر دو کوئری)
                    // ----------------------------------------------------------------

                    // این عبارت منطق ترکیب فیلتر Detailed/Specific را از مرحله قبل جدا می‌کند
                    var accountFilter = db.Transactions
                        .Where(tr => !tr.Status && transactionTypeListIds.Contains(tr.TransactionTypeId))
                        .Where(tr =>
                            (DetailedAccountId != 0 && tr.DetailedAccountId == DetailedAccountId)
                            || (DetailedAccountId == 0 && (SpecificAccountId == 0 || tr.SpecificAccountId == SpecificAccountId))
                        );

                    // ----------------------------------------------------------------
                    // 2. محاسبه مانده اول دوره (Beginning Balance)
                    // ----------------------------------------------------------------

                    var qBeginningBalance = accountFilter
                        // تراکنش‌های قبل از تاریخ شروع
                        .Where(tr => string.Compare(tr.TransactionDate, DateStart) < 0)
                        .GroupBy(tr => 1) // گروه‌بندی کل نتایج در یک سطر
                        .Select(g => new
                        {
                            // محاسبه مجموع بدهکار و بستانکار قبل از دوره
                            TotalPaymentBed = g.Sum(tr => (double?)tr.PaymentBed) ?? 0.0,
                            TotalPaymentBes = g.Sum(tr => (double?)tr.PaymentBes) ?? 0.0
                        })
                        .FirstOrDefault(); // فقط یک سطر نتیجه نیاز داریم


                    // ----------------------------------------------------------------
                    // 3. کوئری تراکنش‌های داخل دوره (Current Transactions)
                    // ----------------------------------------------------------------

                    var qCurrent = from tr in accountFilter
                                   join sp in db.SpecificAccounts on tr.SpecificAccountId equals sp.Id
                                   join da in db.DetailedAccounts on tr.DetailedAccountId equals da.Id
                                   join cu in db.Customers on da.CustomerId equals cu.Id
                                   join tt in db.TransactionTypes on tr.TransactionTypeId equals tt.Id
                                   join User in db.CustomerRoles on tr.UserId equals User.Id
                                   join CuUser in db.Customers on User.Id equals CuUser.Id

                                   // اعمال فیلتر تاریخ داخل دوره
                                   where string.Compare(tr.TransactionDate, DateStart) >= 0
                                   && string.Compare(tr.TransactionDate, DateEnd) <= 0

                                   // اعمال فیلتر کد تراکنش
                                   && (TransactionCodeS == 0 || tr.TransactionCode >= TransactionCodeS)
                                   && (TransactionCodeE == 0 || tr.TransactionCode <= TransactionCodeE)

                                   join coB in db.ComersBs on tr.ComerBId equals coB.Id into coBGroup
                                   from coB_ in coBGroup.DefaultIfEmpty()

                                   join coH in db.ComersHs on coB_.ComersHId equals coH.Id into coHGroup
                                   from coH_ in coHGroup.DefaultIfEmpty()

                                   orderby tr.Id

                                   select new
                                   {
                                       Id = tr.DetailedAccountId,
                                       tr.Series,
                                       tr.TransactionCode,
                                       tr.TransactionDate,
                                       TransactionType = tt.Name,
                                       SpecificAccountName = sp.Name,
                                       ContraAccountName = (cu.Family + " " + cu.Name).Trim(),
                                       cu.CodMeli,
                                       cu.Tel,
                                       TotalAmount = tr.Amount,
                                       tr.PaymentBed,
                                       tr.PaymentBes,
                                       tr.Description,
                                       AccountCode = da.CodeAccount,
                                       tr.IsAutoRejDoc,
                                       ComerSeryal = tr.ComerBId == 0 ? 0 : (coH_ != null ? coH_.RemiaanceSeryal : 0),
                                       User = CuUser.Family + " " + CuUser.Name,
                                   };

                    // ----------------------------------------------------------------
                    // 4. ایجاد سطر مانده اول دوره و ادغام با تراکنش‌های جاری
                    // ----------------------------------------------------------------

                    List<object> finalResult = new List<object>();

                    // ایجاد سطر مانده اول دوره (حالت مجازی)
                    if (qBeginningBalance != null)
                    {
                        var beginningBalanceRow = new
                        {
                            // مقادیر ثابت
                            Id = 0,
                            Series = "",
                            TransactionCode = "",
                            TransactionDate = DateStart, // یا تاریخ دلخواه دیگر
                            TransactionType = "مانده اول دوره", // 👈 عنوان سطر
                            SpecificAccountName = string.Empty,
                            ContraAccountName = string.Empty,
                            TotalAmount = 0.0,

                            // 🎯 مانده بدهکار/بستانکار اول دوره
                            PaymentBed = qBeginningBalance.TotalPaymentBed,
                            PaymentBes = qBeginningBalance.TotalPaymentBes,

                            Description = "مانده حساب قبل از تاریخ " + DateStart,
                            AccountCode = "",
                            IsAutoRejDoc = false,
                            ComerSeryal = 0,
                            User = "",
                        };

                        finalResult.Add(beginningBalanceRow);
                    }

                    // افزودن تراکنش‌های داخل دوره
                    finalResult.AddRange(qCurrent.ToList());

                    // ----------------------------------------------------------------
                    // 5. اتصال به GridEX
                    // ----------------------------------------------------------------

                    gx.DataSource = finalResult;
                    SettingGridEX(gx);
                    return gx;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }
        public static GridExEx.GridExEx FilldgvListTransaction(GridExEx.GridExEx gx, string DateStart, string DateEnd, IEnumerable<int> transactionTypeListIds, int? DetailedAccountId = 0, int? TransactionCodeS = 0, int? TransactionCodeE = 0, int? SpecificAccountId = 0)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    // ----------------------------------------------------------------
                    // 1. تعریف فیلتر اصلی حساب‌ها
                    // ----------------------------------------------------------------
                    var accountFilter = db.Transactions
                        .Where(tr => !tr.Status && transactionTypeListIds.Contains(tr.TransactionTypeId))
                        .Where(tr =>
                            (DetailedAccountId != 0 && tr.DetailedAccountId == DetailedAccountId)
                            || (DetailedAccountId == 0 && (SpecificAccountId == 0 || tr.SpecificAccountId == SpecificAccountId))
                        );

                    // ----------------------------------------------------------------
                    // 2. محاسبه مانده اول دوره
                    // ----------------------------------------------------------------
                    var qBeginningBalance = accountFilter
                        .Where(tr => string.Compare(tr.TransactionDate, DateStart) < 0)
                        .GroupBy(tr => 1)
                        .Select(g => new
                        {
                            TotalPaymentBed = g.Sum(tr => (double?)tr.PaymentBed) ?? 0.0,
                            TotalPaymentBes = g.Sum(tr => (double?)tr.PaymentBes) ?? 0.0
                        })
                        .FirstOrDefault();

                    // ----------------------------------------------------------------
                    // 3. دریافت تراکنش‌های داخل دوره
                    // ----------------------------------------------------------------
                    var qCurrent =
                        from tr in accountFilter
                        join sp in db.SpecificAccounts on tr.SpecificAccountId equals sp.Id
                        join da in db.DetailedAccounts on tr.DetailedAccountId equals da.Id
                        join cu in db.Customers on da.CustomerId equals cu.Id
                        join tt in db.TransactionTypes on tr.TransactionTypeId equals tt.Id
                        join User in db.CustomerRoles on tr.UserId equals User.Id
                        join CuUser in db.Customers on User.Id equals CuUser.Id

                        where string.Compare(tr.TransactionDate, DateStart) >= 0
                           && string.Compare(tr.TransactionDate, DateEnd) <= 0
                           && (TransactionCodeS == 0 || tr.TransactionCode >= TransactionCodeS)
                           && (TransactionCodeE == 0 || tr.TransactionCode <= TransactionCodeE)

                        join coB in db.ComersBs on tr.ComerBId equals coB.Id into coBGroup
                        from coB_ in coBGroup.DefaultIfEmpty()

                        join coH in db.ComersHs on coB_.ComersHId equals coH.Id into coHGroup
                        from coH_ in coHGroup.DefaultIfEmpty()

                        orderby tr.Id

                        select new
                        {
                            tr.Id,
                            tr.Series,
                            tr.TransactionCode,
                            tr.TransactionDate,
                            TransactionType = tt.Name,
                            SpecificAccountName = sp.Name,
                            ContraAccountName = (cu.Family + " " + cu.Name).Trim(),
                            cu.CodMeli,
                            cu.Tel,
                            TotalAmount = tr.Amount,
                            tr.PaymentBed,
                            tr.PaymentBes,
                            tr.Description,
                            AccountCode = da.CodeAccount,
                            tr.IsAutoRejDoc,
                            ComerSeryal = tr.ComerBId == 0 ? 0 : (coH_ != null ? coH_.RemiaanceSeryal : 0),
                            User = CuUser.Family + " " + CuUser.Name,
                        };

                    // ----------------------------------------------------------------
                    // 4. ادغام مانده اول دوره + تراکنش‌ها
                    // ----------------------------------------------------------------

                    List<object> finalResult = new List<object>();

                    // --------------------
                    // ایجاد ردیف مانده اول دوره
                    // --------------------
                    double runningBalance = 0;

                    if (qBeginningBalance != null)
                    {
                        runningBalance = qBeginningBalance.TotalPaymentBed - qBeginningBalance.TotalPaymentBes;

                        var beginningBalanceRow = new
                        {
                            Id = 0,
                            Series = "",
                            TransactionCode = "",
                            TransactionDate = DateStart,
                            TransactionType = "مانده اول دوره",
                            SpecificAccountName = "",
                            ContraAccountName = "",
                            CodMeli = "",
                            Tel = "",
                            TotalAmount = 0.0,
                            PaymentBed = qBeginningBalance.TotalPaymentBed,
                            PaymentBes = qBeginningBalance.TotalPaymentBes,
                            Balance = runningBalance,   // 👈 مانده اول دوره
                            Description = "مانده حساب قبل از تاریخ " + DateStart,
                            AccountCode = "",
                            IsAutoRejDoc = false,
                            ComerSeryal = 0,
                            User = ""
                        };

                        finalResult.Add(beginningBalanceRow);
                    }

                    // --------------------
                    // افزودن تراکنش‌ها + محاسبه مانده هر ردیف
                    // --------------------
                    var currentList = qCurrent.ToList();

                    foreach (var item in currentList)
                    {
                        runningBalance += (item.PaymentBed - item.PaymentBes);

                        finalResult.Add(new
                        {
                            item.Id,
                            item.Series,
                            item.TransactionCode,
                            item.TransactionDate,
                            item.TransactionType,
                            item.SpecificAccountName,
                            item.ContraAccountName,
                            item.CodMeli,
                            item.Tel,
                            item.TotalAmount,
                            item.PaymentBed,
                            item.PaymentBes,
                            Balance = runningBalance,  // 👈 مانده بعد از هر تراکنش
                            item.Description,
                            item.AccountCode,
                            item.IsAutoRejDoc,
                            item.ComerSeryal,
                            item.User
                        });
                    }

                    // ----------------------------------------------------------------
                    // 5. اتصال به GridEX
                    // ----------------------------------------------------------------
                    gx.DataSource = finalResult;
                    SettingGridEX(gx);
                    return gx;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }


        public static GridExEx.GridExEx FilldgvListTransactionDA0(GridExEx.GridExEx gx, string DateStart, string DateEnd, IEnumerable<int> transactionTypeListIds, int? CustomerId = 0, int? TransactionCodeS = 0, int? TransactionCodeE = 0, int? SpecificAccountId = 0)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    // ----------------------------------------------------------------
                    // 1. تعریف فیلتر اصلی حساب‌ها (برای استفاده در هر دو کوئری)
                    // ----------------------------------------------------------------

                    var accountFilter = db.Transactions
                        .Where(tr => !tr.Status && transactionTypeListIds.Contains(tr.TransactionTypeId))
                        .Where(tr =>
                            (CustomerId != 0 && db.DetailedAccounts
                                                   .Where(da => da.CustomerId == CustomerId)
                                                   .Select(da => da.Id)
                                                   .Contains(tr.DetailedAccountId))
                            || (CustomerId == 0 && (SpecificAccountId == 0 || tr.SpecificAccountId == SpecificAccountId))
                        );

                    // ----------------------------------------------------------------
                    // 2. محاسبه مانده اول دوره (Beginning Balance)
                    // ----------------------------------------------------------------

                    var qBeginningBalance = accountFilter
                        .Where(tr => string.Compare(tr.TransactionDate, DateStart) < 0)
                        .GroupBy(tr => 1)
                        .Select(g => new
                        {
                            TotalPaymentBed = g.Sum(tr => (double?)tr.PaymentBed) ?? 0.0,
                            TotalPaymentBes = g.Sum(tr => (double?)tr.PaymentBes) ?? 0.0
                        })
                        .FirstOrDefault();

                    // ----------------------------------------------------------------
                    // 3. کوئری تراکنش‌های داخل دوره (Current Transactions)
                    // ----------------------------------------------------------------

                    var qCurrent = from tr in accountFilter
                                   join sp in db.SpecificAccounts on tr.SpecificAccountId equals sp.Id
                                   join da in db.DetailedAccounts on tr.DetailedAccountId equals da.Id
                                   join ta in db.TotalAccounts on sp.Id_TotalAccount equals ta.Id
                                   join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                                   join cu in db.Customers on da.CustomerId equals cu.Id
                                   join tt in db.TransactionTypes on tr.TransactionTypeId equals tt.Id
                                   join User in db.CustomerRoles on tr.UserId equals User.Id
                                   join CuUser in db.Customers on User.Id equals CuUser.Id

                                   where string.Compare(tr.TransactionDate, DateStart) >= 0
                                   && string.Compare(tr.TransactionDate, DateEnd) <= 0
                                   && (TransactionCodeS == 0 || tr.TransactionCode >= TransactionCodeS)
                                   && (TransactionCodeE == 0 || tr.TransactionCode <= TransactionCodeE)

                                   join coB in db.ComersBs on tr.ComerBId equals coB.Id into coBGroup
                                   from coB_ in coBGroup.DefaultIfEmpty()

                                   join coH in db.ComersHs on coB_.ComersHId equals coH.Id into coHGroup
                                   from coH_ in coHGroup.DefaultIfEmpty()

                                   orderby tr.Id

                                   select new
                                   {
                                       Id = tr.DetailedAccountId,
                                       tr.Series,
                                       tr.TransactionCode,
                                       tr.TransactionDate,
                                       TransactionType = tt.Name,
                                       SpecificAccountName = sp.Name,
                                       ContraAccountName = (cu.Family + " " + cu.Name).Trim(),
                                       cu.CodMeli,
                                       cu.Tel,
                                       TotalAmount = tr.Amount,
                                       tr.PaymentBed,
                                       tr.PaymentBes,
                                       tr.Description,
                                       AccountCode = da.CodeAccount,
                                       tr.IsAutoRejDoc,
                                       ComerSeryal = tr.ComerBId == 0 ? 0 : (coH_ != null ? coH_.RemiaanceSeryal : 0),
                                       User = CuUser.Family + " " + CuUser.Name,
                                   };

                    // ----------------------------------------------------------------
                    // 4. ایجاد سطر مانده اول دوره و ادغام با تراکنش‌های جاری
                    // ----------------------------------------------------------------

                    List<object> finalResult = new List<object>();

                    if (qBeginningBalance != null)
                    {
                        var beginningBalanceRow = new
                        {
                            Id = 0,
                            Series = "",
                            TransactionCode = "",
                            TransactionDate = DateStart,
                            TransactionType = "مانده اول دوره",
                            SpecificAccountName = string.Empty,
                            ContraAccountName = string.Empty,
                            TotalAmount = 0.0,
                            PaymentBed = qBeginningBalance.TotalPaymentBed,
                            PaymentBes = qBeginningBalance.TotalPaymentBes,
                            Description = "مانده حساب قبل از تاریخ " + DateStart,
                            AccountCode = "",
                            IsAutoRejDoc = false,
                            ComerSeryal = 0,
                            User = "",
                        };

                        finalResult.Add(beginningBalanceRow);
                    }

                    finalResult.AddRange(qCurrent.ToList());

                    // ----------------------------------------------------------------
                    // 5. اتصال به GridEX
                    // ----------------------------------------------------------------

                    gx.DataSource = finalResult;
                    SettingGridEX(gx);
                    return gx;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }
        public static GridExEx.GridExEx FilldgvListTransactionDA(GridExEx.GridExEx gx, string DateStart, string DateEnd, IEnumerable<int> transactionTypeListIds, int? CustomerId = 0, int? TransactionCodeS = 0, int? TransactionCodeE = 0, int? SpecificAccountId = 0)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    // ----------------------------------------------------------------
                    // 1. تعریف فیلتر اصلی حساب‌ها
                    // ----------------------------------------------------------------

                    var accountFilter = db.Transactions
                        .Where(tr => !tr.Status && transactionTypeListIds.Contains(tr.TransactionTypeId))
                        .Where(tr =>
                            (CustomerId != 0 && db.DetailedAccounts
                                                       .Where(da => da.CustomerId == CustomerId)
                                                       .Select(da => da.Id)
                                                       .Contains(tr.DetailedAccountId))
                            || (CustomerId == 0 && (SpecificAccountId == 0 || tr.SpecificAccountId == SpecificAccountId))
                        );

                    // ----------------------------------------------------------------
                    // 2. محاسبه مانده اول دوره
                    // ----------------------------------------------------------------

                    var qBeginningBalance = accountFilter
                        .Where(tr => string.Compare(tr.TransactionDate, DateStart) < 0)
                        .GroupBy(tr => 1)
                        .Select(g => new
                        {
                            TotalPaymentBed = g.Sum(tr => (double?)tr.PaymentBed) ?? 0.0,
                            TotalPaymentBes = g.Sum(tr => (double?)tr.PaymentBes) ?? 0.0
                        })
                        .FirstOrDefault();

                    // ----------------------------------------------------------------
                    // 3. تراکنش‌های داخل دوره
                    // ----------------------------------------------------------------

                    var qCurrent =
                        from tr in accountFilter
                        join sp in db.SpecificAccounts on tr.SpecificAccountId equals sp.Id
                        join da in db.DetailedAccounts on tr.DetailedAccountId equals da.Id
                        join ta in db.TotalAccounts on sp.Id_TotalAccount equals ta.Id
                        join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                        join cu in db.Customers on da.CustomerId equals cu.Id
                        join tt in db.TransactionTypes on tr.TransactionTypeId equals tt.Id
                        join User in db.CustomerRoles on tr.UserId equals User.Id
                        join CuUser in db.Customers on User.Id equals CuUser.Id

                        where string.Compare(tr.TransactionDate, DateStart) >= 0
                           && string.Compare(tr.TransactionDate, DateEnd) <= 0
                           && (TransactionCodeS == 0 || tr.TransactionCode >= TransactionCodeS)
                           && (TransactionCodeE == 0 || tr.TransactionCode <= TransactionCodeE)

                        join coB in db.ComersBs on tr.ComerBId equals coB.Id into coBGroup
                        from coB_ in coBGroup.DefaultIfEmpty()

                        join coH in db.ComersHs on coB_.ComersHId equals coH.Id into coHGroup
                        from coH_ in coHGroup.DefaultIfEmpty()

                        orderby tr.Id

                        select new
                        {
                            ga.IdMahiyat,
                            tr.Id,
                            tr.Series,
                            tr.TransactionCode,
                            tr.TransactionDate,
                            TransactionType = tt.Name,
                            SpecificAccountName = sp.Name,
                            ContraAccountName = (cu.Family + " " + cu.Name).Trim(),
                            cu.CodMeli,
                            cu.Tel,
                            TotalAmount = tr.Amount,
                            tr.PaymentBed,
                            tr.PaymentBes,
                            tr.Description,
                            AccountCode = da.CodeAccount,
                            tr.IsAutoRejDoc,
                            ComerSeryal = tr.ComerBId == 0 ? 0 : (coH_ != null ? coH_.RemiaanceSeryal : 0),
                            User = CuUser.Family + " " + CuUser.Name,
                        };

                    // ----------------------------------------------------------------
                    // 4. ترکیب مانده اول دوره + تراکنش‌ها با محاسبه Balance
                    // ----------------------------------------------------------------

                    List<object> finalResult = new List<object>();

                    double runningBalance = 0;

                    // --- ردیف مانده اول دوره ---
                    if (qBeginningBalance != null)
                    {
                        runningBalance = qBeginningBalance.TotalPaymentBed - qBeginningBalance.TotalPaymentBes;

                        finalResult.Add(new
                        {
                            Id = 0,
                            Series = "",
                            TransactionCode = "",
                            TransactionDate = DateStart,
                            TransactionType = "مانده اول دوره",
                            SpecificAccountName = "",
                            ContraAccountName = "",
                            CodMeli = "",
                            Tel = "",
                            TotalAmount = 0.0,
                            PaymentBed = qBeginningBalance.TotalPaymentBed,
                            PaymentBes = qBeginningBalance.TotalPaymentBes,
                            Balance = runningBalance,     // 👈 مانده اول دوره
                            Description = "مانده قبل از " + DateStart,
                            AccountCode = "",
                            IsAutoRejDoc = false,
                            ComerSeryal = 0,
                            User = ""
                        });
                    }

                    // --- محاسبه مانده هر ردیف ---
                    var currentList = qCurrent.ToList();

                    foreach (var item in currentList)
                    {
                        // محاسبه مانده بر اساس ماهیت حساب
                        if (item.IdMahiyat == 1) // بدهکاران
                        {
                            runningBalance += (item.PaymentBed - item.PaymentBes);
                        }
                        else if (item.IdMahiyat == 2) // بستانکاران
                        {
                            runningBalance += (item.PaymentBes + item.PaymentBed);
                        }
                        else
                        {
                            // اگر ماهیت تعریف نشده بود، حالت پیش‌فرض
                            runningBalance += (item.PaymentBed - item.PaymentBes);
                        }

                        finalResult.Add(new
                        {
                            item.Id,
                            item.Series,
                            item.TransactionCode,
                            item.TransactionDate,
                            item.TransactionType,
                            item.SpecificAccountName,
                            item.ContraAccountName,
                            item.CodMeli,
                            item.Tel,
                            item.TotalAmount,
                            item.PaymentBed,
                            item.PaymentBes,
                            Balance = runningBalance,    // 👈 مانده پس از اعمال قانون جدید
                            item.Description,
                            item.AccountCode,
                            item.IsAutoRejDoc,
                            item.ComerSeryal,
                            item.User
                        });
                    }

                    // ----------------------------------------------------------------
                    // 5. اتصال به GridEX
                    // ----------------------------------------------------------------
                    gx.DataSource = finalResult;
                    SettingGridEX(gx);
                    return gx;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }




        /// <summary>
        ///  نمایش اطلاعات در جدول درآمد/هزینه و دریافت/پرداخت و جابجایی ها
        /// </summary>
        /// <param name="gx">جدول دیتاگرید</param>
        /// <param name="DateStart">تاریخ شروع</param>
        /// <param name="DateEnd">تاریخ پایان</param>
        /// <param name="TransactionCode">شماره سند (اختیاری) می باشد</param>
        /// <returns></returns>
        public static GridExEx.GridExEx FilldgvListTransaction(GridExEx.GridExEx gx, string DateStart, string DateEnd, int? TransactionCode = 0)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = from tr in db.Transactions
                            join sp in db.SpecificAccounts on tr.SpecificAccountId equals sp.Id
                            join da in db.DetailedAccounts on tr.DetailedAccountId equals da.Id
                            join cu in db.Customers on da.CustomerId equals cu.Id
                            join tt in db.TransactionTypes on tr.TransactionTypeId equals tt.Id


                            join User in db.CustomerRoles on tr.UserId equals User.Id
                            join CuUser in db.Customers on User.Id equals CuUser.Id


                            join coB in db.ComersBs
                            on tr.ComerBId equals coB.Id into coBGroup
                            from coB_ in coBGroup.DefaultIfEmpty()

                            join coH in db.ComersHs
                            on coB_.ComersHId equals coH.Id into coHGroup
                            from coH_ in coHGroup.DefaultIfEmpty()

                            where !tr.Status
                            && string.Compare(tr.TransactionDate, DateStart) >= 0
                            && string.Compare(tr.TransactionDate, DateEnd) <= 0
                            // ✨ شرط کد تراکنش
                            && (TransactionCode == 0 || tr.TransactionCode == TransactionCode)
                            orderby tr.Id
                            select new
                            {
                                tr.Id,
                                tr.Series,
                                tr.TransactionCode,
                                tr.TransactionDate,
                                TransactionType = tt.Name,
                                SpecificAccountName = sp.Name,
                                ContraAccountName = (cu.Family + " " + cu.Name).Trim(),
                                TotalAmount = tr.Amount,
                                User = CuUser.Family + " " + CuUser.Name,
                                tr.PaymentBed,
                                tr.PaymentBes,
                                tr.Description,
                                AccountCode = da.CodeAccount,
                                tr.IsAutoRejDoc,
                                ComerSeryal = tr.ComerBId == 0 ? 0 : (coH_ != null ? coH_.RemiaanceSeryal : 0)
                            };

                    gx.DataSource = q.ToList();
                    SettingGridEX(gx);
                    return gx;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }



        /// <summary>
        /// تنطیمات عمومی دیتاگرید جانوس
        /// </summary>
        /// <param name="GX"></param>
        /// <returns></returns>
        public static GridExEx.GridExEx SettingGridEX(GridExEx.GridExEx GX, string formName = null)
        {
            try
            {
                GX.AllowRemoveColumns = InheritableBoolean.True;
                GX.RowHeaders = InheritableBoolean.True;
                GX.RowHeaderContent = RowHeaderContent.RowIndex;
                GX.RootTable.RowHeaderWidth = 60;
                GX.RootTable.RowHeaderFormatStyle.TextAlignment = TextAlignment.Center;

                GX.RootTable.Columns["Id"].Selectable = false;
                GX.RootTable.Columns["Id"].ShowInFieldChooser = false;

                if (GX.RootTable.Columns.Contains("Select"))
                {
                    GX.RootTable.Columns["Select"].Selectable = false;
                    GX.RootTable.Columns["Select"].ShowInFieldChooser = false;
                    GX.RootTable.Columns["Select"].AllowRemove = InheritableBoolean.False;
                }

                if (GX.RootTable.Columns.Contains("Edit"))
                {
                    GX.RootTable.Columns["Edit"].Selectable = false;
                    GX.RootTable.Columns["Edit"].ShowInFieldChooser = false;
                    GX.RootTable.Columns["Edit"].AllowRemove = InheritableBoolean.False;
                }

                if (GX.RootTable.Columns.Contains("Delete"))
                {
                    GX.RootTable.Columns["Delete"].Selectable = false;
                    GX.RootTable.Columns["Delete"].ShowInFieldChooser = false;
                    GX.RootTable.Columns["Delete"].AllowRemove = InheritableBoolean.False;
                }

                if (GX.RootTable.Columns.Contains("Details"))
                {
                    GX.RootTable.Columns["Details"].Selectable = false;
                    GX.RootTable.Columns["Details"].ShowInFieldChooser = false;
                    GX.RootTable.Columns["Details"].AllowRemove = InheritableBoolean.False;
                }

                GX.SaveSettings = true;
                GX.SettingsKey = formName;

                foreach (GridEXColumn column in GX.RootTable.Columns)
                {
                    column.HeaderStyle.TextAlignment = TextAlignment.Center;
                    if (column.Tag == null)
                        column.CellStyle.TextAlignment = TextAlignment.Center;
                    else
                        column.CellStyle.TextAlignment = TextAlignment.Near;

                    //if (column.Tag==null)
                    //    column.CellStyle.TextAlignment=TextAlignment.Center;

                }
                GX.AutoSizeColumns();
                return GX;

            }
            catch (Exception er)
            {
                //PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

        /// <summary>
        /// محاسبه مانده حساب های معین
        /// </summary>
        /// <param name="SpecificAccountId"></param>
        /// <returns></returns>
        public static double SpecificAccountsBalance(int SpecificAccountId)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    double bed = 0;
                    double bes = 0;
                    var q = db.Transactions.Where(c => c.SpecificAccountId == SpecificAccountId && !c.Status);

                    var NatureAccount_Id = db.GroupAccounts.Where(c => c.Id == db.TotalAccounts.Where(x => x.Id == db.SpecificAccounts.Where(z => z.Id == SpecificAccountId).FirstOrDefault().Id_TotalAccount).FirstOrDefault().Id_GroupAccount).First().IdMahiyat;

                    if (q.Count() != 0)
                    {
                        bed = q.Sum(c => c.PaymentBed);
                        bes = q.Sum(c => c.PaymentBes);
                    }
                    if (NatureAccount_Id == 2)
                        return (bes - bed);
                    else
                        return (bed - bes);
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }

        /// <summary>
        /// مخاسبه مانده حساب های تفصیلی
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static double DetailedAccountsBalance(int SpecificAccountId, int DetailedAccountId)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    double bed = 0;
                    double bes = 0;

                    var q = db.Transactions.Where(c => c.SpecificAccountId == SpecificAccountId && c.DetailedAccountId == DetailedAccountId && c.FinancialYear == FinancialYear && !c.Status);

                    var NatureAccount_Id = db.GroupAccounts.Where(c => c.Id == db.TotalAccounts.Where(x => x.Id == db.SpecificAccounts.Where(z => z.Id == SpecificAccountId).FirstOrDefault().Id_TotalAccount).FirstOrDefault().Id_GroupAccount).First().IdMahiyat;

                    //مانده ابتدای دوره
                    var BeginningBanace = db.DetailedAccounts.Where(c => c.Id == DetailedAccountId).First();

                    //if (BeginningBanace.NatureAccountsId==2)
                    //    bes=BeginningBanace.BeginningBanace;
                    //else
                    //    bed=BeginningBanace.BeginningBanace;

                    if (q.Count() != 0)
                    {
                        bed += q.Sum(c => c.PaymentBed);
                        bes += q.Sum(c => c.PaymentBes);
                    }

                    if (NatureAccount_Id == 2)
                        return (bes - bed);
                    else
                        return (bed - bes);
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }

        }


        public static System.Data.DataTable GetCustomerDetailedAccountsChildTable(int customerId, string financialYear, string dateS, string dateE, int? transactionCodeS, int? transactionCodeE)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    // 1. فیلترینگ تراکنش‌ها (همانند تابع والد)
                    var transactionsQuery = db.Transactions
                                             .Where(t => t.FinancialYear == financialYear && !t.Status);

                    transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(dateS) >= 0 &&
                                                                     t.TransactionDate.CompareTo(dateE) <= 0);

                    if (transactionCodeS.HasValue && transactionCodeS.Value != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= transactionCodeS.Value);
                    }

                    if (transactionCodeE.HasValue && transactionCodeE.Value != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= transactionCodeE.Value);
                    }

                    var filteredTransactions = transactionsQuery;

                    // 2. کوئری LINQ: محاسبه مانده و گردش تفصیلی‌ها برای یک CustomerId خاص
                    var q = from da in db.DetailedAccounts

                                // فیلتر اصلی: فقط تفصیلی‌های مربوط به مشتری فعلی
                            where da.CustomerId == customerId

                            // Join با حساب‌های بالادستی
                            join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id
                            join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                            join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                            join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                            // Left Join با تراکنش‌های فیلترشده
                            join tr in filteredTransactions
                            on da.Id equals tr.DetailedAccountId
                            into trGroup

                            // 3. محاسبه گردش‌ها
                            let DebitTurnover = trGroup.Sum(t => (double?)t.PaymentBed) ?? 0.0
                            let CreditTurnover = trGroup.Sum(t => (double?)t.PaymentBes) ?? 0.0

                            // 4. محاسبه مانده نهایی با لحاظ کردن مانده اول دوره
                            // (توجه: از ماهیت حساب تفصیلی da.NatureAccountsId استفاده شده است)
                            let EndingBalance = DebitTurnover - CreditTurnover

                            // 5. فیلتر کردن تفصیلی‌های با مانده/گردش صفر
                            where Math.Abs(EndingBalance) != 0 || Math.Abs(DebitTurnover) != 0 || Math.Abs(CreditTurnover) != 0

                            select new
                            {
                                // فیلد کلیدی برای ارتباط با والد (CustomerId)
                                CustomerId = da.CustomerId,

                                // جزئیات تفصیلی
                                DetailedAccountId = da.Id,
                                AccountCode = da.CodeAccount,
                                SpecificAccountName = sa.Name,
                                TotalAccountName = ta.Name,
                                NatureAccountName = na.Name,

                                DebitTurnover = DebitTurnover,
                                CreditTurnover = CreditTurnover,

                                DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                            };

                    // 6. تبدیل نتیجه به DataTable
                    return PublicClass.AddEntityTableToDataTable(q.ToList());
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

        /// <summary>
        /// صورت حساب معین بصورت درختی
        /// </summary>
        /// <param name="DateS"></param>
        /// <param name="DateE"></param>
        /// <param name="TransactionCodeS"></param>
        /// <param name="TransactionCodeE"></param>
        /// <returns></returns>
        public static DataSet SpecificAccountTransactionsTree_(string DateS, string DateE, int? TransactionCodeS = 0, int? TransactionCodeE = 0)
        {
            try
            {
                DataSet ds = new DataSet();
                System.Data.DataTable dtSpecificAccounts = new System.Data.DataTable("SpecificAccounts");
                System.Data.DataTable dtDetailedAccounts = new System.Data.DataTable("DetailedAccounts");

                ds.Tables.Add(dtSpecificAccounts);
                ds.Tables.Add(dtDetailedAccounts);

                using (var db = new DBcontextModel())
                {
                    string FinancialYear = PublicClass.FinancialYear;
                    var transactionsQuery = db.Transactions
                        .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                    transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                    if (TransactionCodeS != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS);
                    }

                    if (TransactionCodeE != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE);
                    }

                    var filteredTransactions = transactionsQuery;
                    if (filteredTransactions.Count() == 0)
                    {
                        return null;
                    }
                    var qSpecific = from da in db.DetailedAccounts
                                    join tr in filteredTransactions on da.Id equals tr.DetailedAccountId into trGroup
                                    group new { da, trGroup } by da.SpecificAccountId into g
                                    join sa in db.SpecificAccounts on g.Key equals sa.Id
                                    join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                                    join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                                    join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                                    let DebitTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                    let CreditTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0
                                    let BeginningBanaceSum = 0
                                    let NatureAccountsId = ga.IdMahiyat
                                    let BeginningBanaceAdjusted = BeginningBanaceSum * (NatureAccountsId == 2 ? -1 : 1)
                                    let EndingBalance = BeginningBanaceAdjusted + DebitTurnoverSum - CreditTurnoverSum
                                    //where ga.Id==1 || ga.Id==3
                                    where Math.Abs(EndingBalance) != 0 || Math.Abs(DebitTurnoverSum) != 0 || Math.Abs(CreditTurnoverSum) != 0
                                    select new
                                    {
                                        Id = sa.Id,
                                        sa.Name,
                                        Code = sa.Cod,
                                        DebitTurnover = DebitTurnoverSum,
                                        CreditTurnover = CreditTurnoverSum,
                                        DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                        CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                                    };


                    dtSpecificAccounts = PublicClass.EntityTableToDataTable(qSpecific.ToList(), "SpecificAccounts");
                    ds.Tables.Remove("SpecificAccounts");
                    ds.Tables.Add(dtSpecificAccounts);

                    var specificAccountIds = qSpecific.Select(s => s.Id).ToList();

                    // ----------------------------------------------------------------
                    // B. کوئری جدول فرزند (DetailedAccounts) - تغییر یافته
                    // ----------------------------------------------------------------
                    var qDetailed = from da in db.DetailedAccounts

                                    join tr in filteredTransactions on da.Id equals tr.DetailedAccountId into trGroup
                                    join cu in db.Customers on da.CustomerId equals cu.Id

                                    where specificAccountIds.Contains(da.SpecificAccountId)

                                    group new { da, cu, trGroup } by new { da.SpecificAccountId, da.Id, da.CodeAccount, cu.Name, cu.Family, Id_ = cu.Id } into g

                                    let DebitTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                    let CreditTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0

                                    let BeginningBanaceSumD = 0.0

                                    let EndingBalanceD = BeginningBanaceSumD + DebitTurnoverSumD - CreditTurnoverSumD

                                    // ❌ شرط فیلتر جدید: حذف تفصیلی‌های با گردش و مانده صفر 
                                    where Math.Abs(EndingBalanceD) != 0 || Math.Abs(DebitTurnoverSumD) != 0 || Math.Abs(CreditTurnoverSumD) != 0

                                    select new
                                    {
                                        ParentSpecificAccountId = g.Key.SpecificAccountId, // 👈 تغییر نام برای وضوح رابطه
                                        Id = g.Key.Id,
                                        CustomerName = g.Key.Name,
                                        Code = g.Key.CodeAccount,
                                        Name = g.Key.Family + " " + g.Key.Name,
                                        DebitTurnover = DebitTurnoverSumD,
                                        CreditTurnover = CreditTurnoverSumD,
                                        DebitBalance = EndingBalanceD > 0 ? EndingBalanceD : 0.0,
                                        CreditBalance = EndingBalanceD < 0 ? Math.Abs(EndingBalanceD) : 0.0,
                                    };

                    dtDetailedAccounts = PublicClass.EntityTableToDataTable(qDetailed.ToList(), "DetailedAccounts");
                    ds.Tables.Remove("DetailedAccounts");
                    ds.Tables.Add(dtDetailedAccounts);
                }

                // ----------------------------------------------------------------
                // C. برقراری DataRelation (بدون تغییر)
                // ----------------------------------------------------------------
                DataColumn parentCol = ds.Tables["SpecificAccounts"].Columns["Id"];
                // ⚠️ توجه: نام ستون کلید خارجی در جدول Child را به ParentSpecificAccountId تغییر دادم تا با کوئری بالا سازگار باشد
                DataColumn childCol = ds.Tables["DetailedAccounts"].Columns["ParentSpecificAccountId"];

                DataRelation relation = new DataRelation("SpecificToDetailed", parentCol, childCol, false);
                ds.Relations.Add(relation);
                return ds;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

        public static DataSet SpecificAccountTransactionsTree(
    string DateS,
    string DateE,
    int? TransactionCodeS = 0,
    int? TransactionCodeE = 0,
    bool ShowZeroBalance = false, // 👈 پارامتر جدید برای کنترل مانده صفر در کوئری
    bool? IsBeginningBalanceFilter = null) // 👈 پارامتر جدید برای کنترل فیلتر مانده اول دوره
        {
            try
            {
                DataSet ds = new DataSet();
                System.Data.DataTable dtSpecificAccounts = new System.Data.DataTable("SpecificAccounts");
                System.Data.DataTable dtDetailedAccounts = new System.Data.DataTable("DetailedAccounts");

                ds.Tables.Add(dtSpecificAccounts);
                ds.Tables.Add(dtDetailedAccounts);

                using (var db = new DBcontextModel())
                {
                    string FinancialYear = PublicClass.FinancialYear;
                    var transactionsQuery = db.Transactions
                        .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                    transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                    if (TransactionCodeS != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS);
                    }

                    if (TransactionCodeE != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE);
                    }

                    // 🎯 اعمال فیلتر IsBeginningBalance
                    if (IsBeginningBalanceFilter.HasValue)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.IsBeginningBalance == IsBeginningBalanceFilter.Value);
                    }

                    var filteredTransactions = transactionsQuery;
                    if (filteredTransactions.Count() == 0)
                    {
                        return null;
                    }

                    // ----------------------------------------------------------------
                    // A. کوئری جدول والد (SpecificAccounts)
                    // ----------------------------------------------------------------
                    var qSpecific = from da in db.DetailedAccounts
                                    join tr in filteredTransactions on da.Id equals tr.DetailedAccountId into trGroup
                                    group new { da, trGroup } by da.SpecificAccountId into g
                                    join sa in db.SpecificAccounts on g.Key equals sa.Id
                                    join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                                    join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                                    join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                                    let DebitTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                    let CreditTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0
                                    let BeginningBanaceSum = 0
                                    let NatureAccountsId = ga.IdMahiyat
                                    let BeginningBanaceAdjusted = BeginningBanaceSum * (NatureAccountsId == 2 ? -1 : 1)
                                    let EndingBalance = BeginningBanaceAdjusted + DebitTurnoverSum - CreditTurnoverSum

                                    // 🎯 اعمال فیلتر مانده صفر برای SpecificAccounts
                                    where ShowZeroBalance ||
                                          (Math.Abs(EndingBalance) != 0 || Math.Abs(DebitTurnoverSum) != 0 || Math.Abs(CreditTurnoverSum) != 0)

                                    select new
                                    {
                                        Id = sa.Id,
                                        sa.Name,
                                        Code = sa.Cod,
                                        DebitTurnover = DebitTurnoverSum,
                                        CreditTurnover = CreditTurnoverSum,
                                        DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                        CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                                    };

                    dtSpecificAccounts = PublicClass.EntityTableToDataTable(qSpecific.ToList(), "SpecificAccounts");
                    ds.Tables.Remove("SpecificAccounts");
                    ds.Tables.Add(dtSpecificAccounts);

                    var specificAccountIds = qSpecific.Select(s => s.Id).ToList();

                    // ----------------------------------------------------------------
                    // B. کوئری جدول فرزند (DetailedAccounts)
                    // ----------------------------------------------------------------
                    var qDetailed = from da in db.DetailedAccounts

                                    join tr in filteredTransactions on da.Id equals tr.DetailedAccountId into trGroup
                                    join cu in db.Customers on da.CustomerId equals cu.Id

                                    where specificAccountIds.Contains(da.SpecificAccountId)

                                    group new { da, cu, trGroup } by new { da.SpecificAccountId, da.Id, da.CodeAccount, cu.Name, cu.Family, Id_ = cu.Id } into g

                                    let DebitTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                    let CreditTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0

                                    let BeginningBanaceSumD = 0.0

                                    let EndingBalanceD = BeginningBanaceSumD + DebitTurnoverSumD - CreditTurnoverSumD

                                    // 🎯 اعمال فیلتر مانده صفر برای DetailedAccounts
                                    where ShowZeroBalance ||
                                          (Math.Abs(EndingBalanceD) != 0 || Math.Abs(DebitTurnoverSumD) != 0 || Math.Abs(CreditTurnoverSumD) != 0)

                                    select new
                                    {
                                        ParentSpecificAccountId = g.Key.SpecificAccountId,
                                        Id = g.Key.Id,
                                        CustomerName = g.Key.Name,
                                        Code = g.Key.CodeAccount,
                                        Name = g.Key.Family + " " + g.Key.Name,
                                        DebitTurnover = DebitTurnoverSumD,
                                        CreditTurnover = CreditTurnoverSumD,
                                        DebitBalance = EndingBalanceD > 0 ? EndingBalanceD : 0.0,
                                        CreditBalance = EndingBalanceD < 0 ? Math.Abs(EndingBalanceD) : 0.0,
                                    };

                    dtDetailedAccounts = PublicClass.EntityTableToDataTable(qDetailed.ToList(), "DetailedAccounts");
                    ds.Tables.Remove("DetailedAccounts");
                    ds.Tables.Add(dtDetailedAccounts);
                }

                // ----------------------------------------------------------------
                // C. برقراری DataRelation 
                // ----------------------------------------------------------------
                DataColumn parentCol = ds.Tables["SpecificAccounts"].Columns["Id"];
                DataColumn childCol = ds.Tables["DetailedAccounts"].Columns["ParentSpecificAccountId"];

                DataRelation relation = new DataRelation("SpecificToDetailed", parentCol, childCol, false);
                ds.Relations.Add(relation);
                return ds;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }


        public static System.Data.DataTable EntityTableToDataTable<T>(List<T> items, string tableName = "Data")
        {
            try
            {
                System.Data.DataTable dt = new System.Data.DataTable(tableName);

                if (items == null || items.Count == 0)
                    return dt;

                // ایجاد reader بسیار سریع از لیست
                using (var reader = ObjectReader.Create(items))
                {
                    dt.Load(reader);
                }

                return dt;
            }
            catch (Exception ex)
            {
                PublicClass.ShowErrorMessage(ex);
                return null;
            }
        }

        /// <summary>
        /// صورتحساب تفصیلی
        /// </summary>
        /// <param name="GX"></param>
        /// <returns></returns>
        public static GridExEx.GridExEx DetailedAccountTransactions(GridExEx.GridExEx GX, string DateS, string DateE, int? TransactionCodeS = 0, int? TransactionCodeE = 0)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    string FinancialYear = PublicClass.FinancialYear;
                    var transactionsQuery = db.Transactions
                                             .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                    transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                    if (TransactionCodeS != null && TransactionCodeS.Value != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS.Value);
                    }

                    if (TransactionCodeE != null && TransactionCodeE.Value != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE.Value);
                    }

                    var filteredTransactions = transactionsQuery;

                    var q = from da in db.DetailedAccounts
                            join cu in db.Customers on da.CustomerId equals cu.Id
                            join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id
                            join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                            join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                            join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                            join tr in filteredTransactions
                            on da.Id equals tr.DetailedAccountId
                            into trGroup

                            group new { da, trGroup, sa, ta, ga, na, cu } by cu.Id into g

                            let CustomerData = g.FirstOrDefault()
                            let CustomerName = (CustomerData.cu.Family + " " + CustomerData.cu.Name).Trim()
                            let CustomerCode = CustomerData.cu.Id

                            let DebitTurnoverSum = g.SelectMany(x => x.trGroup)
                                                    .Sum(t => (double?)t.PaymentBed) ?? 0.0

                            let CreditTurnoverSum = g.SelectMany(x => x.trGroup)
                                                     .Sum(t => (double?)t.PaymentBes) ?? 0.0
                            let EndingBalance = DebitTurnoverSum - CreditTurnoverSum
                            where Math.Abs(EndingBalance) != 0 || Math.Abs(DebitTurnoverSum) != 0 || Math.Abs(CreditTurnoverSum) != 0

                            select new
                            {
                                GroupAccountName = string.Empty,
                                TotalAccountName = string.Empty,
                                SpecificAccountName = string.Empty,
                                Id = CustomerData.cu.Id,
                                Name = CustomerName,
                                Code = CustomerCode,
                                DebitTurnover = DebitTurnoverSum,
                                CreditTurnover = CreditTurnoverSum,
                                DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                            };

                    GX.DataSource = q.ToList();
                    return GX;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }


        public static DataSet DetailedAccountTransactionsTree_(string DateS, string DateE, int? TransactionCodeS = 0, int? TransactionCodeE = 0)
        {
            DataSet ds = new DataSet("AccountingDataSet");

            using (var db = new DBcontextModel())
            {
                string FinancialYear = PublicClass.FinancialYear;

                var transactionsQuery = db.Transactions
                                         .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                if (TransactionCodeS != null && TransactionCodeS.Value != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS.Value);
                }

                if (TransactionCodeE != null && TransactionCodeE.Value != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE.Value);
                }
                if (transactionsQuery.Count() == 0) return null;
                var filteredTransactions = transactionsQuery;

                var qCustomers = from da in db.DetailedAccounts
                                 join cu in db.Customers on da.CustomerId equals cu.Id
                                 join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id
                                 join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                                 join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                                 join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                                 join tr in filteredTransactions
                                 on da.Id equals tr.DetailedAccountId
                                 into trGroup
                                 where ga.Id == 1 || ga.Id == 2 || ga.Id == 3 || ga.Id == 4 || ga.Id == 5

                                 group new { da, trGroup, sa, ta, ga, na, cu } by cu.Id into g

                                 let CustomerData = g.FirstOrDefault()
                                 let CustomerName = (CustomerData.cu.Family + " " + CustomerData.cu.Name).Trim()
                                 let CustomerCode = CustomerData.cu.Id

                                 let DebitTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                 let CreditTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0
                                 let EndingBalance = DebitTurnoverSum - CreditTurnoverSum


                                 //where Math.Abs(EndingBalance) != 0 || Math.Abs(DebitTurnoverSum) != 0 || Math.Abs(CreditTurnoverSum) != 0

                                 select new
                                 {
                                     Id = g.Key,
                                     Name = CustomerName,
                                     Code = CustomerCode,
                                     DebitTurnover = DebitTurnoverSum,
                                     CreditTurnover = CreditTurnoverSum,
                                     DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                     CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                                 };

                var customerIds = qCustomers.Select(c => c.Id).ToList();

                var qDetailed = from da in db.DetailedAccounts
                                join tr in filteredTransactions on da.Id equals tr.DetailedAccountId into trGroup
                                join cu in db.Customers on da.CustomerId equals cu.Id
                                join sp in db.SpecificAccounts on da.SpecificAccountId equals sp.Id
                                where customerIds.Contains(da.CustomerId)

                                group new { da, sp, trGroup } by new { da.Id, da.SpecificAccountId, da.CodeAccount, da.CustomerId, sp.Name } into g

                                let DebitTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                let CreditTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0
                                let EndingBalanceD = DebitTurnoverSumD - CreditTurnoverSumD

                                where Math.Abs(EndingBalanceD) != 0 || Math.Abs(DebitTurnoverSumD) != 0 || Math.Abs(CreditTurnoverSumD) != 0

                                select new
                                {
                                    ParentCustomerId = g.Key.CustomerId,
                                    Id = g.Key.Id,
                                    Code = g.Key.CodeAccount,
                                    Name = g.Key.Name,
                                    DebitTurnover = DebitTurnoverSumD,
                                    CreditTurnover = CreditTurnoverSumD,
                                    DebitBalance = EndingBalanceD > 0 ? EndingBalanceD : 0.0,
                                    CreditBalance = EndingBalanceD < 0 ? Math.Abs(EndingBalanceD) : 0.0,
                                };

                System.Data.DataTable dtCustomers = PublicClass.EntityTableToDataTable(qCustomers.ToList(), "Customers");
                ds.Tables.Add(dtCustomers);

                System.Data.DataTable dtDetailedAccounts = PublicClass.EntityTableToDataTable(qDetailed.ToList(), "DetailedAccounts");
                ds.Tables.Add(dtDetailedAccounts);
            }
            DataColumn parentCol = ds.Tables["Customers"].Columns["Id"];

            DataColumn childCol = ds.Tables["DetailedAccounts"].Columns["ParentCustomerId"];

            DataRelation relation = new DataRelation("CustomerToDetailed", parentCol, childCol, false);
            ds.Relations.Add(relation);

            return ds;
        }

        public static DataSet DetailedAccountTransactionsTree__(
    string DateS,
    string DateE,
    int? TransactionCodeS = 0,
    int? TransactionCodeE = 0,
    bool ShowZeroBalance = false) // 👈 پارامتر کنترل مانده صفر
        {
            DataSet ds = new DataSet("AccountingDataSet");

            using (var db = new DBcontextModel())
            {
                string FinancialYear = PublicClass.FinancialYear;

                var transactionsQuery = db.Transactions
                                         .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                if (TransactionCodeS != null && TransactionCodeS.Value != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS.Value);
                }

                if (TransactionCodeE != null && TransactionCodeE.Value != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE.Value);
                }

                // اگر تراکنشی وجود نداشت، برگرداندن Null
                if (transactionsQuery.Count() == 0) return null;
                var filteredTransactions = transactionsQuery;

                // ----------------------------------------------------------------
                // کوئری سطح والد (Customers)
                // ----------------------------------------------------------------
                var qCustomers = from da in db.DetailedAccounts
                                 join cu in db.Customers on da.CustomerId equals cu.Id
                                 join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id
                                 join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                                 join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                                 join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                                 join tr in filteredTransactions
                                 on da.Id equals tr.DetailedAccountId
                                 into trGroup
                                 where ga.Id == 1 || ga.Id == 2 || ga.Id == 3 || ga.Id == 4 || ga.Id == 5

                                 group new { da, trGroup, sa, ta, ga, na, cu } by cu.Id into g

                                 let CustomerData = g.FirstOrDefault()
                                 let CustomerName = (CustomerData.cu.Family + " " + CustomerData.cu.Name).Trim()
                                 let CustomerCode = CustomerData.cu.Id

                                 let DebitTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                 let CreditTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0
                                 let EndingBalance = DebitTurnoverSum - CreditTurnoverSum

                                 // 🎯 اعمال شرط مانده صفر برای سطح والد
                                 where ShowZeroBalance ||
                                       (Math.Abs(EndingBalance) != 0 || Math.Abs(DebitTurnoverSum) != 0 || Math.Abs(CreditTurnoverSum) != 0)

                                 select new
                                 {
                                     Id = g.Key,
                                     Name = CustomerName,
                                     Code = CustomerCode,
                                     DebitTurnover = DebitTurnoverSum,
                                     CreditTurnover = CreditTurnoverSum,
                                     DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                     CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                                 };

                var customerIds = qCustomers.Select(c => c.Id).ToList();

                // ----------------------------------------------------------------
                // کوئری سطح فرزند (Detailed Accounts)
                // ----------------------------------------------------------------
                var qDetailed = from da in db.DetailedAccounts
                                join tr in filteredTransactions on da.Id equals tr.DetailedAccountId into trGroup
                                join cu in db.Customers on da.CustomerId equals cu.Id
                                join sp in db.SpecificAccounts on da.SpecificAccountId equals sp.Id
                                where customerIds.Contains(da.CustomerId)

                                group new { da, sp, trGroup } by new { da.Id, da.SpecificAccountId, da.CodeAccount, da.CustomerId, sp.Name } into g

                                let DebitTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                let CreditTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0
                                let EndingBalanceD = DebitTurnoverSumD - CreditTurnoverSumD

                                // 🎯 اعمال شرط مانده صفر برای سطح فرزند
                                where ShowZeroBalance ||
                                      (Math.Abs(EndingBalanceD) != 0 || Math.Abs(DebitTurnoverSumD) != 0 || Math.Abs(CreditTurnoverSumD) != 0)

                                select new
                                {
                                    ParentCustomerId = g.Key.CustomerId,
                                    Id = g.Key.Id,
                                    Code = g.Key.CodeAccount,
                                    Name = g.Key.Name,
                                    DebitTurnover = DebitTurnoverSumD,
                                    CreditTurnover = CreditTurnoverSumD,
                                    DebitBalance = EndingBalanceD > 0 ? EndingBalanceD : 0.0,
                                    CreditBalance = EndingBalanceD < 0 ? Math.Abs(EndingBalanceD) : 0.0,
                                };

                // ----------------------------------------------------------------
                // ساخت DataSet و DataRelation
                // ----------------------------------------------------------------
                System.Data.DataTable dtCustomers = PublicClass.EntityTableToDataTable(qCustomers.ToList(), "Customers");
                ds.Tables.Add(dtCustomers);

                System.Data.DataTable dtDetailedAccounts = PublicClass.EntityTableToDataTable(qDetailed.ToList(), "DetailedAccounts");
                ds.Tables.Add(dtDetailedAccounts);
            }

            // تعریف Data Relation
            DataColumn parentCol = ds.Tables["Customers"].Columns["Id"];
            DataColumn childCol = ds.Tables["DetailedAccounts"].Columns["ParentCustomerId"];

            DataRelation relation = new DataRelation("CustomerToDetailed", parentCol, childCol, false);
            ds.Relations.Add(relation);

            return ds;
        }


        public static DataSet DetailedAccountTransactionsTree(
    string DateS,
    string DateE,
    int? TransactionCodeS = 0,
    int? TransactionCodeE = 0,
    bool ShowZeroBalance = false,
    bool IsBeginningBalanceFilter = false) // 👈 پارامتر جدید
        {
            DataSet ds = new DataSet("AccountingDataSet");

            using (var db = new DBcontextModel())
            {
                string FinancialYear = PublicClass.FinancialYear;

                var transactionsQuery = db.Transactions
                                         .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                if (TransactionCodeS != null && TransactionCodeS.Value != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS.Value);
                }

                if (TransactionCodeE != null && TransactionCodeE.Value != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE.Value);
                }

                // 🎯 اعمال فیلتر IsBeginningBalance (منطق درخواستی)
                // اگر IsBeginningBalanceFilter == false، فقط تراکنش‌هایی با IsBeginningBalance == false لحاظ شوند.
                if (!IsBeginningBalanceFilter)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.IsBeginningBalance == false);
                }

                // اگر تراکنشی وجود نداشت، برگرداندن Null
                if (transactionsQuery.Count() == 0) return null;
                var filteredTransactions = transactionsQuery;

                // ----------------------------------------------------------------
                // کوئری سطح والد (Customers)
                // ----------------------------------------------------------------
                var qCustomers = from da in db.DetailedAccounts
                                 join cu in db.Customers on da.CustomerId equals cu.Id
                                 join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id
                                 join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                                 join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                                 join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                                 join tr in filteredTransactions
                                 on da.Id equals tr.DetailedAccountId
                                 into trGroup
                                 where ga.Id == 1 || ga.Id == 2 || ga.Id == 3 || ga.Id == 4 || ga.Id == 5

                                 group new { da, trGroup, sa, ta, ga, na, cu } by cu.Id into g

                                 let CustomerData = g.FirstOrDefault()
                                 let CustomerName = (CustomerData.cu.Family + " " + CustomerData.cu.Name).Trim()
                                 let CustomerCode = CustomerData.cu.Id

                                 let DebitTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                 let CreditTurnoverSum = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0
                                 let EndingBalance = DebitTurnoverSum - CreditTurnoverSum

                                 // اعمال شرط مانده صفر برای سطح والد
                                 where ShowZeroBalance ||
                                       (Math.Abs(EndingBalance) != 0 || Math.Abs(DebitTurnoverSum) != 0 || Math.Abs(CreditTurnoverSum) != 0)

                                 select new
                                 {
                                     Id = g.Key,
                                     Name = CustomerName,
                                     Code = CustomerCode,
                                     DebitTurnover = DebitTurnoverSum,
                                     CreditTurnover = CreditTurnoverSum,
                                     DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                     CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                                 };

                var customerIds = qCustomers.Select(c => c.Id).ToList();

                // ----------------------------------------------------------------
                // کوئری سطح فرزند (Detailed Accounts)
                // ----------------------------------------------------------------
                var qDetailed = from da in db.DetailedAccounts
                                join tr in filteredTransactions on da.Id equals tr.DetailedAccountId into trGroup
                                join cu in db.Customers on da.CustomerId equals cu.Id
                                join sp in db.SpecificAccounts on da.SpecificAccountId equals sp.Id
                                where customerIds.Contains(da.CustomerId)

                                group new { da, sp, trGroup } by new { da.Id, da.SpecificAccountId, da.CodeAccount, da.CustomerId, sp.Name } into g

                                let DebitTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBed) ?? 0.0
                                let CreditTurnoverSumD = g.SelectMany(x => x.trGroup).Sum(t => (double?)t.PaymentBes) ?? 0.0
                                let EndingBalanceD = DebitTurnoverSumD - CreditTurnoverSumD

                                // اعمال شرط مانده صفر برای سطح فرزند
                                where ShowZeroBalance ||
                                      (Math.Abs(EndingBalanceD) != 0 || Math.Abs(DebitTurnoverSumD) != 0 || Math.Abs(CreditTurnoverSumD) != 0)

                                select new
                                {
                                    ParentCustomerId = g.Key.CustomerId,
                                    Id = g.Key.Id,
                                    Code = g.Key.CodeAccount,
                                    Name = g.Key.Name,
                                    DebitTurnover = DebitTurnoverSumD,
                                    CreditTurnover = CreditTurnoverSumD,
                                    DebitBalance = EndingBalanceD > 0 ? EndingBalanceD : 0.0,
                                    CreditBalance = EndingBalanceD < 0 ? Math.Abs(EndingBalanceD) : 0.0,
                                };

                // ----------------------------------------------------------------
                // ساخت DataSet و DataRelation
                // ----------------------------------------------------------------
                System.Data.DataTable dtCustomers = PublicClass.EntityTableToDataTable(qCustomers.ToList(), "Customers");
                ds.Tables.Add(dtCustomers);

                System.Data.DataTable dtDetailedAccounts = PublicClass.EntityTableToDataTable(qDetailed.ToList(), "DetailedAccounts");
                ds.Tables.Add(dtDetailedAccounts);
            }

            // تعریف Data Relation
            System.Data.DataColumn parentCol = ds.Tables["Customers"].Columns["Id"];
            System.Data.DataColumn childCol = ds.Tables["DetailedAccounts"].Columns["ParentCustomerId"];

            System.Data.DataRelation relation = new System.Data.DataRelation("CustomerToDetailed", parentCol, childCol, false);
            ds.Relations.Add(relation);

            return ds;
        }


        /// <summary>
        /// صورتحساب همه حسابها
        /// </summary>
        /// <param name="GX"></param>
        /// <param name="DateS"></param>
        /// <param name="DateE"></param>
        /// <param name="TransactionCodeS"></param>
        /// <param name="TransactionCodeE"></param>
        /// <returns></returns>
        public static GridExEx.GridExEx AllAccountTransactions(GridExEx.GridExEx GX, string DateS, string DateE, int? TransactionCodeS = 0, int? TransactionCodeE = 0)
        {
            /*
            using (var db = new DBcontextModel())
            {
                string FinancialYear = PublicClass.FinancialYear;

                // 1. فیلترینگ تراکنش‌ها
                var transactionsQuery = db.Transactions
                                         .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                if (TransactionCodeS != null && TransactionCodeS.Value != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS.Value);
                }

                if (TransactionCodeE != null && TransactionCodeE.Value != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE.Value);
                }

                var filteredTransactions = transactionsQuery;

                // 2. کوئری اصلی: شروع از DetailedAccounts و سپس GROUP BY بر اساس CustomerId
                var q = from da in db.DetailedAccounts

                            // Join اولیه برای دسترسی به مشخصات مشتری (Customer) و حساب‌های بالادستی
                        join cu in db.Customers on da.CustomerId equals cu.Id
                        join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id
                        join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                        join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                        join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                        // Left Join برای تراکنش‌ها
                        join tr in filteredTransactions
                        on da.Id equals tr.DetailedAccountId
                        into trGroup

                        // 3. گروه‌بندی بر اساس شناسه مشتری (cu.Id)
                        group new { da, trGroup, sa, ta, ga, na, cu } by cu.Id into g

                        // 4. استخراج اطلاعات مشتری
                        let CustomerData = g.FirstOrDefault() // فقط برای استخراج نام، کد و آیدی مشتری از اولین رکورد
                        let CustomerName = (CustomerData.cu.Family + " " + CustomerData.cu.Name).Trim()
                        let CustomerCode = CustomerData.cu.Id // فرض می‌کنیم مشتری نیز کد دارد.

                        // 5. تجمیع مانده اول دوره: جمع مانده تمام تفصیلی‌های زیرمجموعه این مشتری
                        //let BeginningBanaceSum = g.Sum(x => (double?)x.da.BeginningBanace) ?? 0.0

                        // 6. تجمیع گردش‌ها: جمع گردش‌های تمام تفصیلی‌های زیرمجموعه این مشتری
                        let DebitTurnoverSum = g.SelectMany(x => x.trGroup)
                                                .Sum(t => (double?)t.PaymentBed) ?? 0.0

                        let CreditTurnoverSum = g.SelectMany(x => x.trGroup)
                                                 .Sum(t => (double?)t.PaymentBes) ?? 0.0

                        // 7. تعیین ماهیت حساب: برای محاسبه مانده نهایی، باید ماهیت غالب حساب‌های مشتری در نظر گرفته شود.
                        // اما چون یک مشتری ممکن است در حساب‌های با ماهیت مختلف (بدهکار/بستانکار) باشد، ما مانده خالص را محاسبه می‌کنیم.
                        let EndingBalance = DebitTurnoverSum - CreditTurnoverSum

                        // 8. فیلتر نهایی (برای نمایش رکوردهایی که گردش یا مانده اول دوره دارند)
                        where Math.Abs(EndingBalance) !=0  || Math.Abs(DebitTurnoverSum) !=0 || Math.Abs(CreditTurnoverSum) !=0

                        select new
                        {
                            GName = CustomerData.ga.Name,
                            TName = CustomerData.ta.Name,
                            sName = CustomerData.sa.Name,
                            Id = CustomerData.cu.Id,
                            DName = CustomerName,
                            Code = CustomerData.da.CodeAccount,
                            DebitTurnover = DebitTurnoverSum,
                            CreditTurnover = CreditTurnoverSum,
                            DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                            CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                        };

                GX.DataSource = q.ToList();
                return GX;
            }
            */

            using (var db = new DBcontextModel())
            {
                string FinancialYear = PublicClass.FinancialYear;
                var transactionsQuery = db.Transactions
                                          .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                if (TransactionCodeS != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS);
                }

                if (TransactionCodeE != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE);
                }

                var filteredTransactions = transactionsQuery;

                var q = from da in db.DetailedAccounts

                        join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id
                        join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                        join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                        join cu in db.Customers on da.CustomerId equals cu.Id
                        join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                        join tr in filteredTransactions
                        on da.Id equals tr.DetailedAccountId
                        into trGroup

                        let DebitTurnover = trGroup
                                                    .Where(c => c.FinancialYear == FinancialYear && !c.Status)
                                                    .Sum(t => (double?)t.PaymentBed) ?? 0.0
                        let CreditTurnover = trGroup
                                                    .Where(c => c.FinancialYear == FinancialYear && !c.Status)
                                                    .Sum(t => (double?)t.PaymentBes) ?? 0.0

                        let EndingBalance = DebitTurnover - CreditTurnover

                        where Math.Abs(EndingBalance) != 0

                        select new
                        {
                            GName = ga.Name,
                            TName = ta.Name,
                            sName = sa.Name,
                            Id = da.Id,
                            DName = cu.Family + " " + cu.Name,
                            Code = da.CodeAccount,
                            DebitTurnover = DebitTurnover,
                            CreditTurnover = CreditTurnover,
                            DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                            CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                        };
                GX.DataSource = q.ToList();
                return GX;
            }

        }

        /// <summary>
        /// صورتحساب معین
        /// </summary>
        /// <param name="GX"></param>
        /// <returns></returns>
        public static GridExEx.GridExEx SpecificAccountTransactions(GridExEx.GridExEx GX, string DateS, string DateE, int? TransactionCodeS = 0, int? TransactionCodeE = 0)
        {
            using (var db = new DBcontextModel())
            {
                string FinancialYear = PublicClass.FinancialYear;
                var transactionsQuery = db.Transactions
                                          .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                if (TransactionCodeS != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS);
                }

                if (TransactionCodeE != 0)
                {
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE);
                }

                var filteredTransactions = transactionsQuery;

                var q = from da in db.DetailedAccounts

                        join tr in filteredTransactions
                        on da.Id equals tr.DetailedAccountId
                        into trGroup // تمامی تراکنش‌های تفصیلی جاری

                        // 4. گروه‌بندی تمام تفصیلی‌های متصل به یک حساب معین
                        group new { da, trGroup } by da.SpecificAccountId into g

                        // 5. استخراج اطلاعات حساب معین و بالادستی از طریق .FirstOrDefault() یا .Max()
                        // برای این منظور، لازم است جدول SpecificAccount را دوباره Join کنیم.
                        join sa in db.SpecificAccounts on g.Key equals sa.Id
                        join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id
                        join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                        join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                        // 6. محاسبه تجمیعی (Aggregation)
                        let BeginningBanaceSum = 0

                        let DebitTurnoverSum = g.SelectMany(x => x.trGroup)
                                                .Sum(t => (double?)t.PaymentBed) ?? 0.0

                        let CreditTurnoverSum = g.SelectMany(x => x.trGroup)
                                                 .Sum(t => (double?)t.PaymentBes) ?? 0.0

                        // 7. محاسبه مانده نهایی
                        let NatureAccountsId = ga.IdMahiyat
                        let BeginningBanaceAdjusted = BeginningBanaceSum * (NatureAccountsId == 2 ? -1 : 1)
                        let EndingBalance = BeginningBanaceAdjusted + DebitTurnoverSum - CreditTurnoverSum

                        // 8. شرط فیلتر نهایی (برای حذف مانده‌های صفر)
                        where Math.Abs(EndingBalance) != 0 // استفاده از حد آستانه برای ایمنی

                        select new
                        {
                            GroupAccountName = ga.Name,
                            TotalAccountName = ta.Name,
                            SpecificAccountName = sa.Name,

                            Id = sa.Id,
                            Name = sa.Name,
                            Code = sa.Cod,

                            BeginningBanace = BeginningBanaceSum,
                            NatureAccounts = na.Name,

                            DebitTurnover = DebitTurnoverSum,
                            CreditTurnover = CreditTurnoverSum,

                            DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                            CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                        };
                GX.DataSource = q.ToList();
                return GX;
            }
        }


        /// <summary>
        /// صورتحساب حساب کل
        /// </summary>
        /// <param name="GX"></param>
        /// <returns></returns>
        public static GridExEx.GridExEx TotalAccountTransactions_(GridExEx.GridExEx GX, string DateS, string DateE, int? TransactionCodeS = 0, int? TransactionCodeE = 0)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    string FinancialYear = PublicClass.FinancialYear;
                    var transactionsQuery = db.Transactions
                                              .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                    transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                    if (TransactionCodeS != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS);
                    }

                    if (TransactionCodeE != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE);
                    }

                    var filteredTransactions = transactionsQuery;

                    var q = from da in db.DetailedAccounts

                                // 3. Join صریح با SpecificAccount برای دسترسی به شناسه حساب کل
                            join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id

                            // 4. Left Join با تراکنش‌های فیلترشده برای تجمیع گردش
                            join tr in filteredTransactions
                            on da.Id equals tr.DetailedAccountId
                            into trGroup // تمامی تراکنش‌های تفصیلی جاری

                            // 5. گروه‌بندی نهایی بر اساس شناسه حساب کل (TotalAccountId)
                            group new { da, trGroup } by sa.Id_TotalAccount into g

                            // 6. Join با جداول بالادستی برای استخراج اطلاعات ثابت گروه
                            join ta in db.TotalAccounts on g.Key equals ta.Id
                            join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                            join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                            // 7. محاسبه تجمیعی (Aggregation)
                            // جمع مانده اول دوره تمامی تفصیلی‌های زیرمجموعه
                            let BeginningBanaceSum = 0

                            // جمع گردش‌ها از تمامی تراکنش‌های زیرمجموعه
                            let DebitTurnoverSum = g.SelectMany(x => x.trGroup)
                                                    .Sum(t => (double?)t.PaymentBed) ?? 0.0

                            let CreditTurnoverSum = g.SelectMany(x => x.trGroup)
                                                     .Sum(t => (double?)t.PaymentBes) ?? 0.0

                            // 8. محاسبه مانده نهایی
                            let NatureAccountsId = ga.IdMahiyat
                            let BeginningBanaceAdjusted = BeginningBanaceSum * (NatureAccountsId == 2 ? -1 : 1)
                            let EndingBalance = BeginningBanaceAdjusted + DebitTurnoverSum - CreditTurnoverSum

                            // 9. شرط فیلتر نهایی (حذف مانده‌های صفر)
                            where Math.Abs(EndingBalance) > 0.00000001

                            select new
                            {
                                GroupAccountName = ga.Name,
                                TotalAccountName = ta.Name,

                                // در سطح کل، فیلدهای معین/تفصیلی خالی می‌مانند
                                SpecificAccountName = string.Empty,

                                Id = ta.Id,
                                Name = ta.Name,
                                Code = ta.Cod,

                                BeginningBanace = BeginningBanaceSum,
                                NatureAccounts = na.Name,

                                DebitTurnover = DebitTurnoverSum,
                                CreditTurnover = CreditTurnoverSum,

                                DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                            };

                    // 10. اجرای کوئری و نمایش نتایج
                    GX.DataSource = q.ToList();
                    //PublicClass.SettingGridEX(GX);
                    return GX;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

        public static GridExEx.GridExEx TotalAccountTransactions(
            GridExEx.GridExEx GX,
            string DateS,
            string DateE,
            int? TransactionCodeS = 0,
            int? TransactionCodeE = 0,
            bool IsBeginningBalanceFilter = false) // 👈 پارامتر جدید
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    string FinancialYear = PublicClass.FinancialYear;
                    var transactionsQuery = db.Transactions
                                             .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                    transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                    if (TransactionCodeS != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS);
                    }

                    if (TransactionCodeE != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE);
                    }

                    // 🎯 اعمال فیلتر IsBeginningBalance (منطق اصلاح شده)
                    // اگر IsBeginningBalanceFilter == false، فقط تراکنش‌هایی با IsBeginningBalance == false لحاظ شوند.
                    // اگر IsBeginningBalanceFilter == true، همه تراکنش‌ها لحاظ شوند.
                    if (!IsBeginningBalanceFilter)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.IsBeginningBalance == false);
                    }

                    var filteredTransactions = transactionsQuery;

                    var q = from da in db.DetailedAccounts

                                // 3. Join صریح با SpecificAccount برای دسترسی به شناسه حساب کل
                            join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id

                            // 4. Left Join با تراکنش‌های فیلترشده برای تجمیع گردش
                            join tr in filteredTransactions
                            on da.Id equals tr.DetailedAccountId
                            into trGroup // تمامی تراکنش‌های تفصیلی جاری

                            // 5. گروه‌بندی نهایی بر اساس شناسه حساب کل (TotalAccountId)
                            group new { da, trGroup } by sa.Id_TotalAccount into g

                            // 6. Join با جداول بالادستی برای استخراج اطلاعات ثابت گروه
                            join ta in db.TotalAccounts on g.Key equals ta.Id
                            join ga in db.GroupAccounts on ta.Id_GroupAccount equals ga.Id
                            join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                            // 7. محاسبه تجمیعی (Aggregation)
                            // جمع مانده اول دوره تمامی تفصیلی‌های زیرمجموعه
                            let BeginningBanaceSum = 0

                            // جمع گردش‌ها از تمامی تراکنش‌های زیرمجموعه
                            let DebitTurnoverSum = g.SelectMany(x => x.trGroup)
                                                     .Sum(t => (double?)t.PaymentBed) ?? 0.0

                            let CreditTurnoverSum = g.SelectMany(x => x.trGroup)
                                                      .Sum(t => (double?)t.PaymentBes) ?? 0.0

                            // 8. محاسبه مانده نهایی
                            let NatureAccountsId = ga.IdMahiyat
                            let BeginningBanaceAdjusted = BeginningBanaceSum * (NatureAccountsId == 2 ? -1 : 1)
                            let EndingBalance = BeginningBanaceAdjusted + DebitTurnoverSum - CreditTurnoverSum

                            // 9. شرط فیلتر نهایی (حذف مانده‌های صفر)
                            where Math.Abs(EndingBalance) > 0.00000001

                            select new
                            {
                                GroupAccountName = ga.Name,
                                TotalAccountName = ta.Name,

                                // در سطح کل، فیلدهای معین/تفصیلی خالی می‌مانند
                                SpecificAccountName = string.Empty,

                                Id = ta.Id,
                                Name = ta.Name,
                                Code = ta.Cod,

                                BeginningBanace = BeginningBanaceSum,
                                NatureAccounts = na.Name,

                                DebitTurnover = DebitTurnoverSum,
                                CreditTurnover = CreditTurnoverSum,

                                DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                            };

                    // 10. اجرای کوئری و نمایش نتایج
                    GX.DataSource = q.ToList();
                    //PublicClass.SettingGridEX(GX);
                    return GX;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }
        /// <summary>
        /// صورتحساب گروه حساب ها
        /// </summary>
        /// <param name="GX"></param>
        /// <returns></returns>
        public static GridExEx.GridExEx GroupAccountTransactions_(GridExEx.GridExEx GX, string DateS, string DateE, int? TransactionCodeS = 0, int? TransactionCodeE = 0)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    string FinancialYear = PublicClass.FinancialYear;
                    var transactionsQuery = db.Transactions
                                              .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                    transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                    if (TransactionCodeS != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS);
                    }

                    if (TransactionCodeE != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE);
                    }

                    // کوئری فیلتر شده نهایی
                    var filteredTransactions = transactionsQuery;

                    // -------------------------------------------------------------

                    var q = from da in db.DetailedAccounts

                            join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id
                            join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id

                            // 4. استفاده از تراکنش‌های فیلترشده در Left Join
                            join tr in filteredTransactions
                            on da.Id equals tr.DetailedAccountId
                            into trGroup

                            group new { da, trGroup } by ta.Id_GroupAccount into g

                            join ga in db.GroupAccounts on g.Key equals ga.Id
                            join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                            let DebitTurnoverSum = g.SelectMany(x => x.trGroup)
                                                    .Sum(t => (double?)t.PaymentBed) ?? 0.0

                            let CreditTurnoverSum = g.SelectMany(x => x.trGroup)
                                                     .Sum(t => (double?)t.PaymentBes) ?? 0.0

                            let NatureAccountsId = ga.IdMahiyat

                            // در این کوئری، EndingBalance فقط مانده گردش دوره فیلتر شده است.
                            let EndingBalance = DebitTurnoverSum - CreditTurnoverSum

                            where Math.Abs(EndingBalance) > 0.00000001

                            select new
                            {
                                GroupAccountName = ga.Name,

                                TotalAccountName = string.Empty,
                                SpecificAccountName = string.Empty,

                                Id = ga.Id,
                                Name = ga.Name,
                                Code = ga.Id, // فرض می‌شود نام فیلد در مدل GroupAccount، 'Cod' است.

                                NatureAccounts = na.Name,

                                DebitTurnover = DebitTurnoverSum,
                                CreditTurnover = CreditTurnoverSum,

                                DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                            };

                    GX.DataSource = q.ToList();
                    PublicClass.SettingGridEX(GX);
                    return GX;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

        public static GridExEx.GridExEx GroupAccountTransactions(
            GridExEx.GridExEx GX,
            string DateS,
            string DateE,
            int? TransactionCodeS = 0,
            int? TransactionCodeE = 0,
            bool IsBeginningBalanceFilter = false) // 👈 پارامتر
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    string FinancialYear = PublicClass.FinancialYear;
                    var transactionsQuery = db.Transactions
                                             .Where(t => t.FinancialYear == FinancialYear && !t.Status);

                    // 1. اعمال فیلتر تاریخ
                    transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.CompareTo(DateS) >= 0 && t.TransactionDate.CompareTo(DateE) <= 0);

                    // 2. اعمال فیلتر کدهای تراکنش
                    if (TransactionCodeS != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode >= TransactionCodeS);
                    }

                    if (TransactionCodeE != 0)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.TransactionCode <= TransactionCodeE);
                    }

                    // 🎯 3. اعمال فیلتر IsBeginningBalance (اصلاح شده و تأیید شده)
                    if (!IsBeginningBalanceFilter)
                    {
                        transactionsQuery = transactionsQuery.Where(t => t.IsBeginningBalance == false);
                    }

                    // کوئری فیلتر شده نهایی
                    var filteredTransactions = transactionsQuery;

                    // -------------------------------------------------------------

                    var q = from da in db.DetailedAccounts

                            join sa in db.SpecificAccounts on da.SpecificAccountId equals sa.Id
                            join ta in db.TotalAccounts on sa.Id_TotalAccount equals ta.Id

                            // 4. استفاده از تراکنش‌های فیلترشده در Left Join
                            join tr in filteredTransactions
                            on da.Id equals tr.DetailedAccountId
                            into trGroup

                            group new { da, trGroup } by ta.Id_GroupAccount into g

                            join ga in db.GroupAccounts on g.Key equals ga.Id
                            join na in db.NatureAccounts on ga.IdMahiyat equals na.Id

                            let DebitTurnoverSum = g.SelectMany(x => x.trGroup)
                                                     .Sum(t => (double?)t.PaymentBed) ?? 0.0

                            let CreditTurnoverSum = g.SelectMany(x => x.trGroup)
                                                      .Sum(t => (double?)t.PaymentBes) ?? 0.0

                            let NatureAccountsId = ga.IdMahiyat

                            // در این کوئری، EndingBalance فقط مانده گردش دوره فیلتر شده است.
                            let EndingBalance = DebitTurnoverSum - CreditTurnoverSum

                            where Math.Abs(EndingBalance) > 0.00000001

                            select new
                            {
                                GroupAccountName = ga.Name,

                                TotalAccountName = string.Empty,
                                SpecificAccountName = string.Empty,

                                Id = ga.Id,
                                Name = ga.Name,
                                Code = ga.Id,

                                NatureAccounts = na.Name,

                                DebitTurnover = DebitTurnoverSum,
                                CreditTurnover = CreditTurnoverSum,

                                DebitBalance = EndingBalance > 0 ? EndingBalance : 0.0,
                                CreditBalance = EndingBalance < 0 ? Math.Abs(EndingBalance) : 0.0,
                            };

                    System.Data.DataTable dt = PublicClass.EntityTableToDataTable(q.ToList()); GX.DataSource = dt;
                    PublicClass.SettingGridEX(GX);
                    return GX;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return null;
            }
        }

        /// <summary>
        /// بررسی شخص در لیست سیاه
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public static (bool, bool, string) CheckBlacList(int CustomerId)
        {
            try
            {
                using (var db = new DBcontextModel())
                {
                    var q = db.BlacLists.Where(c => c.CustomerId == CustomerId && (c.status/*||c.NoSaveData*/));
                    if (q.Count() != 0)
                    {
                        var cu = db.Customers.Where(c => c.Id == CustomerId).First();

                        WindowAlartByText(eDesktopAlertColor.Red, cu.Name + " " + cu.Family + '\n' + q.First().Description, "", 10, 1);

                        return (q.First().status, q.First().NoSaveData, cu.Name + " " + cu.Family);
                    }
                    else
                        return (false, false, "");
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return (false, false, "");
            }
        }
        /// <summary>
        /// بستن فرم ها
        /// </summary>
        /// <returns></returns>
        public static bool CloseForm()
        {
            try
            {
                DialogResult result = MessageBox.Show(ResourceCode.T100, "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                    return true;
                else
                    return false;

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return false;
            }
        }

        /// <summary>
        /// ثبت اسناد حسابداری بارنامه ها
        /// </summary>
        /// <param name="TransactionCode"></param>
        /// <param name="TransactionDate"></param>
        /// <param name="TransactionTypeId"></param>
        /// <param name="SpecificAccountId"></param>
        /// <param name="DetailedAccountFromId"></param>
        /// <param name="DetailedAccountToId"></param>
        /// <param name="TotlAmount"></param>
        /// <param name="PayAmount"></param>
        /// <param name="TaxAmount"></param>
        /// <param name="ComerBId"></param>
        /// <param name="Description"></param>
        public static void ComerB_AccountingDocumentRegistration(int ComerBId)
        {
            using (var db = new DBcontextModel())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        int ListId = 0;
                        int TransactionCode = Convert.ToInt32(PublicClass.CreatTransactionCode());
                        //شماره سریال سند
                        int Series = 0;
                        int SpecificAccountId = 0;
                        int DetailedAccountId = 0;
                        int customertId = 0;
                        var qcom = db.ComersBs.Where(c => c.Id == ComerBId).First();
                        //var ADR = new Repository<Transaction>(db);

                        //AE سند طرف حساب کالا
                        //دریافت از صاحب کالا بابت حمل کالا.جزء درآمد می باشد
                        {
                            if (qcom.AE != 0)
                            {
                                //سند بد
                                Series++;
                                //حساب معین
                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 10301).First().Id;//بدهکاران تجاری، خریداران

                                //حساب تفصیلی
                                customertId = db.Customers.Where(c => c.Id == db.ComersBs.Where(x => x.Id == ComerBId).FirstOrDefault().GoodsAccountId).FirstOrDefault().Id;

                                var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);

                                if (serch1.Count() == 0)
                                    //ایجاد حساب تفصیلی
                                    DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId = serch1.First().Id;

                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 1, SpecificAccountId, DetailedAccountId, qcom.AE, qcom.AE, 0, ComerBId, "بایت دریافتی از صاحب کالا", "", Series, true);


                                //*****************
                                //سند بس
                                Series++;
                                //حساب معین
                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 60201).First().Id;//درآمد ارائه از خدمات داخلی

                                //حساب تفصیلی
                                customertId = db.Customers.Where(c => c.SecretCode == 3).First().Id;

                                var serch2 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                if (serch2.Count() == 0)
                                    //ایجاد حساب تفصیلی

                                    DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId = serch2.First().Id;


                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 1, SpecificAccountId, DetailedAccountId, qcom.AE, 0, qcom.AE, ComerBId, "بایت دریافتی از صاحب کالا", "", Series, true);

                            }
                        }
                        //AV سند کرایه راننده
                        {
                            double qcomBV = Math.Abs(qcom.BV);
                            if (qcom.BV < 0)//AXسند هرینه
                            {
                                Series++;

                                //حساب معین
                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 80801).First().Id;//هزینه حمل کالا

                                //حساب تفصیلی
                                customertId = db.Customers.Where(c => c.SecretCode == 4).First().Id;

                                var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                if (serch1.Count() == 0)
                                    DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId = serch1.First().Id;

                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 2, SpecificAccountId, DetailedAccountId, qcomBV, qcomBV, 0, ComerBId, "بابت هزینه کرایه حمل", "", Series, true);


                                //*****************
                                Series++;
                                //حساب معین
                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 30101).First().Id;//بستانکاران تجاری فروشندگان

                                //طرف حساب هزینه کامیون
                                customertId = db.Customers.Where(c => c.Id == db.ComersBs.Where(x => x.Id == ComerBId).FirstOrDefault().CostAccountId).FirstOrDefault().Id;

                                var serch2 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                if (serch2.Count() == 0)
                                    DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId = serch2.First().Id;

                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 2, SpecificAccountId, DetailedAccountId, qcomBV, 0, qcomBV, ComerBId, "بابت هزینه کرایه حمل", "", Series, true);

                            }
                            else if (qcom.BV > 0)//AV سند درآمد
                            {
                                Series++;

                                //حساب معین
                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 10301).First().Id;//بدهکاران تجاری، خریداران

                                //حساب تفصیلی
                                customertId = db.Customers.Where(c => c.Id == db.ComersBs.Where(x => x.Id == ComerBId).FirstOrDefault().CostAccountId).FirstOrDefault().Id;

                                var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);

                                if (serch1.Count() == 0)
                                    //ایجاد حساب تفصیلی
                                    DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId = serch1.First().Id;


                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 1, SpecificAccountId, DetailedAccountId, qcomBV, qcomBV, 0, ComerBId, "بابت درآمد کرایه حمل", "", Series, true);

                                //*****************

                                Series++;

                                //حساب معین
                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 60201).First().Id;//درآمد ارائه از خدمات داخلی

                                customertId = db.Customers.Where(c => c.SecretCode == 3).First().Id;

                                var serch2 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                if (serch2.Count() == 0)
                                    //ایجاد حساب تفصیلی

                                    DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId = serch2.First().Id;

                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 1, SpecificAccountId, DetailedAccountId, qcomBV, 0, qcomBV, ComerBId, "بابت درآمد کرایه حمل", "", Series, true);

                            }
                        }
                        //AZ سند بارنامه نویس
                        {
                            double qcomAZ = Math.Abs(qcom.AZ);
                            //وضعیت بارنامه:دارای بارنامه/فاقد بارنامه
                            var StatusLading = db.ComersHs.Where(c => c.Id == qcom.ComersHId).First().StatusLading;

                            if (!StatusLading)
                            {
                                if (qcom.AZ < 0)//(پرداخت شود(سند هزینه
                                {
                                    Series++;
                                    //حساب معین
                                    SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 80801).First().Id;//هزینه حمل کالا

                                    //حساب تفصیلی
                                    customertId = db.Customers.Where(c => c.SecretCode == 9).First().Id;

                                    var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                    if (serch1.Count() == 0)
                                        DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                    else
                                        DetailedAccountId = serch1.First().Id;

                                    PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 2, SpecificAccountId, DetailedAccountId, qcomAZ, qcomAZ, 0, ComerBId, "بابت هزینه بارنامه نویسی", "", Series, true);



                                    //*****************

                                    Series++;
                                    //حساب معین
                                    SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 30101).First().Id;//بستانکاران تجاری فروشندگان

                                    //طرف حساب بارنامه نویس
                                    customertId = db.ComersHs.Where(c => c.Id == qcom.ComersHId).First().ShiperId;

                                    var serch2 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                    if (serch2.Count() == 0)
                                        DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                    else
                                        DetailedAccountId = serch2.First().Id;

                                    PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 2, SpecificAccountId, DetailedAccountId, qcomAZ, 0, qcomAZ, ComerBId, "بابت هزینه بارنامه نویسی", "", Series, true);

                                }
                                else if (qcom.AZ > 0)//(دریافت شود(سند درآمد
                                {
                                    Series++;
                                    //حساب معین
                                    SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 10301).First().Id;//بدهکاران تجاری، خریداران

                                    //حساب تفصیلی
                                    customertId = db.ComersHs.Where(c => c.Id == qcom.ComersHId).First().ShiperId;

                                    var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);

                                    if (serch1.Count() == 0)
                                        //ایجاد حساب تفصیلی
                                        DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                    else
                                        DetailedAccountId = serch1.First().Id;

                                    PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 1, SpecificAccountId, DetailedAccountId, qcomAZ, qcomAZ, 0, ComerBId, "بابت دریافتی از بارنامه نویسی", "", Series, true);
                                    //*****************

                                    Series++;
                                    //حساب معین
                                    SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 60201).First().Id;//درآمد ارائه از خدمات داخلی
                                                                                                                  //حساب تفصیلی
                                    customertId = db.Customers.Where(c => c.SecretCode == 3).First().Id;

                                    var serch2 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                    if (serch2.Count() == 0)
                                        //ایجاد حساب تفصیلی

                                        DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                    else
                                        DetailedAccountId = serch2.First().Id;

                                    PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 1, SpecificAccountId, DetailedAccountId, qcomAZ, 0, qcomAZ, ComerBId, "بابت دریافتی از بارنامه نویسی", "", Series, true);

                                }
                            }
                        }
                        //سند پرداختی سایر
                        {
                            var PaymentToOthers = db.ComersBs.Where(c => c.Id == ComerBId).First();

                            if (PaymentToOthers.PaymentToOthersId != 0)
                            {

                                Series++;
                                SpecificAccountId = db.DetailedAccounts.Where(c => c.Id == PaymentToOthers.PaymentToOthersId).First().SpecificAccountId;
                                DetailedAccountId = PaymentToOthers.PaymentToOthersId;

                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 2, SpecificAccountId, DetailedAccountId, PaymentToOthers.PaymentToOthers1, PaymentToOthers.PaymentToOthers1, 0, ComerBId, "پرداختی سایر", "", Series, true);


                                //*****************

                                Series++;
                                //حساب معین
                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 30101).First().Id; //هزینه حمل کالا
                                                                                                               //حساب تفصیلی
                                customertId = db.Customers.Where(c => c.Id == db.ComersBs.Where(x => x.Id == ComerBId).FirstOrDefault().CostAccountId).FirstOrDefault().Id;

                                var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);
                                if (serch1.Count() == 0)
                                    DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId = serch1.First().Id;

                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 2, SpecificAccountId, DetailedAccountId, PaymentToOthers.PaymentToOthers1, 0, PaymentToOthers.PaymentToOthers1, ComerBId, "پرداختی سایر", "", Series, true);

                            }
                        }
                        //سایر هزینه ها
                        {
                            var PaymentToOthers = db.ComersBs.Where(c => c.Id == ComerBId).First();

                            if (PaymentToOthers.PaymentToOthers2 != 0)
                            {
                                Series++;

                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 80802).First().Id;//هزینه های متفرقه

                                customertId = db.Customers.Where(c => c.SecretCode == 4).First().Id;

                                var serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);

                                if (serch1.Count() == 0)
                                    DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId = serch1.First().Id;


                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 2, SpecificAccountId, DetailedAccountId, PaymentToOthers.PaymentToOthers2, PaymentToOthers.PaymentToOthers2, 0, ComerBId, qcom.DesToOthers, "", Series, true);

                                //*****************
                                Series++;

                                //حساب معین
                                SpecificAccountId = db.SpecificAccounts.Where(c => c.Cod == 30101).First().Id;//بستانکاران تجاری فروشندگان

                                customertId = db.Customers.Where(c => c.SecretCode == 6).First().Id;

                                serch1 = db.DetailedAccounts.Where(c => c.SpecificAccountId == SpecificAccountId && c.CustomerId == customertId);

                                if (serch1.Count() == 0)
                                    DetailedAccountId = AddToDetailedAccounts(SpecificAccountId, customertId);
                                else
                                    DetailedAccountId = serch1.First().Id;

                                PublicClass.AccountingDocumentRegistration(db, ListId, TransactionCode, PersianDate.NowPersianDate, 2, SpecificAccountId, DetailedAccountId, PaymentToOthers.PaymentToOthers2, 0, PaymentToOthers.PaymentToOthers2, ComerBId, qcom.DesToOthers, "", Series, true);
                            }
                        }
                        WindowAlart("1");
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception er)
                    {
                        transaction.Rollback();
                        PublicClass.ShowErrorMessage(er);
                    }
                }
            }
        }


        /// <summary>
        /// ثبت تمامی اسناد مالی
        /// </summary>
        /// <param name="Id">کد لیست</param>
        /// <param name="FinancialYear">سال مالی</param>
        /// <param name="TransactionCode">کد سند</param>
        /// <param name="TransactionDate">تاریخ سند</param>
        /// <param name="TransactionTypeId">کد نوع سند: درآمد، هزینه، جابجایی، دریافت و پرداخت</param>
        /// <param name="SpecificAccountId">کد حساب معین</param>
        /// <param name="DetailedAccountId">کد حساب تفصیلی</param>
        /// <param name="Amount">مبلغ کل سند</param>
        /// <param name="PaymentBed">مبلغ بدهکار</param>
        /// <param name="PaymentBes">مبلغ بستانکار</param>
        /// <param name="ComerBId">کد سند بارنامه</param>
        /// <param name="Description">توضیحات</param>
        /// <param name="UserId">کد کاربر</param>
        /// <param name="Series">سریال سند</param>
        /// <param name="DateTime">تاریخ سیستم</param>
        /// <param name="FinalRegistry">وضعیت ثبت نهایی</param>
        /// <param name="Status">وضعیت ابطال سند</param>
        public static void AccountingDocumentRegistration(DBcontextModel db, int Id, int TransactionCode, string TransactionDate, int TransactionTypeId, int SpecificAccountId, int DetailedAccountId, double Amount, double PaymentBed, double PaymentBes, int ComerBId, string Description, string SeryalNumber, int Series, bool IsAutoRejDoc, bool IsBeginningBalance = false)
        {
            {
                var ADR = new Repository<Transaction>(db);
                ADR.SaveOrUpdateByCommit(new Transaction { Id = Id, FinancialYear = FinancialYear, TransactionCode = TransactionCode, TransactionDate = TransactionDate, TransactionTypeId = TransactionTypeId, SpecificAccountId = SpecificAccountId, DetailedAccountId = DetailedAccountId, Amount = Amount, PaymentBed = PaymentBed, PaymentBes = PaymentBes, ComerBId = ComerBId, Description = Description, SeryalNumber = SeryalNumber, UserId = UserId, Series = Series, DateTime = DateTime.Now, FinalRegistry = false, Status = false, IsAutoRejDoc = IsAutoRejDoc, IsBeginningBalance = IsBeginningBalance }, Id);
            }
        }


        /// <summary>
        /// ثبت تمامی اسناد مالی
        /// </summary>
        /// <param name="Id">کد لیست</param>
        /// <param name="FinancialYear">سال مالی</param>
        /// <param name="TransactionCode">کد سند</param>
        /// <param name="TransactionDate">تاریخ سند</param>
        /// <param name="TransactionTypeId">کد نوع سند: درآمد، هزینه، جابجایی، دریافت و پرداخت</param>
        /// <param name="SpecificAccountId">کد حساب معین</param>
        /// <param name="DetailedAccountId">کد حساب تفصیلی</param>
        /// <param name="Amount">مبلغ کل سند</param>
        /// <param name="PaymentBed">مبلغ بدهکار</param>
        /// <param name="PaymentBes">مبلغ بستانکار</param>
        /// <param name="ComerBId">کد سند بارنامه</param>
        /// <param name="Description">توضیحات</param>
        /// <param name="UserId">کد کاربر</param>
        /// <param name="Series">سریال سند</param>
        /// <param name="DateTime">تاریخ سیستم</param>
        /// <param name="FinalRegistry">وضعیت ثبت نهایی</param>
        /// <param name="Status">وضعیت ابطال سند</param>
        public static int AccountingDocumentRegistrationById(DBcontextModel db, int Id, int TransactionCode, string TransactionDate, int TransactionTypeId, int SpecificAccountId, int DetailedAccountId, double Amount, double PaymentBed, double PaymentBes, int ComerBId, string Description, int Series, bool IsAutoRejDoc, bool IsBeginningBalance = false)
        {
            {
                var ADR = new Repository<Transaction>(db);
                return ADR.SaveOrUpdateRefIdByCommit(new Transaction { Id = Id, FinancialYear = FinancialYear, TransactionCode = TransactionCode, TransactionDate = TransactionDate, TransactionTypeId = TransactionTypeId, SpecificAccountId = SpecificAccountId, DetailedAccountId = DetailedAccountId, Amount = Amount, PaymentBed = PaymentBed, PaymentBes = PaymentBes, ComerBId = ComerBId, Description = Description, UserId = UserId, Series = Series, DateTime = DateTime.Now, FinalRegistry = false, Status = false, IsAutoRejDoc = IsAutoRejDoc, IsBeginningBalance = IsBeginningBalance }, Id);
            }
        }
        /// <summary>
        /// ثبت چک ها
        /// </summary>
        /// <param name="db"></param>
        /// <param name="listId"></param>
        /// <param name="ChequeTypeId">نوع چک</param>
        /// <param name="ChequeNumber">سریال چک</param>
        /// <param name="Amount">مبلغ</param>
        /// <param name="DueDate">تاریخ سررسید</param>
        /// <param name="AccountId">کد حساب بانکی</param>
        /// <param name="DetailedAccountid">کد حساب طرف حساب چک</param>
        /// <param name="ChequeOwner">نام صاحب چک</param>
        /// <param name="DescriptionCh">توضیحات</param>
        /// <param name="TransactionId"></param>
        public static bool AddCheuqeToDatabase(DBcontextModel db,int listId, int ChequeTypeId,string ChequeNumber,double Amount,string DueDate,int AccountId,int DetailedAccountid,string ChequeOwner,string DescriptionCh, int TransactionId)
        {
            try
            {
                var ChequeSave = new Repository<Cheque>(db);
                int ChequeId = ChequeSave.SaveOrUpdateRefIdByCommit(new Cheque { Id = listId, ChequeTypeId = ChequeTypeId, ChequeNumber = ChequeNumber, Amount = Amount, DueDate = DueDate, IssueDate = PersianDate.NowPersianDate, AccountId = AccountId, Payer_Payee_AccId = DetailedAccountid, ChequeOwner = ChequeOwner, Description = DescriptionCh, CurrentStatusID = 0 }, listId);

                var ADR = new Repository<ChequeStatus>(db);
                int CurrentStatusID = ADR.SaveOrUpdateRefIdByCommit(new ChequeStatus { Id = 0, ChequeId = ChequeId, StatusDate = PersianDate.NowPersianDate, StatusCodeId = 2, TransactionId = TransactionId }, 0);

                var ch = db.Cheques.Where(c => c.Id == ChequeId).First();
                ch.CurrentStatusID = CurrentStatusID;
                return true;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return false;
            }
        }


        public static int AddToDetailedAccounts(int SpecificAccountId, int CustomerId)
        {
            using (var db = new DBcontextModel())
            {
                int ListId = 0;
                var code = new Repository<DetailedAccount>(db);
                return code.SaveOrUpdateRefId(new DetailedAccount { Id = ListId, SpecificAccountId = SpecificAccountId, CustomerId = CustomerId, CodeAccount = Convert.ToInt32(PublicClass.CeratDetailedAccountCode(SpecificAccountId).ToString()) }, ListId);
            }
        }


        /// <summary>
        /// کنترل تاریخ در بازه سال مالی
        /// </summary>
        /// <returns></returns>
        public static bool FinancialYearsControl(String Date)
        {
            using (var db = new DBcontextModel())
            {
                int FinancialYearId = Convert.ToInt32(FinancialYear);
                var D = db.FinancialYears.Where(c => c.Id == FinancialYearId).First();

                if (string.Compare(Date, D.DateStart) >= 0 && string.Compare(Date, D.DateEnd) <= 0)
                    return true;
                else
                    return false;
            }

        }


        public static System.Data.DataTable InputExcelToDataDataGridView(string AdresFit)
        {
            try
            {
                string connectionString =
                    "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"" + AdresFit +
                    "\";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";";

                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    con.Open();

                    // خواندن نام اولین شیت
                    System.Data.DataTable sheets = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string firstSheet = sheets.Rows[0]["TABLE_NAME"].ToString();

                    OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM [" + firstSheet + "]", con);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adp.Fill(dt);
                    return dt;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return null;
            }
        }

        public static System.Data.DataTable ReadExcel_ClosedXML(string path)
        {
            using (var workbook = new XLWorkbook(path))
            {
                var worksheet = workbook.Worksheet(1);
                var dt = new System.Data.DataTable();

                bool firstRow = true;
                foreach (var row in worksheet.RowsUsed())
                {
                    if (firstRow)
                    {
                        foreach (var cell in row.Cells())
                            dt.Columns.Add(cell.Value.ToString());
                        firstRow = false;
                    }
                    else
                    {
                        dt.Rows.Add(row.Cells().Select(c => c.Value.ToString()).ToArray());
                    }
                }
                return dt;
            }
        }

        /// <summary>
        /// متد خوانده از جدول دیتا گرید و قرار دادن در دیتاتیبل
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="Exception"></exception>
        public static System.Data.DataTable ReadExcel_NPOI(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("فایل پیدا نشد: " + path);

            IWorkbook workbook;
            using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                string ext = Path.GetExtension(path).ToLower();
                if (ext == ".xls")
                    workbook = new HSSFWorkbook(file);  // Excel 97-2003
                else if (ext == ".xlsx")
                    workbook = new XSSFWorkbook(file);  // Excel 2007+
                else
                    throw new Exception("فرمت فایل پشتیبانی نمی‌شود: " + ext);
            }

            ISheet sheet = workbook.GetSheetAt(0);
            if (sheet == null)
                throw new Exception("شیتی وجود ندارد.");

            System.Data.DataTable dt = new System.Data.DataTable();

            // Helper: خواندن متن یک سلول به صورت ایمن
            string GetCellText(ICell cell)
            {
                if (cell == null) return string.Empty;
                switch (cell.CellType)
                {
                    case CellType.String:
                        return cell.StringCellValue;
                    case CellType.Numeric:
                        if (DateUtil.IsCellDateFormatted(cell))
                            return cell.DateCellValue.ToString();
                        return cell.NumericCellValue.ToString();
                    case CellType.Boolean:
                        return cell.BooleanCellValue.ToString();
                    case CellType.Formula:
                        try
                        {
                            // تلاش برای گرفتن مقدار محاسبه‌شده
                            switch (cell.CachedFormulaResultType)
                            {
                                case CellType.String: return cell.StringCellValue;
                                case CellType.Numeric:
                                    if (DateUtil.IsCellDateFormatted(cell)) return cell.DateCellValue.ToString();
                                    return cell.NumericCellValue.ToString();
                                case CellType.Boolean: return cell.BooleanCellValue.ToString();
                                default: return cell.ToString();
                            }
                        }
                        catch { return cell.ToString(); }
                    default:
                        return cell.ToString();
                }
            }

            // خواندن عنوان ستون‌ها و ایجاد نام یکتا
            IRow headerRow = sheet.GetRow(0);
            if (headerRow == null)
                throw new Exception("ردیف عنوان ستون‌ها (سطر اول) خالی است.");

            int cellCount = headerRow.LastCellNum;
            var existingNames = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            for (int i = 0; i < cellCount; i++)
            {
                string rawName = GetCellText(headerRow.GetCell(i)).Trim();
                if (string.IsNullOrEmpty(rawName))
                    rawName = "Column" + (i + 1);

                string uniqueName = rawName;
                if (existingNames.ContainsKey(rawName))
                {
                    existingNames[rawName] = existingNames[rawName] + 1;
                    uniqueName = $"{rawName} ({existingNames[rawName]})";
                }
                else
                {
                    existingNames[rawName] = 0;
                }

                // در DataTable از نام ستون یکتا استفاده می‌کنیم
                dt.Columns.Add(uniqueName);
            }

            // خواندن سطرها
            for (int i = 1; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row == null) continue;

                DataRow dataRow = dt.NewRow();
                for (int j = 0; j < cellCount; j++)
                {
                    dataRow[j] = GetCellText(row.GetCell(j));
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }

        /// <summary>
        /// ایجاد عدد تصادفی 10 رقمی
        /// </summary>
        /// <param name="random"></param>
        /// <returns>نحوه استفاده</returns>
        /// <returns>Random rand = new Random();</returns>
        /// <returns>long tenDigitNumber = GenerateTenDigitRandomNumber(rand);</returns>
        public static long GetRandomLong(Random random)
        {
            // ایجاد یک آرایه 8 بایتی (8 بایت = 64 بیت = فضای ذخیره سازی یک long)
            byte[] buffer = new byte[8];

            // پر کردن آرایه با مقادیر تصادفی
            random.NextBytes(buffer);

            // تبدیل آرایه 8 بایتی به یک مقدار long (64-bit integer)
            return BitConverter.ToInt64(buffer, 0);
        }

        public static long GenerateTenDigitRandomNumber(Random random)
        {
            // تعریف محدوده: حداقل (کوچکترین عدد ۱۰ رقمی) و حداکثر (بزرگترین عدد ۱۰ رقمی)
            long min = 1_000_000_000L;
            long max = 9_999_999_999L;

            // تولید عدد long تصادفی و اعمال محدوده (Modulo arithmetic)
            // این روش برای نسخه‌های قدیمی که NextLong ندارند، استفاده می‌شود.

            // ۱. تفاوت بین حداکثر و حداقل را محاسبه کنید
            long range = max - min + 1;

            // ۲. یک عدد long تصادفی کامل تولید کنید
            long randLong = GetRandomLong(random);

            // ۳. آن را مثبت کنید (چون GetRandomLong می‌تواند منفی باشد)
            long positiveRand = Math.Abs(randLong);

            // ۴. آن را به محدوده مورد نظر محدود کنید
            return (positiveRand % range) + min;
        }


        public static (int, int) aaaa()
        {





            return (0, 0);
        }
    }
}
