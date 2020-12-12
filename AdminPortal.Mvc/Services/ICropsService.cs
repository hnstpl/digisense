using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Crop;

namespace AdminPortal.Mvc.Services
{
    public interface ICropsService
    {
        IEnumerable<MandiList> GetMandiByLanguageID(int? LanguageID);

        IEnumerable<CropData> GetCropDataByLanguageID(int LanguageID);
    }
}
