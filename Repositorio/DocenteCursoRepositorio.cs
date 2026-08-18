using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class DocenteCursoRepositorio : Repositorio<DocenteCurso>, IRepositorio<DocenteCurso>
    {
        public DocenteCursoRepositorio(AcademiaContext ctx) : base(ctx) { }

        public List<DocenteCurso> GetByDocente(int docenteId)
        {
            return context.DocenteCursos
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
                .Include(dc => dc.Curso)
                    .ThenInclude(c => c!.Materia)
                .Include(dc => dc.Curso)
                    .ThenInclude(c => c!.Comision)
                .Include(dc => dc.Docente)
                .ToList();
        }
    }
}
