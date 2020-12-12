using GeoMasters.WebAPI.Models.DistrictMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Services
{
    public interface IDistrictMasterService
    {
        public MastersModel GetDistricts(string LanguageCode, string customerCode, StateCode stateCode);
    }
}
