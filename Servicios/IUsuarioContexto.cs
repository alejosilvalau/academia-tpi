using Dominio;

namespace Servicios
{
    public interface IUsuarioContexto
    {
        Usuario? ObtenerUsuarioActual();
    }
}
