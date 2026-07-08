namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to authenticate a user using email and password.
/// </summary>
public sealed record AuthenticateUserCommand(
    string Email,
    string Password)
    : IRequest<AuthenticationResultDto>;
