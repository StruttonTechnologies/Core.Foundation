using System.Linq.Expressions;

namespace StruttonTechnologies.Core.Repositories.Contracts.Crud;


public interface IGuidQueryHelpers<TEntity> : IQueryHelpers<TEntity, Guid>
    where TEntity : class
{ }

public interface IQueryHelpers<TEntity, TKey>
where TEntity : class
where TKey : IEquatable<TKey>
{
    Task<int> CountAsync(Expression<Func<TEntity, bool>>? filter = null, CancellationToken cancellationToken = default);
    Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> filter, CancellationToken cancellationToken = default);
    Task<bool> ExistsAsync(TKey id, CancellationToken cancellationToken = default);
}
