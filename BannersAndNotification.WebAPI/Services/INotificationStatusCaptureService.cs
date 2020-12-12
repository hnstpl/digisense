using BannersAndNotification.WebAPI.Models.NotificationCapture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BannersAndNotification.WebAPI.Services
{
   public interface INotificationStatusCaptureService
    {
        public int UpdateNoticicationStatus(NotificationCaptureList input, string customerCode);
    }
}
