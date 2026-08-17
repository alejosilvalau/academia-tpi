namespace Dominio
{
    public class DocenteCurso : BusinessEntity
    {
        public TiposCargos Cargo { get; set; }

        public int CursoId { get; set; }
        private Curso _curso;
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

        public int DocenteId { get; set; }
        private Persona _docente;
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
