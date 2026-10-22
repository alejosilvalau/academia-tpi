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
            SeleccionarFila(dgv, id, desplazar: true);
        }

        protected bool SeleccionarFila(DataGridView dgv, int? id, bool desplazar, int columna = 0)
        {
            if (!id.HasValue) return false;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (ObtenerId(row.DataBoundItem) == id.Value)
                {
                    dgv.ClearSelection();
                    row.Selected = true;
                    if (row.Cells.Count > 0)
                        dgv.CurrentCell = row.Cells[Math.Clamp(columna, 0, row.Cells.Count - 1)];
                    if (desplazar)
                        dgv.FirstDisplayedScrollingRowIndex = row.Index;
                    return true;
                }
            }
            return false;
        }

        private static void SeleccionarPrimeraFila(DataGridView dgv, int columna)
        {
            if (dgv.Rows.Count == 0) return;
            var fila = dgv.Rows[0];
            if (fila.Cells.Count == 0) return;
            dgv.ClearSelection();
            dgv.CurrentCell = fila.Cells[Math.Clamp(columna, 0, fila.Cells.Count - 1)];
            fila.Selected = true;
        }

        private static void RestaurarScroll(DataGridView dgv, int indice)
        {
            if (indice < 0 || dgv.Rows.Count == 0) return;
            dgv.FirstDisplayedScrollingRowIndex = Math.Min(indice, dgv.Rows.Count - 1);
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

        public async Task ListarPreservandoSeleccionAsync(DataGridView dgv)
        {
            int? idSeleccionado = null;
            if (dgv.SelectedRows.Count == 1)
                idSeleccionado = ObtenerId(dgv.SelectedRows[0].DataBoundItem);

            int scroll = dgv.FirstDisplayedScrollingRowIndex;
            int columna = dgv.CurrentCell?.ColumnIndex ?? 0;

            CongelarGrilla(dgv);
            try
            {
                await ListarAsync();
                if (dgv.IsDisposed) return;

                bool encontrada = dgv.SelectedRows.Count == 1 &&
                    ObtenerId(dgv.SelectedRows[0].DataBoundItem) == idSeleccionado;

                if (!encontrada)
                    encontrada = SeleccionarFila(dgv, idSeleccionado, desplazar: false, columna);

                if (encontrada)
                {
                    RestaurarScroll(dgv, scroll);
                }
                else if (dgv.Rows.Count > 0)
                {
                    SeleccionarPrimeraFila(dgv, columna);
                    dgv.FirstDisplayedScrollingRowIndex = 0;
                }
            }
            finally
            {
                if (!dgv.IsDisposed)
                    DescongelarGrilla(dgv);
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0x000B;
    }
}
