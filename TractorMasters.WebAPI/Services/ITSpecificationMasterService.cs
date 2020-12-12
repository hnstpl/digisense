using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.Models.TSpecificationMaster;

namespace TractorMasters.WebAPI.Services
{
   public interface ITSpecificationMasterService
    {
        public MastersModel GetTractorSpecification(string LanguageCode, string customerCode);
    }
}
