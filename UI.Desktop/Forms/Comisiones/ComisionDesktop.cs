using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Comisiones
{
    public partial class ComisionDesktop : ApplicationForm
    {
        private readonly ComisionServicio _servicio;
        private readonly PlanServicio _planServicio;
        private Comision? _comision;

        public ComisionDesktop() : base()
        {
            InitializeComponent();
            _servicio = new ComisionServicio(new AcademiaContext());
            _planServicio = new PlanServicio(new AcademiaContext());
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            cbxPlan.DataSource = _planServicio.GetAll();
            SetModo();
        }

        public ComisionDesktop(int id, ModoForm modo) : this(modo)
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
            txtDescripcion.Text = _comision.Descripcion;
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
            if (cbxPlan.SelectedItem is Plan plan) _comision.Plan = plan;
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtDescripcion.Text, txtAnioEspecialidad.Text }))
            { Notificar("Información inválida", "Complete los campos para continuar."); return false; }
            return true;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                if (_comision == null) return;
                if (Modo == ModoForm.Baja) _servicio.Delete(_comision);
                else if (Modo == ModoForm.Alta) _servicio.Save(_comision);
                else _servicio.Update(_comision);
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { if (Validar()) { GuardarCambios(); Close(); } }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
