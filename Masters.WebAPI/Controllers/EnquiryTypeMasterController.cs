using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.EnquiryTypeMaster;
using Microsoft.Extensions.Configuration;
using Masters.WebAPI.Services;
using Masters.WebAPI.Models.Error;
using Microsoft.AspNetCore.Authorization;

namespace Masters.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnquiryTypeMasterController : ControllerBase
    {
        private readonly IEnquiryTypeMasterService _enquiryType;

        private readonly IGlobalService _global;

        private readonly IConfiguration _config;


        public EnquiryTypeMasterController(IEnquiryTypeMasterService EnquiryType, IGlobalService Global, IConfiguration Config)
        {
            _enquiryType = EnquiryType;
            _global = Global;
            _config = Config;
        }


        ErrResponse err = new ErrResponse();

        [HttpGet]
        [Authorize]
        [Route("Get_EnquiryTypes")]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult Get_EnquiryTypes([FromQuery] LanguageCode input)
        {
            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode(); //Global.GetCustomerCode();

                //Get Module name from config to get the content version
                string moduleName = _config.GetValue<string>("Enquiry:EnquiryTypeModule");

                //Get Languages
                List<MstLanguage> languages = _global.GetLanguageListForCustomer(input.languagecode, customerCode).ToList();

                List<EnquiryTypes> masterList = new List<EnquiryTypes>();
                foreach (var Language in languages)
                {
                    EnquiryTypes EnquiryTypeRecords = _enquiryType.GetByLanguage(Language, moduleName);

                    EnquiryTypeRecords.totalrecords = EnquiryTypeRecords.enquirytypelist.Count;

                    masterList.Add(EnquiryTypeRecords);
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
