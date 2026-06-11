using System.ComponentModel.DataAnnotations;

namespace StruttonTechnologies.Core.Coordinator.Dtos;

public class OperationResult<TDto>
{
    public OperationStatus Status { get; set; } = OperationStatus.Success;
    public string? Message { get; set; }
    public TDto? Result { get; set; }
    public IList<ValidationResult>? ValidationErrors { get; set; }
    public IDictionary<string, string> Metadata { get; set; } = new Dictionary<string, string>();
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
