using Dominio;
using Repositorio;
using Servicios.Excepciones;
using Utils;

namespace Servicios
{
    public class MateriaServicio : ServicioBase
    {
        private MateriaRepositorio _repositorio;

        public MateriaServicio(AcademiaContext context)
        {
            _repositorio = new MateriaRepositorio(context);
        }

        public List<Materia> GetAll()
        {
            return _repositorio.GetAllConPlan();
        }

        public Materia? GetOne(int id)
        {
            return _repositorio.GetOne(id);
        }

        public List<Materia> GetByPlan(int planId)
        {
            return _repositorio.GetByPlan(planId);
        }

        public void Save(Materia materia)
        {
            ValidarBasicos(materia);
            ValidarFormato(materia);
            EjecutarPersistencia(() =>
            {
                _repositorio.Add(materia);
                _repositorio.Save();
            }, "No se pudo guardar la materia. Intente nuevamente.");
        }

        public void Update(Materia materia)
        {
            ValidarBasicos(materia);
            ValidarFormato(materia);
            EjecutarPersistencia(() =>
            {
                _repositorio.Update(materia);
                _repositorio.Save();
            }, "No se pudo actualizar la materia. Intente nuevamente.");
        }

        public void Delete(Materia materia)
        {
            EjecutarPersistencia(() =>
            {
                _repositorio.Delete(materia);
                _repositorio.Save();
            }, "No se pudo eliminar la materia. Intente nuevamente.");
        }

        private void ValidarBasicos(Materia materia)
        {
            Validar(() =>
            {
                if (materia == null)
                    throw new ArgumentException("Los datos de la materia son obligatorios.");
                Validaciones.AsegurarNoVacio(materia.Descripcion, "Descripción");
                Validaciones.AsegurarPositivo(materia.PlanId, "Plan");
                Validaciones.AsegurarPositivo(materia.HorasSemanales, "Horas semanales");
                Validaciones.AsegurarPositivo(materia.HorasTotales, "Horas totales");
            });
        }

        private void ValidarFormato(Materia materia)
        {
            Validar(() =>
            {
                Validaciones.AsegurarDescripcion(materia.Descripcion, "Descripción");
                Validaciones.AsegurarRangoEntero(materia.HorasSemanales, 1, 40, "Horas semanales");
                Validaciones.AsegurarRangoEntero(materia.HorasTotales, 1, 1000, "Horas totales");
                if (materia.HorasTotales < materia.HorasSemanales)
                    throw new ArgumentException("Las horas totales no pueden ser menores que las horas semanales.");
            });
        }
    }
}
