using DevComponents.WinForms.Drawing;

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Comers
{
    /// <summary>
    /// جدول بارنامه
    /// </summary>
    public class ComersB
    {
        public int Id { get; set; }

        /// <summary>
        /// کد جدول حواله
        /// </summary>
        public int ComersHId { get; set; }

        /// <summary>
        /// تاریخ بارنامه
        /// </summary>
        public string DateB { get; set; }
        /// <summary>
        /// سریال بارنامه
        /// </summary>
        public int SeryalB { get; set; }
        /// <summary>
        /// سریال حواله
        /// </summary>
        public int SeryalH { get; set; }

        /// <summary>
        /// کد راننده1
        /// </summary>
        public int DaraverId1_ { get; set; }

        /// <summary>
        /// کد راننده2
        /// </summary>
        public int DaraverId2_ { get; set; }
        /// <summary>
        /// فرستنده1
        /// </summary>
        public int SenderId { get; set; }
        /// <summary>
        /// گیرنده1
        /// </summary>
        public int ResiverId { get; set; }

        /// <summary>
        /// فرستنده2
        /// </summary>
        public int SenderId2 { get; set; }
        /// <summary>
        /// گیرنده2
        /// </summary>
        public int ResiverId2 { get; set; }
        /// <summary>
        /// طرف حساب هزینه کامیون
        /// </summary>
        public int CostAccountId { get; set; }
        /// <summary>
        /// طرف حساب کالا
        /// </summary>
        public int GoodsAccountId { get; set; }

        /// <summary>
        /// نوع محاسبه کرایه حمل/کمیسیون 
        /// </summary>
        public int TypeCalFareId { get; set; }

        /// <summary>
        /// نحوه محاسبه کرایه صاحب کالا
        /// </summary>
        public int MethodCalFareId { get; set; }

        /// <summary>
        /// وزن خالص بار
        /// </summary>
        public double LoadWeight { get; set; }
        
        /// <summary>
        /// وزن مجازبارگیری در بارنامه
        /// </summary>
        public int LoadWeightCapacityB { get; set; }

        /// <summary>
        /// وزن کالاهای تحویلی
        /// </summary>
        public double WeightDeliveredGoods { get; set; }

        /// <summary>
        /// نرخ حمل
        /// </summary>
        public double FreightRate { get; set; }
        /// <summary>
        /// بیمه کالا
        /// </summary>
        public double CargoInsurance { get; set; }
        /// <summary>
        /// هزینه بارگیری و باسکول
        /// </summary>
        public double LoadinCast { get; set; }
        /// <summary>
        /// تشویقی
        /// </summary>
        public double Incentive { get; set; }
        /// <summary>
        /// حق توقف
        /// </summary>
        public double StopCharge { get; set; }
        /// <summary>
        /// کسورات
        /// </summary>
        public double Deduction { get; set; }
        /// <summary>
        /// رند حساب کرایه
        /// </summary>
        public double BalanceAccount { get; set; }
        /// <summary>
        /// نحوه محاسبه کرایه راننده
        /// </summary>
        public int TypeCalcMethodsBId { get; set; }
        /// <summary>
        /// نرخ کرایه پرداختی به راننده
        /// </summary>
        public double PaidFreightRate { get; set; }
        /// <summary>
        /// هزینه بیمه،بارگیری و باسکول پرداختی
        /// </summary>
        public double InsurancCost { get; set; }
        /// <summary>
        /// نحوه پرداخت هزینه بارگیری توسط
        /// </summary>
        
        //public int PaymentMethodId { get; set; }
        /// <summary>
        /// تشویق پرداختی
        /// </summary>
        public double PaidIncentive { get; set; }
        
        /// <summary>
        /// مبلغ پرداختی به سایر1
        /// </summary>
        public double PaymentToOthers1 { get; set; }
        /// <summary>
        /// مبلغ پرداختی به سایر2
        /// </summary>
        public double PaymentToOthers2 { get; set; }
       
        /// <summary>
       /// شخص/حساب پرداخت شده
       /// </summary>
        public int PaymentToOthersId { get; set; }
        /// <summary>
        /// توضیحات مربوط به براختی سایر
        /// </summary>
        public string DesToOthers { get; set; }
        
        /// <summary>
        /// حق توقف پرداختی
        /// </summary>
        public double PaidStopCharge { get; set; }
        /// <summary>
        /// کسورات حساب راننده
        /// </summary>
        public double DriverDeduction { get; set; }
        /// <summary>
        /// نحوه محاسبه هزینه بارنامه
        /// </summary>
        public int BillLadingMethodId { get; set; }
        /// <summary>
        /// هزینه بارنامه
        /// </summary>
        public double BillLadingCastId { get; set; }
        /// <summary>
        /// کرایه پایه
        /// </summary>
        public double BaseFreight { get; set; }
        /// <summary>
        /// مبلغ محاسبه بارنامه
        /// </summary>
        public double BillLadingAmount { get; set; }
        /// <summary>
        /// مبلغ بیمه
        /// </summary>
        public double InsuranceAmount { get; set; }
        /// <summary>
        /// درصد بارنامه نویس
        /// </summary>
        public double BillLadingWriterPercent { get; set; }
        /// <summary>
        /// کسورات بارنامه نویسی
        /// </summary>
        public double OtherBillLadingCosts { get; set; }
        /// <summary>
        /// مبلغ پرداختی توسط راننده باربری
        /// </summary>
        public double AmountPaidTruckDriver { get; set; }
        /// <summary>
        /// رند حساب راننده
        /// </summary>
        public double BalanceAccountDraver { get; set; }
        /// <summary>
        /// رند حساب بارنامه نویس
        /// </summary>
        public double BalanceBillLadingAmount { get; set; }
        /// <summary>
        /// وضعیت تحویل کالا
        /// </summary>
        public bool StatusDeliveryGoods { get; set; } 
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// کرایه صافی راننده
        /// </summary>

        public double BO { get; set; }
        /// <summary>
        /// بدهی صاحب کالا بابت لیست
        /// </summary>
        public double AE { get; set; }
        /// <summary>
        /// بدهی کمیسیون
        /// </summary>
        public double AV { get; set; }
        /// <summary>
        /// بستانکاری کرایه
        /// </summary>
        public double AX { get; set; }
        /// <summary>
        /// بستانکاری/بدهی باربری بابت بارنامه نویس
        /// </summary>
        public double AZ { get; set; }
        /// <summary>
        /// مانده سود و زیان
        /// </summary>
        public double BK { get; set; }
        /// <summary>
        /// جمع هزینه ها
        /// </summary>
        public double BS { get; set; }
        /// <summary>
        /// تراکنش هزینه ها
        /// </summary>
        public double BT { get; set; }
        /// <summary>
        /// مبلغ هزینه بارنامه
        /// </summary>
        /// <returns></returns>
        public double AY { get; set; }
        /// <summary>
        /// مبلغ
        /// </summary>
        /// <returns></returns>
        public double BV { get; set; }
        /// <summary>
        /// جمع کل کرایه
        /// </summary>
        public double Ac { get; set; }
        /// <summary>
        /// کل کرایه
        /// </summary>
        public double Bn { get; set; }
        /// <summary>
        /// بدهی / بستانکاری راننده بابت بارنامه نویسی
        /// </summary>
        public double BP { get; set; }

        public virtual TypeCalcMethod.TypeCalcMethod TypeCalcMethods { get; set; }
    }
    public class ComersBConfig : EntityTypeConfiguration<ComersB>
    {
        public ComersBConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.DateB).IsRequired().HasMaxLength(10);
            Property(d => d.Description).HasMaxLength(int.MaxValue);
            Property(d => d.DesToOthers).HasMaxLength(int.MaxValue);
        }
    }

}
