namespace StruttonTechnologies.Core.Repositories.Contracts.Crud;


public interface ICreateRepository<TEntity>
    where TEntity : class
{
    Task<TEntity> AddAsync(
        TEntity entity,
        CancellationToken cancellationToken = default);

    Task<IEnumerable<TEntity>> BulkInsertAsync(
       IEnumerable<TEntity> entities,
       CancellationToken cancellationToken = default);
}
