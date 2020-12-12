using GeoMasters.WebAPI.Models.DistrictMaster;
using GeoMasters.WebAPI.Models.Error;
using GeoMasters.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictMasterController : ControllerBase
    {
        private readonly IDistrictMasterService _districtMaster;

        private readonly IGlobalService _global;


        public DistrictMasterController(IDistrictMasterService districtMaster, IGlobalService Global)
        {
            _districtMaster = districtMaster;
            _global = Global;
        }

        [HttpGet]
        //[Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_Districts([FromQuery] LanguageCode input, [FromQuery] StateCode stateCode)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _districtMaster.GetDistricts(input.languagecode, customerCode, stateCode);


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
