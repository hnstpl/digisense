using GeoMasters.WebAPI.Models.VillageMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Services
{
   public interface IVillageMasterService
    {
        public MastersModel GetVillages(string LanguageCode, string customerCode, TehsilCode tehsilcode);
    }
}
