namespace STSS.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents a request to change an authenticated user's password.
/// </summary>
public sealed record ChangePasswordRequestDto(
    string CurrentPassword,
    string NewPassword,
    string? ConfirmPassword = null);

/// <summary>
/// Represents the result of a password-change operation.
/// </summary>
public sealed record ChangePasswordResultDto(
    bool IsSuccess,
    string? FailureReason = null)
{
    /// <summary>
    /// Creates a successful password-change result.
    /// </summary>
    public static ChangePasswordResultDto SuccessResult()
    {
        return new(true);
    }

    /// <summary>
    /// Creates a failed password-change result.
    /// </summary>
    public static ChangePasswordResultDto Failure(string reason)
    {
        return new(false, reason);
    }
}

/// <summary>
/// Represents a forgot-password request.
/// </summary>
public sealed record ForgotPasswordRequestDto(string Email);

/// <summary>
/// Represents the result of a forgot-password request.
/// </summary>
public sealed record ForgotPasswordResultDto(
    bool IsSuccess,
    string? ResetToken = null,
    string? FailureReason = null)
{
    /// <summary>
    /// Creates a successful forgot-password result.
    /// </summary>
    public static ForgotPasswordResultDto SuccessResult(string? resetToken = null)
    {
        return new(true, resetToken);
    }

    /// <summary>
    /// Creates a failed forgot-password result.
    /// </summary>
    public static ForgotPasswordResultDto Failure(string reason)
    {
        return new(false, null, reason);
    }
}

/// <summary>
/// Represents a password-reset request.
/// </summary>
public sealed record ResetPasswordRequestDto(
    string UserId,
    string Token,
    string NewPassword,
    string? ConfirmPassword = null);

/// <summary>
/// Represents the result of a password-reset operation.
/// </summary>
public sealed record ResetPasswordResultDto(
    bool IsSuccess,
    string? FailureReason = null)
{
    /// <summary>
    /// Creates a successful password-reset result.
    /// </summary>
    public static ResetPasswordResultDto SuccessResult()
    {
        return new(true);
    }

    /// <summary>
    /// Creates a failed password-reset result.
    /// </summary>
    public static ResetPasswordResultDto Failure(string reason)
    {
        return new(false, reason);
    }
}
