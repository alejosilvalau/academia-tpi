using Dominio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.RegistrarNotas
{
    public partial class RegistrarNotas : ApplicationForm
    {
        private readonly Persona _personaActual;
        private readonly DocenteCursoServicio _dcServicio;
        private readonly InscripcionServicio _inscripcionServicio;

        public override bool PermitirAutoRefresco => false;

        public RegistrarNotas(Persona persona)
        {
            InitializeComponent();
            _personaActual = persona;
            _dcServicio = ServicioFactory.DocenteCurso();
            _inscripcionServicio = ServicioFactory.Inscripcion();
            dgvAlumnos.AutoGenerateColumns = false;
            dgvAlumnos.CellFormatting += (s, e) =>
            {
                if (e.Value is string v && e.ColumnIndex >= 0)
                {
                    var colName = dgvAlumnos.Columns[e.ColumnIndex].Name;
                    if (colName is "Nombre" or "Apellido")
                        e.Value = Formato.ToTitleCase(v);
                }
            };
            cbxCursos.DataSource = _dcServicio.GetByDocente(persona.ID);
            cbxCursos.DisplayMember = "Curso";
        }

        private void RegistrarNotas_Load(object sender, EventArgs e) => Listar();

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var alumno = (AlumnoInscripcion)dgvAlumnos.Rows[e.RowIndex].DataBoundItem;
            txtNota.Text = alumno.Nota?.ToString() ?? string.Empty;
        }

        private void cbxCursos_SelectedIndexChanged(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                dgvAlumnos.DataSource = null;
                if (cbxCursos.SelectedItem is DocenteCurso dc)
                    dgvAlumnos.DataSource = _inscripcionServicio.GetByCurso(dc.CursoId);
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvAlumnos)) return;
            try
            {
                var alumno = (AlumnoInscripcion)dgvAlumnos.SelectedRows[0].DataBoundItem;
                int id = alumno.ID;
                int.TryParse(txtNota.Text, out int nota);
                alumno.Nota = nota;
                if (nota >= 6) alumno.Condicion = AlumnoInscripcion.Condiciones.Aprobado;
                else if (nota >= 4) alumno.Condicion = AlumnoInscripcion.Condiciones.Regular;
                else alumno.Condicion = AlumnoInscripcion.Condiciones.Inscripto;
                _inscripcionServicio.Update(alumno);
                CongelarGrilla(dgvAlumnos);
                Listar();
                SeleccionarFila(dgvAlumnos, id);
                DescongelarGrilla(dgvAlumnos);
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtNota.Text }))
            { Notificar("Información inválida", "Complete los campos para continuar."); return false; }
            return cbxCursos.SelectedValue != null;
        }
    }
}
