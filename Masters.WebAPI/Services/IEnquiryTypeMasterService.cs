using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.DataProvider;
using Masters.WebAPI.Models.EnquiryTypeMaster;

namespace Masters.WebAPI.Services
{
    public interface IEnquiryTypeMasterService
    {
        EnquiryTypes GetByLanguage(MstLanguage Language, string moduleName);
    }
}
