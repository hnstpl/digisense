using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
//using DigisenseAPI.Areas.HelpPage.ModelDescriptions;

namespace Masters.WebAPI.Models.EducationMaster
{
    public class MastersModel
    {
        public List<EducationMaster> masters { get; set; }
    }


    public class EducationMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public EducationList educationlist { get; set; }
    }

    public class EducationList
    {
        public List<Education> education { get; set; }
        public int totalrecords { get; set; }
    }
    public class Education
    {
        public int id { get; set; }
        public string educationname { get; set; }
    }

    //[ModelName("LanguageCodeForEducationMaster")]
    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }

}