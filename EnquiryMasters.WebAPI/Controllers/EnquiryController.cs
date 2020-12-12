using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using EnquiryMasters.WebAPI.Models.Enquiry;
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
    public class EnquiryController : ControllerBase
    {

        private readonly IEnquiryService _Enquiry;
        private readonly IGlobalService _global;

        public EnquiryController(IEnquiryService Enquiry, IGlobalService Global)
        {
            _Enquiry = Enquiry;
            _global = Global;
        }


        [HttpPost]
        [Authorize]
        //[ResponseType(typeof(ErrResponse))]
        public IActionResult Submit_Enquiry([FromBody] Enquiry input)

        {
            ErrResponse err = new ErrResponse();

            try
            {
                var result = _Enquiry.Submit_Enquiry(input);

                    if (result == "0")
                    {
                        err.Message = "Unable to submit the Enquiry";
                        return BadRequest(err);
                     }

                    err.Message = result;
                    return Ok(err);
               
            }
            catch(Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }
        }
    }
}
