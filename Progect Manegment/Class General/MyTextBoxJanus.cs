using Microsoft.Reporting.Map.WebForms.BingMaps;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_ERP_System.Class_General
{
    public partial class MyTextBoxJanus : Janus.Windows.GridEX.EditControls.EditBox
    {
        private string hint;
        private bool digitGroup = true;
        private string simpleText = string.Empty;
        private string simpleTextWatch = string.Empty;
        private string simpleTextDate = string.Empty;
        private string simpleTextTime = string.Empty;
        ToolTip toolTip1 = new ToolTip();

        public MyTextBoxJanus()
        {
            InitializeComponent();
        }
        private System.ComponentModel.IContainer components_ = null;
        public MyTextBoxJanus(IContainer container)
        {
            container.Add(this);
            components_ = new System.ComponentModel.Container();
            toolTip1.UseAnimation = true;

            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;

            InitializeComponent();
        }

        public void Copy_Clice(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(this.Text);
            }
            catch (Exception)
            {
            }
        }

        public void Paste_Clice(object sender, EventArgs e)
        {
            this.Text = Clipboard.GetText();
        }

        public void Delete_Clice(object sender, EventArgs e)
        {
            this.Text = "";
        }

        public void Select_Clice(object sender, EventArgs e)
        {
            this.SelectAll();
        }

        public enum TextBoxMode
        { CodMeli, DecNumber, IntNumber, TaghvimSamsi, Text, Watch }
        private TextBoxMode mode = TextBoxMode.Text;

        private Color color1 = Color.Yellow;
        [Category("TextBoxBackColorEnter"), Description("رنگ پس زمینه، زمان ورود به تکست باکس")]
        public Color TextBoxBackColorEnter
        {
            get { return color1; }
            set { color1 = value; }
        }

        private Color color2 = Color.Gray;
        [Category("TextWatermarkForeColor"), Description("رنگ فونت متن پس زمینه")]
        public Color TextWatermarkForeColor
        {
            get { return color2; }
            set { color2 = value; }
        }

        public enum TextWatermarkAlign
        { Left, Center, Right }
        private TextWatermarkAlign TWAmode = TextWatermarkAlign.Right;

        [Category("TextWMModeAlign"), DefaultValue(TextWatermarkAlign.Right), Description("مکان متن پس زمینه در داخل تکست باکس")]

        public TextWatermarkAlign TextWMModeAlign
        {
            get { return TWAmode; }
            set { TWAmode = value; }
        }

        private bool TextBoxColor_ = false;
        [Category("TextBoxBackColorCheng"), DefaultValue(false), Description("تغییر رنگ پس زمینه تکست باکس با ورود به داخل آن")]
        public bool TextBoxBackColorCheng
        {
            get { return TextBoxColor_; }
            set { TextBoxColor_ = value; }
        }

        private bool TextBoxEroreSendMaseg_ = true;


        [Category("TextBoxSendEroreMaseg"), DefaultValue(true), Description("ارسال پیام خطا در صورت ورود اطاعات ناقص")]
        public bool TextBoxSendEroreMaseg
        {
            get { return TextBoxEroreSendMaseg_; }
            set { TextBoxEroreSendMaseg_ = value; }
        }
        private bool CheackCodeMeli_ = false;
        public bool CheackCodeMeli
        {
            get { return CheackCodeMeli_; }
            set { CheackCodeMeli_ = value; }
        }

        private int codemelimextlength = 10;

        [Category("CodeMeliTextLength"), DefaultValue(10), Description("تعداد ارقام کد یا شناسه ملی")]
        public int CodeMeliTextLength
        {
            get { return codemelimextlength; }
            set { codemelimextlength = value; }
        }

        [Category("Mode"), DefaultValue(TextBoxMode.Text), Description("انتخاب نوع ورودی داده به تکست باکس")]
        public TextBoxMode TextMode
        {
            get { return mode; }
            set { mode = value; }
        }

        [Category("Mode"), DefaultValue(true), Description("Show the ',' character in numerics mode.")]
        public bool TextDigitGroup
        {
            get { return digitGroup; }
            set { digitGroup = value; }
        }
        //-------------------------------------------------------
        public string TextSimple
        {
            get { return simpleText; }
            set
            {
                if (mode == TextBoxMode.Text)
                    simpleText = value;
                else
                {
                    if (mode == TextBoxMode.DecNumber || mode == TextBoxMode.IntNumber)
                        simpleText = value.Replace(",", string.Empty);
                    if (mode == TextBoxMode.TaghvimSamsi)
                        simpleText = value.Replace("/", string.Empty);
                    if (mode == TextBoxMode.Watch)
                        simpleText = value.Replace(":", string.Empty);
                    simpleTextWatch = value.Replace(":", string.Empty);
                    simpleTextDate = value.Replace("/", string.Empty);
                }
            }
        }
        //-------------------------------------------------------



        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            switch (mode)
            {
                //کــد ملی
                case TextBoxMode.CodMeli:
                    if (this.SelectionLength == codemelimextlength)
                        this.Text = "";

                    if (!(char.IsDigit(key) || key == '\b'))
                        e.Handled = true;

                    if (this.TextLength >= codemelimextlength)
                        e.Handled = true;

                    if (this.SelectionLength != 0)
                        e.Handled = false;

                    if (key == '\b')
                        e.Handled = false;

                    break;


                //اعداد صحیح
                case TextBoxMode.IntNumber:
                    // این خط برای جلوگیری از ورود "0" در ابتدا بود که آن را حذف یا کامنت می کنیم.
                    //if (this.SelectionStart == 0 && key == '0')
                    //    e.Handled = true; 

                    // **تغییرات برای اجازه دادن به صفر:**
                    // اگر Text Box خالی است و کلید فشرده شده '0' است، اجازه ورود '0' را بدهید.
                    if (this.Text.Length == 0 && key == '0')
                    {
                        e.Handled = false;
                    }
                    // اگر یک کاراکتر وارد نشده است (یعنی SelectionLength != 0) یا کلید Backspace است، اجازه دهید.
                    else if (this.SelectionLength != 0 || key == '\b')
                    {
                        e.Handled = false;
                    }
                    // اگر در حال حاضر فقط یک "0" در Text Box هست و کاربر دوباره '0' میزند، یا کاراکتر دیگری غیر از عدد/Backpace میزند، جلوگیری کنید.
                    else if (this.Text == "0" && key == '0')
                    {
                        e.Handled = true;
                    }
                    // در غیر این صورت، اگر عدد یا Backspace نیست، جلوگیری کنید.
                    else if (!(char.IsDigit(key) || key == '\b'))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false; // اجازه ورود ارقام دیگر
                    }

                    // کد زیر به حالت اصلی خود باز می گردد اما باید منطق بالا جایگزین منطق قبلی (خط ۴۰۷) شود.
                    //if (!(char.IsDigit(key) || key == '\b'))
                    //    e.Handled = true;
                    break;
                //case TextBoxMode.IntNumber:
                //    if (this.SelectionStart == 0 && key == '0')
                //        e.Handled = true;


                //    if (!(char.IsDigit(key) || key == '\b'))
                //        e.Handled = true;
                //    break;

                //اعداد اعشاری
                case TextBoxMode.DecNumber:
                    if (this.SelectionStart == 0 && key == '0')
                    {
                        this.Text = this.Text.Insert(0, "0.");
                        e.Handled = true;
                    }

                    if (!(char.IsDigit(key) || key == '\b' || key == '.'))
                        e.Handled = true;
                    else if (key == '.' && simpleText.Contains("."))
                        e.Handled = true;
                    break;

                //ســـاعت
                case TextBoxMode.Watch:

                    if (this.SelectionLength == 5)
                        this.Text = "";

                    if (!(char.IsDigit(key) || key == '\b'))
                        e.Handled = true;
                    if (this.TextLength == 5)
                        e.Handled = true;


                    if (this.TextLength == 0 && key != '0' && key != '1' && key != '2')//
                        e.Handled = true;

                    if (this.TextLength == 1 && this.Text.Substring(0, 1) == "2" && key != '0' && key != '1' && key != '2' && key != '3')//
                        e.Handled = true;

                    if (this.TextLength == 2 && key != '0' && key != '1' && key != '2' && key != '3' && key != '4' && key != '5')//
                        e.Handled = true;

                    if (this.TextLength == 3 && this.Text.Substring(0, 3) == "000" && key == '0')//
                        e.Handled = true;


                    if (key == '\b')
                        e.Handled = false;
                    break;

                //تـــاریخ
                case TextBoxMode.TaghvimSamsi:
                    //=======================
                    bool IsSalKabiseh = false;
                    if (this.TextLength >= 6)
                    {
                        PersianCalendar jc = new PersianCalendar();
                        int sal_ = int.Parse(this.Text.Substring(0, 4));
                        try
                        {
                            if (jc.IsLeapYear(sal_))
                                IsSalKabiseh = true;
                        }
                        catch (Exception)
                        {
                        }
                    }
                    //=======================

                    if (this.SelectionLength == 10)
                        this.Text = "";

                    if (!(char.IsDigit(key) || key == '\b'))
                        e.Handled = true;

                    if (this.TextLength == 10)
                        e.Handled = true;

                    if (this.TextLength == 1 && (key == '0' || key == '1' || key == '2'))//
                        e.Handled = true;

                    if (this.TextLength == 4 && key != '1' && key != '0')//
                        e.Handled = true;

                    if (this.TextLength == 5 && this.Text.Substring(4, 1) == "0" && key == '0')//
                        e.Handled = true;
                    //--------------
                    if (this.TextLength == 5 && this.Text.Substring(4, 1) == "1" && key != '0' && key != '1' && key != '2')//
                        e.Handled = true;
                    //--------------
                    if (this.TextLength == 6 && int.Parse(this.Text.Substring(4, 2)) >= 01 && int.Parse(this.Text.Substring(4, 2)) <= 11)
                        if (key != '0' && key != '1' && key != '2' && key != '3')//
                            e.Handled = true;

                    if (this.TextLength == 6 && int.Parse(this.Text.Substring(4, 2)) == 12 && !IsSalKabiseh)//
                        if (key != '0' && key != '1' && key != '2')//
                            e.Handled = true;
                    if (this.TextLength == 6 && int.Parse(this.Text.Substring(4, 2)) == 12 && IsSalKabiseh)//
                        if (key != '0' && key != '1' && key != '2' && key != '3')//
                            e.Handled = true;
                    //--------------
                    if (this.TextLength == 7 && this.Text.Substring(6, 1) == "0" && key == '0')//
                        e.Handled = true;

                    if (this.TextLength == 7 && int.Parse(this.Text.Substring(4, 2)) >= 01 && int.Parse(this.Text.Substring(4, 2)) <= 06)//
                        if (int.Parse(this.Text.Substring(6, 1)) == 03)
                            if (key != '0' && key != '1')//
                                e.Handled = true;

                    if (this.TextLength == 7 && int.Parse(this.Text.Substring(4, 2)) >= 07 && int.Parse(this.Text.Substring(4, 2)) <= 11)//
                        if (int.Parse(this.Text.Substring(6, 1)) == 03)
                            if (key != '0')//
                                e.Handled = true;

                    if (this.TextLength == 7 && int.Parse(this.Text.Substring(4, 2)) == 12 && int.Parse(this.Text.Substring(6, 1)) == 3 && IsSalKabiseh && key != '0')
                        e.Handled = true;


                    if (key == '\b')
                        e.Handled = false;
                    break;
            }
            base.OnKeyPress(e);
        }
        //-------------------------------------------------------

        protected override void OnTextChanged(EventArgs e)
        {

            TextSimple = this.Text;
            string str = simpleText;
            string strT = simpleTextWatch;
            string strD = simpleTextDate;
            bool isText = false;

            switch (mode)
            {
                case TextBoxMode.Text:
                    #region
                    isText = true;
                    #endregion
                    break;


                case TextBoxMode.CodMeli:
                    #region
                    str = strT;
                    #endregion
                    break;

                case TextBoxMode.Watch:
                    #region
                    if (simpleTextWatch.Length == 4)
                        strT = strT.Insert(2, ":");
                    str = strT;
                    #endregion
                    break;

                case TextBoxMode.TaghvimSamsi:
                    #region
                    if (simpleTextDate.Length == 8)
                    {
                        strD = strD.Insert(4, "/");
                        strD = strD.Insert(7, "/");
                    }
                    str = strD;

                    //RF_DateToH(this.Text);
                    //toolTip1.SetToolTip(this, RF_DateToH(this.Text));
                    toolTip1.SetToolTip(this, Tarikh_To_Horof(this.Text, 1));

                    #endregion
                    break;

                case TextBoxMode.IntNumber:
                    #region , Handel
                    if (digitGroup)
                    {
                        toolTip1.SetToolTip(this, RefTo15Digit(this.TextSimple));
                        for (int i = simpleText.Length - 3; i > 0; i -= 3)
                            str = str.Insert(i, ",");
                    }
                    #endregion
                    break;

                case TextBoxMode.DecNumber:
                    #region 0. Handel
                    if (str.StartsWith("0") && str.IndexOf('.') != 1)
                    {
                        str = str.Replace(".", string.Empty);
                        str = str.Insert(1, ".");
                    }
                    if (str.IndexOf('.') == 0)
                        str = str.Insert(0, "0");
                    #endregion
                    #region , Handel
                    if (digitGroup)
                    {
                        if (simpleText.Contains("."))
                            for (int i = simpleText.IndexOf('.') - 3; i > 0; i -= 3)
                                str = str.Insert(i, ",");
                        else
                            for (int i = simpleText.Length - 3; i > 0; i -= 3)
                                str = str.Insert(i, ",");
                    }
                    #endregion
                    break;
            }
            if (isText)
            {
                this.Text = str;
                //this.Select(this.Text.Length, 0);
                base.OnTextChanged(e);
            }
            else
            {
                this.Text = str;
                this.Select(this.Text.Length, 0);
                base.OnTextChanged(e);
            }

        }
        //**************
        private System.Drawing.Color LFBC;
        //-------------------------------------------------------
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (mode == TextBoxMode.TaghvimSamsi)
            {
                if (e.KeyCode == Keys.Add) NextDay_Click(null, null);
                if (e.KeyCode == Keys.Subtract) PrevDay_Click(null, null);
                if (e.KeyCode == Keys.Multiply) Today_Click(null, null);
            }

            if (e.KeyCode == Keys.Add && e.Alt == true)

                this.Font = new Font("", this.Font.Size + 1);

            if (e.KeyCode == Keys.Subtract && e.Alt == true)

                try
                {
                    this.Font = new Font("", this.Font.Size - 1);
                }
                catch (Exception)
                {
                }

            if (e.KeyCode == Keys.Multiply && e.Alt == true)

                try
                {
                    this.Font = new Font("", 8);
                }
                catch (Exception)
                {
                }


            if (e.KeyCode == Keys.Decimal && mode == TextBoxMode.IntNumber)
                this.Text += "000";

        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.SelectionStart =this.Text.Length;
            LFBC = this.BackColor;

            if (TextBoxColor_)
                this.BackColor = color1;

            switch (this.TextLanguage)
            {
                /*
                case TextboxLanguage.Farsi:
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-IR"));
                    break;
                case TextboxLanguage.English:
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
                    break;
                default:
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));

                    break;
                    */
            }

            ContextMenuStrip cm = new ContextMenuStrip();


            if (mode == TextBoxMode.TaghvimSamsi)
            {
                this.SelectionStart = this.Text.Length;
                cm.Font = new System.Drawing.Font("tahoma", 9);
                cm.ForeColor = Color.Blue;
                cm.Items.Add("خالی کردن");//0
                cm.Items.Add("-");//1
                cm.Items.Add("امروز");//2
                cm.Items.Add("روز بعد");//3
                cm.Items.Add("روز قبل");//4
                cm.Items.Add("-");//5

                cm.Items.Add("اول هفته مورد نظر");//6
                cm.Items.Add("آخر هفنه مورد نظر");//7

                cm.Items.Add("-");//8

                cm.Items.Add("اول ماه مورد نظر");//9
                cm.Items.Add("آخر ماه مورد نظر");//10

                cm.Items.Add("-");//11

                cm.Items.Add("اول ماه جاری");//12
                cm.Items.Add("آخر ماه جاری");//13

                cm.Items.Add("-");//14

                cm.Items.Add("اول سال مورد نظر");//15
                cm.Items.Add("آخر سال مورد نظر");//16

                cm.Items.Add("-");//17

                cm.Items.Add("اول سال جاری");//18
                cm.Items.Add("آخر سال جاری");//19

                cm.Items.Add("-");//20

                cm.Items.Add("کپـــی");//21
                cm.Items.Add("الصاق");//22

                cm.Items.Add("-");//23
                cm.Items.Add("راهنما");//24
                this.ContextMenuStrip = cm;

                cm.Items[0].Click += new EventHandler(Null_Click);

                cm.Items[2].Click += new EventHandler(Today_Click);
                cm.Items[3].Click += new EventHandler(NextDay_Click);
                cm.Items[4].Click += new EventHandler(PrevDay_Click);

                cm.Items[6].Click += new EventHandler(FirstWeke_Click);
                cm.Items[7].Click += new EventHandler(EndYearWeke_Click);

                cm.Items[9].Click += new EventHandler(FirstDayOfMonth_Click);
                cm.Items[10].Click += new EventHandler(LastDayOfMonth_Click);

                cm.Items[12].Click += new EventHandler(FirstDayOfMonthJari_Click);
                cm.Items[13].Click += new EventHandler(LastDayOfMonthJari_Click);

                cm.Items[15].Click += new EventHandler(FirstYear_Click);
                cm.Items[16].Click += new EventHandler(EndYear_Click);

                cm.Items[18].Click += new EventHandler(FirstYearJari_Click);
                cm.Items[19].Click += new EventHandler(EndYearJari_Click);


                cm.Items[21].Click += new EventHandler(Copy_Click);
                cm.Items[22].Click += new EventHandler(Paste_Click);
                cm.Items[24].Click += new EventHandler(Help_Click);

                this.NowDateSelected = false;
                this.Invoke();

            }

            else if (mode == TextBoxMode.Watch)
            {
                cm.Font = new System.Drawing.Font("tahoma", 9);
                cm.Items.Add("زمان فعلی");
                this.ContextMenuStrip = cm;
                cm.Items[0].Click += new EventHandler(New_Time_Click);

            }
            /*
        else //if (mode == TextBoxMode.Text)
        {

            cm.Font = new System.Drawing.Font("tahoma", 9);
            cm.Items.Add("کپی");
            cm.Items.Add("الصاق");
            cm.Items.Add("-");
            cm.Items.Add("انتخاب همه");
            cm.Items.Add("حذف");
            this.ContextMenuStrip = cm;
                
            //if (this.PasswordChar.ToString() == "")
            //{
            //    cm.Items[0].Enabled = false;
            //}
                cm.Items[0].Click += new EventHandler(Copy_Clice);
                cm.Items[1].Click += new EventHandler(Paste_Clice);

            cm.Items[3].Click += new EventHandler(Select_Clice);
            cm.Items[4].Click += new EventHandler(Delete_Clice);


       }
        */
        }

        public void New_Time_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.Text = dt.ToString("HH:mm");
        }

        public PersianCalendar pc = new PersianCalendar();

        public void Invoke()
        {
            if (this.NowDateSelected)
            {
                this.Text = MiladiToShamsi(DateTime.Now);
                this.Miladi = DateTime.Now.Date;
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");
            }
        }

        public void Copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(this.Text);
            }
            catch (Exception)
            {
            }
        }

        public void Paste_Click(object sender, EventArgs e)
        {
            this.Text = Clipboard.GetText();
        }
        public void Help_Click(object sender, EventArgs e)
        {
            try
            {
                //School_management.frm_HelpTarikh f = new School_management.frm_HelpTarikh();
                //f.ShowDialog();

            }
            catch (Exception)
            {
            }
        }


        public void FirstWeke_Click(object sender, EventArgs e)
        {
            try
            {
                int Year = int.Parse(this.Text.Substring(0, 4));//1399/10/11
                int Mont = int.Parse(this.Text.Substring(5, 2));
                int Day = int.Parse(this.Text.Substring(8, 2));
                int Roz = int.Parse(Tarikh_To_Horof(this.Text, 3));
                this.Miladi = pc.AddDays(pc.ToDateTime(Year, Mont, Day, 0, 0, 0, 0), -Roz);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");
            }
            catch (Exception)
            {
            }
        }

        public void EndYearWeke_Click(object sender, EventArgs e)
        {
            try
            {
                int Year = int.Parse(this.Text.Substring(0, 4));//1399/10/11
                int Mont = int.Parse(this.Text.Substring(5, 2));
                int Day = int.Parse(this.Text.Substring(8, 2));
                int Roz = int.Parse(Tarikh_To_Horof(this.Text, 3));
                this.Miladi = pc.AddDays(pc.ToDateTime(Year, Mont, Day, 0, 0, 0, 0), 6 - Roz);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");
            }
            catch (Exception)
            {
            }
        }

        public void FirstYear_Click(object sender, EventArgs e)
        {
            try
            {
                int Year = int.Parse(this.Text.Substring(0, 4));
                this.Miladi = pc.ToDateTime(Year, 1, 1, 0, 0, 0, 0);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");

            }
            catch (Exception)
            {
            }
        }

        public void EndYear_Click(object sender, EventArgs e)
        {
            try
            {
                int Year = int.Parse(this.Text.Substring(0, 4));
                this.Miladi = pc.ToDateTime(Year, 12, pc.GetDaysInMonth(Year, 12), 0, 0, 0, 0);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");

            }
            catch (Exception)
            {
            }
        }

        public void FirstYearJari_Click(object sender, EventArgs e)
        {
            try
            {
                this.Miladi = pc.ToDateTime(pc.GetYear(DateTime.Now), 1, 1, 0, 0, 0, 0);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");

            }
            catch (Exception)
            {
            }
        }

        public void EndYearJari_Click(object sender, EventArgs e)
        {
            try
            {
                this.Miladi = pc.ToDateTime(pc.GetYear(DateTime.Now), 12, pc.GetDaysInMonth(pc.GetYear(DateTime.Now), pc.GetMonth(DateTime.Now)), 0, 0, 0, 0);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");

            }
            catch (Exception)
            {

            }
        }

        public void FirstDayOfMonth_Click(object sender, EventArgs e)
        {
            try
            {
                int Year = int.Parse(this.Text.Substring(0, 4));
                int Mont = int.Parse(this.Text.Substring(5, 2));
                this.Miladi = pc.ToDateTime(Year, Mont, 1, 0, 0, 0, 0);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");

            }
            catch (Exception)
            {
            }
        }

        public void LastDayOfMonth_Click(object sender, EventArgs e)
        {
            try
            {
                int Year = int.Parse(this.Text.Substring(0, 4));
                int Mont = int.Parse(this.Text.Substring(5, 2));
                this.Miladi = pc.ToDateTime(Year, Mont, pc.GetDaysInMonth(Year, Mont), 0, 0, 0, 0);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");

            }
            catch (Exception)
            {
            }
        }

        public void LastDayOfMonthJari_Click(object sender, EventArgs e)
        {
            try
            {
                this.Miladi = pc.ToDateTime(pc.GetYear(DateTime.Now), pc.GetMonth(DateTime.Now), pc.GetDaysInMonth(pc.GetYear(DateTime.Now), pc.GetMonth(DateTime.Now)), 0, 0, 0, 0);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");

            }
            catch (Exception)
            {
            }
        }

        public void FirstDayOfMonthJari_Click(object sender, EventArgs e)
        {
            try
            {
                this.Miladi = pc.ToDateTime(pc.GetYear(DateTime.Now), pc.GetMonth(DateTime.Now), 1, 0, 0, 0, 0);
                this.Text = MiladiToShamsi(this.Miladi);
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");
            }
            catch (Exception)
            {
            }
        }

        public void PrevDay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                try
                {
                    this.Miladi = this.Miladi.AddDays(-1);
                    this.Text = MiladiToShamsi(this.Miladi);
                    this.Shamsi = MiladiToShamsi(this.Miladi);
                    this.SelectedDate = this.Shamsi.Replace("/", "");

                }
                catch (Exception)
                {
                }
            }
        }

        public void NextDay_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.Text))
                {
                    this.Miladi = this.Miladi.AddDays(1);
                    this.Text = MiladiToShamsi(this.Miladi);
                    this.Shamsi = MiladiToShamsi(this.Miladi);
                    this.SelectedDate = this.Shamsi.Replace("/", "");
                }

            }
            catch (Exception)
            {
            }
        }

        public void Today_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = MiladiToShamsi(DateTime.Now);
                this.Miladi = DateTime.Now.Date;
                this.Shamsi = MiladiToShamsi(this.Miladi);
                this.SelectedDate = this.Shamsi.Replace("/", "");

            }
            catch (Exception)
            {
            }
        }

        public void Null_Click(object sender, EventArgs e)
        {
            this.Text = null;
            //this.Miladi = new DateTime().Date;
        }

        public DateTime Miladi { get; set; }
        public bool SwitchDateFlag = false;
        public string Shamsi { get; set; }

        public bool NowDateSelected { get; set; }

        public string SelectedDate { get; set; }


        //-------------------------------------------------------
        string txtErore = "";
        void showmaseg()
        {
            MessageBox.Show(txtErore, "خطــا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        protected override void OnLeave(EventArgs e)
        {

            base.OnLeave(e);
            this.BackColor = LFBC;

            switch (mode)
            {
                case TextBoxMode.TaghvimSamsi://تاریخ
                    if (this.Text != "" && this.TextLength != 10)
                    {
                        txtErore = "تــاریخ وارد شده صحیح نمی باشد";
                        this.Focus();
                        //this.BackColor = color3;
                        if (TextBoxEroreSendMaseg_)
                            showmaseg();
                    }
                    else
                        this.BackColor = this.BackColor = LFBC;
                    break;
                case TextBoxMode.Watch://ساعت
                    if (this.Text != "" && this.TextLength != 5)
                    {
                        txtErore = "ساعت وارد شده صحیح نمی باشد";
                        //this.BackColor = color3;
                        this.Focus();
                        if (TextBoxEroreSendMaseg_)
                            showmaseg();

                    }
                    else
                        this.BackColor = this.BackColor = LFBC;
                    break;
                case TextBoxMode.CodMeli://کد ملی
                    if (this.Text != "" && (this.TextLength != 10 || !checCodmeli(this.Text)) && CheackCodeMeli_)
                    {
                        txtErore = "کــد ملــی وارد شده صحیح نمی باشد";


                        this.Focus();
                        if (TextBoxEroreSendMaseg_)
                            showmaseg();
                    }
                    else
                        this.BackColor = this.BackColor = LFBC;

                    break;

            }


        }
        [Category("TextLanguage"), DefaultValue(TextboxLanguage.Farsi), Description("زبان نوشتاری تکست باکس")]
        public TextboxLanguage TextLanguage { get; set; }

        public enum TextboxLanguage
        {
            Farsi, English
        }

        [Category("TextWatermark"), Description("متن پس زمینه تکست باکس در زمان خالی بودن")]
        public string TextWatermark
        {
            get { return hint; }
            set { hint = value; this.Invalidate(); }
        }

        protected override void WndProc(ref Message m)
        {
            TextFormatFlags Align = new TextFormatFlags();
            switch (TWAmode)
            {
                case TextWatermarkAlign.Left:
                    Align = TextFormatFlags.Left;
                    break;
                case TextWatermarkAlign.Center:
                    Align = TextFormatFlags.HorizontalCenter;
                    break;
                case TextWatermarkAlign.Right:
                    Align = TextFormatFlags.Right;
                    break;
            }

            base.WndProc(ref m);
            if (m.Msg == 0xf)
            {
                if (!this.Focused && string.IsNullOrEmpty(this.Text)
                    && !string.IsNullOrEmpty(this.TextWatermark))
                {
                    using (var g = this.CreateGraphics())
                    {
                        TextRenderer.DrawText(g, this.TextWatermark, this.Font, this.ClientRectangle, color2, this.BackColor, Align | Align);
                    }
                }
            }
        }
        // بررسی کد ملی
        public bool checCodmeli(string NumberCodMeli)
        {
            if (NumberCodMeli == "" || NumberCodMeli.Length != 10)
            {
                return false;
            }
            for (int i = 0; i <= 9; i++)
            {
                string s = new string((char)(i + 48), 10);
                if (s == NumberCodMeli)
                {
                    return false;
                }
            }
            int p1, p2, p3;
            p1 = 0;
            for (int i = 0; i <= 8; i++)
            {
                p1 += (int.Parse((NumberCodMeli.Substring(i, 1))) * (10 - i));
            }
            p2 = p1 - p1 / 11 * 11;
            if (p2 > 1)
                p2 = 11 - p2;
            p3 = int.Parse(NumberCodMeli.Substring(9, 1));
            if (p3 == p2)
                return true;
            else
                return false;
        }
        //-------------------------------------------------------
        public bool validate(string dateStr, bool dateCheck)
        {
            if (dateStr == "    /  /")
            {
                return true;
            }
            PersianCalendar pr = new PersianCalendar();
            int NowYear = pr.GetYear(DateTime.Now);
            int NowMonth = pr.GetMonth(DateTime.Now);
            int NowDay = pr.GetDayOfMonth(DateTime.Now);
            bool flag = false;
            if (dateStr.Length > 0)
            {
                int txtLenth = dateStr.Length;
                string[] str = dateStr.Split('/');
                int strLenght = str.Length;
                if (strLenght < 3 || strLenght < 2 || strLenght < 1 || strLenght < 0)
                {
                    return true;
                }
                string year = date(str[0]);
                string month = date(str[1]);
                string day = date(str[2]);
                if (string.IsNullOrEmpty(year) || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(day))
                {
                    return true;
                }

                if (dateCheck)
                {
                    if (int.Parse(month) == 12 && int.Parse(day) > 29)
                        flag = true;
                    if (int.Parse(year) < 1370 || int.Parse(year) > 1399 || year.Length <= 1 || int.Parse(year) > NowYear)
                        flag = true;
                    if (int.Parse(month) < 1 || int.Parse(month) > 12 || month.Length <= 1)
                        flag = true;
                    if (int.Parse(day) < 1 || int.Parse(day) > 31 || day.Length <= 1)
                        flag = true;
                }
                else
                {
                    if (int.Parse(month) == 12 && int.Parse(day) > 29)
                        flag = true;
                    if (int.Parse(year) < 1370 || int.Parse(year) > 1399 || year.Length <= 1)
                        flag = true;
                    if (int.Parse(month) < 1 || int.Parse(month) > 12 || month.Length <= 1)
                        flag = true;
                    if (int.Parse(day) < 1 || int.Parse(day) > 31 || day.Length <= 1)
                        flag = true;
                }

            }
            if (flag)
            {
                return true;
            }
            else
                return false;
        }
        public string date(string sr)
        {
            char[] srr;
            srr = sr.ToArray();
            string c = string.Empty;
            for (int i = 0; i < srr.Length; i++)
            {
                string srss = srr[i].ToString();
                switch (srss)
                {
                    case "۰":
                        c += "0";
                        break;
                    case "۱":
                        c += "1";
                        break;
                    case "۲":
                        c += "2";
                        break;
                    case "۳":
                        c += "3";
                        break;
                    case "۴":
                        c += "4";
                        break;
                    case "۵":
                        c += "5";
                        break;
                    case "۶":
                        c += "6";
                        break;
                    case "۷":
                        c += "7";
                        break;
                    case "۸":
                        c += "8";
                        break;
                    case "۹":
                        c += "9";
                        break;
                    case "0":
                        c += "0";
                        break;
                    case "1":
                        c += "1";
                        break;
                    case "2":
                        c += "2";
                        break;
                    case "3":
                        c += "3";
                        break;
                    case "4":
                        c += "4";
                        break;
                    case "5":
                        c += "5";
                        break;
                    case "6":
                        c += "6";
                        break;
                    case "7":
                        c += "7";
                        break;
                    case "8":
                        c += "8";
                        break;
                    case "9":
                        c += "9";
                        break;
                    default:
                        c = sr;
                        break;
                }

            }
            return c;
        }
        public string GetDateStr(string str)
        {
            string st = str;
            string[] words = st.Split('/');
            string Result = string.Empty;
            string Year;
            string Month;
            string Day;
            Year = datestr(words[0]);
            Month = datestr(words[1]);
            Day = datestr(words[2]);
            Result = Year + "/" + Month + "/" + Day;
            return Result;
        }
        public string datestr(string sr)
        {
            char[] srr;
            srr = sr.ToArray();
            string c = string.Empty;
            for (int i = 0; i < srr.Length; i++)
            {
                string srss = srr[i].ToString();
                switch (srss)
                {
                    case "0":
                        c += "۰";
                        break;
                    case "1":
                        c += "۱";
                        break;
                    case "2":
                        c += "۲";
                        break;
                    case "3":
                        c += "۳";
                        break;
                    case "4":
                        c += "۴";
                        break;
                    case "5":
                        c += "۵";
                        break;
                    case "6":
                        c += "۶";
                        break;
                    case "7":
                        c += "۷";
                        break;
                    case "8":
                        c += "۸";
                        break;
                    case "9":
                        c += "۹";
                        break;
                    case "۰":
                        c += "۰";
                        break;
                    case "۱":
                        c += "۱";
                        break;
                    case "۲":
                        c += "۲";
                        break;
                    case "۳":
                        c += "۳";
                        break;
                    case "۴":
                        c += "۴";
                        break;
                    case "۵":
                        c += "۵";
                        break;
                    case "۶":
                        c += "۶";
                        break;
                    case "۷":
                        c += "۷";
                        break;
                    case "۸":
                        c += "۸";
                        break;
                    case "۹":
                        c += "۹";
                        break;
                    default:
                        c = sr;
                        break;
                }

            }
            return c;
        }
        DateTime dt;
        public DateTime GetDate(string str)
        {
            string st = str;
            string[] words = st.Split('/');
            string Result = string.Empty;
            string Year;
            string Month;
            string Day;
            Year = dateR(words[0]);
            Month = dateR(words[1]);
            Day = dateR(words[2]);
            if (int.Parse(Month) > 12 || int.Parse(Day) > 31)
            {
                MessageBox.Show("قالب تاریخ نادرست است", "خطا");
                return dt;
            }
            else
            {

                PersianCalendar pc = new PersianCalendar();
                dt = new DateTime(int.Parse(Year), int.Parse(Month), int.Parse(Day), pc);
                return dt;
            }
        }
        public string dateR(string sr)
        {
            char[] srr;
            srr = sr.ToArray();
            string c = string.Empty;
            for (int i = 0; i < srr.Length; i++)
            {
                string srss = srr[i].ToString();
                switch (srss)
                {
                    case "۰":
                        c += "0";
                        break;
                    case "۱":
                        c += "1";
                        break;
                    case "۲":
                        c += "2";
                        break;
                    case "۳":
                        c += "3";
                        break;
                    case "۴":
                        c += "4";
                        break;
                    case "۵":
                        c += "5";
                        break;
                    case "۶":
                        c += "6";
                        break;
                    case "۷":
                        c += "7";
                        break;
                    case "۸":
                        c += "8";
                        break;
                    case "۹":
                        c += "9";
                        break;
                    case "0":
                        c += "0";
                        break;
                    case "1":
                        c += "1";
                        break;
                    case "2":
                        c += "2";
                        break;
                    case "3":
                        c += "3";
                        break;
                    case "4":
                        c += "4";
                        break;
                    case "5":
                        c += "5";
                        break;
                    case "6":
                        c += "6";
                        break;
                    case "7":
                        c += "7";
                        break;
                    case "8":
                        c += "8";
                        break;
                    case "9":
                        c += "9";
                        break;
                    default:
                        c = sr;
                        break;
                }

            }
            return c;
        }
        //-------------------------------------------------------

        public int Year
        {
            get;
            set;
        }
        public int Month
        {
            get;
            set;
        }
        public int Day
        {
            get;
            set;
        }

        public void ConvertDate()
        {
        }

        public void ConvertDate(DateTime Date)
        {
            PersianCalendar pc = new PersianCalendar();
            this.Year = pc.GetYear(Date);
            this.Month = pc.GetMonth(Date);
            this.Day = pc.GetDayOfMonth(Date);
        }

        public string MiladiToShamsi(DateTime Mdate)
        {
            try
            {
                PersianCalendar pc = new PersianCalendar();
                string Result = pc.GetYear(Mdate).ToString();
                string Month = Convert.ToString(pc.GetMonth(Mdate).ToString("00"));
                string day = Convert.ToString(pc.GetDayOfMonth(Mdate).ToString("00"));
                Result += "/" + Month + "/" + day;
                return Result;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string func_PersianDateFormat(DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            StringBuilder sb = new StringBuilder();
            sb.Append(pc.GetYear(date).ToString("0000"));
            sb.Append("/");
            sb.Append(pc.GetMonth(date).ToString("00"));
            sb.Append("/");
            sb.Append(pc.GetDayOfMonth(date).ToString("00"));
            return sb.ToString();
        }

        public void SetDate(DateTime Date)
        {
            PersianCalendar pc = new PersianCalendar();
            this.Year = pc.GetYear(Date);
            this.Month = pc.GetMonth(Date);
            this.Day = pc.GetDayOfMonth(Date);
        }

        public int getYear()
        {
            return this.Year;
        }
        public int getMounth()
        {
            return this.Month;
        }
        public int getDay()
        {
            return this.Day;
        }
        public string Number { get; set; }
        //_______________________________________________________
        private string Equivalent3(string t)
        {
            try
            {
                Hashtable arr = new Hashtable();
                arr.Add(0, ""); arr.Add(1, "یک"); arr.Add(2, "دو"); arr.Add(3, "سه"); arr.Add(4, "چهار"); arr.Add(5, "پنج"); arr.Add(6, "شش"); arr.Add(7, "هفت"); arr.Add(8, "هشت"); arr.Add(9, "نه"); arr.Add(10, "ده"); arr.Add(11, "یازده"); arr.Add(12, "دوازده"); arr.Add(13, "سیزده"); arr.Add(14, "چهارده"); arr.Add(15, "پانزده"); arr.Add(16, "شانزده"); arr.Add(17, "هفده"); arr.Add(18, "هجده"); arr.Add(19, "نوزده"); arr.Add(20, "بیست"); arr.Add(30, "سی"); arr.Add(40, "چهل"); arr.Add(50, "پنجاه"); arr.Add(60, "شصت"); arr.Add(70, "هفتاد"); arr.Add(80, "هشتاد"); arr.Add(90, "نود"); arr.Add(100, "یکصد"); arr.Add(200, "دویست"); arr.Add(300, "سیصد"); arr.Add(400, "چهارصد"); arr.Add(500, "پانصد"); arr.Add(600, "ششصد"); arr.Add(700, "هفتصد"); arr.Add(800, "هشتصد"); arr.Add(900, "نهصد");
                object o = int.Parse(t);

                if (!arr.ContainsKey(o))
                {
                    int a = int.Parse(t);
                    string b = a.ToString();
                    int l = b.Length;

                    t = "";
                    int i = 0;

                    if (l == 3)
                        i = 100;
                    else
                        i = 10;

                    while (a != 0)
                    {
                        string va1 = "";
                        string va2 = " و ";

                        if (i == 100)
                        {
                            va1 = "";
                            va2 = " و ";
                        }

                        if (a < 20)
                        {
                            t = t + va2 + arr[a].ToString() + va1;
                            a = a - a / i * i;
                            i = i / 10;
                            break;
                        }
                        else
                        {
                            t = t + va2 + arr[a / i * i].ToString() + va1;
                            a = a - a / i * i;
                            i = i / 10;
                        }

                    }
                    if (t.StartsWith(" و "))
                        t = t.Remove(0, 3);
                    return t;
                }
                else
                    return arr[o].ToString();

            }
            catch (Exception)
            {
                return "";
            }
        }
        //_______________________________________________________
        public string RefTo3Digit(string s)
        {
            return Equivalent3(s);
        }
        //_______________________________________________________
        public string RefTo15Digit(string s)
        {
            string t = "";
            s = s.PadLeft(15, '0');

            if (s == "000000000000000") return ("صفر");

            //هزار میلیارد
            if (!(s.Substring(0, 3) == "000"))
            {
                t = t + RefTo3Digit((s.Substring(0, 3))) + " هزار ";

                if (!(s.Substring(3, 12) == "000000000000"))
                {
                    if (!(s.Substring(3, 3) == "000"))
                        t = t + " و";
                }
            }

            // میلیارد
            if (!(s.Substring(3, 3) == "000"))
            {
                t = t + RefTo3Digit((s.Substring(3, 3))) + " ميليارد ";
                if (!(s.Substring(6, 9) == "000000000")) t = t + " و ";
            }
            else
            {
                if (!(s.Substring(0, 3) == "000")) t = t + " ميليارد و ";
            }

            //میلیون
            if (!(s.Substring(6, 3) == "000"))
            {
                t = t + RefTo3Digit((s.Substring(6, 3))) + " ميليون ";
                if (!(s.Substring(9, 6) == "000000")) t = t + " و ";
            }

            // هزار
            if (!(s.Substring(9, 3) == "000"))
            {
                t = t + RefTo3Digit((s.Substring(9, 3))) + " هزار ";
                if (!(s.Substring(12, 3) == "000")) t = t + " و ";
            }

            // صد
            if (!(s.Substring(12, 3) == "000"))
            {
                t = t + RefTo3Digit((s.Substring(12, 3)));
            }
            return t;
        }
        //_______________________________________________________
        public static string Tarikh_To_Horof(string Tarikh, int Mode)
        {
            //   1399/09/17  تاریخ ایجاد این تابع

            try
            {
                int yyyy = int.Parse(Tarikh.Substring(0, 4));
                int mm = int.Parse(Tarikh.Substring(5, 2));
                int dd = int.Parse(Tarikh.Substring(8, 2));

                PersianCalendar PC = new PersianCalendar();
                DateTime dt = new DateTime(yyyy, mm, dd, PC);
                string TXT = "";
                string Mah = "";
                string day = dt.DayOfWeek.ToString();
                string RozH = "";
                string RozA = "";
                switch (day)
                {
                    case "Saturday":
                        RozH = "شنبه";
                        RozA = "0";
                        break;
                    case "Sunday":
                        RozH = "یک شنبه";
                        RozA = "1";
                        break;
                    case "Monday":
                        RozH = "دو شنبه";
                        RozA = "2";
                        break;
                    case "Tuesday":
                        RozH = "سه شنبه";
                        RozA = "3";
                        break;
                    case "Wednesday":
                        RozH = "چهار شنبه";
                        RozA = "4";
                        break;
                    case "Thursday":
                        RozH = "پنج شنبه";
                        RozA = "5";
                        break;
                    case "Friday":
                        RozH = "جمعه";
                        RozA = "6";
                        break;
                }
                switch (int.Parse(Tarikh.Substring(5, 2)))
                {
                    case 1:
                        Mah = "فروردین";
                        break;
                    case 2:
                        Mah = "اردیبهشت";
                        break;
                    case 3:
                        Mah = "خرداد";
                        break;
                    case 4:
                        Mah = "تیر";
                        break;
                    case 5:
                        Mah = "مرداد";
                        break;
                    case 6:
                        Mah = "شهریور";
                        break;
                    case 7:
                        Mah = "مهر";
                        break;
                    case 8:
                        Mah = "آبان";
                        break;
                    case 9:
                        Mah = "آذر";
                        break;
                    case 10:
                        Mah = "دی";
                        break;
                    case 11:
                        Mah = "بهمن";
                        break;
                    case 12:
                        Mah = "اسفند";
                        break;

                }
                switch (Mode)
                {
                    case 0:
                        TXT = RozH;
                        break;
                    case 1:
                        TXT = RozH + "، " + Tarikh.Substring(8, 2) + " " + Mah + " " + Tarikh.Substring(0, 4);
                        break;
                    case 3:
                        TXT = RozA;
                        break;

                }
                return TXT;

            }
            catch (Exception)
            {
                return "خطا در ثبت تاریخ";
            }
        }
    }
}
