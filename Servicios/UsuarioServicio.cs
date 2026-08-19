using Dominio;
using Repositorio;
using Servicios.Excepciones;
using Utils;

namespace Servicios
{
    public class UsuarioServicio : ServicioBase
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
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ValidacionException("El nombre de usuario es obligatorio.");
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
            ValidarBasicos(usuario);
            ValidarFormato(usuario);
            ValidarReglasNegocio(usuario, esAlta: true);
            EjecutarPersistencia(() =>
            {
                _repositorio.Add(usuario);
                _repositorio.Save();
            }, "No se pudo guardar el usuario. Intente nuevamente.");
        }

        public void Update(Usuario usuario)
        {
            ValidarBasicos(usuario);
            ValidarFormato(usuario);
            ValidarReglasNegocio(usuario, esAlta: false);
            EjecutarPersistencia(() =>
            {
                _repositorio.Update(usuario);
                _repositorio.Save();
            }, "No se pudo actualizar el usuario. Intente nuevamente.");
        }

        public void Delete(Usuario usuario)
        {
            ValidarEliminacion(usuario);
            EjecutarPersistencia(() =>
            {
                _repositorio.Delete(usuario);
                _repositorio.Save();
            }, "No se pudo eliminar el usuario. Intente nuevamente.");
        }

        private void ValidarBasicos(Usuario usuario)
        {
            Validar(() =>
            {
                if (usuario == null)
                    throw new ArgumentException("Los datos del usuario son obligatorios.");
                Validaciones.AsegurarNoVacio(usuario.NombreUsuario, "Nombre de usuario");
                Validaciones.AsegurarNoVacio(usuario.Clave, "Clave");
                if (!usuario.PersonaId.HasValue || usuario.PersonaId <= 0)
                    throw new ArgumentException("El usuario debe estar asociado a una persona.");
            });
        }

        private void ValidarFormato(Usuario usuario)
        {
            Validar(() =>
            {
                Validaciones.AsegurarLongitudUsuario(usuario.NombreUsuario);
                Validaciones.AsegurarClave(usuario.Clave);
            });
        }

        private void ValidarReglasNegocio(Usuario usuario, bool esAlta)
        {
            var existente = _repositorio.GetByUsername(usuario.NombreUsuario);
            if (existente != null && existente.ID != usuario.ID)
                throw new ReglaNegocioException($"El nombre de usuario '{usuario.NombreUsuario}' ya existe.");

            if (!esAlta)
                ValidarUltimoAdministrador(usuario.ID, deshabilitando: !usuario.Habilitado);
        }

        private void ValidarEliminacion(Usuario usuario)
        {
            ValidarUltimoAdministrador(usuario.ID, deshabilitando: true);
        }

        private void ValidarUltimoAdministrador(int usuarioId, bool deshabilitando)
        {
            if (!deshabilitando) return;

            var adminsHabilitados = _repositorio.GetHabilitadosConPersonaAsNoTracking()
                .Where(u => u.Persona != null && u.Persona.Tipo == Persona.TiposPersonas.Administrador)
                .ToList();
            if (!adminsHabilitados.Any(u => u.ID == usuarioId)) return;
            if (adminsHabilitados.Count <= 1)
                throw new ReglaNegocioException("No se puede deshabilitar o eliminar: es el único administrador habilitado.");
        }
    }
}
