using Contratos;
using Utils;

namespace UI.Desktop.Forms.Materias
{
    public partial class MateriaDialog : ApplicationForm
    {
        private int? _id;

        public MateriaDialog() : base()
        {
            InitializeComponent();
        }

        public MateriaDialog(ModoForm modo) : this()
        {
            Modo = modo;
            CargarPlanes();
            SetModo();
        }

        public MateriaDialog(int planId) : this()
        {
            Modo = ModoForm.Alta;
            CargarPlanes();
            cbxPlan.SelectedValue = planId;
            cbxPlan.Enabled = false;
            SetModo();
        }

        public MateriaDialog(int id, ModoForm modo) : this(modo)
        {
            _id = id;
            var materia = ApiEscritorio.Materia.GetOneAsync(id).GetAwaiter().GetResult();
            if (materia != null) MapearDeDatos(materia);
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

        public void MapearDeDatos(MateriaDto materia)
        {
            txtID.Text = materia.Id.ToString();
            txtDescripcion.Text = Formato.ToTitleCase(materia.Descripcion);
            txtHsSemanales.Text = materia.HorasSemanales.ToString();
            txtHsTotales.Text = materia.HorasTotales.ToString();
            cbxPlan.SelectedValue = materia.PlanId;
        }

        public override void MapearDeDatos() { }

        private MateriaRequest ConstruirRequest()
        {
            int.TryParse(txtHsSemanales.Text, out int hsSem);
            int.TryParse(txtHsTotales.Text, out int hsTot);
            return new MateriaRequest
            {
                Descripcion = txtDescripcion.Text,
                HorasSemanales = hsSem,
                HorasTotales = hsTot,
                PlanId = cbxPlan.SelectedValue is int planId ? planId : 0
            };
        }

        public override async Task GuardarCambiosAsync()
        {
            if (Modo == ModoForm.Baja && _id.HasValue)
                await ApiEscritorio.Materia.DeleteAsync(_id.Value);
            else if (Modo == ModoForm.Alta)
                await ApiEscritorio.Materia.SaveAsync(ConstruirRequest());
            else if (_id.HasValue)
                await ApiEscritorio.Materia.UpdateAsync(_id.Value, ConstruirRequest());
        }

        public override bool Validar()
        {
            Validaciones.AsegurarDescripcion(txtDescripcion.Text, "Descripción");
            Validaciones.AsegurarEnteroParseable(txtHsSemanales.Text, "Horas Semanales");
            Validaciones.AsegurarPositivo(int.Parse(txtHsSemanales.Text), "Horas Semanales");
            Validaciones.AsegurarEnteroParseable(txtHsTotales.Text, "Horas Totales");
            Validaciones.AsegurarPositivo(int.Parse(txtHsTotales.Text), "Horas Totales");
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
