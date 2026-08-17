using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Personas")]
    public class Persona : BusinessEntity
    {
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Apellido { get; set; }
        public int? Legajo { get; set; }
        [StringLength(100)]
        public string EMail { get; set; }
        [StringLength(200)]
        public string Direccion { get; set; }
        [StringLength(50)]
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TiposPersonas Tipo { get; set; }

        [ForeignKey("Plan")]
        public int? PlanId { get; set; }
        private Plan _plan;
        public virtual Plan Plan
        {
            get
            {
                return _plan;
            }
            set
            {
                _plan = value;
                if (value == null)
                {
                    PlanId = null;
                }
                else
                {
                    PlanId = value.ID;
                }
            }
        }

        [NotMapped]
        public string NombreCompleto => ToString();

        public enum TiposPersonas
        {
            Administrador,
            Alumno,
            Docente
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
