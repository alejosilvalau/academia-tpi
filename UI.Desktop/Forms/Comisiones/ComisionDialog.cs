using Contratos;
using Utils;

namespace UI.Desktop.Forms.Comisiones
{
    public partial class ComisionDialog : ApplicationForm
    {
        private int? _id;

        public ComisionDialog() : base()
        {
            InitializeComponent();
        }

        public ComisionDialog(ModoForm modo) : this()
        {
            Modo = modo;
            CargarPlanes();
            SetModo();
        }

        public ComisionDialog(int id, ModoForm modo) : this(modo)
        {
            _id = id;
            var comision = ApiEscritorio.Comision.GetOneAsync(id).GetAwaiter().GetResult();
            if (comision != null) MapearDeDatos(comision);
        }

        private void CargarPlanes()
        {
            var planes = ApiEscritorio.Plan.GetAllAsync().GetAwaiter().GetResult();
            cbxPlan.DataSource = planes
                .Select(p => new { p.Id, Descripcion = Formato.ToTitleCase(p.Descripcion) }).ToList();
            cbxPlan.DisplayMember = "Descripcion";
            cbxPlan.ValueMember = "Id";
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

        public void MapearDeDatos(ComisionDto comision)
        {
            txtID.Text = comision.Id.ToString();
            txtDescripcion.Text = Formato.ToTitleCase(comision.Descripcion);
            txtAnioEspecialidad.Text = comision.AnioEspecialidad.ToString();
            cbxPlan.SelectedValue = comision.PlanId;
        }

        public override void MapearDeDatos() { }

        private ComisionRequest ConstruirRequest()
        {
            int.TryParse(txtAnioEspecialidad.Text, out int anio);
            return new ComisionRequest
            {
                Descripcion = txtDescripcion.Text,
                AnioEspecialidad = anio,
                PlanId = cbxPlan.SelectedValue is int planId ? planId : 0
            };
        }

        public override async Task GuardarCambiosAsync()
        {
            if (Modo == ModoForm.Baja && _id.HasValue)
                await ApiEscritorio.Comision.DeleteAsync(_id.Value);
            else if (Modo == ModoForm.Alta)
                await ApiEscritorio.Comision.SaveAsync(ConstruirRequest());
            else if (_id.HasValue)
                await ApiEscritorio.Comision.UpdateAsync(_id.Value, ConstruirRequest());
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
