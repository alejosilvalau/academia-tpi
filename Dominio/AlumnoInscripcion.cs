namespace Dominio
{
    public class AlumnoInscripcion : BusinessEntity
    {
        public AlumnoInscripcion()
        {
            Condicion = Condiciones.Inscripto;
        }

        public Condiciones Condicion { get; set; }
        public int? Nota { get; set; }

        public int AlumnoId { get; set; }
        public virtual Persona Alumno { get; set; }

        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }

        public string DescripcionMateria
        {
            get
            {
                return $"{Curso.Materia}";
            }
        }

        public int? Legajo
        {
            get
            {
                return Alumno.Legajo;
            }
        }

        public string Nombre
        {
            get
            {
                return Alumno.Nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return Alumno.Apellido;
            }
        }

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
