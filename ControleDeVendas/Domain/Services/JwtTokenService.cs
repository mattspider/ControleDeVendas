using ControleDeVendas.Configuration;
using ControleDeVendas.Domain.Interfaces.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ControleDeVendas.Domain.Services
{
    public class JwtTokenService : IJwtTokenService
    {
        private readonly JwtSettings _JwtSettings;

        public JwtTokenService(IOptions<JwtSettings> jwtSettings)
        {
            _JwtSettings = jwtSettings.Value;
        }

        public string GerarToken(string usuario)
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.Name, usuario),
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_JwtSettings.Segredo));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _JwtSettings.Emissor,
                audience: _JwtSettings.Audiencia,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_JwtSettings.ExpiracaoHoras),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
