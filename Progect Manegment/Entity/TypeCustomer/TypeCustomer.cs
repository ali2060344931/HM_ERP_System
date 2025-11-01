using HM_ERP_System.Entity.Ciltys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.TypeCustomer
{
    /// <summary>
    /// جدول نوع مشتری حقیقی یا حقوقی
    /// </summary>
    public class TypeCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Entity.Customer.Customer> Customers { get; set; }

    }
    public class TypeCustomertConfig : EntityTypeConfiguration<TypeCustomer>
    {
        public TypeCustomertConfig()
        {
            HasKey(c => c.Id);
            Property(c => c.Name).IsRequired().HasMaxLength(50);

        }
    }

}
