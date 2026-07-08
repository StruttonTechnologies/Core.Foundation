namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to reset a user's password using a password reset token.
/// </summary>
public sealed record ResetPasswordCommand(
    string UserId,
    string Token,
    string NewPassword,
    string? ConfirmPassword = null)
    : IRequest<ResetPasswordResultDto>;
