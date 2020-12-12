using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.LanguageMaster;
using Masters.WebAPI.Models.Error;
using Masters.WebAPI.Services;
using Microsoft.Extensions.Configuration;

namespace Masters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageMasterController : ControllerBase
    {
        private readonly ILanguageMasterService _language;

        private readonly IGlobalService _global;

        private readonly IConfiguration _config;

        public LanguageMasterController (ILanguageMasterService Language, IGlobalService Global, IConfiguration Config)
        {
            _language = Language;
            _global = Global;
            _config = Config;
        }


        /// <summary>
        /// Returns the active Languages
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Get_Languages")]
        //[ResponseType(typeof(LanguageMasterList))]
        public IActionResult Get_Languages()
        {
            var err = new ErrResponse();
            try
            {
                //Get Module name from config to get the content version
                string moduleName = _config.GetValue<string>("Language:LanguageModule"); //ConfigurationManager.AppSettings["LanguageMaster"];

                List<LanguageMaster> languageResult = _language.GetAll().ToList();

                LanguageMasterList languageMasterList = new LanguageMasterList
                {
                    contentversion = _language.GetContentVerstion(moduleName),
                    languagemaster = languageResult,
                    totalrecords = languageResult.Count
                };

                return Ok(languageMasterList);

            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }
        }

    }
}
