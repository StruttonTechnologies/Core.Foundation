namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to change an authenticated user's password.
/// </summary>
public sealed record ChangePasswordCommand(
    string UserId,
    string CurrentPassword,
    string NewPassword,
    string? ConfirmPassword = null)
    : IRequest<ChangePasswordResultDto>;
