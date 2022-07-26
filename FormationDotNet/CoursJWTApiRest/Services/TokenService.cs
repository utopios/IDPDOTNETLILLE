﻿using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoursJWTApiRest.Services
{
    public class TokenService
    {
        public string Authenticate(string username, string password)
        {
            if(username =="toto" && password=="tata")
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
                {
                    Expires = DateTime.Now.AddDays(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine de crypto")), SecurityAlgorithms.HmacSha256Signature),
                    Issuer = "m2i",
                    Audience = "m2i",
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("role", "admin")
                    })
                };

                SecurityToken token = tokenHandler.CreateToken(securityTokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            return null;
        }
    }
}
