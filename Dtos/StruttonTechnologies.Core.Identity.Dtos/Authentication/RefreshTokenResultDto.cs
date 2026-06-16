namespace StruttonTechnologies.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents the result of a refresh-token exchange.
/// </summary>
/// <param name="IsSuccess">Indicates whether the token refresh succeeded.</param>
/// <param name="AccessToken">The issued access token.</param>
/// <param name="RefreshToken">The issued refresh token.</param>
/// <param name="AccessTokenExpiresAtUtc">The UTC expiration timestamp for the access token.</param>
/// <param name="RefreshTokenExpiresAtUtc">The UTC expiration timestamp for the refresh token.</param>
/// <param name="FailureReason">The failure reason, when applicable.</param>
public sealed record RefreshTokenResultDto(
    bool IsSuccess,
    string AccessToken,
    string RefreshToken,
    DateTime? AccessTokenExpiresAtUtc = null,
    DateTime? RefreshTokenExpiresAtUtc = null,
    string? FailureReason = null)
{
    /// <summary>
    /// Creates a successful refresh-token result.
    /// </summary>
    public static RefreshTokenResultDto SuccessResult(
        string accessToken,
        string refreshToken,
        DateTime? accessTokenExpiresAtUtc = null,
        DateTime? refreshTokenExpiresAtUtc = null)
    {
        return new(true, accessToken, refreshToken, accessTokenExpiresAtUtc, refreshTokenExpiresAtUtc);
    }

    /// <summary>
    /// Creates a failed refresh-token result.
    /// </summary>
    public static RefreshTokenResultDto Failure(string reason)
    {
        return new(false, string.Empty, string.Empty, null, null, reason);
    }

    /// <summary>
    /// Gets a value indicating whether refresh-token exchange failed.
    /// </summary>
    public bool IsFailure => !IsSuccess;
}
