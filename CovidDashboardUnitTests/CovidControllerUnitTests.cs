using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CovidDashboard.Interfaces;
using CovidDashboard.Server.Controllers;
using CovidDashboard.Shared;
using Moq;
using Xunit;

namespace CovidDashboardUnitTests
{
    public class CovidControllerUnitTests
    {
        [Fact]
        public async void CovidControllerGetsUsStats()
        {
            Mock<ICovidService> iCovidService = new Moq.Mock<ICovidService>();
            iCovidService.Setup(s => s.GetCurrentUSStats()).Returns(Task.FromResult(new USStatus()));

            CovidController covidController = new CovidController(iCovidService.Object);

            USStatus usStatus = await covidController.GetCurrentUSStats();

            Assert.NotNull(usStatus);
        }

        [Fact]
        public async void CovidControllerGetTexasStats()
        {
            Mock<ICovidService> iCovidService = new Moq.Mock<ICovidService>();
            iCovidService.Setup(s => s.GetTexasDailyStats()).Returns(Task.FromResult(new List<DailyStatus>()));

            CovidController covidController = new CovidController(iCovidService.Object);

            var stats = await covidController.GetTexasDailyStats();

            Assert.NotNull(stats);
        }
    }
}
