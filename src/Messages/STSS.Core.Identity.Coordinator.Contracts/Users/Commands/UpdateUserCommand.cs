using Microsoft.AspNetCore.Identity;

namespace STSS.Core.Identity.Coordinator.Contracts.Users.Commands;

public sealed record UpdateUserCommand(string UserId, string? Email, string? PhoneNumber)
: IRequest<IdentityResult>;
