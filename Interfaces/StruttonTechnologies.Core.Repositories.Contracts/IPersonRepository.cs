using StruttonTechnologies.Core.Domain.Entities;
using StruttonTechnologies.Core.Repositories.Contracts.Crud;

namespace StruttonTechnologies.Core.Repositories.Contracts;

/// <summary>
/// Contract for managing Person entities with audit and transaction support.
/// </summary>
/// <typeparam name="TPerson">The concrete person type.</typeparam>
/// <typeparam name="TKey">The type of the person identifier.</typeparam>
public interface IPersonRepository<TPerson, TKey> : ICrudRepository<TPerson, TKey>
    where TPerson : Person<TKey>, new()
    where TKey : IEquatable<TKey>
{
    Task<TPerson?> FindByIdentityAsync(
        string firstName,
        string lastName,
        string Email,
        CancellationToken cancellationToken = default);

    Task<TPerson?> GetByEmailAsync(string email, CancellationToken cancellationToken);

    Task<bool> EmailExistsAsync(string email, CancellationToken cancellationToken);
}
