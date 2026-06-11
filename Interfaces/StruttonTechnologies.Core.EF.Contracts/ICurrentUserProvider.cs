namespace StruttonTechnologies.Core.EF.Contracts;

/// <summary>
/// Default current user provider using Guid identifiers.
/// </summary>
public interface ICurrentUserProvider : ICurrentUserProvider<Guid>
{
}

/// <summary>
/// Provides access to the current authenticated user identifier
/// for auditing and persistence operations.
/// </summary>
/// <typeparam name="TKey">
/// The key type used by the application for entity and identity identifiers.
/// </typeparam>
public interface ICurrentUserProvider<TKey>
    where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Gets the identifier of the current authenticated user.
    /// </summary>
    /// <returns>
    /// The current user identifier if available; otherwise, the default value for <typeparamref name="TKey"/>.
    /// </returns>
    TKey? GetCurrentUserId();
}