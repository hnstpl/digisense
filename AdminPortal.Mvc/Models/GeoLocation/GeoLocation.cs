using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminPortal.Mvc.Models;


namespace AdminPortal.Mvc.Models.GeoLocation
{
    public class GeoLocation
    {
        public int tipListCount { get; set; }
    }

    public class State
    {
       
        public string MStateCode_I { get; set; }
        public string MStateCode_VC { get; set; }
        public string MStateName_VC { get; set; }
        public string MZoneCode_VC { get; set; }
        public string MActiveFlag_C { get; set; }
        public string MIsBusinessState_C { get; set; }
        public string MCreatedBy_VC { get; set; }
        public Nullable<System.DateTime> MCreatedDt_D { get; set; }
        public string MModifiedBy_VC { get; set; }
        public Nullable<System.DateTime> MModifiedDt_D { get; set; }
        public string MIs_UnionTerritori_C { get; set; }
        public int MLanguagecode { get; set; }

    }
    public class Language
    {
       
        public int Languageid { get; set; }
        public string Languagename { get; set; }
    }

    public class District
    {
       
        public string MDistrictCode_VC { get; set; }
        public string MDistrictName_VC { get; set; }
        public string MStatenAME_I { get; set; }
        public string MDistrictShortName_VC { get; set; }
        public string MStateCode_I { get; set; }
        public string MACTIVEFLAG_C { get; set; }
        public string MCREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> MCREATEDDT_D { get; set; }
        public string MMODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MMODIFIEDDT_D { get; set; }

    }

    public class Tehsil
    {
        
        public string MTehsilCode_VC { get; set; }
        public string MTehsilName_VC { get; set; }
        public string MDistrictName { get; set; }
        public string MTehsilShortName_VC { get; set; }
        public string MDistrictCode_VC { get; set; }
        public string MACTIVEFLAG_C { get; set; }
        public string MCREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> MCREATEDDT_D { get; set; }
        public string MMODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MMODIFIEDDT_D { get; set; }
    }

    public class Village
    {
       
        public string MVillageCode_VC { get; set; }
        public string MOldVillageCode_VC { get; set; }
        public string MVillageName_VC { get; set; }
        public string MTehsilName_VC { get; set; }
        public string MVDistrictName { get; set; }
        public string MVillageShortName_VC { get; set; }
        public string MTehsilCode_VC { get; set; }
        public string MPostCode_VC { get; set; }
        public string MBlockCode_VC { get; set; }
        public Nullable<int> MClassification1_I { get; set; }
        public Nullable<int> MClassification2_I { get; set; }
        public Nullable<int> MRclassification1_I { get; set; }
        public Nullable<int> MRclassification2_I { get; set; }
        public string MACTIVEFLAG_C { get; set; }
        public string MCREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> MCREATEDDT_D { get; set; }
        public string MMODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MMODIFIEDDT_D { get; set; }
        public string MSyncStatus_C { get; set; }
        public string MSyncRemark_VC { get; set; }
        public string MLongitude { get; set; }
        public string MLatitude { get; set; }
    }
}