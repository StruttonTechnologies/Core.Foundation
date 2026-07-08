namespace STSS.Core.Identity.Coordinator.Contracts.Authorization.Queries;

/// <summary>
/// Query to retrieve a ClaimsPrincipalDto for a given user ID.
/// </summary>
public sealed record GetClaimsPrincipalQuery(string UserId) : IRequest<ClaimsPrincipalDto>;
