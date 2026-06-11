using StruttonTechnologies.Core.Domain.Models;

namespace StruttonTechnologies.Core.Domain.Entities.Utilities;

public static class ThemeRegistry
{
    private static readonly Dictionary<string, ThemeDefinition> _themes = new()
    {
        ["Light"] = new ThemeDefinition { Key = "Light", CssClass = "theme-light", DisplayName = "Light Mode" },
        ["Dark"] = new ThemeDefinition { Key = "Dark", CssClass = "theme-dark", DisplayName = "Dark Mode" },
        ["System"] = new ThemeDefinition { Key = "System", CssClass = "theme-system", DisplayName = "System Default" }
    };

    public static IReadOnlyDictionary<string, ThemeDefinition> All => _themes;

    public static void Register(ThemeDefinition theme)
    {
        if (theme?.Key == null) return;
        _themes[theme.Key] = theme;
    }

    public static ThemeDefinition? Get(string key) =>
        _themes.TryGetValue(key, out var theme) ? theme : null;
}
