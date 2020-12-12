using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace AdminPortal.Mvc.Models.ImplementSuitability
{
    public class ImplementSuitability
    {
       
    }
   
    public class TractorModel
    {
        public string TRACTORCODE { get; set; }
        public string TRACTORNAME { get; set; }
        public string OLDMODELCODE_VC { get; set; }
        public string MODELGROUPCODE_VC { get; set; }
        public string HPCODE_VC { get; set; }
        public Nullable<int> MaterialType_I { get; set; }
        public string ACTIVEFLAG_C { get; set; }
        public Nullable<int> SECTORID_I { get; set; }
        public string CREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> CREATEDDT_D { get; set; }
        public string MODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MODIFIEDDT_D { get; set; }
        public string BRANDCODE_VC { get; set; }
        public string BRANDNAME_VC { get; set; }

        public string MMODELCODE_VC { get; set; }
        public string MMODELNAME { get; set; }
        public string MMODELGROUPNAME { get; set; }
        public string MHPNAME { get; set; }
        public string MBRANDNAME { get; set; }
        public string MACTIVEFLAG_C { get; set; }

    }

    public class ImplementModel
    {
        public string IMPLEMENTCODE { get; set; }
        public string IMPLEMENTNAME { get; set; }

        public string ASSIGNIMPLEMENTCODE { get; set; }
        public string ASSIGNIMPLEMENTNAME { get; set; }

        public string MANUFACTURERCODE_VC { get; set; }
        public Nullable<int> ImplementCategory_ID { get; set; }
        public Nullable<int> MaterialType_I { get; set; }
        public string ACTIVEFLAG_C { get; set; }
        public Nullable<int> SECTORID_I { get; set; }
        public string CREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> CREATEDDT_D { get; set; }
        public string MODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MODIFIEDDT_D { get; set; }
        public string IGCode_VC { get; set; }
        public string SubCategoryCode_VC { get; set; }
        public string ImagePath_VC { get; set; }
        public string ThumpImage { get; set; }
        public Nullable<int> ImagePath_Version { get; set; }
        public Nullable<int> ThumpImage_Version { get; set; }

    }

    public class AvailableAssignment
    {
        public string TRACTORCODE { get; set; }
        public string TRACTORNAME { get; set; }
        public string OLDMODELCODE_VC { get; set; }
        public string MODELGROUPCODE_VC { get; set; }
        public string HPCODE_VC { get; set; }
        public Nullable<int> MaterialType_I { get; set; }
        public string ACTIVEFLAG_C { get; set; }
        public Nullable<int> SECTORID_I { get; set; }
        public string CREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> CREATEDDT_D { get; set; }
        public string MODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MODIFIEDDT_D { get; set; }
        public string BRANDCODE_VC { get; set; }
        public string BRANDNAME_VC { get; set; }

        public string MMODELCODE_VC { get; set; }
        public string MMODELNAME { get; set; }
        public string MMODELGROUPNAME { get; set; }
        public string MHPNAME { get; set; }
        public string MBRANDNAME { get; set; }
        public string MACTIVEFLAG_C { get; set; }
        public string ASSIGNIMPLEMENTCODE { get; set; }
        public string ASSIGNIMPLEMENTNAME { get; set; }

    }

    public class AssignImplementSuitability
    {
        public int SUITABLE_ID { get; set; }
        public string TPDH_MODELCODE_VC { get; set; }
        public string IPDH_MODELCODE_VC { get; set; }
        public string ACTIVEFLAG_C { get; set; }
        public Nullable<int> SECTORID_I { get; set; }
        public string CREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> CREATEDDT_D { get; set; }
        public string MODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MODIFIEDDT_D { get; set; }
       // public virtual mst_tpdh_model mst_tpdh_model { get; set; }
        //public virtual mst_ipdh_model mst_ipdh_model { get; set; }


    }
   
}