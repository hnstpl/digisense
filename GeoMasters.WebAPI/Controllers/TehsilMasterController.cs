using GeoMasters.WebAPI.Models.Error;
using GeoMasters.WebAPI.Models.TehsilMaster;
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
    public class TehsilMasterController : ControllerBase
    {
        private readonly ITehsilMasterService _tehsilMaster;

        private readonly IGlobalService _global;


        public TehsilMasterController(ITehsilMasterService tehsilMaster, IGlobalService Global)
        {
            _tehsilMaster = tehsilMaster;
            _global = Global;
        }

        [HttpGet]
        //[Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_Tehsils([FromQuery] LanguageCode input, [FromQuery] DistrictCode districtCode)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _tehsilMaster.GetTehsils(input.languagecode, customerCode, districtCode);


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
