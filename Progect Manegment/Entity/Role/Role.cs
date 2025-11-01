using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Role
{
    /// <summary>
    ///جدول نوع دسترسی
    /// </summary>
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<RolePermissione.RolePermissione> RolePermissiones { get; set; }
    }
        public class RoleTypeConfig : EntityTypeConfiguration<Role>
        {
            public RoleTypeConfig()
            {
                HasKey(x => x.Id);
                Property(d => d.Name).IsRequired().HasMaxLength(50);
            }
        }
   

}
