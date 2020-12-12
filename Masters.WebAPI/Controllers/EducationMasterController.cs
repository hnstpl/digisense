using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.EducationMaster;
using Masters.WebAPI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Masters.WebAPI.Models.Error;

namespace Masters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationMasterController : ControllerBase
    {

        private readonly IEducationService _education;

        private readonly IGlobalService _global;

        private readonly IConfiguration _config;

        public EducationMasterController(IEducationService Education, IGlobalService Global, IConfiguration Config)
        {
            _education = Education;
            _global = Global;
            _config = Config;
        }

        /// <summary>
        /// Returns Education list (with or without language filter)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("Get_EducationList")]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_EducationList([FromQuery] LanguageCode input)
        {

            ErrResponse err = new ErrResponse();

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();

                //Get Module name from config file to get the version
                string moduleName = _config.GetValue<string>("DIY:DIYModule");

                //Get Languages
                List<MstLanguage> languages = _global.GetLanguageListForCustomer(input.languagecode, customerCode).ToList();

                List<EducationMaster> masterList = new List<EducationMaster>();

                foreach (var Language in languages)
                {
                    var master = _education.GetDataByLanguageID(Language, moduleName);

                    //Update the count
                    master.educationlist.totalrecords = master.educationlist.education.Count;

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
