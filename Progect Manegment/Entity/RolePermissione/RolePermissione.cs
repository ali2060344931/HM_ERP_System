using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.RolePermissione
{
    public class RolePermissione
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public Role.Role Role { get; set; }
        public int PermissionId { get; set; }
        public Peremission.Peremission Peremission { get; set; }

        public bool status { get; set; }
    }
        public class RolePermissioneConfig : EntityTypeConfiguration<RolePermissione>
    {
        public RolePermissioneConfig()
        {
            HasKey(x => x.Id);
            //Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}
