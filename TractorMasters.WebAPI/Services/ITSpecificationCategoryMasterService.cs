using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.Models.TSpecificationCategoryMaster;

namespace TractorMasters.WebAPI.Services
{
   public interface ITSpecificationCategoryMasterService
    {
        public MastersModel GetTractorSpecificationCategory(string LanguageCode, string customerCode);
    }
}
