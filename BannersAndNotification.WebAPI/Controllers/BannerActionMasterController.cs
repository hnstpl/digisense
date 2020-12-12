using BannersAndNotification.WebAPI.Models.BannerActionMaster;
using BannersAndNotification.WebAPI.Models.Error;
using BannersAndNotification.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BannersAndNotification.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerActionMasterController : ControllerBase
    {
        private readonly IBannerActionMasterService _actionMasterService;

        private readonly IGlobalService _global;


        public BannerActionMasterController(IBannerActionMasterService actionMasterService, IGlobalService Global)
        {
            _actionMasterService = actionMasterService;
            _global = Global;
        }

        [HttpGet]
        //[Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_BannerActionTypes([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();
            MastersModel mastersModel = new MastersModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                mastersModel = _actionMasterService.GetBannerActionTypes(input.languagecode, customerCode);


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
