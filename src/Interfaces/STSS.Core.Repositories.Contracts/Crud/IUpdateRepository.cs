namespace STSS.Core.Repositories.Contracts.Crud;

public interface IUpdateRepository<TEntity>
    where TEntity : class
{
    Task<TEntity> UpdateAsync(
        TEntity entity,
        CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> BulkUpdateAsync(
        IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default);
}
