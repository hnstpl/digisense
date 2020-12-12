using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPortal.Mvc.Models.SpecificationCategory
{
    public class SpecificationCategory
    {
        public int MSpecCategoryID { get; set; }
        public string MSpecCategoyName { get; set; }
        public string MACTIVEFLAG_C { get; set; }
        public string MCREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> MCREATEDDT_D { get; set; }
        public string MMODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MMODIFIEDDT_D { get; set; }
    }
    
    public class Language
    {
        public int Languageid { get; set; }
        public string Languagename { get; set; }
    }
}