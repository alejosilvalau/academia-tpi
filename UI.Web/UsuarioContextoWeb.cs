using Dominio;
using Servicios;
using UI.Web.Services;

namespace UI.Web
{
    public class UsuarioContextoWeb : IUsuarioContexto
    {
        private readonly SesionService _sesion;

        public UsuarioContextoWeb(SesionService sesion)
        {
            _sesion = sesion;
        }

        public Usuario? ObtenerUsuarioActual() => _sesion.UsuarioActual;
    }
}
