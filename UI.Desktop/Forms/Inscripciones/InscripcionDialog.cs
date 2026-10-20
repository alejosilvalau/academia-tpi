using Contratos;
using Utils;

namespace UI.Desktop.Forms.Inscripciones
{
    public partial class InscripcionDialog : ApplicationForm
    {
        private readonly int _alumnoId;
        private int? _inscripcionId;

        public InscripcionDialog(int alumnoId, ModoForm modo)
        {
            InitializeComponent();
            _alumnoId = alumnoId;
            Modo = modo;
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvCursos.Columns[e.ColumnIndex].Name;
                if (colName == "Materia" && e.Value is string vm)
                    e.Value = Formato.ToTitleCase(vm);
                else if (colName == "Comision" && e.Value is string vc)
                    e.Value = Formato.ToTitleCase(vc);
            };

            var persona = ApiEscritorio.Persona.GetBasicoAsync(alumnoId).GetAwaiter().GetResult();
            txtAlumno.Text = persona != null
                ? $"{Formato.ToTitleCase(persona.Nombre)} {Formato.ToTitleCase(persona.Apellido)}"
                : "";
            cbxCondicion.DataSource = EnumHelper.GetEnumItems<CondicionInscripcion>();
            cbxCondicion.DisplayMember = "Display";
            cbxCondicion.ValueMember = "Value";
            cbxCondicion.Enabled = false;

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Inscribir";
                    dgvCursos.DataSource = ApiEscritorio.Curso.GetAllAsync().GetAwaiter().GetResult();
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    dgvCursos.Visible = false;
                    ClientSize = new Size(600, 140);
                    break;
            }
        }

        public InscripcionDialog(int alumnoId, int id, ModoForm modo) : this(alumnoId, modo)
        {
            _inscripcionId = id;
            var inscripcion = ApiEscritorio.Inscripcion.GetOneAsync(id).GetAwaiter().GetResult();
            if (inscripcion != null) cbxCondicion.SelectedItem = inscripcion.Condicion;
        }

        public override bool Validar() => true;

        public override async Task GuardarCambiosAsync()
        {
            if (Modo == ModoForm.Alta)
            {
                var curso = (CursoDto)dgvCursos.SelectedRows[0].DataBoundItem;
                await ApiEscritorio.Inscripcion.InscribirAsync(new InscribirRequest
                {
                    AlumnoId = _alumnoId,
                    CursoId = curso.Id
                });
            }
            else if (Modo == ModoForm.Baja && _inscripcionId.HasValue)
            {
                await ApiEscritorio.Inscripcion.DeleteAsync(_inscripcionId.Value);
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Modo == ModoForm.Alta && !IsRowSelected(dgvCursos)) return;
            try { await GuardarCambiosAsync(); Close(); }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
