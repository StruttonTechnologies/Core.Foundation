namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to sign a user out of all devices by revoking all active refresh tokens.
/// </summary>
public sealed record SignOutAllDevicesCommand(
    string UserId)
    : IRequest<SignOutResultDto>;
