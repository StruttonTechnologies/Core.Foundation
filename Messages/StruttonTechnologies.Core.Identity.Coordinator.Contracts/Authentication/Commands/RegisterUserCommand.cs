using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

[ExcludeFromCodeCoverage]
public class RegisterUserCommand : IRequest<RegistrationResultDto>
{
    public string Email { get; }
    public string Password { get; }
    public string DisplayName { get; }

    public RegisterUserCommand(string email, string password, string displayName)
    {
        Email = email;
        Password = password;
        DisplayName = displayName;
    }
}
