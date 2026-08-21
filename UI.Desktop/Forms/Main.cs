using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop
{
    public partial class Main : ApplicationForm
    {
        private readonly PersonaServicio _personaServicio;
        private readonly HashSet<string> _botonesPermitidos = new();

        public Main()
        {
            InitializeComponent();
            _personaServicio = new PersonaServicio(new AcademiaContext(), new UsuarioContextoDesktop());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Login.UsuarioActual?.Persona != null)
            {
                var persona = Login.UsuarioActual.Persona;
                lblTitulo.Text = $"Bienvenido/a {persona.Nombre} {persona.Apellido}";
                lblUsuario.Text = Login.UsuarioActual.NombreUsuario;
                lblTipo.Text = persona.Tipo.ToString();
                lblLegajo.Text = persona.Legajo > 0 ? $"Legajo: {persona.Legajo}" : "";
            }

            panelSubMenu.Visible = false;

            var tipo = Login.UsuarioActual?.Persona?.Tipo;
            btnAdministracion.Visible = tipo == Persona.TiposPersonas.Administrador;
            btnReportes.Visible = tipo != null;

            switch (tipo)
            {
                case Persona.TiposPersonas.Administrador:
                    btnInscripcion.Visible = true;
                    btnNotas.Visible = true;
                    btnReportesRendimientoDocente.Visible = true;
                    btnReportesRendimientoAlumnos.Visible = true;
                    _botonesPermitidos.Add(btnReportesRendimientoDocente.Name);
                    _botonesPermitidos.Add(btnReportesRendimientoAlumnos.Name);
                    _botonesPermitidos.Add(btnABMComisiones.Name);
                    _botonesPermitidos.Add(btnABMCursos.Name);
                    _botonesPermitidos.Add(btnABMEspecialidades.Name);
                    _botonesPermitidos.Add(btnABMPersonas.Name);
                    _botonesPermitidos.Add(btnABMPlanMaterias.Name);
                    _botonesPermitidos.Add(btnABMDictados.Name);
                    _botonesPermitidos.Add(btnABMUsuarios.Name);
                    break;
                case Persona.TiposPersonas.Alumno:
                    btnInscripcion.Visible = true;
                    btnNotas.Visible = false;
                    btnReportesRendimientoDocente.Visible = false;
                    btnReportesRendimientoAlumnos.Visible = true;
                    _botonesPermitidos.Add(btnReportesRendimientoAlumnos.Name);
                    break;
                case Persona.TiposPersonas.Docente:
                    btnInscripcion.Visible = false;
                    btnNotas.Visible = true;
                    btnReportesRendimientoDocente.Visible = true;
                    btnReportesRendimientoAlumnos.Visible = true;
                    _botonesPermitidos.Add(btnReportesRendimientoDocente.Name);
                    _botonesPermitidos.Add(btnReportesRendimientoAlumnos.Name);
                    break;
            }

            ConstruirDashboard(tipo);
        }

        private void ConstruirDashboard(Persona.TiposPersonas? tipo)
        {
            panelDashboard.Controls.Clear();

            var flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = false,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10),
                BackColor = Color.FromArgb(245, 245, 245)
            };

            var cards = new List<(string titulo, string desc, string icono, Action onClick)>();

            if (tipo == Persona.TiposPersonas.Administrador)
            {
                cards.Add(("Especialidades", "Gestionar especialidades", "\u25C6", () => OpenForm(new Forms.Especialidades.Especialidades())));
                cards.Add(("Plan/Materias", "Gestionar planes de estudio y materias", "\u25C6", () => OpenForm(new Forms.Planes.PlanMaterias())));
                cards.Add(("Comisiones", "Gestionar comisiones", "\u25C6", () => OpenForm(new Forms.Comisiones.Comisiones())));
                cards.Add(("Cursos", "Gestionar cursos", "\u25C6", () => OpenForm(new Forms.Cursos.Cursos())));
                cards.Add(("Personas", "Gestionar alumnos, docentes y admins", "\u25C6", () => OpenForm(new Forms.Personas.Personas())));
                cards.Add(("Dictados", "Gestionar asignacion de docentes a cursos", "\u25C6", () => OpenForm(new Forms.Dictados.Dictados())));
                cards.Add(("Usuarios", "Gestionar usuarios del sistema", "\u25C6", () => OpenForm(new Forms.Usuarios.Usuarios())));
                cards.Add(("Inscripciones", "Inscribir alumnos a cursos", "\u270E", () => OpenForm(new Forms.Personas.Personas(Persona.TiposPersonas.Alumno))));
                cards.Add(("Registrar Notas", "Calificar alumnos en cursos", "\u270E", () => OpenForm(new Forms.Personas.Personas(Persona.TiposPersonas.Docente))));
                cards.Add(("Rend. Docente", "Ver reporte de rendimiento docente", "\u2630", () => OpenForm(new ReporteViewer(ModoReporte.RendimientoDocente))));
                cards.Add(("Rend. Alumnos", "Ver reporte de rendimiento de alumnos", "\u2630", () => OpenForm(new ReporteViewer(ModoReporte.RendimientoAlumnos))));
            }
            else if (tipo == Persona.TiposPersonas.Alumno)
            {
                cards.Add(("Inscripciones", "Inscribirse a cursos", "\u270E", () => OpenForm(new Forms.Inscripciones.Inscripciones(Login.UsuarioActual!.Persona!))));
                cards.Add(("Rend. Alumnos", "Ver reporte de rendimiento", "\u2630", () => OpenForm(new ReporteViewer(ModoReporte.RendimientoAlumnos))));
            }
            else if (tipo == Persona.TiposPersonas.Docente)
            {
                cards.Add(("Registrar Notas", "Calificar alumnos en cursos", "\u270E", () => OpenForm(new Forms.RegistrarNotas.RegistrarNotas(Login.UsuarioActual!.Persona!))));
                cards.Add(("Rend. Docente", "Ver reporte de rendimiento", "\u2630", () => OpenForm(new ReporteViewer(ModoReporte.RendimientoDocente))));
                cards.Add(("Rend. Alumnos", "Ver reporte de rendimiento de alumnos", "\u2630", () => OpenForm(new ReporteViewer(ModoReporte.RendimientoAlumnos))));
            }

            foreach (var (titulo, desc, icono, onClick) in cards)
            {
                var card = CrearDashboardCard(titulo, desc, icono, onClick);
                flow.Controls.Add(card);
            }

            panelDashboard.Controls.Add(flow);
            panelDashboard.Visible = true;
        }

        private Panel CrearDashboardCard(string titulo, string desc, string icono, Action onClick)
        {
            var card = new Panel
            {
                Size = new Size(280, 130),
                Margin = new Padding(10),
                BackColor = Color.White,
                Cursor = Cursors.Hand
            };

            var lblIcono = new Label
            {
                Text = icono,
                Font = new Font("Segoe UI Symbol", 30F),
                ForeColor = Color.FromArgb(96, 125, 139),
                Location = new Point(10, 25),
                AutoSize = true
            };

            var lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 33, 33),
                Location = new Point(85, 35),
                AutoSize = true
            };

            var lblDesc = new Label
            {
                Text = desc,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(117, 117, 117),
                Location = new Point(85, 65),
                AutoSize = true,
                MaximumSize = new Size(190, 0)
            };

            card.Controls.Add(lblIcono);
            card.Controls.Add(lblTitulo);
            card.Controls.Add(lblDesc);

            EventHandler handler = (s, e) => onClick();
            card.Click += handler;
            lblIcono.Click += handler;
            lblTitulo.Click += handler;
            lblDesc.Click += handler;

            card.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.FromArgb(176, 190, 197), ButtonBorderStyle.Solid);
            };

            return card;
        }

        internal void OpenForm(ApplicationForm form)
        {
            panelSubMenu.Visible = false;
            panelDashboard.Visible = false;
            panelFormLoader.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            panelFormLoader.Controls.Add(form);
            lblTitulo.Text = form.Text;
            form.Show();
            panelDashboard.Visible = false;
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            ShowSubMenu("ABM", btnAdministracion);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ShowSubMenu("Reportes", btnReportes);
        }

        private void ShowSubMenu(string category, Control trigger)
        {
            panelSubMenu.BringToFront();
            panelSubMenu.Visible = true;
            foreach (Control c in panelSubMenu.Controls)
            {
                if (c is Button btn)
                    btn.Visible = btn.Name.Contains(category) && _botonesPermitidos.Contains(btn.Name);
            }

            int height = 0;
            foreach (Control c in panelSubMenu.Controls)
            {
                if (c.Visible) height += c.Height;
            }
            panelSubMenu.Height = height;
            panelSubMenu.Top = trigger.Top;
        }

        private void HideSubMenu()
        {
            panelSubMenu.Visible = false;
        }

        private void panelOutside_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnABMComisiones_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Comisiones.Comisiones());
        }

        private void btnABMCursos_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Cursos.Cursos());
        }

        private void btnABMEspecialidades_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Especialidades.Especialidades());
        }

        private void btnABMPersonas_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Personas.Personas());
        }

        private void btnABMPlanMaterias_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Planes.PlanMaterias());
        }

        private void btnABMDictados_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Dictados.Dictados());
        }

        private void btnABMUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Usuarios.Usuarios());
        }

        private void btnReportesRendimientoDocente_Click(object sender, EventArgs e)
        {
            OpenForm(new ReporteViewer(ModoReporte.RendimientoDocente));
        }

        private void btnReportesRendimientoAlumnos_Click(object sender, EventArgs e)
        {
            OpenForm(new ReporteViewer(ModoReporte.RendimientoAlumnos));
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            if (Login.UsuarioActual?.Persona?.Tipo == Persona.TiposPersonas.Administrador)
            {
                OpenForm(new Forms.Personas.Personas(Persona.TiposPersonas.Alumno));
            }
            else
            {
                OpenForm(new Forms.Inscripciones.Inscripciones(Login.UsuarioActual!.Persona!));
            }
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            if (Login.UsuarioActual?.Persona?.Tipo == Persona.TiposPersonas.Administrador)
            {
                OpenForm(new Forms.Personas.Personas(Persona.TiposPersonas.Docente));
            }
            else
            {
                OpenForm(new Forms.RegistrarNotas.RegistrarNotas(Login.UsuarioActual!.Persona!));
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            panelFormLoader.Controls.OfType<ApplicationForm>().FirstOrDefault()?.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            panelFormLoader.Controls.Clear();
            panelDashboard.Visible = true;
            var persona = Login.UsuarioActual?.Persona;
            lblTitulo.Text = persona != null ? $"Bienvenido/a {persona.Nombre} {persona.Apellido}" : "Academia TPI";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void panelFormLoader_ControlAdded(object sender, ControlEventArgs e)
        {
            panelBottom.Visible = true;
        }

        private void panelFormLoader_ControlRemoved(object sender, ControlEventArgs e)
        {
            panelBottom.Visible = false;
            if (panelFormLoader.Controls.Count == 0)
            {
                panelDashboard.Visible = true;
                if (Login.UsuarioActual?.Persona != null)
                    lblTitulo.Text = $"Bienvenido/a {Login.UsuarioActual.Persona.Nombre} {Login.UsuarioActual.Persona.Apellido}";
            }
        }
    }
}
