using System;
using System.Collections.Generic;

namespace EnquiryMasters.WebAPI.DataProvider
{
    public partial class TblNotificationTracker
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public string CustCodeVc { get; set; }
        public byte? ReadStatus { get; set; }
        public DateTime? ReadDateTime { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }

        public virtual MstCustprofile CustCodeVcNavigation { get; set; }
        public virtual TblBanners Notification { get; set; }
    }
}
