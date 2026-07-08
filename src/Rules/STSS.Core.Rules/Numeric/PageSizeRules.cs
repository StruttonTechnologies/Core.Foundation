namespace STSS.Core.Rules;

/// <summary>
/// Provides dependency-free rules for paging size values.
/// </summary>
public static class PageSizeRules
{
    public const int DefaultMinimum = 1;
    public const int DefaultMaximum = 500;

    public static bool IsValid(int value, int minimum = DefaultMinimum, int maximum = DefaultMaximum)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(minimum);
        ArgumentOutOfRangeException.ThrowIfLessThan(maximum, minimum);

        return value >= minimum && value <= maximum;
    }

    public static int Clamp(int value, int minimum = DefaultMinimum, int maximum = DefaultMaximum)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(minimum);
        ArgumentOutOfRangeException.ThrowIfLessThan(maximum, minimum);

        return Math.Clamp(value, minimum, maximum);
    }
}
