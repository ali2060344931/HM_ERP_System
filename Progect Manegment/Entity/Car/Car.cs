using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Car
{
    /// <summary>
    /// جدول خودروها
    /// </summary>
    public class Car
    {
        public int Id { get; set; }
        /// <summary>
        /// نام خودرو
        /// </summary>
        public string CarName { get; set; }
        /// <summary>
        /// مدل ساخت
        /// </summary>
        public int CreatModel { get; set; }
        /// <summary>
        /// شماره پلاک
        /// </summary>  
        public string CarPlat { get; set; }
        /// <summary>
        /// سریال پلاک
        /// </summary>
        public string CarPlatSeryal { get; set; }
        /// <summary>
        /// سریال هوشمند
        /// </summary>
        public string Seryal { get; set; }
        /// <summary>
        /// راننده
        /// </summary>
        public int DraverId { get; set; }
        /// <summary>
        /// تعداد محور
        /// </summary>
        public int AxisCount { get; set; }
        /// <summary>
        /// وضعیت مالکیت
        /// </summary>

        public int OwnershipId { get; set; }
        /// <summary>
        /// شرکت مالک
        /// </summary>
        public int OwnershipCompanyId { get; set; }

        /// <summary>
        /// کد طرف حساب
        /// </summary>
        public int GoodsAccountId { get; set; }
        /// <summary>
        /// کد نوع کاربری
        /// </summary>
        public int TruckUsageTypeId { get; set; }
        /// <summary>
        /// ظرفیت مجاز کامیون
        /// </summary>
        public int TruckCapacity { get; set; }

        /// <summary>
        /// ظرفیت مجاز بارگیری
        /// </summary>
        public int LoadWeightCapacity { get; set; }

        /// <summary>
        /// وضعیت فعال/غیرفعال
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// وضعیت کامیون در بارنامه
        /// یعنی امکان صدور حواله را دارد یا خیر
        /// </summary>
        public bool StatusCarToComers { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }

        public virtual Draver.Draver Dravers { get; set; }
        public virtual Ownership.Ownership Ownerships { get; set; }
        public virtual Customer.Customer GoodsAccounts { get; set; }
        public virtual TruckUsageType.TruckUsageType TruckUsageTypes { get; set; }

    }
    public class CarConfig : EntityTypeConfiguration<Car>
    {
        public CarConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.CarName).IsRequired().HasMaxLength(50);

            Property(d => d.CarPlat).IsRequired().HasMaxLength(5);
            Property(d => d.CarPlatSeryal).IsRequired().HasMaxLength(2);
            Property(d => d.Seryal).HasMaxLength(10);
            Property(d => d.Description).HasMaxLength(int.MaxValue);
        }
    }


}
