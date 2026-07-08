namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to disable multi-factor authentication for a user.
/// </summary>
public sealed record DisableMfaCommand(
    string UserId)
    : IRequest<MfaVerifyResultDto>;
