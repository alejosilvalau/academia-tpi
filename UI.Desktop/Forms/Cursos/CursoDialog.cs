using Contratos;
using Utils;

namespace UI.Desktop.Forms.Cursos
{
    public partial class CursoDialog : ApplicationForm
    {
        private int? _id;

        public CursoDialog() : base()
        {
            InitializeComponent();
        }

        public CursoDialog(ModoForm modo) : this()
        {
            Modo = modo;
            CargarCatalogos();
            SetModo();
        }

        public CursoDialog(int id, ModoForm modo) : this(modo)
        {
            _id = id;
            var curso = ApiEscritorio.Curso.GetOneAsync(id).GetAwaiter().GetResult();
            if (curso != null) MapearDeDatos(curso);
        }

        private void CargarCatalogos()
        {
            var materias = ApiEscritorio.Materia.GetAllAsync().GetAwaiter().GetResult();
            cbxMateria.DataSource = materias
                .Select(m => new { m.Id, Descripcion = Formato.ToTitleCase(m.Descripcion) }).ToList();
            cbxMateria.DisplayMember = "Descripcion";
            cbxMateria.ValueMember = "Id";

            var comisiones = ApiEscritorio.Comision.GetAllAsync().GetAwaiter().GetResult();
            cbxComision.DataSource = comisiones
                .Select(c => new { c.Id, Descripcion = Formato.ToTitleCase(c.Descripcion) }).ToList();
            cbxComision.DisplayMember = "Descripcion";
            cbxComision.ValueMember = "Id";
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

        public void MapearDeDatos(CursoDto curso)
        {
            txtID.Text = curso.Id.ToString();
            txtDescripcion.Text = $"{Formato.ToTitleCase(curso.MateriaDescripcion ?? "")} - {Formato.ToTitleCase(curso.ComisionDescripcion ?? "")} - {curso.AnioCalendario}";
            txtAnioCalendario.Text = curso.AnioCalendario.ToString();
            txtCupo.Text = curso.Cupo.ToString();
            cbxMateria.SelectedValue = curso.MateriaId;
            cbxComision.SelectedValue = curso.ComisionId;
        }

        public override void MapearDeDatos() { }

        private CursoRequest ConstruirRequest()
        {
            int.TryParse(txtAnioCalendario.Text, out int anio);
            int.TryParse(txtCupo.Text, out int cupo);
            return new CursoRequest
            {
                AnioCalendario = anio,
                Cupo = cupo,
                MateriaId = cbxMateria.SelectedValue is int materiaId ? materiaId : 0,
                ComisionId = cbxComision.SelectedValue is int comisionId ? comisionId : 0
            };
        }

        public override async Task GuardarCambiosAsync()
        {
            if (Modo == ModoForm.Baja && _id.HasValue)
                await ApiEscritorio.Curso.DeleteAsync(_id.Value);
            else if (Modo == ModoForm.Alta)
                await ApiEscritorio.Curso.SaveAsync(ConstruirRequest());
            else if (_id.HasValue)
                await ApiEscritorio.Curso.UpdateAsync(_id.Value, ConstruirRequest());
        }

        public override bool Validar()
        {
            Validaciones.AsegurarEnteroParseable(txtAnioCalendario.Text, "Año Calendario");
            Validaciones.AsegurarPositivo(int.Parse(txtAnioCalendario.Text), "Año Calendario");
            Validaciones.AsegurarEnteroParseable(txtCupo.Text, "Cupo");
            Validaciones.AsegurarPositivo(int.Parse(txtCupo.Text), "Cupo");
            if (cbxMateria.SelectedValue == null)
                throw new ArgumentException("El campo Materia es obligatorio.");
            if (cbxComision.SelectedValue == null)
                throw new ArgumentException("El campo Comisión es obligatorio.");
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
