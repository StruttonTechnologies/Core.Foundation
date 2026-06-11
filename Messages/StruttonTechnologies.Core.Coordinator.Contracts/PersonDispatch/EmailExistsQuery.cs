namespace StruttonTechnologies.Core.Coordinator.Contracts.PersonDispatch;

public record EmailExistsQuery(string Email) : IRequest<bool>;
