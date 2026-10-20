using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        public ModoForm Modo { get; set; }

        public virtual bool PermitirAutoRefresco => true;

        public virtual DataGridView? GrillaPrincipal => null;

        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }

        public virtual void MapearDeDatos() { }
        public virtual void MapearADatos() { }
        public virtual Task GuardarCambiosAsync() => Task.CompletedTask;
        public virtual Task ListarAsync() => Task.CompletedTask;
        public virtual void Listar() { _ = ListarAsync(); }
        public virtual bool Validar() { return false; }

        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string titulo, string mensaje)
        {
            MessageBox.Show(mensaje, titulo);
        }

        protected bool IsRowSelected(DataGridView dgvSelected)
        {
            if (dgvSelected.SelectedRows.Count != 1)
            {
                Notificar("Acción inválida", "Por favor seleccione una fila.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        protected void AplicarHoverToolStrip(ToolStrip toolStrip, Color hoverColor)
        {
            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item is ToolStripButton)
                {
                    var original = item.BackColor;
                    item.MouseEnter += (s, e) => { item.BackColor = hoverColor; };
                    item.MouseLeave += (s, e) => { item.BackColor = original; };
                }
            }
        }

        protected static int? ObtenerId(object? item)
        {
            if (item == null) return null;
            var tipo = item.GetType();
            var prop = tipo.GetProperty("Id") ?? tipo.GetProperty("ID");
            return prop?.GetValue(item) as int?;
        }

        protected void SeleccionarFila(DataGridView dgv, int? id)
        {
            if (!id.HasValue) return;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (ObtenerId(row.DataBoundItem) == id.Value)
                {
                    row.Selected = true;
                    dgv.CurrentCell = row.Cells[0];
                    dgv.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        protected void CongelarGrilla(DataGridView dgv)
        {
            SendMessage(dgv.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
        }

        protected void DescongelarGrilla(DataGridView dgv)
        {
            SendMessage(dgv.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            dgv.Refresh();
        }

        public void ListarPreservandoSeleccion(DataGridView dgv)
        {
            int? idSeleccionado = null;
            if (dgv.SelectedRows.Count == 1)
                idSeleccionado = ObtenerId(dgv.SelectedRows[0].DataBoundItem);

            CongelarGrilla(dgv);
            Listar();
            if (idSeleccionado.HasValue)
                SeleccionarFila(dgv, idSeleccionado);
            DescongelarGrilla(dgv);
        }

        public async Task ListarPreservandoSeleccionAsync(DataGridView dgv)
        {
            int? idSeleccionado = null;
            if (dgv.SelectedRows.Count == 1)
                idSeleccionado = ObtenerId(dgv.SelectedRows[0].DataBoundItem);

            CongelarGrilla(dgv);
            await ListarAsync();
            if (idSeleccionado.HasValue)
                SeleccionarFila(dgv, idSeleccionado);
            DescongelarGrilla(dgv);
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0x000B;
    }
}
