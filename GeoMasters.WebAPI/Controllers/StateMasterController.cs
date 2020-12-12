using GeoMasters.WebAPI.Models.StateMaster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeoMasters.WebAPI.Services;
using GeoMasters.WebAPI.Models.Error;

namespace GeoMasters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateMasterController : ControllerBase
    {
        private readonly IStateMasterService _stateMaster;

        private readonly IGlobalService _global;


        public StateMasterController(IStateMasterService stateMaster, IGlobalService Global)
        {
            _stateMaster = stateMaster;
            _global = Global;
        }

        [HttpGet]
        //[Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_States([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _stateMaster.GetStates(input.languagecode, customerCode);


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
