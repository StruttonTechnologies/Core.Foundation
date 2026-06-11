namespace StruttonTechnologies.Core.Domain.Contracts;

/// <summary>
/// Represents an entity that supports soft deletion.
/// </summary>
public interface ISoftDeletable
{
    bool IsDeleted { get; set; }
    DateTime? DeletedDate { get; set; }
    Guid? DeletedById { get; set; }
}
