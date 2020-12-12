using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.CropsMaster;
using Masters.WebAPI.Models.Error;
using Masters.WebAPI.Services;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Masters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropsMasterController : ControllerBase
    {
        private readonly ICropsService _crops;

        private readonly IGlobalService _global;

        private readonly IConfiguration _config;

        public CropsMasterController(ICropsService Crops, IGlobalService Global, IConfiguration Config)
        {
            _crops = Crops;
            _global = Global;
            _config = Config;
        }


        /// <summary>
        /// Returns all Crops Data (with or without language filter)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("Get_Crops")]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_Crops([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();

            try
            {
                var Token = HttpContext.Request.Headers.First(x => x.Key == "Authorization");

                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                //Get Module name from config to get the content version
                string moduleName = _config.GetValue<string>("Crops:CropsModule");

                //Get Languages
                List<MstLanguage> languages = _global.GetLanguageListForCustomer(input.languagecode, customerCode).ToList();


                List<Masters.WebAPI.Models.CropsMaster.CropsMaster> masterList = new List<Masters.WebAPI.Models.CropsMaster.CropsMaster>();

                foreach (var Language in languages)
                {
                    var master = _crops.GetCropDataByLanguage(Language, moduleName);

                    //Update the count
                    master.cropslist.totalrecords = master.cropslist.crops.Count;

                    masterList.Add(master);
                }

                MastersModel masterModel = new MastersModel
                {
                    masters = masterList
                };

                //return Request.CreateResponse(HttpStatusCode.OK, masterModel);
                return Ok(masterModel);
            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }
        }



    }
}
