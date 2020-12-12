using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TractorMasters.WebAPI.Models.ProductMasterInfo
{

    public class MastersModel
    {
        public List<ProductMasterInfo> masters { get; set; }
    }

    public class ProductMasterInfo
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public ManufacturersList manufacturerslist { get; set; }
        public BrandsList brandslist { get; set; }
        public HPList hplist { get; set; }
    }

    public class ManufacturersList
    {
        public List<Manufacturers> manufacturers { get; set; }
        public int totalrecords { get; set; }
    }

    /// <summary>
    /// Return type
    /// </summary>
    public class Manufacturers
    {
        //public string languagecode { get; set; }
        public string manufacturercode { get; set; }
        public string manufacturername { get; set; }
    }


    /// <summary>
    /// Return type List
    /// </summary>
    public class BrandsList
    {
        public List<Brands> brands { get; set; }
        public int totalrecords { get; set; }
    }

    /// <summary>
    /// Return type
    /// </summary>
    public class Brands
    {
        //public string languagecode { get; set; }
        public string brandcode { get; set; }
        public string brandname { get; set; }
    }


    public class HPList
    {
        public List<HP> hp { get; set; }
        public int totalrecords { get; set; }
    }

    /// <summary>
    /// Return type
    /// </summary>
    public class HP
    {
        //public string languagecode { get; set; }
        public string hpcode { get; set; }
        public string hpname { get; set; }
    }



    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }

}
