using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop
{
    public partial class Login : ApplicationForm
    {
        private readonly UsuarioServicio _usuarioServicio;

        public static Usuario? UsuarioActual { get; private set; }

        public Login()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio(new AcademiaContext());
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_EnterLeave(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (sender == txtUsuario)
            {
                if (txt.Text == "Usuario") { txt.Text = ""; txt.ForeColor = MaterialColors.TextPrimary; }
                else if (txt.Text == "") { txt.ForeColor = MaterialColors.TextSecondary; txt.Text = "Usuario"; }
            }
            else
            {
                if (txt.Text == "Contraseña") { txt.Text = ""; txt.ForeColor = MaterialColors.TextPrimary; txt.PasswordChar = '*'; }
                else if (txt.Text == "") { txt.ForeColor = MaterialColors.TextSecondary; txt.Text = "Contraseña"; txt.PasswordChar = '\0'; }
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || txtUsuario.Text == "Usuario" ||
                string.IsNullOrEmpty(txtClave.Text) || txtClave.Text == "Contraseña")
            {
                Notificar("Información inválida", "Complete todos los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            UsuarioActual = _usuarioServicio.Login(txtUsuario.Text, txtClave.Text);
            if (UsuarioActual == null)
            {
                Notificar("Información inválida", "Usuario y/o contraseña incorrectos.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
