using HM_ERP_System.Entity.AiQuestionLog;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Class_General.AI_Class
{
    public class AiLogRepository : IAiLogRepository
    {
        private readonly DBcontextModel _db;

        public AiLogRepository(DBcontextModel db)
        {
            _db = db;
        }

        public void Log(string question, AiIntent intent)
        {
            _db.AiQuestionLogs.Add(new AiQuestionLog
            {
                Question = question,
                Intent = intent.ToString()
            });

            _db.SaveChanges();
        }
    }
}
