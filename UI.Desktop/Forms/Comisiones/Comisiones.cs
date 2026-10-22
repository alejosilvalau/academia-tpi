using Contratos;
using Utils;

namespace UI.Desktop.Forms.Comisiones
{
    public partial class Comisiones : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvComisiones;

        public Comisiones()
        {
            InitializeComponent();
            dgvComisiones.AutoGenerateColumns = false;
            dgvComisiones.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvComisiones.Columns[e.ColumnIndex].Name;
                if (colName == "colDescripcion" && e.Value is string v)
                    e.Value = Formato.ToTitleCase(v);
                else if (colName == "colPlan" && dgvComisiones.Rows[e.RowIndex].DataBoundItem is ComisionDto c)
                    e.Value = Formato.ToTitleCase(c.PlanDescripcion ?? "");
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Comisiones_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                dgvComisiones.DataSource = await ApiEscritorio.Comision.GetAllAsync();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            new ComisionDialog(ModoForm.Alta).ShowDialog();
            await ListarAsync();
        }

        private async void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvComisiones)) return;
            int id = ((ComisionDto)dgvComisiones.SelectedRows[0].DataBoundItem).Id;
            new ComisionDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvComisiones);
            await ListarAsync();
            SeleccionarFila(dgvComisiones, id);
            DescongelarGrilla(dgvComisiones);
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvComisiones)) return;
            int id = ((ComisionDto)dgvComisiones.SelectedRows[0].DataBoundItem).Id;
            new ComisionDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvComisiones);
            await ListarAsync();
            SeleccionarFila(dgvComisiones, id);
            DescongelarGrilla(dgvComisiones);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
