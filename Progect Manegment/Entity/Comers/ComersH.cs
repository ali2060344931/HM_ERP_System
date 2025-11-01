using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Comers
{
    /// <summary>
    /// جدول اسناد حواله ها
    /// </summary>
    public class ComersH
    {
        public int Id { get; set; }
        
        
        /// <summary>
        /// تاریخ حواله
        /// </summary>
        public string  date { get; set; }
        public int TypeDocumentId { get; set; }
        /// <summary>
        /// مبداء بارگیری
        /// </summary>
        public int LoadingOrinigId { get; set; }
        /// <summary>
        /// محل بارگیری
        /// </summary>
        public int LoadingLocationId { get; set; }
        /// <summary>
        /// مقصد تخلیه
        /// </summary>
        public int UnLoadingOrinigId { get; set; }
        /// <summary>
        /// محل تخلیه
        /// </summary>
        public int UnLoadingLocationId { get; set; }
        /// <summary>
        /// طرف حساب هزینه کامیون
        /// </summary>
        public int CostAccountId { get; set; }
        /// <summary>
        /// طرف حساب کالا
        /// </summary>
        public int GoodsAccountId { get; set; }
        /// <summary>
        ///1 فرستنده
        /// </summary>
        public int SenderId { get; set; }
        /// <summary>
        ///1 گیرنده
        /// </summary>
        public int ResiverId { get; set; }
        /// <summary>
        ///2 فرستنده
        /// </summary>
        public int Sender2Id { get; set; }
        /// <summary>
        ///2 گیرنده
        /// </summary>
        public int Resiver2Id { get; set; }
        
        
        
        
        /// <summary>
        /// بارنامه نویس
        /// </summary>
        public int ShiperId { get; set; }
        /// <summary>
        /// نوع کرایه
        /// </summary>
        //public int TypeCalFareId { get; set; }
        /// <summary>
        /// نحوه محاسبه کرایه صاحب کالا
        /// </summary>
        //public int methodCalFareId { get; set; }

        ///// <summary>
        ///// شماره و سریال پلاک
        ///// </summary>
        //public string CarPlat { get; set; }

        /// <summary>
        /// شماره کوتاژ
        /// </summary>
        public string CotajNumber { get; set; }
        
        /// <summary>
        /// کد خودرو
        /// </summary>
        public int CarId { get; set; }
        
        
        /// <summary>
        /// کد راننده 1
        /// </summary>
        public int DaraverId1 { get; set; }

        /// <summary>
        /// کد راننده 2
        /// </summary>
        public int DaraverId2 { get; set; }

        /// <summary>
        /// شماره(سریال) حواله
        /// </summary>
        public int RemiaanceSeryal {  get; set; }
        
        /// <summary>
        /// کالا
        /// </summary>
        public int ProductsId { get; set; }

        /// <summary>
        /// وزن(مقدار) بار-برای درخواست حواله
        /// </summary>
        public int DH_LoadWeight { get; set; }
        /// <summary>
        /// شماره پلمپ -برای درخواست حواله
        /// </summary>
        public string DH_SealNumber { get; set; }
        /// <summary>
        /// کرایه حمل -برای درخواست حواله
        /// </summary>
        public double DH_FreightCharge { get; set; }
        /// <summary>
        /// ارزش(بهای) کالا -برای درخواست حواله
        /// </summary>
        public double DH_PriceGoods { get; set; }
        /// <summary>
        /// وضعیت ثبت درخواست حواله
        /// </summary>
        public bool DH_StatusRejistered { get; set; }

        /// <summary>
        /// ظرفیت مجاز بارگیری
        /// </summary>
        public int LoadWeightCapacity { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
         public string Description { get; set; }
         
        /// <summary>
         /// وضعیت بارنامه:دارای بارنامه/فاقد بارنامه
         /// </summary>
        public bool StatusLading { get; set; }
        
        /// <summary>
        /// تاریخ ثبت
        /// </summary>
        public DateTime RecordDateTime { get; set; } = DateTime.Now;
        
        /// <summary>
        /// کد کاربر
        /// </summary>
        public int UserId { get; set; }

    }
        public class ComersHConfig : EntityTypeConfiguration<ComersH>
    {
        public ComersHConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.date).IsRequired().HasMaxLength(10);
            Property(d => d.CotajNumber).IsRequired().HasMaxLength(10);
            Property(d => d.DH_SealNumber).HasMaxLength(int.MaxValue);

        }
    }

}
