namespace STSS.Core.Coordinator.Contracts.PersonDispatch;

public record EmailExistsQuery(string Email) : IRequest<bool>;
