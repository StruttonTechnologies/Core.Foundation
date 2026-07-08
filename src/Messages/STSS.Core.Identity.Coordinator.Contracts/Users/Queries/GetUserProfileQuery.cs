using STSS.Core.Identity.Dtos.Users;

namespace STSS.Core.Identity.Coordinator.Contracts.Users.Queries;

public class GetUserProfileQuery : IRequest<UserProfileResult>
{
    public string UserId { get; }

    public GetUserProfileQuery(string userId)
    {
        UserId = userId;
    }
}
