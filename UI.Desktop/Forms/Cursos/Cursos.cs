using Dominio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Cursos
{
    public partial class Cursos : ApplicationForm
    {
        private readonly CursoServicio _servicio;
        public override DataGridView? GrillaPrincipal => dgvCursos;

        public Cursos()
        {
            InitializeComponent();
            _servicio = ServicioFactory.Curso();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex >= 0 && dgvCursos.Columns[e.ColumnIndex].Name == "Materia"
                    && e.Value is Materia m)
                {
                    e.Value = Formato.ToTitleCase(m.Descripcion);
                }
                if (e.ColumnIndex >= 0 && dgvCursos.Columns[e.ColumnIndex].Name == "Comision"
                    && e.Value is Comision c)
                {
                    e.Value = Formato.ToTitleCase(c.Descripcion);
                }
            };
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
            new CursoDialog(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvCursos)) return;
            int id = ((Curso)dgvCursos.SelectedRows[0].DataBoundItem).ID;
            new CursoDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvCursos);
            Listar();
            SeleccionarFila(dgvCursos, id);
            DescongelarGrilla(dgvCursos);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvCursos)) return;
            int id = ((Curso)dgvCursos.SelectedRows[0].DataBoundItem).ID;
            new CursoDialog(id, ModoForm.Baja).ShowDialog();
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
