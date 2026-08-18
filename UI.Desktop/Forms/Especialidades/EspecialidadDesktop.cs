using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Especialidades
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        private readonly EspecialidadServicio _servicio;
        private Especialidad? _especialidad;

        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            SetModo();
        }

        public EspecialidadDesktop(int id, ModoForm modo) : this(modo)
        {
            _especialidad = _servicio.GetOne(id);
            MapearDeDatos();
        }

        public EspecialidadDesktop() : base()
        {
            InitializeComponent();
            _servicio = new EspecialidadServicio(new AcademiaContext());
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

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtDescripcion.Text }))
            {
                Notificar("Informacion invalida", "Complete los campos para continuar.");
                return false;
            }
            return true;
        }

        public override void GuardarCambios()
        {
            try
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
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar()) { GuardarCambios(); Close(); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
