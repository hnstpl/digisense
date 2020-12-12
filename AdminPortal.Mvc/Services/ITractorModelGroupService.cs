using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.TractorModelGroup;

namespace AdminPortal.Mvc.Services
{
    public interface ITractorModelGroupService
    {
        IEnumerable<TractorModelGroup> GetByLanguageID(int LanguageID);
    }
}
