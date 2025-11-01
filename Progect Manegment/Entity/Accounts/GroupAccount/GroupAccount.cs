using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.GroupAccount
{
    /// <summary>
    /// گروه حساب ها
    /// </summary>
    public class GroupAccount
    {
        public int Id { get; set; }
        public int? IdMahiyat { get; set; }
        public string Name { get; set; }

        public bool Sattus { get; set; } = true;

        public ICollection<Entity.Accounts.TotalAccount.TotalAccount> totalAccounts { get; set; }
    }

    public class GroupAccountConfig : EntityTypeConfiguration<GroupAccount>
    {
        public GroupAccountConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(100);

        }
    }
}
