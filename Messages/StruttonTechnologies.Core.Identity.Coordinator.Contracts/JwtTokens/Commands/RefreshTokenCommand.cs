using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.JwtTokens.Commands;

/// <summary>
/// Command to refresh JWT tokens using a refresh token.
/// </summary>
[ExcludeFromCodeCoverage]
public sealed record RefreshTokenCommand(string RefreshToken) : IRequest<TokenResponseDto>;
