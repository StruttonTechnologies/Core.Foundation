namespace STSS.Core.Rules;

/// <summary>
/// Provides dependency-free rules for date and time ranges.
/// </summary>
public static class DateRangeRules
{
    public static bool IsValid(DateOnly start, DateOnly end)
    {
        return start <= end;
    }

    public static bool IsValid(DateTime start, DateTime end)
    {
        return start <= end;
    }

    public static bool Overlaps(DateOnly firstStart, DateOnly firstEnd, DateOnly secondStart, DateOnly secondEnd)
    {
        return IsValid(firstStart, firstEnd)
            && IsValid(secondStart, secondEnd)
            && firstStart <= secondEnd
            && secondStart <= firstEnd;
    }

    public static bool Overlaps(DateTime firstStart, DateTime firstEnd, DateTime secondStart, DateTime secondEnd)
    {
        return IsValid(firstStart, firstEnd)
            && IsValid(secondStart, secondEnd)
            && firstStart <= secondEnd
            && secondStart <= firstEnd;
    }
}
