using System.Text.RegularExpressions;

namespace STSS.Core.Rules;

/// <summary>
/// Provides dependency-free rules for email address values.
/// </summary>
public static partial class EmailRules
{
    public const int MaximumLength = 254;

    public static bool IsValid(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        var normalized = Normalize(value);

        if (normalized.Length > MaximumLength)
        {
            return false;
        }

        return EmailRegex().IsMatch(normalized);
    }

    public static string Normalize(string value)
    {
        ArgumentNullException.ThrowIfNull(value);

        return value.Trim().ToLowerInvariant();
    }

    public static string? GetDomain(string? value)
    {
        if (!IsValid(value))
        {
            return null;
        }

        var normalized = Normalize(value!);
        var separatorIndex = normalized.LastIndexOf('@');

        return separatorIndex < 0 ? null : normalized[(separatorIndex + 1)..];
    }

    [GeneratedRegex("^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$", RegexOptions.CultureInvariant, 250)]
    private static partial Regex EmailRegex();
}
