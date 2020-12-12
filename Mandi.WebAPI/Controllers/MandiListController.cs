using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mandi.WebAPI.Services;
using Mandi.WebAPI.Models.MandiModel;
using Mandi.WebAPI.Models.Error;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Mandi.WebAPI.DataProvider;

namespace Mandi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MandiListController : ControllerBase
    {
        private readonly IMandiService _mandi;

        private readonly IGlobalService _global;

        private readonly IConfiguration _config;

        public MandiListController(IMandiService Mandi, IGlobalService Global, IConfiguration Config)
        {
            _mandi = Mandi;
            _global = Global;
            _config = Config;
        }

        [HttpGet("Get_Mandi")]
        [Authorize]
        //[ResponseType(typeof(MandiList))]
        public IActionResult Get_Mandi([FromQuery] LanguageCode input, [FromQuery] MandiTypes mandiType)
        {

            ErrResponse err = new ErrResponse();

            try
            {
                //get customer code from token
                string customerCode = _global.GetCustomerCode("Token"); //Global.GetCustomerCode();

                //var customerModels = Global.GetCustomerModels();

                //Get Languages
                List<MstLanguage> languages = _global.GetLanguageListForCustomer(input.languagecode, customerCode).ToList(); //Global.GetLanguageList(input.languagecode, customerCode);

                    List<MandiList> mandilists = new List<MandiList>();

                    //Get Module name from config file to get the version
                    string moduleName = _config.GetValue<string>("Mandi:MandiModule");

                //Default Language
                var DefaultLanguage = Convert.ToInt32(_config.GetValue<string>("DefaultLanguage:ID")); //(ConfigurationManager.AppSettings["DefaultLanguageID"]);




                if (mandiType == MandiTypes.Specific)
                    {

                    var cropselection = _mandi.GetCropSelection(customerCode).ToList();

                    var mandiselection = _mandi.GetMandiSelection(customerCode).ToList();

                    foreach (var Language in languages)
                    {
                        //Get list of Mandi
                        List<MandiModel> mandi = _mandi.GetMandiDataByLanguage(Language, mandiselection, cropselection, DefaultLanguage).ToList();

                        mandi.ForEach(x =>
                        {
                            x.crops = _mandi.GetCropForMandi(Language, cropselection, x.mandid).ToList();
                        });

                        MandiList mandiList = new MandiList
                        {
                            contentversion = _mandi.GetContentVersion(moduleName),
                            languagecode = Language.LanguageCode,
                            mandilist = mandi,
                            totalrecords = mandi.Count
                        };

                        mandilists.Add(mandiList);
                    }

                }
                else
                {
                    foreach (var Language in languages)
                    {
                        //Get list of Mandi
                        List <MandiModel> mandi = _mandi.GetMandiDataByLanguage(Language, null, null, DefaultLanguage).ToList();

                        mandi.ForEach(x =>
                        {
                            x.crops = _mandi.GetCropForMandi(Language, null, x.mandid).ToList();

                        });

                        MandiList mandiList = new MandiList
                        {
                            contentversion = _mandi.GetContentVersion(moduleName),
                            languagecode = Language.LanguageCode,
                            mandilist = mandi,
                            totalrecords = mandi.Count
                        };

                        mandilists.Add(mandiList);
                    }

                }


                MastersModel masterModel = new MastersModel
                {
                    masters = mandilists
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
