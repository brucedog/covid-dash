using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
