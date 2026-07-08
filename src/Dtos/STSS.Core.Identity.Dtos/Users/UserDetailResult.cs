using STSS.Core.Identity.Dtos.Authorization;
using STSS.Core.Identity.Dtos.ExternalLogins;

namespace STSS.Core.Identity.Dtos.Users;

public record UserDetailResult(
    string UserId,
    string Email,
    bool EmailConfirmed,
    bool IsActive,
    IReadOnlyCollection<string> Roles,
    IReadOnlyCollection<ClaimDto> Claims,
    IReadOnlyCollection<ExternalLoginInfoDto> Logins
);
