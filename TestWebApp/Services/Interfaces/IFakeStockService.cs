using TestWebApp.Model;

namespace TestWebApp.Services.Interfaces;

public interface IFakeStockService
{
    Task<PaginatedStocksDto?> GetStocks(GetStockParams stockParams);
}