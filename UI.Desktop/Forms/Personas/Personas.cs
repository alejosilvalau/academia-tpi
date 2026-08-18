using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Personas
{
    public partial class Personas : ApplicationForm
    {
        private readonly PersonaServicio _servicio;
        private readonly Persona.TiposPersonas? _filtroTipo;

        public Personas()
        {
            InitializeComponent();
            _servicio = new PersonaServicio(new AcademiaContext());
            dgvPersonas.AutoGenerateColumns = false;
        }

        public Personas(Persona.TiposPersonas tipo) : this()
        {
            _filtroTipo = tipo;
            Text = $"Personas - {tipo}";
        }

        private void Personas_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                if (_filtroTipo.HasValue)
                    dgvPersonas.DataSource = _servicio.GetByTipo(_filtroTipo.Value);
                else
                    dgvPersonas.DataSource = _servicio.GetAll();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new PersonaDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPersonas)) return;
            int id = ((Persona)dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            new PersonaDesktop(id, ModoForm.Modificacion).ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPersonas)) return;
            int id = ((Persona)dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            new PersonaDesktop(id, ModoForm.Baja).ShowDialog();
            Listar();
        }
    }
}
