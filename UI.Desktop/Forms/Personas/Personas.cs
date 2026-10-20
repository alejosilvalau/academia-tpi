using Contratos;
using Utils;

namespace UI.Desktop.Forms.Personas
{
    public partial class Personas : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvPersonas;
        private readonly TipoPersona? _filtroTipo;

        public Personas()
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
            dgvPersonas.CellFormatting += (s, e) =>
            {
                if (e.Value is string v && e.ColumnIndex >= 0)
                {
                    var colName = dgvPersonas.Columns[e.ColumnIndex].Name;
                    if (colName is "Nombre" or "Apellido" or "EMail")
                        e.Value = Formato.ToTitleCase(v);
                }
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        public Personas(TipoPersona tipo) : this()
        {
            _filtroTipo = tipo;
            Text = tipo == TipoPersona.Alumno ? "Inscripciones" : "Registrar Notas";

            tsbAgregar.Visible = false;
            tsbEditar.Visible = false;
            tsbEliminar.Visible = false;
            tsbSeleccionar.Visible = true;
        }

        private void Personas_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                dgvPersonas.DataSource = null;
                if (_filtroTipo.HasValue)
                    dgvPersonas.DataSource = await ApiEscritorio.Persona.GetByTipoAsync(_filtroTipo.Value);
                else
                    dgvPersonas.DataSource = await ApiEscritorio.Persona.GetAllAsync();
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            new PersonaDialog(ModoForm.Alta).ShowDialog();
            await ListarAsync();
        }

        private async void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPersonas)) return;
            int id = ((PersonaDto)dgvPersonas.SelectedRows[0].DataBoundItem).Id;
            new PersonaDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvPersonas);
            await ListarAsync();
            SeleccionarFila(dgvPersonas, id);
            DescongelarGrilla(dgvPersonas);
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPersonas)) return;
            int id = ((PersonaDto)dgvPersonas.SelectedRows[0].DataBoundItem).Id;
            new PersonaDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvPersonas);
            await ListarAsync();
            SeleccionarFila(dgvPersonas, id);
            DescongelarGrilla(dgvPersonas);
        }

        private void tsbSeleccionar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPersonas)) return;
            var personaSeleccionada = (PersonaDto)dgvPersonas.SelectedRows[0].DataBoundItem;

            if (_filtroTipo == TipoPersona.Alumno)
            {
                var form = new Forms.Inscripciones.Inscripciones(personaSeleccionada.Id, admin: true);
                form.ShowDialog();
            }
            else if (_filtroTipo == TipoPersona.Docente)
            {
                var form = new Forms.RegistrarNotas.RegistrarNotas(personaSeleccionada.Id);
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
