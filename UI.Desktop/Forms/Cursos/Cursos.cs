using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Cursos
{
    public partial class Cursos : ApplicationForm
    {
        private readonly CursoServicio _servicio;

        public Cursos()
        {
            InitializeComponent();
            _servicio = new CursoServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            dgvCursos.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Cursos_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                dgvCursos.DataSource = null;
                dgvCursos.DataSource = _servicio.GetAll();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new CursoDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvCursos)) return;
            int id = ((Curso)dgvCursos.SelectedRows[0].DataBoundItem).ID;
            new CursoDesktop(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvCursos);
            Listar();
            SeleccionarFila(dgvCursos, id);
            DescongelarGrilla(dgvCursos);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvCursos)) return;
            int id = ((Curso)dgvCursos.SelectedRows[0].DataBoundItem).ID;
            new CursoDesktop(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvCursos);
            Listar();
            SeleccionarFila(dgvCursos, id);
            DescongelarGrilla(dgvCursos);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
