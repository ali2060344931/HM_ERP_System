using MyClass;

using Progect_Manegment;

using System;

namespace HM_ERP_System.Class_General
{
    /// <summary>
    /// محاسبات  مبالغ بارنامه ها
    /// </summary>
    public class CalculatComerB
    {
        DBcontextModel db = new DBcontextModel();
        /// <summary>
        /// محاسبات کلی
        /// </summary>
        /// <param name="ComersHId_">کد جدول حواله</param>
        /// <param name="TypeCalFareId_">نوع محاسبه کرایه حمل/کمیسیون</param>
        /// <param name="MethodCalFareId_">نحوه محاسبه کرایه صاحب کالا</param>
        /// <param name="LoadWeight_">وزن خالص بار</param>
        /// <param name="WeightDeliveredGoods_">وزن کالاهای تحویلی</param>
        /// <param name="TruckCapacity_">ظرفیت مجاز کامیون</param>
        /// <param name="FreightRate_">نرخ حمل</param>
        /// <param name="CargoInsurance_">بیمه کالا</param>
        /// <param name="LoadinCast_">هزینه بارگیری و باسکول</param>
        /// <param name="Incentive_">تشویقی</param>
        /// <param name="StopCharge_">حق توقف</param>
        /// <param name="Deduction_">کسورات</param>
        /// <param name="BalanceAccount_">رند حساب صاحب کالا</param>
        /// <param name="TypeCalcMethodsBId_">نحوه محاسبه کرایه راننده</param>
        /// <param name="PaidFreightRate_">نرخ کرایه پرداختی به راننده</param>
        /// <param name="InsurancCost_">هزینه بیمه،بارگیری و باسکول پرداختی</param>
        /// <param name="PaymentMethodId_">نحوه پرداخت هزینه بارگیری توسط</param>
        /// <param name="PaidIncentive_">نحوه پرداخت هزینه بارگیری توسط</param>
        /// <param name="PaidStopCharge_">حق توقف پرداختی</param>
        /// <param name="DriverDeduction_">کسورات حساب راننده</param>
        /// <param name="BillLadingMethodId_">نحوه محاسبه هزینه بارنامه</param>
        /// <param name="BillLadingCastId_">هزینه بارنامه</param>
        /// <param name="BaseFreight_">کرایه پایه</param>
        /// <param name="BillLadingAmount_">مبلغ محاسبه بارنامه</param>
        /// <param name="InsuranceAmount_">مبلغ بیمه</param>
        /// <param name="BillLadingWriterPercent_">درصد بارنامه نویس</param>
        /// <param name="AmountPaidTruckDriver_">مبلغ پرداختی توسط راننده باربری</param>
        /// <param name="BalanceAccountDraver_">رند حساب راننده</param>
        /// <param name="OtherBillLadingCosts_">کسورات بارنامه نویسی</param>
        /// <param name="BalanceBillLadingAmount_">رند حساب بارنامه نویسی</param>

        public (double, double, double, double, double, double, double, double, double, double, double, double, double) CalcComerFilds(int ComersHId_, int TypeCalFareId_, int MethodCalFareId_, double LoadWeight_, double WeightDeliveredGoods_, int TruckCapacity_, double FreightRate_, double CargoInsurance_, double LoadinCast_, double Incentive_, double StopCharge_, double Deduction_, double BalanceAccount_, int TypeCalcMethodsBId_, double PaidFreightRate_, double InsurancCost_, double PaidIncentive_, double PaidStopCharge_, double DriverDeduction_, int BillLadingMethodId_, double BillLadingCastId_, double BaseFreight_, double BillLadingAmount_, double InsuranceAmount_, double BillLadingWriterPercent_, double AmountPaidTruckDriver_, double BalanceAccountDraver_, double OtherBillLadingCosts_, double BalanceBillLadingAmount_)

        {
            //calGeneral();
            ComersHId=ComersHId_; TypeCalFareId=TypeCalFareId_; MethodCalFareId=MethodCalFareId_; LoadWeight=LoadWeight_; WeightDeliveredGoods=WeightDeliveredGoods_; TruckCapacity=TruckCapacity_; FreightRate=FreightRate_; CargoInsurance=CargoInsurance_; LoadinCast=LoadinCast_; Incentive=Incentive_; StopCharge=StopCharge_; Deduction=Deduction_; BalanceAccount=BalanceAccount_; TypeCalcMethodsBId=TypeCalcMethodsBId_; PaidFreightRate=PaidFreightRate_; InsurancCost=InsurancCost_; PaidIncentive=PaidIncentive_; PaidStopCharge=PaidStopCharge_; DriverDeduction=DriverDeduction_; BillLadingMethodId=BillLadingMethodId_; BillLadingCastId=BillLadingCastId_; BaseFreight=BaseFreight_; BillLadingAmount=BillLadingAmount_; InsuranceAmount=InsuranceAmount_; BillLadingWriterPercent=BillLadingWriterPercent_; AmountPaidTruckDriver=AmountPaidTruckDriver_; BalanceAccountDraver=BalanceAccountDraver_; OtherBillLadingCosts=OtherBillLadingCosts_; BalanceBillLadingAmount=BalanceBillLadingAmount_;

            return (AV(), Ac(), AZ(), BO(), AE(), AX(), BK(), BS(), BT(), AY(), BV(), Bn(), BP());

        }

