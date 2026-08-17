using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("Cursos")]
    public class Curso : BusinessEntity
    {
        public int AnioCalendario { get; set; }
        public int Cupo { get; set; }

        [NotMapped]
        public string Descripcion
        {
            get
            {
                return $"{Materia} - {Comision} - {AnioCalendario}";
            }
        }

        [ForeignKey("Materia")]
        public int MateriaId { get; set; }
        private Materia _materia;
        public virtual Materia Materia
        {
            get
            {
                return _materia;
            }
            set
            {
                if (value != null)
                {
                    _materia = value;
                    MateriaId = value.ID;
                }
            }
        }

        [ForeignKey("Comision")]
        public int ComisionId { get; set; }
        private Comision _comision;
        public virtual Comision Comision
        {
            get
            {
                return _comision;
            }
            set
            {
                if (value != null)
                {
                    _comision = value;
                    ComisionId = value.ID;
                }
            }
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
