using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Comision")]
    public class Comision : BusinessEntity
    {
        [StringLength(100)]
        public string Descripcion { get; set; } = null!;
        public int AnioEspecialidad { get; set; }

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

    }
}
