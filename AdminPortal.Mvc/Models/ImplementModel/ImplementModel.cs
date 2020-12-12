using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Models.ImplementModel
{
    public class ImplementModel
    {
        public string MIMPCODE { get; set; }
        public string MIMPNAME { get; set; }
        public string MMANUFACTURERCODE_VC { get; set; }
        public string MMANUFACTURERMNAME { get; set; }
        public Nullable<int> MImplementCategory_ID { get; set; }
        public string MCATEGORYNAME { get; set; }
        public Nullable<int> MMaterialType_I { get; set; }
        public string MMATERIALTYPENAME { get; set; }
        public string MACTIVEFLAG_C { get; set; }
        public Nullable<int> MSECTORID_I { get; set; }
        public string MCREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> MCREATEDDT_D { get; set; }
        public string MMODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MMODIFIEDDT_D { get; set; }
        public string MIGCode_VC { get; set; }
        public string MIGNAME { get; set; }
        public string MSubCategoryCode_VC { get; set; }
        public string MImagePath_VC { get; set; }
    }

    public class Language
    {
        public int Languageid { get; set; }
        public string Languagename { get; set; }
    }
}
