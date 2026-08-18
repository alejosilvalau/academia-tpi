using Servicios;

namespace UI.Desktop
{
    public partial class RViewerPlanes : Form
    {
        private readonly ReporteServicio _servicio;

        public RViewerPlanes()
        {
            InitializeComponent();
            _servicio = new ReporteServicio();
        }

        private void RViewerPlanes_Load(object sender, EventArgs e)
        {
            try
            {
                var planes = _servicio.ObtenerPlanes();
                cbxPlanes.DataSource = planes;
                cbxPlanes.DisplayMember = "Descripcion";
                cbxPlanes.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar planes: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (cbxPlanes.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un plan.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int planId = Convert.ToInt32(cbxPlanes.SelectedValue);
                var report = _servicio.GenerarReportePlanes(planId);
                byte[] pdfBytes = _servicio.ExportarPdf(report);

                string tempPath = Path.Combine(Path.GetTempPath(), $"ReportePlanes_{planId}.pdf");
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
