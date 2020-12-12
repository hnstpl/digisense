using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
//using DigisenseAPI.Areas.HelpPage.ModelDescriptions;

namespace Masters.WebAPI.Models.TractorUsageMaster
{

    public class MastersModel
    {
        public List<TractorUsageMaster> masters { get; set; }
    }


    public class TractorUsageMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public TractorUsageList tractorusagelist { get; set; }
    }

    public class TractorUsageList
    {
        public List<TractorUsage> tractorusage { get; set; }
        public int totalrecords { get; set; }
    }

    public class TractorUsage
    {
        public int id { get; set; }
        public string usagename { get; set; }
    }

    //[ModelName("LanguageCodeForTractorUsage")]
    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }

}