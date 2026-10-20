using Contratos;
using Utils;

namespace UI.Desktop.Forms.RegistrarNotas
{
    public partial class RegistrarNotas : ApplicationForm
    {
        private readonly int _docenteId;
        private List<DocenteCursoDto> _cursos = new();

        public override bool PermitirAutoRefresco => false;

        public RegistrarNotas(int docenteId)
        {
            InitializeComponent();
            _docenteId = docenteId;
            dgvAlumnos.AutoGenerateColumns = false;
            dgvAlumnos.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex < 0) return;
                var colName = dgvAlumnos.Columns[e.ColumnIndex].Name;
                if (dgvAlumnos.Rows[e.RowIndex].DataBoundItem is InscripcionDto ins)
                {
                    if (colName == "Nombre")
                        e.Value = Formato.ToTitleCase(ins.AlumnoNombre ?? "");
                    else if (colName == "Apellido")
                        e.Value = Formato.ToTitleCase(ins.AlumnoApellido ?? "");
                    else if (colName == "Legajo")
                        e.Value = ins.AlumnoLegajo;
                }
            };
        }

        private async void RegistrarNotas_Load(object sender, EventArgs e)
        {
            await CargarCursosAsync();
            await ListarAsync();
        }

        private async Task CargarCursosAsync()
        {
            _cursos = await ApiEscritorio.DocenteCurso.GetByDocenteAsync(_docenteId);
            cbxCursos.DataSource = _cursos
                .Select(dc => new
                {
                    dc.Id,
                    Display = $"{Formato.ToTitleCase(dc.CursoMateriaDescripcion ?? "")} - {Formato.ToTitleCase(dc.CursoComisionDescripcion ?? "")} - {dc.CursoAnioCalendario}"
                }).ToList();
            cbxCursos.DisplayMember = "Display";
            cbxCursos.ValueMember = "Id";
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var alumno = (InscripcionDto)dgvAlumnos.Rows[e.RowIndex].DataBoundItem;
            txtNota.Text = alumno.Nota?.ToString() ?? string.Empty;
        }

        private async void cbxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ListarAsync();
        }

        public override async Task ListarAsync()
        {
            try
            {
                dgvAlumnos.DataSource = null;
                if (cbxCursos.SelectedItem == null) return;
                int cursoId = _cursos.First(dc => dc.Id == Convert.ToInt32(cbxCursos.SelectedValue)).CursoId;
                dgvAlumnos.DataSource = await ApiEscritorio.Inscripcion.GetByCursoAsync(cursoId);
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!IsRowSelected(dgvAlumnos)) return;
            try
            {
                var alumno = (InscripcionDto)dgvAlumnos.SelectedRows[0].DataBoundItem;
                int id = alumno.Id;
                int.TryParse(txtNota.Text, out int nota);
                var condicion = nota >= 6 ? CondicionInscripcion.Aprobado
                    : nota >= 4 ? CondicionInscripcion.Regular
                    : CondicionInscripcion.Inscripto;
                await ApiEscritorio.Inscripcion.UpdateAsync(id, new InscripcionRequest
                {
                    AlumnoId = alumno.AlumnoId,
                    CursoId = alumno.CursoId,
                    Condicion = condicion,
                    Nota = nota
                });
                CongelarGrilla(dgvAlumnos);
                await ListarAsync();
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
