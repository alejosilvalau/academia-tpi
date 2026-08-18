using System.Data;
using FastReport;
using FastReport.Export.PdfSimple;

namespace Repositorio
{
    public class ReporteGenerador
    {
        private readonly ReportesDatos _datos;

        public ReporteGenerador()
        {
            _datos = new ReportesDatos();
        }

        public Report GenerarReporteCursos(int cursoId)
        {
            var dataTable = _datos.GetCursoDetalle(cursoId);
            var report = new Report();
            report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "CursosReport.frx"));
            report.RegisterData(dataTable, "Curso");
            report.Prepare();
            return report;
        }

        public Report GenerarReportePlanes(int planId)
        {
            var dataTable = _datos.GetPlanDetalle(planId);
            var report = new Report();
            report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "PlanesReport.frx"));
            report.RegisterData(dataTable, "Plan");
            report.Prepare();
            return report;
        }

        public byte[] ExportarPdf(Report report)
        {
            using var stream = new MemoryStream();
            var pdfExport = new PDFSimpleExport();
            pdfExport.Export(report, stream);
            return stream.ToArray();
        }

        public DataTable ObtenerCursos()
        {
            return _datos.GetAllCursos();
        }

        public DataTable ObtenerPlanes()
        {
            return _datos.GetAllPlanes();
        }
    }
}
