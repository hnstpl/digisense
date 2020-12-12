using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BannersAndNotification.WebAPI.Models.Banners
{
    public class HomePageModel
    {
        public List<HomePage> homepagemodel { get; set; }
    }


    public class HomePage
    {
        public string languagecode { get; set; }
        public BannersList bannerlist { get; set; }
        public TipsList tipslist { get; set; }
        //Mandi is pending
    }

    public class BannersList
    {
        public List<Banners> banners { get; set; }
        public int totalrecords { get; set; }
    }

    public class Banners
    {
        public int bannerid { get; set; }
        public string bannertitle { get; set; }
        public int bannercategoryid { get; set; }
        public string bannercategory { get; set; }
        public int bannertypeid { get; set; }
        //public int bannercategoryid { get; set; }
        public string bannertypevalue { get; set; }
        public string bannerimageurl { get; set; }
        public string notificationtext { get; set; }
        public int actiontypeid { get; set; }
        public string actiontypevalue { get; set; }
        public string actiontypetarget { get; set; }
        public double validfrom { get; set; }
        public double validthru { get; set; }
        public int? banneractionsubtypeid { get; set; }
        
        public dynamic readstatus { get; set; }

        public string notificationtitle { get; set; }
    }

    public class TipsList
    {
        public List<Tips> tips { get; set; }
        public int totalrecords { get; set; }
    }

    public class Tips
    {
        public int tipid { get; set; }
        public string tipcategory { get; set; }
        public string tiptitle { get; set; }
        public string tiptext { get; set; }
        public double validfrom { get; set; }
        public double validthru { get; set; }
    }

    //[ModelName("LanguageCodeForBanners")]
    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }
}
