using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;


namespace AdminPortal.Mvc.Models.OldTractorEvaluation
{
    public class OldTractorEvaluation
    {
        public int ENQ_ID { get; set; }
        public Nullable<int> ENQ_TYPE_ID { get; set; }
        public string EnqTypeName { get; set; }
        public string CustCode_VC { get; set; }
        public string CustName_VC { get; set; }
        public string DealerCode_VC { get; set; }
        public string DealerName { get; set; }
        public string DealerAddress { get; set; }
        public string VillageCode_VC { get; set; }
        public string VillageName { get; set; }
        public Nullable<int> ProductNImplement { get; set; }
        public string Referral_NAME { get; set; }
        public string Referral_VillageCode_VC { get; set; }
        public string Referral_MobileNo_VC { get; set; }
        public string ENQ_TICKET_ID { get; set; }
        public string ENQ_STATUS { get; set; }
        public string TPDH_MODELCODE_VC { get; set; }
        public string TPDH_MODELNAME_VC { get; set; }
        public string CREATEDBY_VC { get; set; }
        public Nullable<System.DateTime> CREATEDDT_D { get; set; }
        public string MODIFIEDBY_VC { get; set; }
        public Nullable<System.DateTime> MODIFIEDDT_D { get; set; }
        public string IPDH_MODELCODE_VC { get; set; }
        public string IPDH_MODELNAME_VC { get; set; }
        public string ENQ_REMARKS { get; set; }
        public string MANUFACTURERCODE_VC { get; set; }
        public string ISRCAvailable { get; set; }
        public string Year_OF_MANUFACTURE { get; set; }
        public Nullable<int> Intrested_IN { get; set; }
        public string Intrested_IN_TPDH_MODELCODE_VC { get; set; }
        public string Intrested_IN_IPDH_MODELCODE_VC { get; set; }
        public string MStatus { get; set; }
        public string DealerBranchName_VC { get; set; }
        public string Validity { get; set; }
        public string Intrested_IN_TPDH_MODELNAME_VC { get; set; }
        public List<EnquiryImages> ImageData { get; set; }
    }
    public class Language
    {
        public int Languageid { get; set; }
        public string Languagename { get; set; }
    }

    public class ModelData
    {
        public string ModelID { get; set; }
        public string ModelName { get; set; }

    }
    public class EnquiryImages
    {
        public int? ENQ_ID { get; set; }
        public string Imagepath { get; set; }
    }
}