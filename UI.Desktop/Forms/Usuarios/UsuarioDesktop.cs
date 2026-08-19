using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Usuarios
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private readonly UsuarioServicio _servicio;
        private readonly PersonaServicio _personaServicio;
        private Usuario? _usuario;

        public UsuarioDesktop() : base()
        {
            InitializeComponent();
            _servicio = new UsuarioServicio(new AcademiaContext());
            _personaServicio = new PersonaServicio(new AcademiaContext());
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            cbxPersona.DataSource = _personaServicio.GetAll();
            SetModo();
        }

        public UsuarioDesktop(int id, ModoForm modo) : this(modo)
        {
            _usuario = _servicio.GetOne(id);
            MapearDeDatos();
        }

        private void SetModo()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion: btnAceptar.Text = "Guardar"; break;
                case ModoForm.Baja: btnAceptar.Text = "Eliminar"; break;
                case ModoForm.Consulta: btnAceptar.Text = "Aceptar"; break;
            }
        }

        public override void MapearDeDatos()
        {
            if (_usuario == null) return;
            txtID.Text = _usuario.ID.ToString();
            txtUsuario.Text = _usuario.NombreUsuario;
            txtClave.Text = _usuario.Clave;
            chkHabilitado.Checked = _usuario.Habilitado;
            cbxPersona.SelectedValue = _usuario.PersonaId;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) _usuario = new Usuario();
            if (_usuario == null) return;
            _usuario.NombreUsuario = txtUsuario.Text;
            _usuario.Clave = txtClave.Text;
            _usuario.Habilitado = chkHabilitado.Checked;
            if (cbxPersona.SelectedItem is Persona pers) _usuario.Persona = pers;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            if (_usuario == null) return;
            if (Modo == ModoForm.Baja) _servicio.Delete(_usuario);
            else if (Modo == ModoForm.Alta) _servicio.Save(_usuario);
            else _servicio.Update(_usuario);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try { GuardarCambios(); Close(); }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
