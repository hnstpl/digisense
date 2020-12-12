using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
//using DigisenseAPI.Areas.HelpPage.ModelDescriptions;

namespace EnquiryMasters.WebAPI.Models.EnquiryList
{
    public class MasterList
    {
        public string languagecode { get; set; }
        public List<EnquiryMasters.WebAPI.Models.Enquiry.Enquiry> enquirylist { get; set; }
        public int totalrecords { get; set; }
    }


    public class EnquiryList
    {
        public int enquiryid { get; set; }
        public double enquirydate { get; set; }
        public int enquirytypeid { get; set; }
        public string enquirytypevalue { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string village { get; set; }
        public string referralname { get; set; }
        public string referralmobile { get; set; }
        public string referralvillage { get; set; }
        public string dealerbranchcode { get; set; }
        public string selectedmodelcode { get; set; }
        public string interestedinproduct { get; set; }
        public string interestedmodelcode { get; set; }
        public string exchangebrand { get; set; }
        public string exchangemodel { get; set; }
        public Boolean rcavailability { get; set; }
        public string yearofmanufacturing { get; set; }
    }


   // [ModelName("LanguageCodeForGetEnquiries")]
    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }
}