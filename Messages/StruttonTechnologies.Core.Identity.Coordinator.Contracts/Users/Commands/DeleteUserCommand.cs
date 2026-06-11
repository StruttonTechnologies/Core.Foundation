using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Identity;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Users.Commands;

[ExcludeFromCodeCoverage]
public sealed record DeleteUserCommand(string UserId)
: IRequest<IdentityResult>;
