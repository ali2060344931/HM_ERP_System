using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.TotalAccount
{
    /// <summary>
    /// حساب های کل
    /// </summary>
    public class TotalAccount
    {
        public int Id { get; set; }
        public int Cod { get; set; }
        public string Name { get; set; }

        public int Id_GroupAccount { get; set; }

        public bool Sattus { get; set; } = true;

        public ICollection<Entity.Accounts.SpecificAccount.SpecificAccount> specificAccounts { get; set; }//حساب های معین
    }
    public class TotalAccountConfig : EntityTypeConfiguration<TotalAccount>
    {
        public TotalAccountConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(100);

        }
    }
}
