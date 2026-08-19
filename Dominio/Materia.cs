using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Materias")]
    public class Materia : BusinessEntity
    {
        [StringLength(100)]
        public string Descripcion { get; set; } = null!;
        public int HorasSemanales { get; set; }
        public int HorasTotales { get; set; }

        [ForeignKey("Plan")]
        public int PlanId { get; set; }
        private Plan _plan = null!;
        public virtual Plan Plan
        {
            get
            {
                return _plan;
            }
            set
            {
                if (value != null)
                {
                    _plan = value;
                    PlanId = value.ID;
                }
            }
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
