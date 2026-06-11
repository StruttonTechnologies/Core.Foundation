namespace StruttonTechnologies.Core.Repositories.Contracts.Crud;

/// <summary>
/// A generic repository interface that provides standard CRUD operations for entities with Guid as the key.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
public interface ICrudRepository<TEntity> : ICrudRepository<TEntity, Guid>
    where TEntity : class
{ }

public interface ICrudRepository<TEntity, TKey> :
    IQueryHelpers<TEntity,TKey>,
    ICreateRepository<TEntity>,
    IReadRepository<TEntity, TKey>,
    IUpdateRepository<TEntity>,
    IDeleteRepository<TEntity, TKey>,
    ISoftDeleteRepository<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{ }
