using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Masters.WebAPI.Models.LanguageMaster
{
    public class LanguageMasterList
    {
        public decimal contentversion { get; set; }
        public List<LanguageMaster> languagemaster { get; set; }
        public int totalrecords { get; set; }
    }

    public class LanguageMaster
    {
        public int id { get; set; }
        public string languagecode { get; set; }
        public string languagename { get; set; }
        public string languagenametranslated { get; set; }
    }


    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }

}

