using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BannersAndNotification.WebAPI.Models.NotificationCapture
{
    public class NotificationCaptureList
    {
        [Required]
        public List<NotificationCapture> notificationreadlist { get; set; }
    }

    public class NotificationCapture
    {
        [Required]
        public int notificationid { get; set; }
        [Required]
        public double readdatetime { get; set; }
    }
}
