using StruttonTechnologies.Core.Domain.Entities.Base;

using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Domain.Entities.Configuration;

/// <summary>
/// Provides a base entity for application configuration records that control
/// branding and basic behavior of an application.
/// </summary>
/// <remarks>
/// This base class is intended as a starting point for applications that wish
/// to store configurable application settings in the database rather than in
/// static configuration files.
///
/// Consumers may either:
/// <list type="bullet">
/// <item>
/// Inherit from this class to extend the configuration model with
/// application-specific settings.
/// </item>
/// <item>
/// Use the default <see cref="ApplicationConfiguration"/> implementation
/// provided by CoreCapabilities.
/// </item>
/// </list>
/// </remarks>
/// <typeparam name="TKey">
/// The key type used for the configuration entity.
/// </typeparam>
[ExcludeFromCodeCoverage]
public abstract class ApplicationConfigurationBase<TKey> : EntityBase<TKey>
    where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Gets or sets the display name of the application.
    /// </summary>
    /// <remarks>
    /// This value may be shown in navigation bars, page titles,
    /// or other UI elements that identify the application.
    /// </remarks>
    public string ApplicationName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the path or URL to the application logo or icon.
    /// </summary>
    /// <remarks>
    /// This is typically used for branding purposes in the UI,
    /// such as displaying a logo in the header or login screen.
    /// </remarks>
    public string LogoPath { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a short description or tagline for the application.
    /// </summary>
    /// <remarks>
    /// This value may be used in landing pages, about screens,
    /// or other descriptive contexts.
    /// </remarks>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the UI theme used by the application.
    /// </summary>
    /// <remarks>
    /// The value is application-defined but commonly represents
    /// themes such as "Light", "Dark", or a custom theme identifier.
    /// </remarks>
    public string Theme { get; set; } = "Light";

    /// <summary>
    /// Gets or sets a value indicating whether the configuration
    /// record is currently active.
    /// </summary>
    /// <remarks>
    /// This can be used to enable or disable a configuration
    /// without deleting it from the system.
    /// </remarks>
    public bool IsActive { get; set; } = true;
}
