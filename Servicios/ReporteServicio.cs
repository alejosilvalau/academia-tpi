using System.Data;
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

        public DataTable ObtenerCursos()
        {
            RequiereAdmin();
            try
            {
                return _generador.ObtenerCursos();
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudieron obtener los cursos para el reporte. Intente nuevamente.");
            }
        }

        public DataTable ObtenerPlanes()
        {
            RequiereAdmin();
            try
            {
                return _generador.ObtenerPlanes();
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudieron obtener los planes para el reporte. Intente nuevamente.");
            }
        }

        public FastReport.Report GenerarReporteCursos(int cursoId)
        {
            RequiereAdmin();
            try
            {
                return _generador.GenerarReporteCursos(cursoId);
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudo generar el reporte de cursos. Verifique que el archivo de plantilla exista.");
            }
        }

        public FastReport.Report GenerarReportePlanes(int planId)
        {
            RequiereAdmin();
            try
            {
                return _generador.GenerarReportePlanes(planId);
            }
            catch (ServicioException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ServicioException("No se pudo generar el reporte de planes. Verifique que el archivo de plantilla exista.");
            }
        }

        public byte[] ExportarPdf(FastReport.Report report)
        {
            RequiereAdmin();
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
