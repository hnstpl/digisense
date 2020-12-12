using Masters.WebAPI.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Masters.WebAPI.Models.CropsMaster;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Masters.WebAPI.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

namespace Masters.WebAPI.Services
{
    public class GlobalService : IGlobalService
    {
        public static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private readonly dev_encrypted_generalcustomerappContext _context;

        private readonly IConfiguration _config;

        private readonly IHttpContextAccessor _httpContext;

        public GlobalService(dev_encrypted_generalcustomerappContext DataContext, IHttpContextAccessor HttpContext, IConfiguration Config)
        {
            _context = DataContext;
            _httpContext = HttpContext;
            _config = Config;
        }

        public IEnumerable<MstLanguage> GetAllLanguages()
        {
            return _context.MstLanguage.Where(x => x.ActiveflagC == "A");
        }

        public MstLanguage GetLanguageByCode(string Code)
        {
            return _context.MstLanguage.Where(x => x.LanguageCode == Code && x.ActiveflagC == "A").FirstOrDefault();
        }

        public IEnumerable<MstLanguage> GetLanguageListForCustomer(string LanguageCode, string CustomerCode)
        {

            List<MstLanguage> languages = new List<MstLanguage>();

                if (LanguageCode == null)
                {
                    var UserLanguagePreference = (from p in _context.MstCustprofile
                                                  where p.CustCodeVc == CustomerCode
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

        public string GetCustomerCode(string Token)
        {
            return "A000000490";
        }

        public string GetCustomerCode()
        {
            return DecryptString(_httpContext.HttpContext.User.Claims.Where(x => x.Type == "UserID").FirstOrDefault().Value).Result;
        }

        public double GetValidity()
        {
            return Convert.ToDouble(DecryptString(_httpContext.HttpContext.User.Claims.Where(x => x.Type == "Validity").FirstOrDefault().Value));
        }


        public async Task<string> DecryptString(string input)
        {
            try
            {
                string BaseURL = _config.GetValue<string>("DecryptionService:URL");

                BaseURL = BaseURL + input;

                if (input == null) return null;

                var EncryptionObject = new EncryptionModel
                {
                    Name = input
                };


                using (HttpClient _client = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Post, BaseURL);

                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

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
            string BaseURL = _config.GetValue<string>("EncryptionService:URL");

            BaseURL = BaseURL + input;

            if (input == null) return null;

            var EncryptionObject = new EncryptionModel
            {
                Name = input
            };

            using (HttpClient _client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, BaseURL);

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var ReqContent = JsonConvert.SerializeObject(EncryptionObject);

                var data = new StringContent(ReqContent, Encoding.UTF8, "application/json");

                var httpResponse = await _client.PostAsync(BaseURL, data);

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
