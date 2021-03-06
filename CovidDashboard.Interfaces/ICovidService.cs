﻿using System.Collections.Generic;
using System.Threading.Tasks;
using CovidDashboard.Shared;

namespace CovidDashboard.Interfaces
{
    public interface ICovidService
    {
        /// <summary>
        /// Gets the return USA covid-19 stats
        /// </summary>
        Task<USStatus> GetCurrentUSStats();

        /// <summary>
        /// Gets the Texas daily stats
        /// </summary>
        Task<List<DailyStatus>> GetTexasDailyStats();
    }
}