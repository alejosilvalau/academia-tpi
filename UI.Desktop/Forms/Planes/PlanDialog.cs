using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Planes
{
    public partial class PlanDialog : ApplicationForm
    {
        private readonly PlanServicio _planServicio;
        private readonly EspecialidadServicio _especialidadServicio;
        private Plan? _plan;

        public PlanDialog(ModoForm modo) : this()
        {
            Modo = modo;
            SetModo();
        }

        public PlanDialog(int id, ModoForm modo) : this(modo)
        {
            _plan = _planServicio.GetOne(id);
            MapearDeDatos();
        }

        public PlanDialog() : base()
        {
            InitializeComponent();
            _planServicio = new PlanServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            _especialidadServicio = new EspecialidadServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            CargarEspecialidades();
        }

        private void CargarEspecialidades()
        {
            cbxEspecialidad.DataSource = _especialidadServicio.GetAll();
            cbxEspecialidad.DisplayMember = "Descripcion";
            cbxEspecialidad.ValueMember = "ID";
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
            if (_plan == null) return;
            txtID.Text = _plan.ID.ToString();
            txtDescripcion.Text = _plan.Descripcion;
            cbxEspecialidad.SelectedValue = _plan.EspecialidadId;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
                _plan = new Plan();
            if (_plan == null) return;
            _plan.Descripcion = txtDescripcion.Text;
            if (cbxEspecialidad.SelectedValue != null)
            {
                int espId = (int)cbxEspecialidad.SelectedValue;
                _plan.EspecialidadId = espId;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            if (_plan == null) return;
            if (Modo == ModoForm.Baja)
                _planServicio.Delete(_plan);
            else if (Modo == ModoForm.Alta)
                _planServicio.Save(_plan);
            else
                _planServicio.Update(_plan);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try { GuardarCambios(); Close(); }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
