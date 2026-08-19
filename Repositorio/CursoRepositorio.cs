using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class CursoRepositorio : Repositorio<Curso>, IRepositorio<Curso>
    {
        public CursoRepositorio(AcademiaContext ctx) : base(ctx) { }

        public List<Curso> GetAllConMateriaYComision()
        {
            return context.Cursos
                .AsNoTracking()
                .Include(c => c.Materia)
                .Include(c => c.Comision)
                .ToList();
        }

        public Curso? GetOneConMateriaYComision(int id)
        {
            return context.Cursos
                .Include(c => c.Materia)
                .Include(c => c.Comision)
                .FirstOrDefault(c => c.ID == id);
        }

        public List<Curso> GetByMateriaYComision(int materiaId, int comisionId)
        {
            return context.Cursos
                .AsNoTracking()
                .Where(c => c.MateriaId == materiaId && c.ComisionId == comisionId)
                .Include(c => c.Materia)
                .Include(c => c.Comision)
                .ToList();
        }
    }
}
