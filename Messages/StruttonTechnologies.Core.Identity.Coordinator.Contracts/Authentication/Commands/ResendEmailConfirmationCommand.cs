namespace StruttonTechnologies.Core.Identity.Coordinator.Contracts.Authentication.Commands;

/// <summary>
/// Command to resend an email-confirmation token.
/// </summary>
public sealed record ResendEmailConfirmationCommand(
    string Email)
    : IRequest<ResendEmailConfirmationResultDto>;
