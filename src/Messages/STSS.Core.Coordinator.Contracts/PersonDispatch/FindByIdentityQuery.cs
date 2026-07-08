using STSS.Core.Dtos.Person;

namespace STSS.Core.Coordinator.Contracts.PersonDispatch;

/// <summary>
/// Query to find a person by their identity fields.
/// </summary>
public record FindByIdentityQuery(
    string FirstName,
    string LastName,
    string Email
) : IRequest<PersonDto?>;
