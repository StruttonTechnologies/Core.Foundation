namespace StruttonTechnologies.Core.Dtos.Navigation;

/// <summary>
/// Represents metadata information for an application.
/// </summary>
public class AppMetaDataDto
{
    /// <summary>
    /// Gets or sets the display name of the app.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the path to the logo or icon asset.
    /// </summary>
    public string IconPath { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the optional tagline or summary.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the default or resolved UI theme.
    /// </summary>
    public string Theme { get; set; } = "Light";

    /// <summary>
    /// Gets or sets a value indicating whether the app is visible at runtime.
    /// </summary>
    public bool IsActive { get; set; } = true;
}
