using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DIYMaster.WebAPI.Models.DIY
{
    //[ModelName("MastersModelForDIY")]
    public class MastersModel
    {
        public List<DIYList> masters { get; set; }
    }
    public class DIYList
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public List<DIY> diyvideos { get; set; }
        public int totalrecords { get; set; }
    }

    public class DIY
    {
        public int videoid { get; set; }
        public string videoname { get; set; }
        public string videodescription { get; set; }
        public int? videocategoryid { get; set; }
        public string videocategoryvalue { get; set; }
        public string videourl { get; set; }
        public double createddate { get; set; }
        public double modifieddate { get; set; }
        public List<DIY_Tractors> tractors { get; set; }
        public List<DIY_Implements> implements { get; set; }
    }

    public class DIY_Tractors
    {
        public string modelcode { get; set; }
    }


    public class DIY_Implements
    {
        public string modelcodes { get; set; }
    }


    //[ModelName("LanguageCodeForDIY")]
    public class LanguageCode
    {
        /// <summary>
        /// languagecode is optional
        /// </summary>
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }
}
