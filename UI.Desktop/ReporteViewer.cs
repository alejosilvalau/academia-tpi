using Dominio;
using Repositorio;
using Servicios;
using Microsoft.Web.WebView2.WinForms;

namespace UI.Desktop
{
    public enum ModoReporte
    {
        RendimientoDocente,
        RendimientoAlumnos
    }

    public partial class ReporteViewer : ApplicationForm
    {
        private readonly ReporteServicio _servicio;
        private readonly ModoReporte _modo;
        private byte[]? _pdfActual;
        private string? _tempPath;

        public ReporteViewer(ModoReporte modo)
        {
            InitializeComponent();
            _servicio = new ReporteServicio(new UsuarioContextoDesktop());
            _modo = modo;
            Text = modo == ModoReporte.RendimientoDocente
                ? "Reporte de Rendimiento Docente"
                : "Reporte de Rendimiento de Alumnos";
        }

        private void ReporteViewer_Load(object sender, EventArgs e)
        {
            InicializarWebView();
            ConfigurarPorRol();
        }

        private void InicializarWebView()
        {
            webView = new WebView2
            {
                Dock = DockStyle.Fill,
                Visible = false
            };
            panelViewer.Controls.Add(webView);
            _ = webView.EnsureCoreWebView2Async();
        }

        private void ConfigurarPorRol()
        {
            var tipo = Login.UsuarioActual?.Persona?.Tipo;

            if (tipo == Persona.TiposPersonas.Administrador)
            {
                lblSelector.Visible = true;
                cbxSelector.Visible = true;
                CargarSelectorAdmin();
            }
            else
            {
                lblSelector.Visible = false;
                cbxSelector.Visible = false;
            }
        }

        private void CargarSelectorAdmin()
        {
            try
            {
                if (_modo == ModoReporte.RendimientoDocente)
                {
                    cbxSelector.DataSource = _servicio.ObtenerDocentes();
                    lblSelector.Text = "Docente:";
                }
                else
                {
                    cbxSelector.DataSource = _servicio.ObtenerAlumnos();
                    lblSelector.Text = "Alumno:";
                }
                cbxSelector.DisplayMember = "Apellido";
                cbxSelector.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar personas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObtenerIdObjetivo()
        {
            var persona = Login.UsuarioActual?.Persona;
            if (persona != null && persona.Tipo != Persona.TiposPersonas.Administrador)
                return persona.ID;

            if (cbxSelector.SelectedValue == null)
                throw new InvalidOperationException("Seleccione una persona.");

            return Convert.ToInt32(cbxSelector.SelectedValue);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                var report = _modo == ModoReporte.RendimientoDocente
                    ? _servicio.GenerarReporteRendimientoDocente(ObtenerIdObjetivo())
                    : _servicio.GenerarReporteRendimientoAlumno(ObtenerIdObjetivo());

                _pdfActual = _servicio.ExportarPdf(report);
                MostrarPdf(_pdfActual);
                btnDescargar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (_pdfActual == null) return;

            using var sfd = new SaveFileDialog
            {
                Filter = "Archivo PDF|*.pdf",
                FileName = (_modo == ModoReporte.RendimientoDocente ? "ReporteRendimientoDocente" : "ReporteRendimientoAlumnos") + ".pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllBytes(sfd.FileName, _pdfActual);
                    MessageBox.Show("PDF guardado correctamente.",
                        "Descarga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MostrarPdf(byte[] pdf)
        {
            try
            {
                if (!string.IsNullOrEmpty(_tempPath) && File.Exists(_tempPath))
                {
                    try { File.Delete(_tempPath); } catch { }
                }
                _tempPath = Path.Combine(Path.GetTempPath(), $"AcademiaReporte_{Guid.NewGuid():N}.pdf");
                File.WriteAllBytes(_tempPath, pdf);

                lblAviso.Visible = false;
                webView.Visible = true;

                var uri = new Uri(_tempPath).AbsoluteUri;
                if (webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Navigate(uri);
                }
                else
                {
                    webView.Source = new Uri(uri);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar PDF: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
