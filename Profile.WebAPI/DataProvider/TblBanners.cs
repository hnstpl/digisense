using System;
using System.Collections.Generic;

namespace Profile.WebAPI.DataProvider
{
    public partial class TblBanners
    {
        public TblBanners()
        {
            TblBannersLang = new HashSet<TblBannersLang>();
            TblBannersLocationMapping = new HashSet<TblBannersLocationMapping>();
            TblBannersModelMapping = new HashSet<TblBannersModelMapping>();
            TblNotificationTracker = new HashSet<TblNotificationTracker>();
        }

        public int BannerId { get; set; }
        public int? BannerOrNotification { get; set; }
        public string BannerImage { get; set; }
        public int? Category { get; set; }
        public int? ActionType { get; set; }
        public string ActionTypeTarget { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string ApplicableStates { get; set; }
        public string ApplicableProducts { get; set; }
        public string ActiveflagC { get; set; }
        public string CreatedbyVc { get; set; }
        public DateTime? CreateddtD { get; set; }
        public string ModifiedbyVc { get; set; }
        public DateTime? ModifieddtD { get; set; }
        public int? ActionSubType { get; set; }

        public virtual MstBanneractiontype ActionTypeNavigation { get; set; }
        public virtual MstBannertype BannerOrNotificationNavigation { get; set; }
        public virtual MstBannercategory CategoryNavigation { get; set; }
        public virtual ICollection<TblBannersLang> TblBannersLang { get; set; }
        public virtual ICollection<TblBannersLocationMapping> TblBannersLocationMapping { get; set; }
        public virtual ICollection<TblBannersModelMapping> TblBannersModelMapping { get; set; }
        public virtual ICollection<TblNotificationTracker> TblNotificationTracker { get; set; }
    }
}
