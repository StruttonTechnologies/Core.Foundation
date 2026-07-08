using Microsoft.AspNetCore.Identity;

namespace STSS.Core.Identity.Coordinator.Contracts.ExternalLogins.Commands;

public sealed record LinkExternalLoginCommand(string UserId, string Provider, string ProviderKey, string Token)
: IRequest<IdentityResult>;
