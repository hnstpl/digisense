using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Dealer;

namespace AdminPortal.Mvc.Services
{
    public interface IDealerService
    {
        IEnumerable<Dealer> GetAll(int LanguageID);
        IEnumerable<Dealer> GetByType(int LanguageID, int type);
        Boolean UpdateByID(string DealerCode, string User, string ActiveFlag, int LanguageID, string BranchCode);
    }
}
