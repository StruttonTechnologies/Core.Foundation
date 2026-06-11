using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Domain.Models;

[ExcludeFromCodeCoverage]
public class ThemeDefinition
{
    public string Key { get; set; } = default!;           // Unique theme key (e.g., "Light", "Dark", "Forest")
    public string CssClass { get; set; } = default!;      // CSS class for styling
    public string? DisplayName { get; set; }              // Optional name for UI
    public string? IconUrl { get; set; }                  // Optional icon or preview image
}
