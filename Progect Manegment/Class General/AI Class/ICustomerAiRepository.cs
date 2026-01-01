using HM_ERP_System.Class_General.AI_Class.EntityGpt;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Class_General.AI_Class
{
    public interface ICustomerAiRepository
    {
        object Query(CustomerQueryEntity entity, AiIntent intent);
    }
}
