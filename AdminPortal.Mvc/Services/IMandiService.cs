using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Mandi;

namespace AdminPortal.Mvc.Services
{
    public interface IMandiService
    {
        IEnumerable<Mandi> GetMandiDataByLanguageID(int LanguageID);
    }
}
