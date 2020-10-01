using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CovidDashboard.Interfaces;
using CovidDashboard.Shared;
using Newtonsoft.Json;

namespace CovidDashboard.Services
{
    public class CovidService : ICovidService
    {
        private const string CurrentUs = "https://api.covidtracking.com/v1/us/current.json";
        private HttpClient _httpClient;

        public CovidService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<USStatus> GetCurrentUSStats()
        {
            string json_data = await _httpClient.GetStringAsync(CurrentUs);

            List<USStatus> data = JsonConvert.DeserializeObject<List<USStatus>>(json_data);

            return data[0];
        }
    }
}