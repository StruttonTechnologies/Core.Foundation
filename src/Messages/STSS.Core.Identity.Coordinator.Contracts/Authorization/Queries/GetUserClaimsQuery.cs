using System.Security.Claims;

namespace STSS.Core.Identity.Coordinator.Contracts.Authorization.Queries;

public sealed record GetUserClaimsQuery(string UserId)
: IRequest<IList<Claim>>;
