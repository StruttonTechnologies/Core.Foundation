namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to sign out by revoking access and refresh tokens.
/// </summary>
public sealed record SignOutCommand(
    string? AccessToken,
    string? RefreshToken)
    : IRequest<SignOutResultDto>;
