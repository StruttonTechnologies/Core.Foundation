namespace STSS.Core.Coordinator.Contracts.Crud.Commands;

/// <summary>
/// Represents a command to delete a DTO by its identifier.
/// </summary>
/// <typeparam name="TDto">The type of the DTO to be deleted.</typeparam>
/// <typeparam name="TKey">The type of the identifier.</typeparam>
public record DeleteCommand<TDto, TKey>(TKey Id) : IRequest<Unit>
    where TDto : class
    where TKey : IEquatable<TKey>;
