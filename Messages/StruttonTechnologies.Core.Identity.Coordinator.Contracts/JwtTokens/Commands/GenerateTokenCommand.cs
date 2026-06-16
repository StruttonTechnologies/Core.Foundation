namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.JwtTokens.Commands;

/// <summary>
/// Command to generate JWT access and refresh tokens for a user.
/// </summary>
public sealed record GenerateTokenCommand(
    string UserId)
    : IRequest<TokenResponseDto>;
