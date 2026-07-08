using STSS.Core.Coordinator.Contracts.Models;
using STSS.Core.Dtos.Person;

namespace STSS.Core.Coordinator.Contracts.PersonDispatch;

public record CreatePersonCommand(PersonDto Payload) : IRequest<TaskResult<PersonDto>>;
