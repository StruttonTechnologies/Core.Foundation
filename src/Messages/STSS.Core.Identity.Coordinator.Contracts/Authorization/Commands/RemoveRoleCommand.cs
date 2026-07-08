using Microsoft.AspNetCore.Identity;

namespace STSS.Core.Identity.Coordinator.Contracts.Authorization.Commands;

public sealed record RemoveRoleCommand(string UserId, string RoleName)
: IRequest<IdentityResult>;
