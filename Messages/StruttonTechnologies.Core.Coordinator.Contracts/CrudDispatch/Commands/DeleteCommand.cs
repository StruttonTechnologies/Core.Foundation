namespace StruttonTechnologies.Core.Coordinator.Contracts.CrudDispatch.Commands;

/// <summary>
/// Represents a command to delete a DTO by its identifier.
/// </summary>
/// <typeparam name="TDto">The type of the DTO to be deleted.</typeparam>
/// <typeparam name="TKey">The type of the identifier.</typeparam>
public record DeleteCommand<TDto, TKey>(TKey Id) : IRequest<IUnit>
    where TDto : class
    where TKey : IEquatable<TKey>;
