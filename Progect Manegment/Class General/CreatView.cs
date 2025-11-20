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
        }

        /// <summary>
        /// مشتری ها
        /// </summary>
        static void V_Customers()
        {
            string txt = "SELECT     dbo.Customers.Id, dbo.Customers.Name, dbo.Customers.Family, dbo.Customers.CodMeli, dbo.TypeCustomers.Name AS TypeCustomersName, dbo.Customers.Tel, dbo.Customers.Tel2, \r\n                      dbo.Customers.Adders, dbo.Customers.Adders2, dbo.Customers.PostalCode, dbo.Customers.Description, dbo.Customers.BanckName, dbo.Customers.SeryalShaba, \r\n                      dbo.Customers.DabitCardNumber, dbo.Customers.RecordDateTime, dbo.BankBranches.Name AS BankBranchesName, dbo.Bancks.Name AS BancksName, dbo.Customers.SecretCode, \r\n                      dbo.Ciltys.Name AS CiltysName, dbo.Customers.id_TypeCustomer, dbo.Customers.UserId, dbo.Customers.BanckId, dbo.Customers.CityId, dbo.Customers.TypeCustomer_Id\r\nFROM         dbo.TypeCustomers INNER JOIN\r\n                      dbo.Customers ON dbo.TypeCustomers.Id = dbo.Customers.id_TypeCustomer LEFT OUTER JOIN\r\n                      dbo.Ciltys ON dbo.Customers.CityId = dbo.Ciltys.Id LEFT OUTER JOIN\r\n                      dbo.BankBranches INNER JOIN\r\n                      dbo.Bancks ON dbo.BankBranches.BanckId = dbo.Bancks.Id ON dbo.Customers.BanckId = dbo.BankBranches.Id";
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
    }
}
