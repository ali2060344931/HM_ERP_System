using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.NatureAccount
{
    /// <summary>
    /// نوع حساب: بدهکار، بستانکار یا خنثی
    /// </summary>
    public class NatureAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Entity.Accounts.SpecificAccount.SpecificAccount> specificAccounts { get; set; }//حساب معین
    }


    public class NatureAccountConfig : EntityTypeConfiguration<NatureAccount>
    {
        public NatureAccountConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(50);

        }

    }
}
