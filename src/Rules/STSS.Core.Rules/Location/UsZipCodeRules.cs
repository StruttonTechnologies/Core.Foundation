using System.Text.RegularExpressions;

namespace STSS.Core.Rules;

/// <summary>
/// Provides dependency-free rules for United States ZIP code values.
/// </summary>
public static partial class UsZipCodeRules
{
    public static bool IsValid(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        return ZipCodeRegex().IsMatch(value.Trim());
    }

    public static string Normalize(string value)
    {
        ArgumentNullException.ThrowIfNull(value);

        return value.Trim();
    }

    public static bool IsZipPlusFour(string? value)
    {
        return IsValid(value) && Normalize(value!).Length == 10;
    }

    [GeneratedRegex("^\\d{5}(-\\d{4})?$", RegexOptions.CultureInvariant, 250)]
    private static partial Regex ZipCodeRegex();
}
