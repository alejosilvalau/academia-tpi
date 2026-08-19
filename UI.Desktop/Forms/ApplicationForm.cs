using System.Drawing;
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
                Notificar("Accion invalida", "Por favor seleccione una fila.",
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
    }
}
