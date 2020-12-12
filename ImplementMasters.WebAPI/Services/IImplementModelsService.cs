using ImplementMasters.WebAPI.Models.ImplementModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementMasters.WebAPI.Services
{
    public interface IImplementModelsService
    {
        public MastersModel GetImplementModels(string LanguageCode, string customerCode);
    }
}
