namespace StruttonTechnologies.Core.Domain.Contracts;

/// <summary>
/// Defines properties for an auditable entity with creation and modification metadata.
/// </summary>
/// <typeparam name="TUser">The type of the user associated with entity tracking.</typeparam>
public interface IAuditableEntity<TUser>
{
    /// <summary>
    /// Gets or sets the date and time when the entity was created (in UTC).
    /// </summary>
    DateTime CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was last modified (in UTC).
    /// </summary>
    DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who created the entity.
    /// </summary>
    Guid? CreatedById { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who last modified the entity.
    /// </summary>
    Guid? ModifiedById { get; set; }

    /// <summary>
    /// Gets or sets the user who created the entity.
    /// </summary>
    TUser? CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the user who last modified the entity.
    /// </summary>
    TUser? ModifiedBy { get; set; }
}
