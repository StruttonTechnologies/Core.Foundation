namespace STSS.Core.Domain.Contracts;

/// <summary>
/// Defines properties for a default entity with soft-delete and active status, inheriting auditable metadata.
/// </summary>
/// <typeparam name="TUser">The type of the user associated with entity tracking.</typeparam>
public interface IDefaultEntity<TUser> : IAuditableEntity<TUser>
{
    /// <summary>
    /// Gets or sets a value indicating whether the entity is deleted (soft delete).
    /// </summary>
    bool IsDeleted { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entity is active.
    /// </summary>
    bool IsActive { get; set; }
}
