using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Comisiones
{
    public partial class Comisiones : ApplicationForm
    {
        private readonly ComisionServicio _servicio;

        public Comisiones()
        {
            InitializeComponent();
            _servicio = new ComisionServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            dgvComisiones.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Comisiones_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try { dgvComisiones.DataSource = _servicio.GetAll(); }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new ComisionDesktop(ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvComisiones)) return;
            int id = ((Comision)dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            new ComisionDesktop(id, ModoForm.Modificacion).ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvComisiones)) return;
            int id = ((Comision)dgvComisiones.SelectedRows[0].DataBoundItem).ID;
            new ComisionDesktop(id, ModoForm.Baja).ShowDialog();
            Listar();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
