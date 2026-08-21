using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Usuarios
{
    public partial class Usuarios : ApplicationForm
    {
        private readonly UsuarioServicio _servicio;
        public override DataGridView? GrillaPrincipal => dgvUsuarios;

        public Usuarios()
        {
            InitializeComponent();
            _servicio = new UsuarioServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            dgvUsuarios.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Usuarios_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = _servicio.GetAll();
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new UsuarioDialog(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvUsuarios)) return;
            int id = ((Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            new UsuarioDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvUsuarios);
            Listar();
            SeleccionarFila(dgvUsuarios, id);
            DescongelarGrilla(dgvUsuarios);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvUsuarios)) return;
            int id = ((Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            new UsuarioDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvUsuarios);
            Listar();
            SeleccionarFila(dgvUsuarios, id);
            DescongelarGrilla(dgvUsuarios);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
