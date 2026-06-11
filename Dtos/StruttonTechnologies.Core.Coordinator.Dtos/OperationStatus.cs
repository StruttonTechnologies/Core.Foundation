namespace StruttonTechnologies.Core.Coordinator.Dtos;

/// <summary>
/// Indicates the outcome of an operation in a generic and standardized way.
/// </summary>
public enum OperationStatus
{
    Success,
    Warning,
    ValidationFailed,
    NotFound,
    Error
}
