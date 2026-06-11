using StruttonTechnologies.Core.Dtos.Person;

namespace StruttonTechnologies.Core.Coordinator.Contracts.PersonDispatch;

/// <summary>
/// Query to find a person by their identity fields.
/// </summary>
public record FindByIdentityQuery(
    string FirstName,
    string LastName,
    string Email
) : IRequest<PersonDto?>;
