namespace StruttonTechnologies.Core.Coordinator.Contracts.PersonDispatch;

public interface IConfirmPersonLinkRequest
{
    string UserId { get; }
    string PersonId { get; }
    string Token { get; }
}
