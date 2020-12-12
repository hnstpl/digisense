using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.Models.Error;
using TractorMasters.WebAPI.Models.TSpecificationCategoryMaster;
using TractorMasters.WebAPI.Services;

namespace TractorMasters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TSpecificationCategoryMasterController : ControllerBase
    {

        private readonly ITSpecificationCategoryMasterService _tSpecificationCategory;

        private readonly IGlobalService _global;


        public TSpecificationCategoryMasterController(ITSpecificationCategoryMasterService tSpecificationCategory, IGlobalService Global)
        {
            _tSpecificationCategory = tSpecificationCategory;
            _global = Global;
        }


        [HttpGet]

        public IActionResult Get_TractorSpecificationCategory([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _tSpecificationCategory.GetTractorSpecificationCategory(input.languagecode, customerCode);


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
