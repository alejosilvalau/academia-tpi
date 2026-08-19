using Dominio;
using Repositorio;
using Servicios.Excepciones;
using Utils;

namespace Servicios
{
    public class PersonaServicio : ServicioBase
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
            ValidarBasicos(persona);
            ValidarFormato(persona);
            ValidarReglasNegocio(persona, esAlta: true);
            EjecutarPersistencia(() =>
            {
                _repositorio.Add(persona);
                _repositorio.Save();
            }, "No se pudo guardar la persona. Intente nuevamente.");
        }

        public void Update(Persona persona)
        {
            ValidarBasicos(persona);
            ValidarFormato(persona);
            ValidarReglasNegocio(persona, esAlta: false);
            EjecutarPersistencia(() =>
            {
                _repositorio.Update(persona);
                _repositorio.Save();
            }, "No se pudo actualizar la persona. Intente nuevamente.");
        }

        public void Delete(Persona persona)
        {
            EjecutarPersistencia(() =>
            {
                _repositorio.Delete(persona);
                _repositorio.Save();
            }, "No se pudo eliminar la persona. Intente nuevamente.");
        }

        private void ValidarBasicos(Persona persona)
        {
            Validar(() =>
            {
                if (persona == null)
                    throw new ArgumentException("Los datos de la persona son obligatorios.");
                Validaciones.AsegurarNoVacio(persona.Nombre, "Nombre");
                Validaciones.AsegurarNoVacio(persona.Apellido, "Apellido");
                Validaciones.AsegurarNoVacio(persona.EMail, "Email");
                Validaciones.AsegurarNoVacio(persona.Direccion, "Dirección");
                Validaciones.AsegurarNoVacio(persona.Telefono, "Teléfono");
                Validaciones.AsegurarPositivo(persona.Legajo, "Legajo");
                Validaciones.AsegurarRangoEntero(persona.FechaNacimiento.Year, 1900, DateTime.Today.Year, "Año de nacimiento");
                if (persona.FechaNacimiento > DateTime.Today)
                    throw new ArgumentException("La fecha de nacimiento no puede ser futura.");
                if (persona.Tipo == Persona.TiposPersonas.Alumno && (!persona.PlanId.HasValue || persona.PlanId <= 0))
                    throw new ArgumentException("El plan es obligatorio para los alumnos.");
            });
        }

        private void ValidarFormato(Persona persona)
        {
            Validar(() =>
            {
                Validaciones.AsegurarNombreOApellido(persona.Nombre, "Nombre");
                Validaciones.AsegurarNombreOApellido(persona.Apellido, "Apellido");
                Validaciones.AsegurarEmail(persona.EMail);
                Validaciones.AsegurarTelefono(persona.Telefono);
            });
        }

        private void ValidarReglasNegocio(Persona persona, bool esAlta)
        {
            var existente = _repositorio.GetByLegajo(persona.Legajo);
            if (existente != null && existente.ID != persona.ID)
                throw new ReglaNegocioException($"El legajo {persona.Legajo} ya existe.");
        }
    }
}
