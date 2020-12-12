using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPortal.Mvc.Models.Language
{
    public class LanguageInfo
    {
        public int MLanguageID { get; set; }
        public string MLanguage_Name { get; set; }
        public string MTranslate_Name { get; set; }
        public string MACTIVEFLAG_C { get; set; }
        public string MCREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> MCREATEDDT_D { get; set; }
        public Nullable<System.DateTime> MMODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MMODIFIEDDT_D { get; set; }
        public string MLANGUAGE_CODE { get; set; }
    }
}