namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to begin multi-factor authentication setup for a user.
/// </summary>
public sealed record SetupMfaCommand(
    string UserId)
    : IRequest<MfaSetupResultDto>;
