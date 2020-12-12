using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Models.ImplementModelGroup
{
    public class ImplementModelGroup
    {
        public string MIGCode_VC { get; set; }
        public string MIGROUPNAME { get; set; }
        public string MActiveFlag_C { get; set; }
        public Nullable<int> MSectorId_I { get; set; }
        public string MCreatedBy_VC { get; set; }
        public Nullable<System.DateTime> MCreatedDt_D { get; set; }
        public string MModifiedBy_VC { get; set; }
        public Nullable<System.DateTime> MModifiedDt_D { get; set; }
        public string MModelImg_VC { get; set; }
        public int MLanguagecode { get; set; }
        public string MLanguagename { get; set; }
    }

    public class Language
    {
        public int Languageid { get; set; }
        public string Languagename { get; set; }
    }
}
