using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImplementMasters.WebAPI.Services;
using ImplementMasters.WebAPI.Models.ImplementModels;
using ImplementMasters.WebAPI.Models.Error;
using Microsoft.AspNetCore.Authorization;

namespace ImplementMasters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImplementModelsController : ControllerBase
    {
        private readonly IImplementModelsService _implementModels;

        private readonly IGlobalService _global;


        public ImplementModelsController(IImplementModelsService implementModels, IGlobalService Global)
        {
            _implementModels = implementModels;
            _global = Global;
        }

        [HttpGet("Get_TractorModels")]
        [Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_TractorModels([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _implementModels.GetImplementModels(input.languagecode, customerCode);


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
