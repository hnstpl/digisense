using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BannersAndNotification.WebAPI.Models.BannerActionMaster
{
    public class BannerActionTypes
    {
    }


    public class MastersModel
    {
        public List<HomeBannerTypeMaster> masters { get; set; }
    }


    public class HomeBannerTypeMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public HomePageBannerActionTypesList homepagebanneractiontypelist { get; set; }
    }



    public class HomePageBannerActionTypesList
    {
        public List<HomePageBannerActionTypes> homepagebanneractiontypes { get; set; }
        public int totalrecords { get; set; }
    }

    public class HomePageBannerActionTypes
    {
        public int id { get; set; }
        public string actiontype { get; set; }

        public List<BannerActionsubType> subtypes { get; set; }
    }


    public class BannerActionsubType
    {
        public int id { get; set; }
        public string actionsubtype { get; set; }
    }


    //[ModelName("LanguageCodeForBannerActionType")]
    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }
}
