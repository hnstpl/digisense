using ServiceHistoryMaster.WebAPI.Models.ServiceHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceHistoryMaster.WebAPI.DataProvider;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using ServiceHistoryMaster.WebAPI.Models.Error;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace ServiceHistoryMaster.WebAPI.Services
{
    public interface IServiceHistoryService
    {
        public ServiceHistoryList Get_ServiceHistory();
    }
}
