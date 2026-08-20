using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Personas
{
    public partial class PersonaDialog : ApplicationForm
    {
        private readonly PersonaServicio _servicio;
        private readonly PlanServicio _planServicio;
        private Persona? _persona;

        public PersonaDialog() : base()
        {
            InitializeComponent();
            _servicio = new PersonaServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            _planServicio = new PlanServicio(new AcademiaContext(), new UsuarioContextoDesktop());
        }

        public PersonaDialog(ModoForm modo) : this()
        {
            Modo = modo;
            cbxPlan.DataSource = _planServicio.GetAll();
            cbxTipo.DataSource = EnumHelper.GetEnumItems<Persona.TiposPersonas>();
            cbxTipo.DisplayMember = "Display";
            cbxTipo.ValueMember = "Value";
            SetModo();
        }

        public PersonaDialog(int id, ModoForm modo) : this(modo)
        {
            _persona = _servicio.GetOne(id);
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
            if (_persona == null) return;
            txtID.Text = _persona.ID.ToString();
            txtNombre.Text = _persona.Nombre;
            txtApellido.Text = _persona.Apellido;
            txtLegajo.Text = _persona.Legajo.ToString();
            txtEMail.Text = _persona.EMail;
            txtDireccion.Text = _persona.Direccion;
            txtTelefono.Text = _persona.Telefono;
            dtpFechaNacimiento.Value = _persona.FechaNacimiento;
            cbxTipo.SelectedItem = _persona.Tipo;
            if (_persona.PlanId.HasValue) cbxPlan.SelectedValue = _persona.PlanId.Value;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) _persona = new Persona();
            if (_persona == null) return;
            _persona.Nombre = txtNombre.Text;
            _persona.Apellido = txtApellido.Text;
            int.TryParse(txtLegajo.Text, out int legajo);
            _persona.Legajo = legajo;
            _persona.EMail = txtEMail.Text;
            _persona.Direccion = txtDireccion.Text;
            _persona.Telefono = txtTelefono.Text;
            _persona.FechaNacimiento = dtpFechaNacimiento.Value;
            if (cbxTipo.SelectedItem is Persona.TiposPersonas tipo) _persona.Tipo = tipo;
            if (cbxPlan.SelectedValue is int planId) _persona.PlanId = planId;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            if (_persona == null) return;
            if (Modo == ModoForm.Baja) _servicio.Delete(_persona);
            else if (Modo == ModoForm.Alta) _servicio.Save(_persona);
            else _servicio.Update(_persona);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try { GuardarCambios(); Close(); }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
