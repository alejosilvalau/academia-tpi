using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class PersonaRepositorio : Repositorio<Persona>, IRepositorio<Persona>
    {
        public PersonaRepositorio(AcademiaContext ctx) : base(ctx) { }

        public List<Persona> GetByTipo(Persona.TiposPersonas tipo)
        {
            return context.Personas
                .Where(p => p.Tipo == tipo)
                .Include(p => p.Plan)
                .ToList();
        }

        public List<Persona> GetByPlan(int? planId)
        {
            return context.Personas
                .Where(p => p.PlanId == planId)
                .Include(p => p.Plan)
                .ToList();
        }

        public Persona? GetByLegajo(int legajo)
        {
            return context.Personas
                .Include(p => p.Plan)
                .FirstOrDefault(p => p.Legajo == legajo);
        }

        public List<Persona> GetAllConPlan()
        {
            return context.Personas
                .Include(p => p.Plan)
                .ToList();
        }
    }
}
