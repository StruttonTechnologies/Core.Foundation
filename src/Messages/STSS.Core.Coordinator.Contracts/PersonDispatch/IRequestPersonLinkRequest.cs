namespace STSS.Core.Coordinator.Contracts.PersonDispatch;

public interface IRequestPersonLinkRequest
{
    string UserId { get; }
    string PersonId { get; }
}
