using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DealerMaster.WebAPI.Models.Dealers
{
    //[ModelName("MastersModelForDealers")]
    public class MastersModel
    {
        public List<DealerMaster> masters { get; set; }
    }

    public class DealerMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public DealersList dealerlist { get; set; }
    }


    public class DealersList
    {
        public List<Dealers> dealers { get; set; }
        public int totalrecords { get; set; }
    }

    public class Dealers
    {
        public string dealerid { get; set; }
        public string dealername { get; set; }
        public string branchid { get; set; }
        public string contactname { get; set; }
        public string contactnumber { get; set; }
        public string email { get; set; }
        public string statecode { get; set; }
        public string statename { get; set; }
        public string districtcode { get; set; }
        public string districtname { get; set; }
        public string tehsilcode { get; set; }
        public string tehsilname { get; set; }
        public string address { get; set; }
        public Boolean sales { get; set; }
        public Boolean service { get; set; }
        public Boolean spare { get; set; }
        public Position position { get; set; }
    }

    public class Position
    {
        public string lattitude { get; set; }
        public string logitude { get; set; }
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
