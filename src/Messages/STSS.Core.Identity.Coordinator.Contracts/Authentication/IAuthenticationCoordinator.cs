namespace STSS.Core.Identity.Coordinator.Contracts.Authentication;

/// <summary>
/// Defines the authentication coordination contract for registration, sign-in, token refresh, and sign-out flows.
/// </summary>
public interface IAuthenticationCoordinator
{
    /// <summary>
    /// Registers a new user.
    /// </summary>
    public Task<RegistrationResultDto> RegisterAsync(
        string email,
        string password,
        string displayName,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Authenticates an existing user and returns an access-token and refresh-token pair.
    /// </summary>
    public Task<AuthenticationResultDto> AuthenticateAsync(
        string email,
        string password,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Refreshes an authentication token pair using a valid refresh token.
    /// </summary>
    public Task<RefreshTokenResultDto> RefreshTokenAsync(
        string refreshToken,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Signs the current user out by revoking the provided token values.
    /// </summary>
    public Task<SignOutResultDto> SignOutAsync(
        string? accessToken,
        string? refreshToken,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Signs a user out of all devices by revoking all active refresh tokens.
    /// </summary>
    public Task<SignOutResultDto> SignOutAllDevicesAsync(
        string userId,
        CancellationToken cancellationToken = default);
}
