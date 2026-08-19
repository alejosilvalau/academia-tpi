using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Dictados
{
    public partial class Dictados : ApplicationForm
    {
        private readonly DocenteCursoServicio _servicio;

        public Dictados()
        {
            InitializeComponent();
            _servicio = new DocenteCursoServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            dgvDocentes.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Dictados_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                dgvDocentes.DataSource = null;
                dgvDocentes.DataSource = _servicio.GetAll();
                dgvDocentes.Refresh();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new DictadoDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvDocentes)) return;
            int id = ((DocenteCurso)dgvDocentes.SelectedRows[0].DataBoundItem).ID;
            new DictadoDesktop(id, ModoForm.Modificacion).ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvDocentes)) return;
            int id = ((DocenteCurso)dgvDocentes.SelectedRows[0].DataBoundItem).ID;
            new DictadoDesktop(id, ModoForm.Baja).ShowDialog();
            Listar();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
