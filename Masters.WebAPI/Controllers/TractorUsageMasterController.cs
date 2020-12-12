using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.Error;
using Masters.WebAPI.Services;
using Masters.WebAPI.Models.TractorUsageMaster;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace Masters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TractorUsageMasterController : ControllerBase
    {
        private readonly ITractorUsageMasterService _tractorUsage;

        private readonly IConfiguration _config;

        private readonly IGlobalService _global;

        public TractorUsageMasterController(ITractorUsageMasterService TractorUsage, IConfiguration Config, IGlobalService Global)
        {
            _tractorUsage = TractorUsage;
            _config = Config;
            _global = Global;
        }


        /// <summary>
        /// Returns Tractor usage list (with or without language filter)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("Get_TractorUsageList")]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_TractorUsageList([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode(); //Global.GetCustomerCode();

                //Get Module name from config to get the content version
                string moduleName = _config.GetValue<string>("TractorUsage:TractorUsageModule"); //ConfigurationManager.AppSettings["TractorUsageMaster"];

                //Get Languages
                List<MstLanguage> languages = _global.GetLanguageListForCustomer(input.languagecode, customerCode).ToList();

                List<TractorUsageMaster> masterList = new List<TractorUsageMaster>();

                foreach (var Language in languages)
                {
                    TractorUsageMaster master = _tractorUsage.GetByLanguage(Language, moduleName);

                    //Update the count
                    master.tractorusagelist.totalrecords = master.tractorusagelist.tractorusage.Count;

                    masterList.Add(master);
                }

                MastersModel masterModel = new MastersModel
                {
                    masters = masterList
                };

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
