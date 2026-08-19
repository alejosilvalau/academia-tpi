using Dominio;
using Repositorio;
using Servicios.Excepciones;
using Utils;

namespace Servicios
{
    public class PlanServicio : ServicioBase
    {
        private PlanRepositorio _repositorio;

        public PlanServicio(AcademiaContext context, IUsuarioContexto? usuarioContexto)
            : base(usuarioContexto)
        {
            _repositorio = new PlanRepositorio(context);
        }

        public List<Plan> GetAll()
        {
            RequiereAdminOAlumno();
            return _repositorio.GetAllConEspecialidad();
        }

        public Plan? GetOne(int id)
        {
            RequiereAdminOAlumno();
            return _repositorio.GetOne(id);
        }

        public List<Plan> GetByEspecialidad(int especialidadId)
        {
            RequiereAdminOAlumno();
            return _repositorio.GetByEspecialidad(especialidadId);
        }

        public void Save(Plan plan)
        {
            RequiereAdmin();
            ValidarBasicos(plan);
            ValidarFormato(plan);
            EjecutarPersistencia(() =>
            {
                _repositorio.Add(plan);
                _repositorio.Save();
            }, "No se pudo guardar el plan. Intente nuevamente.");
        }

        public void Update(Plan plan)
        {
            RequiereAdmin();
            ValidarBasicos(plan);
            ValidarFormato(plan);
            EjecutarPersistencia(() =>
            {
                _repositorio.Update(plan);
                _repositorio.Save();
            }, "No se pudo actualizar el plan. Intente nuevamente.");
        }

        public void Delete(Plan plan)
        {
            RequiereAdmin();
            EjecutarPersistencia(() =>
            {
                _repositorio.Delete(plan);
                _repositorio.Save();
            }, "No se pudo eliminar el plan. Intente nuevamente.");
        }

        private void ValidarBasicos(Plan plan)
        {
            Validar(() =>
            {
                if (plan == null)
                    throw new ArgumentException("Los datos del plan son obligatorios.");
                Validaciones.AsegurarNoVacio(plan.Descripcion, "Descripción");
                Validaciones.AsegurarPositivo(plan.EspecialidadId, "Especialidad");
            });
        }

        private void ValidarFormato(Plan plan)
        {
            Validar(() =>
            {
                Validaciones.AsegurarDescripcion(plan.Descripcion, "Descripción");
            });
        }
    }
}
