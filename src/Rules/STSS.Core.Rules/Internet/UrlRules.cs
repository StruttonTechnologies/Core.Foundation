namespace STSS.Core.Rules;

/// <summary>
/// Provides dependency-free rules for URL values.
/// </summary>
public static class UrlRules
{
    public static bool IsValidAbsoluteHttpUrl(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        return Uri.TryCreate(value.Trim(), UriKind.Absolute, out var uri)
            && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
    }

    public static string Normalize(string value)
    {
        ArgumentNullException.ThrowIfNull(value);

        return value.Trim();
    }

    public static string? GetHost(string? value)
    {
        if (!IsValidAbsoluteHttpUrl(value))
        {
            return null;
        }

        return new Uri(Normalize(value!)).Host.ToLowerInvariant();
    }
}
