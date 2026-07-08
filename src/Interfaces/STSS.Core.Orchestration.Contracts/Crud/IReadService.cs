using System.Linq.Expressions;

namespace STSS.Core.Orchestration.Contracts.Crud;

public interface IReadService<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    Task<TEntity?> GetByIdAsync(
        TKey id,
        CancellationToken cancellationToken = default,
        params Expression<Func<TEntity, object>>[] includeProperties);

    Task<IEnumerable<TEntity>> GetAllAsync();

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

    Task<int> CountAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        CancellationToken cancellationToken = default);
}
