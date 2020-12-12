using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.Models.TractorModels;

namespace TractorMasters.WebAPI.Services
{
   public interface ITractorModelsService
    {
        public MastersModel GetTractorModels(string LanguageCode, string customerCode);
    }
}
