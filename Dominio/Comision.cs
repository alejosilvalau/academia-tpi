using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Comisiones")]
    public class Comision : BusinessEntity
    {
        [StringLength(100)]
        public string Descripcion { get; set; }
        public int AnioEspecialidad { get; set; }

        [ForeignKey("Plan")]
        public int PlanId { get; set; }
        private Plan _plan;
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
