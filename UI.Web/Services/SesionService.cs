using Dominio;

namespace UI.Web.Services
{
    public class SesionService
    {
        private Usuario? _usuarioActual;

        public Usuario? UsuarioActual => _usuarioActual;

        public bool IsLoggedIn => _usuarioActual != null;

        public Persona.TiposPersonas? TipoUsuario => _usuarioActual?.Persona?.Tipo;

        public bool IsAdmin => TipoUsuario == Persona.TiposPersonas.Administrador;
        public bool IsAlumno => TipoUsuario == Persona.TiposPersonas.Alumno;
        public bool IsDocente => TipoUsuario == Persona.TiposPersonas.Docente;

        public void Login(Usuario usuario)
        {
            _usuarioActual = usuario;
        }

        public void Logout()
        {
            _usuarioActual = null;
        }
    }
}
