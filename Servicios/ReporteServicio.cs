using System.Data;
using Dominio;
using Repositorio;
using Servicios.Excepciones;

namespace Servicios
{
    public class ReporteServicio : ServicioBase
    {
        private readonly ReporteGenerador _generador;

        public ReporteServicio(IUsuarioContexto? usuarioContexto)
            : base(usuarioContexto)
        {
            _generador = new ReporteGenerador();
        }

        public DataTable ObtenerDocentes()
        {
            RequiereAdmin();
            try
            {
                return _generador.ObtenerDocentes();
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudieron obtener los docentes para el reporte. Intente nuevamente.");
            }
        }

        public DataTable ObtenerAlumnos()
        {
            RequiereAdmin();
            try
            {
                return _generador.ObtenerAlumnos();
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudieron obtener los alumnos para el reporte. Intente nuevamente.");
            }
        }

        public DataTable ObtenerAlumnosDeDocente(int docenteId)
        {
            RequiereAdminODocente();
            try
            {
                int idResuelto = EsAdmin() ? docenteId : PersonaIdActual()!.Value;
                return _generador.ObtenerAlumnosDeDocente(idResuelto);
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudieron obtener los alumnos del docente para el reporte. Intente nuevamente.");
            }
        }

        public FastReport.Report GenerarReporteRendimientoDocente(int docenteId)
        {
            RequiereAdminODocente();
            try
            {
                int idResuelto = EsAdmin() ? docenteId : PersonaIdActual()!.Value;
                return _generador.GenerarReporteRendimientoDocente(idResuelto);
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudo generar el reporte de rendimiento docente. Verifique que el archivo de plantilla exista.");
            }
        }

        public FastReport.Report GenerarReporteRendimientoAlumno(int alumnoId)
        {
            RequiereAutenticacion();
            try
            {
                var tipo = TipoUsuarioActual();
                if (tipo == Persona.TiposPersonas.Docente)
                {
                    int docenteId = PersonaIdActual()!.Value;
                    var alumnosDocente = _generador.ObtenerAlumnosDeDocente(docenteId);
                    if (!alumnosDocente.AsEnumerable().Any(r => Convert.ToInt32(r["ID"]) == alumnoId))
                        throw new AccesoNoAutorizadoException("Solo puede generar el reporte de rendimiento de alumnos que dicta.");

                    return _generador.GenerarReporteRendimientoAlumno(alumnoId);
                }

                int idResuelto = EsAdmin() ? alumnoId : PersonaIdActual()!.Value;
                return _generador.GenerarReporteRendimientoAlumno(idResuelto);
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudo generar el reporte de rendimiento del alumno. Verifique que el archivo de plantilla exista.");
            }
        }

        public FastReport.Report GenerarReporteRendimientoAlumnosDeDocente(int docenteId)
        {
            RequiereAdminODocente();
            try
            {
                int idResuelto = EsAdmin() ? docenteId : PersonaIdActual()!.Value;
                return _generador.GenerarReporteRendimientoAlumnosDeDocente(idResuelto);
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudo generar el reporte de rendimiento de los alumnos del docente. Verifique que el archivo de plantilla exista.");
            }
        }

        public byte[] ExportarPdf(FastReport.Report report)
        {
            RequiereAutenticacion();
            try
            {
                return _generador.ExportarPdf(report);
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudo exportar el reporte a PDF. Intente nuevamente.");
            }
        }
    }
}
