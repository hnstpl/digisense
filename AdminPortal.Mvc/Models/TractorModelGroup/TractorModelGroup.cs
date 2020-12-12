using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Models.TractorModelGroup
{
    public class TractorModelGroup
    {
        public string MMODELGROUPCODE_VC { get; set; }
        public string MMODELGROUPNAME { get; set; }
        public string MBRANDCODE_VC { get; set; }
        public Nullable<int> MSECTORID_I { get; set; }
        public string MCREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> MCREATEDDT_D { get; set; }
        public string MMODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MMODIFIEDDT_D { get; set; }
        public string MACTIVEFLAG_C { get; set; }
        public int MLanguagecode { get; set; }
        public string MLanguagename { get; set; }
        public string MBRANDNAME { get; set; }
    }
    public class Language
    {
        public int Languageid { get; set; }
        public string Languagename { get; set; }
    }
}
