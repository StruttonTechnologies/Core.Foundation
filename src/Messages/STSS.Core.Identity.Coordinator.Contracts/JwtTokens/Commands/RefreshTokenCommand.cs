namespace STSS.Core.Identity.Coordinator.Contracts.JwtTokens.Commands;

/// <summary>
/// Command to refresh JWT tokens using a refresh token.
/// </summary>
public sealed record RefreshTokenCommand(
    string RefreshToken)
    : IRequest<RefreshTokenResultDto>;
