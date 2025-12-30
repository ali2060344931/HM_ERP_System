using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AiQueryService
{
    private readonly AccountingRepository _repo;

    public AiQueryService(AccountingRepository repo)
    {
        _repo = repo;
    }

    public AiResponse Execute(string question)
    {
        var intent = IntentDetector.Detect(question);

        switch (intent)
        {
            case AiIntent.TopDebtor:
                var debt = _repo.GetTopDebtorAmount();
                return AiResponse.Ok(
                    intent,
                    debt,
                    $"بیشترین بدهی ثبت شده: {debt:N0} ریال"
                );

            case AiIntent.MonthlySales:
                var (from, to) = DateRules.CurrentMonth();
                var sales = _repo.GetMonthlySales(from, to);
                return AiResponse.Ok(
                    intent,
                    sales,
                    $"میزان فروش این ماه: {sales:N0} ریال"
                );

            default:
                return AiResponse.Fail("سؤال قابل تحلیل نیست.");
        }
    }
}
