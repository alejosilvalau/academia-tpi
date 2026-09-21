using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class EspecialidadRepositorio : Repositorio<Especialidad>, IRepositorio<Especialidad>
    {
        public EspecialidadRepositorio(AcademiaContext ctx) : base(ctx) { }

        public Especialidad? GetByDescripcion(string descripcion)
        {
            return context.Especialidades
                .AsNoTracking()
                .FirstOrDefault(e => e.Descripcion == descripcion);
        }
    }
}
