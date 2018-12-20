﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Geek.AbpGeek.MultiTenancy.HostDashboard.Dto;

namespace Geek.AbpGeek.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}