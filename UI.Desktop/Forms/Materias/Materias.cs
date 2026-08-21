using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Materias
{
    public partial class Materias : ApplicationForm
    {
        private readonly MateriaServicio _servicio;
        public override DataGridView? GrillaPrincipal => dgvMaterias;

        public Materias()
        {
            InitializeComponent();
            _servicio = new MateriaServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            dgvMaterias.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Materias_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                dgvMaterias.DataSource = null;
                dgvMaterias.DataSource = _servicio.GetAll();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new MateriaDialog(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvMaterias)) return;
            int id = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            new MateriaDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvMaterias);
            Listar();
            SeleccionarFila(dgvMaterias, id);
            DescongelarGrilla(dgvMaterias);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvMaterias)) return;
            int id = ((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            new MateriaDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvMaterias);
            Listar();
            SeleccionarFila(dgvMaterias, id);
            DescongelarGrilla(dgvMaterias);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
