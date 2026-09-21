using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("AlumnoInscripcion")]
    public class AlumnoInscripcion : BusinessEntity
    {
        public AlumnoInscripcion()
        {
            Condicion = Condiciones.Inscripto;
        }

        public Condiciones Condicion { get; set; }
        public int? Nota { get; set; }

        [ForeignKey("Alumno")]
        public int AlumnoId { get; set; }
        public virtual Persona Alumno { get; set; } = null!;

        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; } = null!;

        public enum Condiciones
        {
            [Description("Inscripto")]
            Inscripto,
            [Description("Regular")]
            Regular,
            [Description("Aprobado")]
            Aprobado
        }
    }
}
