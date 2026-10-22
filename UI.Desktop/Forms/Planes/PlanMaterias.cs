using Contratos;
using UI.Desktop.Forms.Materias;
using Utils;

namespace UI.Desktop.Forms.Planes
{
    public partial class PlanMaterias : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvPlanes;
        private int? _planSeleccionadoId;
        private bool _cargando;

        public PlanMaterias()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
            dgvMaterias.AutoGenerateColumns = false;
            dgvPlanes.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvPlanes.Columns[e.ColumnIndex].Name;
                if (colName == "colPlanDescripcion" && e.Value is string v)
                    e.Value = Formato.ToTitleCase(v);
                else if (colName == "colPlanEspecialidad" && dgvPlanes.Rows[e.RowIndex].DataBoundItem is PlanDto p)
                    e.Value = Formato.ToTitleCase(p.EspecialidadDescripcion ?? "");
            };
            dgvMaterias.CellFormatting += (s, e) =>
            {
                if (e.Value is string v && dgvMaterias.Columns[e.ColumnIndex].Name == "colMateriaDescripcion")
                    e.Value = Formato.ToTitleCase(v);
            };
            AplicarHoverToolStrip(toolStripMaestro, MaterialColors.Primary);
            AplicarHoverToolStrip(toolStripDetalle, MaterialColors.Primary);
        }

        private void PlanMaterias_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                _cargando = true;
                dgvPlanes.DataSource = await ApiEscritorio.Plan.GetAllAsync();
                if (_planSeleccionadoId.HasValue)
                    SeleccionarFila(dgvPlanes, _planSeleccionadoId, desplazar: false);
                await CargarMateriasAsync();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
            finally { _cargando = false; }
        }

        private async Task CargarMateriasAsync()
        {
            try
            {
                int? materiaSeleccionadaId = null;
                if (dgvMaterias.SelectedRows.Count == 1)
                    materiaSeleccionadaId = ObtenerId(dgvMaterias.SelectedRows[0].DataBoundItem);

                if (dgvPlanes.SelectedRows.Count != 1)
                {
                    dgvMaterias.DataSource = null;
                    _planSeleccionadoId = null;
                    return;
                }
                var plan = (PlanDto)dgvPlanes.SelectedRows[0].DataBoundItem;
                _planSeleccionadoId = plan.Id;
                dgvMaterias.DataSource = await ApiEscritorio.Materia.GetByPlanAsync(plan.Id);

                if (materiaSeleccionadaId.HasValue)
                    SeleccionarFila(dgvMaterias, materiaSeleccionadaId);
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private async void dgvPlanes_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            await CargarMateriasAsync();
        }

        private void dgvPlanes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditarPlan_Click(sender, e);
        }

        private async void tsbAgregarPlan_Click(object sender, EventArgs e)
        {
            new PlanDialog(ModoForm.Alta).ShowDialog();
            CongelarGrilla(dgvPlanes);
            await ListarAsync();
            DescongelarGrilla(dgvPlanes);
        }

        private async void tsbEditarPlan_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int id = ((PlanDto)dgvPlanes.SelectedRows[0].DataBoundItem).Id;
            new PlanDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvPlanes);
            _planSeleccionadoId = id;
            await ListarAsync();
            SeleccionarFila(dgvPlanes, id);
            DescongelarGrilla(dgvPlanes);
        }

        private async void tsbEliminarPlan_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int id = ((PlanDto)dgvPlanes.SelectedRows[0].DataBoundItem).Id;
            new PlanDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvPlanes);
            _planSeleccionadoId = null;
            await ListarAsync();
            DescongelarGrilla(dgvPlanes);
        }

        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditarMateria_Click(sender, e);
        }

        private async void tsbAgregarMateria_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int planId = ((PlanDto)dgvPlanes.SelectedRows[0].DataBoundItem).Id;
            new MateriaDialog(planId).ShowDialog();
            CongelarGrilla(dgvMaterias);
            await CargarMateriasAsync();
            DescongelarGrilla(dgvMaterias);
        }

        private async void tsbEditarMateria_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvMaterias)) return;
            int id = ((MateriaDto)dgvMaterias.SelectedRows[0].DataBoundItem).Id;
            new MateriaDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvMaterias);
            await CargarMateriasAsync();
            SeleccionarFila(dgvMaterias, id);
            DescongelarGrilla(dgvMaterias);
        }

        private async void tsbEliminarMateria_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvMaterias)) return;
            int id = ((MateriaDto)dgvMaterias.SelectedRows[0].DataBoundItem).Id;
            new MateriaDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvMaterias);
            await CargarMateriasAsync();
            SeleccionarFila(dgvMaterias, id);
            DescongelarGrilla(dgvMaterias);
        }
    }
}
