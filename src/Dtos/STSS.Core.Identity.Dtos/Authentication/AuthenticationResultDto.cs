namespace STSS.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents the result of an authentication attempt.
/// </summary>
/// <param name="IsSuccess">Indicates whether authentication succeeded.</param>
/// <param name="AccessToken">The generated JWT access token.</param>
/// <param name="RefreshToken">The generated refresh token.</param>
/// <param name="AccessTokenExpiresAtUtc">The UTC expiration timestamp for the access token.</param>
/// <param name="RefreshTokenExpiresAtUtc">The UTC expiration timestamp for the refresh token.</param>
/// <param name="FailureReason">The reason authentication failed, when applicable.</param>
public sealed record AuthenticationResultDto(
    bool IsSuccess,
    string AccessToken,
    string RefreshToken,
    DateTime? AccessTokenExpiresAtUtc = null,
    DateTime? RefreshTokenExpiresAtUtc = null,
    string? FailureReason = null)
{
    /// <summary>
    /// Creates a successful authentication result.
    /// </summary>
    /// <param name="accessToken">The generated JWT access token.</param>
    /// <param name="refreshToken">The generated refresh token.</param>
    /// <param name="accessTokenExpiresAtUtc">The UTC expiration timestamp for the access token.</param>
    /// <param name="refreshTokenExpiresAtUtc">The UTC expiration timestamp for the refresh token.</param>
    /// <returns>A successful authentication result.</returns>
    public static AuthenticationResultDto SuccessResult(
        string accessToken,
        string refreshToken,
        DateTime? accessTokenExpiresAtUtc = null,
        DateTime? refreshTokenExpiresAtUtc = null)
    {
        return new(true, accessToken, refreshToken, accessTokenExpiresAtUtc, refreshTokenExpiresAtUtc);
    }

    /// <summary>
    /// Creates a failed authentication result.
    /// </summary>
    /// <param name="reason">The failure reason.</param>
    /// <returns>A failed authentication result.</returns>
    public static AuthenticationResultDto Failure(string reason)
    {
        return new(false, string.Empty, string.Empty, null, null, reason);
    }

    /// <summary>
    /// Gets a value indicating whether authentication failed.
    /// </summary>
    public bool IsFailure => !IsSuccess;
}
