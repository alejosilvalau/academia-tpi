using System.ComponentModel;

namespace Contratos
{
    public enum CargoDocente
    {
        [Description("Profesor")]
        Profesor,
        [Description("Jefe De Cátedra")]
        JefeDeCatedra,
        [Description("Auxiliar")]
        Auxiliar
    }
}
