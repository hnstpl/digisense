using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Profile.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Profile.WebAPI.DataProvider;

namespace Profile.WebAPI.Services
{
    public class GlobalService : IGlobalService
    {
        private readonly IConfiguration _config;

        private readonly IHttpContextAccessor _httpContext;

        private readonly dev_encrypted_generalcustomerappContext _context;
        

        public static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);



        public GlobalService(IConfiguration Config, IHttpContextAccessor HttpContext, dev_encrypted_generalcustomerappContext Context)
        {
            _config = Config;
            _httpContext = HttpContext;
            _context = Context;
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

        public string GetCustomerCode()
        {
            return DecryptString(_httpContext.HttpContext.User.Claims.Where(x => x.Type == "UserID").FirstOrDefault().Value).Result;
        }

        public int GetLanguagePreference(string CustomerCode)
        {
            var LanguagePreference = (from p in _context.MstCustprofile
                                      where p.CustCodeVc == CustomerCode
                                      && p.ActiveFlagC == "A"
                                      select p.LanguagePreference).FirstOrDefault();

            return LanguagePreference.Value;
        }

        public bool IsUserLangAvail(string CustomerCode, int LanguageID)
        {
            return _context.MstCustprofileLang.Where(x => x.MstLangId == LanguageID && x.CustCodeVc == CustomerCode).FirstOrDefault() != null ? true : false;
        }

        public MstEducation GetEducationByID(int ID)
        {
            var educationValue = (from p in _context.MstEducation
                                  where p.ActiveflagC == "A"
                                  && p.Id == ID
                                  select p).FirstOrDefault();

            return educationValue;
        }
    }
}
