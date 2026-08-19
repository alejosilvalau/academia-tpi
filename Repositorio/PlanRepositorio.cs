using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class PlanRepositorio : Repositorio<Plan>, IRepositorio<Plan>
    {
        public PlanRepositorio(AcademiaContext ctx) : base(ctx) { }

        public List<Plan> GetAllConEspecialidad()
        {
            return context.Planes
                .Include(p => p.Especialidad)
                .ToList();
        }

        public List<Plan> GetByEspecialidad(int especialidadId)
        {
            return context.Planes
                .Where(p => p.EspecialidadId == especialidadId)
                .Include(p => p.Especialidad)
                .ToList();
        }
    }
}
