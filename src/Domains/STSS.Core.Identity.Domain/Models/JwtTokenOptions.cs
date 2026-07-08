namespace STSS.Core.Identity.Domain.Models;

/// <summary>
/// Provides configuration settings for JWT access tokens and refresh tokens.
/// </summary>
public class JwtTokenOptions
{
    /// <summary>
    /// Gets or sets the signing key used to sign JWT access tokens.
    /// </summary>
    public string SigningKey { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the expected token issuer.
    /// </summary>
    public string Issuer { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the expected token audience.
    /// </summary>
    public string Audience { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the access-token lifetime in minutes.
    /// </summary>
    public int AccessTokenMinutes { get; set; } = 15;

    /// <summary>
    /// Gets or sets the refresh-token lifetime in days.
    /// </summary>
    public int RefreshTokenDays { get; set; } = 7;

    /// <summary>
    /// Gets or sets a value indicating whether access-token revocation checks are enabled.
    /// </summary>
    public bool EnableAccessTokenRevocation { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether refresh-token rotation is enabled.
    /// </summary>
    public bool EnableRefreshTokenRotation { get; set; } = true;

    /// <summary>
    /// Gets or sets the legacy access-token lifetime setting.
    /// </summary>
    /// <remarks>
    /// This property is retained for backwards compatibility. New code should use <see cref="AccessTokenMinutes" />.
    /// </remarks>
    public int ExpirationMinutes
    {
        get => AccessTokenMinutes;
        set => AccessTokenMinutes = value;
    }
}
