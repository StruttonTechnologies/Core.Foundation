namespace StruttonTechnologies.Core.Repositories.Contracts.Crud;

public interface ISoftDeleteRepository<TEntity> : ISoftDeleteRepository<TEntity, Guid>
    where TEntity : class
{ }

public interface ISoftDeleteRepository<TEntity, TKey>
    where TEntity : class
    where TKey : IEquatable<TKey>
{
    Task<TEntity?> SoftDeleteAsync(TKey id, CancellationToken cancellationToken = default);
}
