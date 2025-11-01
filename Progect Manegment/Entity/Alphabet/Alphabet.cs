using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.Alphabet
{
    /// <summary>
    /// حروف الفبا
    /// </summary>
    public class Alphabet
    {
        public int Id { get; set; }
        public string AlphabetName { get; set; }
    }
    public class AlphabetConfig : EntityTypeConfiguration<Alphabet>
    {
        public AlphabetConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.AlphabetName).IsRequired().HasMaxLength(3);
        }
    }
}
