using Dominio;
using Repositorio;

namespace Servicios
{
    public class EspecialidadServicio
    {
        private EspecialidadRepositorio _repositorio;

        public EspecialidadServicio(AcademiaContext context)
        {
            _repositorio = new EspecialidadRepositorio(context);
        }

        public List<Especialidad> GetAll()
        {
            return _repositorio.GetAll();
        }

        public Especialidad? GetOne(int id)
        {
            return _repositorio.GetOne(id);
        }

        public void Save(Especialidad especialidad)
        {
            _repositorio.Add(especialidad);
            _repositorio.Save();
        }

        public void Update(Especialidad especialidad)
        {
            _repositorio.Update(especialidad);
            _repositorio.Save();
        }

        public void Delete(Especialidad especialidad)
        {
            _repositorio.Delete(especialidad);
            _repositorio.Save();
        }
    }
}
