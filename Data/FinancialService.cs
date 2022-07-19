using System.Net.Http.Json;

namespace UntitledApp.Financial
{
    public class FinancialService
    {
        private readonly HttpClient http;

        public FinancialService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<BoxOfficeRevenueType[]?> GetBoxOfficeRevenue()
        {
            return await http.GetFromJsonAsync<BoxOfficeRevenueType[]?>("static-data/financial-box-office-revenue.json");
        }
    }
}