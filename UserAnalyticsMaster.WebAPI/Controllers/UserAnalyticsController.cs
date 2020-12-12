using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAnalyticsMaster.WebAPI.Models.Error;
using UserAnalyticsMaster.WebAPI.Models.UserAnalytics;
using UserAnalyticsMaster.WebAPI.Services;

namespace UserAnalyticsMaster.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAnalyticsController : ControllerBase
    {
        private readonly IUserAnalyticsService  _userAnalytics;

        private readonly IGlobalService _global;


        public UserAnalyticsController(IUserAnalyticsService userAnalytics, IGlobalService Global)
        {
            _userAnalytics = userAnalytics;
            _global = Global;
        }

        [HttpPost("Capture")]
        [Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Capture(UserAnalyticsCapture input)
        {
            int Result = 0;
            ErrResponse err = new ErrResponse();
          
            try
            {
                if (input == null)
                {
                    throw new ArgumentException("Input Parameters missing");
                }

                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                Result = _userAnalytics.CaptureUpdate(input,customerCode);

             

                if (Result > 0)
                {
                    err.Message = "Successfully updated!";                    
                    return Ok(err);
                }
                else
                {
                    throw new InvalidOperationException("Error while updating information");
                }
                
            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }
        }
    }
}
