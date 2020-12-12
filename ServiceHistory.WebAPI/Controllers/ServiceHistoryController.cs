using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using ServiceHistoryMaster.WebAPI.Models.ServiceHistory;
using ServiceHistoryMaster.WebAPI.Models.Error;
using ServiceHistoryMaster.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ServiceHistoryMaster.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceHistoryController : ControllerBase
    {

        private readonly IServiceHistoryService _ServiceHistory;

        private readonly IGlobalService _global;


        public ServiceHistoryController(IServiceHistoryService ServiceHistory, IGlobalService Global)
        {
            _ServiceHistory = ServiceHistory;
            _global = Global;
        }


        [HttpGet("Get_ServiceHistory")]
        [Authorize]
        public IActionResult Get_ServiceHistory()
        {

            ErrResponse err = new ErrResponse();

            try
            {
                ServiceHistoryList ServiceHistoryList = new ServiceHistoryList();
                DateTime? dob = null;
                ServiceHistoryList = _ServiceHistory.Get_ServiceHistory();
                return Ok(ServiceHistoryList);

            }
            catch(Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }

        }

    }
}
