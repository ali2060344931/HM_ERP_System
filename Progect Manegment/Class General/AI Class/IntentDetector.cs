public enum AiIntent
{
    Unknown,
    TopDebtor,
    MonthlySales,
    RiskCustomers
}

public static class IntentDetector
{
    public static AiIntent Detect(string question)
    {
        question = question?.Trim() ?? "";

        if (question.Contains("بدهکار"))
            return AiIntent.TopDebtor;

        if (question.Contains("فروش") && question.Contains("ماه"))
            return AiIntent.MonthlySales;

        if (question.Contains("بدحساب") || question.Contains("ریسک"))
            return AiIntent.RiskCustomers;

        return AiIntent.Unknown;
    }
}
