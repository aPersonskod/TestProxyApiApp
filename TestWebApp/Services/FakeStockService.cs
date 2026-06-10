using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Options;
using TestWebApp.Model;
using TestWebApp.Services.Interfaces;
using TestWebApp.Settings;

namespace TestWebApp.Services;

public class FakeStockService(IOptions<StockSettings> stockSettings) : IFakeStockService
{
    public async Task<PaginatedStocksDto?> GetStocks(GetStockParams stockParams)
    {
        using var client = new HttpClient();
        var base64Credentials =  Convert.ToBase64String(Encoding.UTF8.GetBytes($"{stockSettings.Value.Login}:{stockSettings.Value.Password}"));
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);
        var queryParams = stockParams.GetParams();
        var query = stockSettings.Value.BaseAddress + $"/v1/Stock{queryParams}";
        var response = await client.GetAsync(query);
        response.EnsureSuccessStatusCode();
        if (response.IsSuccessStatusCode) return await response.Content.ReadFromJsonAsync<PaginatedStocksDto>();
        throw new ArgumentNullException($"server error code {response.StatusCode}");
    }
}