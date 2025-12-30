using System;

public static class DateRules
{
    public static (DateTime from, DateTime to) CurrentMonth()
    {
        var now = DateTime.Now;
        var from = new DateTime(now.Year, now.Month, 1);
        return (from, now);
    }
}
