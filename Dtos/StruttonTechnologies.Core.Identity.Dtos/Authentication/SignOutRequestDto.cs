namespace StruttonTechnologies.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents a request to sign out and revoke active authentication tokens.
/// </summary>
/// <param name="AccessToken">The access token to revoke, when access-token revocation is enabled.</param>
/// <param name="RefreshToken">The refresh token to revoke.</param>
/// <param name="SignOutAllDevices">Indicates whether all refresh tokens for the user should be revoked.</param>
public sealed record SignOutRequestDto(
    string? AccessToken,
    string? RefreshToken,
    bool SignOutAllDevices = false);
