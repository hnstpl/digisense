using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Masters.WebAPI.Models.TractorModels
{

    public class MastersModel
    {
        public List<TPDHModelGroups> masters { get; set; }
    }


    public class TPDHModelGroups
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public TPDHModelGroupsList tractormodelgrouplist { get; set; }
    }


    public class TPDHModelGroupsList
    {
        public List<TPDHModelGroup> tractormodelgroup { get; set; }
        public int totalrecords { get; set; }
    }

    public class TPDHModelGroup
    {
        //public string languagecode { get; set; }
        public string groupcode { get; set; }
        public string groupname { get; set; }
        public TPDHModelsList tractormodelslist { get; set; }
    }

    public class TPDHModelsList
    {
        public List<TPDHModels> tractormodels { get; set; }
        public int totalrecords { get; set; }
    }

    public class TPDHModels
    {
        public string brand { get; set; }
        public string hprange { get; set; }
        public int hp { get; set; }
        public string modelcode { get; set; }
        public string modelname { get; set; }
        public Image imageslist { get; set; }
        public TPDHModelSpecsList tractormodelspecificationlist { get; set; }
        public TPDHModelFeaturesList tractormodelfeaturelist { get; set; }
    }



    public class TPDHModelSpecsList
    {
        public List<TPDHModelSpecs> tractormodelspecifications { get; set; }
        public int totalrecords { get; set; }
    }

    public class TPDHModelSpecs
    {
        public int specid { get; set; }
        public string specname { get; set; }
        //public int speccategoryid { get; set; }
        public string specvalue { get; set; }
    }


    public class TPDHModelFeaturesList
    {
        public List<TPDHModelFeatures> tractormodelfeatures { get; set; }
        public int totalrecords { get; set; }
    }

    public class TPDHModelFeatures
    {
        public int featureid { get; set; }
        public string featurename { get; set; }
        public string featurevalue { get; set; }
        public string featureimage { get; set; }
        public int imageversion { get; set; }
    }

    public class Image
    {
        public List<ImageProp> _360 { get; set; }
        public List<ImageProp> images { get; set; }
    }


    public class ImageProp
    {
        public int imageid { get; set; }
        public string imageurl { get; set; }
        //public DateTime modifiedon { get; set; }
        public int imageversion { get; set; }
    }


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
