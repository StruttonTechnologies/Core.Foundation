namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to verify a multi-factor authentication code for a user.
/// </summary>
public sealed record VerifyMfaCommand(
    string UserId,
    string Code)
    : IRequest<MfaVerifyResultDto>;
