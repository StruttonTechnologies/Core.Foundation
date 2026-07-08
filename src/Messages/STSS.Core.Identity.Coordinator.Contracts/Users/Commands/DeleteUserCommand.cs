using Microsoft.AspNetCore.Identity;

namespace STSS.Core.Identity.Coordinator.Contracts.Users.Commands;

public sealed record DeleteUserCommand(string UserId)
: IRequest<IdentityResult>;
