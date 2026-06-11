using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Dtos.Person;

[ExcludeFromCodeCoverage]
public class PersonIdentityDto
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
}
