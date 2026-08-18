using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Dictados
{
    public partial class DictadoDesktop : ApplicationForm
    {
        private readonly DocenteCursoServicio _servicio;
        private readonly CursoServicio _cursoServicio;
        private readonly PersonaServicio _personaServicio;
        private DocenteCurso? _dictado;

        public DictadoDesktop() : base()
        {
            InitializeComponent();
            _servicio = new DocenteCursoServicio(new AcademiaContext());
            _cursoServicio = new CursoServicio(new AcademiaContext());
            _personaServicio = new PersonaServicio(new AcademiaContext());
        }

        public DictadoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            cbxCursos.DataSource = _cursoServicio.GetAll();
            cbxDocentes.DataSource = _personaServicio.GetByTipo(Persona.TiposPersonas.Docente);
            cbxTiposCargos.DataSource = Enum.GetValues(typeof(DocenteCurso.TiposCargos));
            SetModo();
        }

        public DictadoDesktop(int id, ModoForm modo) : this(modo)
        {
            _dictado = _servicio.GetOne(id);
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
            if (_dictado == null) return;
            txtID.Text = _dictado.ID.ToString();
            cbxCursos.SelectedValue = _dictado.CursoId;
            cbxDocentes.SelectedValue = _dictado.DocenteId;
            cbxTiposCargos.SelectedItem = _dictado.Cargo;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) _dictado = new DocenteCurso();
            if (_dictado == null) return;
            if (cbxCursos.SelectedItem is Curso cur) _dictado.Curso = cur;
            if (cbxDocentes.SelectedItem is Persona doc) _dictado.Docente = doc;
            if (cbxTiposCargos.SelectedItem is DocenteCurso.TiposCargos cargo) _dictado.Cargo = cargo;
        }

        public override bool Validar()
        {
            if (cbxCursos.SelectedValue == null || cbxDocentes.SelectedValue == null || cbxTiposCargos.SelectedValue == null)
            { Notificar("Informacion invalida", "Complete los campos para continuar."); return false; }
            return true;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                if (_dictado == null) return;
                if (Modo == ModoForm.Baja) _servicio.Delete(_dictado);
                else if (Modo == ModoForm.Alta) _servicio.AsignarDocente(_dictado.DocenteId, _dictado.CursoId, _dictado.Cargo);
                else _servicio.Update(_dictado);
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { if (Validar()) { GuardarCambios(); Close(); } }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
