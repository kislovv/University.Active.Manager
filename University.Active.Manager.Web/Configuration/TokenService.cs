using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using University.Active.Manager.Abstraction;
using University.Active.Manager.Entity;

namespace University.Active.Manager.Web.Configuration;

public class TokenService : ITokenService
{
    private readonly TokenOptions _tokenOptions;
    public TokenService(IOptionsMonitor<TokenOptions> optionsMonitor)
    {
        _tokenOptions = optionsMonitor.CurrentValue;
    }
    public string BuildToken(User user)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, user.FirstName),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Role, user.Role),
            new Claim(ClaimTypes.Email, user.Email)
        };

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.Key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        var tokenDescriptor = new JwtSecurityToken(_tokenOptions.Issuer, _tokenOptions.Audience, claims,
            expires: DateTime.Now.Add(_tokenOptions.ExpiryDuration), signingCredentials: credentials);
        return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
    }
}