namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

public record AuthenticationCommand(string Email, string Password)
    : IRequest<TokenResponseDto>;
