using System.Collections.Generic;
using System.Linq;
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
        private const string DailyTexasStat = "https://api.covidtracking.com/v1/states/tx/daily.json";
        private HttpClient _httpClient;
        private List<DailyStatus> texas_data;

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

        public async Task<List<DailyStatus>> GetTexasDailyStats()
        {
            if (texas_data != null)
                return texas_data;

            string json_data = await _httpClient.GetStringAsync(DailyTexasStat);

            texas_data = JsonConvert.DeserializeObject<List<DailyStatus>>(json_data);

            texas_data = texas_data.Where(w => w.CheckTimeEt != null && w.DateChecked.Year > 2018).ToList();
            return texas_data;
        }
    }
}