using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.LanguageMaster;

namespace Masters.WebAPI.Services
{
    public interface ILanguageMasterService
    {
        IEnumerable<LanguageMaster> GetAll();

        decimal GetContentVerstion(string moduleName);
    }
}
