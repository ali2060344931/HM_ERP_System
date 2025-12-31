public enum AiIntent
{
    Unknown = 0,
    TopDebtor = 1,
    MonthlySales = 2,
    GetBillOfLadings = 3   //حواله ها
}

public static class IntentDetector
{
    public static AiIntent Detect(string question)
    {
        question = Normalize(question);

        if (question.Contains("فروش") ||
            question.Contains("درآمد") ||
            question.Contains("جمع فروش"))
            return AiIntent.MonthlySales;

        if (question.Contains("بدهکار"))
            return AiIntent.TopDebtor;
        if (question.Contains("حواله")|| question.Contains("بارنامه") || question.Contains("پورسانت") || question.Contains("کامیون") || question.Contains("راننده") || question.Contains("پلاک"))
            return AiIntent.GetBillOfLadings;

        return AiIntent.Unknown;
    }

    private static string Normalize(string input)
    {
        return input
            .Replace("ي", "ی")
            .Replace("ك", "ک")
            .Trim()
            .ToLower();
    }
}


//public static class IntentDetector
//{
//    public static AiIntent Detect(string question)
//    {
//        question = question?.Trim() ?? "";

//        if (question.Contains("بدهکار"))
//            return AiIntent.TopDebtor;

//        if (question.Contains("فروش") && question.Contains("ماه"))
//            return AiIntent.MonthlySales;

//        return AiIntent.Unknown;
//    }
//}
