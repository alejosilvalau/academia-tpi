using Contratos;
using Utils;

namespace UI.Desktop.Forms.Usuarios
{
    public partial class UsuarioDialog : ApplicationForm
    {
        private int? _id;

        public UsuarioDialog() : base()
        {
            InitializeComponent();
        }

        public UsuarioDialog(ModoForm modo) : this()
        {
            Modo = modo;
            CargarPersonas();
            SetModo();
        }

        public UsuarioDialog(int id, ModoForm modo) : this(modo)
        {
            _id = id;
            var usuario = ApiEscritorio.Usuario.GetOneAsync(id).GetAwaiter().GetResult();
            if (usuario != null) MapearDeDatos(usuario);
        }

        private void CargarPersonas()
        {
            var personas = ApiEscritorio.Persona.GetAllAsync().GetAwaiter().GetResult();
            cbxPersona.DataSource = personas
                .Select(p => new { p.Id, Display = $"{Formato.ToTitleCase(p.Nombre)} {Formato.ToTitleCase(p.Apellido)}" }).ToList();
            cbxPersona.DisplayMember = "Display";
            cbxPersona.ValueMember = "Id";
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

        public void MapearDeDatos(UsuarioDto usuario)
        {
            txtID.Text = usuario.Id.ToString();
            txtUsuario.Text = usuario.NombreUsuario;
            txtClave.Text = "";
            chkHabilitado.Checked = usuario.Habilitado;
            if (usuario.PersonaId.HasValue) cbxPersona.SelectedValue = usuario.PersonaId.Value;
        }

        public override void MapearDeDatos() { }

        private UsuarioRequest ConstruirRequest() => new()
        {
            NombreUsuario = txtUsuario.Text,
            Clave = string.IsNullOrWhiteSpace(txtClave.Text) ? null : txtClave.Text,
            Habilitado = chkHabilitado.Checked,
            PersonaId = cbxPersona.SelectedValue is int personaId ? personaId : null
        };

        public override async Task GuardarCambiosAsync()
        {
            if (Modo == ModoForm.Baja && _id.HasValue)
                await ApiEscritorio.Usuario.DeleteAsync(_id.Value);
            else if (Modo == ModoForm.Alta)
                await ApiEscritorio.Usuario.SaveAsync(ConstruirRequest());
            else if (_id.HasValue)
                await ApiEscritorio.Usuario.UpdateAsync(_id.Value, ConstruirRequest());
        }

        public override bool Validar()
        {
            Validaciones.AsegurarLongitudUsuario(txtUsuario.Text);
            if (Modo == ModoForm.Alta)
                Validaciones.AsegurarClave(txtClave.Text);
            if (cbxPersona.SelectedValue == null)
                throw new ArgumentException("El campo Persona es obligatorio.");
            return true;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;
                await GuardarCambiosAsync();
                Close();
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
