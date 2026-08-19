using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Planes
{
    public partial class PlanDesktop : ApplicationForm
    {
        private readonly PlanServicio _planServicio;
        private readonly EspecialidadServicio _especialidadServicio;
        private Plan? _plan;

        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            SetModo();
        }

        public PlanDesktop(int id, ModoForm modo) : this(modo)
        {
            _plan = _planServicio.GetOne(id);
            MapearDeDatos();
        }

        public PlanDesktop() : base()
        {
            InitializeComponent();
            _planServicio = new PlanServicio(new AcademiaContext());
            _especialidadServicio = new EspecialidadServicio(new AcademiaContext());
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
                _plan.Especialidad = (Especialidad)cbxEspecialidad.SelectedItem;
            }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtDescripcion.Text }) || cbxEspecialidad.SelectedValue == null)
            {
                Notificar("Información inválida", "Complete los campos para continuar.");
                return false;
            }
            return true;
        }

        public override void GuardarCambios()
        {
            try
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
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar()) { GuardarCambios(); Close(); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
