using STSS.Core.Identity.Dtos.Users;

namespace STSS.Core.Identity.Coordinator.Contracts.Users.Queries;

public sealed record GetUserByIdQuery(string UserId)
    : IRequest<UserDetailResult>;
