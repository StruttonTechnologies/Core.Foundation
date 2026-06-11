using StruttonTechnologies.Core.Domain.Entities;

namespace StruttonTechnologies.Core.Orchestration.Contracts;

public interface IPersonOrchestration<TKey>
    where TKey : IEquatable<TKey>
{
    Task<Person<TKey>?> CreatePersonAsync(Person<TKey> person, CancellationToken cancellationToken = default);

    Task<Person<TKey>?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

    Task<Person<TKey>?> FindByIdentityAsync(string firstName, string lastName, string Email, CancellationToken cancellationToken = default);

    Task<bool> EmailExistsAsync(string email, CancellationToken cancellationToken = default);
}
