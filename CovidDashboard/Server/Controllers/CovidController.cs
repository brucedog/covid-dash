using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CovidDashboard.Interfaces;
using CovidDashboard.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidDashboard.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidController : ControllerBase
    {
        private ICovidService _covidService;

        public CovidController(ICovidService covidService)
        {
            _covidService = covidService;
        }


        [Route("[action]")]
        [HttpGet]
        public async Task<USStatus> GetCurrentUSStats()
        {
            try
            {
                var result = await _covidService.GetCurrentUSStats();
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return new USStatus();
        }

        [Route("[action]")]
        [HttpGet]
        public async Task<List<LineChartData>> GetTexasDailyStats()
        {
            try
            {
                var result = await _covidService.GetTexasDailyStats();
                List<LineChartData> chartData = new List<LineChartData>(result.Count);
                PropertyInfo propertyInfo = typeof(DailyStatus).GetProperty("Positive");

                return PopulateChartData(result, propertyInfo, chartData);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return  new List<LineChartData>();
        }
        

        [Route("[action]/{id?}")]
        [HttpGet]
        public async Task<List<LineChartData>> GetTexasDailyStat(string id)
        {
            try
            {
                var result = await _covidService.GetTexasDailyStats();

                List<LineChartData> chartData = new List<LineChartData>(result.Count);
                PropertyInfo propertyInfo = typeof(DailyStatus).GetProperty(id);

                return PopulateChartData(result, propertyInfo, chartData);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return new List<LineChartData>();
        }

        private List<LineChartData> PopulateChartData(List<DailyStatus> result, PropertyInfo propertyInfo, List<LineChartData> chartData)
        {
            foreach (DailyStatus dailyStatus in result)
            {
                int propValue = (int)propertyInfo.GetValue(dailyStatus, null);

                chartData.Add(new LineChartData
                {
                    Date = new DateTime(dailyStatus.DateChecked.Year, dailyStatus.DateChecked.Month,
                        dailyStatus.DateChecked.Day),
                    Value = propValue
                });
            }

            return chartData.OrderBy(o => o.Date).ToList();
        }
    }
}
