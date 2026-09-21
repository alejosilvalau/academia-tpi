using System.ComponentModel;
using System.Reflection;
using Dominio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Dictados
{
    public partial class Dictados : ApplicationForm
    {
        private readonly DocenteCursoServicio _servicio;
        public override DataGridView? GrillaPrincipal => dgvDocentes;

        public Dictados()
        {
            InitializeComponent();
            _servicio = ServicioFactory.DocenteCurso();
            dgvDocentes.AutoGenerateColumns = false;
            dgvDocentes.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex >= 0 && dgvDocentes.Columns[e.ColumnIndex].Name == "Cargo"
                    && e.Value is DocenteCurso.TiposCargos cargo)
                {
                    var field = typeof(DocenteCurso.TiposCargos).GetField(cargo.ToString());
                    var attr = field?.GetCustomAttribute<DescriptionAttribute>();
                    e.Value = attr?.Description ?? cargo.ToString();
                }
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Dictados_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                dgvDocentes.DataSource = null;
                dgvDocentes.DataSource = _servicio.GetAll();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new DictadoDialog(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvDocentes)) return;
            int id = ((DocenteCurso)dgvDocentes.SelectedRows[0].DataBoundItem).ID;
            new DictadoDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvDocentes);
            Listar();
            SeleccionarFila(dgvDocentes, id);
            DescongelarGrilla(dgvDocentes);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvDocentes)) return;
            int id = ((DocenteCurso)dgvDocentes.SelectedRows[0].DataBoundItem).ID;
            new DictadoDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvDocentes);
            Listar();
            SeleccionarFila(dgvDocentes, id);
            DescongelarGrilla(dgvDocentes);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
