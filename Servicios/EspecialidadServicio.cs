using Dominio;
using Repositorio;
using Servicios.Excepciones;
using Utils;

namespace Servicios
{
    public class EspecialidadServicio : ServicioBase
    {
        private EspecialidadRepositorio _repositorio;

        public EspecialidadServicio(AcademiaContext context, IUsuarioContexto? usuarioContexto)
            : base(usuarioContexto)
        {
            _repositorio = new EspecialidadRepositorio(context);
        }

        public List<Especialidad> GetAll()
        {
            RequiereAdminOAlumno();
            return _repositorio.GetAll();
        }

        public Especialidad? GetOne(int id)
        {
            RequiereAdminOAlumno();
            return _repositorio.GetOne(id);
        }

        public void Save(Especialidad especialidad)
        {
            RequiereAdmin();
            ValidarBasicos(especialidad);
            ValidarFormato(especialidad);
            EjecutarPersistencia(() =>
            {
                _repositorio.Add(especialidad);
                _repositorio.Save();
            }, "No se pudo guardar la especialidad. Intente nuevamente.");
        }

        public void Update(Especialidad especialidad)
        {
            RequiereAdmin();
            ValidarBasicos(especialidad);
            ValidarFormato(especialidad);
            EjecutarPersistencia(() =>
            {
                _repositorio.Update(especialidad);
                _repositorio.Save();
            }, "No se pudo actualizar la especialidad. Intente nuevamente.");
        }

        public void Delete(Especialidad especialidad)
        {
            RequiereAdmin();
            EjecutarPersistencia(() =>
            {
                _repositorio.Delete(especialidad);
                _repositorio.Save();
            }, "No se pudo eliminar la especialidad. Intente nuevamente.");
        }

        private void ValidarBasicos(Especialidad especialidad)
        {
            Validar(() =>
            {
                if (especialidad == null)
                    throw new ArgumentException("Los datos de la especialidad son obligatorios.");
                Validaciones.AsegurarNoVacio(especialidad.Descripcion, "Descripción");
            });
        }

        private void ValidarFormato(Especialidad especialidad)
        {
            Validar(() =>
            {
                Validaciones.AsegurarDescripcion(especialidad.Descripcion, "Descripción");
            });
        }
    }
}
