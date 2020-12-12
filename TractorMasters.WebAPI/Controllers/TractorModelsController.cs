using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.Models.Error;
using TractorMasters.WebAPI.Models.TractorModels;
using TractorMasters.WebAPI.Services;

namespace TractorMasters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TractorModelsController : ControllerBase
    {

        private readonly ITractorModelsService _tractorModels;

        private readonly IGlobalService _global;


        public TractorModelsController(ITractorModelsService tractorModels, IGlobalService Global)
        {
            _tractorModels = tractorModels; ;
            _global = Global;
        }

        [HttpGet]
        //[Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_TractorModels([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _tractorModels.GetTractorModels(input.languagecode, customerCode);


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
