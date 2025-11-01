using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.Banck
{
    /// <summary>
    /// ثبت شعب بانک ها
    /// </summary>
    public  class BankBranch
    {
        public int Id { get; set; }
        public int BanckId { get; set; }

       public string Name { get; set; }
    }
        public class BankBranchConfig : EntityTypeConfiguration<BankBranch>
    {
        public BankBranchConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(100);
        }
    }

}
