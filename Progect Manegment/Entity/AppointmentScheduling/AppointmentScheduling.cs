using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.AppointmentScheduling
{
    /// <summary>
    /// جدول نوبت دهی
    /// </summary>
    public  class AppointmentScheduling
    {
        public int Id { get; set; }

        /// <summary>
        /// کد کامیون
        /// </summary>
        public int CarId { get; set; }
        
        
        /// <summary>
        /// تاریخ 
        /// </summary>
        public string Date { get; set; }
       /// <summary>
       /// ساعت
       /// </summary>
        public string Time { get; set; }
        /// <summary>
        /// لیست استان ها
        /// </summary>
        public string ProvincesList { get; set; }
        /// <summary>
        /// وضعیت فعال/غیرفعال
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// در وضعیت انتخاب
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }
    }
    public class AppointmentSchedulingConfig : EntityTypeConfiguration<AppointmentScheduling>
    {
        public AppointmentSchedulingConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Date).IsRequired().HasMaxLength(10);
            Property(d => d.Time).IsRequired().HasMaxLength(5);
            Property(d => d.ProvincesList).IsRequired().HasMaxLength(int.MaxValue);
        }
    }

}
