namespace STSS.Core.Identity.Dtos.Authentication;

/// <summary>
/// Represents the result of a sign-out operation.
/// </summary>
/// <param name="Success">Indicates whether the sign-out operation succeeded.</param>
/// <param name="Message">A status message or failure reason.</param>
public sealed record SignOutResultDto(
    bool Success,
    string? Message = null)
{
    /// <summary>
    /// Creates a successful sign-out result.
    /// </summary>
    public static SignOutResultDto SuccessResult()
    {
        return new(true, "Token revoked successfully.");
    }

    /// <summary>
    /// Creates a failed sign-out result.
    /// </summary>
    public static SignOutResultDto Failure(string reason)
    {
        return new(false, reason);
    }
}
