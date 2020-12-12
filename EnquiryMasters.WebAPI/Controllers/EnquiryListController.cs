using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using EnquiryMasters.WebAPI.Models.EnquiryList;
using EnquiryMasters.WebAPI.Models.Error;
using EnquiryMasters.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;



namespace EnquiryMasters.WebAPI.Controllers
{
       [Route("api/[controller]")]
        [ApiController]
        public class EnquiryListController : ControllerBase
        {

        private readonly IEnquiryListService _EnquiryList;
        private readonly IGlobalService _global;
        ErrResponse err = new ErrResponse();
        private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);


        public EnquiryListController(IEnquiryListService EnquiryList, IGlobalService Global)
        {
            _EnquiryList = EnquiryList;
            _global = Global;
        }

        
        [HttpGet]
        [Authorize]
       // [ResponseType(typeof(MasterList))]
        public IActionResult Get_Enquiries([FromQuery] LanguageCode input, Boolean isSec, long? Offset = null)
        {

            ErrResponse err = new ErrResponse();
            MasterList enquiryList = new MasterList();
            DateTime? dob = null;
           
           try
            {
                try
                {
                    if (Offset != null)
                    {
                        dob = new DateTime(1970, 1, 1).Add(TimeSpan.FromSeconds((int)Convert.ToDouble(Offset)));
                        if ((Convert.ToDouble(Offset) != 0 && dob == new DateTime(1970, 1, 1)) || dob == DateTime.MinValue)
                        {
                            throw new Exception("Format error");
                        }
                    }
                }
                catch (Exception)
                {
                    err.Message = "Format error in date parameter";
                    return BadRequest(err);
                }

                enquiryList = _EnquiryList.Get_Enquiries(input.languagecode, isSec, Offset);
                return Ok(enquiryList);
            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }

        }

    }
}
