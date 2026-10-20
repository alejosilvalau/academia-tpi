using Contratos;
using Dominio;
using Servicios;
using UI.Api.Mapping;

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

            g.MapGet("", (DocenteCursoServicio s) => Results.Ok(s.GetAll().Select(d => d.ADto()).ToList()));
            g.MapGet("/{id:int}", (int id, DocenteCursoServicio s) =>
                s.GetOne(id) is DocenteCurso d ? Results.Ok(d.ADto()) : Results.NotFound());
            g.MapGet("/por-docente/{docenteId:int}", (int docenteId, DocenteCursoServicio s) =>
                Results.Ok(s.GetByDocente(docenteId).Select(d => d.ADto()).ToList()));
            g.MapGet("/por-curso/{cursoId:int}", (int cursoId, DocenteCursoServicio s) =>
                Results.Ok(s.GetByCurso(cursoId).Select(d => d.ADto()).ToList()));
            g.MapPost("/asignar", (AsignarDocenteRequest cuerpo, DocenteCursoServicio s) =>
            {
                s.AsignarDocente(cuerpo.DocenteId, cuerpo.CursoId, cuerpo.Cargo);
                return Results.NoContent();
            });
            g.MapPut("/{id:int}", (int id, DocenteCursoRequest cuerpo, DocenteCursoServicio s) =>
            {
                var entidad = s.GetOne(id);
                if (entidad == null) return Results.NotFound();
                cuerpo.Aplicar(entidad);
                s.Update(entidad);
                return Results.Ok(entidad.ADto());
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

            g.MapGet("", (InscripcionServicio s) => Results.Ok(s.GetAll().Select(a => a.ADto()).ToList()));
            g.MapGet("/{id:int}", (int id, InscripcionServicio s) =>
                s.GetOne(id) is AlumnoInscripcion a ? Results.Ok(a.ADto()) : Results.NotFound());
            g.MapGet("/por-alumno/{alumnoId:int}", (int alumnoId, InscripcionServicio s) =>
                Results.Ok(s.GetByAlumno(alumnoId).Select(a => a.ADto()).ToList()));
            g.MapGet("/por-curso/{cursoId:int}", (int cursoId, InscripcionServicio s) =>
                Results.Ok(s.GetByCurso(cursoId).Select(a => a.ADto()).ToList()));
            g.MapPost("/inscribir", (InscribirRequest cuerpo, InscripcionServicio s) =>
            {
                s.InscribirAlumno(cuerpo.AlumnoId, cuerpo.CursoId);
                return Results.NoContent();
            });
            g.MapPut("/{id:int}", (int id, InscripcionRequest cuerpo, InscripcionServicio s) =>
            {
                var entidad = s.GetOne(id);
                if (entidad == null) return Results.NotFound();
                cuerpo.Aplicar(entidad);
                s.Update(entidad);
                return Results.Ok(entidad.ADto());
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
