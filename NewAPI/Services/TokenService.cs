using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using NewAPI.Entities;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Services;

public class TokenService(JwtSecurityTokenHandler handler) : ITokenService
{
    public string GenerateToken(User user)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ew54rw8(7,nb7u9342@fh2340oghno0w(e"));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Email, user.Email!)
        };
        
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            SigningCredentials = credentials,
            IssuedAt = DateTime.UtcNow,
            Expires = DateTime.UtcNow.AddHours(2),
            Subject = new ClaimsIdentity(claims)
        };
        var token = handler.CreateToken(tokenDescriptor);
        return handler.WriteToken(token);
    }
}