namespace StruttonTechnologies.Core.Coordinator.Contracts.PersonDispatch;

public interface IRequestPersonLinkRequest
{
    string UserId { get; }
    string PersonId { get; }
}
