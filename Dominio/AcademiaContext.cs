using Microsoft.EntityFrameworkCore;

namespace Dominio
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
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AcademiaDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plan>(entity =>
            {
                entity.Metadata.FindNavigation(nameof(Plan.Especialidad))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
            });

            modelBuilder.Entity<Materia>(entity =>
            {
                entity.Metadata.FindNavigation(nameof(Materia.Plan))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
            });

            modelBuilder.Entity<Comision>(entity =>
            {
                entity.Metadata.FindNavigation(nameof(Comision.Plan))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Ignore(c => c.Descripcion);

                entity.Metadata.FindNavigation(nameof(Curso.Materia))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.Metadata.FindNavigation(nameof(Curso.Comision))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Ignore(p => p.NombreCompleto);

                entity.Metadata.FindNavigation(nameof(Persona.Plan))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Ignore(u => u.PersonaNombre);
                entity.Ignore(u => u.PersonaApellido);
                entity.Ignore(u => u.PersonaEMail);

                entity.Metadata.FindNavigation(nameof(Usuario.Persona))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
            });

            modelBuilder.Entity<DocenteCurso>(entity =>
            {
                entity.Metadata.FindNavigation(nameof(DocenteCurso.Curso))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
                entity.Metadata.FindNavigation(nameof(DocenteCurso.Docente))!
                    .SetPropertyAccessMode(PropertyAccessMode.Field);
            });

            modelBuilder.Entity<AlumnoInscripcion>(entity =>
            {
                entity.Ignore(ai => ai.DescripcionMateria);
                entity.Ignore(ai => ai.Legajo);
                entity.Ignore(ai => ai.Nombre);
                entity.Ignore(ai => ai.Apellido);
                entity.Ignore(ai => ai.DescripcionComision);
            });
        }
    }
}
