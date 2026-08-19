using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("DocenteCursos")]
    public class DocenteCurso : BusinessEntity
    {
        public TiposCargos Cargo { get; set; }

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
            Profesor,
            JefeDeCatedra,
            Auxiliar
        }
    }
}
