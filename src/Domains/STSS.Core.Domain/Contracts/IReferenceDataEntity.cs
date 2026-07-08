namespace STSS.Core.Domain.Contracts;

/// <summary>
/// Defines properties for a reference data entity, including name and description, with default entity metadata.
/// </summary>
/// <typeparam name="TUser">The type of the user associated with entity tracking.</typeparam>
public interface IReferenceDataEntity<TUser> : IDefaultEntity<TUser>
{
    /// <summary>
    /// Gets or sets the name of the reference data entity.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets the description of the reference data entity.
    /// </summary>
    string Description { get; set; }
}
