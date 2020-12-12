using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminPortal.Mvc.Models.Dealer
{
    public class Dealer
    {
        public string MDealerCode { get; set; }
        public string MCategoryCode_VC { get; set; }
        public string MBranchCode_VC { get; set; }
        public string MBranchName { get; set; }
        public string MAccountCode { get; set; }
        public string MDealerTitle { get; set; }
        public string MDealerName { get; set; }
        public string MStateName { get; set; }
        public string MDistrictName { get; set; }
        public string MCityName { get; set; }
        public string MAddress { get; set; }
        public string MDealerLoc { get; set; }
        public string MDistrict { get; set; }
        public string MCity { get; set; }
        public string MStateCode_I { get; set; }
        public string MDistrictCode_VC { get; set; }
        public string MAOCode { get; set; }
        public string MPinCode { get; set; }
        public string MContactPerson { get; set; }
        public string MTelOff1 { get; set; }
        public string MTelOff2 { get; set; }
        public string MEmail { get; set; }
        public string MDealerType { get; set; }
        public string MDealerPhoto { get; set; }
        public string MStatus { get; set; }
        public Nullable<int> MSectorId_I { get; set; }
        public string MCreatedBy_VC { get; set; }
        public Nullable<System.DateTime> MCreatedDt_D { get; set; }
        public string MModifiedBy_VC { get; set; }
        public Nullable<System.DateTime> MModifiedDt_D { get; set; }
        public string MDealerBranchCode { get; set; }
        public string MdealerType_vc { get; set; }
        public string MMahindraShree { get; set; }
        public Nullable<int> Mtypeofoffice_i { get; set; }
        public int MLanguagecode { get; set; }
        public string MLanguagename { get; set; }
        public string MPhone { get; set; }
        public string MMobile { get; set; }
    }
    public class Language
    {

        public int Languageid { get; set; }
        public string Languagename { get; set; }
    }


}