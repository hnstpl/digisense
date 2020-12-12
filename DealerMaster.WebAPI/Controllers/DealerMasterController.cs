using DealerMaster.WebAPI.Models.Dealers;
using DealerMaster.WebAPI.Models.Error;
using DealerMaster.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerMaster.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerMasterController : ControllerBase
    {

        private readonly IDealerMasterService _dealerMaster;

        private readonly IGlobalService _global;


        public DealerMasterController(IDealerMasterService dealerMaster, IGlobalService Global)
        {
            _dealerMaster = dealerMaster;
            _global = Global;
        }

        [HttpGet]
        //[Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_Dealers([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _dealerMaster.GetDealers(input.languagecode, customerCode);


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