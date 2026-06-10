using System.Text.Json.Serialization;

namespace TestWebApp.Model;

public class StockDto
{
    [JsonPropertyName("code")]
    public string Code { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("manufacturer")]
    public string Manufacturer { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("price")]
    public string Price { get; set; }
    [JsonPropertyName("stock")]
    public int Stock { get; set; }
}