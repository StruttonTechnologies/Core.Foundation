namespace StruttonTechnologies.Core.Coordinator.Contracts.CrudDispatch.Commands;

/// <summary>
/// Represents a command to perform a soft delete on a DTO by its identifier.
/// </summary>
/// <typeparam name="TDto">The DTO type to be soft deleted.</typeparam>
/// <typeparam name="TKey">The identifier type.</typeparam>
public record SoftDeleteCommand<TDto, TKey>(TKey Id) : IRequest<IUnit>
    where TDto : class
    where TKey : IEquatable<TKey>;
