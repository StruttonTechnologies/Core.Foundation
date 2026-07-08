namespace STSS.Core.Domain.Entities.Base;

/// <summary>
/// Defines a contract for entities that support soft deletion.
/// </summary>
public interface ISoftDeletable
{
    /// <summary>
    /// Gets or sets a value indicating whether the entity has been soft deleted.
    /// </summary>
    bool IsDeleted { get; set; }
}