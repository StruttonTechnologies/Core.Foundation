using StruttonTechnologies.Core.Coordinator.Contracts.Models;
using StruttonTechnologies.Core.Dtos.Person;

namespace StruttonTechnologies.Core.Coordinator.Contracts.PersonDispatch;

public record CreatePersonCommand(PersonDto Payload) : IRequest<TaskResult<PersonDto>>;
