using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Cursos
{
    public partial class CursoDesktop : ApplicationForm
    {
        private readonly CursoServicio _servicio;
        private readonly MateriaServicio _materiaServicio;
        private readonly ComisionServicio _comisionServicio;
        private Curso? _curso;

        public CursoDesktop() : base()
        {
            InitializeComponent();
            _servicio = new CursoServicio(new AcademiaContext());
            _materiaServicio = new MateriaServicio(new AcademiaContext());
            _comisionServicio = new ComisionServicio(new AcademiaContext());
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            cbxMateria.DataSource = _materiaServicio.GetAll();
            cbxComision.DataSource = _comisionServicio.GetAll();
            SetModo();
        }

        public CursoDesktop(int id, ModoForm modo) : this(modo)
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
            if (cbxMateria.SelectedItem is Materia mat) _curso.Materia = mat;
            if (cbxComision.SelectedItem is Comision com) _curso.Comision = com;
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtAnioCalendario.Text, txtCupo.Text }))
            { Notificar("Información inválida", "Complete los campos para continuar."); return false; }
            return true;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                if (_curso == null) return;
                if (Modo == ModoForm.Baja) _servicio.Delete(_curso);
                else if (Modo == ModoForm.Alta) _servicio.Save(_curso);
                else _servicio.Update(_curso);
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { if (Validar()) { GuardarCambios(); Close(); } }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
