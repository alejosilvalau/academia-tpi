using Dominio;
using Repositorio;

namespace Servicios
{
    public class InscripcionServicio
    {
        private AlumnoInscripcionRepositorio _repositorioInscripcion;
        private CursoRepositorio _repositorioCurso;

        public InscripcionServicio(AcademiaContext context)
        {
            _repositorioInscripcion = new AlumnoInscripcionRepositorio(context);
            _repositorioCurso = new CursoRepositorio(context);
        }

        public List<AlumnoInscripcion> GetAll()
        {
            return _repositorioInscripcion.GetAllConAlumnoYCurso();
        }

        public AlumnoInscripcion? GetOne(int id)
        {
            return _repositorioInscripcion.GetOne(id);
        }

        public List<AlumnoInscripcion> GetByAlumno(int alumnoId)
        {
            return _repositorioInscripcion.GetByAlumno(alumnoId);
        }

        public List<AlumnoInscripcion> GetByCurso(int cursoId)
        {
            return _repositorioInscripcion.GetByCurso(cursoId);
        }

        public void InscribirAlumno(int alumnoId, int cursoId)
        {
            var curso = _repositorioCurso.GetOne(cursoId);
            if (curso == null)
                throw new Exception("Curso no encontrado");

            var inscriptos = _repositorioInscripcion.GetByCurso(cursoId).Count;
            if (inscriptos >= curso.Cupo)
                throw new Exception("El curso no tiene cupo disponible");

            var inscripcion = new AlumnoInscripcion
            {
                AlumnoId = alumnoId,
                CursoId = cursoId,
                Condicion = AlumnoInscripcion.Condiciones.Inscripto
            };

            _repositorioInscripcion.Add(inscripcion);
            _repositorioInscripcion.Save();
        }

        public void Update(AlumnoInscripcion inscripcion)
        {
            _repositorioInscripcion.Update(inscripcion);
            _repositorioInscripcion.Save();
        }

        public void Delete(AlumnoInscripcion inscripcion)
        {
            _repositorioInscripcion.Delete(inscripcion);
            _repositorioInscripcion.Save();
        }
    }
}
