namespace StruttonTechnologies.Core.Coordinator.Contracts.Models;

/// <summary>
/// Represents the outcome of a MediatR handler task (command/query).
/// Distinct from ValidationResult, which is for input validation only.
/// </summary>
public sealed class TaskResult<T>
{
    /// <summary>
    /// Indicates whether the task succeeded.
    /// </summary>
    public bool Success { get; }

    /// <summary>
    /// Optional message describing the outcome.
    /// </summary>
    public string? Message { get; }

    /// <summary>
    /// Optional code for categorizing the outcome (e.g., NotFound, Error).
    /// </summary>
    public string? Code { get; }

    /// <summary>
    /// The data payload returned by the handler (usually a DTO).
    /// </summary>
    public T? Data { get; }

    /// <summary>
    /// Exception details if the task failed due to an error.
    /// </summary>
    public Exception? Exception { get; }

    private TaskResult(
        bool success,
        T? data = default,
        string? message = null,
        string? code = null,
        Exception? exception = null)
    {
        Success = success;
        Data = data;
        Message = message;
        Code = code;
        Exception = exception;
    }

    /// <summary>
    /// Success result with data.
    /// </summary>
    public static TaskResult<T> Ok(T data, string? message = null) =>
        new TaskResult<T>(true, data, message);

    /// <summary>
    /// Not found result.
    /// </summary>
    public static TaskResult<T> NotFound(string? message = null) =>
        new TaskResult<T>(false, default, message, "NotFound");

    /// <summary>
    /// Error result.
    /// </summary>
    public static TaskResult<T> Error(string message, string? code = null, Exception? exception = null) =>
        new TaskResult<T>(false, default, message, code ?? "Error", exception);

}
