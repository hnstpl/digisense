using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace UserAnalyticsMaster.WebAPI.Models.UserAnalytics
{
    public class UserAnalyticsCapture
    {
        public List<UserAnalytics> useranalytics { get; set; }
    }

    public class UserAnalytics
    {
        [DefaultValue(null)]
        public int moduleid { get; set; }
        [DefaultValue(null)]
        public int submoduleid { get; set; }
        [DefaultValue(null)]
        public string modelcode { get; set; }
        [DefaultValue(null)]
        public double starttime { get; set; }
        [DefaultValue(null)]
        public double endtime { get; set; }
        [DefaultValue(null)]
        public string deviceid { get; set; }
        [DefaultValue(null)]
        public string osversion { get; set; }
    }

    public class MastersModel
    {
        public UserAnalyticsModulesMaster masters { get; set; }
    }

    public class UserAnalyticsModulesMaster
    {
        public decimal? contentversion { get; set; }
        public List<UserAnalyticsModules> useranalyticsmodules { get; set; }

    }

    public class UserAnalyticsModules
    {
        public int moduleid { get; set; }
        public string modulename { get; set; }
        public List<UserAnalyticsSubModules> submodules { get; set; }
    }


    public class UserAnalyticsSubModules
    {
        public int submoduleid { get; set; }
        public string submodulename { get; set; }
    }
}
