using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TractorMasters.WebAPI.Models.TSpecificationMaster
{
    public class MastersModel
    {
        public List<SpeficicationMaster> masters { get; set; }
    }


    public class SpeficicationMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public TPDHSpecificationsList tractorspeclist { get; set; }
    }

    public class TPDHSpecificationsList
    {
        public List<TPDHSpecifications> tractorspecifications { get; set; }
        public int totalrecords { get; set; }
    }

    public class TPDHSpecifications
    {
        public int specificationid { get; set; }
        public int speccategoryid { get; set; }
        public string specificationname { get; set; }
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
