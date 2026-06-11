namespace StruttonTechnologies.Core.Coordinator.Contracts.CrudDispatch.Queries;

/// <summary>
/// Query to retrieve a single DTO by its ID.
/// </summary>
/// <typeparam name="TDto">The type of the DTO.</typeparam>
/// <typeparam name="TKey">The type of the identifier.</typeparam>
public record GetByIdQuery<TDto, TKey>(TKey Id) : IRequest<TDto?>
    where TDto : class
    where TKey : IEquatable<TKey>;
