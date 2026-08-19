using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class MateriaRepositorio : Repositorio<Materia>, IRepositorio<Materia>
    {
        public MateriaRepositorio(AcademiaContext ctx) : base(ctx) { }

        public List<Materia> GetAllConPlan()
        {
            return context.Materias
                .AsNoTracking()
                .Include(m => m.Plan)
                .ToList();
        }

        public List<Materia> GetByPlan(int planId)
        {
            return context.Materias
                .AsNoTracking()
                .Where(m => m.PlanId == planId)
                .Include(m => m.Plan)
                .ToList();
        }
    }
}
