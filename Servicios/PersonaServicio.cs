using Dominio;
using Repositorio;

namespace Servicios
{
    public class PersonaServicio
    {
        private PersonaRepositorio _repositorio;

        public PersonaServicio(AcademiaContext context)
        {
            _repositorio = new PersonaRepositorio(context);
        }

        public List<Persona> GetAll()
        {
            return _repositorio.GetAllConPlan();
        }

        public Persona? GetOne(int id)
        {
            return _repositorio.GetOne(id);
        }

        public List<Persona> GetByTipo(Persona.TiposPersonas tipo)
        {
            return _repositorio.GetByTipo(tipo);
        }

        public Persona? GetByLegajo(int legajo)
        {
            return _repositorio.GetByLegajo(legajo);
        }

        public void Save(Persona persona)
        {
            _repositorio.Add(persona);
            _repositorio.Save();
        }

        public void Update(Persona persona)
        {
            _repositorio.Update(persona);
            _repositorio.Save();
        }

        public void Delete(Persona persona)
        {
            _repositorio.Delete(persona);
            _repositorio.Save();
        }
    }
}
