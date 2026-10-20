using System.Data;
using Contratos;
using Dominio;
using Microsoft.EntityFrameworkCore;
using Repositorio;
using Servicios.Excepciones;

namespace Servicios
{
    public abstract class ServicioBase
    {
        protected IUsuarioContexto? UsuarioContexto { get; }

        protected ServicioBase(IUsuarioContexto? usuarioContexto)
        {
            UsuarioContexto = usuarioContexto;
        }

        protected void RequiereAutenticacion()
        {
            if (UsuarioContexto?.ObtenerUsuarioActual() == null)
                throw new AccesoNoAutorizadoException("Debe iniciar sesión para realizar esta operación.");
        }

        protected void RequiereAdmin()
        {
            RequiereAutenticacion();
            if (EsAdmin()) return;
            throw new AccesoNoAutorizadoException("No tiene permisos de administrador.");
        }

        protected void RequiereAdminOAlumno()
        {
            RequiereAutenticacion();
            var tipo = TipoUsuarioActual();
            if (tipo == TipoPersona.Administrador || tipo == TipoPersona.Alumno) return;
            throw new AccesoNoAutorizadoException("No tiene permisos para realizar esta operación.");
        }

        protected void RequiereAdminODocente()
        {
            RequiereAutenticacion();
            var tipo = TipoUsuarioActual();
            if (tipo == TipoPersona.Administrador || tipo == TipoPersona.Docente) return;
            throw new AccesoNoAutorizadoException("No tiene permisos para realizar esta operación.");
        }

        protected bool EsAdmin()
        {
            return TipoUsuarioActual() == TipoPersona.Administrador;
        }

        protected TipoPersona? TipoUsuarioActual()
        {
            return UsuarioContexto?.ObtenerUsuarioActual()?.Persona?.Tipo;
        }

        protected int? PersonaIdActual()
        {
            return UsuarioContexto?.ObtenerUsuarioActual()?.PersonaId;
        }

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
        protected static void EjecutarPersistenciaTransaccional(
            AcademiaContext context, Action accion, string mensajeError)
        {
            using var transaction = context.Database.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                accion();
                transaction.Commit();
            }
            catch (DbUpdateException ex)
            {
                transaction.Rollback();
                throw ErrorDbTraductor.Traducir(ex);
            }
            catch (ServicioException)
            {
                transaction.Rollback();
                throw;
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw new ServicioException(mensajeError);
            }
        }
    }
}
