using BannersAndNotification.WebAPI.Models.Error;
using BannersAndNotification.WebAPI.Models.NotificationCapture;
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
    public class NotificationStatusCaptureController : ControllerBase
    {
        private readonly INotificationStatusCaptureService _notificationStatusCapture;

        private readonly IGlobalService _global;


        public NotificationStatusCaptureController(INotificationStatusCaptureService notificationStatusCapture, IGlobalService Global)
        {
            _notificationStatusCapture = notificationStatusCapture;
            _global = Global;
        }

        [HttpGet]
        //[Authorize]
        //[ResponseType(typeof(MastersModel))]
        public IActionResult UpdateNoticication([FromBody] NotificationCaptureList input)
        {

            ErrResponse err = new ErrResponse();
            int Result = 0;
          

            try
            {
                //Get Customer code from token
                string customerCode = _global.GetCustomerCode();
                if (input.notificationreadlist != null && input.notificationreadlist.Count > 0)
                {

                    Result = _notificationStatusCapture.UpdateNoticicationStatus(input, customerCode);

                    if (Result > 0)
                    {
                        err.Message = "Status updated successfully!";
                        return Ok(err);
                    }
                    else
                    {
                        err.Message = "Something went wrong!";
                        return Ok(err);
                    }
                }
                else
                {
                    err.Message = "Input request body is empty";
                    return BadRequest(err);
                }
                
            }
            catch (Exception e)
            {
                err.Message = e.Message;
                return BadRequest(err);
            }
        }
    }
}
