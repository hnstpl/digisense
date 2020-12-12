using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.Models.CropsMaster;
using Masters.WebAPI.DataProvider;

namespace Masters.WebAPI.Services
{
    public interface ICropsService
    {
        CropsMaster GetCropDataByLanguage(MstLanguage Language, string ModuleName);
    }
}
