using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mandi.WebAPI.DataProvider;
using Mandi.WebAPI.Models.MandiModel;

namespace Mandi.WebAPI.Services
{
    public interface IMandiService
    {
        IEnumerable<int?> GetCropSelection(string CustomerCode);

        IEnumerable<int?> GetMandiSelection(string CustomerCode);

        IEnumerable<MandiModel> GetMandiDataByLanguage(MstLanguage Language, List<int?> MandiList, List<int?> CropList, int DefaultLanguageID);

        IEnumerable<Crop> GetCropForMandi(MstLanguage Language, List<int?> CropsSelection, int MandiID);

        decimal GetContentVersion(string moduleName);
    }
}
