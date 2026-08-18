using System.Data;
using Repositorio;

namespace Servicios
{
    public class ReporteServicio
    {
        private readonly ReporteGenerador _generador;

        public ReporteServicio()
        {
            _generador = new ReporteGenerador();
        }

        public DataTable ObtenerCursos()
        {
            return _generador.ObtenerCursos();
        }

        public DataTable ObtenerPlanes()
        {
            return _generador.ObtenerPlanes();
        }

        public FastReport.Report GenerarReporteCursos(int cursoId)
        {
            return _generador.GenerarReporteCursos(cursoId);
        }

        public FastReport.Report GenerarReportePlanes(int planId)
        {
            return _generador.GenerarReportePlanes(planId);
        }

        public byte[] ExportarPdf(FastReport.Report report)
        {
            return _generador.ExportarPdf(report);
        }
    }
}
