using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.TractorModel;

namespace AdminPortal.Mvc.Services
{
    public interface ITractorModelService
    {
        IEnumerable<TractorModel> GetByLanguageID(int LanguageID);
    }
}
