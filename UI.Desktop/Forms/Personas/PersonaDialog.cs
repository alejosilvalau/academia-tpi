using Contratos;
using Utils;

namespace UI.Desktop.Forms.Personas
{
    public partial class PersonaDialog : ApplicationForm
    {
        private int? _id;

        public PersonaDialog() : base()
        {
            InitializeComponent();
        }

        public PersonaDialog(ModoForm modo) : this()
        {
            Modo = modo;
            CargarCatalogos();
            SetModo();
        }

        public PersonaDialog(int id, ModoForm modo) : this(modo)
        {
            _id = id;
            var persona = ApiEscritorio.Persona.GetOneAsync(id).GetAwaiter().GetResult();
            if (persona != null) MapearDeDatos(persona);
        }

        private void CargarCatalogos()
        {
            var planes = ApiEscritorio.Plan.GetAllAsync().GetAwaiter().GetResult();
            cbxPlan.DataSource = planes
                .Select(p => new { p.Id, Descripcion = Formato.ToTitleCase(p.Descripcion) }).ToList();
            cbxPlan.DisplayMember = "Descripcion";
            cbxPlan.ValueMember = "Id";
            cbxTipo.DataSource = EnumHelper.GetEnumItems<TipoPersona>();
            cbxTipo.DisplayMember = "Display";
            cbxTipo.ValueMember = "Value";
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

        public void MapearDeDatos(PersonaDto persona)
        {
            txtID.Text = persona.Id.ToString();
            txtNombre.Text = Formato.ToTitleCase(persona.Nombre);
            txtApellido.Text = Formato.ToTitleCase(persona.Apellido);
            txtLegajo.Text = persona.Legajo.ToString();
            txtEMail.Text = Formato.ToTitleCase(persona.EMail);
            txtDireccion.Text = Formato.ToTitleCase(persona.Direccion);
            txtTelefono.Text = persona.Telefono;
            dtpFechaNacimiento.Value = persona.FechaNacimiento;
            cbxTipo.SelectedItem = persona.Tipo;
            if (persona.PlanId.HasValue) cbxPlan.SelectedValue = persona.PlanId.Value;
        }

        public override void MapearDeDatos() { }

        private PersonaRequest ConstruirRequest()
        {
            int.TryParse(txtLegajo.Text, out int legajo);
            return new PersonaRequest
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Legajo = legajo,
                EMail = txtEMail.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                Tipo = cbxTipo.SelectedItem is TipoPersona tipo ? tipo : TipoPersona.Alumno,
                PlanId = cbxPlan.SelectedValue is int planId ? planId : null
            };
        }

        public override async Task GuardarCambiosAsync()
        {
            if (Modo == ModoForm.Baja && _id.HasValue)
                await ApiEscritorio.Persona.DeleteAsync(_id.Value);
            else if (Modo == ModoForm.Alta)
                await ApiEscritorio.Persona.SaveAsync(ConstruirRequest());
            else if (_id.HasValue)
                await ApiEscritorio.Persona.UpdateAsync(_id.Value, ConstruirRequest());
        }

        public override bool Validar()
        {
            Validaciones.AsegurarNombreOApellido(txtNombre.Text, "Nombre");
            Validaciones.AsegurarNombreOApellido(txtApellido.Text, "Apellido");
            Validaciones.AsegurarEnteroParseable(txtLegajo.Text, "Legajo");
            Validaciones.AsegurarPositivo(int.Parse(txtLegajo.Text), "Legajo");
            Validaciones.AsegurarEmail(txtEMail.Text);
            Validaciones.AsegurarTelefono(txtTelefono.Text);
            if (cbxTipo.SelectedItem == null)
                throw new ArgumentException("El campo Tipo es obligatorio.");
            if (cbxPlan.SelectedValue == null)
                throw new ArgumentException("El campo Plan es obligatorio.");
            return true;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modo is not (ModoForm.Baja or ModoForm.Consulta) && !Validar()) return;
                await GuardarCambiosAsync();
                Close();
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
