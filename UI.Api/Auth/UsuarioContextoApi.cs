using Dominio;
using Microsoft.EntityFrameworkCore;
using Repositorio;
using Servicios;

namespace UI.Api.Auth
{
    public class UsuarioContextoApi : IUsuarioContexto
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AcademiaContext _context;

        public UsuarioContextoApi(IHttpContextAccessor httpContextAccessor, AcademiaContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public Usuario? ObtenerUsuarioActual()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            var nombreUsuario = httpContext?.User?.Identity?.IsAuthenticated == true
                ? httpContext.User.Identity.Name
                : null;

            if (string.IsNullOrWhiteSpace(nombreUsuario))
                return null;

            return _context.Usuarios
                .AsNoTracking()
                .Include(u => u.Persona)
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }
    }
}