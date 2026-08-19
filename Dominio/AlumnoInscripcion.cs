using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    [Table("AlumnoInscripciones")]
    public class AlumnoInscripcion : BusinessEntity
    {
        public AlumnoInscripcion()
        {
            Condicion = Condiciones.Inscripto;
        }

        public Condiciones Condicion { get; set; }
        public int? Nota { get; set; }

        [ForeignKey("Alumno")]
        public int AlumnoId { get; set; }
        public virtual Persona Alumno { get; set; } = null!;

        [ForeignKey("Curso")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; } = null!;

        [NotMapped]
        public string DescripcionMateria
        {
            get
            {
                return $"{Curso.Materia}";
            }
        }

        [NotMapped]
        public int? Legajo
        {
            get
            {
                return Alumno.Legajo;
            }
        }

        [NotMapped]
        public string Nombre
        {
            get
            {
                return Alumno.Nombre;
            }
        }

        [NotMapped]
        public string Apellido
        {
            get
            {
                return Alumno.Apellido;
            }
        }

        [NotMapped]
        public string DescripcionComision
        {
            get
            {
                return $"{Curso.Comision}";
            }
        }

        public enum Condiciones
        {
            Inscripto,
            Regular,
            Aprobado
        }
    }
}
