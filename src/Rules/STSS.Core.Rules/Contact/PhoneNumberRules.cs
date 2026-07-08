using System.Text;

namespace STSS.Core.Rules;

/// <summary>
/// Provides dependency-free rules for North American phone number values.
/// </summary>
public static class PhoneNumberRules
{
    public const int NationalDigitCount = 10;
    public const int CountryCodeDigitCount = 11;

    public static bool IsValid(string? value)
    {
        var digits = GetDigits(value);

        return digits.Length == NationalDigitCount
            || (digits.Length == CountryCodeDigitCount && digits[0] == '1');
    }

    public static string Normalize(string value)
    {
        ArgumentNullException.ThrowIfNull(value);

        var digits = GetDigits(value);

        return digits.Length == CountryCodeDigitCount && digits[0] == '1'
            ? digits[1..]
            : digits;
    }

    public static string? FormatNational(string? value)
    {
        if (!IsValid(value))
        {
            return null;
        }

        var digits = Normalize(value!);

        return $"({digits[..3]}) {digits.Substring(3, 3)}-{digits[6..]}";
    }

    public static string GetDigits(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        var builder = new StringBuilder(value.Length);

        foreach (var character in value)
        {
            if (char.IsDigit(character))
            {
                builder.Append(character);
            }
        }

        return builder.ToString();
    }
}
