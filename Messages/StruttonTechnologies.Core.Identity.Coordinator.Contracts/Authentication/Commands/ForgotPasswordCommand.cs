using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

[ExcludeFromCodeCoverage]
public sealed record ForgotPasswordCommand(string Email)
: IRequest<string>;
