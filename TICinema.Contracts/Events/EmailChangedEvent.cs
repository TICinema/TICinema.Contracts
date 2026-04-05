namespace TICinema.Contracts.Events;

public class EmailChangedEvent
{
    public string NewEmail { get; init; } = string.Empty;
    public string Code { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}