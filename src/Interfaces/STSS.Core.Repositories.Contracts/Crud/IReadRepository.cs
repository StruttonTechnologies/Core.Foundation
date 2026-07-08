using System.Linq.Expressions;

namespace STSS.Core.Repositories.Contracts.Crud;

public interface IReadRepository<TEntity> : IReadRepository<TEntity, Guid>
    where TEntity : class
{ }

public interface IReadRepository<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<TEntity?> GetByIdAsync(
        TKey id,
        CancellationToken cancellationToken = default,
        params Expression<Func<TEntity, object>>[] includeProperties);

    /// <summary>
    /// Retrieves all entities with optional sorting, filtering, pagination, batching, and eager loading.
    /// </summary>
    Task<IEnumerable<TEntity>> GetAllAsync<TSortKey>(
        bool isSorted = false,
        Expression<Func<TEntity, TSortKey>>? orderBy = null,
        bool ascending = true,
        bool isPaginated = false,
        int pageNumber = 1,
        int pageSize = 100,
        bool isBatched = false,
        int batchSize = 100,
        Expression<Func<TEntity, bool>>? filter = null,
        CancellationToken cancellationToken = default,
        params Expression<Func<TEntity, object>>[] includeProperties);

    /// <summary>
    /// Retrieves entities by their identifiers with optional sorting, pagination, batching, and eager loading.
    /// </summary>
    Task<IEnumerable<TEntity>> GetManyByIdsAsync<TSortKey>(
        IEnumerable<TKey> ids,
        bool isSorted = false,
        Expression<Func<TEntity, TSortKey>>? orderBy = null,
        bool ascending = true,
        bool isPaginated = false,
        int pageNumber = 1,
        int pageSize = 100,
        bool isBatched = false,
        int batchSize = 100,
        CancellationToken cancellationToken = default,
        params Expression<Func<TEntity, object>>[] includeProperties);

    /// <summary>
    /// Non-generic overload for retrieving entities by IDs (no sorting).
    /// </summary>
    Task<IEnumerable<TEntity>> GetManyByIdsAsync(
        IEnumerable<TKey> ids,
        bool isPaginated = false,
        int pageNumber = 1,
        int pageSize = 100,
        CancellationToken cancellationToken = default,
        params Expression<Func<TEntity, object>>[] includeProperties);

    /// <summary>
    /// Retrieves entities matching a filter with optional sorting, pagination, batching, and eager loading.
    /// </summary>
    Task<IEnumerable<TEntity>> GetByFilterAsync<TSortKey>(
        Expression<Func<TEntity, bool>>? filter = null,
        bool isSorted = false,
        Expression<Func<TEntity, TSortKey>>? orderBy = null,
        bool ascending = true,
        bool isPaginated = false,
        int pageNumber = 1,
        int pageSize = 100,
        bool isBatched = false,
        int batchSize = 100,
        CancellationToken cancellationToken = default,
        params Expression<Func<TEntity, object>>[] includeProperties);
}
