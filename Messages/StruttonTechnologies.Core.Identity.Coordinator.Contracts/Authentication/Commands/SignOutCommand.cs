using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

[ExcludeFromCodeCoverage]
public class SignOutCommand : IRequest<SignOutResultDto>
{
    public string Token { get; }

    public SignOutCommand(string token)
    {
        Token = token;
    }
}
