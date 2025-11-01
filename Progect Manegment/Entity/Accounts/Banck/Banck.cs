using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Accounts.Banck
{
    /// <summary>
    /// جدول بانک ها 
    /// </summary>
    public  class Banck
    {
        public int Id { get; set; }
       /// <summary>
       ///نام بانک
       /// </summary>
        public string Name { get; set; }
        //public string BranchName { get; set; }

    }
        public class BanckConfig : EntityTypeConfiguration<Banck>
    {
        public BanckConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
            //Property(d => d.Name).IsRequired().HasMaxLength(150);
        }
    }

}
