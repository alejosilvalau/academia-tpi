using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Planes")]
    public class Plan : BusinessEntity
    {
        [StringLength(100)]
        public string Descripcion { get; set; } = null!;

        [ForeignKey("Especialidad")]
        public int EspecialidadId { get; set; }
        private Especialidad _especialidad = null!;
        public virtual Especialidad Especialidad
        {
            get
            {
                return _especialidad;
            }
            set
            {
                if (value != null)
                {
                    _especialidad = value;
                    EspecialidadId = value.ID;
                }
            }
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
