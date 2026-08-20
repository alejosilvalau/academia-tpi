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
            _servicio = new PersonaServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            dgvPersonas.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        public Personas(Persona.TiposPersonas tipo) : this()
        {
            _filtroTipo = tipo;
            Text = $"Personas - {tipo}";

            tsbAgregar.Visible = false;
            tsbEditar.Visible = false;
            tsbEliminar.Visible = false;
            tsbSeleccionar.Visible = true;
        }

        private void Personas_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                dgvPersonas.DataSource = null;
                if (_filtroTipo.HasValue)
                    dgvPersonas.DataSource = _servicio.GetByTipo(_filtroTipo.Value);
                else
                    dgvPersonas.DataSource = _servicio.GetAll();
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new PersonaDialog(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPersonas)) return;
            int id = ((Persona)dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            new PersonaDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvPersonas);
            Listar();
            SeleccionarFila(dgvPersonas, id);
            DescongelarGrilla(dgvPersonas);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPersonas)) return;
            int id = ((Persona)dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            new PersonaDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvPersonas);
            Listar();
            SeleccionarFila(dgvPersonas, id);
            DescongelarGrilla(dgvPersonas);
        }

        private void tsbSeleccionar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPersonas)) return;
            var personaSeleccionada = (Persona)dgvPersonas.SelectedRows[0].DataBoundItem;

            if (_filtroTipo == Persona.TiposPersonas.Alumno)
            {
                var form = new Forms.Inscripciones.Inscripciones(personaSeleccionada, admin: true);
                form.ShowDialog();
            }
            else if (_filtroTipo == Persona.TiposPersonas.Docente)
            {
                var form = new Forms.RegistrarNotas.RegistrarNotas(personaSeleccionada);
                form.ShowDialog();
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tsbSeleccionar.Visible)
                tsbSeleccionar_Click(sender, e);
            else
                tsbEditar_Click(sender, e);
        }
    }
}
