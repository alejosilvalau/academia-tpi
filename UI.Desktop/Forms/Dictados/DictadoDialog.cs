using Dominio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Dictados
{
    public partial class DictadoDialog : ApplicationForm
    {
        private readonly DocenteCursoServicio _servicio;
        private readonly CursoServicio _cursoServicio;
        private readonly PersonaServicio _personaServicio;
        private DocenteCurso? _dictado;

        public DictadoDialog() : base()
        {
            InitializeComponent();
            _servicio = ServicioFactory.DocenteCurso();
            _cursoServicio = ServicioFactory.Curso();
            _personaServicio = ServicioFactory.Persona();
        }

        public DictadoDialog(ModoForm modo) : this()
        {
            Modo = modo;
            cbxCursos.DataSource = _cursoServicio.GetAll()
                .Select(c => new { c.ID, Display = $"{Formato.ToTitleCase(c.Materia.Descripcion)} - {Formato.ToTitleCase(c.Comision.Descripcion)} - {c.AnioCalendario}" }).ToList();
            cbxCursos.DisplayMember = "Display";
            cbxCursos.ValueMember = "ID";
            cbxDocentes.DataSource = _personaServicio.GetByTipo(Persona.TiposPersonas.Docente)
                .Select(p => new { p.ID, Display = $"{Formato.ToTitleCase(p.Nombre)} {Formato.ToTitleCase(p.Apellido)}" }).ToList();
            cbxDocentes.DisplayMember = "Display";
            cbxDocentes.ValueMember = "ID";
            cbxTiposCargos.DataSource = EnumHelper.GetEnumItems<DocenteCurso.TiposCargos>();
            cbxTiposCargos.DisplayMember = "Display";
            cbxTiposCargos.ValueMember = "Value";
            SetModo();
        }

        public DictadoDialog(int id, ModoForm modo) : this(modo)
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
            if (cbxCursos.SelectedValue is int cursoId) _dictado.CursoId = cursoId;
            if (cbxDocentes.SelectedValue is int docenteId) _dictado.DocenteId = docenteId;
            if (cbxTiposCargos.SelectedItem is DocenteCurso.TiposCargos cargo) _dictado.Cargo = cargo;
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            if (_dictado == null) return;
            if (Modo == ModoForm.Baja) _servicio.Delete(_dictado);
            else if (Modo == ModoForm.Alta) _servicio.AsignarDocente(_dictado.DocenteId, _dictado.CursoId, _dictado.Cargo);
            else _servicio.Update(_dictado);
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
    }
}
