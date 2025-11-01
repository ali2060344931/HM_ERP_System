using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.SpecificAccount
{
    /// <summary>
    /// جدول گروه بندی حساب های معین
    /// </summary>
    public class SpecificAccountsGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TransactionTypeId { get; set; }
        public int SpecificAccountIdF { get; set; }
        public int SpecificAccountIdT { get; set; }
        public string Description { get; set; }
    }
        public class SpecificAccountsGroupConfig : EntityTypeConfiguration<SpecificAccountsGroup>
    {
        public SpecificAccountsGroupConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
            Property(d => d.Description).HasMaxLength(500);
        }
    }

}
