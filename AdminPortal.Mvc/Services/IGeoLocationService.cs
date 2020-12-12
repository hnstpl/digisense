using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.GeoLocation;

namespace AdminPortal.Mvc.Services
{
    public interface IGeoLocationService
    {
        IEnumerable<State> GetAllStates(int LanguageID);
        IEnumerable<District> GetAllDistricts(int LanguageID);
        IEnumerable<Tehsil> GetAllTehsils(int LanguageID);
        IEnumerable<Village> GetAllVillages(int LanguageID);
    }
}
