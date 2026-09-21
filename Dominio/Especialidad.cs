using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Especialidad")]
    public class Especialidad : BusinessEntity
    {
        [StringLength(100)]
        public string Descripcion { get; set; } = null!;

    }
}
