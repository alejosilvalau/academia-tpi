using System.Security.Claims;
using Dominio;
using Microsoft.AspNetCore.Components.Authorization;

namespace UI.Web.Services
{
    public class SesionService
    {
        private readonly AuthenticationStateProvider _authStateProvider;
        private ClaimsPrincipal? _cachedPrincipal;
        private bool _cargado;

        public SesionService(AuthenticationStateProvider authStateProvider)
        {
            _authStateProvider = authStateProvider;
        }

        private ClaimsPrincipal? ObtenerPrincipal()
        {
            if (_cargado) return _cachedPrincipal;

            var task = _authStateProvider.GetAuthenticationStateAsync();
            // El estado ya está completado cuando Blazor renderiza el circuito.
            var state = task.IsCompleted
                ? task.Result
                : task.GetAwaiter().GetResult();

            _cachedPrincipal = state.User;
            _cargado = true;
            return _cachedPrincipal;
        }

        public Usuario? UsuarioActual
        {
            get
            {
                var p = ObtenerPrincipal();
                if (p?.Identity?.IsAuthenticated != true) return null;

                var personaId = int.TryParse(p.FindFirst("PersonaId")?.Value, out var pid) ? pid :
                    (int.TryParse(p.FindFirst(ClaimTypes.NameIdentifier)?.Value, out var id) ? id : 0);

                return new Usuario
                {
                    NombreUsuario = p.Identity.Name ?? "",
                    PersonaId = personaId,
                    Persona = new Persona
                    {
                        ID = personaId,
                        Nombre = p.FindFirst("Nombre")?.Value ?? "",
                        Apellido = p.FindFirst("Apellido")?.Value ?? "",
                        Legajo = int.TryParse(p.FindFirst("Legajo")?.Value, out var leg) ? leg : 0,
                        Tipo = ObtenerTipo(p) ?? Persona.TiposPersonas.Alumno
                    }
                };
            }
        }

        public bool IsLoggedIn => ObtenerPrincipal()?.Identity?.IsAuthenticated == true;

        public Persona.TiposPersonas? TipoUsuario => ObtenerTipo(ObtenerPrincipal());

        public bool IsAdmin => TipoUsuario == Persona.TiposPersonas.Administrador;
        public bool IsAlumno => TipoUsuario == Persona.TiposPersonas.Alumno;
        public bool IsDocente => TipoUsuario == Persona.TiposPersonas.Docente;

        public bool ValidarPermisos(Persona.TiposPersonas tipoRequerido)
        {
            return IsAdmin || TipoUsuario == tipoRequerido;
        }

        public void Invalidar()
        {
            _cargado = false;
            _cachedPrincipal = null;
        }

        private static Persona.TiposPersonas? ObtenerTipo(ClaimsPrincipal? principal)
        {
            if (principal?.Identity?.IsAuthenticated != true) return null;
            var role = principal.FindFirst(ClaimTypes.Role)?.Value;
            return Enum.TryParse<Persona.TiposPersonas>(role, out var tipo) ? tipo : null;
        }
    }
}
