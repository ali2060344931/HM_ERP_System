using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.TypeAccount
{
    /// <summary>
    /// نوع حساب های بانکی
    /// </summary>
    public  class TypeAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        public class TypeAccountConfig : EntityTypeConfiguration<TypeAccount>
    {
        public TypeAccountConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(20);
        }
    }

}
