using BannersAndNotification.WebAPI.Models.Banners;
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
    public class BannersController : ControllerBase
    {
        private readonly IBannersService _banners;

        private readonly IGlobalService _global;


        public BannersController(IBannersService banners, IGlobalService Global)
        {
            _banners = banners;
            _global = Global;
        }

        [HttpGet]
        //[Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_Banners([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();
            HomePageModel homepageModel = new HomePageModel();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                homepageModel = _banners.GetBanners(input.languagecode, customerCode);


                return Ok(homepageModel); // Request.CreateResponse(HttpStatusCode.OK, masterModel);      
            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(e);
            }
        }
    }
}
