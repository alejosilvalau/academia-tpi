using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class ComisionRepositorio : Repositorio<Comision>, IRepositorio<Comision>
    {
        public ComisionRepositorio(AcademiaContext ctx) : base(ctx) { }

        public List<Comision> GetAllConPlan()
        {
            return context.Comisiones
                .AsNoTracking()
                .Include(c => c.Plan)
                .ToList();
        }

        public List<Comision> GetByPlan(int planId)
        {
            return context.Comisiones
                .AsNoTracking()
                .Where(c => c.PlanId == planId)
                .Include(c => c.Plan)
                .ToList();
        }
    }
}
