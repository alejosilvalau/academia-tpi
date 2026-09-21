using Dominio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Inscripciones
{
    public partial class Inscripciones : ApplicationForm
    {
        private readonly InscripcionServicio _servicio;
        public override DataGridView? GrillaPrincipal => dgvInscripciones;
        private readonly Persona _personaActual;

        public Inscripciones(Persona persona, bool admin = false)
        {
            InitializeComponent();
            _servicio = ServicioFactory.Inscripcion();
            _personaActual = persona;
            dgvInscripciones.AutoGenerateColumns = false;
            dgvInscripciones.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvInscripciones.Columns[e.ColumnIndex].Name;
                if (dgvInscripciones.Rows[e.RowIndex].DataBoundItem is AlumnoInscripcion ins)
                {
                    if (colName == "DescripcionMateria")
                        e.Value = Formato.ToTitleCase(ins.Curso.Materia.ToString());
                    else if (colName == "Legajo")
                        e.Value = ins.Alumno.Legajo;
                }
            };
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);

            if (!admin)
            {
                tsbEliminar.Visible = false;
            }
        }

        private void Inscripciones_Load(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                dgvInscripciones.DataSource = null;
                dgvInscripciones.DataSource = _servicio.GetByAlumno(_personaActual.ID);
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            new InscripcionDialog(_personaActual, ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvInscripciones)) return;
            int id = ((AlumnoInscripcion)dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
            new InscripcionDialog(_personaActual, id, ModoForm.Baja).ShowDialog();
            CongelarGrilla(dgvInscripciones);
            Listar();
            SeleccionarFila(dgvInscripciones, id);
            DescongelarGrilla(dgvInscripciones);
        }

    }
}
