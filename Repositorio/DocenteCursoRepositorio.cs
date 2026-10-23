using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class DocenteCursoRepositorio : Repositorio<DocenteCurso>, IRepositorio<DocenteCurso>
    {
        public DocenteCursoRepositorio(AcademiaContext ctx) : base(ctx) { }

        public int? GetCursoIdActual(int id)
        {
            return context.DocenteCursos
                .AsNoTracking()
                .Where(dc => dc.ID == id)
                .Select(dc => (int?)dc.CursoId)
                .FirstOrDefault();
        }

        public List<DocenteCurso> GetByDocente(int docenteId)
        {
            return context.DocenteCursos
                .AsNoTracking()
                .Where(dc => dc.DocenteId == docenteId)
                .Include(dc => dc.Curso)
                    .ThenInclude(c => c!.Materia)
                .Include(dc => dc.Curso)
                    .ThenInclude(c => c!.Comision)
                .Include(dc => dc.Docente)
                .ToList();
        }

        public List<DocenteCurso> GetByCurso(int cursoId)
        {
            return context.DocenteCursos
                .AsNoTracking()
                .Where(dc => dc.CursoId == cursoId)
                .Include(dc => dc.Curso)
                    .ThenInclude(c => c!.Materia)
                .Include(dc => dc.Curso)
                    .ThenInclude(c => c!.Comision)
                .Include(dc => dc.Docente)
                .ToList();
        }

        public List<DocenteCurso> GetAllConCursoYDocente()
        {
            return context.DocenteCursos
                .AsNoTracking()
                .Include(dc => dc.Curso)
                    .ThenInclude(c => c!.Materia)
                .Include(dc => dc.Curso)
                    .ThenInclude(c => c!.Comision)
                .Include(dc => dc.Docente)
                .ToList();
        }
    }
}
