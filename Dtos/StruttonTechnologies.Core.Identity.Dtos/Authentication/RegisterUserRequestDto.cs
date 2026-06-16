namespace StruttonTechnologies.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents a request to register a new user.
/// </summary>
/// <param name="Email">The user's email address.</param>
/// <param name="Password">The user's password.</param>
/// <param name="DisplayName">The user's display name.</param>
public sealed record RegisterUserRequestDto(
    string Email,
    string Password,
    string DisplayName);
