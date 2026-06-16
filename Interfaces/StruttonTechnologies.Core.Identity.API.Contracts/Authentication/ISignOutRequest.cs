namespace StruttonTechnologies.Core.Identity.API.Contracts.Authentication;

/// <summary>
/// Defines a request to sign out and revoke authentication tokens.
/// </summary>
public interface ISignOutRequest
{
    /// <summary>
    /// Gets the access token to revoke, when access-token revocation is enabled.
    /// </summary>
    public string? AccessToken { get; }

    /// <summary>
    /// Gets the refresh token to revoke.
    /// </summary>
    public string? RefreshToken { get; }

    /// <summary>
    /// Gets a value indicating whether all devices should be signed out.
    /// </summary>
    public bool SignOutAllDevices { get; }
}
