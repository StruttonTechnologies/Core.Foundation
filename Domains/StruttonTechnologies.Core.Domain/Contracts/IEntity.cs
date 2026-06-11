namespace StruttonTechnologies.Core.Domain.Contracts;

/// <summary>
/// Represents an entity with a strongly typed identifier.
/// </summary>
/// <typeparam name="TKey">The type of the entity identifier.</typeparam>
public interface IEntity<TKey>
    where TKey : IEquatable<TKey>
{
    TKey Id { get; }
}
