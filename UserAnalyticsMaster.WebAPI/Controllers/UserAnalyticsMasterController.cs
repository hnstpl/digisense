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
    public class UserAnalyticsMasterController : ControllerBase
    {
        private readonly IUserAnalyticsMasterService _userAnalyticsMaster;

        private readonly IGlobalService _global;


        public UserAnalyticsMasterController(IUserAnalyticsMasterService userAnalyticsMaster, IGlobalService Global)
        {
            _userAnalyticsMaster = userAnalyticsMaster;
            _global = Global;
        }

        [HttpGet("Get_UserAnalyticsMdules")]
        [Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_UserAnalyticsMdules()
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {

                mastersModel = _userAnalyticsMaster.GetUserAnalyticsMdules();


                return Ok(mastersModel); // Request.CreateResponse(HttpStatusCode.OK, masterModel);      
            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }
        }
    }
}
