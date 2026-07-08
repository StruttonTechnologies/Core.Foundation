namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to request a password reset token.
/// </summary>
public sealed record ForgotPasswordCommand(
    string Email)
    : IRequest<ForgotPasswordResultDto>;
