namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to regenerate multi-factor authentication recovery codes for a user.
/// </summary>
public sealed record RegenerateMfaRecoveryCodesCommand(
    string UserId)
    : IRequest<MfaRecoveryCodesResultDto>;
