using System.ComponentModel;

namespace Contratos
{
    public enum CondicionInscripcion
    {
        [Description("Inscripto")]
        Inscripto,
        [Description("Regular")]
        Regular,
        [Description("Aprobado")]
        Aprobado
    }
}
