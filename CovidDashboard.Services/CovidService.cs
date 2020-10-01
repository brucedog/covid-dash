using System.Threading.Tasks;
using CovidDashboard.Interfaces;
using CovidDashboard.Shared;

namespace CovidDashboard.Services
{
    public class CovidService : ICovidService
    {
        private const string CurrentUs = "https://api.covidtracking.com/v1/us/current.json";
        public Task<USStatus> GetCurrentUSStats()
        {
            throw new System.NotImplementedException();
        }
    }
}