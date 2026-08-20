using Dominio;
using Repositorio;
using Servicios;
using UI.Desktop.Forms.Materias;

namespace UI.Desktop.Forms.Planes
{
    public partial class PlanMaterias : ApplicationForm
    {
        private readonly PlanServicio _planServicio;
        private readonly MateriaServicio _materiaServicio;
        private int? _planSeleccionadoId;
        private bool _cargando;

        public PlanMaterias()
        {
            InitializeComponent();
            _planServicio = new PlanServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            _materiaServicio = new MateriaServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            dgvPlanes.AutoGenerateColumns = false;
            dgvMaterias.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStripMaestro, MaterialColors.Primary);
            AplicarHoverToolStrip(toolStripDetalle, MaterialColors.Primary);
        }

        private void PlanMaterias_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                _cargando = true;
                dgvPlanes.DataSource = null;
                dgvPlanes.DataSource = _planServicio.GetAll();
                if (_planSeleccionadoId.HasValue)
                    SeleccionarFila(dgvPlanes, _planSeleccionadoId);
                _cargando = false;
                CargarMaterias();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void CargarMaterias()
        {
            try
            {
                if (dgvPlanes.SelectedRows.Count != 1)
                {
                    dgvMaterias.DataSource = null;
                    _planSeleccionadoId = null;
                    return;
                }
                var plan = (Plan)dgvPlanes.SelectedRows[0].DataBoundItem;
                _planSeleccionadoId = plan.ID;
                dgvMaterias.DataSource = null;
                dgvMaterias.DataSource = _materiaServicio.GetByPlan(plan.ID);
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void dgvPlanes_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            CargarMaterias();
        }

        private void dgvPlanes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditarPlan_Click(sender, e);
        }

        private void tsbAgregarPlan_Click(object sender, EventArgs e)
        {
            new PlanDialog(ModoForm.Alta).ShowDialog();
            CongelarGrilla(dgvPlanes);
            Listar();
            DescongelarGrilla(dgvPlanes);
        }

        private void tsbEditarPlan_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int id = ((Plan)dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            new PlanDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvPlanes);
            _planSeleccionadoId = id;
            Listar();
            SeleccionarFila(dgvPlanes, id);
            DescongelarGrilla(dgvPlanes);
        }

        private void tsbEliminarPlan_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int id = ((Plan)dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            new PlanDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvPlanes);
            _planSeleccionadoId = null;
            Listar();
            DescongelarGrilla(dgvPlanes);
        }

        private void dgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditarMateria_Click(sender, e);
        }

        private void tsbAgregarMateria_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int planId = ((Plan)dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            new MateriaDialog(planId).ShowDialog();
            CongelarGrilla(dgvMaterias);
            CargarMaterias();
            DescongelarGrilla(dgvMaterias);
        }

        private void tsbEditarMateria_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvMaterias)) return;
            int id = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            new MateriaDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvMaterias);
            CargarMaterias();
            SeleccionarFila(dgvMaterias, id);
            DescongelarGrilla(dgvMaterias);
        }

        private void tsbEliminarMateria_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvMaterias)) return;
            int id = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            new MateriaDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvMaterias);
            CargarMaterias();
            SeleccionarFila(dgvMaterias, id);
            DescongelarGrilla(dgvMaterias);
        }
    }
}