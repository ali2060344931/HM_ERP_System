using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_ERP_System.Class_General.AI_Class
{
    public interface IAccountingAiRepository
    {
        double GetTopDebtorAmount();
        (int DetailedAccountId, double Amount) GetTopDebtor();
        (int DetailedAccountId, string Name, double Amount) GetTopDebtorWithName();
        double GetMonthlySales(string  from, string to);
    }
}
