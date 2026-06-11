using static StruttonTechnologies.MediatR.Abstracts.IUnit;

namespace StruttonTechnologies.Core.Coordinator.Contracts;

/// <summary>
/// Abstraction over MediatR for dispatching commands and queries.
/// </summary>
public interface ICoordinator
{
    Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);
    Task Send(IRequest<Unit> request, CancellationToken cancellationToken = default);
}
