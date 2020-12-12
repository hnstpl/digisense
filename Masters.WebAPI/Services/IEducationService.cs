using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.EducationMaster;

namespace Masters.WebAPI.Services
{
    public interface IEducationService
    {
        EducationMaster GetDataByLanguageID(MstLanguage Language, string Modulename);
    }
}
