using DealerMaster.WebAPI.Models.Dealers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealerMaster.WebAPI.Services
{
   public interface IDealerMasterService
    {
        public MastersModel GetDealers(string LanguageCode, string customerCode);
    }
}
