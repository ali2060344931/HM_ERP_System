using NPOI.HSSF.Record.Chart;

using Progect_Manegment;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static MyClass.PersianDate;

namespace HM_ERP_System.Class_General.AI_Class
{
    public class AccountingAiRepository : IAccountingAiRepository
    {
        private readonly DBcontextModel _db;

        public AccountingAiRepository(DBcontextModel db)
        {
            _db = db;
        }


        public double GetSales(string fromShamsi, string toShamsi)
        {
            return _db.Transactions
                .AsNoTracking()
                .Where(t =>
                    t.Status &&
                    t.FinalRegistry &&
                    string.Compare(t.TransactionDate, fromShamsi) >= 0 &&
                    string.Compare(t.TransactionDate, toShamsi) <= 0
                )
                .Sum(t => (double?)t.PaymentBes) ?? 0;
        }
        public (int DetailedAccountId, string Name, double Amount) GetTopDebtorWithName()
        {
            var result = _db.Transactions
                .AsNoTracking()
                .Where(t => !t.Status && !t.FinalRegistry && !t.IsBeginningBalance)
                .GroupBy(t => t.DetailedAccountId)
                .Select(g => new
                {
                    DetailedAccountId = g.Key,
                    NetDebt =
                        g.Sum(x => (double)x.PaymentBed) -
                        g.Sum(x => (double)x.PaymentBes)
                })
                .Where(x => x.NetDebt > 0)
                .OrderByDescending(x => x.NetDebt)
                .FirstOrDefault();

            if (result == null)
                return (0, "یافت نشد", 0);

            var customerInfo =
                (from d in _db.DetailedAccounts
                 join c in _db.Customers
                     on d.CustomerId equals c.Id
                 where d.Id == result.DetailedAccountId
                 select new
                 {
                     FullName = c.Name + " " + c.Family
                 })
                .FirstOrDefault();

            string fullName = customerInfo != null
                ? customerInfo.FullName
                : "نامشخص";

            return (result.DetailedAccountId, fullName, result.NetDebt);
        }



        public (int DetailedAccountId, double Amount) GetTopDebtor()
        {
            return _db.Transactions
                .AsNoTracking()
                .Where(t =>
                    t.Status &&
                    t.FinalRegistry &&
                    !t.IsBeginningBalance
                )
                .GroupBy(t => t.DetailedAccountId)
                .Select(g => new
                {
                    DetailedAccountId = g.Key,
                    NetDebt =
                        g.Sum(x => (double)x.PaymentBed) -
                        g.Sum(x => (double)x.PaymentBes)
                })
                .Where(x => x.NetDebt > 0)
                .OrderByDescending(x => x.NetDebt)
                .AsEnumerable()
                .Select(x => (x.DetailedAccountId, x.NetDebt))
                .FirstOrDefault();
        }


        public double GetTopDebtorAmount()
        {
            return _db.Transactions
                .AsNoTracking()
                .Where(t =>
                    t.Status == true &&           // سند ابطال نشده
                    t.FinalRegistry == true &&    // ثبت نهایی
                    !t.IsBeginningBalance         // مانده اول دوره نباشد
                )
                .GroupBy(t => t.DetailedAccountId)
                .Select(g => new
                {
                    NetDebt = g.Sum(x => (double)x.PaymentBed)
                            - g.Sum(x => (double)x.PaymentBes)
                })
                .Where(x => x.NetDebt > 0)
                .OrderByDescending(x => x.NetDebt)
                .Select(x => x.NetDebt)
                .FirstOrDefault();
        }

        public double GetMonthlySales(string  from, string to)
        {
            return _db.Transactions
                .AsNoTracking()
                .Where(t =>
                    string.Compare(t.TransactionDate, from) >= 0 &&
                    string.Compare(t.TransactionDate, to) <= 0 
                )
                .Sum(t => (double?)t.PaymentBed) ?? 0;
        }
    }
}
