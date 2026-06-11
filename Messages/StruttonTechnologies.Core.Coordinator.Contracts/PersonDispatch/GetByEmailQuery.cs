using StruttonTechnologies.Core.Dtos.Person;

namespace StruttonTechnologies.Core.Coordinator.Contracts.PersonDispatch;

public record GetByEmailQuery(string Email) : IRequest<PersonDto?>;
