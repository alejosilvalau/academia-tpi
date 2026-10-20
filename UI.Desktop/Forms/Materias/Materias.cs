using Contratos;
using Utils;

namespace UI.Desktop.Forms.Materias
{
    public partial class Materias : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvMaterias;

        public Materias()
        {
            InitializeComponent();
            dgvMaterias.AutoGenerateColumns = false;
            dgvMaterias.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvMaterias.Columns[e.ColumnIndex].Name;
                if (colName == "colDescripcion" && e.Value is string v)
                    e.Value = Formato.ToTitleCase(v);
                else if (colName == "colPlan" && dgvMaterias.Rows[e.RowIndex].DataBoundItem is MateriaDto m)
                    e.Value = Formato.ToTitleCase(m.PlanDescripcion ?? "");
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Materias_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                dgvMaterias.DataSource = null;
                dgvMaterias.DataSource = await ApiEscritorio.Materia.GetAllAsync();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            new MateriaDialog(ModoForm.Alta).ShowDialog();
            await ListarAsync();
        }

        private async void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvMaterias)) return;
            int id = ((MateriaDto)dgvMaterias.SelectedRows[0].DataBoundItem).Id;
            new MateriaDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvMaterias);
            await ListarAsync();
            SeleccionarFila(dgvMaterias, id);
            DescongelarGrilla(dgvMaterias);
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvMaterias)) return;
            int id = ((MateriaDto)dgvMaterias.SelectedRows[0].DataBoundItem).Id;
            new MateriaDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvMaterias);
            await ListarAsync();
            SeleccionarFila(dgvMaterias, id);
            DescongelarGrilla(dgvMaterias);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
