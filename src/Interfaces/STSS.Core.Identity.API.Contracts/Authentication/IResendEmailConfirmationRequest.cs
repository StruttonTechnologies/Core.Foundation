namespace STSS.Core.Identity.API.Contracts.Authentication;

/// <summary>
/// Defines a request to resend an email-confirmation token.
/// </summary>
public interface IResendEmailConfirmationRequest
{
    /// <summary>
    /// Gets the email address that should receive the confirmation token.
    /// </summary>
    public string Email { get; }
}
