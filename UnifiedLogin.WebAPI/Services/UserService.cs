/**********Udhay working***********/

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using UnifiedLogin.WebAPI.Entities;
using UnifiedLogin.WebAPI.Helpers;
using UnifiedLogin.WebAPI.Models;
using UnifiedLogin.WebAPI.DataProvider;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace UnifiedLogin.WebAPI.Services
{
    public class UserService :IUserService
    {
        private readonly AppSettings _appSettings;
        
        private dev_encrypted_generalcustomerappContext _context;

        private readonly IGlobalService _global;

        private readonly DataContext _dataContext;

        private readonly IHttpContextAccessor _contextAccessor;

        public UserService(
            dev_encrypted_generalcustomerappContext context,
            IOptions<AppSettings> appSettings,
            IGlobalService Global,
            DataContext DataContext,
            IHttpContextAccessor ContextAccessor
            )
        {
            _context = context;
            _appSettings = appSettings.Value;
            _global = Global;
            _dataContext = DataContext;
            _contextAccessor = ContextAccessor;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model, string ipAddress)
        {
            if (!model.isSec)
            {
                model.Username = _global.EncryptString(model.Username).Result;
                model.Password = _global.EncryptString(model.Password).Result;
            }

            var user = (from p in _context.MstCustprofile
                        where p.MobileNoVc == model.Username
                        && p.Password == model.Password
                        select new User
                        {
                            Username = p.MobileNoVc,
                            Password = p.Password,
                            CustomerCode = p.CustCodeVc
                        }).FirstOrDefault();
            
            
            //var user = _context.Users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            if (user == null || user.Password != model.Password) return null;

            var jwtToken = generateJWTToken(user);
            var refreshToken = generateRefreshToken(ipAddress);

            user.RefreshTokens = new List<RefreshToken>();

            user.RefreshTokens.Add(refreshToken);
            _dataContext.Add(user);
            //_context.Update(user);
            _context.SaveChanges();
            _dataContext.SaveChanges();

            return new AuthenticateResponse(user, jwtToken, refreshToken.Token, _global.GetUnixTime(DateTime.Now));
        }



        public User GetById(int id)
        {
            return _dataContext.Users.Find(id); ;// _context.Users.Find(id);
        }

        public AuthenticateResponse RefreshToken(string token, string ipAddress)
        {
            var user = _dataContext.Users.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));// _context.Users.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

            // return null if no user found with token
            if (user == null) return null;
            var refreshToken = user.RefreshTokens.Single(x => x.Token == token);
            // return null if token is no longer active
            if (!refreshToken.IsActive) return null;

            // replace old refresh token with a new one and save
            var newRefreshToken = generateRefreshToken(ipAddress);
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.RevokedByIp = ipAddress;
            refreshToken.ReplacedByToken = newRefreshToken.Token;
            user.RefreshTokens.Add(newRefreshToken);
            _dataContext.Update(user);
            _dataContext.SaveChanges();

            // generate new jwt
            var jwtToken = generateJWTToken(user);

            return new AuthenticateResponse(user, jwtToken, newRefreshToken.Token, _global.GetUnixTime(DateTime.Now));
        }

        public bool RevokeToken(string token, string ipAddress)
        {
            var user = _dataContext.Users.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

            //var user = _context.Users.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

            // return false if no user found with token
            if (user == null) return false;

            var refreshToken = user.RefreshTokens.Single(x => x.Token == token);

            // return false if token is not active
            if (!refreshToken.IsActive) return false;

            // revoke token and save
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.RevokedByIp = ipAddress;
            _dataContext.Update(user);
            _dataContext.SaveChanges();

            return true;
        }

        private string generateJWTToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

            var Userclaims = new List<Claim>();

            Userclaims.Add(new Claim("UserID", _global.EncryptString(user.CustomerCode).Result));
            Userclaims.Add(new Claim("Validity", _global.EncryptString(_global.GetUnixTime(DateTime.Now).ToString()).Result));

            var appIdenity = new ClaimsIdentity(Userclaims);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)

            };

            var jwtToken = new JwtSecurityToken(
                claims: Userclaims,
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                );

            _contextAccessor.HttpContext.User.AddIdentity(appIdenity);

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(jwtToken);
        }

        private RefreshToken generateRefreshToken(string ipAddress)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                var randomBytes = new byte[64];
                rngCryptoServiceProvider.GetBytes(randomBytes);
                return new RefreshToken
                {
                    Token = Convert.ToBase64String(randomBytes),
                    Expires = DateTime.UtcNow.AddDays(7),
                    Created = DateTime.UtcNow,
                    CreatedByIp = ipAddress
                };
            }
        }
    }
}
