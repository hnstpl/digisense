using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Brand;

namespace AdminPortal.Mvc.Services
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetAll(int LanguageID);
    }
}
