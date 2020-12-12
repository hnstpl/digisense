using AdminPortal.Mvc.Models.HP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPortal.Mvc.Services
{
    public interface IHPService
    {
        IEnumerable<HP> GetAll(int LanguageID);
    }
}
