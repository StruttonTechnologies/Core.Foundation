namespace STSS.Core.Coordinator.Contracts.Crud.Commands;

/// <summary>
/// Represents a command to perform a soft delete on a DTO by its identifier.
/// </summary>
/// <typeparam name="TDto">The DTO type to be soft deleted.</typeparam>
/// <typeparam name="TKey">The identifier type.</typeparam>
public record SoftDeleteCommand<TDto, TKey>(TKey Id) : IRequest<Unit>
    where TDto : class
    where TKey : IEquatable<TKey>;
