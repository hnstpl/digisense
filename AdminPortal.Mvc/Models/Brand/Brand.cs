using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPortal.Mvc.Models.Brand
{
    public class Brand
    {
        public string MBRANDCODE_VC { get; set; }
        public string MBrandName { get; set; }
        public string SERIESCODE_VC { get; set; }
        public Nullable<int> SECTORID_I { get; set; }
        public string ACTIVEFLAG_C { get; set; }
        public string CREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> CREATEDDT_D { get; set; }
        public string MODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MODIFIEDDT_D { get; set; }
        public string MANUFACTURERCODE_VC { get; set; }
        public int MLanguagecode { get; set; }
        public string MLanguagename { get; set; }
    }
    public class Language
    {
        public int Languageid { get; set; }
        public string Languagename { get; set; }
    }

}