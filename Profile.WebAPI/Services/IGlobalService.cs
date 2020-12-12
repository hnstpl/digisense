using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Profile.WebAPI.DataProvider;

namespace Profile.WebAPI.Services
{
    public interface IGlobalService
    {
        Task<string> DecryptString(string input);
        Task<string> EncryptString(string input);
        double? GetUnixTime(DateTime dateTime);
        string GetCustomerCode();
        int GetLanguagePreference(string CustomerCode);

        bool IsUserLangAvail(string CustomerCode, int LanguageID);

        MstEducation GetEducationByID(int ID);
        
    }
}
