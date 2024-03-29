﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAnalyticsMaster.WebAPI.Models.UserAnalytics;

namespace UserAnalyticsMaster.WebAPI.Services
{
   public interface IUserAnalyticsService
    {
        public int CaptureUpdate(UserAnalyticsCapture input, string customerCode);
    }
}
