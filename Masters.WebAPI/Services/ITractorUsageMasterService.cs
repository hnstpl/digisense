using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.TractorUsageMaster;

namespace Masters.WebAPI.Services
{
    public interface ITractorUsageMasterService
    {
        TractorUsageMaster GetByLanguage(MstLanguage Language, string moduleName);

    }
}
