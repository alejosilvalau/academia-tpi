using Dominio;
using Repositorio;
using Servicios.Excepciones;
using Utils;

namespace Servicios
{
    public class InscripcionServicio : ServicioBase
    {
        private AlumnoInscripcionRepositorio _repositorioInscripcion;
        private CursoRepositorio _repositorioCurso;
        private PersonaRepositorio _repositorioPersona;
        private DocenteCursoRepositorio _repositorioDocenteCurso;

        public InscripcionServicio(AcademiaContext context, IUsuarioContexto? usuarioContexto)
            : base(usuarioContexto)
        {
            _repositorioInscripcion = new AlumnoInscripcionRepositorio(context);
            _repositorioCurso = new CursoRepositorio(context);
            _repositorioPersona = new PersonaRepositorio(context);
            _repositorioDocenteCurso = new DocenteCursoRepositorio(context);
        }

        public List<AlumnoInscripcion> GetAll()
        {
            RequiereAdmin();
            return _repositorioInscripcion.GetAllConAlumnoYCurso();
        }

        public AlumnoInscripcion? GetOne(int id)
        {
            RequiereAdmin();
            return _repositorioInscripcion.GetOne(id);
        }

        public List<AlumnoInscripcion> GetByAlumno(int alumnoId)
        {
            RequiereAutenticacion();
            if (!EsAdmin() && PersonaIdActual() != alumnoId)
                throw new AccesoNoAutorizadoException("No puede consultar las inscripciones de otro alumno.");
            return _repositorioInscripcion.GetByAlumno(alumnoId);
        }

        public List<AlumnoInscripcion> GetByCurso(int cursoId)
        {
            RequiereAutenticacion();
            if (!EsAdmin() && !EsDocenteDelCurso(cursoId))
                throw new AccesoNoAutorizadoException("No puede consultar las inscripciones de un curso que no le está asignado.");
            return _repositorioInscripcion.GetByCurso(cursoId);
        }

        public void InscribirAlumno(int alumnoId, int cursoId)
        {
            ValidarBasicos(alumnoId, cursoId);
            RequiereAutenticacion();
            if (!EsAdmin() && PersonaIdActual() != alumnoId)
                throw new AccesoNoAutorizadoException("No puede inscribir a otro alumno.");
            ValidarReglasNegocio(alumnoId, cursoId);

            var inscripcion = new AlumnoInscripcion
            {
                AlumnoId = alumnoId,
                CursoId = cursoId,
                Condicion = AlumnoInscripcion.Condiciones.Inscripto
            };

            EjecutarPersistencia(() =>
            {
                _repositorioInscripcion.Add(inscripcion);
                _repositorioInscripcion.Save();
            }, "No se pudo concretar la inscripción. Intente nuevamente.");
        }

        public void Update(AlumnoInscripcion inscripcion)
        {
            ValidarBasicosActualizacion(inscripcion);
            RequiereAutenticacion();
            if (!EsAdmin() && !EsDocenteDelCurso(inscripcion.CursoId))
                throw new AccesoNoAutorizadoException("No puede modificar inscripciones de un curso que no le está asignado.");
            EjecutarPersistencia(() =>
            {
                _repositorioInscripcion.Update(inscripcion);
                _repositorioInscripcion.Save();
            }, "No se pudo actualizar la inscripción. Intente nuevamente.");
        }

        public void Delete(AlumnoInscripcion inscripcion)
        {
            RequiereAdmin();
            EjecutarPersistencia(() =>
            {
                _repositorioInscripcion.Delete(inscripcion);
                _repositorioInscripcion.Save();
            }, "No se pudo eliminar la inscripción. Intente nuevamente.");
        }

        private void ValidarBasicos(int alumnoId, int cursoId)
        {
            Validar(() =>
            {
                Validaciones.AsegurarPositivo(alumnoId, "Alumno");
                Validaciones.AsegurarPositivo(cursoId, "Curso");
            });
        }

        private void ValidarBasicosActualizacion(AlumnoInscripcion inscripcion)
        {
            Validar(() =>
            {
                if (inscripcion == null)
                    throw new ArgumentException("Los datos de la inscripción son obligatorios.");
                Validaciones.AsegurarPositivo(inscripcion.AlumnoId, "Alumno");
                Validaciones.AsegurarPositivo(inscripcion.CursoId, "Curso");
                if (inscripcion.Nota.HasValue)
                    Validaciones.AsegurarRangoEntero(inscripcion.Nota.Value, 1, 10, "Nota");
                ValidarCoherenciaNotaCondicion(inscripcion);
            });
        }

        private static void ValidarCoherenciaNotaCondicion(AlumnoInscripcion inscripcion)
        {
            if (!inscripcion.Nota.HasValue)
            {
                if (inscripcion.Condicion != AlumnoInscripcion.Condiciones.Inscripto)
                    throw new ArgumentException("Si no hay nota, la condición debe ser 'Inscripto'.");
                return;
            }
            var condicionEsperada = inscripcion.Nota.Value switch
            {
                >= 6 => AlumnoInscripcion.Condiciones.Aprobado,
                >= 4 => AlumnoInscripcion.Condiciones.Regular,
                _ => AlumnoInscripcion.Condiciones.Inscripto
            };
            if (inscripcion.Condicion != condicionEsperada)
                throw new ArgumentException($"La nota {inscripcion.Nota.Value} no corresponde con la condición '{inscripcion.Condicion}'.");
        }

        private void ValidarReglasNegocio(int alumnoId, int cursoId)
        {
            var alumno = _repositorioPersona.GetOne(alumnoId);
            if (alumno == null)
                throw new ReglaNegocioException("El alumno especificado no existe.");
            if (alumno.Tipo != Persona.TiposPersonas.Alumno)
                throw new ReglaNegocioException("La persona seleccionada no es de tipo alumno.");

            var curso = _repositorioCurso.GetOne(cursoId);
            if (curso == null)
                throw new ReglaNegocioException("El curso no existe.");

            var inscriptos = _repositorioInscripcion.GetByCurso(cursoId).Count;
            if (inscriptos >= curso.Cupo)
                throw new ReglaNegocioException("El curso no tiene cupo disponible.");

            var yaInscripto = _repositorioInscripcion.GetByAlumno(alumnoId).Any(ai => ai.CursoId == cursoId);
            if (yaInscripto)
                throw new ReglaNegocioException("El alumno ya está inscripto en ese curso.");
        }

        private bool EsDocenteDelCurso(int cursoId)
        {
            if (TipoUsuarioActual() != Persona.TiposPersonas.Docente) return false;
            var docenteId = PersonaIdActual();
            if (!docenteId.HasValue) return false;
            return _repositorioDocenteCurso.GetByCurso(cursoId).Any(dc => dc.DocenteId == docenteId.Value);
        }
    }
}
