namespace StruttonTechnologies.Core.Orchestration.Contracts.Crud;


public interface ICreateService<TEntity>
    where TEntity : class
{
    Task<TEntity> CreateAsync(
        TEntity entity,
        CancellationToken cancellationToken = default);

    Task<IEnumerable<TEntity>> BulkInsertAsync(
        IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default);
}

public interface ICreateService<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    Task<TEntity> CreateAsync(
        TEntity entity,
        CancellationToken cancellationToken = default);

    Task<IEnumerable<TEntity>> BulkInsertAsync(
        IEnumerable<TEntity> entities,
        CancellationToken cancellationToken = default);
}
