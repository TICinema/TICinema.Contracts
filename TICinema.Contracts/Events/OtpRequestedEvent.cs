namespace TICinema.Contracts.Events;

public class OtpRequestedEvent
{
    public string Identifier { get; init; } = string.Empty; // Телефон или Email
    public string Code { get; init; } = string.Empty;
    public string Type { get; set; } = string.Empty;
}