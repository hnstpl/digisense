using System;
using System.Text.Json.Serialization;
using UnifiedLogin.WebAPI.Entities;

namespace UnifiedLogin.WebAPI.Models
{
    public class AuthenticateResponse
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public string FirstName { get; set; }
        [JsonIgnore]
        public string LastName { get; set; }
        [JsonIgnore]
        public string Username { get; set; }
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        [JsonIgnore]
        public double? GeneratedDate { get; set; }
        //[JsonIgnore]
        public string RefreshToken { get; set; }

        public AuthenticateResponse(User user, string jwtToken, string refreshToken, double? generatedDate)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            access_token = jwtToken;
            token_type = "bearer";
            expires_in = Convert.ToInt32((DateTime.Now.AddMinutes(30) - DateTime.Now).TotalSeconds);
            RefreshToken = refreshToken;
            GeneratedDate = generatedDate;
        }
    }
}
