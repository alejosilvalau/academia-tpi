using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Dominio;
using Microsoft.IdentityModel.Tokens;

namespace UI.Api.Auth
{
    public class JwtTokenService
    {
        private readonly IConfiguration _config;

        public JwtTokenService(IConfiguration config)
        {
            _config = config;
        }

        public string GenerarToken(Usuario usuario)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, usuario.NombreUsuario),
                new Claim(ClaimTypes.Name, usuario.NombreUsuario),
                new Claim(ClaimTypes.NameIdentifier, (usuario.PersonaId ?? 0).ToString()),
                new Claim(ClaimTypes.Role, (usuario.Persona?.Tipo ?? Persona.TiposPersonas.Alumno).ToString()),
                new Claim("Nombre", usuario.Persona?.Nombre ?? ""),
                new Claim("Apellido", usuario.Persona?.Apellido ?? ""),
                new Claim("Legajo", (usuario.Persona?.Legajo ?? 0).ToString()),
                new Claim("PersonaId", (usuario.PersonaId ?? 0).ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expire = int.TryParse(_config["Jwt:ExpireMinutes"], out var min)
                ? min
                : 60;

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(expire),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}