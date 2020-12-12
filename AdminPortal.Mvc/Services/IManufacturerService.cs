using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminPortal.Mvc.Models.Manufacturer;

namespace AdminPortal.Mvc.Services
{
    public interface IManufacturerService
    {
        IEnumerable<Manufacturer> GetAll(int LanguageID);
    }
}
