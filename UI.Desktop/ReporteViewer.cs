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

            var tipo = Login.UsuarioActual?.Persona?.Tipo;
            if (tipo != Persona.TiposPersonas.Administrador
                && !(tipo == Persona.TiposPersonas.Docente && _modo == ModoReporte.RendimientoAlumnos))
            {
                GenerarReporte();
            }
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
                btnGenerar.Location = new System.Drawing.Point(550, 15);
                btnDescargar.Location = new System.Drawing.Point(695, 15);
            }
            else if (tipo == Persona.TiposPersonas.Docente && _modo == ModoReporte.RendimientoAlumnos)
            {
                lblSelector.Visible = true;
                cbxSelector.Visible = true;
                lblSelector.Text = "Alumno:";
                CargarSelectorDocente();
                btnGenerar.Location = new System.Drawing.Point(550, 15);
                btnDescargar.Location = new System.Drawing.Point(695, 15);
            }
            else
            {
                lblSelector.Visible = false;
                cbxSelector.Visible = false;
                btnGenerar.Visible = false;
                btnDescargar.Location = new System.Drawing.Point(15, 15);
            }

            SetBtnDescargarEstado(false);
        }

        private void CargarSelectorDocente()
        {
            try
            {
                cbxSelector.DataSource = _servicio.ObtenerAlumnosDeDocente(Login.UsuarioActual!.Persona!.ID);
                cbxSelector.DisplayMember = "Apellido";
                cbxSelector.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alumnos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            {
                if (persona.Tipo == Persona.TiposPersonas.Docente && _modo == ModoReporte.RendimientoAlumnos)
                {
                    if (cbxSelector.SelectedValue == null)
                        throw new InvalidOperationException("Seleccione un alumno.");
                    return Convert.ToInt32(cbxSelector.SelectedValue);
                }
                return persona.ID;
            }

            if (cbxSelector.SelectedValue == null)
                throw new InvalidOperationException("Seleccione una persona.");

            return Convert.ToInt32(cbxSelector.SelectedValue);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            try
            {
                var report = _modo == ModoReporte.RendimientoDocente
                    ? _servicio.GenerarReporteRendimientoDocente(ObtenerIdObjetivo())
                    : _servicio.GenerarReporteRendimientoAlumno(ObtenerIdObjetivo());

                _pdfActual = _servicio.ExportarPdf(report);
                MostrarPdf(_pdfActual);
                SetBtnDescargarEstado(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reporte: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargar_Click(object? sender, EventArgs e)
        {
            if (_pdfActual == null) return;

            var persona = Login.UsuarioActual?.Persona;
            string prefijo = _modo == ModoReporte.RendimientoDocente
                ? "reporte-rendimiento-docente"
                : "reporte-rendimiento-alumno";
            string nombreArchivo = persona != null
                ? $"{prefijo}-{persona.Legajo}-{persona.Nombre}-{persona.Apellido}-{DateTime.Now:yyyyMMdd}"
                : $"{prefijo}-{DateTime.Now:yyyyMMdd}";

            using var sfd = new SaveFileDialog
            {
                Filter = "Archivo PDF|*.pdf",
                FileName = nombreArchivo + ".pdf"
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

        private void SetBtnDescargarEstado(bool activo)
        {
            btnDescargar.Enabled = activo;
            if (activo)
            {
                btnDescargar.BackColor = Color.FromArgb(96, 125, 139);
                btnDescargar.ForeColor = Color.White;
            }
            else
            {
                btnDescargar.BackColor = Color.FromArgb(176, 190, 197);
                btnDescargar.ForeColor = Color.FromArgb(120, 120, 120);
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
