using AdminPortal.Mvc.Models.ImplementModelGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public interface IImplementModelGroupService
    {
        IEnumerable<ImplementModelGroup> GetByLanguageID(int LanguageID);
    }
}
