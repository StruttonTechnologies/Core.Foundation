namespace StruttonTechnologies.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents an MFA setup result.
/// </summary>
public sealed record MfaSetupResultDto(
    bool IsSuccess,
    string? SharedKey = null,
    string? AuthenticatorUri = null,
    string? FailureReason = null);

/// <summary>
/// Represents an MFA verification request.
/// </summary>
public sealed record MfaVerifyRequestDto(
    string Code);

/// <summary>
/// Represents the result of an MFA verification operation.
/// </summary>
public sealed record MfaVerifyResultDto(
    bool IsSuccess,
    string? FailureReason = null);

/// <summary>
/// Represents generated MFA recovery codes.
/// </summary>
public sealed record MfaRecoveryCodesResultDto(
    bool IsSuccess,
    IReadOnlyCollection<string> RecoveryCodes,
    string? FailureReason = null);
