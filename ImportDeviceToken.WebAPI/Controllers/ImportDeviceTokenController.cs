using ImportDeviceToken.WebAPI.Models.DeviceToken;
using ImportDeviceToken.WebAPI.Models.Error;
using ImportDeviceToken.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ImportDeviceToken.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportDeviceTokenController : ControllerBase
    {
        private readonly IImportDeviceTokenService _importDeviceToken;

        private readonly IGlobalService _global;


        public ImportDeviceTokenController(IImportDeviceTokenService importDeviceToken, IGlobalService Global)
        {
            _importDeviceToken = importDeviceToken;
            _global = Global;
        }

        [HttpPost("devicetoken")]
        [Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult devicetoken(DeviceToken input)
        {

            ErrResponse err = new ErrResponse();
            int Result = 0;

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();
                string deviceID = ClaimsPrincipal.Current.Identities.First().Claims.FirstOrDefault(x => x.Type.Contains("sid")).Value;

                Result = _importDeviceToken.devicetoken(input, customerCode, deviceID);


                err.Message = "Device Registered Succes";
                return Ok(err); // Request.CreateResponse(HttpStatusCode.OK, masterModel);      
            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }
        }
    }
}
