namespace STSS.Core.Rules;

/// <summary>
/// Provides dependency-free rules for Guid identifier values.
/// </summary>
public static class GuidRules
{
    public static bool IsAssigned(Guid value)
    {
        return value != Guid.Empty;
    }

    public static bool IsValidString(string? value)
    {
        return Guid.TryParse(value, out var parsed) && IsAssigned(parsed);
    }
}
