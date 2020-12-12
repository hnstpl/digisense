using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mandi.WebAPI.DataProvider;


namespace Mandi.WebAPI.Services
{
    public interface IGlobalService
    {
        IEnumerable<MstLanguage> GetAllLanguages();

        MstLanguage GetLanguageByCode(string Code);

        string GetCustomerCode(string Token);

        IEnumerable<MstLanguage> GetLanguageListForCustomer(string LanguageCode, string CustomerCode);
    }
}
