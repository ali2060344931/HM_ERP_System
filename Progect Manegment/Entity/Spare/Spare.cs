using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Spare
{
    /// <summary>
    /// جدول یدک ها
    /// </summary>
    public class Spare
    {
        public int Id { get; set; }
        /// <summary>
        /// شماره قرارداد
        /// </summary>
        public string  ContactNo { get; set; }
       /// <summary>
       /// شماره تانکر
       /// </summary>
        public string TankerNo { get; set; }
        /// <summary>
        /// کد کامیون
        /// </summary>
        public int CarId { get; set; }
        /// <summary>
        /// تاریخ شروع قرارداد
        /// </summary>
        public string DataStart { get; set; }
        /// <summary>
        ///تاریخ پایان قرارداد
        /// </summary>
        public string DataEnd { get; set; }
        /// <summary>
        /// کد نوع ضمانت
        /// </summary>
        public int WarantyTypeId { get; set; }
        /// <summary>
        /// مبلغ ضمانت
        /// </summary>
        public double SecurityDeposit {  get; set; }
        /// <summary>
        /// مبلغ اجاره
        /// </summary>
        public double RentAmount { get; set; }
        /// <summary>
        /// وضعیت قرارداد
        /// </summary>
        public bool ContractStatus { get; set; }
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

    }
    public class SpareConfig : EntityTypeConfiguration<Spare>
    {
        public SpareConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.ContactNo).IsRequired().HasMaxLength(10);
            Property(d => d.TankerNo).IsRequired().HasMaxLength(10);
            Property(d => d.DataStart).IsRequired().HasMaxLength(10);
            Property(d => d.DataEnd).IsRequired().HasMaxLength(10);
            Property(d => d.Description).HasMaxLength(500);
        }
    }

}
