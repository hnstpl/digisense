using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Models.VillageMaster
{
    public class MastersModel
    {
        public List<VillageMaster> masters { get; set; }
    }

    public class VillageMaster
    {
        public decimal contentversion { get; set; }
        public string languagecode { get; set; }
        public VillagesList villagelist { get; set; }
    }


    /// <summary>
    /// Return type List
    /// </summary>
    public class VillagesList
    {
        public List<Villages> villages { get; set; }
        public int totalrecords { get; set; }
    }

    /// <summary>
    /// Return type
    /// </summary>
    public class Villages
    {
        public string villagecode { get; set; }
        public string villagename { get; set; }
        public string tehsilcode { get; set; }
    }


    public class LanguageCode
    {
        [DefaultValue(null)]
        public string languagecode { get; set; }
    }

    public class TehsilCode
    {
        [DefaultValue(null)]
        public string tehsilcode { get; set; }
    }
}
