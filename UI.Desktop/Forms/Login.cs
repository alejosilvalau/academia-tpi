using Dominio;
using Repositorio;
using Servicios;
using System.Runtime.InteropServices;

namespace UI.Desktop
{
    public partial class Login : ApplicationForm
    {
        private readonly UsuarioServicio _usuarioServicio;

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static Usuario? UsuarioActual { get; private set; }

        public Login()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio(new AcademiaContext());
        }

        private void appLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
                if (txt.Text == "Contrasena") { txt.Text = ""; txt.ForeColor = MaterialColors.TextPrimary; txt.PasswordChar = '*'; }
                else if (txt.Text == "") { txt.ForeColor = MaterialColors.TextSecondary; txt.Text = "Contrasena"; txt.PasswordChar = '\0'; }
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || txtUsuario.Text == "Usuario" ||
                string.IsNullOrEmpty(txtClave.Text) || txtClave.Text == "Contrasena")
            {
                Notificar("Informacion invalida", "Complete todos los campos para continuar.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            UsuarioActual = _usuarioServicio.Login(txtUsuario.Text, txtClave.Text);
            if (UsuarioActual == null)
            {
                Notificar("Informacion invalida", "Usuario y/o contrasena incorrectos.",
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
