using Xunit;
using DotnetCqrsTransactionOutbox.Domain;

namespace DotnetCqrsTransactionOutbox.UnitTests;

public class OutboxTests
{
    [Fact]
    public void UnprocessedMessage_HasCorrectDefaultState()
    {
        var id = Guid.NewGuid();
        var msg = new OutboxMessage(id, "OrderPlaced", "{}", DateTime.UtcNow);

        Assert.Equal(id, msg.Id);
        Assert.False(msg.IsProcessed);
        Assert.Null(msg.ProcessedOnUtc);
        Assert.Null(msg.Error);
    }

    [Fact]
    public void ProcessedMessage_SetsIsProcessedToTrue()
    {
        var now = DateTime.UtcNow;
        var msg = new OutboxMessage(Guid.NewGuid(), "OrderPlaced", "{}", now.AddMinutes(-1), now);

        Assert.True(msg.IsProcessed);
        Assert.NotNull(msg.ProcessedOnUtc);
    }
}
