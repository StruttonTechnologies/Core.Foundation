namespace STSS.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to register a new user.
/// </summary>
public sealed record RegisterUserCommand(
    string Email,
    string Password,
    string DisplayName)
    : IRequest<RegistrationResultDto>;
