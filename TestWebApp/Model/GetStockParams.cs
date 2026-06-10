namespace TestWebApp.Model;

public class GetStockParams
{
    public int Skip { get; set; } = 0;
    public int Take { get; set; } = 0;
    public string Expand { get; set; } = "";
    public string Filter { get; set; } = "";
    public string OrderBy { get; set; } = "";
    public string OrderDirection { get; set; } = "";
    private readonly List<string> _filters = new List<string>();

    public string GetParams()
    {
        var ps = "";
        if (Skip != 0) _filters.Add($"Skip={Skip}");
        if (Take != 0) _filters.Add($"Take={Take}");
        if (string.IsNullOrWhiteSpace(Expand)) _filters.Add($"Expand={Expand}");
        if (string.IsNullOrWhiteSpace(Filter)) _filters.Add($"Expand={Filter}");
        if (string.IsNullOrWhiteSpace(OrderBy)) _filters.Add($"Expand={OrderBy}");
        if (string.IsNullOrWhiteSpace(OrderDirection)) _filters.Add($"Expand={OrderDirection}");

        if (_filters.Any())
        {
            ps +="?" + string.Join("&", _filters);
        }

        return ps;
    }
}