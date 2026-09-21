using Dominio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Cursos
{
    public partial class CursoDialog : ApplicationForm
    {
        private readonly CursoServicio _servicio;
        private readonly MateriaServicio _materiaServicio;
        private readonly ComisionServicio _comisionServicio;
        private Curso? _curso;

        public CursoDialog() : base()
        {
            InitializeComponent();
            _servicio = ServicioFactory.Curso();
            _materiaServicio = ServicioFactory.Materia();
            _comisionServicio = ServicioFactory.Comision();
        }

        public CursoDialog(ModoForm modo) : this()
        {
            Modo = modo;
            cbxMateria.DataSource = _materiaServicio.GetAll()
                .Select(m => new { m.ID, Descripcion = Formato.ToTitleCase(m.Descripcion) }).ToList();
            cbxComision.DataSource = _comisionServicio.GetAll()
                .Select(c => new { c.ID, Descripcion = Formato.ToTitleCase(c.Descripcion) }).ToList();
            SetModo();
        }

        public CursoDialog(int id, ModoForm modo) : this(modo)
        {
            _curso = _servicio.GetOne(id);
            MapearDeDatos();
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

        public override void MapearDeDatos()
        {
            if (_curso == null) return;
            txtID.Text = _curso.ID.ToString();
            txtDescripcion.Text = $"{Formato.ToTitleCase(_curso.Materia.Descripcion)} - {Formato.ToTitleCase(_curso.Comision.Descripcion)} - {_curso.AnioCalendario}";
            txtAnioCalendario.Text = _curso.AnioCalendario.ToString();
            txtCupo.Text = _curso.Cupo.ToString();
            cbxMateria.SelectedValue = _curso.MateriaId;
            cbxComision.SelectedValue = _curso.ComisionId;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) _curso = new Curso();
            if (_curso == null) return;
            int.TryParse(txtAnioCalendario.Text, out int anio);
            int.TryParse(txtCupo.Text, out int cupo);
            _curso.AnioCalendario = anio;
            _curso.Cupo = cupo;
            if (cbxMateria.SelectedValue is int materiaId) _curso.MateriaId = materiaId;
            if (cbxComision.SelectedValue is int comisionId) _curso.ComisionId = comisionId;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            if (_curso == null) return;
            if (Modo == ModoForm.Baja) _servicio.Delete(_curso);
            else if (Modo == ModoForm.Alta) _servicio.Save(_curso);
            else _servicio.Update(_curso);
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validar()) return;
                GuardarCambios();
                Close();
            }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void CursoDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
