using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
//using DigisenseAPI.Areas.HelpPage.ModelDescriptions;

namespace Masters.WebAPI.Models.EnquiryTypeMaster
{
    public class MastersModel
    {
        public List<EnquiryTypes> masters { get; set; }
    }
    public class EnquiryTypes
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public List<EnquiryTypesList> enquirytypelist { get; set; }
        public int totalrecords { get; set; }
    }

    public class EnquiryTypesList
    {
        public int enquirytypeid { get; set; }
        public string enquirytypename { get; set; }
    }

    //[ModelName("LanguageCodeForEnquiryType")]
    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }
}