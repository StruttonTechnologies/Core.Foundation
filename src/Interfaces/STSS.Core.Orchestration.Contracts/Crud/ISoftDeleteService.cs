namespace STSS.Core.Orchestration.Contracts.Crud;

/// <summary>
/// Defines operations for entities that support soft deletion.
/// Instead of physically removing the entity, a soft delete
/// typically marks it as inactive or sets a deleted flag.
/// </summary>
public interface ISoftDeleteService<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Soft deletes an entity by its identifier.
    /// </summary>
    /// <param name="id">The identifier of the entity to soft delete.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>The updated entity if found; otherwise, null.</returns>
    Task<TEntity?> SoftDeleteAsync(TKey id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Soft deletes multiple entities by their identifiers.
    /// </summary>
    /// <param name="ids">The identifiers of the entities to soft delete.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>The updated entities.</returns>
    Task<IEnumerable<TEntity>> BulkSoftDeleteAsync(
        IEnumerable<TKey> ids,
        CancellationToken cancellationToken = default);
}
