using ImportDeviceToken.WebAPI.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImportDeviceToken.WebAPI.Services
{
    public interface IGlobalService
    {
        IEnumerable<MstLanguage> GetAllLanguages();

        MstLanguage GetLanguageByCode(string Code);
        public string GetCustomerCode();
        public MstLanguage GetLanguage(string LanguageCode, string customerCode);
        public List<MstLanguage> GetLanguageList(string LanguageCode, string customerCode);
        Task<string> DecryptString(string input);
        Task<string> EncryptString(string input);
        double? GetUnixTime(DateTime dateTime);
    }
}
