namespace STSS.Core.Orchestration.Contracts.Crud;

public interface IDeleteService<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Deletes a single entity by ID. May perform hard or soft delete depending on implementation.
    /// </summary>
    Task<TEntity?> DeleteAsync(TKey id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes multiple entities by ID. May perform hard or soft delete depending on implementation.
    /// </summary>
    Task<IEnumerable<TEntity>> BulkDeleteAsync(IEnumerable<TKey> ids, CancellationToken cancellationToken = default);
}
