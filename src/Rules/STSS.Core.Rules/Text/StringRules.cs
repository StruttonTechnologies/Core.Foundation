namespace STSS.Core.Rules;

/// <summary>
/// Provides dependency-free rules for general string values.
/// </summary>
public static class StringRules
{
    public static bool HasValue(string? value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }

    public static bool IsWithinLength(string? value, int maximumLength)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(maximumLength);

        return value is not null && value.Length <= maximumLength;
    }

    public static bool IsWithinLength(string? value, int minimumLength, int maximumLength)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(minimumLength);
        ArgumentOutOfRangeException.ThrowIfLessThan(maximumLength, minimumLength);

        return value is not null && value.Length >= minimumLength && value.Length <= maximumLength;
    }

    public static string NormalizeWhiteSpace(string value)
    {
        ArgumentNullException.ThrowIfNull(value);

        return string.Join(' ', value.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries));
    }
}
