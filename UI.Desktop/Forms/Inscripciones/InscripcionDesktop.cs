using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Inscripciones
{
    public partial class InscripcionDesktop : ApplicationForm
    {
        private readonly InscripcionServicio _servicio;
        private readonly Persona _personaActual;
        private AlumnoInscripcion? _inscripcion;

        public InscripcionDesktop(Persona persona, ModoForm modo)
        {
            InitializeComponent();
            _servicio = new InscripcionServicio(new AcademiaContext());
            _personaActual = persona;
            Modo = modo;
            txtAlumno.Text = persona.ToString();
            cbxCondicion.DataSource = EnumHelper.GetEnumItems<AlumnoInscripcion.Condiciones>();
            cbxCondicion.DisplayMember = "Display";
            cbxCondicion.ValueMember = "Value";
            cbxCondicion.Enabled = false;

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Inscribir";
                    dgvCursos.DataSource = new CursoServicio(new AcademiaContext()).GetAll();
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    cbxCondicion.Enabled = true;
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
            }
        }

        public InscripcionDesktop(Persona persona, int id, ModoForm modo) : this(persona, modo)
        {
            _inscripcion = _servicio.GetOne(id);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            if (_inscripcion == null) return;
            cbxCondicion.SelectedItem = _inscripcion.Condicion;
        }

        public override void MapearADatos()
        {
            if (_inscripcion == null) return;
            if (Modo == ModoForm.Alta) return;
            if (cbxCondicion.SelectedItem is AlumnoInscripcion.Condiciones cond)
                _inscripcion.Condicion = cond;
        }

        public override bool Validar() => true;

        public override void GuardarCambios()
        {
            if (Modo == ModoForm.Alta)
            {
                if (!IsRowSelected(dgvCursos)) { Notificar("Error", "Seleccione un curso.", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                var curso = (Curso)dgvCursos.SelectedRows[0].DataBoundItem;
                _servicio.InscribirAlumno(_personaActual.ID, curso.ID);
            }
            else if (Modo == ModoForm.Baja && _inscripcion != null)
            {
                _servicio.Delete(_inscripcion);
            }
            else if (Modo == ModoForm.Modificacion && _inscripcion != null)
            {
                MapearADatos();
                _servicio.Update(_inscripcion);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Modo == ModoForm.Alta && !IsRowSelected(dgvCursos)) return;
            try { GuardarCambios(); Close(); }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
