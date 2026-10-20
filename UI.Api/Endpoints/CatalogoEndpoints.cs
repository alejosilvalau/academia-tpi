using Contratos;
using Dominio;
using Servicios;
using UI.Api.Mapping;

namespace UI.Api.Endpoints
{
    public static class CatalogoEndpoints
    {
        public static IEndpointRouteBuilder MapCatalogoEndpoints(this IEndpointRouteBuilder app)
        {
            MapEspecialidades(app);
            MapPlanes(app);
            MapMaterias(app);
            MapComisiones(app);
            MapCursos(app);
            return app;
        }

        private static void MapEspecialidades(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/especialidades").WithTags("Especialidades").RequireAuthorization();

            g.MapGet("", (EspecialidadServicio s) => Results.Ok(s.GetAll().Select(e => e.ADto()).ToList()));
            g.MapGet("/{id:int}", (int id, EspecialidadServicio s) =>
                s.GetOne(id) is Especialidad e ? Results.Ok(e.ADto()) : Results.NotFound());
            g.MapPost("", (EspecialidadRequest cuerpo, EspecialidadServicio s) =>
            {
                var entidad = cuerpo.AEntidad();
                s.Save(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapPut("/{id:int}", (int id, EspecialidadRequest cuerpo, EspecialidadServicio s) =>
            {
                var entidad = s.GetOne(id);
                if (entidad == null) return Results.NotFound();
                cuerpo.Aplicar(entidad);
                s.Update(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapDelete("/{id:int}", (int id, EspecialidadServicio s) =>
            {
                var e = s.GetOne(id);
                if (e == null) return Results.NotFound();
                s.Delete(e);
                return Results.NoContent();
            });
        }

        private static void MapPlanes(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/planes").WithTags("Planes").RequireAuthorization();

            g.MapGet("", (PlanServicio s) => Results.Ok(s.GetAll().Select(p => p.ADto()).ToList()));
            g.MapGet("/{id:int}", (int id, PlanServicio s) =>
                s.GetOne(id) is Plan p ? Results.Ok(p.ADto()) : Results.NotFound());
            g.MapGet("/por-especialidad/{especialidadId:int}", (int especialidadId, PlanServicio s) =>
                Results.Ok(s.GetByEspecialidad(especialidadId).Select(p => p.ADto()).ToList()));
            g.MapPost("", (PlanRequest cuerpo, PlanServicio s) =>
            {
                var entidad = cuerpo.AEntidad();
                s.Save(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapPut("/{id:int}", (int id, PlanRequest cuerpo, PlanServicio s) =>
            {
                var entidad = s.GetOne(id);
                if (entidad == null) return Results.NotFound();
                cuerpo.Aplicar(entidad);
                s.Update(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapDelete("/{id:int}", (int id, PlanServicio s) =>
            {
                var p = s.GetOne(id);
                if (p == null) return Results.NotFound();
                s.Delete(p);
                return Results.NoContent();
            });
        }

        private static void MapMaterias(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/materias").WithTags("Materias").RequireAuthorization();

            g.MapGet("", (MateriaServicio s) => Results.Ok(s.GetAll().Select(m => m.ADto()).ToList()));
            g.MapGet("/{id:int}", (int id, MateriaServicio s) =>
                s.GetOne(id) is Materia m ? Results.Ok(m.ADto()) : Results.NotFound());
            g.MapGet("/por-plan/{planId:int}", (int planId, MateriaServicio s) =>
                Results.Ok(s.GetByPlan(planId).Select(m => m.ADto()).ToList()));
            g.MapPost("", (MateriaRequest cuerpo, MateriaServicio s) =>
            {
                var entidad = cuerpo.AEntidad();
                s.Save(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapPut("/{id:int}", (int id, MateriaRequest cuerpo, MateriaServicio s) =>
            {
                var entidad = s.GetOne(id);
                if (entidad == null) return Results.NotFound();
                cuerpo.Aplicar(entidad);
                s.Update(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapDelete("/{id:int}", (int id, MateriaServicio s) =>
            {
                var m = s.GetOne(id);
                if (m == null) return Results.NotFound();
                s.Delete(m);
                return Results.NoContent();
            });
        }

        private static void MapComisiones(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/comisiones").WithTags("Comisiones").RequireAuthorization();

            g.MapGet("", (ComisionServicio s) => Results.Ok(s.GetAll().Select(c => c.ADto()).ToList()));
            g.MapGet("/{id:int}", (int id, ComisionServicio s) =>
                s.GetOne(id) is Comision c ? Results.Ok(c.ADto()) : Results.NotFound());
            g.MapGet("/por-plan/{planId:int}", (int planId, ComisionServicio s) =>
                Results.Ok(s.GetByPlan(planId).Select(c => c.ADto()).ToList()));
            g.MapPost("", (ComisionRequest cuerpo, ComisionServicio s) =>
            {
                var entidad = cuerpo.AEntidad();
                s.Save(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapPut("/{id:int}", (int id, ComisionRequest cuerpo, ComisionServicio s) =>
            {
                var entidad = s.GetOne(id);
                if (entidad == null) return Results.NotFound();
                cuerpo.Aplicar(entidad);
                s.Update(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapDelete("/{id:int}", (int id, ComisionServicio s) =>
            {
                var c = s.GetOne(id);
                if (c == null) return Results.NotFound();
                s.Delete(c);
                return Results.NoContent();
            });
        }

        private static void MapCursos(IEndpointRouteBuilder app)
        {
            var g = app.MapGroup("/api/cursos").WithTags("Cursos").RequireAuthorization();

            g.MapGet("", (CursoServicio s) => Results.Ok(s.GetAll().Select(c => c.ADto()).ToList()));
            g.MapGet("/{id:int}", (int id, CursoServicio s) =>
                s.GetOne(id) is Curso c ? Results.Ok(c.ADto()) : Results.NotFound());
            g.MapGet("/por-materia-comision", (int materiaId, int comisionId, CursoServicio s) =>
                Results.Ok(s.GetByMateriaYComision(materiaId, comisionId).Select(c => c.ADto()).ToList()));
            g.MapPost("", (CursoRequest cuerpo, CursoServicio s) =>
            {
                var entidad = cuerpo.AEntidad();
                s.Save(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapPut("/{id:int}", (int id, CursoRequest cuerpo, CursoServicio s) =>
            {
                var entidad = s.GetOne(id);
                if (entidad == null) return Results.NotFound();
                cuerpo.Aplicar(entidad);
                s.Update(entidad);
                return Results.Ok(entidad.ADto());
            });
            g.MapDelete("/{id:int}", (int id, CursoServicio s) =>
            {
                var c = s.GetOne(id);
                if (c == null) return Results.NotFound();
                s.Delete(c);
                return Results.NoContent();
            });
        }
    }
}
