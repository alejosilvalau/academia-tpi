using Contratos;
using Utils;

namespace UI.Desktop.Forms.Dictados
{
    public partial class DictadoDialog : ApplicationForm
    {
        private int? _id;

        public DictadoDialog() : base()
        {
            InitializeComponent();
        }

        public DictadoDialog(ModoForm modo) : this()
        {
            Modo = modo;
            CargarCatalogos();
            SetModo();
        }

        public DictadoDialog(int id, ModoForm modo) : this(modo)
        {
            _id = id;
            var dictado = ApiEscritorio.DocenteCurso.GetOneAsync(id).GetAwaiter().GetResult();
            if (dictado != null) MapearDeDatos(dictado);
        }

        private void CargarCatalogos()
        {
            var cursos = ApiEscritorio.Curso.GetAllAsync().GetAwaiter().GetResult();
            cbxCursos.DataSource = cursos
                .Select(c => new { c.Id, Display = $"{Formato.ToTitleCase(c.MateriaDescripcion ?? "")} - {Formato.ToTitleCase(c.ComisionDescripcion ?? "")} - {c.AnioCalendario}" }).ToList();
            cbxCursos.DisplayMember = "Display";
            cbxCursos.ValueMember = "Id";

            var docentes = ApiEscritorio.Persona.GetByTipoAsync(TipoPersona.Docente).GetAwaiter().GetResult();
            cbxDocentes.DataSource = docentes
                .Select(p => new { p.Id, Display = $"{Formato.ToTitleCase(p.Nombre)} {Formato.ToTitleCase(p.Apellido)}" }).ToList();
            cbxDocentes.DisplayMember = "Display";
            cbxDocentes.ValueMember = "Id";

            cbxTiposCargos.DataSource = EnumHelper.GetEnumItems<CargoDocente>();
            cbxTiposCargos.DisplayMember = "Display";
            cbxTiposCargos.ValueMember = "Value";
        }

        private void SetModo()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion: btnAceptar.Text = "Guardar"; break;
                case ModoForm.Baja: btnAceptar.Text = "Eliminar"; break;
                case ModoForm.Consulta: btnAceptar.Text = "Aceptar"; break;
            }
        }

        public void MapearDeDatos(DocenteCursoDto dictado)
        {
            txtID.Text = dictado.Id.ToString();
            cbxCursos.SelectedValue = dictado.CursoId;
            cbxDocentes.SelectedValue = dictado.DocenteId;
            cbxTiposCargos.SelectedItem = dictado.Cargo;
        }

        public override void MapearDeDatos() { }

        private int CursoId => cbxCursos.SelectedValue is int cursoId ? cursoId : 0;
        private int DocenteId => cbxDocentes.SelectedValue is int docenteId ? docenteId : 0;
        private CargoDocente Cargo => cbxTiposCargos.SelectedItem is CargoDocente cargo ? cargo : CargoDocente.Profesor;

        public override async Task GuardarCambiosAsync()
        {
            if (Modo == ModoForm.Baja && _id.HasValue)
                await ApiEscritorio.DocenteCurso.DeleteAsync(_id.Value);
            else if (Modo == ModoForm.Alta)
                await ApiEscritorio.DocenteCurso.AsignarAsync(new AsignarDocenteRequest
                {
                    DocenteId = DocenteId,
                    CursoId = CursoId,
                    Cargo = Cargo
                });
            else if (_id.HasValue)
                await ApiEscritorio.DocenteCurso.UpdateAsync(_id.Value, new DocenteCursoRequest
                {
                    Cargo = Cargo,
                    DocenteId = DocenteId,
                    CursoId = CursoId
                });
        }

        public override bool Validar()
        {
            if (cbxCursos.SelectedValue == null)
                throw new ArgumentException("El campo Curso es obligatorio.");
            if (cbxDocentes.SelectedValue == null)
                throw new ArgumentException("El campo Docente es obligatorio.");
            if (cbxTiposCargos.SelectedValue == null)
                throw new ArgumentException("El campo Cargo es obligatorio.");
            return true;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;
                await GuardarCambiosAsync();
                Close();
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
