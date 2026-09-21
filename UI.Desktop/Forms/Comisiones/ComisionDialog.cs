using Dominio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Comisiones
{
    public partial class ComisionDialog : ApplicationForm
    {
        private readonly ComisionServicio _servicio;
        private readonly PlanServicio _planServicio;
        private Comision? _comision;

        public ComisionDialog() : base()
        {
            InitializeComponent();
            _servicio = ServicioFactory.Comision();
            _planServicio = ServicioFactory.Plan();
        }

        public ComisionDialog(ModoForm modo) : this()
        {
            Modo = modo;
            cbxPlan.DataSource = _planServicio.GetAll();
            SetModo();
        }

        public ComisionDialog(int id, ModoForm modo) : this(modo)
        {
            _comision = _servicio.GetOne(id);
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
            if (_comision == null) return;
            txtID.Text = _comision.ID.ToString();
            txtDescripcion.Text = Formato.ToTitleCase(_comision.Descripcion);
            txtAnioEspecialidad.Text = _comision.AnioEspecialidad.ToString();
            cbxPlan.SelectedValue = _comision.PlanId;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) _comision = new Comision();
            if (_comision == null) return;
            _comision.Descripcion = txtDescripcion.Text;
            int.TryParse(txtAnioEspecialidad.Text, out int anio);
            _comision.AnioEspecialidad = anio;
            if (cbxPlan.SelectedValue is int planId) _comision.PlanId = planId;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            if (_comision == null) return;
            if (Modo == ModoForm.Baja) _servicio.Delete(_comision);
            else if (Modo == ModoForm.Alta) _servicio.Save(_comision);
            else _servicio.Update(_comision);
        }

        public override bool Validar()
        {
            Validaciones.AsegurarDescripcion(txtDescripcion.Text, "Descripción");
            Validaciones.AsegurarEnteroParseable(txtAnioEspecialidad.Text, "Año Especialidad");
            Validaciones.AsegurarPositivo(int.Parse(txtAnioEspecialidad.Text), "Año Especialidad");
            if (cbxPlan.SelectedValue == null)
                throw new ArgumentException("El campo Plan es obligatorio.");
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;
                GuardarCambios();
                Close();
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

    }
}
