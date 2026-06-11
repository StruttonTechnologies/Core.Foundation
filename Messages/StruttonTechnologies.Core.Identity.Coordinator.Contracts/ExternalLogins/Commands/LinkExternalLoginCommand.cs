using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Identity;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.ExternalLogins.Commands;

[ExcludeFromCodeCoverage]
public sealed record LinkExternalLoginCommand(string UserId, string Provider, string ProviderKey, string Token)
: IRequest<IdentityResult>;
