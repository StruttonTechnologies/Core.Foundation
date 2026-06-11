using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Identity;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authorization.Commands;

[ExcludeFromCodeCoverage]
public sealed record RemoveRoleCommand(string UserId, string RoleName)
: IRequest<IdentityResult>;
