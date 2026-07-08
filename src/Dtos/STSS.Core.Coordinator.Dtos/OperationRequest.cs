namespace STSS.Core.Coordinator.Dtos;

public class OperationRequest<TDto>
{
    public TDto Payload { get; set; } = default!;
    public string? CorrelationId { get; set; }
    public string? RequestedBy { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    public IDictionary<string, string>? Metadata { get; set; }
}
