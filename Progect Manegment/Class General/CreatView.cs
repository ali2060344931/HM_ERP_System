using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Class_General
{
    public static class CreatView
    {
        public static void BanckEdid()
        {
            V_Customers();
            V_Dravers();
            V_Cars();
            V_PlaceTransfer();
            V_Commission();
            V_AppointmentScheduling();
            V_ComersH();
            V_ComersB();
            V_TankerRental();
            V_Purchase_Tanker();
            V_Product();
            V_DetailedAccount();
            V_ReviewAccountsG();
            V_ReviewAccountsT();
            V_ReviewAccountsS();
            V_ReviewAccountsD();
            V_ReviewAccountsAllAcconts();
            V_ReviewAccountsList();
            V_ReviewAccountsTransaction();
        }

        /// <summary>
        /// مشتری ها
        /// </summary>
        static void V_Customers()
        {
            //string txt = "SELECT        dbo.Customers.Id, dbo.Customers.Name, dbo.Customers.Family, dbo.Customers.CodMeli, dbo.TypeCustomers.Name AS TypeCustomerName, dbo.Customers.Tel, dbo.Customers.Tel2, dbo.Customers.Adders, \r\n                         dbo.Customers.Adders2, dbo.Customers.PostalCode, dbo.Customers.Description, dbo.Customers.BanckName, dbo.Customers.SeryalShaba, dbo.Customers.DabitCardNumber, dbo.Customers.RecordDateTime, \r\n                         dbo.BankBranches.Name AS BankBranchesName, dbo.Bancks.Name AS BancksName, dbo.Customers.SecretCode, dbo.Ciltys.Name AS CiltysName, dbo.Customers.id_TypeCustomer, dbo.Customers.UserId, \r\n                         dbo.Customers.BanckId, dbo.Customers.CityId, dbo.Customers.TypeCustomer_Id\r\nFROM            dbo.TypeCustomers INNER JOIN\r\n                         dbo.Customers ON dbo.TypeCustomers.Id = dbo.Customers.id_TypeCustomer LEFT OUTER JOIN\r\n                         dbo.Ciltys ON dbo.Customers.CityId = dbo.Ciltys.Id LEFT OUTER JOIN\r\n                         dbo.BankBranches INNER JOIN\r\n                         dbo.Bancks ON dbo.BankBranches.BanckId = dbo.Bancks.Id ON dbo.Customers.BanckId = dbo.BankBranches.Id";
            string txt = "SELECT        cu.Id, cu.Name, cu.Family, cu.CodMeli, tc.Name AS TypeCustomerName, cu.Tel, cu.Tel2, cu.Adders, cu.Adders2, cu.PostalCode, cu.Description, cu.SeryalShaba, cu.DabitCardNumber, cu.RecordDateTime, \r\n                         CASE WHEN bb.Id IS NOT NULL AND ba.Id IS NOT NULL THEN ba.Name + ' - ' + bb.Name ELSE '-' END AS BanckName, cu.SecretCode, CASE WHEN ct.Id IS NOT NULL THEN ct.Name ELSE '-' END AS CiltysName, \r\n                         CASE WHEN pr.Id IS NOT NULL THEN pr.Name ELSE '-' END AS ProvincesName, cu.id_TypeCustomer, cu.UserId, cu.BanckId, cu.CityId\r\nFROM            Customers AS cu INNER JOIN\r\n                         TypeCustomers AS tc ON cu.id_TypeCustomer = tc.Id LEFT OUTER JOIN\r\n                         Ciltys AS ct ON cu.CityId = ct.Id LEFT OUTER JOIN\r\n                         Provinces AS pr ON ct.ProvincesId = pr.Id LEFT OUTER JOIN\r\n                         BankBranches AS bb ON cu.BanckId = bb.Id LEFT OUTER JOIN\r\n                         Bancks AS ba ON bb.BanckId = ba.Id\r\nWHERE        (cu.id_TypeCustomer <= 2)";
            
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_Customers");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_Customers] AS " + txt);

        }
        /// <summary>
        /// راننده ها
        /// </summary>
        static void V_Dravers()
        {
            string txt = "SELECT     dr.Id, cu.Family + ' ' + cu.Name AS Name, cu.CodMeli, cu.Tel, cu.Adders, dr.Description, dr.BirDate, gn.Name AS Gender, pr.Name AS Provinces, ct.Name AS City, dr.Status, dr.SmartCard, \r\n                      dr.SeryalGovahiname\r\nFROM         Provinces AS pr INNER JOIN\r\n                      Ciltys AS ct ON pr.Id = ct.ProvincesId RIGHT OUTER JOIN\r\n                      Dravers AS dr INNER JOIN\r\n                      Customers AS cu ON dr.CustomerId = cu.Id INNER JOIN\r\n                      Genders AS gn ON dr.GenderId = gn.Id ON ct.Id = cu.CityId";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_Dravers");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_Dravers] AS " + txt);

        }
        /// <summary>
        /// کامیون ها
        /// </summary>
        static void V_Cars()
        {
            string txt = "SELECT\r\n    cr.Id,\r\n    cr.CarName,\r\n    (cu.Family + ' ' + cu.Name) AS DraverName,\r\n    cr.OwnershipId,\r\n    ISNULL(owc.Name, '-') AS OwnershipCompanyName,\r\n    cr.CarPlat,\r\n    cr.CarPlatSeryal,\r\n    cr.Seryal,\r\n    cr.CreatModel,\r\n    cr.AxisCount,\r\n    cr.Description,\r\n    cr.LoadWeightCapacity,\r\n    cr.TruckCapacity,\r\n    ow.Name AS OwnershipName,\r\n    cr.Status,\r\n    tu.Name AS TruckUsageTypeName,\r\n    (cu2.Family + ' ' + cu2.Name) AS GoodsAccountName,\r\n    cu.CodMeli AS CodMeli,\r\n    ISNULL(ct.Name, '-') AS CityName,\r\n    ISNULL(pr.Name, '-') AS ProvincesName\r\nFROM Cars cr\r\n    INNER JOIN Dravers dr ON cr.DraverId = dr.Id\r\n    INNER JOIN Customers cu ON dr.CustomerId = cu.Id\r\n\r\n    LEFT JOIN Ciltys ct ON cu.CityId = ct.Id\r\n    LEFT JOIN Provinces pr ON ct.ProvincesId = pr.Id\r\n\r\n    INNER JOIN Customers cu2 ON cr.GoodsAccountId = cu2.Id\r\n    INNER JOIN TruckUsageTypes tu ON cr.TruckUsageTypeId = tu.Id\r\n    INNER JOIN Ownerships ow ON cr.OwnershipId = ow.Id\r\n\r\n    LEFT JOIN Customers owc ON cr.OwnershipCompanyId = owc.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_Cars");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_Cars] AS " + txt);

        }
        /// <summary>
        /// محل بارگیری و تخلیه
        /// </summary>
        static void V_PlaceTransfer()
        {
            string txt = "SELECT\r\n    pt.Id,\r\n    pt.Name AS PlaceTransferName,\r\n    ct.Name AS CityName,\r\n    pr.Name AS ProvincesName,\r\n    pt.publicStatus,\r\n    pt.PostalCode,\r\n    pt.Addres\r\nFROM PlaceTransfers pt\r\n    INNER JOIN Ciltys ct ON pt.CiltyId = ct.Id\r\n    INNER JOIN Provinces pr ON ct.ProvincesId = pr.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_PlaceTransfer");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_PlaceTransfer] AS " + txt);
        }
        /// <summary>
        /// پورسانت ها
        /// </summary>
        static void V_Commission()
        {
            string txt = "SELECT\r\n    co.Id,\r\n    co.Date,\r\n    co.Amount,\r\n    co.Des,\r\n    cmb.SeryalH AS ComersB,\r\n    pg.Name AS CommissionType,\r\n    cu.Family + ' ' + cu.Name AS Customer,\r\n\r\n    CASE WHEN co.TransactionId = 0 THEN '' ELSE tr.TransactionCode END AS TransactionsSeryal,\r\n\r\n    cmb.DateB,\r\n    cmb.SeryalB,\r\n\r\n    ct1.Name AS LoadingOrinigName,\r\n    pt1.Name AS LoadingLocationName,\r\n    ct2.Name AS UnLoadingOrinigName,\r\n    pr.Name AS ProductsName,\r\n    pt2.Name AS UnLoadingLocationName,\r\n\r\n    (ca.Family + ' ' + ca.Name) AS CostAccountName,\r\n    (ga.Family + ' ' + ga.Name) AS GoodsAccountName,\r\n\r\n    ISNULL(sh.Family + ' ' + sh.Name, '-') AS ShiperName,\r\n\r\n    cr.CarPlat + '-' + cr.CarPlatSeryal AS CarPlat,\r\n\r\n    cu1.Family + ' ' + cu1.Name AS DaraverName,\r\n    cu1.Tel AS DaraverTel,\r\n\r\n    cu2.Family + ' ' + cu2.Name AS DaraverName2,\r\n    cu2.Tel AS DaraverTel2,\r\n\r\n    sd1.Family + ' ' + sd1.Name AS SenderName,\r\n    rs1.Family + ' ' + rs1.Name AS ResiverName,\r\n\r\n    ISNULL(sd2.Family + ' ' + sd2.Name, '-') AS SenderName2,\r\n    ISNULL(rs2.Family + ' ' + rs2.Name, '-') AS ResiverName2,\r\n\r\n    cmb.Bn\r\nFROM Commissions co\r\n    INNER JOIN ComersBs cmb ON co.ComersBId = cmb.Id\r\n    INNER JOIN PersonGroups pg ON co.CommissionTypeId = pg.Id\r\n    INNER JOIN CustomerToGroups ctg ON co.CustomerToGroupsId = ctg.Id\r\n    INNER JOIN Customers cu ON ctg.CustomerId = cu.Id\r\n\r\n    LEFT JOIN Transactions tr ON co.TransactionId = tr.Id\r\n\r\n    INNER JOIN ComersHes cmh ON cmb.ComersHId = cmh.Id\r\n    INNER JOIN Ciltys ct1 ON cmh.LoadingOrinigId = ct1.Id\r\n    INNER JOIN PlaceTransfers pt1 ON cmh.LoadingLocationId = pt1.Id\r\n    INNER JOIN Ciltys ct2 ON cmh.UnLoadingOrinigId = ct2.Id\r\n    INNER JOIN PlaceTransfers pt2 ON cmh.UnLoadingLocationId = pt2.Id\r\n    INNER JOIN Products pr ON cmh.ProductsId = pr.Id\r\n\r\n    INNER JOIN Dravers dr1 ON cmb.DaraverId1_ = dr1.Id\r\n    INNER JOIN Customers cu1 ON dr1.CustomerId = cu1.Id\r\n\r\n    INNER JOIN Dravers dr2 ON cmb.DaraverId2_ = dr2.Id\r\n    INNER JOIN Customers cu2 ON dr2.CustomerId = cu2.Id\r\n\r\n    INNER JOIN Customers ca ON cmb.CostAccountId = ca.Id\r\n    INNER JOIN Customers ga ON cmb.GoodsAccountId = ga.Id\r\n\r\n    INNER JOIN Customers sd1 ON cmb.SenderId = sd1.Id\r\n    INNER JOIN Customers rs1 ON cmb.ResiverId = rs1.Id\r\n\r\n    LEFT JOIN Customers rs2 ON cmb.ResiverId2 = rs2.Id\r\n    LEFT JOIN Customers sd2 ON cmb.SenderId2 = sd2.Id\r\n\r\n    LEFT JOIN ComersHes shh ON cmh.ShiperId = shh.Id\r\n    LEFT JOIN Customers sh ON shh.ShiperId = sh.Id\r\n\r\n    LEFT JOIN DetailedAccounts ptonDA ON cmb.PaymentToOthersId = ptonDA.Id\r\n    LEFT JOIN Customers ptonC ON ptonDA.CustomerId = ptonC.Id\r\n\r\n    INNER JOIN Cars cr ON cmh.CarId = cr.Id\r\n    INNER JOIN TransactionFees tf ON cmb.BT = tf.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_Commission");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_Commission] AS " + txt);
        }
        /// <summary>
        /// نویت دهی کامیونها
        /// </summary>
        static void V_AppointmentScheduling()
        {
            string txt = "SELECT\r\n    carList.Id,\r\n    cr.CarPlat + cr.CarPlatSeryal AS CarPlat,\r\n    pr.Family + ' ' + pr.Name AS DraverName,\r\n    cr.CarName,\r\n    carList.Date + '-' + carList.Time AS DateTime,\r\n    carList.ProvincesList,\r\n    pr.Tel,\r\n    carList.Status,\r\n    GA.Family + ' ' + GA.Name AS GoodsAccount\r\nFROM AppointmentSchedulings carList\r\n    INNER JOIN Cars cr\r\n        ON carList.CarId = cr.Id\r\n    INNER JOIN Dravers dr\r\n        ON cr.DraverId = dr.Id\r\n    INNER JOIN Customers pr\r\n        ON dr.CustomerId = pr.Id\r\n    INNER JOIN Customers GA\r\n        ON cr.GoodsAccountId = GA.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_AppointmentScheduling");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_AppointmentScheduling] AS " + txt);
        }
        /// <summary>
        /// حواله ها
        /// </summary>
        static void V_ComersH()
        {
            string txt = "SELECT\r\n    -- نام بارنامه‌نویس\r\n    ISNULL(sh.Family + ' ' + sh.Name, '-') AS ShiperName,\r\n\r\n    -- تعداد مدارک پیوست\r\n    (SELECT COUNT(*)\r\n     FROM DocumentBancks d\r\n     WHERE d.ListInFoemId = cmh.Id AND d.FormName = 'frmComersH') AS CountDoc,\r\n\r\n    -- فیلدهای اصلی\r\n    cmh.Id,\r\n    cmh.date,\r\n    td.Name AS TypeDocumentName,\r\n\r\n    lo.Name AS LoadingOrinigName,\r\n    ll.Name AS LoadingLocationName,\r\n\r\n    ulo.Name AS UnLoadingOrinigName,\r\n    ull.Name AS UnLoadingLocationName,\r\n\r\n    (ca.Family + ' ' + ca.Name) AS CostAccountName,\r\n    (ga.Family + ' ' + ga.Name) AS GoodsAccountName,\r\n\r\n    (sr1.Family + ' ' + sr1.Name) AS SenderName,\r\n    (rs1.Family + ' ' + rs1.Name) AS ResiverName,\r\n\r\n    ISNULL(sender2.Family + ' ' + sender2.Name, '-') AS SenderName2,\r\n    ISNULL(reciver2.Family + ' ' + reciver2.Name, '-') AS ResiverName2,\r\n\r\n    (cu1.Family + ' ' + cu1.Name) AS DaraverName1,\r\n    ISNULL(cu2.Family + ' ' + cu2.Name, '-') AS DaraverName2,\r\n\r\n    pr.Name AS ProductsName,\r\n\r\n    cr.CarPlat + '-' + cr.CarPlatSeryal AS CarPlat,\r\n\r\n    cmh.RemiaanceSeryal,\r\n    cmh.LoadWeightCapacity,\r\n    cmh.Description,\r\n    cmh.CotajNumber\r\n\r\nFROM ComersHes cmh\r\n\r\n-- نوع سند\r\nLEFT JOIN TypeDocuments td\r\n    ON cmh.TypeDocumentId = td.Id\r\n\r\n-- مبدا بارگیری\r\nLEFT JOIN Ciltys lo\r\n    ON cmh.LoadingOrinigId = lo.Id\r\n\r\nLEFT JOIN PlaceTransfers ll\r\n    ON cmh.LoadingLocationId = ll.Id\r\n\r\n-- مقصد تخلیه\r\nLEFT JOIN Ciltys ulo\r\n    ON cmh.UnLoadingOrinigId = ulo.Id\r\n\r\nLEFT JOIN PlaceTransfers ull\r\n    ON cmh.UnLoadingLocationId = ull.Id\r\n\r\n-- حساب هزینه\r\nLEFT JOIN Customers ca\r\n    ON cmh.CostAccountId = ca.Id\r\n\r\n-- حساب کالا\r\nLEFT JOIN Customers ga\r\n    ON cmh.GoodsAccountId = ga.Id\r\n\r\n-- فرستنده 1 و گیرنده 1\r\nLEFT JOIN Customers sr1\r\n    ON cmh.SenderId = sr1.Id\r\n\r\nLEFT JOIN Customers rs1\r\n    ON cmh.ResiverId = rs1.Id\r\n\r\n-- فرستنده 2 و گیرنده 2 (Null مجاز)\r\nLEFT JOIN Customers sender2\r\n    ON cmh.Sender2Id = sender2.Id\r\n\r\nLEFT JOIN Customers reciver2\r\n    ON cmh.Resiver2Id = reciver2.Id\r\n\r\n-- راننده 1\r\nLEFT JOIN Dravers dr1\r\n    ON cmh.DaraverId1 = dr1.Id\r\n\r\nLEFT JOIN Customers cu1\r\n    ON dr1.CustomerId = cu1.Id\r\n\r\n-- راننده 2 (Null مجاز)\r\nLEFT JOIN Dravers dr2\r\n    ON cmh.DaraverId2 = dr2.Id\r\n\r\nLEFT JOIN Customers cu2\r\n    ON dr2.CustomerId = cu2.Id\r\n\r\n-- کالا\r\nLEFT JOIN Products pr\r\n    ON cmh.ProductsId = pr.Id\r\n\r\n-- خودرو\r\nLEFT JOIN Cars cr\r\n    ON cmh.CarId = cr.Id\r\n\r\n-- بارنامه نویس\r\nLEFT JOIN Customers sh\r\n    ON cmh.ShiperId = sh.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_ComersH");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_ComersH] AS " + txt);
        }
        /// <summary>
        /// بارنامه
        /// </summary>
        static void V_ComersB()
        {
            string txt = "SELECT\r\n    cmb.Id,\r\n    cmb.DateB,\r\n    cmb.SeryalB,\r\n    cmb.SeryalH,\r\n\r\n    ct1.Name AS LoadingOrinigName,\r\n    pt1.Name AS LoadingLocationName,\r\n    ct2.Name AS UnLoadingOrinigName,\r\n    pt2.Name AS UnLoadingLocationName,\r\n\r\n    (ca.Family + ' ' + ca.Name) AS CostAccountName,\r\n    (ga.Family + ' ' + ga.Name) AS GoodsAccountName,\r\n\r\n    ISNULL(sh.Family + ' ' + sh.Name, '-') AS ShiperName,\r\n\r\n    (cr.CarPlatSeryal + ' ' + cr.CarPlat) AS CarPlat,\r\n\r\n    cu1.Family + ' ' + cu1.Name AS DaraverName,\r\n    cu1.Tel AS DaraverTel,\r\n\r\n    cu2.Family + ' ' + cu2.Name AS DaraverName2,\r\n    cu2.Tel AS DaraverTel2,\r\n\r\n    sd1.Family + ' ' + sd1.Name AS SenderName,\r\n    rs1.Family + ' ' + rs1.Name AS ResiverName,\r\n\r\n    ISNULL(sd2.Family + ' ' + sd2.Name, '-') AS SenderName2,\r\n    ISNULL(rs2.Family + ' ' + rs2.Name, '-') AS ResiverName2,\r\n\r\n    pr.Name AS ProductsName,\r\n    tcf.Name AS FareCalcMethodName,\r\n    mcf.Name AS MethodCalFareName,\r\n    pm2.Name AS BillLadingCast,\r\n    tcm2.Name AS BillLadingMethod,\r\n\r\n    ptonC_Left.Family + ' ' + ptonC_Left.Name AS PaymentToOthersName,\r\n\r\n    cmb.LoadWeight,\r\n    cmb.WeightDeliveredGoods,\r\n    cmb.FreightRate,\r\n    cmb.CargoInsurance,\r\n    cmb.LoadinCast,\r\n    cmb.Incentive,\r\n    cmb.StopCharge,\r\n    cmb.Deduction,\r\n    cmb.BalanceAccount,\r\n    cmb.PaidFreightRate,\r\n    cmb.InsurancCost,\r\n    cmb.PaidIncentive,\r\n    cmb.PaidStopCharge,\r\n    cmb.DriverDeduction,\r\n    cmb.BaseFreight,\r\n    cmb.BillLadingAmount,\r\n    cmb.InsuranceAmount,\r\n    cmb.BillLadingWriterPercent,\r\n    cmb.OtherBillLadingCosts,\r\n    cmb.AmountPaidTruckDriver,\r\n    cmb.BalanceAccountDraver,\r\n    cmb.StatusDeliveryGoods,\r\n    cmb.Description,\r\n    cmb.PaymentToOthers1,\r\n    cmb.PaymentToOthers2,\r\n    cmb.DesToOthers,\r\n\r\n    cmb.BO,\r\n    cmb.AE,\r\n    cmb.AV,\r\n    cmb.AX,\r\n    cmb.AZ,\r\n    cmb.BP,\r\n    cmb.BK,\r\n    cmb.BS,\r\n    tf.Name AS BT,\r\n    cmb.AY,\r\n    cmb.BV,\r\n    cmb.Ac,\r\n    cmb.Bn\r\nFROM ComersBs cmb\r\n    INNER JOIN ComersHes cmh ON cmb.ComersHId = cmh.Id\r\n    INNER JOIN Ciltys ct1 ON cmh.LoadingOrinigId = ct1.Id\r\n    INNER JOIN PlaceTransfers pt1 ON cmh.LoadingLocationId = pt1.Id\r\n    INNER JOIN Ciltys ct2 ON cmh.UnLoadingOrinigId = ct2.Id\r\n    INNER JOIN PlaceTransfers pt2 ON cmh.UnLoadingLocationId = pt2.Id\r\n    INNER JOIN Products pr ON cmh.ProductsId = pr.Id\r\n\r\n    INNER JOIN Dravers dr1 ON cmb.DaraverId1_ = dr1.Id\r\n    INNER JOIN Customers cu1 ON dr1.CustomerId = cu1.Id\r\n\r\n    INNER JOIN Dravers dr2 ON cmb.DaraverId2_ = dr2.Id\r\n    INNER JOIN Customers cu2 ON dr2.CustomerId = cu2.Id\r\n\r\n    INNER JOIN Customers ca ON cmb.CostAccountId = ca.Id\r\n    INNER JOIN Customers ga ON cmb.GoodsAccountId = ga.Id\r\n\r\n    INNER JOIN Customers sd1 ON cmb.SenderId = sd1.Id\r\n    INNER JOIN Customers rs1 ON cmb.ResiverId = rs1.Id\r\n\r\n    LEFT JOIN Customers rs2 ON cmb.ResiverId2 = rs2.Id\r\n    LEFT JOIN Customers sd2 ON cmb.SenderId2 = sd2.Id\r\n\r\n    INNER JOIN FareCalcMethods tcf ON cmb.TypeCalFareId = tcf.Id\r\n    INNER JOIN TypeCalcMethods mcf ON cmb.MethodCalFareId = mcf.Id\r\n    INNER JOIN PaymentMethods pm2 ON cmb.BillLadingCastId = pm2.Id\r\n    INNER JOIN TypeCalcMethods tcm2 ON cmb.BillLadingMethodId = tcm2.Id\r\n\r\n    LEFT JOIN Customers sh ON cmh.ShiperId = sh.Id\r\n\r\n    LEFT JOIN DetailedAccounts ptonDA ON cmb.PaymentToOthersId = ptonDA.Id\r\n    LEFT JOIN Customers ptonC_Left ON ptonDA.CustomerId = ptonC_Left.Id\r\n\r\n    INNER JOIN Cars cr ON cmh.CarId = cr.Id\r\n    INNER JOIN TransactionFees tf ON cmb.BT = tf.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_ComersB");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_ComersB] AS " + txt);
        }
        /// <summary>
        /// اجاره تانکرها
        /// </summary>
        static void V_TankerRental()
        {
            string txt = "SELECT     sp.Id, sp.ContactNo, sp.TankerNo, cr.CarPlat, cr.CarPlatSeryal, cr.AxisCount, cr.CarName, cu.Family + ' ' + cu.Name AS GoodsAccountName, sp.DataStart, sp.DataEnd, sp.RentAmount, \r\n                      sp.SecurityDeposit, sp.ContractStatus, sp.Description, wr.Name AS WarantyType, rt.Name AS RentalType, tut.Name AS TruckUsageTypeName\r\nFROM         Spares AS sp INNER JOIN\r\n                      Cars AS cr ON sp.CarId = cr.Id INNER JOIN\r\n                      Customers AS cu ON cr.GoodsAccountId = cu.Id INNER JOIN\r\n                      WarantyTypes AS wr ON sp.WarantyTypeId = wr.Id INNER JOIN\r\n                      TruckUsageTypes AS tut ON cr.TruckUsageTypeId = tut.Id INNER JOIN\r\n                      RentalTypes AS rt ON sp.RentalTypeId = rt.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_TankerRental");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_TankerRental] AS " + txt);
        }
        /// <summary>
        /// خرید تانکرها
        /// </summary>
        static void V_Purchase_Tanker()
        {
            string txt = "SELECT\r\n    pt.Id,\r\n    pt.Date,\r\n\r\n    Seller = s.Family + ' ' + s.Name,\r\n    Buyer  = b.Family + ' ' + b.Name,\r\n\r\n    TypeTrailer = tut.Name,\r\n\r\n    pt.TankerNo,\r\n    pt.Manufacturer,\r\n    pt.NumberAxles,\r\n    pt.TypeChassisCapsule,\r\n    pt.DocumentStatus,\r\n    pt.PreviousPlateNumber,\r\n    pt.NewPlateNumber,\r\n    pt.PurchaseAmount,\r\n    pt.BlockedAmountDocument,\r\n    pt.AgencyCommission,\r\n    pt.TransactionsStatuse\r\nFROM PurchaseTankers pt\r\n    INNER JOIN Customers s ON pt.SellerId = s.Id\r\n    INNER JOIN Customers b ON pt.BuyerId  = b.Id\r\n    INNER JOIN TruckUsageTypes tut ON pt.TypeTrailerId = tut.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_Purchase_Tanker");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_Purchase_Tanker] AS " + txt);
        }
        /// <summary>
        /// لیست کالاها
        /// </summary>
        static void V_Product()
        {
            string txt = "SELECT \r\n    pr.Id,\r\n    pr.Name,\r\n    ProductGroupName = prg.Name\r\nFROM Products pr\r\n    INNER JOIN ProductGroups prg ON pr.ProductGroupId = prg.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_Product");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_Product] AS " + txt);
        }
        /// <summary>
        /// حساب های تفصیلی
        /// </summary>
        static void V_DetailedAccount()
        {
            string txt = "SELECT \r\n    da.Id,\r\n    ga.Name AS GroupAccountName,\r\n    ta.Name AS TotalAccountName,\r\n    sa.Name AS SpecificAccountName,\r\n    LTRIM(RTRIM(cu.Family + ' ' + cu.Name)) AS Name,\r\n    na.Name AS NatureAccounts,\r\n    da.CodeAccount AS DetailedAccountCode,\r\n\r\n    -- مجموع بدهکار\r\n    ISNULL((\r\n        SELECT SUM(t.PaymentBed)\r\n        FROM Transactions t\r\n        WHERE \r\n            t.DetailedAccountId = da.Id\r\n            AND t.Status = 0\r\n    ), 0) AS Bed,\r\n\r\n    -- مجموع بستانکار\r\n    ISNULL((\r\n        SELECT SUM(t.PaymentBes)\r\n        FROM Transactions t\r\n        WHERE \r\n            t.DetailedAccountId = da.Id\r\n            AND t.Status = 0\r\n    ), 0) AS Bes,\r\n\r\n    -- مانده\r\n    ABS(\r\n        ISNULL((\r\n            SELECT SUM(t.PaymentBes)\r\n            FROM Transactions t\r\n            WHERE t.DetailedAccountId = da.Id AND t.Status = 0\r\n        ), 0)\r\n        -\r\n        ISNULL((\r\n            SELECT SUM(t.PaymentBed)\r\n            FROM Transactions t\r\n            WHERE t.DetailedAccountId = da.Id AND t.Status = 0\r\n        ), 0)\r\n    ) AS Balance\r\n\r\nFROM DetailedAccounts da\r\nLEFT JOIN SpecificAccounts sa ON da.SpecificAccountId = sa.Id\r\nLEFT JOIN TotalAccounts ta ON sa.Id_TotalAccount = ta.Id\r\nLEFT JOIN GroupAccounts ga ON ta.Id_GroupAccount = ga.Id\r\nLEFT JOIN Customers cu ON da.CustomerId = cu.Id\r\nLEFT JOIN NatureAccounts na ON ga.IdMahiyat = na.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_DetailedAccount");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_DetailedAccount] AS " + txt);
        }
        /// <summary>
        /// مرور حسابها- گروه
        /// </summary>
        static void V_ReviewAccountsG()
        {
            string txt = "WITH TransSums AS \r\n(\r\n    SELECT \r\n        da.Id AS DetailedAccountId,\r\n        ta.Id_GroupAccount AS GroupAccountId,\r\n        SUM(CASE WHEN tr.PaymentBed IS NULL THEN 0 ELSE tr.PaymentBed END) AS DebitTurnover,\r\n        SUM(CASE WHEN tr.PaymentBes IS NULL THEN 0 ELSE tr.PaymentBes END) AS CreditTurnover\r\n    FROM DetailedAccounts da\r\n    INNER JOIN SpecificAccounts sa ON da.SpecificAccountId = sa.Id\r\n    INNER JOIN TotalAccounts ta ON sa.Id_TotalAccount = ta.Id\r\n\r\n    LEFT JOIN Transactions tr \r\n        ON da.Id = tr.DetailedAccountId\r\n        AND tr.Status = 0              -- فیلتر مشابه LINQ\r\n        -- AND tr.FinancialYear = '1403'   (در صورت نیاز فعال کنید)\r\n\r\n    GROUP BY \r\n        da.Id,\r\n        ta.Id_GroupAccount\r\n),\r\n\r\nGroupCalc AS\r\n(\r\n    SELECT \r\n        g.GroupAccountId,\r\n        SUM(g.DebitTurnover) AS TotalDebitTurnover,\r\n        SUM(g.CreditTurnover) AS TotalCreditTurnover,\r\n        SUM(g.DebitTurnover - g.CreditTurnover) AS EndingBalance\r\n    FROM TransSums g\r\n    GROUP BY g.GroupAccountId\r\n)\r\n\r\nSELECT\r\n    ga.Id AS Id,\r\n    ga.Name AS GroupAccountName,\r\n    '' AS TotalAccountName,\r\n    '' AS SpecificAccountName,\r\n    ga.Id AS Code,\r\n    ga.Name AS Name,\r\n\r\n    na.Name AS NatureAccounts,\r\n\r\n    gc.TotalDebitTurnover AS DebitTurnover,\r\n    gc.TotalCreditTurnover AS CreditTurnover,\r\n\r\n    CASE \r\n        WHEN gc.EndingBalance > 0 THEN gc.EndingBalance\r\n        ELSE 0 \r\n    END AS DebitBalance,\r\n\r\n    CASE \r\n        WHEN gc.EndingBalance < 0 THEN ABS(gc.EndingBalance)\r\n        ELSE 0 \r\n    END AS CreditBalance\r\n\r\nFROM GroupCalc gc\r\nINNER JOIN GroupAccounts ga \r\n    ON ga.Id = gc.GroupAccountId\r\nINNER JOIN NatureAccounts na\r\n    ON na.Id = ga.IdMahiyat\r\n\r\nWHERE \r\n    ABS(gc.EndingBalance) > 0.00000001;";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_ReviewAccountsG");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_ReviewAccountsG] AS " + txt);
        }
        /// <summary>
        /// مرور حساب ها- کل
        /// </summary>
        static void V_ReviewAccountsT()
        {
            string txt = "WITH TransSums AS\r\n(\r\n    SELECT \r\n        da.Id AS DetailedAccountId,\r\n        sa.Id AS SpecificAccountId,\r\n        sa.Id_TotalAccount AS TotalAccountId,\r\n        SUM(CASE WHEN tr.PaymentBed IS NULL THEN 0 ELSE tr.PaymentBed END) AS DebitTurnover,\r\n        SUM(CASE WHEN tr.PaymentBes IS NULL THEN 0 ELSE tr.PaymentBes END) AS CreditTurnover\r\n    FROM DetailedAccounts da\r\n    INNER JOIN SpecificAccounts sa ON da.SpecificAccountId = sa.Id\r\n    LEFT JOIN Transactions tr \r\n        ON da.Id = tr.DetailedAccountId\r\n        AND tr.Status = 0  -- مشابه filteredTransactions\r\n    GROUP BY da.Id, sa.Id, sa.Id_TotalAccount\r\n),\r\nTotalAccountCalc AS\r\n(\r\n    SELECT\r\n        ts.TotalAccountId,\r\n        SUM(ts.DebitTurnover) AS DebitTurnoverSum,\r\n        SUM(ts.CreditTurnover) AS CreditTurnoverSum,\r\n        -- BeginningBalance = 0 برای ساده‌سازی مشابه LINQ\r\n        0 AS BeginningBalance\r\n    FROM TransSums ts\r\n    GROUP BY ts.TotalAccountId\r\n)\r\nSELECT\r\n    ta.Id AS Id,\r\n    ga.Name AS GroupAccountName,\r\n    ta.Name AS TotalAccountName,\r\n    ' ' AS SpecificAccountName,  -- مقدار پیش‌فرض برای RDLC\r\n    ta.Cod AS Code,\r\n    ta.Name AS Name,\r\n    tac.BeginningBalance AS BeginningBanace,\r\n    na.Name AS NatureAccounts,\r\n    tac.DebitTurnoverSum AS DebitTurnover,\r\n    tac.CreditTurnoverSum AS CreditTurnover,\r\n    CASE WHEN (tac.BeginningBalance + tac.DebitTurnoverSum - tac.CreditTurnoverSum) > 0 \r\n         THEN (tac.BeginningBalance + tac.DebitTurnoverSum - tac.CreditTurnoverSum)\r\n         ELSE 0 \r\n    END AS DebitBalance,\r\n    CASE WHEN (tac.BeginningBalance + tac.DebitTurnoverSum - tac.CreditTurnoverSum) < 0 \r\n         THEN ABS(tac.BeginningBalance + tac.DebitTurnoverSum - tac.CreditTurnoverSum)\r\n         ELSE 0 \r\n    END AS CreditBalance\r\nFROM TotalAccountCalc tac\r\nINNER JOIN TotalAccounts ta ON ta.Id = tac.TotalAccountId\r\nINNER JOIN GroupAccounts ga ON ta.Id_GroupAccount = ga.Id\r\nINNER JOIN NatureAccounts na ON na.Id = ga.IdMahiyat\r\nWHERE ABS(tac.DebitTurnoverSum - tac.CreditTurnoverSum) > 0.00000001";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_ReviewAccountsT");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_ReviewAccountsT] AS " + txt);
        }
        /// <summary>
        /// مرور حساب ها- معین
        /// </summary>
        static void V_ReviewAccountsS()
        {
            string txt = "WITH TransFiltered AS (SELECT        Id, FinancialYear, TransactionCode, Series, TransactionDate, TransactionTypeId, SpecificAccountId, DetailedAccountId, Amount, PaymentBed, PaymentBes, ComerBId, Description, Status, FinalRegistry, \r\n                                                                             IsAutoRejDoc, UserId, DateTime, SeryalNumber, IsBeginningBalance\r\n                                                    FROM            Transactions\r\n                                                    WHERE        (Status = 0)), SpecificAgg AS\r\n    (SELECT        da.SpecificAccountId, sa.Name AS SpecificAccountName, sa.Cod AS SpecificAccountCode, SUM(ISNULL(tr.PaymentBed, 0)) AS DebitTurnover, SUM(ISNULL(tr.PaymentBes, 0)) AS CreditTurnover, 0 AS BeginningBalance, \r\n                                ga.IdMahiyat AS NatureAccountId\r\n       FROM            DetailedAccounts AS da LEFT OUTER JOIN\r\n                                TransFiltered AS tr ON da.Id = tr.DetailedAccountId INNER JOIN\r\n                                SpecificAccounts AS sa ON da.SpecificAccountId = sa.Id INNER JOIN\r\n                                TotalAccounts AS ta ON sa.Id_TotalAccount = ta.Id INNER JOIN\r\n                                GroupAccounts AS ga ON ta.Id_GroupAccount = ga.Id\r\n       GROUP BY da.SpecificAccountId, sa.Name, sa.Cod, ga.IdMahiyat)\r\n    SELECT        SpecificAccountId AS Id, SpecificAccountName AS Name, SpecificAccountCode AS Code, DebitTurnover, CreditTurnover, CASE WHEN (0 + DebitTurnover - CreditTurnover) > 0 THEN (0 + DebitTurnover - CreditTurnover) \r\n                              ELSE 0 END AS DebitBalance, CASE WHEN (0 + DebitTurnover - CreditTurnover) < 0 THEN ABS(0 + DebitTurnover - CreditTurnover) ELSE 0 END AS CreditBalance\r\n     FROM            SpecificAgg\r\n     WHERE        (ABS(0 + DebitTurnover - CreditTurnover) <> 0) OR\r\n                              (ABS(DebitTurnover) <> 0) OR\r\n                              (ABS(CreditTurnover) <> 0)";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_ReviewAccountsS");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_ReviewAccountsS] AS " + txt);
        }
        /// <summary>
        /// مرور حساب ها- تفصیلی
        /// </summary>
        static void V_ReviewAccountsD()
        {
            string txt = "WITH TransFiltered AS (SELECT        Id, FinancialYear, TransactionCode, Series, TransactionDate, TransactionTypeId, SpecificAccountId, DetailedAccountId, Amount, PaymentBed, PaymentBes, ComerBId, Description, Status, FinalRegistry, \r\n                                                                             IsAutoRejDoc, UserId, DateTime, SeryalNumber, IsBeginningBalance\r\n                                                    FROM            Transactions\r\n                                                    WHERE        (Status = 0)), CustomerAgg AS\r\n    (SELECT        cu.Id AS CustomerId, cu.Name AS FirstName, cu.Family AS LastName, SUM(ISNULL(tr.PaymentBed, 0)) AS DebitTurnover, SUM(ISNULL(tr.PaymentBes, 0)) AS CreditTurnover\r\n       FROM            DetailedAccounts AS da INNER JOIN\r\n                                Customers AS cu ON da.CustomerId = cu.Id INNER JOIN\r\n                                SpecificAccounts AS sa ON da.SpecificAccountId = sa.Id INNER JOIN\r\n                                TotalAccounts AS ta ON sa.Id_TotalAccount = ta.Id INNER JOIN\r\n                                GroupAccounts AS ga ON ta.Id_GroupAccount = ga.Id LEFT OUTER JOIN\r\n                                TransFiltered AS tr ON da.Id = tr.DetailedAccountId\r\n       WHERE        (ga.Id IN (1, 2, 3, 4, 5))\r\n       GROUP BY cu.Id, cu.Name, cu.Family)\r\n    SELECT        CustomerId AS Id, RTRIM(LTRIM(LastName + ' ' + FirstName)) AS Name, CustomerId AS Code, DebitTurnover, CreditTurnover, CASE WHEN (DebitTurnover - CreditTurnover) > 0 THEN (DebitTurnover - CreditTurnover) \r\n                              ELSE 0 END AS DebitBalance, CASE WHEN (DebitTurnover - CreditTurnover) < 0 THEN ABS(DebitTurnover - CreditTurnover) ELSE 0 END AS CreditBalance\r\n     FROM            CustomerAgg\r\n     WHERE        (ABS(DebitTurnover - CreditTurnover) <> 0) OR\r\n                              (ABS(DebitTurnover) <> 0) OR\r\n                              (ABS(CreditTurnover) <> 0)";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_ReviewAccountsD");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_ReviewAccountsD] AS " + txt);
        }
        static void V_ReviewAccountsAllAcconts()
        {
            string txt = "SELECT\r\n    ga.Name AS GName,\r\n    ta.Name AS TName,\r\n    sa.Name AS sName,\r\n    da.Id,\r\n    cu.Family + ' ' + cu.Name AS DName,\r\n    da.CodeAccount AS Code,\r\n\r\n    -- جمع کل بدهکارها\r\n    ISNULL(SUM(tr.PaymentBed), 0) AS DebitTurnover,\r\n\r\n    -- جمع کل بستانکارها\r\n    ISNULL(SUM(tr.PaymentBes), 0) AS CreditTurnover,\r\n\r\n    -- مانده بدهکار\r\n    CASE \r\n        WHEN ISNULL(SUM(tr.PaymentBed), 0) - ISNULL(SUM(tr.PaymentBes), 0) > 0\r\n        THEN ISNULL(SUM(tr.PaymentBed), 0) - ISNULL(SUM(tr.PaymentBes), 0)\r\n        ELSE 0\r\n    END AS DebitBalance,\r\n\r\n    -- مانده بستانکار\r\n    CASE \r\n        WHEN ISNULL(SUM(tr.PaymentBed), 0) - ISNULL(SUM(tr.PaymentBes), 0) < 0\r\n        THEN ABS(ISNULL(SUM(tr.PaymentBed), 0) - ISNULL(SUM(tr.PaymentBes), 0))\r\n        ELSE 0\r\n    END AS CreditBalance\r\n\r\nFROM DetailedAccounts da\r\nJOIN SpecificAccounts sa ON da.SpecificAccountId = sa.Id\r\nJOIN TotalAccounts ta ON sa.Id_TotalAccount = ta.Id\r\nJOIN GroupAccounts ga ON ta.Id_GroupAccount = ga.Id\r\nJOIN Customers cu ON da.CustomerId = cu.Id\r\nJOIN NatureAccounts na ON ga.IdMahiyat = na.Id\r\n\r\n-- تمام تراکنش‌ها بدون شرط\r\nLEFT JOIN Transactions tr ON da.Id = tr.DetailedAccountId\r\n\r\nGROUP BY\r\n    ga.Name,\r\n    ta.Name,\r\n    sa.Name,\r\n    da.Id,\r\n    cu.Family,\r\n    cu.Name,\r\n    da.CodeAccount;";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_ReviewAccountsAllAcconts");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_ReviewAccountsAllAcconts] AS " + txt);
        }
        /// <summary>
        /// مرور حساب ها- لیست تراکنش ها
        /// </summary>
        static void V_ReviewAccountsList()
        {
            string txt = "SELECT     tr.DetailedAccountId AS Id, tr.Series, tr.TransactionCode, tr.TransactionDate, tt.Name AS TransactionType, sp.Name AS SpecificAccountName, cu.Family + ' ' + cu.Name AS ContraAccountName, \r\n                      cu.CodMeli, cu.Tel, tr.Amount AS TotalAmount, tr.PaymentBed, tr.PaymentBes, tr.Description, da.CodeAccount AS AccountCode, tr.IsAutoRejDoc, ISNULL(coH.RemiaanceSeryal, 0) AS ComerSeryal, \r\n                      CuUser.Family + ' ' + CuUser.Name AS [User], ga.Name AS GroupAccountName, ta.Name AS TotalAccountName, sp.Cod AS SpecificAccountCode, da.CustomerId, da.SpecificAccountId, \r\n                      da.CodeAccount, tr.Status, tr.UserId, tr.ComerBId\r\nFROM         Transactions AS tr INNER JOIN\r\n                      SpecificAccounts AS sp ON tr.SpecificAccountId = sp.Id INNER JOIN\r\n                      DetailedAccounts AS da ON tr.DetailedAccountId = da.Id INNER JOIN\r\n                      TotalAccounts AS ta ON sp.Id_TotalAccount = ta.Id INNER JOIN\r\n                      GroupAccounts AS ga ON ta.Id_GroupAccount = ga.Id INNER JOIN\r\n                      Customers AS cu ON da.CustomerId = cu.Id INNER JOIN\r\n                      TransactionTypes AS tt ON tr.TransactionTypeId = tt.Id INNER JOIN\r\n                      CustomerRoles AS cr ON tr.UserId = cr.Id INNER JOIN\r\n                      Customers AS CuUser ON cr.Id = CuUser.Id LEFT OUTER JOIN\r\n                      ComersBs AS coB ON tr.ComerBId = coB.Id LEFT OUTER JOIN\r\n                      ComersHes AS coH ON coB.ComersHId = coH.Id\r\nWHERE     (tr.Status = 0)";

            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_ReviewAccountsList");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_ReviewAccountsList] AS " + txt);
        }
        /// <summary>
        /// لیست اسناد
        /// </summary>
        static void V_ReviewAccountsTransaction()
        {
            string txt = "SELECT     tr.DetailedAccountId AS Id, tr.Series, tr.TransactionCode, tr.TransactionDate, tt.Name AS TransactionType, sp.Name AS SpecificAccountName, cu.Family + ' ' + cu.Name AS ContraAccountName, \r\n                      cu.CodMeli, cu.Tel, tr.Amount AS TotalAmount, tr.PaymentBed, tr.PaymentBes, tr.Description, da.CodeAccount AS AccountCode, tr.IsAutoRejDoc, ISNULL(coH.RemiaanceSeryal, 0) AS ComerSeryal, \r\n                      CuUser.Family + ' ' + CuUser.Name AS [User], ga.Name AS GroupAccountName, ta.Name AS TotalAccountName, sp.Cod AS SpecificAccountCode, da.CustomerId, da.SpecificAccountId, \r\n                      da.CodeAccount, tr.Status, tr.UserId, tr.ComerBId\r\nFROM         Transactions AS tr INNER JOIN\r\n                      SpecificAccounts AS sp ON tr.SpecificAccountId = sp.Id INNER JOIN\r\n                      DetailedAccounts AS da ON tr.DetailedAccountId = da.Id INNER JOIN\r\n                      TotalAccounts AS ta ON sp.Id_TotalAccount = ta.Id INNER JOIN\r\n                      GroupAccounts AS ga ON ta.Id_GroupAccount = ga.Id INNER JOIN\r\n                      Customers AS cu ON da.CustomerId = cu.Id INNER JOIN\r\n                      TransactionTypes AS tt ON tr.TransactionTypeId = tt.Id INNER JOIN\r\n                      CustomerRoles AS cr ON tr.UserId = cr.Id INNER JOIN\r\n                      Customers AS CuUser ON cr.Id = CuUser.Id LEFT OUTER JOIN\r\n                      ComersBs AS coB ON tr.ComerBId = coB.Id LEFT OUTER JOIN\r\n                      ComersHes AS coH ON coB.ComersHId = coH.Id\r\nWHERE     (tr.Status = 0)";

            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_ReviewAccountsTransaction");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_ReviewAccountsTransaction] AS " + txt);
        }
    }
}
