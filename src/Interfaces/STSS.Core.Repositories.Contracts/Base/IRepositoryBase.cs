using STSS.Core.Repositories.Contracts.Crud;

namespace STSS.Core.Repositories.Contracts.Base;

/// <summary>
/// Defines the complete repository contract for an entity that uses a
/// <see cref="Guid"/> as its primary key.
/// </summary>
/// <typeparam name="TEntity">
/// The entity type managed by the repository.
/// </typeparam>
public interface IRepositoryBase<TEntity> : IRepositoryBase<TEntity, Guid>
    where TEntity : class
{
}

/// <summary>
/// Defines the complete repository contract for an entity by composing
/// the create, read, update, delete, soft-delete, and query-helper contracts.
/// </summary>
/// <typeparam name="TEntity">
/// The entity type managed by the repository.
/// </typeparam>
/// <typeparam name="TKey">
/// The type used as the entity's primary key.
/// </typeparam>
public interface IRepositoryBase<TEntity, TKey> :
    ICreateRepository<TEntity>,
    IReadRepository<TEntity, TKey>,
    IUpdateRepository<TEntity>,
    IDeleteRepository<TEntity, TKey>,
    ISoftDeleteRepository<TEntity, TKey>,
    IQueryHelpers<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
}
