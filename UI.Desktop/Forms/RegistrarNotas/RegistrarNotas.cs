using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.RegistrarNotas
{
    public partial class RegistrarNotas : ApplicationForm
    {
        private readonly Persona _personaActual;
        private readonly DocenteCursoServicio _dcServicio;
        private readonly InscripcionServicio _inscripcionServicio;

        public RegistrarNotas(Persona persona)
        {
            InitializeComponent();
            _personaActual = persona;
            _dcServicio = new DocenteCursoServicio(new AcademiaContext());
            _inscripcionServicio = new InscripcionServicio(new AcademiaContext());
            cbxCursos.DataSource = _dcServicio.GetByDocente(persona.ID);
            cbxCursos.DisplayMember = "Curso";
            dgvAlumnos.AutoGenerateColumns = false;
        }

        private void RegistrarNotas_Load(object sender, EventArgs e) => Listar();

        private void cbxCursos_SelectedIndexChanged(object sender, EventArgs e) => Listar();

        public override void Listar()
        {
            try
            {
                if (cbxCursos.SelectedItem is DocenteCurso dc)
                    dgvAlumnos.DataSource = _inscripcionServicio.GetByCurso(dc.CursoId);
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvAlumnos)) return;
            try
            {
                var alumno = (AlumnoInscripcion)dgvAlumnos.SelectedRows[0].DataBoundItem;
                int.TryParse(txtNota.Text, out int nota);
                if (nota < 1 || nota > 10) { Notificar("Error", "La nota debe ser entre 1 y 10."); return; }
                alumno.Nota = nota;
                if (nota >= 6) alumno.Condicion = AlumnoInscripcion.Condiciones.Aprobado;
                else if (nota >= 4) alumno.Condicion = AlumnoInscripcion.Condiciones.Regular;
                else alumno.Condicion = AlumnoInscripcion.Condiciones.Inscripto;
                _inscripcionServicio.Update(alumno);
                Listar();
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtNota.Text }))
            { Notificar("Informacion invalida", "Complete los campos para continuar."); return false; }
            return cbxCursos.SelectedValue != null;
        }
    }
}
