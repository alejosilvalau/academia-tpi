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

        public DataTable ObtenerDocentes()
        {
            return _datos.GetDocentes();
        }

        public DataTable ObtenerAlumnos()
        {
            return _datos.GetAlumnos();
        }

        public Report GenerarReporteRendimientoDocente(int docenteId)
        {
            var persona = _datos.GetPersona(docenteId);
            var nombre = persona != null ? $"{persona["Nombre"]} {persona["Apellido"]}" : "Desconocido";
            var legajo = persona != null && persona["Legajo"] != DBNull.Value ? persona["Legajo"].ToString() : "-";

            var dataTable = _datos.GetRendimientoDocente(docenteId);
            AgregarColumnaCalculada(dataTable, "CargoTexto", r => TextoCargo(Convert.ToInt32(r["Cargo"])));
            AgregarColumnaCalculada(dataTable, "PromedioTexto", r =>
            {
                if (r["Promedio"] == DBNull.Value) return "-";
                return Convert.ToDouble(r["Promedio"]).ToString("0.00");
            });

            var report = new Report();
            report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "RendimientoDocenteReport.frx"));
            report.RegisterData(dataTable, "Rendimiento");
            var ds = report.GetDataSource("Rendimiento");
            if (ds != null) ds.Enabled = true;

            report.SetParameterValue("DocenteNombre", nombre);
            report.SetParameterValue("DocenteLegajo", legajo);
            report.SetParameterValue("FechaGeneracion", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

            if (dataTable.Rows.Count > 0)
            {
                var imagen = GraficoGenerador.BarrasRendimientoDocente(dataTable);
                AsignarImagen(report, "GraficoGeneral", imagen);
            }

            report.Prepare();
            return report;
        }

        public Report GenerarReporteRendimientoAlumno(int alumnoId)
        {
            var persona = _datos.GetPersona(alumnoId);
            var titulo = persona != null
                ? $"Rendimiento de: {persona["Nombre"]} {persona["Apellido"]} (Legajo {persona["Legajo"]})"
                : "Rendimiento del alumno";

            var dataTable = _datos.GetRendimientoAlumno(alumnoId);
            EnriquecerTablaAlumnos(dataTable);

            var report = ConstruirReporteAlumnos(dataTable, titulo);
            return report;
        }

        public Report GenerarReporteRendimientoAlumnosDeDocente(int docenteId)
        {
            var persona = _datos.GetPersona(docenteId);
            var titulo = persona != null
                ? $"Rendimiento de los alumnos del docente: {persona["Nombre"]} {persona["Apellido"]} (Legajo {persona["Legajo"]})"
                : "Rendimiento de los alumnos del docente";

            var dataTable = _datos.GetRendimientoAlumnosDeDocente(docenteId);
            EnriquecerTablaAlumnos(dataTable);

            return ConstruirReporteAlumnos(dataTable, titulo);
        }

        public byte[] ExportarPdf(Report report)
        {
            using var stream = new MemoryStream();
            var pdfExport = new PDFSimpleExport();
            pdfExport.Export(report, stream);
            return stream.ToArray();
        }

        private Report ConstruirReporteAlumnos(DataTable dataTable, string titulo)
        {
            var report = new Report();
            report.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "RendimientoAlumnosReport.frx"));
            report.RegisterData(dataTable, "Alumnos");
            var dsAl = report.GetDataSource("Alumnos");
            if (dsAl != null) dsAl.Enabled = true;

            report.SetParameterValue("TituloFiltro", titulo);
            report.SetParameterValue("FechaGeneracion", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

            if (dataTable.Rows.Count > 0)
            {
                var imagen = GraficoGenerador.TortaCondiciones(dataTable, 500, 400);
                AsignarImagen(report, "GraficoGeneral", imagen);
            }

            report.Prepare();
            return report;
        }

        private static void EnriquecerTablaAlumnos(DataTable dataTable)
        {
            AgregarColumnaCalculada(dataTable, "CondicionTexto", r => TextoCondicion(Convert.ToInt32(r["Condicion"])));
            AgregarColumnaCalculada(dataTable, "NotaTexto", r => r["Nota"] == DBNull.Value ? "-" : (Convert.ToString(r["Nota"]) ?? "-"));
        }

        private static void AgregarColumnaCalculada(DataTable table, string nombreColumna, Func<DataRow, string> calculo)
        {
            table.Columns.Add(nombreColumna, typeof(string));
            foreach (DataRow row in table.Rows)
            {
                row[nombreColumna] = calculo(row);
            }
        }

        private static void AsignarImagen(Report report, string nombreObjeto, byte[] imagen)
        {
            var picture = report.FindObject(nombreObjeto) as PictureObject;
            if (picture != null)
            {
                using var stream = new MemoryStream(imagen);
                picture.Image = System.Drawing.Image.FromStream(stream);
            }
        }

        private static string TextoCargo(int cargo) => cargo switch
        {
            0 => "Profesor",
            1 => "Jefe de Cátedra",
            2 => "Auxiliar",
            _ => cargo.ToString()
        };

        private static string TextoCondicion(int condicion) => condicion switch
        {
            0 => "Inscripto",
            1 => "Regular",
            2 => "Aprobado",
            _ => condicion.ToString()
        };
    }
}
