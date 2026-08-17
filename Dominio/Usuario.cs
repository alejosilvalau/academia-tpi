using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Usuarios")]
    public class Usuario : BusinessEntity
    {
        [StringLength(100)]
        public string NombreUsuario { get; set; }
        [StringLength(100)]
        public string Clave { get; set; }
        public bool Habilitado { get; set; }

        [ForeignKey("Persona")]
        public int? PersonaId { get; set; }
        private Persona _persona;
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

        [NotMapped]
        public string PersonaNombre
        {
            get
            {
                return Persona?.Nombre ?? "-";
            }
        }

        [NotMapped]
        public string PersonaApellido
        {
            get
            {
                return Persona?.Apellido ?? "-";
            }
        }

        [NotMapped]
        public string PersonaEMail
        {
            get
            {
                return Persona?.EMail ?? "-";
            }
        }
    }
}
