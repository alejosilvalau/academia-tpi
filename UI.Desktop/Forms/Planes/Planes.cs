using Contratos;
using Utils;

namespace UI.Desktop.Forms.Planes
{
    public partial class Planes : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvPlanes;

        public Planes()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
            dgvPlanes.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvPlanes.Columns[e.ColumnIndex].Name;
                if (colName == "Descripcion" && e.Value is string v)
                    e.Value = Formato.ToTitleCase(v);
                else if (colName == "Especialidad" && dgvPlanes.Rows[e.RowIndex].DataBoundItem is PlanDto p)
                    e.Value = Formato.ToTitleCase(p.EspecialidadDescripcion ?? "");
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Planes_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                dgvPlanes.DataSource = null;
                dgvPlanes.DataSource = await ApiEscritorio.Plan.GetAllAsync();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            new PlanDialog(ModoForm.Alta).ShowDialog();
            await ListarAsync();
        }

        private async void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int id = ((PlanDto)dgvPlanes.SelectedRows[0].DataBoundItem).Id;
            new PlanDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvPlanes);
            await ListarAsync();
            SeleccionarFila(dgvPlanes, id);
            DescongelarGrilla(dgvPlanes);
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int id = ((PlanDto)dgvPlanes.SelectedRows[0].DataBoundItem).Id;
            new PlanDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvPlanes);
            await ListarAsync();
            SeleccionarFila(dgvPlanes, id);
            DescongelarGrilla(dgvPlanes);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
