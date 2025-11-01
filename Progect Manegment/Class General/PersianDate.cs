using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace MyClass
{
    public static class PersianDate
    {
        /// <summary>
        /// یک استرینگ تاریخ شمسی را به معادل میلادی تبدیل میکند
        /// </summary>
        /// <param name="persianDate">تاریخ شمسی</param>
        /// <returns>تاریخ میلادی</returns>
        public static DateTime ToGeorgianDateTime(this string persianDate)
        {
            try
            {
                int year = Convert.ToInt32(persianDate.Substring(0, 4));
                int month = Convert.ToInt32(persianDate.Substring(5, 2));
                int day = Convert.ToInt32(persianDate.Substring(8, 2));
                DateTime georgianDateTime = new DateTime(year, month, day, new System.Globalization.PersianCalendar());
                return georgianDateTime;

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DateTime.Now;
            }
        }
        //_______________________________________________________
        /// <summary>
        /// یک تاریخ میلادی را به معادل فارسی آن تبدیل میکند
        /// </summary>
        /// <param name="georgianDate">تاریخ میلادی</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToPersianDateString(this DateTime georgianDate)
        {
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate).ToString();
            string month = persianCalendar.GetMonth(georgianDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(georgianDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDateString;
        }
        //_______________________________________________________
        /// <summary>
        /// یک تعداد روز را از یک تاریخ شمسی کم میکند یا به آن آضافه میکند
        /// </summary>
        /// <param name="georgianDate">تاریخ شمسی اول</param>
        /// <param name="days">تعداد روزی که میخواهیم اضافه یا کم کنیم</param>
        /// <returns>تاریخ شمسی به اضافه تعداد روز</returns>
        public static string AddDaysToShamsiDate(this string persianDate, int days)
        {
            DateTime dt = persianDate.ToGeorgianDateTime();
            dt = dt.AddDays(days);
            return dt.ToPersianDateString();
        }
        //-------------------------------------------------------
        public static string AddMontToShamsiDate(this string persianDate, int mont)
        {
            DateTime dt = persianDate.ToGeorgianDateTime();
            dt = dt.AddMonths(mont);
            return dt.ToPersianDateString();
        }

        //_______________________________________________________
        public static string NowPersianDate
        {
            get
            {
                PersianCalendar p = new PersianCalendar();
                DateTime d = DateTime.Now;//milady
                int year = p.GetYear(d);
                int month = p.GetMonth(d);
                int day = p.GetDayOfMonth(d);
                return FormatDate(year, month, day);
            }
        }
        //_______________________________________________________
        public static string FormatDate(int year, int month, int day)
        {
            return year + "/" + (month <= 9 ? "0" + month : month.ToString()) + "/" + (day <= 9 ? "0" + day : day.ToString());
        }
        //_______________________________________________________
        public static string MiladyToShamsi(DateTime d)
        {
            PersianCalendar p = new PersianCalendar();
            int year = p.GetYear(d);
            int month = p.GetMonth(d);
            int day = p.GetDayOfMonth(d);

            return FormatDate(year, month, day);
        }
        //_______________________________________________________
        public static int MohaseabatModatEntezar(string Date1, string Date2)
        {
            int year1 = Convert.ToInt16(Date1.Substring(0, 4));
            int month1 = Convert.ToInt16(Date1.Substring(5, 2));
            int day1 = Convert.ToInt16(Date1.Substring(8, 2));

            int year2 = Convert.ToInt16(Date2.Substring(0, 4));
            int month2 = Convert.ToInt16(Date2.Substring(5, 2));
            int day2 = Convert.ToInt16(Date2.Substring(8, 2));

            PersianCalendar calendar = new PersianCalendar();
            DateTime dt1 = calendar.ToDateTime(year1, month1, day1, 0, 0, 0, 0);
            DateTime dt2 = calendar.ToDateTime(year2, month2, day2, 0, 0, 0, 0);
            TimeSpan ts = dt2.Subtract(dt1);

            return ts.Days;
        }
        //_______________________________________________________

        public static bool ControlDateMiladi(string Data_)
        {
            int yy = int.Parse(Data_.Substring(0, 4));
            int mm = int.Parse(Data_.Substring(5, 2));
            int dd = int.Parse(Data_.Substring(8, 2));
            if (yy >= 1900 && yy <= 9999)
            {
                //check month
                if (mm >= 1 && mm <= 12)
                {
                    //check days
                    if ((dd >= 1 && dd <= 31) && (mm == 1 || mm == 3 || mm == 5 || mm == 7 || mm == 8 || mm == 10 || mm == 12))
                        return true;
                    else if ((dd >= 1 && dd <= 30) && (mm == 4 || mm == 6 || mm == 9 || mm == 11))
                        return true;

                    else if ((dd >= 1 && dd <= 28) && (mm == 2))
                        return true;

                    else if (dd == 29 && mm == 2 && (yy % 400 == 0 || (yy % 4 == 0 && yy % 100 != 0)))
                        return true;

                    else
                        return false;

                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //_______________________________________________________

        public static bool ControlDateShamsi(string Data_)
        {
            try
            {
                PersianCalendar jc = new PersianCalendar();
                int sal_ = int.Parse(Data_.Substring(0, 4));
                int mah_ = int.Parse(Data_.Substring(5, 2));
                int roz_ = int.Parse(Data_.Substring(8, 2));

                if (mah_ < 1 || mah_ > 12)
                    return false;

                if (mah_ <= 6)
                {
                    if (roz_ < 1 || roz_ > 31)
                        return false;
                }
                else
                {
                    if (!jc.IsLeapYear(sal_))
                    {
                        if (roz_ < 1 || roz_ > 29)
                            return false;
                    }
                    else
                    {
                        if (roz_ < 1 || roz_ > 30)
                            return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //-------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Time_"></param>
        /// <returns></returns>
        public static bool ControlTime(string Time_)
        {
            if (Time_.Length != 5)
                return false;
            if (int.Parse(Time_.Substring(0, 2)) >= 24)
                return false;
            if (int.Parse(Time_.Substring(3, 2)) >= 60)
                return false;

            return true;
        }

        //Todo کنترل تاریخ وارد شده که قبل از روز جاری بایستی باشد
        /// <summary>
        /// مقایس تاریخ میلادی مورد نظر با تاریخ جاری سیستم
        /// </summary>
        /// <param name="Date">تاریخ مورد نظر</param>
        /// <param name="Cod">کد:1=اجباری 2=غیراجباری</param>
        /// <returns></returns>
        public static int ComparisonOfTowDates(string Date, int Cod)
        {
            if (Cod==2) return 3;

            try
            {
                DateTime dt1 = Convert.ToDateTime(Date);
                DateTime dt2 = DateTime.Now;
                int r = dt1.CompareTo(dt2);
                return r;
            }
            catch (Exception)
            {
                return 2;
            }
        }

        /// <summary>
        /// متد محاسبه تاریخ شروع و پایان یک هفته
        /// </summary>
        /// <param name="Day"></param>
        /// <returns></returns>
        public static string Beginning_EndOfWeek(DateTime Day)
        {
            DateTime inputDate = Day; // تاریخ ورودی
            DateTime beginningOfWeek = inputDate.AddDays(-(int)inputDate.DayOfWeek); // تاریخ اولین روز هفته
            DateTime endOfWeek = beginningOfWeek.AddDays(6); // تاریخ آخرین روز هفته
            return beginningOfWeek.ToString("MM/dd/yyyy")+"|"+endOfWeek.ToString("MM/dd/yyyy");
        }

        /// <summary>
        /// محاسبه تاریخ شروع و پایان یک ماه با ورود تاریخ موردنظر
        /// </summary>
        /// <param name="Day"></param>
        /// <returns></returns>
        public static string Beginning_EndOfMount(DateTime Day)
        {
            // ورودی تاریخ
            DateTime inputDate = Day;
            // محاسبه تاریخ اول ماه
            DateTime firstDayOfMonth = new DateTime(inputDate.Year, inputDate.Month, 1);
            // محاسبه تاریخ آخر ماه
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            return firstDayOfMonth.ToString("MM/dd/yyyy")+"|"+lastDayOfMonth.ToString("MM/dd/yyyy");
        }

        /// <summary>
        /// محاسبه تاریخ شروع و پایان سال جاری با ورود تاریخ موردنظر
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static string Beginning_EndOfYear(DateTime year)
        {
            // ورودی تاریخ
            DateTime inputDate = year;
            //DateTime firstDayOfMonth = new DateTime(inputDate.Year, 1, 1);


            // محاسبه تاریخ اول ماه
            DateTime startOfYear = new DateTime(inputDate.Year, 1, 1);

            // محاسبه تاریخ آخر ماه
            DateTime endOfYear = new DateTime(inputDate.Year, 12, 31);

            //DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            return startOfYear.ToString("MM/dd/yyyy")+"|"+endOfYear.ToString("MM/dd/yyyy");
        }
        //ToDo کنترل صحت سنجی تاریخ میلادی
        /// <summary>
        /// کنترل صحت سنجی تاریخ میلادی
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool ValidateDate(string date)
        {
            DateTime dtValue;
            return DateTime.TryParse(date, out dtValue);
        }
    }

}
