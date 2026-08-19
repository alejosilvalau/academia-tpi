using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Dominio
{
    [Table("DocenteCursos")]
    public class DocenteCurso : BusinessEntity
    {
        public TiposCargos Cargo { get; set; }

        [NotMapped]
        public string CargoDisplay
        {
            get
            {
                var field = typeof(TiposCargos).GetField(Cargo.ToString());
                var attr = field?.GetCustomAttribute<DescriptionAttribute>();
                return attr?.Description ?? Cargo.ToString();
            }
        }

        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        private Curso _curso = null!;
        public virtual Curso Curso
        {
            get
            {
                return _curso;
            }
            set
            {
                if (value != null)
                {
                    _curso = value;
                    CursoId = value.ID;
                }
            }
        }

        [ForeignKey("Docente")]
        public int DocenteId { get; set; }
        private Persona _docente = null!;
        public virtual Persona Docente
        {
            get
            {
                return _docente;
            }
            set
            {
                if (value != null)
                {
                    _docente = value;
                    DocenteId = value.ID;
                }
            }
        }

        public enum TiposCargos
        {
            [Description("Profesor")]
            Profesor,
            [Description("Jefe De Cátedra")]
            JefeDeCatedra,
            [Description("Auxiliar")]
            Auxiliar
        }
    }
}
