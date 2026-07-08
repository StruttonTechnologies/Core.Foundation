namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to confirm a user's email address.
/// </summary>
public sealed record ConfirmEmailCommand(
    string UserId,
    string Token)
    : IRequest<ConfirmEmailResultDto>;