        public int ComersHId { get; set; } = 0;
        /// <summary>
        /// نوع محاسبه کرایه حمل/کمیسیون 
        /// </summary>
        public int TypeCalFareId { get; set; } = 0;
        /// <summary>
        /// نحوه محاسبه کرایه صاحب کالا
        /// </summary>
        public int MethodCalFareId { get; set; } = 0;
        /// <summary>
        /// وزن خالص بار
        /// </summary>
        public double LoadWeight { get; set; } = 0;
        /// <summary>
        /// وزن کالاهای تحویلی
        /// </summary>
        public double WeightDeliveredGoods { get; set; } = 0;
        /// <summary>
        /// ظرفیت مجاز کامیون
        /// </summary>
        public int TruckCapacity { get; set; } = 0;
        /// <summary>
        /// نرخ حمل
        /// </summary>
        public double FreightRate { get; set; } = 0;
        /// <summary>
        /// بیمه کالا
        /// </summary>
        public double CargoInsurance { get; set; } = 0;
        /// <summary>
        /// هزینه بارگیری و باسکول
        /// </summary>
        public double LoadinCast { get; set; } = 0;
        /// <summary>
        /// تشویقی
        /// </summary>
        public double Incentive { get; set; } = 0;
        /// <summary>
        /// حق توقف
        /// </summary>
        public double StopCharge { get; set; } = 0;
        /// <summary>
        /// کسورات
        /// </summary>
        public double Deduction { get; set; } = 0;
        /// <summary>
        /// رند حساب صاحب کالا
        /// </summary>
        public double BalanceAccount { get; set; } = 0;
        /// <summary>
        /// نحوه محاسبه کرایه راننده
        /// </summary>
        public int TypeCalcMethodsBId { get; set; } = 0;
        /// <summary>
        /// نرخ کرایه پرداختی به راننده
        /// </summary>
        public double PaidFreightRate { get; set; } = 0;
        /// <summary>
        /// هزینه بیمه،بارگیری و باسکول پرداختی
        /// </summary>
        public double InsurancCost { get; set; } = 0;
        /// <summary>
        /// نحوه پرداخت هزینه بارگیری توسط
        /// </summary>
        public int PaymentMethodId { get; set; } = 0;
        /// <summary>
        ///  تشویق پرداختی
        /// </summary>
        public double PaidIncentive { get; set; } = 0;
        /// <summary>
        /// حق توقف پرداختی
        /// </summary>
        public double PaidStopCharge { get; set; } = 0;
        /// <summary>
        /// کسورات حساب راننده
        /// </summary>
        public double DriverDeduction { get; set; } = 0;
        /// <summary>
        /// نحوه محاسبه هزینه بارنامه
        /// </summary>
        public int BillLadingMethodId { get; set; } = 0;
        /// <summary>
        /// پرداخت هزینه بارنامه به عهده
        /// </summary>
        public double BillLadingCastId { get; set; } = 0;
        /// <summary>
        /// کرایه پایه
        /// </summary>
        public double BaseFreight { get; set; } = 0;
        /// <summary>
        /// مبلغ محاسبه بارنامه
        /// </summary>
        public double BillLadingAmount { get; set; } = 0;
        /// <summary>
        /// مبلغ بیمه
        /// </summary>
        public double InsuranceAmount { get; set; } = 0;
        /// <summary>
        /// درصد بارنامه نویس
        /// </summary>
        public double BillLadingWriterPercent { get; set; } = 0;
        /// <summary>
        /// مبلغ پرداختی توسط راننده به باربری
        /// </summary>
        public double AmountPaidTruckDriver { get; set; } = 0;
        /// <summary>
        /// رند حساب راننده
        /// </summary>
        public double BalanceAccountDraver { get; set; } = 0;
        /// <summary>
        /// سایر هزینه های بارنامه نویسی
        /// </summary>
        public double OtherBillLadingCosts { get; set; } = 0;
        /// <summary>
        /// رند حساب بارنامه نویس
        /// </summary>
        public double BalanceBillLadingAmount { get; set; } = 0;

