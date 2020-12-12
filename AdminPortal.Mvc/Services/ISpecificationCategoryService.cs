using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.SpecificationCategory;

namespace AdminPortal.Mvc.Services
{
    public interface ISpecificationCategoryService
    {
        IEnumerable<SpecificationCategory> GetAll(int LanguageID);
    }
}
