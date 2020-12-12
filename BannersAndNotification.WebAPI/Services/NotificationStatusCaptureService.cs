using BannersAndNotification.WebAPI.DataProvider;
using BannersAndNotification.WebAPI.Models.NotificationCapture;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BannersAndNotification.WebAPI.Services
{
    public class NotificationStatusCaptureService:INotificationStatusCaptureService
    {
        private readonly dev_encrypted_generalcustomerappContext _context;



        private readonly IConfiguration _config;
        private readonly IGlobalService _global;

        string moduleName = "";
        public NotificationStatusCaptureService(dev_encrypted_generalcustomerappContext dataContext, IConfiguration config, IGlobalService Global)
        {
            _context = dataContext;
            _config = config;
            _global = Global;

            //Get Module name from config to get the content version
            moduleName = _config.GetValue<string>("GeoMasters:DistrictMaster");
        }

        public int UpdateNoticicationStatus(NotificationCaptureList input, string customerCode)
        {


            
            //Get Languages

            foreach (var Itm in input.notificationreadlist)
            {
                var dt = new DateTime(1970, 1, 1).Add(TimeSpan.FromSeconds((int)Itm.readdatetime));
                //new DateTime((int)Global.epoch.Ticks + (int)Itm.readdatetime, System.DateTimeKind.Utc);


                var NotificationRecord = (from p in _context.TblNotificationTracker
                                          where p.ActiveflagC == "A"
                                          && p.CustCodeVc == customerCode
                                          && p.NotificationId == Itm.notificationid
                                          select p).FirstOrDefault();
                if (NotificationRecord == null)
                {
                    NotificationRecord = new TblNotificationTracker
                    {
                        NotificationId = Itm.notificationid,
                        CustCodeVc = customerCode,
                        ReadStatus = 0,
                        ReadDateTime = dt,
                        ActiveflagC = "A",
                        CreatedbyVc = customerCode,
                        CreateddtD = DateTime.Now
                    };

                    _context.TblNotificationTracker.Add(NotificationRecord);
                }
                else
                {
                    NotificationRecord.ReadDateTime = dt;
                    NotificationRecord.ModifiedbyVc = customerCode;
                    NotificationRecord.ModifieddtD = DateTime.Now;
                }

            }

            var result = _context.SaveChanges();

            return result;

        }
    }
}
