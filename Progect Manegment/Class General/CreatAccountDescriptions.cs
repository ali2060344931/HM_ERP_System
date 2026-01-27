using DocumentFormat.OpenXml.Drawing.Charts;

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
                var qB=db.ComersBs.Where(c=>c.Id==comersBId).First();
                var qH=db.ComersHs.Where(c=>c.Id==qB.ComersHId).First();

                //مقصد2: کمیسیون،   لیست1: کرایه حمل
                //string FareCalcMethodName = "";
                //if (qB.MethodCalFareId == 1)
                //    FareCalcMethodName = "کرایه حمل ";
                //else
                //    FareCalcMethodName = "کمیسیون";
               
                var car = db.Cars.Where(c => c.Id == qH.CarId).First();
                //سریال بارنامه
                string SeryalComerB=qB.SeryalB.ToString();
                //سریال حواله
                string SeryalComerH = qH.RemiaanceSeryal.ToString();

                //پلاک
                string CarPlat = car.CarPlat;
                //سریال پلاک
                string CarPlatSeryal = car.CarPlatSeryal;
                //شهر
                string LoadingOrinig = db.Ciltys.Where(c=>c.Id==qH.LoadingOrinigId).First().Name;
                //انبار
                string LoadingLocation = db.PlaceTransfers.Where(c=>c.Id==qH.LoadingLocationId).First().Name;
                //شهر
                string UnLoadingOrinig = db.Ciltys.Where(c => c.Id == qH.UnLoadingOrinigId).First().Name;
                //انبار
                string UnLoadingLocation = db.PlaceTransfers.Where(c => c.Id == qH.UnLoadingLocationId).First().Name;
                var Sender = db.Customers.Where(c => c.Id == qH.SenderId).First();
                string SenderName = Sender.Name + " " + Sender.Family;

                //نام کالا
                string ProductName=db.Products.Where(c=>c.Id==qH.ProductsId).First().Name;
                //وزن خالص بار
                string LoadWeight = qB.LoadWeight.ToString();

                return "کرایه حمل بارنامه: "+ SeryalComerB + " ش حواله: "+ SeryalComerH + " کامیون "+ CarPlat+ " ایران "+ CarPlatSeryal+" از "+ LoadingOrinig +"، "+ SenderName + " به "+ UnLoadingOrinig+"، "+ UnLoadingLocation +" کالا: "+ ProductName+" به وزن: "+ LoadWeight+" کیلوگرم";
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

                //مقصد2: کمیسیون،   لیست1: کرایه حمل
                string FareCalcMethodName = "";
                if (qB.MethodCalFareId == 1)
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

                return FareCalcMethodName + " ش بارنامه " + SeryalComerB + " ش حواله: " + SeryalComerH + " کامیون " + CarPlat + " ایران " + CarPlatSeryal + " از " + LoadingOrinig + "، " + LoadingLocation + " به " + UnLoadingOrinig + "، " + UnLoadingLocation + " کالا: " + ProductName + " به وزن: " + LoadWeight + " کیلوگرم";
            }


        }

        /// <summary>
        /// شرح سند بارنامه نویس
        /// </summary>
        /// <param name="comersBId"></param>
        /// <returns></returns>
        public static string ShiperAccountDes(int comersBId)
        {
            using (var db = new DBcontextModel())
            {
                var qB = db.ComersBs.Where(c => c.Id == comersBId).First();
                var qH = db.ComersHs.Where(c => c.Id == qB.ComersHId).First();
                
                //مقصد2: کمیسیون،   لیست1: کرایه حمل
                //string FareCalcMethodName = "";
                //if (qB.MethodCalFareId == 1)
                //    FareCalcMethodName = "کرایه حمل ";
                //else
                //    FareCalcMethodName = "کمیسیون";

                //مقصد: کمیسیون،   لیست: کرایه حمل
                //string FareCalcMethodName = db.FareCalcMethods.Where(c => c.Id == qB.MethodCalFareId).First().Name;


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

                return  "هزینه بارنامه نویس به بارنامه " + SeryalComerB + " ش ح: " + SeryalComerH + " کامیون " + CarPlat + " ایران " + CarPlatSeryal + " از " + LoadingOrinig + "، " + LoadingLocation+" کرایه پایه: "+ qB.BaseFreight.ToString("#,##0")+ " هزینه بیمه: " + qB.InsuranceAmount.ToString("#,##0") + (qB.BillLadingMethodId==3?" درصد: "+qB.BillLadingWriterPercent:"");
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
                var qdr=db.Dravers.Where(c=>c.Id== qB.DaraverId1_).First();
                var cu = db.Customers.Where(c => c.Id == qdr.CustomerId).First();
                return "پرداختی توسط " + cu.Name +" "+ cu.Family +" بابت حواله: "+qB.SeryalH;
            }
        }
    }
}
