using System.Diagnostics.CodeAnalysis;

namespace StruttonTechnologies.Core.Dtos.Person;

[ExcludeFromCodeCoverage]
public class UpdatePersonDto
{
    public string Id { get; set; } = default!;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
}
