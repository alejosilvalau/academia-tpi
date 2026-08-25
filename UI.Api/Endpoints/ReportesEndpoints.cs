using System.Data;
using Servicios;

namespace UI.Api.Endpoints
{
    public static class ReportesEndpoints
    {
        public static IEndpointRouteBuilder MapReportesEndpoints(this IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/reportes").WithTags("Reportes").RequireAuthorization();

            g.MapGet("/docentes", (ReporteServicio s) => Results.Ok(TablaAJson(s.ObtenerDocentes())));
            g.MapGet("/alumnos", (ReporteServicio s) => Results.Ok(TablaAJson(s.ObtenerAlumnos())));
            g.MapGet("/alumnos-de-docente/{docenteId:int}", (int docenteId, ReporteServicio s) =>
                Results.Ok(TablaAJson(s.ObtenerAlumnosDeDocente(docenteId))));

            g.MapGet("/rendimiento-docente/{docenteId:int}/pdf", (int docenteId, ReporteServicio s) =>
                Results.File(s.ExportarPdf(s.GenerarReporteRendimientoDocente(docenteId)), "application/pdf", "rendimiento-docente.pdf"));

            g.MapGet("/rendimiento-alumno/{alumnoId:int}/pdf", (int alumnoId, ReporteServicio s) =>
                Results.File(s.ExportarPdf(s.GenerarReporteRendimientoAlumno(alumnoId)), "application/pdf", "rendimiento-alumno.pdf"));

            g.MapGet("/rendimiento-alumnos-docente/{docenteId:int}/pdf", (int docenteId, ReporteServicio s) =>
                Results.File(s.ExportarPdf(s.GenerarReporteRendimientoAlumnosDeDocente(docenteId)), "application/pdf", "rendimiento-alumnos-docente.pdf"));

            return app;
        }

        private static List<Dictionary<string, object?>> TablaAJson(DataTable tabla)
        {
            var filas = new List<Dictionary<string, object?>>(tabla.Rows.Count);
            foreach (DataRow fila in tabla.Rows)
            {
                var dict = new Dictionary<string, object?>(tabla.Columns.Count);
                foreach (DataColumn columna in tabla.Columns)
                    dict[columna.ColumnName] = fila[columna] == DBNull.Value ? null : fila[columna];
                filas.Add(dict);
            }
            return filas;
        }
    }
}