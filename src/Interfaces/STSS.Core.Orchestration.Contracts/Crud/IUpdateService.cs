namespace STSS.Core.Orchestration.Contracts.Crud;

public interface IUpdateService<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task<IEnumerable<TEntity>> BulkUpdateAsync(
        IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default);
}
