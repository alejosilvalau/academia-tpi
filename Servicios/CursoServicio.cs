using Dominio;
using Repositorio;
using Servicios.Excepciones;
using Utils;

namespace Servicios
{
    public class CursoServicio : ServicioBase
    {
        private CursoRepositorio _repositorio;
        private AlumnoInscripcionRepositorio _repositorioInscripciones;

        public CursoServicio(AcademiaContext context)
        {
            _repositorio = new CursoRepositorio(context);
            _repositorioInscripciones = new AlumnoInscripcionRepositorio(context);
        }

        public List<Curso> GetAll()
        {
            return _repositorio.GetAllConMateriaYComision();
        }

        public Curso? GetOne(int id)
        {
            return _repositorio.GetOneConMateriaYComision(id);
        }

        public List<Curso> GetByMateriaYComision(int materiaId, int comisionId)
        {
            return _repositorio.GetByMateriaYComision(materiaId, comisionId);
        }

        public void Save(Curso curso)
        {
            ValidarBasicos(curso);
            ValidarFormato(curso);
            ValidarReglasNegocio(curso, esAlta: true);
            EjecutarPersistencia(() =>
            {
                _repositorio.Add(curso);
                _repositorio.Save();
            }, "No se pudo guardar el curso. Intente nuevamente.");
        }

        public void Update(Curso curso)
        {
            ValidarBasicos(curso);
            ValidarFormato(curso);
            ValidarReglasNegocio(curso, esAlta: false);
            EjecutarPersistencia(() =>
            {
                _repositorio.Update(curso);
                _repositorio.Save();
            }, "No se pudo actualizar el curso. Intente nuevamente.");
        }

        public void Delete(Curso curso)
        {
            EjecutarPersistencia(() =>
            {
                _repositorio.Delete(curso);
                _repositorio.Save();
            }, "No se pudo eliminar el curso. Intente nuevamente.");
        }

        private void ValidarBasicos(Curso curso)
        {
            Validar(() =>
            {
                if (curso == null)
                    throw new ArgumentException("Los datos del curso son obligatorios.");
                Validaciones.AsegurarPositivo(curso.AnioCalendario, "Año calendario");
                Validaciones.AsegurarPositivo(curso.Cupo, "Cupo");
                Validaciones.AsegurarPositivo(curso.MateriaId, "Materia");
                Validaciones.AsegurarPositivo(curso.ComisionId, "Comisión");
            });
        }

        private void ValidarFormato(Curso curso)
        {
            Validar(() =>
            {
                Validaciones.AsegurarRangoEntero(curso.AnioCalendario, 2000, 2100, "Año calendario");
                Validaciones.AsegurarRangoEntero(curso.Cupo, 1, 500, "Cupo");
            });
        }

        private void ValidarReglasNegocio(Curso curso, bool esAlta)
        {
            var duplicado = _repositorio.GetByMateriaYComision(curso.MateriaId, curso.ComisionId)
                .FirstOrDefault(c => c.AnioCalendario == curso.AnioCalendario && c.ID != curso.ID);
            if (duplicado != null)
                throw new ReglaNegocioException("Ya existe un curso para esa materia, comisión y año calendario.");

            if (!esAlta)
            {
                var inscriptos = _repositorioInscripciones.GetByCurso(curso.ID).Count;
                if (curso.Cupo < inscriptos)
                    throw new ReglaNegocioException($"El cupo no puede ser menor a la cantidad de inscriptos actuales ({inscriptos}).");
            }
        }
    }
}
