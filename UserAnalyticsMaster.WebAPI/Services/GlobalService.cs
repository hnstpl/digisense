using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UserAnalyticsMaster.WebAPI.DataProvider;

namespace UserAnalyticsMaster.WebAPI.Services
{
    public class GlobalService:IGlobalService
    {
        private readonly IConfiguration _config;

        private readonly IHttpContextAccessor _httpContext;

        private readonly dev_encrypted_generalcustomerappContext _context;


        public static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public GlobalService(dev_encrypted_generalcustomerappContext DataContext, IConfiguration Config, IHttpContextAccessor HttpContext)
        {
            _context = DataContext;
            _config = Config;
            _httpContext = HttpContext;
        }

        public IEnumerable<MstLanguage> GetAllLanguages()
        {
            return _context.MstLanguage.Where(x => x.ActiveflagC == "A");
        }

        public MstLanguage GetLanguageByCode(string Code)
        {
            return _context.MstLanguage.Where(x => x.LanguageCode == Code && x.ActiveflagC == "A").FirstOrDefault();
        }


        public List<MstLanguage> GetLanguageList(string LanguageCode, string customerCode)
        {
            List<MstLanguage> languages = new List<MstLanguage>();


            if (LanguageCode == null)
            {
                var UserLanguagePreference = (from p in _context.MstCustprofile
                                              where p.CustCodeVc == customerCode
                                              select p).FirstOrDefault();

                languages = (from p in _context.MstLanguage
                             where p.ActiveflagC == "A"
                             && p.Id == UserLanguagePreference.LanguagePreference
                             select p).ToList();
            }
            else
            {
                languages = (from p in _context.MstLanguage
                             where p.ActiveflagC == "A"
                             && (LanguageCode == null || p.LanguageCode == LanguageCode)
                             select p).ToList();
            }

            return languages;
        }
        public MstLanguage GetLanguage(string LanguageCode, string customerCode)
        {
            MstLanguage languages = new MstLanguage();


            if (LanguageCode == null)
            {
                var UserLanguagePreference = (from p in _context.MstCustprofile
                                              where p.CustCodeVc == customerCode
                                              select p).FirstOrDefault();

                languages = (from p in _context.MstLanguage
                             where p.ActiveflagC == "A"
                             && p.Id == UserLanguagePreference.LanguagePreference
                             select p).FirstOrDefault();
            }
            else
            {
                languages = (from p in _context.MstLanguage
                             where p.ActiveflagC == "A"
                             && (LanguageCode == null || p.LanguageCode == LanguageCode)
                             select p).FirstOrDefault();
            }


            return languages;
        }

        public string GetCustomerCode()
        {
            //return ClaimsPrincipal.Current.Identities.First().Claims.FirstOrDefault(x => x.Type.Contains("nameidentifier")).Value.Replace("\"", "");
            //return "A000000490";

            return DecryptString(_httpContext.HttpContext.User.Claims.Where(x => x.Type == "UserID").FirstOrDefault().Value).Result;
        }

        public async Task<string> DecryptString(string input)
        {
            try
            {
                string BaseURL = _config["DecryptServiceURL"];

                BaseURL = BaseURL + input;

                if (input == null) return null;

                using (HttpClient _client = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Get, BaseURL);

                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    request.Headers.Add("API-Key", (Convert.ToInt32(GetUnixTime(DateTime.Now)) + 25000).ToString());


                    using (var response = await _client.SendAsync(request))
                    {
                        if (!response.IsSuccessStatusCode) return null;

                        var Content = await response.Content.ReadAsStringAsync();

                        var Tasks = JsonConvert.DeserializeObject<string>(Content);

                        return Tasks;
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<string> EncryptString(string input)
        {
            string BaseURL = _config["EncryptServiceURL"];

            BaseURL = BaseURL + input;

            using (HttpClient _client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, BaseURL);

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                request.Headers.Add("API-Key", (Convert.ToInt32(GetUnixTime(DateTime.Now)) + 25000).ToString());

                using (var response = await _client.SendAsync(request))
                {
                    if (!response.IsSuccessStatusCode) return null;

                    var Content = await response.Content.ReadAsStringAsync();

                    var Tasks = JsonConvert.DeserializeObject<string>(Content);

                    return Tasks;
                }
            }
        }

        public double? GetUnixTime(DateTime dateTime)
        {
            if (dateTime == null) return null;

            return (dateTime - epoch).TotalSeconds;
        }
    }
}
