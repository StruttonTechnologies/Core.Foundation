namespace StruttonTechnologies.Core.Orchestration.Contracts.Crud;

/// <summary>
/// Composite CRUD service interface that brings together
/// create, read, update, delete, and optional soft delete operations.
/// 
/// Use this when you want a full out-of-the-box CRUD orchestration
/// without needing to inherit each service individually.
/// </summary>
public interface ICrudService<TEntity, TKey> :
    ICreateService<TEntity,TKey>,
    IReadService<TEntity, TKey>,
    IUpdateService<TEntity, TKey>,
    IDeleteService<TEntity, TKey>,
    ISoftDeleteService<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{}
