using System.ComponentModel.DataAnnotations;

using StruttonTechnologies.Core.Domain.Contracts;

namespace StruttonTechnologies.Core.Domain.Entities.Base;

/// <summary>
/// Base class for persisted business entities with identity, auditing,
/// soft-delete support, and optimistic concurrency control.
/// </summary>
/// <typeparam name="TKey">The entity key type.</typeparam>
public abstract class EntityBase<TKey> : IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Gets or sets the primary key.
    /// </summary>
    public TKey Id { get; set; } = default!;

    /// <summary>
    /// Gets or sets the date and time the entity was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user or process that created the entity.
    /// </summary>
    public TKey CreatedBy { get; set; } = default!;

    /// <summary>
    /// Gets or sets the date and time the entity was last modified.
    /// </summary>
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user or process that last modified the entity.
    /// </summary>
    public TKey? ModifiedBy { get; set; } = default!;

    /// <summary>
    /// Gets or sets a value indicating whether the entity has been soft deleted.
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets the date and time the entity was soft deleted.
    /// </summary>
    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user or process that soft deleted the entity.
    /// </summary>
    public TKey? DeletedBy { get; set; } = default!;

    /// <summary>
    /// Gets or sets the optimistic concurrency token.
    /// </summary>
    [Timestamp]
    public byte[] RowVersion { get; set; } = default!;
}
