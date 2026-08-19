using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Planes
{
    public partial class Planes : ApplicationForm
    {
        private readonly PlanServicio _servicio;

        public Planes()
        {
            InitializeComponent();
            _servicio = new PlanServicio(new AcademiaContext());
            dgvPlanes.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Planes_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try { dgvPlanes.DataSource = _servicio.GetAll(); }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new PlanDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int id = ((Plan)dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            new PlanDesktop(id, ModoForm.Modificacion).ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvPlanes)) return;
            int id = ((Plan)dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            new PlanDesktop(id, ModoForm.Baja).ShowDialog();
            Listar();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
