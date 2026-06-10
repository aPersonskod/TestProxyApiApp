using Microsoft.AspNetCore.Mvc;
using TestWebApp.Model;
using TestWebApp.Services.Interfaces;

namespace TestWebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class FakeStockController(IFakeStockService fakeStockService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetFakeStock(
        [FromQuery] int skip = 0,
        [FromQuery] int take = 0,
        [FromQuery] string expand = "",
        [FromQuery] string filter = "",
        [FromQuery] string orderBy = "",
        [FromQuery] string orderDirection = "")
    {
        var stockParams = new GetStockParams()
        {
            Skip = skip,
            Take = take,
            Expand = expand,
            Filter = filter,
            OrderBy = orderBy,
            OrderDirection = orderDirection
        };
        return Ok(await fakeStockService.GetStocks(stockParams));
    }
}