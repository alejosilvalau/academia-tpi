using System.ComponentModel.DataAnnotations.Schema;
using Contratos;

namespace Dominio
{
    [Table("AlumnoInscripcion")]
    public class AlumnoInscripcion : BusinessEntity
    {
        public AlumnoInscripcion()
        {
            Condicion = CondicionInscripcion.Inscripto;
        }

        public CondicionInscripcion Condicion { get; set; }
        public int? Nota { get; set; }

        [ForeignKey("Alumno")]
        public int AlumnoId { get; set; }
        public virtual Persona Alumno { get; set; } = null!;

        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; } = null!;
    }
}
