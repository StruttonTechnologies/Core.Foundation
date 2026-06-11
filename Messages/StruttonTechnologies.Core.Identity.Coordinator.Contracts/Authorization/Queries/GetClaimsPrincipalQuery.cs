using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authorization.Queries;

/// <summary>
/// Query to retrieve a ClaimsPrincipalDto for a given user ID.
/// </summary>
[ExcludeFromCodeCoverage]
public sealed record GetClaimsPrincipalQuery(string UserId) : IRequest<ClaimsPrincipalDto>;
