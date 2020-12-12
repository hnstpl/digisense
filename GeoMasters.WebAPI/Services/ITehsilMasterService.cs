using GeoMasters.WebAPI.Models.TehsilMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Services
{
   public interface ITehsilMasterService
    {
        public MastersModel GetTehsils(string LanguageCode, string customerCode, DistrictCode districtCode);
    }
}
