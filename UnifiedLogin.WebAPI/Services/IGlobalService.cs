using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnifiedLogin.WebAPI.Services
{
    public interface IGlobalService
    {
        Task<string> DecryptString(string input);
        Task<string> EncryptString(string input);
        double? GetUnixTime(DateTime dateTime);

        
    }
}