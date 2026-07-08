using Microsoft.AspNetCore.Identity;

namespace STSS.Core.Identity.Coordinator.Contracts.Users.Queries;

/// <summary>
/// Query to retrieve all external login providers linked to a user.
/// </summary>
public sealed record GetUserLoginsQuery(string UserId) : IRequest<IList<UserLoginInfo>>;
