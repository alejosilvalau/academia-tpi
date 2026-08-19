using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Especialidades
{
    public partial class Especialidades : ApplicationForm
    {
        private readonly EspecialidadServicio _servicio;

        public Especialidades()
        {
            InitializeComponent();
            _servicio = new EspecialidadServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            dgvEspecialidades.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Especialidades_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try { dgvEspecialidades.DataSource = _servicio.GetAll(); }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new EspecialidadDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvEspecialidades)) return;
            int id = ((Especialidad)dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            new EspecialidadDesktop(id, ModoForm.Modificacion).ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvEspecialidades)) return;
            int id = ((Especialidad)dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            new EspecialidadDesktop(id, ModoForm.Baja).ShowDialog();
            Listar();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
