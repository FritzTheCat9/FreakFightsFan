﻿using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Features.Users.Responses;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FreakFightsFan.Api.Auth
{
    public interface IAuthenticator
    {
        JwtDto CreateToken(User user);
    }

    public class Authenticator : IAuthenticator
    {
        private readonly IClock _clock;
        private readonly AuthOptions _options;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly TimeSpan _expiry;
        private readonly SigningCredentials _signingCredencials;
        private readonly JwtSecurityTokenHandler _jwtHandler = new();

        public Authenticator(
            IClock clock,
            IOptions<AuthOptions> options)
        {
            _clock = clock;
            _options = options.Value;
            _issuer = _options.Issuer;
            _audience = _options.Audience;
            _expiry = _options.Expiry;
            _signingCredencials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.SigningKey)),
                SecurityAlgorithms.HmacSha256);
        }

        public JwtDto CreateToken(User user)
        {
            var now = _clock.Current();
            var expires = now.Add(_expiry);

            var claims = new List<Claim>()
            {
                new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new(JwtRegisteredClaimNames.UniqueName, user.Id.ToString()),
                new(ClaimTypes.Name, user.UserName),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Role, Policy.User),
            };

            if (user.IsAdmin)
                claims.Add(new(ClaimTypes.Role, Policy.Admin));

            if (user.IsSuperAdmin)
                claims.Add(new(ClaimTypes.Role, Policy.SuperAdmin));

            var jwt = new JwtSecurityToken(_issuer, _audience, claims, now, expires, _signingCredencials);
            var accessToken = _jwtHandler.WriteToken(jwt);

            return new() { AccessToken = accessToken };
        }
    }
}
