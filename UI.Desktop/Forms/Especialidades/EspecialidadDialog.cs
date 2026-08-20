using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Especialidades
{
    public partial class EspecialidadDialog : ApplicationForm
    {
        private readonly EspecialidadServicio _servicio;
        private Especialidad? _especialidad;

        public EspecialidadDialog(ModoForm modo) : this()
        {
            Modo = modo;
            SetModo();
        }

        public EspecialidadDialog(int id, ModoForm modo) : this(modo)
        {
            _especialidad = _servicio.GetOne(id);
            MapearDeDatos();
        }

        public EspecialidadDialog() : base()
        {
            InitializeComponent();
            _servicio = new EspecialidadServicio(new AcademiaContext(), new UsuarioContextoDesktop());
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
            if (_especialidad == null) return;
            txtID.Text = _especialidad.ID.ToString();
            txtDescripcion.Text = _especialidad.Descripcion;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
                _especialidad = new Especialidad();
            if (_especialidad == null) return;
            _especialidad.Descripcion = txtDescripcion.Text;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            if (_especialidad == null) return;
            if (Modo == ModoForm.Baja)
                _servicio.Delete(_especialidad);
            else if (Modo == ModoForm.Alta)
                _servicio.Save(_especialidad);
            else
                _servicio.Update(_especialidad);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try { GuardarCambios(); Close(); }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
