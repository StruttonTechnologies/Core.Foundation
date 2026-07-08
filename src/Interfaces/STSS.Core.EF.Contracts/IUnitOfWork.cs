namespace STSS.Core.EF.Contracts;

/// <summary>
/// Defines a unit of work for coordinating persistence commits.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Commits all staged changes as a single atomic operation.
    /// </summary>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous commit operation.</returns>
    Task CommitAsync(CancellationToken cancellationToken = default);
}