using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Draver
{
    /// <summary>
    /// جدول راننده ها
    /// </summary>
    public class Draver
    {
        public int Id { get; set; }
        
        /// <summary>
        /// شخص
        /// </summary>
        public int CustomerId { get; set; }
        
        /// <summary>
        /// جنسیت
        /// </summary>
        public int GenderId { get; set; }
        
        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public string BirDate { get; set; }
        
        /// <summary>
        /// شهر
        /// </summary>
        //public int CityId { get; set; }
        
        /// <summary>
        /// سریال گواهینامه
        /// </summary>
        public string SeryalGovahiname { get; set; }
        
        /// <summary>
        /// سریال کارت هوشمند
        /// </summary>
        public string SmartCard { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// وضعیت
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;
        
        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }

        public virtual Customer.Customer Customers { get; set; }

        public virtual ICollection<Car.Car> CarId { get; set; }
    }
    public class DraverConfig : EntityTypeConfiguration<Draver>
    {
        public DraverConfig()
        {
            HasKey(x => x.Id);
            //Property(d => d.Name).IsRequired().HasMaxLength(100);
            Property(d => d.BirDate).IsRequired().HasMaxLength(10);
            Property(d => d.SeryalGovahiname).HasMaxLength(15);
            Property(d => d.SmartCard).HasMaxLength(15);

        }
    }

}
