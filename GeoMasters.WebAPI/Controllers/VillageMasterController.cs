using GeoMasters.WebAPI.Models.Error;
using GeoMasters.WebAPI.Models.VillageMaster;
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
    public class VillageMasterController : ControllerBase
    {
        private readonly IVillageMasterService _villageMaster;

        private readonly IGlobalService _global;


        public VillageMasterController(IVillageMasterService villageMaster, IGlobalService Global)
        {
            _villageMaster = villageMaster;
            _global = Global;
        }

        [HttpGet]
        //[Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_Villages([FromQuery] LanguageCode input, [FromQuery] TehsilCode tehsilcode)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _villageMaster.GetVillages(input.languagecode, customerCode, tehsilcode);


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
