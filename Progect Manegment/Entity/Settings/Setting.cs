using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Settings
{
    /// <summary>
    /// جدول تنظیمات
    /// </summary>
    public class Setting
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Subject { get; set; }
        public int IntCode1 { get; set; }
        public int IntCode2 { get; set; }
        public int IntCode3 { get; set; }
        public bool BoolCode1 { get; set; }
        public bool BoolCode2 { get; set; }
        public bool BoolCode3 { get; set; }
        public string StrCode1 { get; set; }
        public string StrCode2 { get; set; }
        public string StrCode3 { get; set; }
        public string StrCode4 { get; set; }
        public string StrCode5 { get; set; }
        public double DoubCode1 { get; set; }
        public double DoubCode2 { get; set; }
        public double DoubCode3 { get; set; }
        public byte[] Image1 { get; set; }
        public byte[] Image2 { get; set; }
        public byte[] Image3 { get; set; }
        ///// <summary>
        ///// پیش فرض
        ///// </summary>
        //public bool Default { get; set; }
        

        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }

    }
    public class SettingConfig : EntityTypeConfiguration<Setting>
    {
        public SettingConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Subject).HasMaxLength(int.MaxValue);
            Property(d => d.StrCode1).HasMaxLength(int.MaxValue);
            Property(d => d.StrCode2).HasMaxLength(int.MaxValue);
            Property(d => d.StrCode3).HasMaxLength(int.MaxValue);
            Property(d => d.StrCode4).HasMaxLength(int.MaxValue);
            Property(d => d.StrCode5).HasMaxLength(int.MaxValue);
        }
    }

}
