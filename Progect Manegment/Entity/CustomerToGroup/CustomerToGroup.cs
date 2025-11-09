using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.CustomerToGroup
{
    /// <summary>
    /// اختصاص اشخاص به گروه
    /// </summary>
    public class CustomerToGroup
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PersonGroupId { get; set; }
    }
    public class CustomerToGroupConfig : EntityTypeConfiguration<CustomerToGroup>
    {
        public CustomerToGroupConfig()
        {
            HasKey(x => x.Id);
        }
    }

}
