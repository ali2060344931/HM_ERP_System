using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Entity.AiQuestionLog
{
    public class AiQuestionLog
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Intent { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
        public class AiQuestionLogConfig : EntityTypeConfiguration<AiQuestionLog>
    {
        public AiQuestionLogConfig()
        {
            HasKey(x => x.Id);
            Property(d => d.Question).IsRequired().HasMaxLength(int.MaxValue);
            Property(d => d.Intent).IsRequired().HasMaxLength(100);
        }
    }
}
