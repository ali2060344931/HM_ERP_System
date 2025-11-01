using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.CustomerRole
{
    public class CustomerRole
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        //سال مالی
        public int FinancialYearId { get; set; }
        public Customer.Customer Customer { get; set; }
        public int RoleId { get; set; }
        public Role.Role Role { get; set; }

        /// <summary>
        /// رمز عبور
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// وضعیت فعال/غیرفعال
        /// </summary>
        public bool Status { get; set; }

    }
    public class CustomerRoleConfig : EntityTypeConfiguration<CustomerRole>
    {
        public CustomerRoleConfig()
        {
            HasKey(x => x.Id);
            //Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}
