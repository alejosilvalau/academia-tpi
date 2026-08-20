using Dominio;
using Repositorio;
using Servicios;

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
            _servicio = new CursoServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            _materiaServicio = new MateriaServicio(new AcademiaContext(), new UsuarioContextoDesktop());
            _comisionServicio = new ComisionServicio(new AcademiaContext(), new UsuarioContextoDesktop());
        }

        public CursoDialog(ModoForm modo) : this()
        {
            Modo = modo;
            cbxMateria.DataSource = _materiaServicio.GetAll();
            cbxComision.DataSource = _comisionServicio.GetAll();
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
            txtDescripcion.Text = _curso.Descripcion;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try { GuardarCambios(); Close(); }
            catch (Exception ex) { Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void CursoDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
