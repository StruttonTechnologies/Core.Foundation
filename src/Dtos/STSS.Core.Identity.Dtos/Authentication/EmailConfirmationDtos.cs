namespace STSS.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents an email-confirmation request.
/// </summary>
public sealed record ConfirmEmailRequestDto(
    string UserId,
    string Token);

/// <summary>
/// Represents the result of an email-confirmation operation.
/// </summary>
public sealed record ConfirmEmailResultDto(
    bool IsSuccess,
    string? FailureReason = null)
{
    /// <summary>
    /// Creates a successful email-confirmation result.
    /// </summary>
    public static ConfirmEmailResultDto SuccessResult()
    {
        return new(true);
    }

    /// <summary>
    /// Creates a failed email-confirmation result.
    /// </summary>
    public static ConfirmEmailResultDto Failure(string reason)
    {
        return new(false, reason);
    }
}

/// <summary>
/// Represents a request to resend an email-confirmation token.
/// </summary>
public sealed record ResendEmailConfirmationRequestDto(string Email);

/// <summary>
/// Represents the result of a resend-email-confirmation operation.
/// </summary>
public sealed record ResendEmailConfirmationResultDto(
    bool IsSuccess,
    string? ConfirmationToken = null,
    string? FailureReason = null)
{
    /// <summary>
    /// Creates a successful resend-email-confirmation result.
    /// </summary>
    public static ResendEmailConfirmationResultDto SuccessResult(string? confirmationToken = null)
    {
        return new(true, confirmationToken);
    }

    /// <summary>
    /// Creates a failed resend-email-confirmation result.
    /// </summary>
    public static ResendEmailConfirmationResultDto Failure(string reason)
    {
        return new(false, null, reason);
    }
}
