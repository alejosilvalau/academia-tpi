using Contratos;
using Utils;

namespace UI.Desktop.Forms.Usuarios
{
    public partial class Usuarios : ApplicationForm
    {
        public override DataGridView? GrillaPrincipal => dgvUsuarios;

        public Usuarios()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.CellFormatting += (s, e) =>
            {
                if (e.Value is string v && e.ColumnIndex >= 0)
                {
                    var colName = dgvUsuarios.Columns[e.ColumnIndex].Name;
                    if (colName is "NombreUsuario" or "Nombre" or "Apellido")
                        e.Value = Formato.ToTitleCase(v);
                }
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);
        }

        private void Usuarios_Load(object sender, EventArgs e) => Listar();

        public override async Task ListarAsync()
        {
            try
            {
                dgvUsuarios.DataSource = null;
                var usuarios = await ApiEscritorio.Usuario.GetAllAsync();
                dgvUsuarios.DataSource = usuarios.Select(u => new
                {
                    u.Id,
                    u.NombreUsuario,
                    Nombre = u.PersonaNombre ?? "-",
                    Apellido = u.PersonaApellido ?? "-",
                    u.Habilitado
                }).ToList();
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            new UsuarioDialog(ModoForm.Alta).ShowDialog();
            await ListarAsync();
        }

        private async void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvUsuarios)) return;
            int id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
            new UsuarioDialog(id, ModoForm.Modificacion).ShowDialog();
            CongelarGrilla(dgvUsuarios);
            await ListarAsync();
            SeleccionarFila(dgvUsuarios, id);
            DescongelarGrilla(dgvUsuarios);
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvUsuarios)) return;
            int id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
            new UsuarioDialog(id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvUsuarios);
            await ListarAsync();
            SeleccionarFila(dgvUsuarios, id);
            DescongelarGrilla(dgvUsuarios);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
