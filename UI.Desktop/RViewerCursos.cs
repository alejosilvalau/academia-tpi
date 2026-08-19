using Servicios;

namespace UI.Desktop
{
    public partial class RViewerCursos : ApplicationForm
    {
        private readonly ReporteServicio _servicio;

        public RViewerCursos()
        {
            InitializeComponent();
            _servicio = new ReporteServicio(new UsuarioContextoDesktop());
        }

        private void RViewerCursos_Load(object sender, EventArgs e)
        {
            try
            {
                var cursos = _servicio.ObtenerCursos();
                cbxCursos.DataSource = cursos;
                cbxCursos.DisplayMember = "Descripcion";
                cbxCursos.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cursos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cbxCursos.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un curso.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int cursoId = Convert.ToInt32(cbxCursos.SelectedValue);
                var report = _servicio.GenerarReporteCursos(cursoId);
                byte[] pdfBytes = _servicio.ExportarPdf(report);

                string tempPath = Path.Combine(Path.GetTempPath(), $"ReporteCursos_{cursoId}.pdf");
                File.WriteAllBytes(tempPath, pdfBytes);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = tempPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
