using System.Text.Json.Serialization;

namespace connect_utilities.Models;

public class ErrorViewModel
{
    [JsonPropertyName("requestId")]
    public string? RequestId { get; set; }
    [JsonPropertyName("showRequestId")]
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    [JsonPropertyName("status")]
    public int Status { get; set; }
}
