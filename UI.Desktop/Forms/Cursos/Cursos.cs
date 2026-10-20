using Contratos;
using Utils;

namespace UI.Desktop.Forms.Cursos
{
    public partial class Cursos : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvCursos;

        public Cursos()
        {
            InitializeComponent();
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvCursos.Columns[e.ColumnIndex].Name;
                if (colName == "Materia" && e.Value is string vm)
                    e.Value = Formato.ToTitleCase(vm);
                else if (colName == "Comision" && e.Value is string vc)
                    e.Value = Formato.ToTitleCase(vc);
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Cursos_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                dgvCursos.DataSource = null;
                dgvCursos.DataSource = await ApiEscritorio.Curso.GetAllAsync();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            new CursoDialog(ModoForm.Alta).ShowDialog();
            await ListarAsync();
        }

        private async void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvCursos)) return;
            int id = ((CursoDto)dgvCursos.SelectedRows[0].DataBoundItem).Id;
            new CursoDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvCursos);
            await ListarAsync();
            SeleccionarFila(dgvCursos, id);
            DescongelarGrilla(dgvCursos);
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvCursos)) return;
            int id = ((CursoDto)dgvCursos.SelectedRows[0].DataBoundItem).Id;
            new CursoDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvCursos);
            await ListarAsync();
            SeleccionarFila(dgvCursos, id);
            DescongelarGrilla(dgvCursos);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
