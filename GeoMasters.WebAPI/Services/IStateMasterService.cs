using GeoMasters.WebAPI.Models.StateMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMasters.WebAPI.Services
{
   public interface IStateMasterService
    {
        public MastersModel GetStates(string LanguageCode, string customerCode);
    }
}
