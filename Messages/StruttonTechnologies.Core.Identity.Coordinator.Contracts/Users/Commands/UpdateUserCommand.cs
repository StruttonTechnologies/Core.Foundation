using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Identity;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Users.Commands;

[ExcludeFromCodeCoverage]
public sealed record UpdateUserCommand(string UserId, string? Email, string? PhoneNumber)
: IRequest<IdentityResult>;
