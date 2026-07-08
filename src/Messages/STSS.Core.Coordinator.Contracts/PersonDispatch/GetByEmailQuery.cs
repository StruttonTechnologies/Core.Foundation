using STSS.Core.Dtos.Person;

namespace STSS.Core.Coordinator.Contracts.PersonDispatch;

public record GetByEmailQuery(string Email) : IRequest<PersonDto?>;
