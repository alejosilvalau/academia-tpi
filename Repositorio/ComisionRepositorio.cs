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
                .Include(c => c.Plan)
                .ToList();
        }

        public List<Comision> GetByPlan(int planId)
        {
            return context.Comisiones
                .Where(c => c.PlanId == planId)
                .Include(c => c.Plan)
                .ToList();
        }
    }
}
