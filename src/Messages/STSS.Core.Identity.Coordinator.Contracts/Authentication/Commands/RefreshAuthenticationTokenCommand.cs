namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to refresh authentication tokens using a refresh token.
/// </summary>
public sealed record RefreshAuthenticationTokenCommand(
    string RefreshToken)
    : IRequest<RefreshTokenResultDto>;
