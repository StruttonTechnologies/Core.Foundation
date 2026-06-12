namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

public class AuthenticateUserCommand : IRequest<AuthenticationResultDto>
{
    public string Email { get; }
    public string Password { get; }

    public AuthenticateUserCommand(string email, string password)
    {
        Email = email;
        Password = password;
    }
}
