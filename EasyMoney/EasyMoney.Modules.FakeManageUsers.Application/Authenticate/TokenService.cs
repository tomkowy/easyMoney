using Common.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EasyMoney.Modules.FakeManageUsers.Application.Authenticate
{
    public class TokenService : ITokenService
    {
        private readonly IOptions<Authentication> _authenticationAppsettings;

        public TokenService(IOptions<Authentication> authenticationAppsettings)
        {
            _authenticationAppsettings = authenticationAppsettings;
        }

        public string GenerateJwtForUser(Guid userId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_authenticationAppsettings.Value.JwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(_authenticationAppsettings.Value.JwtExpireDays),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
