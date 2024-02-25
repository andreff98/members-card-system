using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EvceApi.Business.Exceptions;
using Microsoft.IdentityModel.Tokens;

namespace EvceApi.Business.Services;

public class JwtService(string? key, string? issuer, string? audience, IUserService userService) : IJwtService
{
    public string? GenerateJwtToken(string? username)
    {
        if (string.IsNullOrEmpty(key))
            throw new JwtTokenNotFound();
        
        // var user = userService.GetUserAsync()
            
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("user", username ?? string.Empty),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }),
            Expires = DateTime.UtcNow.AddSeconds(60),
            Issuer = issuer,
            Audience = audience,
            SigningCredentials = credentials
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var jwtToken = tokenHandler.WriteToken(token);
        
        return jwtToken;
    }
}