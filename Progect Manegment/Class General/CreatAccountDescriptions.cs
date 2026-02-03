using DocumentFormat.OpenXml.Drawing.Charts;

using HM_ERP_System.Components;
using HM_ERP_System.Entity.Car;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Class_General
{
    public static class CreatAccountDescriptions
    {

        /// <summary>
        /// شرح سند مربوط به صاحب کالا
        /// </summary>
        /// <param name="comersBId"></param>
        /// <returns></returns>
        public static string GoodsAccountDes(int comersBId)
        {
            using (var db = new DBcontextModel())
            {
                var qB = db.ComersBs.Where(c => c.Id == comersBId).First();
                var qH = db.ComersHs.Where(c => c.Id == qB.ComersHId).First();

                //مقصد2: کمیسیون،   لیست1: کرایه حمل
                //string FareCalcMethodName = "";
                //if (qB.TypeCalFareId == 1)
                //    FareCalcMethodName = "کرایه حمل ";
                //else
                //    FareCalcMethodName = "کمیسیون";

                var car = db.Cars.Where(c => c.Id == qH.CarId).First();
                //سریال بارنامه
                string SeryalComerB = qB.SeryalB.ToString();
                //سریال حواله
                string SeryalComerH = qH.RemiaanceSeryal.ToString();

                //پلاک
                string CarPlat = car.CarPlat;
                //سریال پلاک
                string CarPlatSeryal = car.CarPlatSeryal;
                //شهر
                string LoadingOrinig = db.Ciltys.Where(c => c.Id == qH.LoadingOrinigId).First().Name;
                //انبار
                string LoadingLocation = db.PlaceTransfers.Where(c => c.Id == qH.LoadingLocationId).First().Name;
                //شهر
                string UnLoadingOrinig = db.Ciltys.Where(c => c.Id == qH.UnLoadingOrinigId).First().Name;
                //انبار
                string UnLoadingLocation = db.PlaceTransfers.Where(c => c.Id == qH.UnLoadingLocationId).First().Name;
                var Sender = db.Customers.Where(c => c.Id == qH.SenderId).First();
                string SenderName = Sender.Name + " " + Sender.Family;

                //نام کالا
                string ProductName = db.Products.Where(c => c.Id == qH.ProductsId).First().Name;
                //وزن خالص بار
                string LoadWeight = qB.LoadWeight.ToString();

                return "کرایه حمل بارنامه: " + SeryalComerB + " ش حواله: " + SeryalComerH + " کامیون " + CarPlat + " ایران " + CarPlatSeryal + " از " + LoadingOrinig + "، " + SenderName + " به " + UnLoadingOrinig + "، " + UnLoadingLocation + " کالا: " + ProductName + " به وزن: " + LoadWeight + " کیلوگرم";
            }
        }

        /// <summary>
        /// شرح سند مربوط به صاحب کامیون
        /// </summary>
        /// <param name="comersBId"></param>
        /// <returns></returns>
        public static string CostAccounDes(int comersBId)
        {
            using (var db = new DBcontextModel())
            {
                var qB = db.ComersBs.Where(c => c.Id == comersBId).First();
                var qH = db.ComersHs.Where(c => c.Id == qB.ComersHId).First();
                //MethodCalFareId
                //مقصد2: کمیسیون،   لیست1: کرایه حمل
                string FareCalcMethodName = "";
                if (qB.TypeCalFareId == 1)
                    FareCalcMethodName = "کرایه حمل ";
                else
                    FareCalcMethodName = "کمیسیون";

                var car = db.Cars.Where(c => c.Id == qH.CarId).First();
                //سریال بارنامه
                string SeryalComerB = qB.SeryalB.ToString();
                //سریال حواله
                string SeryalComerH = qH.RemiaanceSeryal.ToString();

                //پلاک
                string CarPlat = car.CarPlat;
                //سریال پلاک
                string CarPlatSeryal = car.CarPlatSeryal;
                //شهر
                string LoadingOrinig = db.Ciltys.Where(c => c.Id == qH.LoadingOrinigId).First().Name;
                //انبار
                string LoadingLocation = db.PlaceTransfers.Where(c => c.Id == qH.LoadingLocationId).First().Name;
                //شهر
                string UnLoadingOrinig = db.Ciltys.Where(c => c.Id == qH.UnLoadingOrinigId).First().Name;
                //انبار
                string UnLoadingLocation = db.PlaceTransfers.Where(c => c.Id == qH.UnLoadingLocationId).First().Name;
                //نام کالا
                string ProductName = db.Products.Where(c => c.Id == qH.ProductsId).First().Name;
                //وزن خالص بار
                string LoadWeight = qB.LoadWeight.ToString();

                return FareCalcMethodName + " بارنامه " + SeryalComerB + " ش حواله: " + SeryalComerH + " کامیون " + CarPlat + " ایران " + CarPlatSeryal + " از " + LoadingOrinig + "، " + LoadingLocation + " به " + UnLoadingOrinig + "، " + UnLoadingLocation + " کالا: " + ProductName + " به وزن: " + LoadWeight + " کیلوگرم";
            }
        }

        /// <summary>
        /// شرح سند بارنامه نویس
        /// </summary>
        /// <param name="comersBId"></param>
        /// <returns></returns>
        public static string ShiperAccountDes1(int comersBId)
        {
            using (var db = new DBcontextModel())
            {
                var qB = db.ComersBs.Where(c => c.Id == comersBId).First();
                var qH = db.ComersHs.Where(c => c.Id == qB.ComersHId).First();

                var car = db.Cars.Where(c => c.Id == qH.CarId).First();

                //سریال بارنامه
                string SeryalComerB = qB.SeryalB.ToString();
                //سریال حواله
                string SeryalComerH = qH.RemiaanceSeryal.ToString();
                //پلاک
                string CarPlat = car.CarPlat;
                //سریال پلاک
                string CarPlatSeryal = car.CarPlatSeryal;

                //شهر مبدا
                string LoadingOrinig = db.Ciltys.Where(c => c.Id == qH.LoadingOrinigId).First().Name;
                //انبا مبدا
                string LoadingLocation = db.PlaceTransfers.Where(c => c.Id == qH.LoadingLocationId).First().Name;

                //شهر
                string UnLoadingOrinig = db.Ciltys.Where(c => c.Id == qH.UnLoadingOrinigId).First().Name;
                //انبار
                string UnLoadingLocation = db.PlaceTransfers.Where(c => c.Id == qH.UnLoadingLocationId).First().Name;

                return "هزینه بارنامه نویس، بارنامه " + SeryalComerB + " ش ح: " + SeryalComerH + " کامیون " + CarPlat + " ایران " + CarPlatSeryal + " از " + LoadingOrinig + "، " + LoadingLocation + " به " + UnLoadingOrinig + "، " + UnLoadingLocation + " کرایه پایه: " + qB.BaseFreight.ToString("#,##0") + " هزینه بیمه: " + qB.InsuranceAmount.ToString("#,##0") + (qB.BillLadingMethodId == 3 ? " درصد: " + qB.BillLadingWriterPercent + "%" : "");
            }
        }

        public static string ShiperAccountDes2_1(int comersBId)
        {
            using (var db = new DBcontextModel())
            {
                var qB = db.ComersBs.Where(c => c.Id == comersBId).First();
                var qH = db.ComersHs.Where(c => c.Id == qB.ComersHId).First();
                
                //راننده 1
                var dr = db.Dravers.Where(c => c.Id == qB.DaraverId1_).First();
                var dr1=db.Customers.Where(c=>c.Id == dr.CustomerId).First();
                //بارنامه نویس
                var Shiper = db.Customers.Where(c => c.Id == qH.ShiperId).First();


                return "پرداخت توسط " + dr1.Name + " " + dr1.Family + " به " + Shiper.Name + " " + Shiper.Family + " ش ح " + qB.SeryalH;
            }
        }

        public static string ShiperAccountDes2_2(int comersBId)
        {
            using (var db = new DBcontextModel())
            {
                var qB = db.ComersBs.Where(c => c.Id == comersBId).First();
                var qH = db.ComersHs.Where(c => c.Id == qB.ComersHId).First();

                //راننده 1
                var dr = db.Dravers.Where(c => c.Id == qB.DaraverId1_).First();
                var dr1 = db.Customers.Where(c => c.Id == dr.CustomerId).First();
               
                //پرداخت شده به سایر
                var PaymentToOthers = db.Customers.Where(c => c.Id == db.DetailedAccounts.Where(x=>x.Id== qB.PaymentToOthersId).FirstOrDefault().CustomerId).First();

                return "پرداخت توسط " + dr1.Name + " " + dr1.Family + " به " + PaymentToOthers.Name + " " + PaymentToOthers.Family + " ش ح " + qB.SeryalH;
            }
        }

        public static string ShiperAccountDes3(int comersBId)
        {
            using (var db = new DBcontextModel())
            {
                var qB = db.ComersBs.Where(c => c.Id == comersBId).First();
                var qH = db.ComersHs.Where(c => c.Id == qB.ComersHId).First();
                var car = db.Cars.Where(c => c.Id == qH.CarId).First();

                //پلاک
                string CarPlat = car.CarPlat;
                //سریال پلاک
                string CarPlatSeryal = car.CarPlatSeryal;

                //شهر مبدا
                string LoadingOrinig = db.Ciltys.Where(c => c.Id == qH.LoadingOrinigId).First().Name;
                //انبا مبدا
                string LoadingLocation = db.PlaceTransfers.Where(c => c.Id == qH.LoadingLocationId).First().Name;

                //شهر
                string UnLoadingOrinig = db.Ciltys.Where(c => c.Id == qH.UnLoadingOrinigId).First().Name;
                //انبار
                string UnLoadingLocation = db.PlaceTransfers.Where(c => c.Id == qH.UnLoadingLocationId).First().Name;

                //نام کالا
                string ProductName = db.Products.Where(c => c.Id == qH.ProductsId).First().Name;
                //وزن خالص بار
                string LoadWeight = qB.LoadWeight.ToString();

                return "کمیسیون بارنامه " + qB.SeryalB + " ش ح " + qB.SeryalH + " کامیون " + CarPlat + " ایران " + CarPlatSeryal +" از "+ LoadingOrinig+"، "+ LoadingLocation+" به "+ UnLoadingOrinig+"، "+ UnLoadingLocation + " وزن " + LoadWeight + " کیلوگرم " + ProductName;
            }

        }

        /// <summary>
        /// شرح سند سایر حساب ها
        /// </summary>
        /// <param name="comersBId"></param>
        /// <returns></returns>
        public static string AnterAccountDes(int comersBId)
        {
            using (var db = new DBcontextModel())
            {
                var qB = db.ComersBs.Where(c => c.Id == comersBId).First();
                var qdr = db.Dravers.Where(c => c.Id == qB.DaraverId1_).First();
                var cu = db.Customers.Where(c => c.Id == qdr.CustomerId).First();
                return "پرداختی توسط " + cu.Name + " " + cu.Family + " بابت حواله: " + qB.SeryalH;
            }
        }



    }
}
