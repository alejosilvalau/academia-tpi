using Contratos;
using Utils;

namespace UI.Desktop.Forms.Especialidades
{
    public partial class Especialidades : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvEspecialidades;

        public Especialidades()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.CellFormatting += (s, e) =>
            {
                if (e.Value is string v && dgvEspecialidades.Columns[e.ColumnIndex].Name == "Descripcion")
                    e.Value = Formato.ToTitleCase(v);
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Especialidades_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                dgvEspecialidades.DataSource = await ApiEscritorio.Especialidad.GetAllAsync();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            new EspecialidadDialog(ModoForm.Alta).ShowDialog();
            await ListarAsync();
        }

        private async void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvEspecialidades)) return;
            int id = ((EspecialidadDto)dgvEspecialidades.SelectedRows[0].DataBoundItem).Id;
            new EspecialidadDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvEspecialidades);
            await ListarAsync();
            SeleccionarFila(dgvEspecialidades, id);
            DescongelarGrilla(dgvEspecialidades);
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvEspecialidades)) return;
            int id = ((EspecialidadDto)dgvEspecialidades.SelectedRows[0].DataBoundItem).Id;
            new EspecialidadDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvEspecialidades);
            await ListarAsync();
            SeleccionarFila(dgvEspecialidades, id);
            DescongelarGrilla(dgvEspecialidades);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
