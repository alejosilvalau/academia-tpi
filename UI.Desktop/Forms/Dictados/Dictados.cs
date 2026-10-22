using System.ComponentModel;
using System.Reflection;
using Contratos;
using Utils;

namespace UI.Desktop.Forms.Dictados
{
    public partial class Dictados : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvDocentes;

        public Dictados()
        {
            InitializeComponent();
            dgvDocentes.AutoGenerateColumns = false;
            dgvDocentes.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvDocentes.Columns[e.ColumnIndex].Name;
                if (dgvDocentes.Rows[e.RowIndex].DataBoundItem is DocenteCursoDto dc)
                {
                    if (colName == "Curso")
                        e.Value = $"{Formato.ToTitleCase(dc.CursoMateriaDescripcion ?? "")} - {Formato.ToTitleCase(dc.CursoComisionDescripcion ?? "")} - {dc.CursoAnioCalendario}";
                    else if (colName == "Docente")
                        e.Value = $"{Formato.ToTitleCase(dc.DocenteNombre ?? "")} {Formato.ToTitleCase(dc.DocenteApellido ?? "")}";
                    else if (colName == "Cargo" && e.Value is CargoDocente cargo)
                    {
                        var field = typeof(CargoDocente).GetField(cargo.ToString());
                        var attr = field?.GetCustomAttribute<DescriptionAttribute>();
                        e.Value = attr?.Description ?? cargo.ToString();
                    }
                }
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Dictados_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                dgvDocentes.DataSource = await ApiEscritorio.DocenteCurso.GetAllAsync();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            new DictadoDialog(ModoForm.Alta).ShowDialog();
            await ListarAsync();
        }

        private async void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvDocentes)) return;
            int id = ((DocenteCursoDto)dgvDocentes.SelectedRows[0].DataBoundItem).Id;
            new DictadoDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvDocentes);
            await ListarAsync();
            SeleccionarFila(dgvDocentes, id);
            DescongelarGrilla(dgvDocentes);
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvDocentes)) return;
            int id = ((DocenteCursoDto)dgvDocentes.SelectedRows[0].DataBoundItem).Id;
            new DictadoDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvDocentes);
            await ListarAsync();
            SeleccionarFila(dgvDocentes, id);
            DescongelarGrilla(dgvDocentes);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
