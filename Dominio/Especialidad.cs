using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Especialidades")]
    public class Especialidad : BusinessEntity
    {
        [StringLength(100)]
        public string Descripcion { get; set; } = null!;

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
