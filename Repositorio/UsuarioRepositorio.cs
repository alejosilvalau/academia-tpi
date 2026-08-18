using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IRepositorio<Usuario>
    {
        public UsuarioRepositorio(AcademiaContext ctx) : base(ctx) { }

        public List<Usuario> GetAllConPersona()
        {
            return context.Usuarios
                .Include(u => u.Persona)
                .ToList();
        }

        public Usuario? GetByUsername(string nombreUsuario)
        {
            return context.Usuarios
                .Include(u => u.Persona)
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }

        public Usuario? GetOneConPersona(int id)
        {
            return context.Usuarios
                .Include(u => u.Persona)
                .FirstOrDefault(u => u.ID == id);
        }
    }
}
