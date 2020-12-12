using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Models.DistrictMaster
{
    //[ModelName("MastersModelForDistricts")]
    public class MastersModel
    {
        public List<DistrictMaster> masters { get; set; }
    }

    public class DistrictMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public DistrictsList districtlist { get; set; }
    }


    /// <summary>
    /// Return type List
    /// </summary>
    public class DistrictsList
    {
        public List<Districts> districts { get; set; }
        public int totalrecords { get; set; }
    }

    /// <summary>
    /// Return Type
    /// </summary>
    public class Districts
    {
        public string districtcode { get; set; }
        public string districtname { get; set; }
        public string statecode { get; set; }
    }


    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }


    public class StateCode
    {
        [DefaultValue(null)]
        public string statecode { get; set; }
    }
}
