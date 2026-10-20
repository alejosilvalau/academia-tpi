using System.Security.Claims;
using Contratos;
using Microsoft.AspNetCore.Components.Authorization;

namespace UI.Web.Services
{
    public class SesionService : AuthenticationStateProvider, IApiTokenProvider
    {
        private LoginResponse? _sesion;

        public string? Token => _sesion?.Token;
        public LoginResponse? Perfil => _sesion;
        public int? PersonaId => _sesion?.PersonaId;
        public TipoPersona? TipoUsuario => _sesion?.Tipo;
        public string? NombreUsuario => _sesion?.NombreUsuario;
        public bool IsLoggedIn => _sesion != null;
        public bool IsAdmin => TipoUsuario == TipoPersona.Administrador;
        public bool IsAlumno => TipoUsuario == TipoPersona.Alumno;
        public bool IsDocente => TipoUsuario == TipoPersona.Docente;

        public bool ValidarPermisos(TipoPersona tipoRequerido) => IsAdmin || TipoUsuario == tipoRequerido;

        public void Iniciar(LoginResponse sesion)
        {
            _sesion = sesion;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public void Invalidar()
        {
            _sesion = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return Task.FromResult(new AuthenticationState(ConstruirPrincipal(_sesion)));
        }

        private static ClaimsPrincipal ConstruirPrincipal(LoginResponse? sesion)
        {
            if (sesion == null)
            {
                return new ClaimsPrincipal(new ClaimsIdentity());
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, sesion.NombreUsuario),
                new Claim(ClaimTypes.NameIdentifier, (sesion.PersonaId ?? 0).ToString()),
                new Claim(ClaimTypes.Role, (sesion.Tipo ?? TipoPersona.Alumno).ToString()),
                new Claim("Nombre", sesion.Nombre ?? ""),
                new Claim("Apellido", sesion.Apellido ?? ""),
                new Claim("Legajo", (sesion.Legajo ?? 0).ToString()),
                new Claim("PersonaId", (sesion.PersonaId ?? 0).ToString())
            };
            return new ClaimsPrincipal(new ClaimsIdentity(claims, "AcademiaTPI.Api"));
        }
    }
}
