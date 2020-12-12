using AdminPortal.Mvc.Models.ImplementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public interface IImplementModelService
    {
        IEnumerable<ImplementModel> GetAll(int LanguageID);
        IEnumerable<ImplementModel> GetByType(int LanguageID);       
    }
}
