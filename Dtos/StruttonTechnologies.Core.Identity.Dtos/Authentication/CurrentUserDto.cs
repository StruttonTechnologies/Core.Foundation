using StruttonTechnologies.Core.Identity.Dtos.Authorization;

namespace StruttonTechnologies.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents the current authenticated user's identity context.
/// </summary>
public sealed record CurrentUserDto(
    string UserId,
    string Email,
    string? UserName,
    string? DisplayName,
    IReadOnlyCollection<string> Roles,
    IReadOnlyCollection<ClaimDto> Claims);
