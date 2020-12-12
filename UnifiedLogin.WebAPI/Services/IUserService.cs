using System;
using UnifiedLogin.WebAPI.Entities;
using UnifiedLogin.WebAPI.Models;

namespace UnifiedLogin.WebAPI.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress);
        AuthenticateResponse RefreshToken(string token, string ipAddress);
        bool RevokeToken(string token, string ipAddress);
        User GetById(int id);
    }
}
