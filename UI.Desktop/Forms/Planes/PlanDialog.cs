using Contratos;
using Utils;

namespace UI.Desktop.Forms.Planes
{
    public partial class PlanDialog : ApplicationForm
    {
        private int? _id;

        public PlanDialog(ModoForm modo) : this()
        {
            Modo = modo;
            CargarEspecialidades();
            SetModo();
        }

        public PlanDialog(int id, ModoForm modo) : this(modo)
        {
            _id = id;
            var plan = ApiEscritorio.Plan.GetOneAsync(id).GetAwaiter().GetResult();
            if (plan != null) MapearDeDatos(plan);
        }

        public PlanDialog() : base()
        {
            InitializeComponent();
        }

        private void CargarEspecialidades()
        {
            var especialidades = ApiEscritorio.Especialidad.GetAllAsync().GetAwaiter().GetResult();
            cbxEspecialidad.DataSource = especialidades
                .Select(e => new { e.Id, Descripcion = Formato.ToTitleCase(e.Descripcion) }).ToList();
            cbxEspecialidad.DisplayMember = "Descripcion";
            cbxEspecialidad.ValueMember = "Id";
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

        public void MapearDeDatos(PlanDto plan)
        {
            txtID.Text = plan.Id.ToString();
            txtDescripcion.Text = Formato.ToTitleCase(plan.Descripcion);
            cbxEspecialidad.SelectedValue = plan.EspecialidadId;
        }

        public override void MapearDeDatos() { }

        private PlanRequest ConstruirRequest() => new()
        {
            Descripcion = txtDescripcion.Text,
            EspecialidadId = cbxEspecialidad.SelectedValue is int espId ? espId : 0
        };

        public override async Task GuardarCambiosAsync()
        {
            if (Modo == ModoForm.Baja && _id.HasValue)
                await ApiEscritorio.Plan.DeleteAsync(_id.Value);
            else if (Modo == ModoForm.Alta)
                await ApiEscritorio.Plan.SaveAsync(ConstruirRequest());
            else if (_id.HasValue)
                await ApiEscritorio.Plan.UpdateAsync(_id.Value, ConstruirRequest());
        }

        public override bool Validar()
        {
            Validaciones.AsegurarDescripcion(txtDescripcion.Text, "Descripción");
            if (cbxEspecialidad.SelectedValue == null)
                throw new ArgumentException("El campo Especialidad es obligatorio.");
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
