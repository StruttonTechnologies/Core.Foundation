namespace StruttonTechnologies.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents the result of an authentication attempt.
/// </summary>
/// <param name="isSuccess">Indicates whether authentication succeeded.</param>
/// <param name="accessToken">The generated JWT access token.</param>
/// <param name="refreshToken">The generated refresh token.</param>
/// <param name="failureReason">The reason authentication failed, when applicable.</param>
public sealed record AuthenticationResultDto(
    bool IsSuccess,
    string AccessToken,
    string RefreshToken,
    string? FailureReason = null)
{
    /// <summary>
    /// Creates a successful authentication result.
    /// </summary>
    /// <param name="accessToken">The generated JWT access token.</param>
    /// <param name="refreshToken">The generated refresh token.</param>
    /// <returns>A successful authentication result.</returns>
    public static AuthenticationResultDto SuccessResult(
        string accessToken,
        string refreshToken)
    {
        return new(true, accessToken, refreshToken);
    }

    /// <summary>
    /// Creates a failed authentication result.
    /// </summary>
    /// <param name="reason">The failure reason.</param>
    /// <returns>A failed authentication result.</returns>
    public static AuthenticationResultDto Failure(string reason)
    {
        return new(false, string.Empty, string.Empty, reason);
    }

    /// <summary>
    /// Gets a value indicating whether authentication failed.
    /// </summary>
    public bool IsFailure => !IsSuccess;
}
