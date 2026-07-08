using Microsoft.AspNetCore.Identity;

namespace STSS.Core.Identity.Coordinator.Contracts.Authorization.Commands;

/// <summary>
/// Command to add a claim to a user.
/// </summary>
public sealed record AddClaimCommand(string UserId, string ClaimType, string ClaimValue)
    : IRequest<IdentityResult>;
