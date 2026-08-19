using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop
{
    public partial class Main : ApplicationForm
    {
        private readonly PersonaServicio _personaServicio;

        public Main()
        {
            InitializeComponent();
            _personaServicio = new PersonaServicio(new AcademiaContext());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Login.UsuarioActual?.Persona != null)
            {
                var persona = Login.UsuarioActual.Persona;
                lblTitulo.Text = $"Bienvenido/a {persona.Nombre} {persona.Apellido}";
                lblUsuario.Text = Login.UsuarioActual.NombreUsuario;
                lblTipo.Text = persona.Tipo.ToString();
            }

            panelSubMenu.Visible = false;
            btnAdministracion.Visible = Login.UsuarioActual?.Persona?.Tipo == Persona.TiposPersonas.Administrador;
            btnReportes.Visible = Login.UsuarioActual?.Persona?.Tipo == Persona.TiposPersonas.Administrador;
            btnInscripcion.Visible = true;
            btnNotas.Visible = true;
        }

        internal void OpenForm(ApplicationForm form)
        {
            panelSubMenu.Visible = false;
            panelFormLoader.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.TopMost = true;
            panelFormLoader.Controls.Add(form);
            lblTitulo.Text = form.Text;
            form.Show();
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
                    btn.Visible = btn.Name.Contains(category);
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

        private void btnABMMaterias_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Materias.Materias());
        }

        private void btnABMPersonas_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Personas.Personas());
        }

        private void btnABMPlanes_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Planes.Planes());
        }

        private void btnABMDictados_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Dictados.Dictados());
        }

        private void btnABMUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Usuarios.Usuarios());
        }

        private void btnReportesCursos_Click(object sender, EventArgs e)
        {
            OpenForm(new RViewerCursos());
        }

        private void btnReportesPlanes_Click(object sender, EventArgs e)
        {
            OpenForm(new RViewerPlanes());
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
            lblTitulo.Text = $"Bienvenido/a {Login.UsuarioActual?.Persona}";
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
            if (Login.UsuarioActual?.Persona != null)
                lblTitulo.Text = $"Bienvenido/a {Login.UsuarioActual.Persona.Nombre} {Login.UsuarioActual.Persona.Apellido}";
        }
    }
}
