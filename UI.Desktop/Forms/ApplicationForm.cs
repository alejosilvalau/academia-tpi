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

        public enum ModoForm
        {
            Alta,
            Baja,
            Modificacion,
            Consulta
        }

        public virtual void MapearDeDatos() { }
        public virtual void MapearADatos() { }
        public virtual void GuardarCambios() { }
        public virtual void Listar() { }
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

        protected void SeleccionarFila(DataGridView dgv, int? id)
        {
            if (!id.HasValue) return;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.DataBoundItem != null &&
                    row.DataBoundItem.GetType().GetProperty("ID")?.GetValue(row.DataBoundItem) is int rowId &&
                    rowId == id.Value)
                {
                    row.Selected = true;
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

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0x000B;
    }
}
