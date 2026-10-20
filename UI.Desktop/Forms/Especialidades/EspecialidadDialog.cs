using Contratos;
using Utils;

namespace UI.Desktop.Forms.Especialidades
{
    public partial class EspecialidadDialog : ApplicationForm
    {
        private int? _id;
        private string _descripcionActual = "";

        public EspecialidadDialog(ModoForm modo) : this()
        {
            Modo = modo;
            SetModo();
        }

        public EspecialidadDialog(int id, ModoForm modo) : this(modo)
        {
            _id = id;
            var especialidad = ApiEscritorio.Especialidad.GetOneAsync(id).GetAwaiter().GetResult();
            if (especialidad != null)
            {
                _descripcionActual = especialidad.Descripcion;
                MapearDeDatos();
            }
        }

        public EspecialidadDialog() : base()
        {
            InitializeComponent();
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
            txtID.Text = _id?.ToString() ?? "";
            txtDescripcion.Text = Formato.ToTitleCase(_descripcionActual);
        }

        public override void MapearADatos()
        {
            _descripcionActual = txtDescripcion.Text;
        }

        public override async Task GuardarCambiosAsync()
        {
            MapearADatos();
            if (Modo == ModoForm.Baja && _id.HasValue)
                await ApiEscritorio.Especialidad.DeleteAsync(_id.Value);
            else if (Modo == ModoForm.Alta)
                await ApiEscritorio.Especialidad.SaveAsync(new EspecialidadRequest { Descripcion = _descripcionActual });
            else if (_id.HasValue)
                await ApiEscritorio.Especialidad.UpdateAsync(_id.Value, new EspecialidadRequest { Descripcion = _descripcionActual });
        }

        public override bool Validar()
        {
            Validaciones.AsegurarDescripcion(txtDescripcion.Text, "Descripción");
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
