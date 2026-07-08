namespace STSS.Core.Repositories.Contracts.Base;

public interface IAuditContext
{
    Guid CurrentUserId { get; }
    string? CurrentUserName { get; }
    string? CurrentUserEmail { get; }

    object? CurrentUser { get; }
}
