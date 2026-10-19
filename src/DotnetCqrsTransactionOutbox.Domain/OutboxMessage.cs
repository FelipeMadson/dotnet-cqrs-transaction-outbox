namespace DotnetCqrsTransactionOutbox.Domain;

public record OutboxMessage(
    Guid Id,
    string EventType,
    string Payload,
    DateTime OccurredOnUtc,
    DateTime? ProcessedOnUtc = null,
    string? Error = null
)
{
    public bool IsProcessed => ProcessedOnUtc.HasValue;
}
