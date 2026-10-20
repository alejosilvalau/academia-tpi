using System.ComponentModel;

namespace Contratos
{
    public enum TipoPersona
    {
        [Description("Administrador")]
        Administrador,
        [Description("Alumno")]
        Alumno,
        [Description("Docente")]
        Docente
    }
}
