using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Http;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using UnifiedLogin.WebAPI.Models;
using System.Text;

namespace UnifiedLogin.WebAPI.Services
{
    public class GlobalService : IGlobalService
    {
        private readonly IConfiguration _config;

        static readonly HttpClient client = new HttpClient();

        public static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public GlobalService(IConfiguration Config)
        {
            _config = Config;
        }

        public async Task<string> DecryptString(string input)
        {
            try
            {
                string BaseURL = _config.GetValue<string>("DecryptionService:URL");

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
            string BaseURL = _config.GetValue<string>("EncryptionService:URL");

            BaseURL = string.Format(BaseURL, input);

            using (HttpClient _client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, BaseURL);

                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                request.Headers.Add("API-Key", (Convert.ToInt32(GetUnixTime(DateTime.Now))+25000).ToString());

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
