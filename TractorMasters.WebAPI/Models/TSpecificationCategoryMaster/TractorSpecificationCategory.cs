using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TractorMasters.WebAPI.Models.TSpecificationCategoryMaster
{
    //[ModelName("MastersModelForTractorSpecificationCategory")]
    public class MastersModel
    {
        public List<SpeficicationCategoryMasters> masters { get; set; }
    }


    public class SpeficicationCategoryMasters
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public TPDHSpecificationsCategoryList tractorspeccategorylist { get; set; }
    }

    public class TPDHSpecificationsCategoryList
    {
        public List<TPDHSpecificationsCategory> tractorspecificationcategory { get; set; }
        public int totalrecords { get; set; }
    }

    public class TPDHSpecificationsCategory
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }
    }


    //[ModelName("LanguageCodeForTPDHSpecs")]
    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }

    public class DistrictCode
    {
        [DefaultValue(null)]
        public string districtcode { get; set; }
    }
}
