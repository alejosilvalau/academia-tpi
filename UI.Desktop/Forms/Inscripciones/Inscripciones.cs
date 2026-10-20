using Contratos;
using Utils;

namespace UI.Desktop.Forms.Inscripciones
{
    public partial class Inscripciones : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvInscripciones;
        private readonly int _alumnoId;

        public Inscripciones(int alumnoId, bool admin = false)
        {
            InitializeComponent();
            _alumnoId = alumnoId;
            dgvInscripciones.AutoGenerateColumns = false;
            dgvInscripciones.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvInscripciones.Columns[e.ColumnIndex].Name;
                if (dgvInscripciones.Rows[e.RowIndex].DataBoundItem is InscripcionDto ins)
                {
                    if (colName == "DescripcionMateria")
                        e.Value = Formato.ToTitleCase(ins.CursoMateriaDescripcion ?? "");
                    else if (colName == "Legajo")
                        e.Value = ins.AlumnoLegajo;
                }
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);

            if (!admin)
            {
                tsbEliminar.Visible = false;
            }
        }

        private void Inscripciones_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                dgvInscripciones.DataSource = null;
                dgvInscripciones.DataSource = await ApiEscritorio.Inscripcion.GetByAlumnoAsync(_alumnoId);
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            new InscripcionDialog(_alumnoId, ModoForm.Alta).ShowDialog();
            await ListarAsync();
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvInscripciones)) return;
            int id = ((InscripcionDto)dgvInscripciones.SelectedRows[0].DataBoundItem).Id;
            new InscripcionDialog(_alumnoId, id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvInscripciones);
            await ListarAsync();
            SeleccionarFila(dgvInscripciones, id);
            DescongelarGrilla(dgvInscripciones);
        }
    }
}
