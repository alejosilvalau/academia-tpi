using Dominio;
using Repositorio;
using Servicios;

namespace UI.Desktop.Forms.Inscripciones
{
    public partial class Inscripciones : ApplicationForm
    {
        private readonly InscripcionServicio _servicio;
        private readonly Persona _personaActual;

        public Inscripciones(Persona persona, bool admin = false)
        {
            InitializeComponent();
            _servicio = new InscripcionServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            _personaActual = persona;
            dgvInscripciones.AutoGenerateColumns = false;
            AplicarHoverToolStrip(toolStrip1, MaterialColors.Primary);

            if (!admin)
            {
                tsbEditar.Visible = false;
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
            new InscripcionDesktop(_personaActual, ModoForm.Alta).ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvInscripciones)) return;
            int id = ((AlumnoInscripcion)dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
            new InscripcionDesktop(_personaActual, id, ModoForm.Modificacion).ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvInscripciones)) return;
            int id = ((AlumnoInscripcion)dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
            new InscripcionDesktop(_personaActual, id, ModoForm.Baja).ShowDialog();
            Listar();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditar_Click(sender, e);
        }
    }
}
