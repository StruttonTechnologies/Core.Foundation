using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Domain.Entities.Base;

/// <summary>
/// Base class for persisted business entities that have a user-facing name
/// and optional description.
/// </summary>
/// <typeparam name="TKey">The entity key type.</typeparam>
[ExcludeFromCodeCoverage]
public abstract class NameableEntityBase<TKey> : EntityBase<TKey>
    where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Gets or sets the display name of the entity.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the optional description of the entity.
    /// </summary>
    public string? Description { get; set; }
}
