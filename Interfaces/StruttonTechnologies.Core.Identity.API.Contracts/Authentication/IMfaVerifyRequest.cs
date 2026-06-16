namespace StruttonTechnologies.Core.Identity.API.Contracts.Authentication;

/// <summary>
/// Defines a request to verify a multi-factor authentication code.
/// </summary>
public interface IMfaVerifyRequest
{
    /// <summary>
    /// Gets the multi-factor authentication code.
    /// </summary>
    public string Code { get; }
}
