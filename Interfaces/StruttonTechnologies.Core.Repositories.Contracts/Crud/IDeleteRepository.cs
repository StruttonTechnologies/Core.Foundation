namespace StruttonTechnologies.Core.Repositories.Contracts.Crud;

public interface IDeleteRepository<TEntity> : IDeleteRepository<TEntity, Guid>
    where TEntity : class
{}

public interface IDeleteRepository<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    Task<IEnumerable<TEntity>> BulkDeleteAsync(
        IEnumerable<TKey> ids,
        CancellationToken cancellationToken = default);
    Task<TEntity?> DeleteAsync(
        TKey id,
        CancellationToken cancellationToken = default);
}
