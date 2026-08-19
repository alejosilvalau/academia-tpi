using Dominio;
using Repositorio;
using Servicios;
using Utils;

namespace UI.Desktop.Forms.Materias
{
    public partial class MateriaDesktop : ApplicationForm
    {
        private readonly MateriaServicio _servicio;
        private readonly PlanServicio _planServicio;
        private Materia? _materia;

        public MateriaDesktop() : base()
        {
            InitializeComponent();
            _servicio = new MateriaServicio(new AcademiaContext());
            _planServicio = new PlanServicio(new AcademiaContext());
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            cbxPlan.DataSource = _planServicio.GetAll();
            SetModo();
        }

        public MateriaDesktop(int id, ModoForm modo) : this(modo)
        {
            _materia = _servicio.GetOne(id);
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
            if (_materia == null) return;
            txtID.Text = _materia.ID.ToString();
            txtDescripcion.Text = _materia.Descripcion;
            txtHsSemanales.Text = _materia.HorasSemanales.ToString();
            txtHsTotales.Text = _materia.HorasTotales.ToString();
            cbxPlan.SelectedValue = _materia.PlanId;
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta) _materia = new Materia();
            if (_materia == null) return;
            _materia.Descripcion = txtDescripcion.Text;
            int.TryParse(txtHsSemanales.Text, out int hsSem);
            _materia.HorasSemanales = hsSem;
            int.TryParse(txtHsTotales.Text, out int hsTot);
            _materia.HorasTotales = hsTot;
            if (cbxPlan.SelectedItem is Plan plan) _materia.Plan = plan;
        }

        public override bool Validar()
        {
            if (!Validaciones.FormularioCompleto(new List<string> { txtDescripcion.Text, txtHsSemanales.Text, txtHsTotales.Text }))
            { Notificar("Información inválida", "Complete los campos para continuar."); return false; }
            return true;
        }

        public override void GuardarCambios()
        {
            try
            {
                MapearADatos();
                if (_materia == null) return;
                if (Modo == ModoForm.Baja) _servicio.Delete(_materia);
                else if (Modo == ModoForm.Alta) _servicio.Save(_materia);
                else _servicio.Update(_materia);
            }
            catch (Exception ex) { Notificar("Error", ex.Message); }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { if (Validar()) { GuardarCambios(); Close(); } }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();
    }
}
