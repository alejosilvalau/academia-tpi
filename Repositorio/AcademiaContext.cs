using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Repositorio
{
    public class AcademiaContext : DbContext
    {
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Comision> Comisiones { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DocenteCurso> DocenteCursos { get; set; }
        public DbSet<AlumnoInscripcion> AlumnoInscripciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Academia;TrustServerCertificate=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plan>(entity =>
            {
                entity.Metadata.FindNavigation(nameof(Plan.Especialidad))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.HasOne(p => p.Especialidad).WithMany()
                    .HasForeignKey(p => p.EspecialidadId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.Metadata.FindNavigation(nameof(Materia.Plan))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.HasOne(m => m.Plan).WithMany()
                    .HasForeignKey(m => m.PlanId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Comision>(entity =>
            {
                entity.Metadata.FindNavigation(nameof(Comision.Plan))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.HasOne(c => c.Plan).WithMany()
                    .HasForeignKey(c => c.PlanId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Ignore(c => c.Descripcion);

                entity.Metadata.FindNavigation(nameof(Curso.Materia))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.Metadata.FindNavigation(nameof(Curso.Comision))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.HasOne(c => c.Materia).WithMany()
                    .HasForeignKey(c => c.MateriaId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(c => c.Comision).WithMany()
                    .HasForeignKey(c => c.ComisionId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Ignore(p => p.NombreCompleto);

                entity.Metadata.FindNavigation(nameof(Persona.Plan))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.HasOne(p => p.Plan).WithMany()
                    .HasForeignKey(p => p.PlanId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Ignore(u => u.PersonaNombre);
                entity.Ignore(u => u.PersonaApellido);
                entity.Ignore(u => u.PersonaEMail);

                entity.Metadata.FindNavigation(nameof(Usuario.Persona))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.HasOne(u => u.Persona).WithMany()
                    .HasForeignKey(u => u.PersonaId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<DocenteCurso>(entity =>
            {
                entity.Metadata.FindNavigation(nameof(DocenteCurso.Curso))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.Metadata.FindNavigation(nameof(DocenteCurso.Docente))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.HasOne(dc => dc.Curso).WithMany()
                    .HasForeignKey(dc => dc.CursoId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(dc => dc.Docente).WithMany()
                    .HasForeignKey(dc => dc.DocenteId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<AlumnoInscripcion>(entity =>
            {
                entity.Ignore(ai => ai.DescripcionMateria);
                entity.Ignore(ai => ai.Legajo);
                entity.Ignore(ai => ai.Nombre);
                entity.Ignore(ai => ai.Apellido);
                entity.Ignore(ai => ai.DescripcionComision);
                entity.HasOne(ai => ai.Alumno).WithMany()
                    .HasForeignKey(ai => ai.AlumnoId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(ai => ai.Curso).WithMany()
                    .HasForeignKey(ai => ai.CursoId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Especialidad>().HasData(
                new Especialidad { ID = 1, Descripcion = "Ingeniería en Sistemas" },
                new Especialidad { ID = 2, Descripcion = "Ingeniería Industrial" },
                new Especialidad { ID = 3, Descripcion = "Ciencias de la Computación" },
                new Especialidad { ID = 4, Descripcion = "Licenciatura en Administración" },
                new Especialidad { ID = 5, Descripcion = "Ingeniería Química" }
            );

            modelBuilder.Entity<Plan>().HasData(
                new Plan { ID = 1, Descripcion = "Plan 2015", EspecialidadId = 1 },
                new Plan { ID = 2, Descripcion = "Plan 2020", EspecialidadId = 1 },
                new Plan { ID = 3, Descripcion = "Plan 2018", EspecialidadId = 2 },
                new Plan { ID = 4, Descripcion = "Plan 2015", EspecialidadId = 3 },
                new Plan { ID = 5, Descripcion = "Plan 2022", EspecialidadId = 3 },
                new Plan { ID = 6, Descripcion = "Plan 2019", EspecialidadId = 4 },
                new Plan { ID = 7, Descripcion = "Plan 2016", EspecialidadId = 5 },
                new Plan { ID = 8, Descripcion = "Plan 2021", EspecialidadId = 5 }
            );

            modelBuilder.Entity<Comision>().HasData(
                new Comision { ID = 1, Descripcion = "1A", AnioEspecialidad = 1, PlanId = 2 },
                new Comision { ID = 2, Descripcion = "2B", AnioEspecialidad = 2, PlanId = 2 },
                new Comision { ID = 3, Descripcion = "3C", AnioEspecialidad = 3, PlanId = 2 },
                new Comision { ID = 4, Descripcion = "1A", AnioEspecialidad = 1, PlanId = 1 },
                new Comision { ID = 5, Descripcion = "2A", AnioEspecialidad = 2, PlanId = 2 },
                new Comision { ID = 6, Descripcion = "4B", AnioEspecialidad = 4, PlanId = 2 },
                new Comision { ID = 7, Descripcion = "5A", AnioEspecialidad = 5, PlanId = 2 },
                new Comision { ID = 8, Descripcion = "4A", AnioEspecialidad = 4, PlanId = 1 },
                new Comision { ID = 9, Descripcion = "1B", AnioEspecialidad = 1, PlanId = 4 },
                new Comision { ID = 10, Descripcion = "2A", AnioEspecialidad = 2, PlanId = 5 },
                new Comision { ID = 11, Descripcion = "1A", AnioEspecialidad = 1, PlanId = 6 },
                new Comision { ID = 12, Descripcion = "1B", AnioEspecialidad = 1, PlanId = 7 }
            );

            modelBuilder.Entity<Materia>().HasData(
                new Materia { ID = 1, Descripcion = "Programación I", HorasSemanales = 4, HorasTotales = 64, PlanId = 2 },
                new Materia { ID = 2, Descripcion = "Análisis de Sistemas", HorasSemanales = 3, HorasTotales = 48, PlanId = 2 },
                new Materia { ID = 3, Descripcion = "Algebra Lineal", HorasSemanales = 4, HorasTotales = 64, PlanId = 1 },
                new Materia { ID = 4, Descripcion = "Física I", HorasSemanales = 4, HorasTotales = 64, PlanId = 2 },
                new Materia { ID = 5, Descripcion = "Base de Datos", HorasSemanales = 3, HorasTotales = 48, PlanId = 2 },
                new Materia { ID = 6, Descripcion = "Estadística", HorasSemanales = 3, HorasTotales = 48, PlanId = 2 },
                new Materia { ID = 7, Descripcion = "Redes de Computadoras", HorasSemanales = 3, HorasTotales = 48, PlanId = 2 },
                new Materia { ID = 8, Descripcion = "Cálculo I", HorasSemanales = 4, HorasTotales = 64, PlanId = 4 },
                new Materia { ID = 9, Descripcion = "Química General", HorasSemanales = 3, HorasTotales = 48, PlanId = 8 },
                new Materia { ID = 10, Descripcion = "Microeconomía", HorasSemanales = 3, HorasTotales = 48, PlanId = 6 },
                new Materia { ID = 11, Descripcion = "Termodinámica", HorasSemanales = 4, HorasTotales = 64, PlanId = 7 },
                new Materia { ID = 12, Descripcion = "Contabilidad", HorasSemanales = 3, HorasTotales = 48, PlanId = 6 }
            );

            modelBuilder.Entity<Curso>().HasData(
                new Curso { ID = 1, AnioCalendario = 2024, Cupo = 35, MateriaId = 1, ComisionId = 1 },
                new Curso { ID = 2, AnioCalendario = 2024, Cupo = 30, MateriaId = 2, ComisionId = 3 },
                new Curso { ID = 3, AnioCalendario = 2024, Cupo = 40, MateriaId = 3, ComisionId = 2 },
                new Curso { ID = 4, AnioCalendario = 2024, Cupo = 35, MateriaId = 4, ComisionId = 5 },
                new Curso { ID = 5, AnioCalendario = 2024, Cupo = 30, MateriaId = 5, ComisionId = 4 },
                new Curso { ID = 6, AnioCalendario = 2024, Cupo = 35, MateriaId = 6, ComisionId = 10 },
                new Curso { ID = 7, AnioCalendario = 2024, Cupo = 25, MateriaId = 7, ComisionId = 3 },
                new Curso { ID = 8, AnioCalendario = 2024, Cupo = 40, MateriaId = 8, ComisionId = 9 },
                new Curso { ID = 9, AnioCalendario = 2024, Cupo = 30, MateriaId = 9, ComisionId = 12 },
                new Curso { ID = 10, AnioCalendario = 2024, Cupo = 45, MateriaId = 10, ComisionId = 11 }
            );

            modelBuilder.Entity<Persona>().HasData(
                new Persona { ID = 1, Nombre = "Luciano", Apellido = "Ferreyra", Legajo = 10000, EMail = "lferreyra@academia.com", Direccion = "San Martin 1250", Telefono = "291-4567890", FechaNacimiento = new DateTime(1988, 3, 15), Tipo = Persona.TiposPersonas.Administrador, PlanId = null },
                new Persona { ID = 2, Nombre = "Valentina", Apellido = "Ríos", Legajo = 10001, EMail = "vrios@academia.com", Direccion = "Belgrano 890", Telefono = "291-5551234", FechaNacimiento = new DateTime(1990, 7, 22), Tipo = Persona.TiposPersonas.Docente, PlanId = null },
                new Persona { ID = 3, Nombre = "Matías", Apellido = "Herrera", Legajo = 10002, EMail = "mherrera@academia.com", Direccion = "Rivadavia 2340", Telefono = "291-6667890", FechaNacimiento = new DateTime(1985, 11, 8), Tipo = Persona.TiposPersonas.Docente, PlanId = null },
                new Persona { ID = 4, Nombre = "Camila", Apellido = "López", Legajo = 48102, EMail = "clopez@alumnos.edu", Direccion = "Uruguay 1450", Telefono = "291-7771234", FechaNacimiento = new DateTime(2002, 4, 12), Tipo = Persona.TiposPersonas.Alumno, PlanId = 2 },
                new Persona { ID = 5, Nombre = "Tomás", Apellido = "Giménez", Legajo = 48230, EMail = "tgimenez@alumnos.edu", Direccion = "Mitre 560", Telefono = "291-8885678", FechaNacimiento = new DateTime(2001, 9, 3), Tipo = Persona.TiposPersonas.Alumno, PlanId = 2 },
                new Persona { ID = 6, Nombre = "Isidora", Apellido = "Castro", Legajo = 48315, EMail = "icastro@alumnos.edu", Direccion = "Sarmiento 1820", Telefono = "291-9993210", FechaNacimiento = new DateTime(2003, 1, 27), Tipo = Persona.TiposPersonas.Alumno, PlanId = 2 },
                new Persona { ID = 7, Nombre = "Benjamín", Apellido = "Morales", Legajo = 48401, EMail = "bmorales@alumnos.edu", Direccion = "Dorrego 970", Telefono = "291-1114567", FechaNacimiento = new DateTime(2000, 12, 14), Tipo = Persona.TiposPersonas.Alumno, PlanId = 1 },
                new Persona { ID = 8, Nombre = "Antonella", Apellido = "Vega", Legajo = 48520, EMail = "avega@alumnos.edu", Direccion = "Pellegrini 3210", Telefono = "291-2228901", FechaNacimiento = new DateTime(2002, 6, 30), Tipo = Persona.TiposPersonas.Alumno, PlanId = 4 },
                new Persona { ID = 9, Nombre = "Dante", Apellido = "Romero", Legajo = 48610, EMail = "dromero@alumnos.edu", Direccion = "Entre Rios 1560", Telefono = "291-3336789", FechaNacimiento = new DateTime(2001, 2, 18), Tipo = Persona.TiposPersonas.Alumno, PlanId = 5 },
                new Persona { ID = 10, Nombre = "Florencia", Apellido = "Acosta", Legajo = 10003, EMail = "facosta@academia.com", Direccion = "Mendoza 2100", Telefono = "291-4442345", FechaNacimiento = new DateTime(1992, 8, 5), Tipo = Persona.TiposPersonas.Docente, PlanId = null },
                new Persona { ID = 11, Nombre = "Nicolás", Apellido = "Medina", Legajo = 10004, EMail = "nmedina@academia.com", Direccion = "Junin 780", Telefono = "291-5559012", FechaNacimiento = new DateTime(1987, 5, 20), Tipo = Persona.TiposPersonas.Docente, PlanId = null },
                new Persona { ID = 12, Nombre = "Emilia", Apellido = "Silva", Legajo = 48705, EMail = "esilva@alumnos.edu", Direccion = "La Rioja 1890", Telefono = "291-6663456", FechaNacimiento = new DateTime(2003, 10, 9), Tipo = Persona.TiposPersonas.Alumno, PlanId = 6 },
                new Persona { ID = 13, Nombre = "Santiago", Apellido = "Pereyra", Legajo = 48812, EMail = "spereyra@alumnos.edu", Direccion = "Catamarca 430", Telefono = "291-7777890", FechaNacimiento = new DateTime(2000, 7, 25), Tipo = Persona.TiposPersonas.Alumno, PlanId = 7 }
            );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { ID = 1, NombreUsuario = "lferreyra", Clave = "admin123", Habilitado = true, PersonaId = 1 },
                new Usuario { ID = 2, NombreUsuario = "vrios", Clave = "doc2024", Habilitado = true, PersonaId = 2 },
                new Usuario { ID = 3, NombreUsuario = "mherrera", Clave = "doc2024", Habilitado = true, PersonaId = 3 },
                new Usuario { ID = 4, NombreUsuario = "clopez", Clave = "alu2024", Habilitado = true, PersonaId = 4 },
                new Usuario { ID = 5, NombreUsuario = "tgimenez", Clave = "alu2024", Habilitado = true, PersonaId = 5 },
                new Usuario { ID = 6, NombreUsuario = "icastro", Clave = "alu2024", Habilitado = true, PersonaId = 6 },
                new Usuario { ID = 7, NombreUsuario = "bmorales", Clave = "alu2024", Habilitado = true, PersonaId = 7 },
                new Usuario { ID = 8, NombreUsuario = "avega", Clave = "alu2024", Habilitado = true, PersonaId = 8 },
                new Usuario { ID = 9, NombreUsuario = "dromero", Clave = "alu2024", Habilitado = true, PersonaId = 9 },
                new Usuario { ID = 10, NombreUsuario = "facosta", Clave = "doc2024", Habilitado = true, PersonaId = 10 },
                new Usuario { ID = 11, NombreUsuario = "nmedina", Clave = "doc2024", Habilitado = true, PersonaId = 11 },
                new Usuario { ID = 12, NombreUsuario = "esilva", Clave = "alu2024", Habilitado = true, PersonaId = 12 }
            );

            modelBuilder.Entity<DocenteCurso>().HasData(
                new DocenteCurso { ID = 1, CursoId = 1, DocenteId = 2, Cargo = DocenteCurso.TiposCargos.Profesor },
                new DocenteCurso { ID = 2, CursoId = 5, DocenteId = 2, Cargo = DocenteCurso.TiposCargos.JefeDeCatedra },
                new DocenteCurso { ID = 3, CursoId = 2, DocenteId = 3, Cargo = DocenteCurso.TiposCargos.Profesor },
                new DocenteCurso { ID = 4, CursoId = 3, DocenteId = 10, Cargo = DocenteCurso.TiposCargos.Auxiliar },
                new DocenteCurso { ID = 5, CursoId = 9, DocenteId = 11, Cargo = DocenteCurso.TiposCargos.Profesor },
                new DocenteCurso { ID = 6, CursoId = 10, DocenteId = 11, Cargo = DocenteCurso.TiposCargos.JefeDeCatedra }
            );

            modelBuilder.Entity<AlumnoInscripcion>().HasData(
                new AlumnoInscripcion { ID = 1, AlumnoId = 4, CursoId = 1, Condicion = AlumnoInscripcion.Condiciones.Aprobado, Nota = 8 },
                new AlumnoInscripcion { ID = 2, AlumnoId = 4, CursoId = 3, Condicion = AlumnoInscripcion.Condiciones.Regular, Nota = 5 },
                new AlumnoInscripcion { ID = 3, AlumnoId = 5, CursoId = 1, Condicion = AlumnoInscripcion.Condiciones.Aprobado, Nota = 9 },
                new AlumnoInscripcion { ID = 4, AlumnoId = 5, CursoId = 2, Condicion = AlumnoInscripcion.Condiciones.Inscripto, Nota = null },
                new AlumnoInscripcion { ID = 5, AlumnoId = 6, CursoId = 5, Condicion = AlumnoInscripcion.Condiciones.Aprobado, Nota = 7 },
                new AlumnoInscripcion { ID = 6, AlumnoId = 6, CursoId = 6, Condicion = AlumnoInscripcion.Condiciones.Regular, Nota = 4 },
                new AlumnoInscripcion { ID = 7, AlumnoId = 7, CursoId = 3, Condicion = AlumnoInscripcion.Condiciones.Aprobado, Nota = 10 },
                new AlumnoInscripcion { ID = 8, AlumnoId = 7, CursoId = 4, Condicion = AlumnoInscripcion.Condiciones.Aprobado, Nota = 6 },
                new AlumnoInscripcion { ID = 9, AlumnoId = 8, CursoId = 8, Condicion = AlumnoInscripcion.Condiciones.Aprobado, Nota = 8 },
                new AlumnoInscripcion { ID = 10, AlumnoId = 8, CursoId = 6, Condicion = AlumnoInscripcion.Condiciones.Inscripto, Nota = null },
                new AlumnoInscripcion { ID = 11, AlumnoId = 9, CursoId = 8, Condicion = AlumnoInscripcion.Condiciones.Regular, Nota = 5 },
                new AlumnoInscripcion { ID = 12, AlumnoId = 9, CursoId = 10, Condicion = AlumnoInscripcion.Condiciones.Aprobado, Nota = 7 },
                new AlumnoInscripcion { ID = 13, AlumnoId = 12, CursoId = 10, Condicion = AlumnoInscripcion.Condiciones.Aprobado, Nota = 9 },
                new AlumnoInscripcion { ID = 14, AlumnoId = 12, CursoId = 7, Condicion = AlumnoInscripcion.Condiciones.Inscripto, Nota = null },
                new AlumnoInscripcion { ID = 15, AlumnoId = 13, CursoId = 9, Condicion = AlumnoInscripcion.Condiciones.Aprobado, Nota = 6 }
            );
        }
    }
}
