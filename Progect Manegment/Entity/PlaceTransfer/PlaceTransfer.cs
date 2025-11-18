using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.PlaceTransfer
{
    /// <summary>
    /// محل بارگیری و تخلیه
    /// </summary>
    public class PlaceTransfer
    {
        public int Id { get; set; }
        /// <summary>
        /// (نام انبار(محل بارگیری یا تخلیه
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// کد بارگیری، تخلیه
        /// </summary>
        //public int EvacuationDeploymentId { get; set; }
        
        /// <summary>
        /// شهر
        /// </summary>
        public int CiltyId { get; set; }
        /// <summary>
        /// (وضعیت عمومی(شناور
        /// </summary>
        public bool publicStatus { get; set; }
        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }
        public string Addres { get; set; }

        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;
        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }

        public virtual EvacuationDeployment.EvacuationDeployment EvacuationDeployment { get; set; }

    }
    public class PlaceTransferConfig : EntityTypeConfiguration<PlaceTransfer>
    {
        public PlaceTransferConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(60);
            Property(d => d.PostalCode).HasMaxLength(10);
            Property(d => d.Addres).HasMaxLength(300);
        }
    }

}