        /// <summary>
        /// بدهی / بستانکاری راننده بابت بارنامه نویسی
        /// </summary>
        public  double BP()
        {
            try
            {
                if (BillLadingCastId==1)
                {
                    return AmountPaidTruckDriver;
                }
                else if (BillLadingCastId==2)
                {
                    return AmountPaidTruckDriver-AY();
                }
                else
                    return 0;
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage( er);
                return 0;

            }
        }
        /// <summary>
        /// کرایه صافی راننده
        /// </summary>
        public double BO()
        {
            try
            {
                if (TypeCalcMethodsBId==1)//تن
                {
                    if (TruckCapacity>LoadWeight)
                    {
                        double x = Math.Round(TruckCapacity*PaidFreightRate/1000,0);
                        return x;
                    }
                    else
                    {
                        double x = Math.Round(PaidFreightRate*LoadWeight/1000,0);
                        return x;
                    }
                }
                else
                {
                    if (TypeCalcMethodsBId==3)//درصدی
                    {
                        double x =Math.Round( Bn()-PaidFreightRate*Bn()/100,0);
                        return x;
                    }
                    else
                    {
                        return PaidFreightRate;
                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage( er);
                return 0;
            }

        }
        /// <summary>
        /// بدهی صاحب کالا بابت لیست
        /// </summary>
        public double AE()
        {
            try
            {
                if (TypeCalFareId==1)
                {
                    double x = Ac();
                    return x;
                }
                else
                    return 0;

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage( er);
                return 0;
            }
        }
        /// <summary>
        /// بدهی کمیسیون
        /// </summary>
        public double AV()
        {
            try
            {
                if (TypeCalFareId==2)
                {
                    double bp = BP();
                    double bo = BO();
                    double x = Ac()-(bp+bo+BalanceAccountDraver-DriverDeduction+PaidStopCharge+InsurancCost + PaidIncentive);
                    return x;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage( er);
                return 0;
            }
        }
        /// <summary>
        /// بستانکاری کرایه
        /// </summary>
        public double AX()
        {
            //پرداخت هزینه بارگیری توسط
            try
            {
                if (TypeCalFareId==1)//کرایه حمل
                {
                    double bp = BP();
                    double bo = BO();

                    double x = bp+bo+BalanceAccountDraver-DriverDeduction+PaidStopCharge+InsurancCost+PaidIncentive;
                    return -x;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
        /// <summary>
        /// بستانکاری/بدهی باربری بابت بارنامه نویس
        /// </summary>
        public double AZ()
        {
            try
            {
                double x = AmountPaidTruckDriver-AY();
                return x;

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
        /// <summary>
        /// مانده سود و زیان
        /// </summary>
        public double BK()
        {
            try
            {
                double x = Ac()+BS();
                return x;

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
        /// <summary>
        /// جمع هزینه ها
        /// </summary>
        public double BS()
        {
            try
            {
                double bo=BO();
                double ay= AY();

                if (BillLadingCastId==1)//پیمانکار
                {
                    double x = bo+InsurancCost+PaidIncentive+PaidStopCharge-DriverDeduction+BalanceAccountDraver+ay;
                    return -x;
                }
                else
                {
                    double x = bo+InsurancCost+PaidIncentive+PaidStopCharge-DriverDeduction+BalanceAccountDraver;
                    return -x;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
        /// <summary>
        /// تراکنش هزینه ها
        /// </summary>
        public double BT()
        {
            try
            {
                if (BV()==1)
                {
                    return 1;
                }
                else
                {
                    return 2;

                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
        /// <summary>
        /// مبلغ هزینه بارنامه
        /// </summary>
        /// <returns></returns>
        public double AY()
        {
            try
            {
                if (BillLadingMethodId==3)//درصدی
                {
                    double x = Math.Round((BaseFreight*BillLadingWriterPercent/100)+InsuranceAmount-OtherBillLadingCosts+BalanceBillLadingAmount,0);
                    return x;
                }
                else
                {
                    if (BillLadingMethodId==2)//بارنامه ای
                    {
                        double x =Math.Round( BillLadingAmount+InsuranceAmount-OtherBillLadingCosts+BalanceBillLadingAmount,0);
                        return x;
                    }
                    else//پیمانکار
                        return 0;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
        /// <summary>
        /// مبلغ
        /// </summary>
        /// <returns></returns>
        public double BV()
        {
            try
            {
                double y = AV();
                if (y==0)
                {
                    double x = AX();
                    return x;
                }
                else
                {
                    double x = AV();
                    return x;
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
        /// <summary>
        /// جمع کل کرایه
        /// </summary>
        public double Ac()
        {
            try
            {
                double x = Bn() + BalanceAccount - Deduction+StopCharge+Incentive+LoadinCast+CargoInsurance;
                return x;

            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
        /// <summary>
        /// کل کرایه
        /// </summary>
        public double Bn()
        {
            try
            {
                using (var DB = new DBcontextModel())
                {
                    if (MethodCalFareId==1)//نحوه محاسبه کرایه:تن
                    {
                        if (TruckCapacity>0)
                        {
                            double x = Math.Round(TruckCapacity*FreightRate/1000,0);
                            return x;
                        }
                        else
                        {
                            double x = Math.Round(LoadWeight*FreightRate/1000,0);
                            return x;
                        }
                    }
                    else
                    {
                        return FreightRate;

                    }
                }
            }
            catch (Exception er)
            {
                PublicClass.ShowErrorMessage(er);
                return 0;
            }
        }
    }
}
