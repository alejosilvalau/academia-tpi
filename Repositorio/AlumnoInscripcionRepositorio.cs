using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Repositorio
{
    public class AlumnoInscripcionRepositorio : Repositorio<AlumnoInscripcion>, IRepositorio<AlumnoInscripcion>
    {
        public AlumnoInscripcionRepositorio(AcademiaContext ctx) : base(ctx) { }

        public List<AlumnoInscripcion> GetByAlumno(int alumnoId)
        {
            return context.AlumnoInscripciones
                .AsNoTracking()
                .Where(ai => ai.AlumnoId == alumnoId)
                .Include(ai => ai.Alumno)
                .Include(ai => ai.Curso)
                    .ThenInclude(c => c!.Materia)
                .Include(ai => ai.Curso)
                    .ThenInclude(c => c!.Comision)
                .ToList();
        }

        public List<AlumnoInscripcion> GetByCurso(int cursoId)
        {
            return context.AlumnoInscripciones
                .AsNoTracking()
                .Where(ai => ai.CursoId == cursoId)
                .Include(ai => ai.Alumno)
                .Include(ai => ai.Curso)
                    .ThenInclude(c => c!.Materia)
                .Include(ai => ai.Curso)
                    .ThenInclude(c => c!.Comision)
                .ToList();
        }

        public List<AlumnoInscripcion> GetAllConAlumnoYCurso()
        {
            return context.AlumnoInscripciones
                .AsNoTracking()
                .Include(ai => ai.Alumno)
                .Include(ai => ai.Curso)
                    .ThenInclude(c => c!.Materia)
                .Include(ai => ai.Curso)
                    .ThenInclude(c => c!.Comision)
                .ToList();
        }
    }
}
