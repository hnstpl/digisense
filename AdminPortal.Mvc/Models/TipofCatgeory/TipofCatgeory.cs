using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPortal.Mvc.Models.TipofCatgeory
{
    public class TipofCatgeory
    {
        public int MTipCategory_ID { get; set; }
        public string MTipCategoryName { get; set; }
        public string MACTIVEFLAG_C { get; set; }
        public string MCREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> MCREATEDDT_D { get; set; }
        public string MMODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MMODIFIEDDT_D { get; set; }
        public int MLanguagecode { get; set; }
        public string MLanguagename { get; set; }
    }

    public class Language
    {
        public int Languageid { get; set; }
        public string Languagename { get; set; }
    }
}