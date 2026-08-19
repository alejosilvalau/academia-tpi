using Dominio;
using Repositorio;
using Servicios.Excepciones;
using Utils;

namespace Servicios
{
    public class ComisionServicio : ServicioBase
    {
        private ComisionRepositorio _repositorio;

        public ComisionServicio(AcademiaContext context, IUsuarioContexto? usuarioContexto)
            : base(usuarioContexto)
        {
            _repositorio = new ComisionRepositorio(context);
        }

        public List<Comision> GetAll()
        {
            RequiereAdminOAlumno();
            return _repositorio.GetAllConPlan();
        }

        public Comision? GetOne(int id)
        {
            RequiereAdminOAlumno();
            return _repositorio.GetOne(id);
        }

        public List<Comision> GetByPlan(int planId)
        {
            RequiereAdminOAlumno();
            return _repositorio.GetByPlan(planId);
        }

        public void Save(Comision comision)
        {
            RequiereAdmin();
            ValidarBasicos(comision);
            ValidarFormato(comision);
            EjecutarPersistencia(() =>
            {
                _repositorio.Add(comision);
                _repositorio.Save();
            }, "No se pudo guardar la comisión. Intente nuevamente.");
        }

        public void Update(Comision comision)
        {
            RequiereAdmin();
            ValidarBasicos(comision);
            ValidarFormato(comision);
            EjecutarPersistencia(() =>
            {
                _repositorio.Update(comision);
                _repositorio.Save();
            }, "No se pudo actualizar la comisión. Intente nuevamente.");
        }

        public void Delete(Comision comision)
        {
            RequiereAdmin();
            EjecutarPersistencia(() =>
            {
                _repositorio.Delete(comision);
                _repositorio.Save();
            }, "No se pudo eliminar la comisión. Intente nuevamente.");
        }

        private void ValidarBasicos(Comision comision)
        {
            Validar(() =>
            {
                if (comision == null)
                    throw new ArgumentException("Los datos de la comisión son obligatorios.");
                Validaciones.AsegurarNoVacio(comision.Descripcion, "Descripción");
                Validaciones.AsegurarPositivo(comision.PlanId, "Plan");
                Validaciones.AsegurarPositivo(comision.AnioEspecialidad, "Año de especialidad");
            });
        }

        private void ValidarFormato(Comision comision)
        {
            Validar(() =>
            {
                Validaciones.AsegurarDescripcion(comision.Descripcion, "Descripción");
                Validaciones.AsegurarRangoEntero(comision.AnioEspecialidad, 1, 10, "Año de especialidad");
            });
        }
    }
}
