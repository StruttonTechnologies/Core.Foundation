using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.ExternalLogins.Commands;

[ExcludeFromCodeCoverage]
public sealed record ExternalLoginCommand(string Provider, string IdToken)
: IRequest<TokenResponseDto>;
