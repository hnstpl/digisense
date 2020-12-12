using AdminPortal.Mvc.Models.TipofCatgeory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public interface ITipofCatgeoryService
    {
        IEnumerable<TipofCatgeory> GetAll(int LanguageID);
    }
}
