using Microsoft.EntityFrameworkCore;
using Servicios.Excepciones;

namespace Servicios
{
    public abstract class ServicioBase
    {
        protected static void Validar(Action accion)
        {
            try
            {
                accion();
            }
            catch (ValidacionException)
            {
                throw;
            }
            catch (ReglaNegocioException)
            {
                throw;
            }
            catch (ArgumentException ex)
            {
                throw new ValidacionException(ex.Message);
            }
        }

        protected static void EjecutarPersistencia(Action accion, string mensajeError)
        {
            try
            {
                accion();
            }
            catch (DbUpdateException ex)
            {
                throw ErrorDbTraductor.Traducir(ex);
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException(mensajeError);
            }
        }
    }
}
