namespace STSS.Core.Coordinator.Contracts.Crud.Commands;

/// <summary>
/// Represents a command to update a DTO by Id.
/// </summary>
/// <typeparam name="TDto">The DTO type to update.</typeparam>
/// <typeparam name="TKey">The identifier type.</typeparam>
public record UpdateCommand<TDto, TKey>(TKey Id, TDto Payload) : IRequest<TDto>
    where TDto : class
    where TKey : IEquatable<TKey>;
