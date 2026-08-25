using Dominio;
using Servicios;

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

            g.MapGet("", (EspecialidadServicio s) => s.GetAll());
            g.MapGet("/{id:int}", (int id, EspecialidadServicio s) =>
                s.GetOne(id) is Especialidad e ? Results.Ok(e) : Results.NotFound());
            g.MapPost("", (Especialidad cuerpo, EspecialidadServicio s) =>
            {
                s.Save(cuerpo);
                return Results.Ok(cuerpo);
            });
            g.MapPut("/{id:int}", (int id, Especialidad cuerpo, EspecialidadServicio s) =>
            {
                cuerpo.ID = id;
                s.Update(cuerpo);
                return Results.Ok(cuerpo);
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

            g.MapGet("", (PlanServicio s) => s.GetAll());
            g.MapGet("/{id:int}", (int id, PlanServicio s) =>
                s.GetOne(id) is Plan p ? Results.Ok(p) : Results.NotFound());
            g.MapGet("/por-especialidad/{especialidadId:int}", (int especialidadId, PlanServicio s) => s.GetByEspecialidad(especialidadId));
            g.MapPost("", (Plan cuerpo, PlanServicio s) =>
            {
                s.Save(cuerpo);
                return Results.Ok(cuerpo);
            });
            g.MapPut("/{id:int}", (int id, Plan cuerpo, PlanServicio s) =>
            {
                cuerpo.ID = id;
                s.Update(cuerpo);
                return Results.Ok(cuerpo);
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

            g.MapGet("", (MateriaServicio s) => s.GetAll());
            g.MapGet("/{id:int}", (int id, MateriaServicio s) =>
                s.GetOne(id) is Materia m ? Results.Ok(m) : Results.NotFound());
            g.MapGet("/por-plan/{planId:int}", (int planId, MateriaServicio s) => s.GetByPlan(planId));
            g.MapPost("", (Materia cuerpo, MateriaServicio s) =>
            {
                s.Save(cuerpo);
                return Results.Ok(cuerpo);
            });
            g.MapPut("/{id:int}", (int id, Materia cuerpo, MateriaServicio s) =>
            {
                cuerpo.ID = id;
                s.Update(cuerpo);
                return Results.Ok(cuerpo);
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

            g.MapGet("", (ComisionServicio s) => s.GetAll());
            g.MapGet("/{id:int}", (int id, ComisionServicio s) =>
                s.GetOne(id) is Comision c ? Results.Ok(c) : Results.NotFound());
            g.MapGet("/por-plan/{planId:int}", (int planId, ComisionServicio s) => s.GetByPlan(planId));
            g.MapPost("", (Comision cuerpo, ComisionServicio s) =>
            {
                s.Save(cuerpo);
                return Results.Ok(cuerpo);
            });
            g.MapPut("/{id:int}", (int id, Comision cuerpo, ComisionServicio s) =>
            {
                cuerpo.ID = id;
                s.Update(cuerpo);
                return Results.Ok(cuerpo);
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

            g.MapGet("", (CursoServicio s) => s.GetAll());
            g.MapGet("/{id:int}", (int id, CursoServicio s) =>
                s.GetOne(id) is Curso c ? Results.Ok(c) : Results.NotFound());
            g.MapGet("/por-materia-comision", (int materiaId, int comisionId, CursoServicio s) =>
                s.GetByMateriaYComision(materiaId, comisionId));
            g.MapPost("", (Curso cuerpo, CursoServicio s) =>
            {
                s.Save(cuerpo);
                return Results.Ok(cuerpo);
            });
            g.MapPut("/{id:int}", (int id, Curso cuerpo, CursoServicio s) =>
            {
                cuerpo.ID = id;
                s.Update(cuerpo);
                return Results.Ok(cuerpo);
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