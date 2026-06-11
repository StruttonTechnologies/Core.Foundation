namespace StruttonTechnologies.Core.Coordinator.Contracts.CrudDispatch.Commands;

/// <summary>
/// Represents a request to create a new DTO.
/// </summary>
/// <typeparam name="TDto">The DTO used to construct the entity.</typeparam>
/// <typeparam name="TKey">The type of the identifier.</typeparam>
public record CreateCommand<TDto, TKey>(TDto Payload) : IRequest<TDto>
    where TDto : class
    where TKey : IEquatable<TKey>;
