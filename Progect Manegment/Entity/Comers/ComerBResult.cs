using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Comers
{
    public class ComerBResult
    {
        public int Id { get; set; }
        public string DateB { get; set; }
        public string SeryalB { get; set; }
        public string SeryalH { get; set; }
        public bool Transaction { get; set; }

        public string LoadingOrinigName { get; set; }
        public string LoadingLocationName { get; set; }
        public string UnLoadingOrinigName { get; set; }
        public string UnLoadingLocationName { get; set; }

        public string CostAccountName { get; set; }
        public string GoodsAccountName { get; set; }
        public string ShiperName { get; set; }

        public string CarPlat { get; set; }

        public string DaraverName { get; set; }
        public string DaraverTel { get; set; }
        public string DaraverName2 { get; set; }
        public string DaraverTel2 { get; set; }

        public string SenderName { get; set; }
        public string ResiverName { get; set; }
        public string SenderName2 { get; set; }
        public string ResiverName2 { get; set; }

        public string ProductsName { get; set; }
        public string FareCalcMethodName { get; set; }
        public string MethodCalFareName { get; set; }

        public int CountDoc { get; set; }

        public decimal? LoadWeight { get; set; }
        public decimal? WeightDeliveredGoods { get; set; }
        public decimal? FreightRate { get; set; }
        public decimal? CargoInsurance { get; set; }
        public decimal? LoadinCast { get; set; }
        public decimal? Incentive { get; set; }
        public decimal? StopCharge { get; set; }
        public decimal? Deduction { get; set; }
        public decimal? BalanceAccount { get; set; }

        public string PaymentToOthersName { get; set; }
        public string DesToOthers { get; set; }

        public string BillLadingCast { get; set; }
        public string BillLadingMethod { get; set; }

        public string BT { get; set; }
        public string Description { get; set; }
    }

}
