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
        static void V_Dravers()
        {
            string txt = "SELECT        dbo.Dravers.Id, dbo.Dravers.BirDate, dbo.Dravers.SeryalGovahiname, dbo.Ciltys.Name AS Cilty, dbo.Provinces.Name AS Provinces, dbo.Customers.Name + ' ' + dbo.Customers.Family AS Name, dbo.Customers.CodMeli, \r\n                         dbo.Customers.Tel, dbo.Dravers.SmartCard, dbo.Dravers.Description, dbo.Genders.Name AS Gender, dbo.Customers.Adders, dbo.Dravers.Status\r\nFROM            dbo.Customers INNER JOIN\r\n                         dbo.Dravers ON dbo.Customers.Id = dbo.Dravers.CustomerId LEFT OUTER JOIN\r\n                         dbo.Provinces INNER JOIN\r\n                         dbo.Ciltys ON dbo.Provinces.Id = dbo.Ciltys.ProvincesId ON dbo.Customers.CityId = dbo.Ciltys.Id RIGHT OUTER JOIN\r\n                         dbo.Genders ON dbo.Dravers.GenderId = dbo.Genders.Id";
            MyClass.SqlBankClass.AddColumnInTable("Drop view  V_Dravers");
            MyClass.SqlBankClass.AddColumnInTable("CREATE VIEW [V_Dravers] AS " + txt);

        }
    }
}
