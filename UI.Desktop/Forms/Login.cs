using Contratos;

namespace UI.Desktop
{
    public partial class Login : ApplicationForm
    {
        public Login()
        {
            InitializeComponent();
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

            try
            {
                var respuesta = ApiEscritorio.Auth
                    .LoginAsync(txtUsuario.Text, txtClave.Text)
                    .GetAwaiter().GetResult();

                if (respuesta == null || !respuesta.Habilitado || string.IsNullOrEmpty(respuesta.Token))
                {
                    Notificar("Información inválida", "Usuario o clave incorrectos.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                SesionEscritorio.Iniciar(respuesta);
                return true;
            }
            catch (ApiException ex)
            {
                Notificar("Información inválida", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
