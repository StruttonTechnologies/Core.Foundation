namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Queries;

/// <summary>
/// Query to retrieve the current authenticated user's identity context.
/// </summary>
public sealed record GetCurrentUserQuery(
    string UserId)
    : IRequest<CurrentUserDto>;
