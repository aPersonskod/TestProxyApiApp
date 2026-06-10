using System.Text.Json.Serialization;

namespace TestWebApp.Model;

public class PaginatedStocksDto
{
    [JsonPropertyName("result")]
    public StockResultDto StockResult { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; }
}