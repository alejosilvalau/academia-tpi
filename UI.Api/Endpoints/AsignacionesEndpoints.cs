using Dominio;
using Servicios;

namespace UI.Api.Endpoints
{
    public static class AsignacionesEndpoints
    {
        public static IEndpointRouteBuilder MapAsignacionesEndpoints(this IEndpointRouteBuilder app)
        {
            MapDocentesCursos(app);
            MapInscripciones(app);
            return app;
        }

        private static void MapDocentesCursos(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/docentes-cursos").WithTags("DocenteCurso").RequireAuthorization();

            g.MapGet("", (DocenteCursoServicio s) => s.GetAll());
            g.MapGet("/{id:int}", (int id, DocenteCursoServicio s) =>
                s.GetOne(id) is DocenteCurso d ? Results.Ok(d) : Results.NotFound());
            g.MapGet("/por-docente/{docenteId:int}", (int docenteId, DocenteCursoServicio s) => s.GetByDocente(docenteId));
            g.MapGet("/por-curso/{cursoId:int}", (int cursoId, DocenteCursoServicio s) => s.GetByCurso(cursoId));
            g.MapPost("/asignar", (int docenteId, int cursoId, DocenteCurso.TiposCargos cargo, DocenteCursoServicio s) =>
            {
                s.AsignarDocente(docenteId, cursoId, cargo);
                return Results.NoContent();
            });
            g.MapPut("/{id:int}", (int id, DocenteCurso cuerpo, DocenteCursoServicio s) =>
            {
                cuerpo.ID = id;
                s.Update(cuerpo);
                return Results.Ok(cuerpo);
            });
            g.MapDelete("/{id:int}", (int id, DocenteCursoServicio s) =>
            {
                var d = s.GetOne(id);
                if (d == null) return Results.NotFound();
                s.Delete(d);
                return Results.NoContent();
            });
        }

        private static void MapInscripciones(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/inscripciones").WithTags("Inscripciones").RequireAuthorization();

            g.MapGet("", (InscripcionServicio s) => s.GetAll());
            g.MapGet("/{id:int}", (int id, InscripcionServicio s) =>
                s.GetOne(id) is AlumnoInscripcion a ? Results.Ok(a) : Results.NotFound());
            g.MapGet("/por-alumno/{alumnoId:int}", (int alumnoId, InscripcionServicio s) => s.GetByAlumno(alumnoId));
            g.MapGet("/por-curso/{cursoId:int}", (int cursoId, InscripcionServicio s) => s.GetByCurso(cursoId));
            g.MapPost("/inscribir", (int alumnoId, int cursoId, InscripcionServicio s) =>
            {
                s.InscribirAlumno(alumnoId, cursoId);
                return Results.NoContent();
            });
            g.MapPut("/{id:int}", (int id, AlumnoInscripcion cuerpo, InscripcionServicio s) =>
            {
                cuerpo.ID = id;
                s.Update(cuerpo);
                return Results.Ok(cuerpo);
            });
            g.MapDelete("/{id:int}", (int id, InscripcionServicio s) =>
            {
                var a = s.GetOne(id);
                if (a == null) return Results.NotFound();
                s.Delete(a);
                return Results.NoContent();
            });
        }
    }
}