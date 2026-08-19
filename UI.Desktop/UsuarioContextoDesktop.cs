using Dominio;
using Servicios;

namespace UI.Desktop
{
    public class UsuarioContextoDesktop : IUsuarioContexto
    {
        public Usuario? ObtenerUsuarioActual() => Login.UsuarioActual;
    }
}
