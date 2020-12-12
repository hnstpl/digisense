using Masters.WebAPI.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Masters.WebAPI.Services
{
    public interface IGlobalService
    {
        IEnumerable<MstLanguage> GetAllLanguages();

        MstLanguage GetLanguageByCode(string Code);

        string GetCustomerCode(string Token);

        IEnumerable<MstLanguage> GetLanguageListForCustomer(string LanguageCode, string CustomerCode);

        string GetCustomerCode();
        Task<string> DecryptString(string input);
        Task<string> EncryptString(string input);
    }
}
