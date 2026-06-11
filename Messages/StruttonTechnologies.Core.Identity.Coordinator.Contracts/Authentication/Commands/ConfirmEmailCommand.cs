using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Identity;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

[ExcludeFromCodeCoverage]
public sealed record ConfirmEmailCommand(string UserId, string Token)
: IRequest<IdentityResult>;
