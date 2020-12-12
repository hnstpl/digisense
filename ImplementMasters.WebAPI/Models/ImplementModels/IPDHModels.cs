using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementMasters.WebAPI.Models.ImplementModels
{
    public class MastersModel
    {
        public List<IPDHModelGroups> masters { get; set; }
    }


    public class IPDHModelGroups
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public IPDHModelGroupsList impmodelgrouplist { get; set; }
    }


    public class IPDHModelGroupsList
    {
        public List<IPDHModelGroup> impmodelgroups { get; set; }
        public int totalrecords { get; set; }
    }

    public class IPDHModelGroup
    {
        public string impmodelgroupid { get; set; }
        public string impmodelgroupname { get; set; }
        public IPDHModelsList impmodelslist { get; set; }
    }


    public class IPDHModelsList
    {
        public List<IPDHModels> implementmodels { get; set; }
        public int totalrecords { get; set; }
    }

    public class IPDHModels
    {
        public string modelcode { get; set; }
        public string modelname { get; set; }
        public string modelgroupid { get; set; }
        public string modelgroupname { get; set; }
        public string subcategory { get; set; }
        public string imageurl { get; set; }
        public int imageversion { get; set; }
        public IPDHSpecificationsList impmodelspecificationslist { get; set; }
        public IPDHFeaturesList impmodelfeatureslist { get; set; }
        public IPDHBenefitsList impmodelbenefitslist { get; set; }
    }


    public class IPDHSpecificationsList
    {
        public List<IPDHSpecifications> impmodelspecifications { get; set; }
        public int totalrecords { get; set; }
    }

    public class IPDHSpecifications
    {
        public int specificationid { get; set; }
        public string specificationcategory { get; set; }
        public string specificationname { get; set; }
        public string specificationvalue { get; set; }
    }

    public class IPDHFeaturesList
    {
        public List<IPDHFeatures> impmodelfeatures { get; set; }
        public int totalrecords { get; set; }
    }

    public class IPDHFeatures
    {
        public int featureid { get; set; }
        public string featurename { get; set; }
        public string featurevalue { get; set; }
    }



    public class IPDHBenefitsList
    {
        public List<IPDHBenefits> impmodelbenefits { get; set; }
        public int totalrecords { get; set; }
    }

    public class IPDHBenefits
    {
        public int benefitid { get; set; }
        public string benefitname { get; set; }
        public string benefitvalue { get; set; }
    }

    //[ModelName("LanguageCodeForImplementModel")]
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
