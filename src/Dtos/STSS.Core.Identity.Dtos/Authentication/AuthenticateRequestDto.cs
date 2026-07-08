namespace STSS.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents a password authentication request.
/// </summary>
/// <param name="Email">The email address or login identifier for the user.</param>
/// <param name="Password">The user's password.</param>
public sealed record AuthenticateRequestDto(
    string Email,
    string Password);
