using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Models.TehsilMaster
{
    public class MastersModel
    {
        public List<TehsilMaster> masters { get; set; }
    }

    public class TehsilMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public TehsilList tehsillist { get; set; }
    }




    /// <summary>
    /// Return type List
    /// </summary>
    public class TehsilList
    {
        public List<Tehsils> tehsils { get; set; }
        public int totalrecords { get; set; }
    }

    /// <summary>
    /// Return type
    /// </summary>
    public class Tehsils
    {
        public string tehsilcode { get; set; }
        public string tehsilname { get; set; }
        public string districtcode { get; set; }
    }

    //[ModelName("LanguageCodeForTehsilMaster")]
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
