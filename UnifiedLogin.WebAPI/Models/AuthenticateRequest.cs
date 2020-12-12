using System;
using System.ComponentModel.DataAnnotations;

namespace UnifiedLogin.WebAPI.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Grant_type { get; set; }
        public string RequestedFrom { get; set; }
        public bool isSec { get; set; }
        public string Refresh_token { get; set; }
        public string DeviceID { get; set; }
    }
}
