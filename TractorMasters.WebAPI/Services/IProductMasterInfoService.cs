using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TractorMasters.WebAPI.DataProvider;
using TractorMasters.WebAPI.Models.ProductMasterInfo;

namespace TractorMasters.WebAPI.Services
{
   public interface IProductMasterInfoService
    {
        public MastersModel GetProductMasterInfo(string LanguageCode, string customerCode);
    }
}
