using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Models.StateMaster
{
    public class MastersModel
    {
        public List<StateMaster> masters { get; set; }
    }


    /// <summary>
    /// Return Master States
    /// </summary>
    public class StateMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public StatesList stateslist { get; set; }
    }



    /// <summary>
    /// Return type List
    /// </summary>
    public class StatesList
    {
        public List<States> states { get; set; }
        public int totalrecords { get; set; }
    }

    /// <summary>
    /// Return type
    /// </summary>
    public class States
    {
        public string statecode { get; set; }
        public string statename { get; set; }
    }

    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }
}
