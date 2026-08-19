using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Usuarios
{
    public partial class Usuarios : ApplicationForm
    {
        private readonly UsuarioServicio _servicio;

        public Usuarios()
        {
            InitializeComponent();
            _servicio = new UsuarioServicio(new AcademiaContext());
            dgvUsuarios.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Usuarios_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try { dgvUsuarios.DataSource = _servicio.GetAll(); }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new UsuarioDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvUsuarios)) return;
            int id = ((Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            new UsuarioDesktop(id, ModoForm.Modificacion).ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvUsuarios)) return;
            int id = ((Usuario)dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
            new UsuarioDesktop(id, ModoForm.Baja).ShowDialog();
            Listar();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
