using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.PersonGroup
{
    /// <summary>
    /// گروه اشخاص
    /// </summary>
    public class PersonGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
    }
        public class PersonGroupConfig : EntityTypeConfiguration<PersonGroup>
    {
        public PersonGroupConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Name).IsRequired().HasMaxLength(50);
        }
    }

}
