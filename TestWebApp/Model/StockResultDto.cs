using System.Text.Json.Serialization;

namespace TestWebApp.Model;

public class StockResultDto
{
    [JsonPropertyName("totalItems")]
    public int TotalItems { get; set; }
    [JsonPropertyName("items")]
    public IEnumerable<StockDto> Items { get; set; }
}