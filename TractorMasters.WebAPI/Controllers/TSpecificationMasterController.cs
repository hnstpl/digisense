using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.Models.Error;
using TractorMasters.WebAPI.Services;
using TractorMasters.WebAPI.Models.TSpecificationMaster;

namespace TractorMasters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TSpecificationMasterController : ControllerBase
    {

        private readonly ITSpecificationMasterService _tSpecificationMaster;

        private readonly IGlobalService _global;


        public TSpecificationMasterController(ITSpecificationMasterService tSpecificationMaster, IGlobalService Global)
        {
            _tSpecificationMaster = tSpecificationMaster;
            _global = Global;
        }


        [HttpGet]
      
        public IActionResult Get_TractorSpecification([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _tSpecificationMaster.GetTractorSpecification(input.languagecode, customerCode);


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
