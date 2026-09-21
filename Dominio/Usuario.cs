using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Usuario")]
    public class Usuario : BusinessEntity
    {
        [StringLength(100)]
        public string NombreUsuario { get; set; } = null!;
        [StringLength(100)]
        public string Clave { get; set; } = null!;
        public bool Habilitado { get; set; }

        [ForeignKey("Persona")]
        public int? PersonaId { get; set; }
        private Persona _persona = null!;
        public virtual Persona Persona
        {
            get
            {
                return _persona;
            }
            set
            {
                _persona = value;
                if (value == null)
                {
                    PersonaId = null;
                }
                else
                {
                    PersonaId = value.ID;
                }
            }
        }

    }
}
