using Dominio;
using Repositorio;

namespace Servicios
{
    public class UsuarioServicio
    {
        private UsuarioRepositorio _repositorio;

        public UsuarioServicio(AcademiaContext context)
        {
            _repositorio = new UsuarioRepositorio(context);
        }

        public List<Usuario> GetAll()
        {
            return _repositorio.GetAllConPersona();
        }

        public Usuario? GetOne(int id)
        {
            return _repositorio.GetOneConPersona(id);
        }

        public Usuario? GetByUsername(string nombreUsuario)
        {
            return _repositorio.GetByUsername(nombreUsuario);
        }

        public Usuario? Login(string nombreUsuario, string clave)
        {
            var usuario = _repositorio.GetByUsername(nombreUsuario);
            if (usuario != null && usuario.Habilitado && usuario.Clave == clave)
            {
                return usuario;
            }
            return null;
        }

        public void Save(Usuario usuario)
        {
            _repositorio.Add(usuario);
            _repositorio.Save();
        }

        public void Update(Usuario usuario)
        {
            _repositorio.Update(usuario);
            _repositorio.Save();
        }

        public void Delete(Usuario usuario)
        {
            _repositorio.Delete(usuario);
            _repositorio.Save();
        }
    }
}
